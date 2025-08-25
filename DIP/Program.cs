using DIP.After_DIP;
using DIP.Before_DIP;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before DIP
            //DIP.Before_DIP.UserService userService = new DIP.Before_DIP.UserService();
            // userService.sendemail("Abdallah","Mohamed");
            #endregion
            #region After DIP
            //DIP.After_DIP.UserService userService = new DIP.After_DIP.UserService(new SendEmail());
            //userService.sendemail("Abdallah", "Mohamed");
            #endregion
        }
    }
}
