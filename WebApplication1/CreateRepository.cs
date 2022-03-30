using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApplication1
{
    public class CreateRepository
    {
        public CreateDbContext Context;

        public CreateRepository(CreateDbContext context)
        {
            Context = context;
        }

        //Create**********************************************
        public void Create(NOKTemplateCreateDb item)
        {
            Context.NOKTemplateCreateDbs.Add(item);
            Context.SaveChanges();
        }
        //****************************************************
 
        //Read************************************************
        public IEnumerable<NOKTemplateCreateDb> Get()
        {
            return Context.NOKTemplateCreateDbs;
        }
        //***************************************************

        //Update*********************************************
        public NOKTemplateCreateDb Get(int Id)
        {
            return Context.NOKTemplateCreateDbs.Find(Id);
        }
        
        public void Update(NOKTemplateCreateDb updateTodoItem)
         {
            NOKTemplateCreateDb currentItem = Get(updateTodoItem.Id);
             currentItem.Number1 = updateTodoItem.Number1;
             currentItem.Number2 = updateTodoItem.Number2;
             currentItem.Result = updateTodoItem.Result;
             currentItem.ReleaseDateTime = updateTodoItem.ReleaseDateTime;

            Context.NOKTemplateCreateDbs.Update(currentItem);
             Context.SaveChanges();
         }
        //****************************************************

        //Delete**********************************************
        public void Delete(int id)
        {

            var wr = Context.NOKTemplateCreateDbs.Find(id);
            /*if (wr is null)
             {
                 return NotFound();
             }*/
            Context.NOKTemplateCreateDbs.Remove(wr);
            Context.SaveChanges();
        }
        //****************************************************
    }
}

