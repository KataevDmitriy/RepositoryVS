using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

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
        public void Delete(int id)
        {
            CreateRep.Delete(id);
        }

    }





}
