namespace StudentChallan
{
    partial class detailView
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
            this.studentChallanDbDataSet2 = new StudentChallan.StudentChallanDbDataSet2();
            this.studentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter = new StudentChallan.StudentChallanDbDataSet2TableAdapters.studentDataTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentChallanDbDataSet4 = new StudentChallan.StudentChallanDbDataSet4();
            this.studentDataTableAdapter1 = new StudentChallan.StudentChallanDbDataSet4TableAdapters.studentDataTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.studentChallanDbDataSet5 = new StudentChallan.StudentChallanDbDataSet5();
            this.studentDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter2 = new StudentChallan.StudentChallanDbDataSet5TableAdapters.studentDataTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // studentChallanDbDataSet2
            // 
            this.studentChallanDbDataSet2.DataSetName = "StudentChallanDbDataSet2";
            this.studentChallanDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataBindingSource
            // 
            this.studentDataBindingSource.DataMember = "studentData";
            this.studentDataBindingSource.DataSource = this.studentChallanDbDataSet2;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display Year wise Admission Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.yearFromDataGridViewTextBoxColumn,
            this.yearToDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.casteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentDataBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 494);
            this.dataGridView1.TabIndex = 2;
            // 
            // studentDataBindingSource1
            // 
            this.studentDataBindingSource1.DataMember = "studentData";
            this.studentDataBindingSource1.DataSource = this.studentChallanDbDataSet4;
            // 
            // studentChallanDbDataSet4
            // 
            this.studentChallanDbDataSet4.DataSetName = "StudentChallanDbDataSet4";
            this.studentChallanDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataTableAdapter1
            // 
            this.studentDataTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Display the Caste wise Admission Number";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentChallanDbDataSet5
            // 
            this.studentChallanDbDataSet5.DataSetName = "StudentChallanDbDataSet5";
            this.studentChallanDbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataBindingSource2
            // 
            this.studentDataBindingSource2.DataMember = "studentData";
            this.studentDataBindingSource2.DataSource = this.studentChallanDbDataSet5;
            // 
            // studentDataTableAdapter2
            // 
            this.studentDataTableAdapter2.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adNoDataGridViewTextBoxColumn
            // 
            this.adNoDataGridViewTextBoxColumn.DataPropertyName = "adNo";
            this.adNoDataGridViewTextBoxColumn.HeaderText = "adNo";
            this.adNoDataGridViewTextBoxColumn.Name = "adNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // yearFromDataGridViewTextBoxColumn
            // 
            this.yearFromDataGridViewTextBoxColumn.DataPropertyName = "yearFrom";
            this.yearFromDataGridViewTextBoxColumn.HeaderText = "yearFrom";
            this.yearFromDataGridViewTextBoxColumn.Name = "yearFromDataGridViewTextBoxColumn";
            // 
            // yearToDataGridViewTextBoxColumn
            // 
            this.yearToDataGridViewTextBoxColumn.DataPropertyName = "yearTo";
            this.yearToDataGridViewTextBoxColumn.HeaderText = "yearTo";
            this.yearToDataGridViewTextBoxColumn.Name = "yearToDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // casteDataGridViewTextBoxColumn
            // 
            this.casteDataGridViewTextBoxColumn.DataPropertyName = "caste";
            this.casteDataGridViewTextBoxColumn.HeaderText = "caste";
            this.casteDataGridViewTextBoxColumn.Name = "casteDataGridViewTextBoxColumn";
            // 
            // detailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 726);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "detailView";
            this.Text = "detailView";
            this.Load += new System.EventHandler(this.detailView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StudentChallanDbDataSet2 studentChallanDbDataSet2;
        private System.Windows.Forms.BindingSource studentDataBindingSource;
        private StudentChallanDbDataSet2TableAdapters.studentDataTableAdapter studentDataTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentChallanDbDataSet4 studentChallanDbDataSet4;
        private System.Windows.Forms.BindingSource studentDataBindingSource1;
        private StudentChallanDbDataSet4TableAdapters.studentDataTableAdapter studentDataTableAdapter1;
        private System.Windows.Forms.Button button2;
        private StudentChallanDbDataSet5 studentChallanDbDataSet5;
        private System.Windows.Forms.BindingSource studentDataBindingSource2;
        private StudentChallanDbDataSet5TableAdapters.studentDataTableAdapter studentDataTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casteDataGridViewTextBoxColumn;
    }
}