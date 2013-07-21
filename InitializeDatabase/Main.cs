using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using InitializeDatabase.BusinessObjects;
using System.IO;
using CsvHelper;
using Contactisch;

class Program
{
    public static void Main()
    {
        using ( TextReader textReader = File.OpenText( @"..\..\..\Data\contacts.csv" ))
        using (var context = new ContacticsContext())
        {
            var csvReader = new CsvReader( textReader );
            csvReader.Configuration.RegisterClassMap<GoogleContactMap>();
            var contacts = csvReader.GetRecords<GoogleContact>();

            ImportGoogleContacts(contacts, context);
        }
    }

    private static void ImportGoogleContacts(IEnumerable<GoogleContact> aContacts, ContacticsContext aContext)
    {
        
        // INFO, PJ: Clear table. Entity framework doesn't do bulk deletes. 
        aContext.Database.ExecuteSqlCommand("delete from Contacts");

        // INFO, PJ: Import all contacts
        foreach (var googleContact in aContacts)
        {
            if (!String.IsNullOrWhiteSpace(googleContact.Name))
            {
                Contact contact = new Contact()
                {
                    UserId = 1,
                    Address = googleContact.Address1Formatted,
                    Email = googleContact.Email1Value,
                    FullName = googleContact.Name,
                    Phone = googleContact.Phone1Value
                };

                aContext.Contacts.Add(contact);
                aContext.SaveChanges();
            }
        }
    }


}

