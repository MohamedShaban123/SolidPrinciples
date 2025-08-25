using LSP.After_LSP;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before LSP

            //Apple apple1 = new Apple();
            //var ret1 = apple1.GetColor();
            //Console.WriteLine(ret1);      // red

            Apple apple2 = new Orange();
            var ret2 = apple2.GetColor();
            Console.WriteLine(ret2);        // orange


           

            #endregion

            #region After LSP

            IColor color = new LSP.After_LSP.Apple();
            var resultColor = color.GetColor();
            Console.WriteLine(resultColor);

            //Console.WriteLine("=======================");
            //IColor color2 = new LSP.After_LSP.Orange();
            //var resultColor2 = color2.GetColor();
            //Console.WriteLine(resultColor2);

            #endregion

        }
    }
}
