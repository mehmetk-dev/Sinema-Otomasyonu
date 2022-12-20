namespace Sinema
{
    partial class personel_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel_ekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uyeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeler1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.üyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.üyeler = new Sinema.üyeler();
            this.label5 = new System.Windows.Forms.Label();
            this.sinemadbDataSet = new Sinema.sinemadbDataSet();
            this.uyeler1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyeler1TableAdapter = new Sinema.sinemadbDataSetTableAdapters.uyeler1TableAdapter();
            this.sinemadbDataSet1 = new Sinema.sinemadbDataSet1();
            this.uyeler1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uyeler1TableAdapter1 = new Sinema.sinemadbDataSet1TableAdapters.uyeler1TableAdapter();
            this.sinemadbDataSet3 = new Sinema.sinemadbDataSet3();
            this.sinemadbDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyeler1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uyeler1TableAdapter2 = new Sinema.sinemadbDataSet3TableAdapters.uyeler1TableAdapter();
            this.uyeler1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.uyeler1TableAdapter3 = new Sinema.üyelerTableAdapters.uyeler1TableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.üyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.üyeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(34, 141);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(63, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personel Ekle";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(57, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ad Soyad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyeid,
            this.adsoyad,
            this.kullanıcıadı,
            this.sifre});
            this.dataGridView1.Location = new System.Drawing.Point(344, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uyeid
            // 
            this.uyeid.HeaderText = "Üye ID";
            this.uyeid.Name = "uyeid";
            this.uyeid.ReadOnly = true;
            // 
            // adsoyad
            // 
            this.adsoyad.HeaderText = "Ad Soyad";
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.ReadOnly = true;
            // 
            // kullanıcıadı
            // 
            this.kullanıcıadı.HeaderText = "Kullanıcı Adı";
            this.kullanıcıadı.Name = "kullanıcıadı";
            this.kullanıcıadı.ReadOnly = true;
            // 
            // sifre
            // 
            this.sifre.HeaderText = "Şifre";
            this.sifre.Name = "sifre";
            this.sifre.ReadOnly = true;
            // 
            // uyeler1BindingSource4
            // 
            this.uyeler1BindingSource4.DataMember = "uyeler1";
            this.uyeler1BindingSource4.DataSource = this.üyelerBindingSource;
            // 
            // üyelerBindingSource
            // 
            this.üyelerBindingSource.DataSource = this.üyeler;
            this.üyelerBindingSource.Position = 0;
            // 
            // üyeler
            // 
            this.üyeler.DataSetName = "üyeler";
            this.üyeler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(475, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Personel Bilgileri";
            // 
            // sinemadbDataSet
            // 
            this.sinemadbDataSet.DataSetName = "sinemadbDataSet";
            this.sinemadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeler1BindingSource
            // 
            this.uyeler1BindingSource.DataMember = "uyeler1";
            this.uyeler1BindingSource.DataSource = this.sinemadbDataSet;
            // 
            // uyeler1TableAdapter
            // 
            this.uyeler1TableAdapter.ClearBeforeFill = true;
            // 
            // sinemadbDataSet1
            // 
            this.sinemadbDataSet1.DataSetName = "sinemadbDataSet1";
            this.sinemadbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeler1BindingSource1
            // 
            this.uyeler1BindingSource1.DataMember = "uyeler1";
            this.uyeler1BindingSource1.DataSource = this.sinemadbDataSet1;
            // 
            // uyeler1TableAdapter1
            // 
            this.uyeler1TableAdapter1.ClearBeforeFill = true;
            // 
            // sinemadbDataSet3
            // 
            this.sinemadbDataSet3.DataSetName = "sinemadbDataSet3";
            this.sinemadbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinemadbDataSet3BindingSource
            // 
            this.sinemadbDataSet3BindingSource.DataSource = this.sinemadbDataSet3;
            this.sinemadbDataSet3BindingSource.Position = 0;
            // 
            // uyeler1BindingSource2
            // 
            this.uyeler1BindingSource2.DataMember = "uyeler1";
            this.uyeler1BindingSource2.DataSource = this.sinemadbDataSet3BindingSource;
            // 
            // uyeler1TableAdapter2
            // 
            this.uyeler1TableAdapter2.ClearBeforeFill = true;
            // 
            // uyeler1BindingSource3
            // 
            this.uyeler1BindingSource3.DataMember = "uyeler1";
            this.uyeler1BindingSource3.DataSource = this.üyeler;
            // 
            // uyeler1TableAdapter3
            // 
            this.uyeler1TableAdapter3.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(434, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personel Bilgileri Güncelle";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(532, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(532, 334);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(532, 368);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(134, 20);
            this.textBox6.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(400, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ad Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(400, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Şifre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(400, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(93, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Personel Sil";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(77, 337);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(180, 20);
            this.textBox7.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(74, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Silinecek personelin ID\'si";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 32);
            this.button3.TabIndex = 22;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(716, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 48);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "geri.png");
            // 
            // personel_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 480);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "personel_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Bilgileri";
            this.Load += new System.EventHandler(this.personel_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.üyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.üyeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeler1BindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private sinemadbDataSet sinemadbDataSet;
        private System.Windows.Forms.BindingSource uyeler1BindingSource;
        private sinemadbDataSetTableAdapters.uyeler1TableAdapter uyeler1TableAdapter;
        private sinemadbDataSet1 sinemadbDataSet1;
        private System.Windows.Forms.BindingSource uyeler1BindingSource1;
        private sinemadbDataSet1TableAdapters.uyeler1TableAdapter uyeler1TableAdapter1;
        private System.Windows.Forms.BindingSource sinemadbDataSet3BindingSource;
        private sinemadbDataSet3 sinemadbDataSet3;
        private System.Windows.Forms.BindingSource uyeler1BindingSource2;
        private sinemadbDataSet3TableAdapters.uyeler1TableAdapter uyeler1TableAdapter2;
        private üyeler üyeler;
        private System.Windows.Forms.BindingSource uyeler1BindingSource3;
        private üyelerTableAdapters.uyeler1TableAdapter uyeler1TableAdapter3;
        private System.Windows.Forms.BindingSource uyeler1BindingSource4;
        private System.Windows.Forms.BindingSource üyelerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList ımageList1;
    }
}