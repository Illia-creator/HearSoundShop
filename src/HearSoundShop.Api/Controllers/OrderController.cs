using HearSoundShop.Domain;
using HearSoundShop.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HearSoundShop.Api.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        public OrderController(IOrderService order)
        {
            this.orderService  = order;
        }

        [HttpPost]
        public ActionResult<OrderModel> Post([FromBody] OrderModel order)
        {
            var result = orderService.Create(order);
            return Ok(result);
        }
    }
}
