using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Login
    {
        private string UsernameLogin;
        private string PasswordLogin;
        private int IdWorker;


        public string GetSetUsernameLogin
        {
            get { return UsernameLogin; }
            set { UsernameLogin = value; }
        }

        public string GetSetPasswordLogin
        {
            get { return PasswordLogin; }
            set { PasswordLogin = value; }
        }

        public int GetSetIdWorker
        {
            get { return IdWorker; }
            set { IdWorker = value; }
        }
    }
}
