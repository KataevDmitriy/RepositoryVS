namespace WebAppHomeWork1.Models
{
    public class SearchNOKModel
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public SearchNOKModel(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
        }
      
        public ulong nok()
        {
            if (num1 == 0 || num2 == 0)
                return 0;
            //НОК наименьшее общее кратное
            ulong x = (ulong)num1;
            ulong y = (ulong)num2;
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
            return result;
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
}
