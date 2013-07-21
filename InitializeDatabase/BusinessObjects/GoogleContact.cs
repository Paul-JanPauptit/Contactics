using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace InitializeDatabase.BusinessObjects
{
    public class GoogleContact
    {
        public String Name { get; set; }

        public String Address1Formatted { get; set; }

        public String Phone1Value { get; set; }

        public String Email1Value { get; set; }
    }

    public sealed class GoogleContactMap : CsvClassMap<GoogleContact>
    {
        public override void CreateMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.Address1Formatted).Name("Address 1 - Formatted");
            Map(m => m.Phone1Value).Name("Phone 1 - Value");
            Map(m => m.Email1Value).Name("E-mail 1 - Value");
        }
    }

}
