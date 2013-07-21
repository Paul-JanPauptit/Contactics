using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contactisch
{
    public partial class Contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String contactsDescription = "";
            using (var context = new ContacticsContext())
            {
                User user = GetUser(context);

                ListView1.DataSource = user.Contacts;
                ListView1.DataBind();
            }
        }

        private User GetUser(ContacticsContext aContext)
        {
            string username = Context.User.Identity.Name;

            return aContext.Users.Where(u => u.Username == username).First();
        }
    }
}