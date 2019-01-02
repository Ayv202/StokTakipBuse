namespace SLNStokTakip.Fatura
{
    partial class frmFaturaKes
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.txtToplamT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtAraT = new System.Windows.Forms.TextBox();
            this.cbUrun = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCollaps = new System.Windows.Forms.Button();
            this.chbManuel = new System.Windows.Forms.CheckBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTcV = new System.Windows.Forms.TextBox();
            this.txtVd = new System.Windows.Forms.TextBox();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCariAdi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGenelNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CikisKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKesNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarih :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kayıt No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cari Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(94, 98);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(177, 20);
            this.dtpTarih.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKaydet.Location = new System.Drawing.Point(0, 373);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(279, 63);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Liste);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer2.Panel2.Controls.Add(this.btnSil);
            this.splitContainer2.Panel2.Controls.Add(this.txtYazi);
            this.splitContainer2.Panel2.Controls.Add(this.txtToplamT);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.txtKdv);
            this.splitContainer2.Panel2.Controls.Add(this.txtAraT);
            this.splitContainer2.Panel2.Controls.Add(this.cbUrun);
            this.splitContainer2.Panel2.Controls.Add(this.btnPrint);
            this.splitContainer2.Size = new System.Drawing.Size(658, 440);
            this.splitContainer2.SplitterDistance = 317;
            this.splitContainer2.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CikisKodu,
            this.FKesNo,
            this.UrunKodu,
            this.Lot,
            this.Aciklama,
            this.Adet,
            this.BFiyat,
            this.Tutar});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(654, 313);
            this.Liste.TabIndex = 0;
            this.Liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellClick);
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(81, 82);
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(492, 20);
            this.txtYazi.TabIndex = 6;
            // 
            // txtToplamT
            // 
            this.txtToplamT.Location = new System.Drawing.Point(448, 56);
            this.txtToplamT.Name = "txtToplamT";
            this.txtToplamT.Size = new System.Drawing.Size(125, 20);
            this.txtToplamT.TabIndex = 2;
            this.txtToplamT.TextChanged += new System.EventHandler(this.txtToplamT_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(345, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Toplam Tutar :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(361, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "KDV %18 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(361, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ara Toplam :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKdv
            // 
            this.txtKdv.Location = new System.Drawing.Point(448, 30);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(125, 20);
            this.txtKdv.TabIndex = 2;
            // 
            // txtAraT
            // 
            this.txtAraT.Location = new System.Drawing.Point(448, 4);
            this.txtAraT.Name = "txtAraT";
            this.txtAraT.Size = new System.Drawing.Size(125, 20);
            this.txtAraT.TabIndex = 2;
            // 
            // cbUrun
            // 
            this.cbUrun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbUrun.FormattingEnabled = true;
            this.cbUrun.Location = new System.Drawing.Point(81, 3);
            this.cbUrun.Name = "cbUrun";
            this.cbUrun.Size = new System.Drawing.Size(121, 21);
            this.cbUrun.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrint.Location = new System.Drawing.Point(0, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 115);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.btnCollaps);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.chbManuel);
            this.splitContainer1.Panel2.Controls.Add(this.txtAdres);
            this.splitContainer1.Panel2.Controls.Add(this.txtTcV);
            this.splitContainer1.Panel2.Controls.Add(this.txtVd);
            this.splitContainer1.Panel2.Controls.Add(this.txtEvrakNo);
            this.splitContainer1.Panel2.Controls.Add(this.txtSaat);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.dtpTarih);
            this.splitContainer1.Panel2.Controls.Add(this.txtCariAdi);
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(967, 440);
            this.splitContainer1.SplitterDistance = 680;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnCollaps
            // 
            this.btnCollaps.BackColor = System.Drawing.Color.Red;
            this.btnCollaps.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCollaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCollaps.ForeColor = System.Drawing.Color.White;
            this.btnCollaps.Location = new System.Drawing.Point(658, 0);
            this.btnCollaps.Name = "btnCollaps";
            this.btnCollaps.Size = new System.Drawing.Size(22, 440);
            this.btnCollaps.TabIndex = 1;
            this.btnCollaps.Text = "GİZLE";
            this.btnCollaps.UseVisualStyleBackColor = false;
            this.btnCollaps.Click += new System.EventHandler(this.btnCollaps_Click);
            // 
            // chbManuel
            // 
            this.chbManuel.AutoSize = true;
            this.chbManuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbManuel.ForeColor = System.Drawing.Color.White;
            this.chbManuel.Location = new System.Drawing.Point(171, 127);
            this.chbManuel.Name = "chbManuel";
            this.chbManuel.Size = new System.Drawing.Size(96, 17);
            this.chbManuel.TabIndex = 7;
            this.chbManuel.Text = "Manuel Giriş";
            this.chbManuel.UseVisualStyleBackColor = true;
            this.chbManuel.CheckedChanged += new System.EventHandler(this.chbManuel_CheckedChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(94, 214);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(177, 75);
            this.txtAdres.TabIndex = 6;
            this.txtAdres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTcV
            // 
            this.txtTcV.Location = new System.Drawing.Point(94, 188);
            this.txtTcV.Name = "txtTcV";
            this.txtTcV.Size = new System.Drawing.Size(177, 20);
            this.txtTcV.TabIndex = 6;
            this.txtTcV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtVd
            // 
            this.txtVd.Location = new System.Drawing.Point(94, 162);
            this.txtVd.Name = "txtVd";
            this.txtVd.Size = new System.Drawing.Size(177, 20);
            this.txtVd.TabIndex = 6;
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(95, 12);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(176, 20);
            this.txtEvrakNo.TabIndex = 5;
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(95, 124);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(70, 20);
            this.txtSaat.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Adres :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tc :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vergi Dairesi :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(95, 38);
            this.txtCariAdi.Multiline = true;
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(177, 54);
            this.txtCariAdi.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblGenelNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 63);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblGenelNo
            // 
            this.lblGenelNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenelNo.BackColor = System.Drawing.Color.Red;
            this.lblGenelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelNo.ForeColor = System.Drawing.Color.White;
            this.lblGenelNo.Location = new System.Drawing.Point(558, 10);
            this.lblGenelNo.Name = "lblGenelNo";
            this.lblGenelNo.Size = new System.Drawing.Size(100, 44);
            this.lblGenelNo.TabIndex = 4;
            this.lblGenelNo.Text = "**";
            this.lblGenelNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "FATURA KES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKapat.Location = new System.Drawing.Point(683, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(284, 63);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "FORMU KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 41;
            // 
            // CikisKodu
            // 
            this.CikisKodu.HeaderText = "Çıkış Kodu";
            this.CikisKodu.Name = "CikisKodu";
            this.CikisKodu.ReadOnly = true;
            this.CikisKodu.Visible = false;
            // 
            // FKesNo
            // 
            this.FKesNo.HeaderText = "F.KesNo";
            this.FKesNo.Name = "FKesNo";
            this.FKesNo.Visible = false;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunKodu.HeaderText = "Ürün Kodu";
            this.UrunKodu.Name = "UrunKodu";
            this.UrunKodu.ReadOnly = true;
            this.UrunKodu.Width = 83;
            // 
            // Lot
            // 
            this.Lot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lot.HeaderText = "Lot/Seri No";
            this.Lot.Name = "Lot";
            this.Lot.ReadOnly = true;
            this.Lot.Width = 87;
            // 
            // Aciklama
            // 
            this.Aciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Width = 75;
            // 
            // Adet
            // 
            this.Adet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adet.HeaderText = "Çıkış Adet";
            this.Adet.Name = "Adet";
            this.Adet.ReadOnly = true;
            this.Adet.Width = 79;
            // 
            // BFiyat
            // 
            this.BFiyat.HeaderText = "Birim Fiyat";
            this.BFiyat.Name = "BFiyat";
            // 
            // Tutar
            // 
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSil.Location = new System.Drawing.Point(579, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 115);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmFaturaKes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 503);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmFaturaKes";
            this.Text = "frmFaturaKes";
            this.Load += new System.EventHandler(this.frmFaturaKes_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ComboBox cbUrun;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCollaps;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.TextBox txtCariAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGenelNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtToplamT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtAraT;
        private System.Windows.Forms.TextBox txtYazi;
        private System.Windows.Forms.TextBox txtVd;
        private System.Windows.Forms.TextBox txtTcV;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbManuel;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKesNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.Button btnSil;
    }
}