namespace Hastane
{
    partial class Hasta
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.doktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new Hastane.HastaneDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet1 = new Hastane.HastaneDataSet1();
            this.hastaTableAdapter = new Hastane.HastaneDataSet1TableAdapters.HastaTableAdapter();
            this.doktorTableAdapter = new Hastane.HastaneDataSetTableAdapters.DoktorTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı :  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Soyadı  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doktor : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.doktorBindingSource;
            this.comboBox1.DisplayMember = "DoktorID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(458, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "DoktorID";
            // 
            // doktorBindingSource
            // 
            this.doktorBindingSource.DataMember = "Doktor";
            this.doktorBindingSource.DataSource = this.hastaneDataSetBindingSource;
            // 
            // hastaneDataSetBindingSource
            // 
            this.hastaneDataSetBindingSource.DataSource = this.hastaneDataSet;
            this.hastaneDataSetBindingSource.Position = 0;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "HastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastaIDDataGridViewTextBoxColumn,
            this.hastaAdiDataGridViewTextBoxColumn,
            this.hastaSoyadiDataGridViewTextBoxColumn,
            this.doktorIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(99, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // hastaIDDataGridViewTextBoxColumn
            // 
            this.hastaIDDataGridViewTextBoxColumn.DataPropertyName = "HastaID";
            this.hastaIDDataGridViewTextBoxColumn.HeaderText = "HastaID";
            this.hastaIDDataGridViewTextBoxColumn.Name = "hastaIDDataGridViewTextBoxColumn";
            this.hastaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaAdiDataGridViewTextBoxColumn
            // 
            this.hastaAdiDataGridViewTextBoxColumn.DataPropertyName = "HastaAdi";
            this.hastaAdiDataGridViewTextBoxColumn.HeaderText = "HastaAdi";
            this.hastaAdiDataGridViewTextBoxColumn.Name = "hastaAdiDataGridViewTextBoxColumn";
            // 
            // hastaSoyadiDataGridViewTextBoxColumn
            // 
            this.hastaSoyadiDataGridViewTextBoxColumn.DataPropertyName = "HastaSoyadi";
            this.hastaSoyadiDataGridViewTextBoxColumn.HeaderText = "HastaSoyadi";
            this.hastaSoyadiDataGridViewTextBoxColumn.Name = "hastaSoyadiDataGridViewTextBoxColumn";
            // 
            // doktorIDDataGridViewTextBoxColumn
            // 
            this.doktorIDDataGridViewTextBoxColumn.DataPropertyName = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.HeaderText = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.Name = "doktorIDDataGridViewTextBoxColumn";
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "Hasta";
            this.hastaBindingSource.DataSource = this.hastaneDataSet1;
            // 
            // hastaneDataSet1
            // 
            this.hastaneDataSet1.DataSetName = "HastaneDataSet1";
            this.hastaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // doktorTableAdapter
            // 
            this.doktorTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(762, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // Hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hasta";
            this.Text = "Hasta";
            this.Load += new System.EventHandler(this.Hasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hastaneDataSetBindingSource;
        private HastaneDataSet hastaneDataSet;
        private HastaneDataSet1 hastaneDataSet1;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private HastaneDataSet1TableAdapters.HastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doktorBindingSource;
        private HastaneDataSetTableAdapters.DoktorTableAdapter doktorTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}