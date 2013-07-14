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
            String password = Password.Text;

            if (ValidateLogin(username, password))
            {
                FormsAuthentication.RedirectFromLoginPage(username, true);
            }
            else
            {
                ErrorContainer.Visible = true;
                MessageLabel.Text = "Invalid username or password.";
            }
        }

        protected bool ValidateLogin(String aUsername, String aPassword)
        {
            bool isValid = false;

            using (var context = new ContacticsContext())
            {
                User user = context.Users.Where(u => u.Username == aUsername).SingleOrDefault();

                if (user != null)
                {
                    String hashedPassword = Encryption.MakeHash(aPassword, user.Salt.ToString());

                    isValid = String.Equals(hashedPassword, user.Password, StringComparison.Ordinal);
                }
            }

            return isValid;
        }
    }
}