using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contactisch.Misc;

namespace Contactisch
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "";

            String username = Username.Text;
            String password = Encryption.makeHashSHA256(Password.Text);

            using (var context = new ContacticsContext())
            {
                User user = (
                    from
                        u in context.Users
                    where
                        u.Username == username &&
                        u.Password == password
                    select
                        u).FirstOrDefault();


                if (user != null)
                {
                    FormsAuthentication.RedirectFromLoginPage(username, true);
                }
                else
                    MessageLabel.Text = "Invalid username or password.";
            }
        }

        protected bool login(String aUsername, String aPassword)
        {
            bool isValid = false;

            using (var context = new ContacticsContext())
            {
                User user = context.Users.Where(u => u.Username == aUsername).SingleOrDefault();

                if (user != null)
                {
                    String hashedPassword = Encryption.makeHash(aPassword, user.Salt);

                    isValid = (hashedPassword == user.Password);
                }
            }

            return isValid;
        }
    }
}