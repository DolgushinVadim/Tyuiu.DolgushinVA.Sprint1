using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DolgushinVA.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            bool n = value.All(char.IsDigit);
            if ((n == true) && (value[0] != '0'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
