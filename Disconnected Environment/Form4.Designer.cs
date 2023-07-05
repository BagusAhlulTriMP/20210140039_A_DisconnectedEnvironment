namespace Disconnected_Environment
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBDisconnectedEnvironmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_DisconnectedEnvironmentDataSet = new Disconnected_Environment.DB_DisconnectedEnvironmentDataSet();
            this.NamaMahasiswa = new System.Windows.Forms.Label();
            this.NIM = new System.Windows.Forms.Label();
            this.StatusMahasiswa = new System.Windows.Forms.Label();
            this.TahunMasuk = new System.Windows.Forms.Label();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtNIM = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDisconnectedEnvironmentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DisconnectedEnvironmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dBDisconnectedEnvironmentDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // dBDisconnectedEnvironmentDataSetBindingSource
            // 
            this.dBDisconnectedEnvironmentDataSetBindingSource.DataSource = this.dB_DisconnectedEnvironmentDataSet;
            this.dBDisconnectedEnvironmentDataSetBindingSource.Position = 0;
            // 
            // dB_DisconnectedEnvironmentDataSet
            // 
            this.dB_DisconnectedEnvironmentDataSet.DataSetName = "DB_DisconnectedEnvironmentDataSet";
            this.dB_DisconnectedEnvironmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NamaMahasiswa
            // 
            this.NamaMahasiswa.AutoSize = true;
            this.NamaMahasiswa.Location = new System.Drawing.Point(20, 223);
            this.NamaMahasiswa.Name = "NamaMahasiswa";
            this.NamaMahasiswa.Size = new System.Drawing.Size(115, 16);
            this.NamaMahasiswa.TabIndex = 1;
            this.NamaMahasiswa.Text = "Nama Mahasiswa";
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(20, 262);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(154, 16);
            this.NIM.TabIndex = 2;
            this.NIM.Text = "Nomor Induk Mahasiswa";
            this.NIM.Click += new System.EventHandler(this.label2_Click);
            // 
            // StatusMahasiswa
            // 
            this.StatusMahasiswa.AutoSize = true;
            this.StatusMahasiswa.Location = new System.Drawing.Point(20, 297);
            this.StatusMahasiswa.Name = "StatusMahasiswa";
            this.StatusMahasiswa.Size = new System.Drawing.Size(115, 16);
            this.StatusMahasiswa.TabIndex = 3;
            this.StatusMahasiswa.Text = "Status Mahasiswa";
            // 
            // TahunMasuk
            // 
            this.TahunMasuk.AutoSize = true;
            this.TahunMasuk.Location = new System.Drawing.Point(20, 337);
            this.TahunMasuk.Name = "TahunMasuk";
            this.TahunMasuk.Size = new System.Drawing.Size(88, 16);
            this.TahunMasuk.TabIndex = 4;
            this.TahunMasuk.Text = "Tahun Masuk";
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Items.AddRange(new object[] {
            "Bagus Ahlul",
            "Indra",
            "Adityo Arya"});
            this.cbxNama.Location = new System.Drawing.Point(190, 220);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(171, 24);
            this.cbxNama.TabIndex = 5;
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(190, 289);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(171, 24);
            this.cbxStatusMahasiswa.TabIndex = 6;
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(190, 337);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(171, 24);
            this.cbxTahunMasuk.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(389, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(389, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(389, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(545, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(187, 262);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(43, 16);
            this.txtNIM.TabIndex = 12;
            this.txtNIM.Text = "txtNIM";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.TahunMasuk);
            this.Controls.Add(this.StatusMahasiswa);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.NamaMahasiswa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Data Status Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDisconnectedEnvironmentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DisconnectedEnvironmentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dBDisconnectedEnvironmentDataSetBindingSource;
        private DB_DisconnectedEnvironmentDataSet dB_DisconnectedEnvironmentDataSet;
        private System.Windows.Forms.Label NamaMahasiswa;
        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label StatusMahasiswa;
        private System.Windows.Forms.Label TahunMasuk;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.Button button5;
    }
}