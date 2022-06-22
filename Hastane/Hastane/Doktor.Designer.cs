namespace Hastane
{
    partial class Doktor
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaneDataSet = new Hastane.HastaneDataSet();
            this.doktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doktorTableAdapter = new Hastane.HastaneDataSetTableAdapters.DoktorTableAdapter();
            this.doktorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor AD : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor SoyAD : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bölüm : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktorIDDataGridViewTextBoxColumn,
            this.doktorAdiDataGridViewTextBoxColumn,
            this.doktorSoyadiDataGridViewTextBoxColumn,
            this.doktorBolumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doktorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(159, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "HastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorBindingSource
            // 
            this.doktorBindingSource.DataMember = "Doktor";
            this.doktorBindingSource.DataSource = this.hastaneDataSet;
            // 
            // doktorTableAdapter
            // 
            this.doktorTableAdapter.ClearBeforeFill = true;
            // 
            // doktorIDDataGridViewTextBoxColumn
            // 
            this.doktorIDDataGridViewTextBoxColumn.DataPropertyName = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.HeaderText = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.Name = "doktorIDDataGridViewTextBoxColumn";
            this.doktorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorAdiDataGridViewTextBoxColumn
            // 
            this.doktorAdiDataGridViewTextBoxColumn.DataPropertyName = "DoktorAdi";
            this.doktorAdiDataGridViewTextBoxColumn.HeaderText = "DoktorAdi";
            this.doktorAdiDataGridViewTextBoxColumn.Name = "doktorAdiDataGridViewTextBoxColumn";
            // 
            // doktorSoyadiDataGridViewTextBoxColumn
            // 
            this.doktorSoyadiDataGridViewTextBoxColumn.DataPropertyName = "DoktorSoyadi";
            this.doktorSoyadiDataGridViewTextBoxColumn.HeaderText = "DoktorSoyadi";
            this.doktorSoyadiDataGridViewTextBoxColumn.Name = "doktorSoyadiDataGridViewTextBoxColumn";
            // 
            // doktorBolumDataGridViewTextBoxColumn
            // 
            this.doktorBolumDataGridViewTextBoxColumn.DataPropertyName = "DoktorBolum";
            this.doktorBolumDataGridViewTextBoxColumn.HeaderText = "DoktorBolum";
            this.doktorBolumDataGridViewTextBoxColumn.Name = "doktorBolumDataGridViewTextBoxColumn";
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Doktor";
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource doktorBindingSource;
        private HastaneDataSetTableAdapters.DoktorTableAdapter doktorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorBolumDataGridViewTextBoxColumn;
    }
}