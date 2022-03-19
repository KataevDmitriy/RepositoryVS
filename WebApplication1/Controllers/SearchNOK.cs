using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchNOK : Controller
    {
        //https://localhost:7207/SearchNOK?number1=1&number2=2
        [HttpGet(Name = "SearchNOK")]
        public box Get(ulong number1 , ulong number2)
        {
            //НОК наименьшее общее кратное
            ulong x = number1;
            ulong y = number2;
            ulong result = 0;
            List<ulong> list_number1 = new List<ulong>();
            List<ulong> list_number2 = new List<ulong>();

            list_number1 = CreateNumberSeries(x, y);
            list_number2 = CreateNumberSeries(y, x);

            foreach (ulong t in list_number1)
            {
                bool exit = false;
                foreach (ulong s in list_number2)
                {
                    if (t == s)
                    {
                        result = s;
                        exit = true;
                        break;
                    }
                }
                if (exit) { break; }
            }
            //return String.Format("Для числа {0} и числа {1} НОК {2}", number1, number2 , result.ToString());
            box b = new box();
            b.number = result;
            return b;
        }

        private List<ulong> CreateNumberSeries(ulong number1, ulong number2)
        {
            List<ulong> list = new List<ulong>();
            ulong r = number1 * number2;
            for (ulong d = 1; number1 * d <= r; d++)
            {
                list.Add(number1 * d);
            }
            return list;
        }
        
    }
    public class box
    { 
    public ulong number { get; set; }
    }

}
