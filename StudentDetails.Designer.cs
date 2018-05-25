namespace StudentChallan
{
    partial class StudentDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboCaste = new System.Windows.Forms.ComboBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtYearFrom = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtAdNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.studentChallanDbDataSet1 = new StudentChallan.StudentChallanDbDataSet1();
            this.studentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter = new StudentChallan.StudentChallanDbDataSet1TableAdapters.studentDataTableAdapter();
            this.txtYearTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentChallanDbDataSet3 = new StudentChallan.StudentChallanDbDataSet3();
            this.studentDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter1 = new StudentChallan.StudentChallanDbDataSet3TableAdapters.studentDataTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtYearTo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboCaste);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.txtYearFrom);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.txtAdNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 301);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            // 
            // comboCaste
            // 
            this.comboCaste.FormattingEnabled = true;
            this.comboCaste.Items.AddRange(new object[] {
            "Open",
            "OBC",
            "SC/ST"});
            this.comboCaste.Location = new System.Drawing.Point(176, 264);
            this.comboCaste.Name = "comboCaste";
            this.comboCaste.Size = new System.Drawing.Size(288, 24);
            this.comboCaste.TabIndex = 9;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(176, 221);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(288, 22);
            this.txtMobile.TabIndex = 8;
            // 
            // txtYearFrom
            // 
            this.txtYearFrom.Location = new System.Drawing.Point(176, 140);
            this.txtYearFrom.Name = "txtYearFrom";
            this.txtYearFrom.Size = new System.Drawing.Size(288, 22);
            this.txtYearFrom.TabIndex = 7;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(176, 95);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(288, 22);
            this.txtFname.TabIndex = 6;
            // 
            // txtAdNo
            // 
            this.txtAdNo.Location = new System.Drawing.Point(176, 48);
            this.txtAdNo.Name = "txtAdNo";
            this.txtAdNo.Size = new System.Drawing.Size(288, 22);
            this.txtAdNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Caste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admission Number";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(566, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 247);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "See Detail View";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(13, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 404);
            this.panel3.TabIndex = 2;
            // 
            // studentChallanDbDataSet1
            // 
            this.studentChallanDbDataSet1.DataSetName = "StudentChallanDbDataSet1";
            this.studentChallanDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataBindingSource
            // 
            this.studentDataBindingSource.DataMember = "studentData";
            this.studentDataBindingSource.DataSource = this.studentChallanDbDataSet1;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // txtYearTo
            // 
            this.txtYearTo.Location = new System.Drawing.Point(176, 184);
            this.txtYearTo.Name = "txtYearTo";
            this.txtYearTo.Size = new System.Drawing.Size(288, 22);
            this.txtYearTo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Year To";
            // 
            // studentChallanDbDataSet3
            // 
            this.studentChallanDbDataSet3.DataSetName = "StudentChallanDbDataSet3";
            this.studentChallanDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataBindingSource1
            // 
            this.studentDataBindingSource1.DataMember = "studentData";
            this.studentDataBindingSource1.DataSource = this.studentChallanDbDataSet3;
            // 
            // studentDataTableAdapter1
            // 
            this.studentDataTableAdapter1.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.studentDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 374);
            this.dataGridView1.TabIndex = 0;
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
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 736);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDetails";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentChallanDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboCaste;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtYearFrom;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtAdNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private StudentChallanDbDataSet1 studentChallanDbDataSet1;
        private System.Windows.Forms.BindingSource studentDataBindingSource;
        private StudentChallanDbDataSet1TableAdapters.studentDataTableAdapter studentDataTableAdapter;
        private System.Windows.Forms.TextBox txtYearTo;
        private System.Windows.Forms.Label label6;
        private StudentChallanDbDataSet3 studentChallanDbDataSet3;
        private System.Windows.Forms.BindingSource studentDataBindingSource1;
        private StudentChallanDbDataSet3TableAdapters.studentDataTableAdapter studentDataTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casteDataGridViewTextBoxColumn;
    }
}