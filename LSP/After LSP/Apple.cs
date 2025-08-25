using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.After_LSP
{
    internal class Apple : IColor
    {
  
        public string GetColor()
        {
            return "Red";
        }
    }
}
