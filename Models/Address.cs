using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressList.Shared.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FileID { get; set; }

        [Required]
        public string Aktenzeichen { get; set; }

        public string Rechtsform { get; set; } = string.Empty;
        public string Anrede { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;

        [Required]
        public string Vorname { get; set; }

        [Required]
        public string Nachname { get; set; }

        public string Straße { get; set; } = string.Empty;
        public string Hausnummer { get; set; } = string.Empty;
        public string PLZ { get; set; } = string.Empty;
        public string Ort { get; set; } = string.Empty;
        public string Land { get; set; } = string.Empty;
        public string Import { get; set; } = string.Empty;
        public string Datenquelle { get; set; } = string.Empty;
        public bool AktuelleAnschrift { get; set; }

        [Required]
        public string AddressStatus { get; set; }
    }
}
