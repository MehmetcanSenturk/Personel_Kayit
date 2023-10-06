namespace Personel_Kayit
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grPersonelKayit = new System.Windows.Forms.GroupBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.lblpermaas = new System.Windows.Forms.Label();
            this.mskdmaas = new System.Windows.Forms.MaskedTextBox();
            this.lblpermeslek = new System.Windows.Forms.Label();
            this.rdbutbekar = new System.Windows.Forms.RadioButton();
            this.rdbutevli = new System.Windows.Forms.RadioButton();
            this.lblperdurum = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.lblpersehir = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblpersoyad = new System.Windows.Forms.Label();
            this.txtpersonelAd = new System.Windows.Forms.TextBox();
            this.lblperad = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblperid = new System.Windows.Forms.Label();
            this.grislemler = new System.Windows.Forms.GroupBox();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.grKayitlar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.grPersonelKayit.SuspendLayout();
            this.grislemler.SuspendLayout();
            this.grKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grPersonelKayit
            // 
            this.grPersonelKayit.BackColor = System.Drawing.Color.DarkCyan;
            this.grPersonelKayit.Controls.Add(this.txtMeslek);
            this.grPersonelKayit.Controls.Add(this.lblpermaas);
            this.grPersonelKayit.Controls.Add(this.mskdmaas);
            this.grPersonelKayit.Controls.Add(this.lblpermeslek);
            this.grPersonelKayit.Controls.Add(this.rdbutbekar);
            this.grPersonelKayit.Controls.Add(this.rdbutevli);
            this.grPersonelKayit.Controls.Add(this.lblperdurum);
            this.grPersonelKayit.Controls.Add(this.cmbSehir);
            this.grPersonelKayit.Controls.Add(this.lblpersehir);
            this.grPersonelKayit.Controls.Add(this.txtSoyad);
            this.grPersonelKayit.Controls.Add(this.lblpersoyad);
            this.grPersonelKayit.Controls.Add(this.txtpersonelAd);
            this.grPersonelKayit.Controls.Add(this.lblperad);
            this.grPersonelKayit.Controls.Add(this.txtid);
            this.grPersonelKayit.Controls.Add(this.lblperid);
            this.grPersonelKayit.Location = new System.Drawing.Point(12, 8);
            this.grPersonelKayit.Name = "grPersonelKayit";
            this.grPersonelKayit.Size = new System.Drawing.Size(332, 351);
            this.grPersonelKayit.TabIndex = 0;
            this.grPersonelKayit.TabStop = false;
            this.grPersonelKayit.Text = "Personel Kayıt";
            this.grPersonelKayit.Enter += new System.EventHandler(this.grPersonelKayit_Enter);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(108, 264);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(100, 31);
            this.txtMeslek.TabIndex = 6;
            // 
            // lblpermaas
            // 
            this.lblpermaas.AutoSize = true;
            this.lblpermaas.Location = new System.Drawing.Point(48, 196);
            this.lblpermaas.Name = "lblpermaas";
            this.lblpermaas.Size = new System.Drawing.Size(57, 23);
            this.lblpermaas.TabIndex = 16;
            this.lblpermaas.Text = "Maaş:";
            // 
            // mskdmaas
            // 
            this.mskdmaas.Location = new System.Drawing.Point(108, 193);
            this.mskdmaas.Mask = "0000";
            this.mskdmaas.Name = "mskdmaas";
            this.mskdmaas.Size = new System.Drawing.Size(100, 31);
            this.mskdmaas.TabIndex = 5;
            this.mskdmaas.ValidatingType = typeof(int);
            // 
            // lblpermeslek
            // 
            this.lblpermeslek.AutoSize = true;
            this.lblpermeslek.Location = new System.Drawing.Point(32, 272);
            this.lblpermeslek.Name = "lblpermeslek";
            this.lblpermeslek.Size = new System.Drawing.Size(70, 23);
            this.lblpermeslek.TabIndex = 14;
            this.lblpermeslek.Text = "Meslek:";
            // 
            // rdbutbekar
            // 
            this.rdbutbekar.AutoSize = true;
            this.rdbutbekar.Location = new System.Drawing.Point(169, 228);
            this.rdbutbekar.Name = "rdbutbekar";
            this.rdbutbekar.Size = new System.Drawing.Size(72, 27);
            this.rdbutbekar.TabIndex = 13;
            this.rdbutbekar.TabStop = true;
            this.rdbutbekar.Text = "Bekar";
            this.rdbutbekar.UseVisualStyleBackColor = true;
            this.rdbutbekar.CheckedChanged += new System.EventHandler(this.rdbutbekar_CheckedChanged);
            // 
            // rdbutevli
            // 
            this.rdbutevli.AutoSize = true;
            this.rdbutevli.Location = new System.Drawing.Point(108, 230);
            this.rdbutevli.Name = "rdbutevli";
            this.rdbutevli.Size = new System.Drawing.Size(55, 27);
            this.rdbutevli.TabIndex = 12;
            this.rdbutevli.TabStop = true;
            this.rdbutevli.Text = "Evli";
            this.rdbutevli.UseVisualStyleBackColor = true;
            this.rdbutevli.CheckedChanged += new System.EventHandler(this.rdbutevli_CheckedChanged);
            // 
            // lblperdurum
            // 
            this.lblperdurum.AutoSize = true;
            this.lblperdurum.Location = new System.Drawing.Point(32, 232);
            this.lblperdurum.Name = "lblperdurum";
            this.lblperdurum.Size = new System.Drawing.Size(70, 23);
            this.lblperdurum.TabIndex = 10;
            this.lblperdurum.Text = "Durum:";
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(108, 151);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(100, 31);
            this.cmbSehir.TabIndex = 4;
            // 
            // lblpersehir
            // 
            this.lblpersehir.AutoSize = true;
            this.lblpersehir.Location = new System.Drawing.Point(48, 154);
            this.lblpersehir.Name = "lblpersehir";
            this.lblpersehir.Size = new System.Drawing.Size(54, 23);
            this.lblpersehir.TabIndex = 6;
            this.lblpersehir.Text = "Şehir:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(108, 114);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 31);
            this.txtSoyad.TabIndex = 3;
            // 
            // lblpersoyad
            // 
            this.lblpersoyad.AutoSize = true;
            this.lblpersoyad.Location = new System.Drawing.Point(39, 114);
            this.lblpersoyad.Name = "lblpersoyad";
            this.lblpersoyad.Size = new System.Drawing.Size(63, 23);
            this.lblpersoyad.TabIndex = 4;
            this.lblpersoyad.Text = "Soyad:";
            // 
            // txtpersonelAd
            // 
            this.txtpersonelAd.Location = new System.Drawing.Point(108, 74);
            this.txtpersonelAd.Name = "txtpersonelAd";
            this.txtpersonelAd.Size = new System.Drawing.Size(100, 31);
            this.txtpersonelAd.TabIndex = 2;
            // 
            // lblperad
            // 
            this.lblperad.AutoSize = true;
            this.lblperad.Location = new System.Drawing.Point(3, 77);
            this.lblperad.Name = "lblperad";
            this.lblperad.Size = new System.Drawing.Size(106, 23);
            this.lblperad.TabIndex = 2;
            this.lblperad.Text = "Personel Ad:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(108, 40);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 31);
            this.txtid.TabIndex = 1;
            // 
            // lblperid
            // 
            this.lblperid.AutoSize = true;
            this.lblperid.Location = new System.Drawing.Point(3, 40);
            this.lblperid.Name = "lblperid";
            this.lblperid.Size = new System.Drawing.Size(99, 23);
            this.lblperid.TabIndex = 15;
            this.lblperid.Text = "Personel id:";
            // 
            // grislemler
            // 
            this.grislemler.BackColor = System.Drawing.Color.DarkCyan;
            this.grislemler.Controls.Add(this.btnRaporlar);
            this.grislemler.Controls.Add(this.btngrafik);
            this.grislemler.Controls.Add(this.btnistatistik);
            this.grislemler.Controls.Add(this.btntemizle);
            this.grislemler.Controls.Add(this.btngüncelle);
            this.grislemler.Controls.Add(this.btnsil);
            this.grislemler.Controls.Add(this.btnkaydet);
            this.grislemler.Controls.Add(this.btnlistele);
            this.grislemler.Location = new System.Drawing.Point(350, 8);
            this.grislemler.Name = "grislemler";
            this.grislemler.Size = new System.Drawing.Size(221, 351);
            this.grislemler.TabIndex = 1;
            this.grislemler.TabStop = false;
            this.grislemler.Text = "İşlemler";
            this.grislemler.Enter += new System.EventHandler(this.grislemler_Enter);
            // 
            // btngrafik
            // 
            this.btngrafik.Location = new System.Drawing.Point(69, 261);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(93, 35);
            this.btngrafik.TabIndex = 8;
            this.btngrafik.Text = "Grafikler";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(69, 222);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(93, 35);
            this.btnistatistik.TabIndex = 7;
            this.btnistatistik.Text = "İstatistik";
            this.btnistatistik.UseVisualStyleBackColor = true;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(69, 183);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(93, 35);
            this.btntemizle.TabIndex = 6;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(69, 142);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(93, 35);
            this.btngüncelle.TabIndex = 5;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(69, 102);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(93, 35);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(69, 65);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(93, 35);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(69, 28);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(93, 35);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // grKayitlar
            // 
            this.grKayitlar.Controls.Add(this.dataGridView1);
            this.grKayitlar.Location = new System.Drawing.Point(12, 365);
            this.grKayitlar.Name = "grKayitlar";
            this.grKayitlar.Size = new System.Drawing.Size(747, 300);
            this.grKayitlar.TabIndex = 2;
            this.grKayitlar.TabStop = false;
            this.grKayitlar.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(577, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(69, 302);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(93, 35);
            this.btnRaporlar.TabIndex = 9;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(760, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grKayitlar);
            this.Controls.Add(this.grislemler);
            this.Controls.Add(this.grPersonelKayit);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grPersonelKayit.ResumeLayout(false);
            this.grPersonelKayit.PerformLayout();
            this.grislemler.ResumeLayout(false);
            this.grKayitlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grPersonelKayit;
        private System.Windows.Forms.RadioButton rdbutbekar;
        private System.Windows.Forms.RadioButton rdbutevli;
        private System.Windows.Forms.Label lblperdurum;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label lblpersehir;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblpersoyad;
        private System.Windows.Forms.TextBox txtpersonelAd;
        private System.Windows.Forms.Label lblperad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblperid;
        private System.Windows.Forms.Label lblpermeslek;
        private System.Windows.Forms.GroupBox grislemler;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox grKayitlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label lblpermaas;
        private System.Windows.Forms.MaskedTextBox mskdmaas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRaporlar;
    }
}

