// See https://aka.ms/new-console-template for more informat
using Kozos.Data;
using Kozos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

CsvSeeder.SeedData();
using RendelesekContext db = new RendelesekContext();

//foreach (Ugyfel item in db.Ugyfelek.Include(u => u.Rendelesek))
//{
//    Rendeles r= new Rendeles();
//    r= item.Rendelesek.FirstOrDefault();
//    Console.WriteLine(item+":"+r);
//}

Console.WriteLine();
Console.WriteLine("Ügyfelek:");
Console.WriteLine();
foreach (Ugyfel ugyfel in db.Ugyfelek.Include(u => u.Rendelesek))
{
        Console.WriteLine(ugyfel.ToString());
        foreach (Rendeles rendeles in ugyfel.Rendelesek)
        {
            Console.WriteLine("\t" + rendeles.ToString());
        }
}
Console.WriteLine();
Console.WriteLine("Rendelesek:");
Console.WriteLine();


foreach (Rendeles rendeles in db.Rendelesek.Include(r => r.Ugyfel))
{
    Console.WriteLine(rendeles.ToString() + " - " + rendeles.Ugyfel.ToString());
}

Console.WriteLine();
Console.WriteLine("Join Lista:");
Console.WriteLine();


var joinEredmeny = db.Rendelesek.Join(
    db.Ugyfelek,
    r => r.UgyfelId,
    u=>u.Id,
    (r,u) => new {
        r.RendelesSzam,
        UgyfelNev = u.Nev,
        u.Varos,
        r.Datum,
        r.Osszeg,
        r.Statusz
    }    
    ).OrderByDescending(j => j.Osszeg);

foreach (var item in joinEredmeny)
{
    Console.WriteLine($"{item.RendelesSzam} - {item.UgyfelNev} - {item.Varos} - {item.Datum:yyyy.MM.dd} - {item.Osszeg} Ft - {item.Statusz}");
}

Console.WriteLine();
Console.WriteLine("Budapesti rendelesek:");
Console.WriteLine();

var budapest = db.Rendelesek.Join(
    db.Ugyfelek,
    r => r.UgyfelId,
    u => u.Id,
    (r, u) => new {
        Rndeles =r, Ugyfel=u}
    ).Where(x=>x.Ugyfel.Varos == "Budapest" && x.Rndeles.Osszeg>50000).OrderByDescending(x => x.Rndeles.Osszeg);

foreach (var item in budapest)
{
    Console.WriteLine($"{item.Rndeles.RendelesSzam} - {item.Ugyfel.Nev}  - {item.Rndeles.Osszeg} Ft");
}

Console.WriteLine("A lekérdezések lefutottak!");