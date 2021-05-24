
namespace Crud_operation
{
    partial class Form5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessiontableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itpmCRUDDataSet = new Crud_operation.itpmCRUDDataSet();
            this.dataGridViewConsecutive = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewparallel = new System.Windows.Forms.DataGridView();
            this.dataGridView_sespar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.sessiontableTableAdapter = new Crud_operation.itpmCRUDDataSetTableAdapters.sessiontableTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureOneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureTwoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfStudentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessiontableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpmCRUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsecutive)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewparallel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sespar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(30, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1135, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.dataGridViewConsecutive);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1127, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "consecutive";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lectureOneDataGridViewTextBoxColumn,
            this.lectureTwoDataGridViewTextBoxColumn,
            this.subjectCodeDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.noOfStudentDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sessiontableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 195);
            this.dataGridView1.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lectureOneDataGridViewTextBoxColumn
            // 
            this.lectureOneDataGridViewTextBoxColumn.DataPropertyName = "lecture one";
            this.lectureOneDataGridViewTextBoxColumn.HeaderText = "lecture one";
            this.lectureOneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lectureOneDataGridViewTextBoxColumn.Name = "lectureOneDataGridViewTextBoxColumn";
            this.lectureOneDataGridViewTextBoxColumn.Width = 125;
            // 
            // lectureTwoDataGridViewTextBoxColumn
            // 
            this.lectureTwoDataGridViewTextBoxColumn.DataPropertyName = "lecture two";
            this.lectureTwoDataGridViewTextBoxColumn.HeaderText = "lecture two";
            this.lectureTwoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lectureTwoDataGridViewTextBoxColumn.Name = "lectureTwoDataGridViewTextBoxColumn";
            this.lectureTwoDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectCodeDataGridViewTextBoxColumn
            // 
            this.subjectCodeDataGridViewTextBoxColumn.DataPropertyName = "subject code";
            this.subjectCodeDataGridViewTextBoxColumn.HeaderText = "subject code";
            this.subjectCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectCodeDataGridViewTextBoxColumn.Name = "subjectCodeDataGridViewTextBoxColumn";
            this.subjectCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "subject name";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "subject name";
            this.subjectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "group id";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "group id";
            this.groupIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            this.groupIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "tag";
            this.tagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.Width = 125;
            // 
            // noOfStudentDataGridViewTextBoxColumn
            // 
            this.noOfStudentDataGridViewTextBoxColumn.DataPropertyName = "no of student";
            this.noOfStudentDataGridViewTextBoxColumn.HeaderText = "no of student";
            this.noOfStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfStudentDataGridViewTextBoxColumn.Name = "noOfStudentDataGridViewTextBoxColumn";
            this.noOfStudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // sessiontableBindingSource
            // 
            this.sessiontableBindingSource.DataMember = "sessiontable";
            this.sessiontableBindingSource.DataSource = this.itpmCRUDDataSet;
            // 
            // itpmCRUDDataSet
            // 
            this.itpmCRUDDataSet.DataSetName = "itpmCRUDDataSet";
            this.itpmCRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewConsecutive
            // 
            this.dataGridViewConsecutive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConsecutive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsecutive.Location = new System.Drawing.Point(31, 325);
            this.dataGridViewConsecutive.Name = "dataGridViewConsecutive";
            this.dataGridViewConsecutive.RowHeadersWidth = 51;
            this.dataGridViewConsecutive.RowTemplate.Height = 24;
            this.dataGridViewConsecutive.Size = new System.Drawing.Size(1032, 200);
            this.dataGridViewConsecutive.TabIndex = 3;
            this.dataGridViewConsecutive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(448, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridViewparallel);
            this.tabPage2.Controls.Add(this.dataGridView_sespar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1127, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "parallel";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(488, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "parallel save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewparallel
            // 
            this.dataGridViewparallel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewparallel.Location = new System.Drawing.Point(50, 306);
            this.dataGridViewparallel.Name = "dataGridViewparallel";
            this.dataGridViewparallel.RowHeadersWidth = 51;
            this.dataGridViewparallel.RowTemplate.Height = 24;
            this.dataGridViewparallel.Size = new System.Drawing.Size(1041, 150);
            this.dataGridViewparallel.TabIndex = 1;
            // 
            // dataGridView_sespar
            // 
            this.dataGridView_sespar.AllowUserToAddRows = false;
            this.dataGridView_sespar.AutoGenerateColumns = false;
            this.dataGridView_sespar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sespar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.lectureOneDataGridViewTextBoxColumn1,
            this.lectureTwoDataGridViewTextBoxColumn1,
            this.subjectCodeDataGridViewTextBoxColumn1,
            this.subjectNameDataGridViewTextBoxColumn1,
            this.groupIdDataGridViewTextBoxColumn1,
            this.tagDataGridViewTextBoxColumn1,
            this.noOfStudentDataGridViewTextBoxColumn1,
            this.durationDataGridViewTextBoxColumn1});
            this.dataGridView_sespar.DataSource = this.sessiontableBindingSource;
            this.dataGridView_sespar.Location = new System.Drawing.Point(50, 32);
            this.dataGridView_sespar.Name = "dataGridView_sespar";
            this.dataGridView_sespar.RowHeadersWidth = 51;
            this.dataGridView_sespar.RowTemplate.Height = 24;
            this.dataGridView_sespar.Size = new System.Drawing.Size(1041, 150);
            this.dataGridView_sespar.TabIndex = 0;
            this.dataGridView_sespar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.dataGridView6);
            this.tabPage3.Controls.Add(this.dataGridView5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1127, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "non overlapping";
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(71, 329);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(1015, 150);
            this.dataGridView6.TabIndex = 2;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(62, 53);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(1024, 150);
            this.dataGridView5.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(457, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1127, 547);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "non available times";
            // 
            // sessiontableTableAdapter
            // 
            this.sessiontableTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lectureOneDataGridViewTextBoxColumn1
            // 
            this.lectureOneDataGridViewTextBoxColumn1.DataPropertyName = "lecture one";
            this.lectureOneDataGridViewTextBoxColumn1.HeaderText = "lecture one";
            this.lectureOneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lectureOneDataGridViewTextBoxColumn1.Name = "lectureOneDataGridViewTextBoxColumn1";
            this.lectureOneDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lectureTwoDataGridViewTextBoxColumn1
            // 
            this.lectureTwoDataGridViewTextBoxColumn1.DataPropertyName = "lecture two";
            this.lectureTwoDataGridViewTextBoxColumn1.HeaderText = "lecture two";
            this.lectureTwoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lectureTwoDataGridViewTextBoxColumn1.Name = "lectureTwoDataGridViewTextBoxColumn1";
            this.lectureTwoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // subjectCodeDataGridViewTextBoxColumn1
            // 
            this.subjectCodeDataGridViewTextBoxColumn1.DataPropertyName = "subject code";
            this.subjectCodeDataGridViewTextBoxColumn1.HeaderText = "subject code";
            this.subjectCodeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.subjectCodeDataGridViewTextBoxColumn1.Name = "subjectCodeDataGridViewTextBoxColumn1";
            this.subjectCodeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // subjectNameDataGridViewTextBoxColumn1
            // 
            this.subjectNameDataGridViewTextBoxColumn1.DataPropertyName = "subject name";
            this.subjectNameDataGridViewTextBoxColumn1.HeaderText = "subject name";
            this.subjectNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.subjectNameDataGridViewTextBoxColumn1.Name = "subjectNameDataGridViewTextBoxColumn1";
            this.subjectNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // groupIdDataGridViewTextBoxColumn1
            // 
            this.groupIdDataGridViewTextBoxColumn1.DataPropertyName = "group id";
            this.groupIdDataGridViewTextBoxColumn1.HeaderText = "group id";
            this.groupIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.groupIdDataGridViewTextBoxColumn1.Name = "groupIdDataGridViewTextBoxColumn1";
            this.groupIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tagDataGridViewTextBoxColumn1
            // 
            this.tagDataGridViewTextBoxColumn1.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn1.HeaderText = "tag";
            this.tagDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tagDataGridViewTextBoxColumn1.Name = "tagDataGridViewTextBoxColumn1";
            this.tagDataGridViewTextBoxColumn1.Width = 125;
            // 
            // noOfStudentDataGridViewTextBoxColumn1
            // 
            this.noOfStudentDataGridViewTextBoxColumn1.DataPropertyName = "no of student";
            this.noOfStudentDataGridViewTextBoxColumn1.HeaderText = "no of student";
            this.noOfStudentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.noOfStudentDataGridViewTextBoxColumn1.Name = "noOfStudentDataGridViewTextBoxColumn1";
            this.noOfStudentDataGridViewTextBoxColumn1.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn1
            // 
            this.durationDataGridViewTextBoxColumn1.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn1.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn1.Name = "durationDataGridViewTextBoxColumn1";
            this.durationDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1190, 645);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessiontableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpmCRUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsecutive)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewparallel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sespar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewConsecutive;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewparallel;
        private System.Windows.Forms.DataGridView dataGridView_sespar;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private itpmCRUDDataSet itpmCRUDDataSet;
        private System.Windows.Forms.BindingSource sessiontableBindingSource;
        private itpmCRUDDataSetTableAdapters.sessiontableTableAdapter sessiontableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureOneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureTwoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfStudentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn1;
    }
}