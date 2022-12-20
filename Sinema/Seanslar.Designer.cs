namespace Sinema
{
    partial class Seanslar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seanslar));
            this.seanslar1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seansIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seanslar2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemadbDataSet = new Sinema.sinemadbDataSet();
            this.seanslar2TableAdapter = new Sinema.sinemadbDataSetTableAdapters.seanslar2TableAdapter();
            this.seanslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seanslarTableAdapter = new Sinema.sinemadbDataSetTableAdapters.seanslarTableAdapter();
            this.sinemadbDataSet2 = new Sinema.sinemadbDataSet2();
            this.seanslarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seanslarTableAdapter1 = new Sinema.sinemadbDataSet2TableAdapters.seanslarTableAdapter();
            this.sinemadbDataSet1 = new Sinema.sinemadbDataSet1();
            this.seanslarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.seanslarTableAdapter2 = new Sinema.sinemadbDataSet1TableAdapters.seanslarTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.seanslar1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslar2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seansIDDataGridViewTextBoxColumn,
            this.filmAdı,
            this.salonAdı,
            this.tarihDataGridViewTextBoxColumn,
            this.seansDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seanslar2BindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // seansIDDataGridViewTextBoxColumn
            // 
            this.seansIDDataGridViewTextBoxColumn.DataPropertyName = "seansID";
            this.seansIDDataGridViewTextBoxColumn.HeaderText = "Seans ID";
            this.seansIDDataGridViewTextBoxColumn.Name = "seansIDDataGridViewTextBoxColumn";
            this.seansIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdı
            // 
            this.filmAdı.DataPropertyName = "filmAdı";
            this.filmAdı.HeaderText = "Film Adı";
            this.filmAdı.Name = "filmAdı";
            this.filmAdı.ReadOnly = true;
            // 
            // salonAdı
            // 
            this.salonAdı.DataPropertyName = "salonAdı";
            this.salonAdı.HeaderText = "Salon Adı";
            this.salonAdı.Name = "salonAdı";
            this.salonAdı.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seansDataGridViewTextBoxColumn
            // 
            this.seansDataGridViewTextBoxColumn.DataPropertyName = "seans";
            this.seansDataGridViewTextBoxColumn.HeaderText = "Seans Saati";
            this.seansDataGridViewTextBoxColumn.Name = "seansDataGridViewTextBoxColumn";
            this.seansDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seanslar2BindingSource
            // 
            this.seanslar2BindingSource.DataMember = "seanslar2";
            this.seanslar2BindingSource.DataSource = this.sinemadbDataSet;
            // 
            // sinemadbDataSet
            // 
            this.sinemadbDataSet.DataSetName = "sinemadbDataSet";
            this.sinemadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seanslar2TableAdapter
            // 
            this.seanslar2TableAdapter.ClearBeforeFill = true;
            // 
            // seanslarBindingSource
            // 
            this.seanslarBindingSource.DataMember = "seanslar";
            this.seanslarBindingSource.DataSource = this.sinemadbDataSet;
            // 
            // seanslarTableAdapter
            // 
            this.seanslarTableAdapter.ClearBeforeFill = true;
            // 
            // sinemadbDataSet2
            // 
            this.sinemadbDataSet2.DataSetName = "sinemadbDataSet2";
            this.sinemadbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seanslarBindingSource1
            // 
            this.seanslarBindingSource1.DataMember = "seanslar";
            this.seanslarBindingSource1.DataSource = this.sinemadbDataSet2;
            // 
            // seanslarTableAdapter1
            // 
            this.seanslarTableAdapter1.ClearBeforeFill = true;
            // 
            // sinemadbDataSet1
            // 
            this.sinemadbDataSet1.DataSetName = "sinemadbDataSet1";
            this.sinemadbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seanslarBindingSource2
            // 
            this.seanslarBindingSource2.DataMember = "seanslar";
            this.seanslarBindingSource2.DataSource = this.sinemadbDataSet1;
            // 
            // seanslarTableAdapter2
            // 
            this.seanslarTableAdapter2.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, 239);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(307, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silinecek Olan Seansın ID\'sini Girin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageKey = "geri.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(490, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 38);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "geri.png");
            // 
            // Seanslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 288);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Seanslar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seanslar";
            this.Load += new System.EventHandler(this.Seanslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seanslar1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslar2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private sinemadbDataSetTableAdapters.seanslar2TableAdapter seanslar2TableAdapter;
        private System.Windows.Forms.BindingSource seanslar1BindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sinemadbDataSet sinemadbDataSet;
        private System.Windows.Forms.BindingSource seanslarBindingSource;
        private sinemadbDataSetTableAdapters.seanslarTableAdapter seanslarTableAdapter;
        private sinemadbDataSet2 sinemadbDataSet2;
        private System.Windows.Forms.BindingSource seanslarBindingSource1;
        private sinemadbDataSet2TableAdapters.seanslarTableAdapter seanslarTableAdapter1;
        private sinemadbDataSet1 sinemadbDataSet1;
        private System.Windows.Forms.BindingSource seanslarBindingSource2;
        private sinemadbDataSet1TableAdapters.seanslarTableAdapter seanslarTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seanslar2BindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}