using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net;

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
      /*  public object Get(int Id)
        {
            var result = Context.NOKTemplateCreateDbs.Find(Id);
            if (result == null)
                return HttpStatusCode.BadRequest;
            else
                return result;
        }*/

        public void Update(NOKTemplateCreateDb updateTodoItem)
         {
            NOKTemplateCreateDb currentItem = Context.NOKTemplateCreateDbs.Find(updateTodoItem.Id);
           // NOKTemplateCreateDb currentItem = Get(updateTodoItem.Id);
            currentItem.Number1 = updateTodoItem.Number1;
             currentItem.Number2 = updateTodoItem.Number2;
             currentItem.Result = updateTodoItem.Result;
             currentItem.ReleaseDateTime = updateTodoItem.ReleaseDateTime;

            Context.NOKTemplateCreateDbs.Update(currentItem);
             Context.SaveChanges();
         }
        //****************************************************

        //Delete**********************************************
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        public HttpStatusCode Delete(int id)
        {

            var wr = Context.NOKTemplateCreateDbs.Find(id);
            if (wr is null)
             {
                //return "Запись на удаление не найдена";
                return HttpStatusCode.BadRequest;
            }
            Context.NOKTemplateCreateDbs.Remove(wr);
            Context.SaveChanges();
            return HttpStatusCode.OK;
        }
        //****************************************************
    }
}

