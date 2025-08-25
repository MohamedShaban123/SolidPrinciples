using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Before_ISP
{
    internal class OldMachine : IMachine
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
