using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting
{
    public class myTryDataLoss
    {
        public void TryDataLoss()
        {
            long result = long.MaxValue;
            float myresult = 0;
            long result2 = 0;

            for (int i = 0; i < i + 1; i++)
            {
                myresult = result;
                myresult += 1;
                try { 
                checked
                {
                    result2 = (long)myresult;
                }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(result);
                    Console.WriteLine((float)result+1);
                    Console.WriteLine(myresult.ToString("d"));
                    Console.WriteLine((myresult + 1).ToString("n"));
                    Console.WriteLine((myresult + 2).ToString("n"));
                    Console.ReadKey();
                    break;
                }
                /*if (result == result2)
                {
                    result += 1;
                    continue;
                }
                else if (result2 < result)
                {
                    
                  
                    Console.ReadKey();
                    break;
                }*/
            }
    

        }
    }
}
