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
    public partial class RezervariActualizare : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        //private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;

        public RezervariActualizare()
        {
            InitializeComponent();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RezervariActualizare_Load(object sender, EventArgs e)
        {
            A1();
        }

        public void completeazaTitlu(String titlu) { lblOp.Text = titlu; }
        // in lucru; status: OK
        private void completeazaComanda()
        {
            DataRowView current = (DataRowView)bs1.Current;
            //idCda = (int)current["IdComanda"]; 
            txtNrComanda.Text = Convert.ToString(current["IdRezervare"]);
            cmbClient.Text = current["NumeClient"].ToString(); 
            txtTotal.Text = current["Total"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(current["DataRezervarii"]);
            bs2.MoveFirst();
            dataSet2.RezervareContinutManevra.Clear();
            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;
                DataSet2.RezervareContinutManevraRow r = dataSet2.RezervareContinutManevra.NewRezervareContinutManevraRow(); 
                r.NrCrt = Convert.ToInt16(current["Nrc"]); 
                r.IdCamera = Convert.ToInt32(current["IdCamera"]);
                //r.DataCazarii = Convert.ToString(current["DataCazarii"]);
                r.DataCazarii = Convert.ToDateTime(current["DataCazarii"]).ToString("MM/dd/yyyy");
            
                r.PretZi = Convert.ToDecimal(current["PretZi"]);
                //r.NrZile = Convert.ToDecimal(current["NrZile"]); 
                r.NrZile = Convert.ToInt32(current["NrZile"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);
                dataSet2.RezervareContinutManevra.Rows.Add(r); 
                bs2.MoveNext();
            }
        }

        private void A1()
        {
            //Incarcare DataTable Produse
            this.camereTableAdapter.Fill(this.dataSet2.Camere);

            //Incarcare DataTable Clienti
            this.clientiTableAdapter.Fill(this.dataSet2.Clienti);

            // Protectie la modificare
            txtNrComanda.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            dataCazariiDataGridViewTextBoxColumn.ReadOnly = true;
            pretZiDataGridViewTextBoxColumn.ReadOnly = true;
            valoareDataGridViewTextBoxColumn.ReadOnly = true;

            // Initializare cmbClient
            if (lblOp.Text == "MODIFICARE REZERVARE") completeazaComanda();
            else if (lblOp.Text == "REZERVARE NOUA") cmbClient.SelectedIndex = -1;
        }

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE REZERVARE")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariComenziContinut();
                this.Close();
            }
            else if (lblOp.Text == "REZERVARE NOUA")
            {
                //ok
                generez_nr_cda();
                //ok rezervari
                adaugaInregistrareComenzi();
                //nu e necesar pt ca citim direct
                //cautaInregistrare();
                //pare ok
                adaugaInregistrariComenziContinut();
                //ok
                golireCampuri();
            }
        }

        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)rezervareContinutManevraBindingSource.Current;
            try { current["NrCrt"] = rezervareContinutManevraBindingSource.Position + 1; }
            catch { }
        }
        
        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)camereBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[2].Value = dateTimePicker2.Value.ToString("MM/dd/yyyy");
                    dataGridView1.CurrentRow.Cells[3].Value = current["PretZi"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    rezervareContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
            }
            catch { }
        }


        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dataSet2.RezervareContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }

            txtTotal.Text = Convert.ToString(t);
        }
        //OK
        private void generez_nr_cda()
        {
            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(IdRezervare) FROM Rezervari";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.IsDBNull(0))
            {
                txtNrComanda.Text = "1";
            } else
            {
                txtNrComanda.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            }
            
            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbClient.Text == "")
            {
                MessageBox.Show("Completati Client !");
                cmbClient.Focus();
                return false;
            }
            // Validare completare continut
            if (rezervareContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut comanda !");
                dataGridView1.Focus();
                return false;
            }
            int ok = 1;
            foreach (DataRow r in dataSet2.RezervareContinutManevra)
            {
                if (r["NrZile"] == DBNull.Value)
                {
                    ok = -1;
                    break;
                }
                int x = Convert.ToInt32(r["NrZile"]);
                if (x < 1)
                {
                    ok = -1;
                    MessageBox.Show("Introduceti un nr pozitiv la NrZile");
                    break;
                }
            }
            if (ok == -1) return false;
            return true;
        }
        /*private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT idComanda From Comenzi Where NrComanda = " +
            txtNrComanda.Text;
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }*/

        private void adaugaInregistrariComenziContinut()
        {
            //din bd atributele din rezervariContinut
            string listaCampuri = "IdRezervare, Nrc, IdCamera, DataCazarii, PretZi, NrZile";
            string listaValori;
            con.Open();
            foreach (DataRow r in dataSet2.RezervareContinutManevra)
            {
                listaValori = txtNrComanda.Text + "," + r["NrCrt"] + "," + r["IdCamera"] + ", #" +
                                r["DataCazarii"] + "#," + r["PretZi"] + "," + r["NrZile"];
                cmd.CommandText = "Insert into RezervariContinut(" + listaCampuri + ") " +
                "Select " + listaValori;
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        //Rezervari
        private void adaugaInregistrareComenzi()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;
            listaCampuri = "IdRezervare, DataRezervarii, IdClient";
            listaValori = txtNrComanda.Text +
            ",#" + Convert.ToString(d.Month) + "/"
            + Convert.ToString(d.Day) + "/"
            + Convert.ToString(d.Year) + "#,"
            + cmbClient.SelectedValue;
            cmd.CommandText = "Insert into Rezervari(" + listaCampuri + ") " +
            "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void golireCampuri()
        {
            txtNrComanda.Text = "";
            cmbClient.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet2.RezervareContinutManevra.Clear();
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;
            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            string clauzaWhere = " Where IdRezervare = " + txtNrComanda.Text;
            string clauzaSet = "Set DataRezervarii = #" + d1.Month + "/"
            + d1.Day + "/"
           + d1.Year + "#,"
           + "IdClient = " + cmbClient.SelectedValue;
            cmd.CommandText = "Update Rezervari " + clauzaSet + clauzaWhere;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from RezervariContinut Where IdRezervare = " + txtNrComanda.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //ok
        private void rezervareContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }
        //ok
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }
        //ok
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }
        //ok
        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }
    }
}
