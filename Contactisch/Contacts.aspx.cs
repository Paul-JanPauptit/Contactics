using Contactisch.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contactisch
{
    public partial class Contacts : GenericPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListView1.DataSource = user.Contacts;
            ListView1.DataBind();
        }
    }
}