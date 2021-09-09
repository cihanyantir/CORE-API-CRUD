using CORE_API.IService;
using CORE_API.Repository.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : GenericController<Order>
    {
        public OrderController(IGenericService<Order> genericService) : base(genericService)
        { }

    }
}
