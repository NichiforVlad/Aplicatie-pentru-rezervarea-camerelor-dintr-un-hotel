namespace proiect
{
    partial class Rezervari
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
            this.btnStergeRezervare = new System.Windows.Forms.Button();
            this.btnModificaRezervare = new System.Windows.Forms.Button();
            this.btnRezervareNoua = new System.Windows.Forms.Button();
            this.txtIdComanda = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new proiect.DataSet2();
            this.rezervariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervariTableAdapter = new proiect.DataSet2TableAdapters.RezervariTableAdapter();
            this.rezervariContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervariContinutTableAdapter = new proiect.DataSet2TableAdapters.RezervariContinutTableAdapter();
            this.idRezervareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCazariiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrZileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRezervareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRezervariiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStergeRezervare
            // 
            this.btnStergeRezervare.Location = new System.Drawing.Point(661, 123);
            this.btnStergeRezervare.Name = "btnStergeRezervare";
            this.btnStergeRezervare.Size = new System.Drawing.Size(111, 23);
            this.btnStergeRezervare.TabIndex = 11;
            this.btnStergeRezervare.Text = "Sterge rezervare";
            this.btnStergeRezervare.UseVisualStyleBackColor = true;
            this.btnStergeRezervare.Click += new System.EventHandler(this.btnStergeRezervare_Click);
            // 
            // btnModificaRezervare
            // 
            this.btnModificaRezervare.Location = new System.Drawing.Point(661, 94);
            this.btnModificaRezervare.Name = "btnModificaRezervare";
            this.btnModificaRezervare.Size = new System.Drawing.Size(111, 23);
            this.btnModificaRezervare.TabIndex = 10;
            this.btnModificaRezervare.Text = "Modificare rezervare";
            this.btnModificaRezervare.UseVisualStyleBackColor = true;
            this.btnModificaRezervare.Click += new System.EventHandler(this.btnModificaRezervare_Click);
            // 
            // btnRezervareNoua
            // 
            this.btnRezervareNoua.Location = new System.Drawing.Point(661, 65);
            this.btnRezervareNoua.Name = "btnRezervareNoua";
            this.btnRezervareNoua.Size = new System.Drawing.Size(111, 23);
            this.btnRezervareNoua.TabIndex = 9;
            this.btnRezervareNoua.Text = "Rezervare noua";
            this.btnRezervareNoua.UseVisualStyleBackColor = true;
            this.btnRezervareNoua.Click += new System.EventHandler(this.btnRezervareNoua_Click);
            // 
            // txtIdComanda
            // 
            this.txtIdComanda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervariBindingSource, "IdRezervare", true));
            this.txtIdComanda.Enabled = false;
            this.txtIdComanda.Location = new System.Drawing.Point(661, 39);
            this.txtIdComanda.Name = "txtIdComanda";
            this.txtIdComanda.Size = new System.Drawing.Size(111, 20);
            this.txtIdComanda.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRezervareDataGridViewTextBoxColumn1,
            this.nrcDataGridViewTextBoxColumn,
            this.idCameraDataGridViewTextBoxColumn,
            this.dataCazariiDataGridViewTextBoxColumn,
            this.pretZiDataGridViewTextBoxColumn,
            this.nrZileDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rezervariContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(28, 261);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(744, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRezervareDataGridViewTextBoxColumn,
            this.numeClientDataGridViewTextBoxColumn,
            this.dataRezervariiDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(562, 197);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervariBindingSource
            // 
            this.rezervariBindingSource.DataMember = "Rezervari";
            this.rezervariBindingSource.DataSource = this.dataSet2;
            this.rezervariBindingSource.PositionChanged += new System.EventHandler(this.rezervariBindingSource_PositionChanged);
            // 
            // rezervariTableAdapter
            // 
            this.rezervariTableAdapter.ClearBeforeFill = true;
            // 
            // rezervariContinutBindingSource
            // 
            this.rezervariContinutBindingSource.DataMember = "RezervariContinut";
            this.rezervariContinutBindingSource.DataSource = this.dataSet2;
            // 
            // rezervariContinutTableAdapter
            // 
            this.rezervariContinutTableAdapter.ClearBeforeFill = true;
            // 
            // idRezervareDataGridViewTextBoxColumn1
            // 
            this.idRezervareDataGridViewTextBoxColumn1.DataPropertyName = "IdRezervare";
            this.idRezervareDataGridViewTextBoxColumn1.HeaderText = "IdRezervare";
            this.idRezervareDataGridViewTextBoxColumn1.Name = "idRezervareDataGridViewTextBoxColumn1";
            this.idRezervareDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCameraDataGridViewTextBoxColumn
            // 
            this.idCameraDataGridViewTextBoxColumn.DataPropertyName = "IdCamera";
            this.idCameraDataGridViewTextBoxColumn.HeaderText = "IdCamera";
            this.idCameraDataGridViewTextBoxColumn.Name = "idCameraDataGridViewTextBoxColumn";
            this.idCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCazariiDataGridViewTextBoxColumn
            // 
            this.dataCazariiDataGridViewTextBoxColumn.DataPropertyName = "DataCazarii";
            this.dataCazariiDataGridViewTextBoxColumn.HeaderText = "DataCazarii";
            this.dataCazariiDataGridViewTextBoxColumn.Name = "dataCazariiDataGridViewTextBoxColumn";
            this.dataCazariiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretZiDataGridViewTextBoxColumn
            // 
            this.pretZiDataGridViewTextBoxColumn.DataPropertyName = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.HeaderText = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.Name = "pretZiDataGridViewTextBoxColumn";
            this.pretZiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrZileDataGridViewTextBoxColumn
            // 
            this.nrZileDataGridViewTextBoxColumn.DataPropertyName = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.HeaderText = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.Name = "nrZileDataGridViewTextBoxColumn";
            this.nrZileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idRezervareDataGridViewTextBoxColumn
            // 
            this.idRezervareDataGridViewTextBoxColumn.DataPropertyName = "IdRezervare";
            this.idRezervareDataGridViewTextBoxColumn.HeaderText = "IdRezervare";
            this.idRezervareDataGridViewTextBoxColumn.Name = "idRezervareDataGridViewTextBoxColumn";
            this.idRezervareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeClientDataGridViewTextBoxColumn
            // 
            this.numeClientDataGridViewTextBoxColumn.DataPropertyName = "NumeClient";
            this.numeClientDataGridViewTextBoxColumn.HeaderText = "NumeClient";
            this.numeClientDataGridViewTextBoxColumn.Name = "numeClientDataGridViewTextBoxColumn";
            this.numeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRezervariiDataGridViewTextBoxColumn
            // 
            this.dataRezervariiDataGridViewTextBoxColumn.DataPropertyName = "DataRezervarii";
            this.dataRezervariiDataGridViewTextBoxColumn.HeaderText = "DataRezervarii";
            this.dataRezervariiDataGridViewTextBoxColumn.Name = "dataRezervariiDataGridViewTextBoxColumn";
            this.dataRezervariiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Rezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStergeRezervare);
            this.Controls.Add(this.btnModificaRezervare);
            this.Controls.Add(this.btnRezervareNoua);
            this.Controls.Add(this.txtIdComanda);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rezervari";
            this.Text = "Rezervari";
            this.Load += new System.EventHandler(this.Rezervari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStergeRezervare;
        private System.Windows.Forms.Button btnModificaRezervare;
        private System.Windows.Forms.Button btnRezervareNoua;
        private System.Windows.Forms.TextBox txtIdComanda;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource rezervariBindingSource;
        private DataSet2TableAdapters.RezervariTableAdapter rezervariTableAdapter;
        private System.Windows.Forms.BindingSource rezervariContinutBindingSource;
        private DataSet2TableAdapters.RezervariContinutTableAdapter rezervariContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRezervareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCazariiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRezervareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRezervariiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}