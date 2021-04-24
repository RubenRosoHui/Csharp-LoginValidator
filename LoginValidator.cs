using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLoginValidator
{
    public class LoginValidator
    {
        private string Username;
        private string Password;
        public LoginValidator() 
        {
            Username = null;
            Password = null;
        }
        public string username
        {
            get{return Username;}
            set{Username = value;}
        }
        public string password
        {
            private get{return Password; }
            set{Password = value;}
        }
        public bool? Authorize() 
        {
            string Pass1 = "bryan", Pass2 = "123", Pass3 = "pass",
                User1 = "wayne", User2 = "test", User3 = "user";
            if (Password == null || Username == null)
            {
                return null;
            }
            else
            {
                if (Username == User1 && Password == Pass1 || Username == User2 && Password == Pass2 || Username == User3 && Password == Pass3)
                {
                    return true;
                } 
            }
            return false;
        }
    }
}
