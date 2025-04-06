using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressList.Shared.Models
{
    public class ContactInfo
    {
        [Key]
        public int Id { get; set; }
        public int FileID { get; set; }
        public string Status { get; set; }

        public string Typ { get; set; }

        public string Kommunikationsadresse { get; set; }

        public string Gehoert { get; set; }

        public string Anmerkung { get; set; }
        public string ImportDatum { get; set; }
    }
}
