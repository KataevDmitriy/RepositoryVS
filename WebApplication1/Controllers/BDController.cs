using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;



namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class BDController : Controller
    {
        CreateRepository CreateRep;
        CreateDbContext _context;

        public BDController(CreateRepository createRep, CreateDbContext context)
        {
            CreateRep = createRep;
            _context = context;
        }

     

        [Route("CreateNewItemDB")]
        [HttpPost]
        public void Create([FromBody] NOKTemplateCreateDb todoItem)
        {
           // todoItem.Result = 
            CreateRep.Create(todoItem);
            
            
        }

        [Route("ReadAllItemDB")]
        [HttpGet]
        //[HttpGet(Name = "GetAllItems")]
        public IEnumerable<NOKTemplateCreateDb> Get()
        {
            return CreateRep.Get();
        }

        [Route("ReadIdItemDB/{id}")]
        [HttpGet]
        //[HttpGet(Name = "GetAllItems")]
        public object Get(int id)
        {
            return CreateRep.Get(id);
        }

        [Route("Update")]
        [HttpPost]
        public void Update([FromBody] NOKTemplateCreateDb updateTodoItem)
        {
            CreateRep.Update(updateTodoItem);
        }
        /*
          [HttpDelete("{id}")]
        public void Delete([FromBody] NOKTemplateCreateDb updateTodoItem)
        {
            CreateRep.Delete(updateTodoItem.Id);
        }
         */
        [HttpDelete("Delete/{id}")]
        public HttpStatusCode Delete(int id)
        {
           return CreateRep.Delete(id);
        }

    }





}
