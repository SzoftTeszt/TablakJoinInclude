using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozos.Models
{
    public class Rendeles
    {
        public int Id{ get; set; }

        [Required, StringLength(20)]
        public string RendelesSzam { get; set; } = string.Empty;

        public DateTime Datum { get; set; }
        public decimal Osszeg { get; set; }

        [Required, StringLength(30)]
        public string Statusz { get; set; } = string.Empty;

        public int UgyfelId { get; set; }
        public Ugyfel Ugyfel { get; set; } = null!;

        public Rendeles() { }

        public override string? ToString()
        {
            return $"{RendelesSzam} - {Datum:yyyy.MM.dd} - {Osszeg} Ft - {Statusz}";
        }
    }
}
