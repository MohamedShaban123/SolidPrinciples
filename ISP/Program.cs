using ISP.Before_ISP;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before ISP
            //OldMachine oldMachine = new OldMachine();
            // oldMachine.Print();
            //oldMachine.Fax();  // thow exception  as you know 
            //oldMachine.Scan();  // thow exception  as you know 
            #endregion

            #region After ISP

           //ISP.After_ISP.OldMachine oldMachine = new ISP.After_ISP.OldMachine();
           // oldMachine.Print();

            #endregion
        }
    }
}
