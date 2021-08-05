using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class Class2
    {
        private double _powResult;
        public Func<int, bool> Calc(Func<int, int, int> powHandler, int x, int y)
        {
            _powResult = powHandler.Invoke(x, y);

            return Result;
        }

        private bool Result(int item)
        {
            return _powResult % item == 0;
        }
    }
}
