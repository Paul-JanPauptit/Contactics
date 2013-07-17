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
            Username.Text = Context.User.Identity.Name;

            String contactsDescription = "";
            using (var context = new ContacticsContext())
            {

                User user = GetUser(context);

                // TODO, PJ: More elegant conditional string concatenation?
                foreach (Contact contact in user.Contacts)
                {
                    if (contactsDescription != "")
                    {
                        contactsDescription += ", ";
                    }

                    contactsDescription += contact.FullName;
                }

                ContactsLabel.Text = contactsDescription;
            }
        }

        private User GetUser(ContacticsContext aContext)
        {
            string username = Context.User.Identity.Name;

            return aContext.Users.Where(u => u.Username == username).First();
        }
    }
}