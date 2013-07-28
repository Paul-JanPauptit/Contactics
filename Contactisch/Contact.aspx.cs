using Contactisch.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contactisch
{
    public partial class Contact1 : GenericPage
    {
        private Contact _contact = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            int contactID;

            if (int.TryParse(Request.QueryString["id"], out contactID))
            {
                _contact = user.Contacts.Where(c => c.Id == contactID).First();
            }

            if (!Page.IsPostBack)
            {
                InitializePage();
            }
           
        }

        protected void DoneButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                CommitContact();
            }
            else
                ErrorContainer.Visible = true;
        }

        private void InitializePage()
        {
            if (_contact != null)
            {
                FullName.Text = _contact.FullName;
                Address.Text = _contact.Address;
                Email.Text = _contact.Email;
                Phone.Text = _contact.Phone;

                DoneButton.Text = "Save";
            }
            else
            {
                DoneButton.Text = "Add";
            }
        }

        private bool ValidateInput()
        {
            bool isValid = true;

            if (FullName.Text == "")
            {
                MessageLabel.Text = "Name should not be empty.";
                FullName.Focus();

                isValid = false;
            }

            return isValid;
        }

        private void CommitContact()
        {
            Contact contact;

            if (_contact == null)
            {
                contact = new Contact();
                DataContext.Contacts.Add(contact);
            }
            else
                contact = _contact;

            contact.FullName = FullName.Text;
            contact.Address = Address.Text;
            contact.Email = Email.Text;
            contact.Phone = Phone.Text;

            DataContext.SaveChanges();
            Response.Redirect("contacts.aspx");
        }

    }
}