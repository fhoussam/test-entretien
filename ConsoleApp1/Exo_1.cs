using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dynamichelper<T>
    {
        public static T Add<T>(T a, T b) where T : struct
        {
            return (dynamic)a + (dynamic)b;
        }
    }
}
