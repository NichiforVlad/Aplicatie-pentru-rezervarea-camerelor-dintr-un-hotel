using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Rezervari : Form
    {
        public Rezervari()
        {
            InitializeComponent();
        }

        private void Rezervari_Load(object sender, EventArgs e)
        {
            refreshGrid();
            try
            {
                rezervariContinutBindingSource.Filter = "IdRezervare=" + txtIdComanda.Text;
            }
            catch { }
        }

        private void refreshGrid()
        {
            this.rezervariContinutTableAdapter.Fill(this.dataSet2.RezervariContinut);
            this.rezervariTableAdapter.Fill(this.dataSet2.Rezervari);
            try
            {
                rezervariContinutBindingSource.Filter = "IdRezervare=" + txtIdComanda.Text;
            }
            catch { }
        }

        private void btnRezervareNoua_Click(object sender, EventArgs e)
        {
            RezervariActualizare f = new RezervariActualizare();
            f.ShowDialog();
            refreshGrid();
        }

        private void btnModificaRezervare_Click(object sender, EventArgs e)
        {
            RezervariActualizare f = new RezervariActualizare();
            f.completeazaTitlu("MODIFICARE REZERVARE");
            f.bs1 = rezervariBindingSource;
            f.bs2 = rezervariContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
        }

        private void btnStergeRezervare_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = rezervariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            // Sterg continut comanda
            cmd.CommandText = "Delete From RezervariContinut Where IdRezervare = " + txtIdComanda.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            // Sterg comanda
            cmd.CommandText = "Delete From Rezervari Where IdRezervare = " + txtIdComanda.Text;
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            con.Close();
            // Refresh grid-uri
            refreshGrid();
        }

        private void rezervariBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                rezervariContinutBindingSource.Filter = "IdRezervare=" + txtIdComanda.Text;
            }
            catch { }
        }
    }
}
