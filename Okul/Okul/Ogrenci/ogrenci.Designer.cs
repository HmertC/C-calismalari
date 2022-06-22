namespace Okul.Ogrenci
{
    partial class ogrenci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egitmenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okulDataSet = new Okul.OkulDataSet();
            this.ogrencilerTableAdapter = new Okul.OkulDataSetTableAdapters.OgrencilerTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.siniflarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okulDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okulDataSet2 = new Okul.OkulDataSet2();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.egitmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okulDataSet3 = new Okul.OkulDataSet3();
            this.siniflarTableAdapter = new Okul.OkulDataSet2TableAdapters.SiniflarTableAdapter();
            this.egitmenTableAdapter = new Okul.OkulDataSet3TableAdapters.EgitmenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OgrenciTC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ogrenci Soyadı : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciNoDataGridViewTextBoxColumn,
            this.ogrenciTCDataGridViewTextBoxColumn,
            this.ogrenciAdiDataGridViewTextBoxColumn,
            this.ogrenciSoyadiDataGridViewTextBoxColumn,
            this.sinifIDDataGridViewTextBoxColumn,
            this.egitmenIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrencilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ogrenciNoDataGridViewTextBoxColumn
            // 
            this.ogrenciNoDataGridViewTextBoxColumn.DataPropertyName = "OgrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.HeaderText = "OgrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.Name = "ogrenciNoDataGridViewTextBoxColumn";
            this.ogrenciNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciTCDataGridViewTextBoxColumn
            // 
            this.ogrenciTCDataGridViewTextBoxColumn.DataPropertyName = "OgrenciTC";
            this.ogrenciTCDataGridViewTextBoxColumn.HeaderText = "OgrenciTC";
            this.ogrenciTCDataGridViewTextBoxColumn.Name = "ogrenciTCDataGridViewTextBoxColumn";
            // 
            // ogrenciAdiDataGridViewTextBoxColumn
            // 
            this.ogrenciAdiDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAdi";
            this.ogrenciAdiDataGridViewTextBoxColumn.HeaderText = "OgrenciAdi";
            this.ogrenciAdiDataGridViewTextBoxColumn.Name = "ogrenciAdiDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadiDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadiDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyadi";
            this.ogrenciSoyadiDataGridViewTextBoxColumn.HeaderText = "OgrenciSoyadi";
            this.ogrenciSoyadiDataGridViewTextBoxColumn.Name = "ogrenciSoyadiDataGridViewTextBoxColumn";
            // 
            // sinifIDDataGridViewTextBoxColumn
            // 
            this.sinifIDDataGridViewTextBoxColumn.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.HeaderText = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.Name = "sinifIDDataGridViewTextBoxColumn";
            // 
            // egitmenIDDataGridViewTextBoxColumn
            // 
            this.egitmenIDDataGridViewTextBoxColumn.DataPropertyName = "EgitmenID";
            this.egitmenIDDataGridViewTextBoxColumn.HeaderText = "EgitmenID";
            this.egitmenIDDataGridViewTextBoxColumn.Name = "egitmenIDDataGridViewTextBoxColumn";
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "Ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.okulDataSet;
            // 
            // okulDataSet
            // 
            this.okulDataSet.DataSetName = "OkulDataSet";
            this.okulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SınıfID : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Egitmen ID : ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.siniflarBindingSource;
            this.comboBox1.DisplayMember = "SinifAdi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(453, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "SinifID";
            // 
            // siniflarBindingSource
            // 
            this.siniflarBindingSource.DataMember = "Siniflar";
            this.siniflarBindingSource.DataSource = this.okulDataSet2BindingSource;
            // 
            // okulDataSet2BindingSource
            // 
            this.okulDataSet2BindingSource.DataSource = this.okulDataSet2;
            this.okulDataSet2BindingSource.Position = 0;
            // 
            // okulDataSet2
            // 
            this.okulDataSet2.DataSetName = "OkulDataSet2";
            this.okulDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.egitmenBindingSource;
            this.comboBox2.DisplayMember = "EgitmenID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(453, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "EgitmenAdi";
            // 
            // egitmenBindingSource
            // 
            this.egitmenBindingSource.DataMember = "Egitmen";
            this.egitmenBindingSource.DataSource = this.okulDataSet3;
            // 
            // okulDataSet3
            // 
            this.okulDataSet3.DataSetName = "OkulDataSet3";
            this.okulDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siniflarTableAdapter
            // 
            this.siniflarTableAdapter.ClearBeforeFill = true;
            // 
            // egitmenTableAdapter
            // 
            this.egitmenTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ogrenci";
            this.Text = "ogrenci";
            this.Load += new System.EventHandler(this.ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OkulDataSet okulDataSet;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private OkulDataSetTableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egitmenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource okulDataSet2BindingSource;
        private OkulDataSet2 okulDataSet2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource siniflarBindingSource;
        private OkulDataSet2TableAdapters.SiniflarTableAdapter siniflarTableAdapter;
        private OkulDataSet3 okulDataSet3;
        private System.Windows.Forms.BindingSource egitmenBindingSource;
        private OkulDataSet3TableAdapters.EgitmenTableAdapter egitmenTableAdapter;
    }
}