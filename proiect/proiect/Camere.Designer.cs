namespace proiect
{
    partial class Camere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblOp = new System.Windows.Forms.Label();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.txtEtaj = new System.Windows.Forms.TextBox();
            this.txtPretZi = new System.Windows.Forms.TextBox();
            this.txtNrLocuri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new proiect.DataSet2();
            this.camereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camereTableAdapter = new proiect.DataSet2TableAdapters.CamereTableAdapter();
            this.idCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrLocuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCamera = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(635, 110);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(35, 13);
            this.lblOp.TabIndex = 15;
            this.lblOp.Text = "label1";
            // 
            // txtSpImagine
            // 
            this.txtSpImagine.Location = new System.Drawing.Point(75, 127);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.Size = new System.Drawing.Size(129, 20);
            this.txtSpImagine.TabIndex = 13;
            this.txtSpImagine.TextChanged += new System.EventHandler(this.txtSpImagine_TextChanged);
            this.txtSpImagine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSpImagine_MouseDoubleClick);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(217, 48);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(197, 165);
            this.pb.TabIndex = 12;
            this.pb.TabStop = false;
            // 
            // txtEtaj
            // 
            this.txtEtaj.Location = new System.Drawing.Point(75, 74);
            this.txtEtaj.Name = "txtEtaj";
            this.txtEtaj.Size = new System.Drawing.Size(129, 20);
            this.txtEtaj.TabIndex = 10;
            // 
            // txtPretZi
            // 
            this.txtPretZi.Location = new System.Drawing.Point(75, 101);
            this.txtPretZi.Name = "txtPretZi";
            this.txtPretZi.Size = new System.Drawing.Size(129, 20);
            this.txtPretZi.TabIndex = 8;
            // 
            // txtNrLocuri
            // 
            this.txtNrLocuri.Location = new System.Drawing.Point(75, 48);
            this.txtNrLocuri.Name = "txtNrLocuri";
            this.txtNrLocuri.Size = new System.Drawing.Size(129, 20);
            this.txtNrLocuri.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "SpImagine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "PretZi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NrLocuri";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdCamera);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSpImagine);
            this.panel1.Controls.Add(this.pb);
            this.panel1.Controls.Add(this.txtEtaj);
            this.panel1.Controls.Add(this.txtPretZi);
            this.panel1.Controls.Add(this.txtNrLocuri);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(563, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 220);
            this.panel1.TabIndex = 14;
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(526, 101);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 13;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(432, 101);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 12;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(229, 101);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 11;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(120, 101);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 10;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(14, 101);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 9;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCameraDataGridViewTextBoxColumn,
            this.nrLocuriDataGridViewTextBoxColumn,
            this.etajDataGridViewTextBoxColumn,
            this.pretZiDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.camereBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 213);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // camereBindingSource
            // 
            this.camereBindingSource.DataMember = "Camere";
            this.camereBindingSource.DataSource = this.dataSet2;
            // 
            // camereTableAdapter
            // 
            this.camereTableAdapter.ClearBeforeFill = true;
            // 
            // idCameraDataGridViewTextBoxColumn
            // 
            this.idCameraDataGridViewTextBoxColumn.DataPropertyName = "IdCamera";
            this.idCameraDataGridViewTextBoxColumn.HeaderText = "IdCamera";
            this.idCameraDataGridViewTextBoxColumn.Name = "idCameraDataGridViewTextBoxColumn";
            this.idCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrLocuriDataGridViewTextBoxColumn
            // 
            this.nrLocuriDataGridViewTextBoxColumn.DataPropertyName = "NrLocuri";
            this.nrLocuriDataGridViewTextBoxColumn.HeaderText = "NrLocuri";
            this.nrLocuriDataGridViewTextBoxColumn.Name = "nrLocuriDataGridViewTextBoxColumn";
            this.nrLocuriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etajDataGridViewTextBoxColumn
            // 
            this.etajDataGridViewTextBoxColumn.DataPropertyName = "Etaj";
            this.etajDataGridViewTextBoxColumn.HeaderText = "Etaj";
            this.etajDataGridViewTextBoxColumn.Name = "etajDataGridViewTextBoxColumn";
            this.etajDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretZiDataGridViewTextBoxColumn
            // 
            this.pretZiDataGridViewTextBoxColumn.DataPropertyName = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.HeaderText = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.Name = "pretZiDataGridViewTextBoxColumn";
            this.pretZiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Etaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "IdCamera";
            // 
            // txtIdCamera
            // 
            this.txtIdCamera.Location = new System.Drawing.Point(75, 23);
            this.txtIdCamera.Name = "txtIdCamera";
            this.txtIdCamera.Size = new System.Drawing.Size(129, 20);
            this.txtIdCamera.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Camere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 467);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Camere";
            this.Text = "Camere";
            this.Load += new System.EventHandler(this.Camere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtSpImagine;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.TextBox txtEtaj;
        private System.Windows.Forms.TextBox txtPretZi;
        private System.Windows.Forms.TextBox txtNrLocuri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource camereBindingSource;
        private DataSet2TableAdapters.CamereTableAdapter camereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrLocuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCamera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}