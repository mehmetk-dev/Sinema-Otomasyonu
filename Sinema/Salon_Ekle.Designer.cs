namespace Sinema
{
    partial class Salon_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salon_Ekle));
            this.label1 = new System.Windows.Forms.Label();
            this.salontxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataSet1 = new Sinema.DataSet1();
            this.salonbilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonbilgileriTableAdapter = new Sinema.DataSet1TableAdapters.salonbilgileriTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.salonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemadbDataSet1 = new Sinema.sinemadbDataSet1();
            this.sinemadbDataSet = new Sinema.sinemadbDataSet();
            this.salonbilgileriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salonbilgileriTableAdapter1 = new Sinema.sinemadbDataSetTableAdapters.salonbilgileriTableAdapter();
            this.salonbilgileriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.salonlarTableAdapter = new Sinema.sinemadbDataSet1TableAdapters.salonlarTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgileriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgileriBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(32, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eklemek İstediğiniz Salon İsmini Girin";
            // 
            // salontxt
            // 
            this.salontxt.Location = new System.Drawing.Point(43, 156);
            this.salontxt.Name = "salontxt";
            this.salontxt.Size = new System.Drawing.Size(100, 20);
            this.salontxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageKey = "geri.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(313, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 33);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "geri.png");
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonbilgileriBindingSource
            // 
            this.salonbilgileriBindingSource.DataMember = "salonbilgileri";
            this.salonbilgileriBindingSource.DataSource = this.dataSet1;
            // 
            // salonbilgileriTableAdapter
            // 
            this.salonbilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salonIDDataGridViewTextBoxColumn,
            this.salonAdıDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.salonlarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(303, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 8;
            // 
            // salonIDDataGridViewTextBoxColumn
            // 
            this.salonIDDataGridViewTextBoxColumn.DataPropertyName = "salonID";
            this.salonIDDataGridViewTextBoxColumn.HeaderText = "Salon ID";
            this.salonIDDataGridViewTextBoxColumn.Name = "salonIDDataGridViewTextBoxColumn";
            this.salonIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salonAdıDataGridViewTextBoxColumn
            // 
            this.salonAdıDataGridViewTextBoxColumn.DataPropertyName = "Salon Adı";
            this.salonAdıDataGridViewTextBoxColumn.HeaderText = "Salon Adı";
            this.salonAdıDataGridViewTextBoxColumn.Name = "salonAdıDataGridViewTextBoxColumn";
            this.salonAdıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salonlarBindingSource
            // 
            this.salonlarBindingSource.DataMember = "salonlar";
            this.salonlarBindingSource.DataSource = this.sinemadbDataSet1;
            // 
            // sinemadbDataSet1
            // 
            this.sinemadbDataSet1.DataSetName = "sinemadbDataSet1";
            this.sinemadbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinemadbDataSet
            // 
            this.sinemadbDataSet.DataSetName = "sinemadbDataSet";
            this.sinemadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonbilgileriBindingSource1
            // 
            this.salonbilgileriBindingSource1.DataMember = "salonbilgileri";
            this.salonbilgileriBindingSource1.DataSource = this.sinemadbDataSet;
            // 
            // salonbilgileriTableAdapter1
            // 
            this.salonbilgileriTableAdapter1.ClearBeforeFill = true;
            // 
            // salonbilgileriBindingSource2
            // 
            this.salonbilgileriBindingSource2.DataMember = "salonbilgileri";
            this.salonbilgileriBindingSource2.DataSource = this.sinemadbDataSet;
            // 
            // salonlarTableAdapter
            // 
            this.salonlarTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(39, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Silinecek Salon ID\'sini Girin";
            // 
            // Salon_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salontxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Salon_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon Bilgileri";
            this.Load += new System.EventHandler(this.Salon_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgileriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgileriBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salontxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource salonbilgileriBindingSource;
        private DataSet1TableAdapters.salonbilgileriTableAdapter salonbilgileriTableAdapter;
        private sinemadbDataSet sinemadbDataSet;
        private System.Windows.Forms.BindingSource salonbilgileriBindingSource1;
        private sinemadbDataSetTableAdapters.salonbilgileriTableAdapter salonbilgileriTableAdapter1;
        private System.Windows.Forms.BindingSource salonbilgileriBindingSource2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private sinemadbDataSet1 sinemadbDataSet1;
        private System.Windows.Forms.BindingSource salonlarBindingSource;
        private sinemadbDataSet1TableAdapters.salonlarTableAdapter salonlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}