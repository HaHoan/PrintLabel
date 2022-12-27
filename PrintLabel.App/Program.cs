using System;
using System.Threading;
using System.Windows.Forms;
using VBSQLHelper;

namespace PrintLabel.App
{
    static class Program
    {
        public static User CurrentUser { get; set; }
        public static string ModelSelect = string.Empty;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLHelper.SERVER_NAME = "172.28.10.17";
            SQLHelper.USERNAME_DB = "sa";
            SQLHelper.PASSWORD_DB = "umc@2019";
            SQLHelper.DATABASE = "UMCVN_BASE";
            SQLHelper.ConnectString();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CurrentUser = new User();
            bool ownmutex;

            // Tạo và lấy quyền sở hữu một Mutex có tên là 
            using (var mutex = new Mutex(true, "PrintLabel", out ownmutex))
            {
                // Nếu ứng dụng sở hữu Mutex, nó có thể tiếp tục thực thi;
                // nếu không, ứng dụng sẽ thoát.
                if (ownmutex)
                {
                    Application.Run(new FormMain());
                    //giai phong Mutex;
                    mutex.ReleaseMutex();
                }
                else
                    Application.ExitThread();
            }
        }
    }
}
