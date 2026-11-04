using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozos.Models
{
    public class Ugyfel
    {
        public int Id { get; set; }

        [Required, StringLength(10)]
        public string Kod { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string Nev { get; set; } = string.Empty;

        [Required, StringLength(60)]
        public string Varos { get; set; } = string.Empty;

        [Required, StringLength(120)]
        public string Email { get; set; } = string.Empty;

        public List<Rendeles> Rendelesek { get; set; } = new();

        public override string? ToString()
        {
            return $"{Nev} - {Varos}";
        }
        public Ugyfel() { }


    }
}
