using Dal.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IOrderService
    {
        int CreateOrder(CreateOrderDTO createOrderDTO);
        OrderDetailDTO GetOrderDetails(int orderId);
    }
}
