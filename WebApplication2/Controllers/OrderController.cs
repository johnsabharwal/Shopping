using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal.common;
using Dal.DTO;
using Dal.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        public JsonResult CreateNewOrder(CreateOrder createOrder)
        {
            if (ModelState.IsValid)
            {
                CreateOrderDTO cod = new CreateOrderDTO() { OrderDetails = createOrder.OrderDetails.Select(x => new Dal.DTO.OrderDetails() { ProductId = x.ProductId, Quanitity = x.Quanitity }).ToList(), PaymentMethod = createOrder.PaymentMethod, UserId = createOrder.UserId };
                var orderId = _orderService.CreateOrder(cod);
                if (orderId != 0)
                {
                    return new JsonResult(new Response()
                    {
                        Status = Dal.Enum.ResponseTypes.ok,
                        Data = new { OrderId = orderId }
                    });
                }
                else
                {
                    return new JsonResult(new Response()
                    {
                        Status = Dal.Enum.ResponseTypes.Error,
                        ErrorMessage = "Server Side Error"
                    });
                }
            }
            else
            {
                return new JsonResult(new Response()
                {
                    Status = Dal.Enum.ResponseTypes.invalid,
                    ErrorMessage = "Invalid Details"
                });
            }

        }
        [HttpGet]
        public JsonResult GetOrderDetail(int orderId)
        {
            var order = _orderService.GetOrderDetails(orderId);
            if (order != null)
                return new JsonResult(new Response()
                {
                    Status = Dal.Enum.ResponseTypes.ok,
                    Data = order
                });
            else
                return new JsonResult(new Response()
                {
                    Status = Dal.Enum.ResponseTypes.invalid,
                });
        }
    }
}