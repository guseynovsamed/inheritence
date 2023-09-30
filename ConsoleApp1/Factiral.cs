using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Factiral : ComonClac
    {
       public int GetFactorial(int a )
        {
            int result = 1;

            for( int i = 1; i < a; i++ )
            {
                result *= i;
            }

            return result;
        }
    }
}
