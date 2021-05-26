using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Clienti : Form
    {
        const int IdClient = 0;
        const int NumeIndex = 1;
        const int TelefonIndex = 2;

        public Clienti()
        {
            InitializeComponent();
        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            config(true);
            refresh();
            dataGridView1.Columns[IdClient].ReadOnly = true;
        }

        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            //Protectie coloane
            dataGridView1.Columns[NumeIndex].ReadOnly = v;
            dataGridView1.Columns[TelefonIndex].ReadOnly = v;


            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }

        private void refresh()
        {
            clientiTableAdapter.Fill(this.dataSet2.Clienti);
        }

        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet2.Clienti)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                
                if (r["NumeClient"] == DBNull.Value)
                {
                    MessageBox.Show("Completati NumeClient la linia cu Id " + r["IdClient"]);
                    raspuns = false;
                }

                String numeClient = r["NumeClient"].ToString();
                for (int i = 0; i < numeClient.Length; i++)
                {
                    try
                    {
                        int x = Convert.ToInt32(numeClient[i]);
                        if (!(x < 48 || x > 57))
                        {
                            raspuns = false;
                            MessageBox.Show("NumeClient la linia cu Id " + r["IdClient"] + " contine numere");
                            break;
                        }
                    }
                    catch
                    {
                        raspuns = false;
                        MessageBox.Show("NumeClient la linia cu Id " + r["IdClient"] + " contine numere");
                        break;
                    }
                }

                if (r["NrTelefon"] == DBNull.Value)
                {
                    MessageBox.Show("Completati NrTelefon la linia cu Id " + r["IdClient"]);
                    raspuns = false;
                }
                if (r["NrTelefon"].ToString().Length != 10)
                {
                    MessageBox.Show("NrTelefon la linia cu Id " + r["IdClient"] + " nu are 10 numere");
                    raspuns = false;
                }

                String nrTelefon = r["NrTelefon"].ToString();
                for (int i = 0; i < nrTelefon.Length; i++)
                {
                    try
                    {
                        int x = Convert.ToInt32(nrTelefon[i]);
                        if (x < 48 || x > 57)
                        {
                            raspuns = false;
                            MessageBox.Show("NrTelefon la linia cu Id " + r["IdClient"] + " nu are 10 numere");
                            break;
                        }
                    } catch
                    {
                        raspuns = false;
                        MessageBox.Show("NrTelefon la linia cu Id " + r["IdClient"] + " nu are 10 numere");
                        break;
                    }
                }
            }
            return raspuns;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();
                return;
            }
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;

            try
            {
                clientiTableAdapter.Update(dataSet2.Clienti);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Numarul de telefon sau numele exista deja !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (btnActualizare.Enabled) return;
        }
    }
}
