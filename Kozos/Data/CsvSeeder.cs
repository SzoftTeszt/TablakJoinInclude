using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozos.Data
{
    public static class CsvSeeder
    {
        public static void SeedData()
        {
            using RendelesekContext db = new();

            if (db.Ugyfelek.Any() || db.Rendelesek.Any()) return;

            string[] ugyfelSorok = File.ReadAllLines("Data\\ugyfelek_join.csv", Encoding.UTF8).Skip(1).ToArray();
            foreach (string sor in ugyfelSorok)
            {
                string[] mezok = sor.Split(';');
                db.Ugyfelek.Add(new Models.Ugyfel
                {
                    Kod = mezok[0],
                    Nev = mezok[1],
                    Varos = mezok[2],
                    Email = mezok[3]
                });         
            }
            db.SaveChanges();

            Dictionary<string, int> ugyfelKodIdMap = db.Ugyfelek.ToDictionary(u => u.Kod, u => u.Id);

            string[] rendelesSorok = File.ReadAllLines("Data\\rendelesek_join.csv", Encoding.UTF8).Skip(1).ToArray();

            foreach (string sor in rendelesSorok)
            {
                string[] mezok = sor.Split(';');
                db.Rendelesek.Add(new Models.Rendeles
                {
                    RendelesSzam = mezok[0].Trim(),
                    UgyfelId = ugyfelKodIdMap[mezok[1]],
                    Datum = DateTime.ParseExact(mezok[2], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Osszeg = decimal.Parse(mezok[3], CultureInfo.InvariantCulture),
                    Statusz = mezok[4],
                 
                });
            }
            db.SaveChanges();
        }
    }
}
