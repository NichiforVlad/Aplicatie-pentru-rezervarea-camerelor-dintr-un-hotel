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
    public partial class Camere : Form
    {
        public Camere()
        {
            InitializeComponent();
        }

        private void Camere_Load(object sender, EventArgs e)
        {
            A1();
            txtIdCamera.Enabled = false;
        }

        private void A1()
        {
            this.camereTableAdapter.Fill(this.dataSet2.Camere);
            //Configurare PB
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            //Protectie grid
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            A3();
        }

        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);
            //Dezlegare controale Panel
            legareControale(false);
            //Ridicare protectie controale Panel
            protectiePanel(false);
            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";
            //Pozitionare cursor pe primul camp
            txtNrLocuri.Focus();
            // Golire campuri
            golireCampuri();
        }

        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";
            //Çonfigurare(butoane)
            configureazaButoane(true);
            //Protectie componente Panel
            protectiePanel(true);
            //Legare controale
            legareControale(true);
        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;
                adauga_inregistrare();
                golireCampuri();
                //Pune cursor pe primul camp
                txtNrLocuri.Focus();
                refresh_grid(camereBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                if (!validareCampuriObligatorii()) return;
                modifica_inregistrare();
                refresh_grid(camereBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

       /* private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;
            try { p = Convert.ToDecimal(txtB.Text); }
            catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            if (lblOp.Text == "ADAUGARE")
            {
                cmd.CommandText = "Select DPartener From Parteneri where CodPartener=" +
               txtCodPartener.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Cod partener deja existent");
                    txtCodPartener.Focus();
                }
                con.Close();
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                cmd.CommandText = "Select DPartener From Parteneri where CodPartener=" +
               txtCodPartener.Text +
                " and IdPartener <> " + txtIdPartener.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Cod partener deja existent");
                    txtCodPartener.Focus();
                }
                con.Close();
            }
        }*/

        private void A6()
        {
            if (lblOp.Text == "")
                return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSpImagine.Text = openFileDialog1.FileName;
                pb.ImageLocation = txtSpImagine.Text;
            }
        }

        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);
            //Dezlegare controale Panel
            legareControale(false);
            //Ridicare protectie controale Panel
            protectiePanel(false);
            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";
            //Pozitionare cursor pe primul camp
            txtNrLocuri.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            //Trebuie vazut mai tarziu -
            cmd.CommandText = "Select IdCamera From RezervariContinut where IdCamera=" + txtIdCamera.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Camera referita in tabela RezervariContinut! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            cmd.CommandText = "Delete From Camere Where IdCamera = " + txtIdCamera.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(camereBindingSource.Position);
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtIdCamera.DataBindings.Add("Text", camereBindingSource, "IdCamera");
                txtNrLocuri.DataBindings.Add("Text", camereBindingSource, "NrLocuri");
                txtEtaj.DataBindings.Add("Text", camereBindingSource, "Etaj");
                txtPretZi.DataBindings.Add("Text", camereBindingSource, "PretZi");
                txtSpImagine.DataBindings.Add("Text", camereBindingSource, "SpImagine");
                pb.DataBindings.Add("ImageLocation", camereBindingSource, "SpImagine");
            }
            else
            {
                txtIdCamera.DataBindings.Clear();
                txtNrLocuri.DataBindings.Clear();
                txtEtaj.DataBindings.Clear();
                txtPretZi.DataBindings.Clear();
                txtSpImagine.DataBindings.Clear();
                pb.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
            txtNrLocuri.ReadOnly = v;
            txtEtaj.ReadOnly = v;
            txtPretZi.ReadOnly = v;
            txtSpImagine.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtNrLocuri.Text = "";
            txtIdCamera.Text = "";
            txtEtaj.Text = "";
            txtPretZi.Text = "";
            txtSpImagine.Text = "";
            pb.ImageLocation = "";
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtNrLocuri.Text == "")
            {
                MessageBox.Show("Completati NrLocuri !");
                txtNrLocuri.Focus();
                return false;
            }

            try
            {
                int x = Convert.ToInt32(txtNrLocuri.Text);
                if (x <= 0)
                {
                    MessageBox.Show("Completati NrLocuri cu un numar pozitiv!");
                    txtNrLocuri.Focus();
                    return false;
                }
            } catch
            {
                MessageBox.Show("Completati NrLocuri cu un numar pozitiv!");
                txtNrLocuri.Focus();
                return false;
            }

            if (txtEtaj.Text == "")
            {
                MessageBox.Show("Completati Etaj !");
                txtEtaj.Focus();
                return false;
            }

            try
            {
                int x = Convert.ToInt32(txtEtaj.Text);
                if (x <= 0)
                {
                    MessageBox.Show("Completati Etaj cu un numar pozitiv!");
                    txtEtaj.Focus();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Completati Etaj cu un numar pozitiv!");
                txtEtaj.Focus();
                return false;
            }

            if (txtPretZi.Text == "")
            {
                MessageBox.Show("Completati PretZi !");
                txtPretZi.Focus();
                return false;
            }

            try
            {
                double x = Convert.ToDouble(txtPretZi.Text);
                if (x <= 0)
                {
                    MessageBox.Show("Completati PretZi cu un numar pozitiv!");
                    txtPretZi.Focus();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Completati PretZi cu un numar pozitiv!");
                txtPretZi.Focus();
                return false;
            }

            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "NrLocuri, Etaj, PretZi, SpImagine";
            listaValori = "'" + txtNrLocuri.Text + "'" +
            "," + txtEtaj.Text +
           ",'" + txtPretZi.Text + "'" +
            ",'" + txtSpImagine.Text + "'";
            cmd.CommandText = "Insert into Camere(" + listaCampuri + ") " +
            "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void refresh_grid(int p)
        {
            camereTableAdapter.Fill(dataSet2.Camere);
            camereBindingSource.Position = p;
        }

        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "NrLocuri = '" + txtNrLocuri.Text + "'," +
            "Etaj = " + txtEtaj.Text + "," +
            "PretZi = '" + txtPretZi.Text + "'," +
            "SpImagine = '" + txtSpImagine.Text + "'";
            cmd.CommandText = "Update Camere Set " + listaSet + " Where IdCamera=" + txtIdCamera.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();

        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void txtSpImagine_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpImagine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            A6();
        }


    }
}
