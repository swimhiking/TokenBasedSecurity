using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AngularJSAuthentication.API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }

    }

    #region Helpers

    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }

        public static List<Order> CreateOrders()
        {
            List<Order> OrderList = new List<Order> 
            {
                new Order {OrderID = 10248, CustomerName = "Allen Song", ShipperCity = "Calgary", IsShipped = true },
                new Order {OrderID = 10249, CustomerName = "Jim Wang", ShipperCity = "Shanghai", IsShipped = false},
                new Order {OrderID = 10250,CustomerName = "Gerry Li", ShipperCity = "Toronto", IsShipped = false },
                new Order {OrderID = 10251,CustomerName = "Mike Shi", ShipperCity = "Waterloo", IsShipped = true}
            };

            return OrderList;
        }
    }

    #endregion
}
