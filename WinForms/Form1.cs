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

            lstRendelesek.DataSource = rendelesek.OrderByDescending(r=>r.Datum).ToList();
        }
    }
}
