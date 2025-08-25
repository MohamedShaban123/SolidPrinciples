using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.After_LSP
{
    internal class Orange : IColor
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}
