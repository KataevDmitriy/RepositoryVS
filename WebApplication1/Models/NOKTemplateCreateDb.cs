using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    /// <summary>
    //Структура создаваемой в базе таблицы NOKTemplateCreateDb
    /// </summary>
    public class NOKTemplateCreateDb
    {
        public int Id { get; set; }
     
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDateTime { get; set; }
        public ulong Number1 { get; set; }
        public ulong Number2 { get; set; }
        public ulong Result { get; set; }
    }
}
