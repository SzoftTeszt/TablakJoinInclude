using Kozos.Data;
using Kozos.Models;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CsvSeeder.SeedData();
            dvgJOIN.MultiSelect = false;
            dvgJOIN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgJOIN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using RendelesekContext context = new RendelesekContext();
            lstUgyfelek.DataSource = context.Ugyfelek.OrderBy(x => x.Nev).ToList();
        }

        private void lstUgyfelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ugyfel kivalasztott = (Ugyfel)lstUgyfelek.SelectedItem;
            //MessageBox.Show(kivalasztott.ToString());

            using RendelesekContext context = new RendelesekContext();

            var rendelesek = context.Rendelesek.Where(x => x.UgyfelId == kivalasztott.Id);

            lblKivalasztott.Text = $"{kivalasztott.Nev} rendelései ({rendelesek.Count()} db)";

            lstRendelesek.DataSource = rendelesek.OrderByDescending(r => r.Datum).ToList();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            using RendelesekContext db = new();

            

            Button gomb = (Button)sender;
           


                var lista = db.Rendelesek.Join(db.Ugyfelek,
                    r => r.UgyfelId,
                    u => u.Id,
                    (r, u) => new
                    {
                        Rendelés = r.RendelesSzam,
                        Ügyfél = u.Nev,
                        Város = u.Varos,
                        Dátum = r.Datum,
                        Összeg = r.Osszeg,
                        Státus = r.Statusz
                    }).OrderByDescending(x => x.Dátum).ToList();

            if (gomb.Equals(btnBudapest))
            {
                lista = lista.Where(x => x.Város == "Budapest").ToList();     
            }
          
            dvgJOIN.DataSource = lista;
            dvgJOIN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
