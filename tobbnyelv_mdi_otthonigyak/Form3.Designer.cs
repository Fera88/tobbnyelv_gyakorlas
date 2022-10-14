namespace tobbnyelv_mdi_otthonigyak
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sorszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magyarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feliratElemekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new tobbnyelv_mdi_otthonigyak.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feliratElemekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "XML betöltése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Adatok mentése";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sorszamDataGridViewTextBoxColumn,
            this.magyarDataGridViewTextBoxColumn,
            this.angolDataGridViewTextBoxColumn,
            this.nemetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feliratElemekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 321);
            this.dataGridView1.TabIndex = 2;
            // 
            // sorszamDataGridViewTextBoxColumn
            // 
            this.sorszamDataGridViewTextBoxColumn.DataPropertyName = "Sorszam";
            this.sorszamDataGridViewTextBoxColumn.HeaderText = "Sorszam";
            this.sorszamDataGridViewTextBoxColumn.Name = "sorszamDataGridViewTextBoxColumn";
            // 
            // magyarDataGridViewTextBoxColumn
            // 
            this.magyarDataGridViewTextBoxColumn.DataPropertyName = "Magyar";
            this.magyarDataGridViewTextBoxColumn.HeaderText = "Magyar";
            this.magyarDataGridViewTextBoxColumn.Name = "magyarDataGridViewTextBoxColumn";
            // 
            // angolDataGridViewTextBoxColumn
            // 
            this.angolDataGridViewTextBoxColumn.DataPropertyName = "Angol";
            this.angolDataGridViewTextBoxColumn.HeaderText = "Angol";
            this.angolDataGridViewTextBoxColumn.Name = "angolDataGridViewTextBoxColumn";
            // 
            // nemetDataGridViewTextBoxColumn
            // 
            this.nemetDataGridViewTextBoxColumn.DataPropertyName = "Nemet";
            this.nemetDataGridViewTextBoxColumn.HeaderText = "Nemet";
            this.nemetDataGridViewTextBoxColumn.Name = "nemetDataGridViewTextBoxColumn";
            // 
            // feliratElemekBindingSource
            // 
            this.feliratElemekBindingSource.DataMember = "FeliratElemek";
            this.feliratElemekBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Nyelvi táblázat kezelése";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feliratElemekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magyarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource feliratElemekBindingSource;
        private DataSet1 dataSet1;
    }
}