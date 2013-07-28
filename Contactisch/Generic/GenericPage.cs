using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contactisch.Generic
{
    public class GenericPage : System.Web.UI.Page
    {
        private ContacticsContext _dataContext;
        private User _user;

        public GenericPage()
        {
            Load += Page_Load;
            Unload += Page_Unload;
        }

        private void Page_Load(object sender, EventArgs e)
        {
            _dataContext = new ContacticsContext();
        }

        private void Page_Unload(object sender, EventArgs e)
        {
            _dataContext.Dispose();
        }

        protected ContacticsContext DataContext
        {
            get { return _dataContext; }
        }

        protected User user
        {
            get
            {
                if (_user == null)
                {
                    _user = GetUser();
                }

                return _user;
            }
        }

        private User GetUser()
        {
            // INFO, PJ: Note how Context denotes the page httpContext here, as opposed to the DBContext.
            string username = Context.User.Identity.Name;

            return _dataContext.Users.Where(u => u.Username == username).First();
        }

    }
}