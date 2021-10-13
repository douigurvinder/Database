using Homework_Form.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Form.Server.Controllers
{
    [ApiController]
    [Route ("api/[controller]") ]
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public GenresController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
       public async Task<ActionResult<int>>Post(Class1 class1) 
        {
            context.Add(class1);
            await context.SaveChangesAsync();
            return class1.ID;
        }
    }
}
