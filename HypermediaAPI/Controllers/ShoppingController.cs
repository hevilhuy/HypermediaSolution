using HypermediaAPI.ActionFilters;
using HypermediaAPI.Database;
using HypermediaAPI.Database.Models;
using HypermediaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HypermediaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [HATEOASFilter(typeof(ShoppingLinkProfile))]
    public class ShoppingController : ControllerBase
    {
        [HttpGet]
        [HATEOASFilter(typeof(ShoppingLinkItemProfile))]
        public IEnumerable<ShoppingItem> Get(int id)
        {
            return DemoData.ShoppingItems;
        }
    }
}
