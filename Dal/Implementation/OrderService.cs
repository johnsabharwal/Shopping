using Dal.DTO;
using Dal.Entities;
using Dal.Enum;
using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Implementation
{
    public class OrderService : IOrderService
    {
        DBContext dBContext;
        public OrderService(DBContext db)
        {
            dBContext = db;
        }
        public int CreateOrder(CreateOrderDTO createOrderDTO)
        {
            var products = createOrderDTO.OrderDetails.Select(x => x.ProductId).ToList();
            var order = new Order()
            {
                OrderDate = DateTime.Now,
                PaymentMethod = createOrderDTO.PaymentMethod,
                OrderStatus = OrderStatus.InProgress.ToString(),
                PaymentStatus = PaymentStatus.unPaid.ToString(),
                Total = dBContext.Product.Where(x => products.Contains(x.Id)).Select(x => x.Price * createOrderDTO.OrderDetails.Where(z => z.ProductId == x.Id).Select(z => z.Quanitity).First() + x.ShippingCost).Sum(),
                UserId = createOrderDTO.UserId,
            };
            dBContext.Order.Add(order);
            dBContext.SaveChanges();
            foreach (var item in createOrderDTO.OrderDetails)
            {
                var OrderDetails = new Entities.OrderDetails()
                {
                    OrderId = order.Id,
                    ProductId = item.ProductId,
                    Quantity = item.Quanitity,
                };
                dBContext.OrderDetails.Add(OrderDetails);
            }
            dBContext.SaveChanges();
            return order.Id;
        }

        public OrderDetailDTO GetOrderDetails(int orderId)
        {
            return dBContext.Order.Where(x => x.Id == orderId).Select(
                x => new OrderDetailDTO()
                {
                    OrderDate = x.OrderDate,
                    OrderStatus = x.OrderStatus,
                    PaymentMethod = x.PaymentMethod,
                    PaymentStatus = x.PaymentStatus,
                    Total = x.Total,
                    UserId = x.UserId,
                    Id = x.Id,
                    OrderDetails = x.OrderDetails.Select(y => new OrderDetailsDTO()
                    { ProductId = y.ProductId, Quantity = y.Quantity, OrderId = y.OrderId, ShippingCost = y.Product.ShippingCost }).ToList()
                }).FirstOrDefault();
        }
    }
}
