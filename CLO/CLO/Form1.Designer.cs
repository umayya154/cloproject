using System;
using System.Windows.Forms;

namespace CLO
{
    partial class fmCLO
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
            this.tabCTRLCLO = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnstudentEdit = new System.Windows.Forms.Button();
            this.lbstdstatus = new System.Windows.Forms.Label();
            this.cmbstdstatus = new System.Windows.Forms.ComboBox();
            this.btnStudentadd = new System.Windows.Forms.Button();
            this.txtstdregistrationNo = new System.Windows.Forms.TextBox();
            this.txtstdemail = new System.Windows.Forms.TextBox();
            this.txtstdcontact = new System.Windows.Forms.TextBox();
            this.txtstdlastname = new System.Windows.Forms.TextBox();
            this.txtstdfirstname = new System.Windows.Forms.TextBox();
            this.lbstdregistrationNo = new System.Windows.Forms.Label();
            this.lbstdemail = new System.Windows.Forms.Label();
            this.lbstdcontact = new System.Windows.Forms.Label();
            this.lblastname = new System.Windows.Forms.Label();
            this.lbStdfirstname = new System.Windows.Forms.Label();
            this.tabclo = new System.Windows.Forms.TabPage();
            this.btnCLODelete = new System.Windows.Forms.Button();
            this.btnCLOEdit = new System.Windows.Forms.Button();
            this.btnCLOcadd = new System.Windows.Forms.Button();
            this.txtcloname = new System.Windows.Forms.TextBox();
            this.lblcloname = new System.Windows.Forms.Label();
            this.tabRubric = new System.Windows.Forms.TabPage();
            this.cmbselectClo = new System.Windows.Forms.ComboBox();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new CLO.ProjectBDataSet1();
            this.btnRubricDelete = new System.Windows.Forms.Button();
            this.btnRubricEdit = new System.Windows.Forms.Button();
            this.btnRubricadd = new System.Windows.Forms.Button();
            this.txtrubricDetails = new System.Windows.Forms.TextBox();
            this.lblRubric = new System.Windows.Forms.Label();
            this.lblselectclo = new System.Windows.Forms.Label();
            this.tabRubriclevel = new System.Windows.Forms.TabPage();
            this.btnRubricLeveldelete = new System.Windows.Forms.Button();
            this.btnRubricLeveledit = new System.Windows.Forms.Button();
            this.btnrubriclevelAdd = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblMeasurementLevel = new System.Windows.Forms.Label();
            this.txtRubriclvl_detail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMeasurementLevel = new System.Windows.Forms.ComboBox();
            this.cmbRubricId = new System.Windows.Forms.ComboBox();
            this.tabAssessmentComponent = new System.Windows.Forms.TabPage();
            this.btnAssessmentComponentDelete = new System.Windows.Forms.Button();
            this.btnassessmentComponentedit = new System.Windows.Forms.Button();
            this.btnAssessmentcomponentadd = new System.Windows.Forms.Button();
            this.cmbTotalmarks = new System.Windows.Forms.ComboBox();
            this.combrubricID2 = new System.Windows.Forms.ComboBox();
            this.lblassessmentID2 = new System.Windows.Forms.Label();
            this.lblTotalmark = new System.Windows.Forms.Label();
            this.lblrubricID2 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtComponentName = new System.Windows.Forms.TextBox();
            this.lblcomponentName = new System.Windows.Forms.Label();
            this.tabassessment = new System.Windows.Forms.TabPage();
            this.btnassessemntDelete = new System.Windows.Forms.Button();
            this.btnassessementedit = new System.Windows.Forms.Button();
            this.btnassessmentAdd = new System.Windows.Forms.Button();
            this.txtTotalweightage = new System.Windows.Forms.TextBox();
            this.txtTotalMarks2 = new System.Windows.Forms.TextBox();
            this.lbltotalweightage = new System.Windows.Forms.Label();
            this.lbltotalMarks2 = new System.Windows.Forms.Label();
            this.lblAssessmenttitle = new System.Windows.Forms.Label();
            this.txtAssenssmentTitle = new System.Windows.Forms.TextBox();
            this.tabStudentAttendance = new System.Windows.Forms.TabPage();
            this.btnAttendanceMark = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblattendanceStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentAttendence = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GVStudent = new System.Windows.Forms.DataGridView();
            this.projectBDataSet = new CLO.ProjectBDataSet();
            this.lookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookupTableAdapter = new CLO.ProjectBDataSetTableAdapters.LookupTableAdapter();
            this.lblRecord = new System.Windows.Forms.Label();
            this.cloTableAdapter = new CLO.ProjectBDataSet1TableAdapters.CloTableAdapter();
            this.tabCTRLCLO.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.tabclo.SuspendLayout();
            this.tabRubric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            this.tabRubriclevel.SuspendLayout();
            this.tabAssessmentComponent.SuspendLayout();
            this.tabassessment.SuspendLayout();
            this.tabStudentAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCTRLCLO
            // 
            this.tabCTRLCLO.Controls.Add(this.tabStudent);
            this.tabCTRLCLO.Controls.Add(this.tabclo);
            this.tabCTRLCLO.Controls.Add(this.tabRubric);
            this.tabCTRLCLO.Controls.Add(this.tabRubriclevel);
            this.tabCTRLCLO.Controls.Add(this.tabAssessmentComponent);
            this.tabCTRLCLO.Controls.Add(this.tabassessment);
            this.tabCTRLCLO.Controls.Add(this.tabStudentAttendance);
            this.tabCTRLCLO.Controls.Add(this.tabPage1);
            this.tabCTRLCLO.Location = new System.Drawing.Point(12, 12);
            this.tabCTRLCLO.Name = "tabCTRLCLO";
            this.tabCTRLCLO.SelectedIndex = 0;
            this.tabCTRLCLO.Size = new System.Drawing.Size(464, 319);
            this.tabCTRLCLO.TabIndex = 0;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.btnStudentDelete);
            this.tabStudent.Controls.Add(this.btnstudentEdit);
            this.tabStudent.Controls.Add(this.lbstdstatus);
            this.tabStudent.Controls.Add(this.cmbstdstatus);
            this.tabStudent.Controls.Add(this.btnStudentadd);
            this.tabStudent.Controls.Add(this.txtstdregistrationNo);
            this.tabStudent.Controls.Add(this.txtstdemail);
            this.tabStudent.Controls.Add(this.txtstdcontact);
            this.tabStudent.Controls.Add(this.txtstdlastname);
            this.tabStudent.Controls.Add(this.txtstdfirstname);
            this.tabStudent.Controls.Add(this.lbstdregistrationNo);
            this.tabStudent.Controls.Add(this.lbstdemail);
            this.tabStudent.Controls.Add(this.lbstdcontact);
            this.tabStudent.Controls.Add(this.lblastname);
            this.tabStudent.Controls.Add(this.lbStdfirstname);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(456, 293);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "Student";
            this.tabStudent.UseVisualStyleBackColor = true;
            this.tabStudent.Click += new System.EventHandler(this.tabStudent_Click);
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(256, 238);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStudentDelete.TabIndex = 31;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnstudentEdit
            // 
            this.btnstudentEdit.Location = new System.Drawing.Point(146, 238);
            this.btnstudentEdit.Name = "btnstudentEdit";
            this.btnstudentEdit.Size = new System.Drawing.Size(75, 23);
            this.btnstudentEdit.TabIndex = 30;
            this.btnstudentEdit.Text = "Edit";
            this.btnstudentEdit.UseVisualStyleBackColor = true;
            this.btnstudentEdit.Click += new System.EventHandler(this.btnstudentEdit_Click);
            // 
            // lbstdstatus
            // 
            this.lbstdstatus.AutoSize = true;
            this.lbstdstatus.Location = new System.Drawing.Point(33, 198);
            this.lbstdstatus.Name = "lbstdstatus";
            this.lbstdstatus.Size = new System.Drawing.Size(37, 13);
            this.lbstdstatus.TabIndex = 14;
            this.lbstdstatus.Text = "Status";
            // 
            // cmbstdstatus
            // 
            this.cmbstdstatus.FormattingEnabled = true;
            this.cmbstdstatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbstdstatus.Location = new System.Drawing.Point(194, 195);
            this.cmbstdstatus.Name = "cmbstdstatus";
            this.cmbstdstatus.Size = new System.Drawing.Size(100, 21);
            this.cmbstdstatus.TabIndex = 13;
            // 
            // btnStudentadd
            // 
            this.btnStudentadd.Location = new System.Drawing.Point(36, 238);
            this.btnStudentadd.Name = "btnStudentadd";
            this.btnStudentadd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentadd.TabIndex = 12;
            this.btnStudentadd.Text = "Add";
            this.btnStudentadd.UseVisualStyleBackColor = true;
            this.btnStudentadd.Click += new System.EventHandler(this.btnstdadd_Click);
            // 
            // txtstdregistrationNo
            // 
            this.txtstdregistrationNo.Location = new System.Drawing.Point(194, 168);
            this.txtstdregistrationNo.Name = "txtstdregistrationNo";
            this.txtstdregistrationNo.Size = new System.Drawing.Size(100, 20);
            this.txtstdregistrationNo.TabIndex = 11;
            // 
            // txtstdemail
            // 
            this.txtstdemail.Location = new System.Drawing.Point(194, 140);
            this.txtstdemail.Name = "txtstdemail";
            this.txtstdemail.Size = new System.Drawing.Size(100, 20);
            this.txtstdemail.TabIndex = 10;
            // 
            // txtstdcontact
            // 
            this.txtstdcontact.Location = new System.Drawing.Point(194, 110);
            this.txtstdcontact.Name = "txtstdcontact";
            this.txtstdcontact.Size = new System.Drawing.Size(100, 20);
            this.txtstdcontact.TabIndex = 9;
            // 
            // txtstdlastname
            // 
            this.txtstdlastname.Location = new System.Drawing.Point(194, 78);
            this.txtstdlastname.Name = "txtstdlastname";
            this.txtstdlastname.Size = new System.Drawing.Size(100, 20);
            this.txtstdlastname.TabIndex = 8;
            // 
            // txtstdfirstname
            // 
            this.txtstdfirstname.Location = new System.Drawing.Point(194, 49);
            this.txtstdfirstname.Name = "txtstdfirstname";
            this.txtstdfirstname.Size = new System.Drawing.Size(100, 20);
            this.txtstdfirstname.TabIndex = 7;
            // 
            // lbstdregistrationNo
            // 
            this.lbstdregistrationNo.AutoSize = true;
            this.lbstdregistrationNo.Location = new System.Drawing.Point(33, 171);
            this.lbstdregistrationNo.Name = "lbstdregistrationNo";
            this.lbstdregistrationNo.Size = new System.Drawing.Size(103, 13);
            this.lbstdregistrationNo.TabIndex = 4;
            this.lbstdregistrationNo.Text = "Registration Number";
            // 
            // lbstdemail
            // 
            this.lbstdemail.AutoSize = true;
            this.lbstdemail.Location = new System.Drawing.Point(33, 143);
            this.lbstdemail.Name = "lbstdemail";
            this.lbstdemail.Size = new System.Drawing.Size(32, 13);
            this.lbstdemail.TabIndex = 3;
            this.lbstdemail.Text = "Email";
            // 
            // lbstdcontact
            // 
            this.lbstdcontact.AutoSize = true;
            this.lbstdcontact.Location = new System.Drawing.Point(33, 113);
            this.lbstdcontact.Name = "lbstdcontact";
            this.lbstdcontact.Size = new System.Drawing.Size(44, 13);
            this.lbstdcontact.TabIndex = 2;
            this.lbstdcontact.Text = "Contact";
            // 
            // lblastname
            // 
            this.lblastname.AutoSize = true;
            this.lblastname.Location = new System.Drawing.Point(33, 81);
            this.lblastname.Name = "lblastname";
            this.lblastname.Size = new System.Drawing.Size(58, 13);
            this.lblastname.TabIndex = 1;
            this.lblastname.Text = "Last Name";
            // 
            // lbStdfirstname
            // 
            this.lbStdfirstname.AutoSize = true;
            this.lbStdfirstname.Location = new System.Drawing.Point(33, 49);
            this.lbStdfirstname.Name = "lbStdfirstname";
            this.lbStdfirstname.Size = new System.Drawing.Size(57, 13);
            this.lbStdfirstname.TabIndex = 0;
            this.lbStdfirstname.Text = "First Name";
            // 
            // tabclo
            // 
            this.tabclo.Controls.Add(this.btnCLODelete);
            this.tabclo.Controls.Add(this.btnCLOEdit);
            this.tabclo.Controls.Add(this.btnCLOcadd);
            this.tabclo.Controls.Add(this.txtcloname);
            this.tabclo.Controls.Add(this.lblcloname);
            this.tabclo.Location = new System.Drawing.Point(4, 22);
            this.tabclo.Name = "tabclo";
            this.tabclo.Padding = new System.Windows.Forms.Padding(3);
            this.tabclo.Size = new System.Drawing.Size(456, 293);
            this.tabclo.TabIndex = 1;
            this.tabclo.Text = "CLO";
            this.tabclo.UseVisualStyleBackColor = true;
            this.tabclo.Click += new System.EventHandler(this.tabclo_Click);
            // 
            // btnCLODelete
            // 
            this.btnCLODelete.Location = new System.Drawing.Point(236, 132);
            this.btnCLODelete.Name = "btnCLODelete";
            this.btnCLODelete.Size = new System.Drawing.Size(75, 23);
            this.btnCLODelete.TabIndex = 29;
            this.btnCLODelete.Text = "Delete";
            this.btnCLODelete.UseVisualStyleBackColor = true;
            // 
            // btnCLOEdit
            // 
            this.btnCLOEdit.Location = new System.Drawing.Point(126, 132);
            this.btnCLOEdit.Name = "btnCLOEdit";
            this.btnCLOEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCLOEdit.TabIndex = 28;
            this.btnCLOEdit.Text = "Edit";
            this.btnCLOEdit.UseVisualStyleBackColor = true;
            // 
            // btnCLOcadd
            // 
            this.btnCLOcadd.Location = new System.Drawing.Point(25, 132);
            this.btnCLOcadd.Name = "btnCLOcadd";
            this.btnCLOcadd.Size = new System.Drawing.Size(75, 23);
            this.btnCLOcadd.TabIndex = 27;
            this.btnCLOcadd.Text = "Add";
            this.btnCLOcadd.UseVisualStyleBackColor = true;
            this.btnCLOcadd.Click += new System.EventHandler(this.btnCLOcadd_Click);
            // 
            // txtcloname
            // 
            this.txtcloname.Location = new System.Drawing.Point(202, 49);
            this.txtcloname.Name = "txtcloname";
            this.txtcloname.Size = new System.Drawing.Size(128, 20);
            this.txtcloname.TabIndex = 26;
            // 
            // lblcloname
            // 
            this.lblcloname.AutoSize = true;
            this.lblcloname.Location = new System.Drawing.Point(41, 49);
            this.lblcloname.Name = "lblcloname";
            this.lblcloname.Size = new System.Drawing.Size(59, 13);
            this.lblcloname.TabIndex = 25;
            this.lblcloname.Text = "CLO Name";
            // 
            // tabRubric
            // 
            this.tabRubric.Controls.Add(this.cmbselectClo);
            this.tabRubric.Controls.Add(this.btnRubricDelete);
            this.tabRubric.Controls.Add(this.btnRubricEdit);
            this.tabRubric.Controls.Add(this.btnRubricadd);
            this.tabRubric.Controls.Add(this.txtrubricDetails);
            this.tabRubric.Controls.Add(this.lblRubric);
            this.tabRubric.Controls.Add(this.lblselectclo);
            this.tabRubric.Location = new System.Drawing.Point(4, 22);
            this.tabRubric.Name = "tabRubric";
            this.tabRubric.Padding = new System.Windows.Forms.Padding(3);
            this.tabRubric.Size = new System.Drawing.Size(456, 293);
            this.tabRubric.TabIndex = 2;
            this.tabRubric.Text = "Rubric";
            this.tabRubric.UseVisualStyleBackColor = true;
            this.tabRubric.Click += new System.EventHandler(this.tabRubric_Click);
            // 
            // cmbselectClo
            // 
            this.cmbselectClo.DataSource = this.cloBindingSource;
            this.cmbselectClo.FormattingEnabled = true;
            this.cmbselectClo.Location = new System.Drawing.Point(195, 56);
            this.cmbselectClo.Name = "cmbselectClo";
            this.cmbselectClo.Size = new System.Drawing.Size(121, 21);
            this.cmbselectClo.TabIndex = 33;
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRubricDelete
            // 
            this.btnRubricDelete.Location = new System.Drawing.Point(222, 206);
            this.btnRubricDelete.Name = "btnRubricDelete";
            this.btnRubricDelete.Size = new System.Drawing.Size(75, 23);
            this.btnRubricDelete.TabIndex = 32;
            this.btnRubricDelete.Text = "Delete";
            this.btnRubricDelete.UseVisualStyleBackColor = true;
            // 
            // btnRubricEdit
            // 
            this.btnRubricEdit.Location = new System.Drawing.Point(117, 206);
            this.btnRubricEdit.Name = "btnRubricEdit";
            this.btnRubricEdit.Size = new System.Drawing.Size(75, 23);
            this.btnRubricEdit.TabIndex = 31;
            this.btnRubricEdit.Text = "Edit";
            this.btnRubricEdit.UseVisualStyleBackColor = true;
            this.btnRubricEdit.Click += new System.EventHandler(this.btnRubricEdit_Click);
            // 
            // btnRubricadd
            // 
            this.btnRubricadd.Location = new System.Drawing.Point(20, 206);
            this.btnRubricadd.Name = "btnRubricadd";
            this.btnRubricadd.Size = new System.Drawing.Size(75, 23);
            this.btnRubricadd.TabIndex = 30;
            this.btnRubricadd.Text = "Add";
            this.btnRubricadd.UseVisualStyleBackColor = true;
            this.btnRubricadd.Click += new System.EventHandler(this.btnRubricadd_Click);
            // 
            // txtrubricDetails
            // 
            this.txtrubricDetails.Location = new System.Drawing.Point(195, 90);
            this.txtrubricDetails.Multiline = true;
            this.txtrubricDetails.Name = "txtrubricDetails";
            this.txtrubricDetails.Size = new System.Drawing.Size(100, 64);
            this.txtrubricDetails.TabIndex = 28;
            // 
            // lblRubric
            // 
            this.lblRubric.AutoSize = true;
            this.lblRubric.Location = new System.Drawing.Point(34, 90);
            this.lblRubric.Name = "lblRubric";
            this.lblRubric.Size = new System.Drawing.Size(68, 13);
            this.lblRubric.TabIndex = 26;
            this.lblRubric.Text = "Rubric Detail";
            // 
            // lblselectclo
            // 
            this.lblselectclo.AutoSize = true;
            this.lblselectclo.Location = new System.Drawing.Point(34, 64);
            this.lblselectclo.Name = "lblselectclo";
            this.lblselectclo.Size = new System.Drawing.Size(61, 13);
            this.lblselectclo.TabIndex = 25;
            this.lblselectclo.Text = "Select CLO";
            // 
            // tabRubriclevel
            // 
            this.tabRubriclevel.Controls.Add(this.btnRubricLeveldelete);
            this.tabRubriclevel.Controls.Add(this.btnRubricLeveledit);
            this.tabRubriclevel.Controls.Add(this.btnrubriclevelAdd);
            this.tabRubriclevel.Controls.Add(this.lblDetails);
            this.tabRubriclevel.Controls.Add(this.lblMeasurementLevel);
            this.tabRubriclevel.Controls.Add(this.txtRubriclvl_detail);
            this.tabRubriclevel.Controls.Add(this.label9);
            this.tabRubriclevel.Controls.Add(this.cmbMeasurementLevel);
            this.tabRubriclevel.Controls.Add(this.cmbRubricId);
            this.tabRubriclevel.Location = new System.Drawing.Point(4, 22);
            this.tabRubriclevel.Name = "tabRubriclevel";
            this.tabRubriclevel.Padding = new System.Windows.Forms.Padding(3);
            this.tabRubriclevel.Size = new System.Drawing.Size(456, 293);
            this.tabRubriclevel.TabIndex = 3;
            this.tabRubriclevel.Text = "Rubric Level";
            this.tabRubriclevel.UseVisualStyleBackColor = true;
            this.tabRubriclevel.Click += new System.EventHandler(this.tabRubriclevel_Click);
            // 
            // btnRubricLeveldelete
            // 
            this.btnRubricLeveldelete.Location = new System.Drawing.Point(233, 227);
            this.btnRubricLeveldelete.Name = "btnRubricLeveldelete";
            this.btnRubricLeveldelete.Size = new System.Drawing.Size(75, 23);
            this.btnRubricLeveldelete.TabIndex = 35;
            this.btnRubricLeveldelete.Text = "Delete";
            this.btnRubricLeveldelete.UseVisualStyleBackColor = true;
            // 
            // btnRubricLeveledit
            // 
            this.btnRubricLeveledit.Location = new System.Drawing.Point(128, 227);
            this.btnRubricLeveledit.Name = "btnRubricLeveledit";
            this.btnRubricLeveledit.Size = new System.Drawing.Size(75, 23);
            this.btnRubricLeveledit.TabIndex = 34;
            this.btnRubricLeveledit.Text = "Edit";
            this.btnRubricLeveledit.UseVisualStyleBackColor = true;
            // 
            // btnrubriclevelAdd
            // 
            this.btnrubriclevelAdd.Location = new System.Drawing.Point(31, 227);
            this.btnrubriclevelAdd.Name = "btnrubriclevelAdd";
            this.btnrubriclevelAdd.Size = new System.Drawing.Size(75, 23);
            this.btnrubriclevelAdd.TabIndex = 33;
            this.btnrubriclevelAdd.Text = "Add";
            this.btnrubriclevelAdd.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(38, 136);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 26;
            this.lblDetails.Text = "Details";
            // 
            // lblMeasurementLevel
            // 
            this.lblMeasurementLevel.AutoSize = true;
            this.lblMeasurementLevel.Location = new System.Drawing.Point(38, 96);
            this.lblMeasurementLevel.Name = "lblMeasurementLevel";
            this.lblMeasurementLevel.Size = new System.Drawing.Size(100, 13);
            this.lblMeasurementLevel.TabIndex = 25;
            this.lblMeasurementLevel.Text = "Measurement Level";
            // 
            // txtRubriclvl_detail
            // 
            this.txtRubriclvl_detail.Location = new System.Drawing.Point(168, 136);
            this.txtRubriclvl_detail.Multiline = true;
            this.txtRubriclvl_detail.Name = "txtRubriclvl_detail";
            this.txtRubriclvl_detail.Size = new System.Drawing.Size(125, 65);
            this.txtRubriclvl_detail.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Rubric ID";
            // 
            // cmbMeasurementLevel
            // 
            this.cmbMeasurementLevel.FormattingEnabled = true;
            this.cmbMeasurementLevel.Location = new System.Drawing.Point(168, 96);
            this.cmbMeasurementLevel.Name = "cmbMeasurementLevel";
            this.cmbMeasurementLevel.Size = new System.Drawing.Size(121, 21);
            this.cmbMeasurementLevel.TabIndex = 1;
            // 
            // cmbRubricId
            // 
            this.cmbRubricId.FormattingEnabled = true;
            this.cmbRubricId.Location = new System.Drawing.Point(168, 56);
            this.cmbRubricId.Name = "cmbRubricId";
            this.cmbRubricId.Size = new System.Drawing.Size(121, 21);
            this.cmbRubricId.TabIndex = 0;
            // 
            // tabAssessmentComponent
            // 
            this.tabAssessmentComponent.Controls.Add(this.btnAssessmentComponentDelete);
            this.tabAssessmentComponent.Controls.Add(this.btnassessmentComponentedit);
            this.tabAssessmentComponent.Controls.Add(this.btnAssessmentcomponentadd);
            this.tabAssessmentComponent.Controls.Add(this.cmbTotalmarks);
            this.tabAssessmentComponent.Controls.Add(this.combrubricID2);
            this.tabAssessmentComponent.Controls.Add(this.lblassessmentID2);
            this.tabAssessmentComponent.Controls.Add(this.lblTotalmark);
            this.tabAssessmentComponent.Controls.Add(this.lblrubricID2);
            this.tabAssessmentComponent.Controls.Add(this.textBox10);
            this.tabAssessmentComponent.Controls.Add(this.txtComponentName);
            this.tabAssessmentComponent.Controls.Add(this.lblcomponentName);
            this.tabAssessmentComponent.Location = new System.Drawing.Point(4, 22);
            this.tabAssessmentComponent.Name = "tabAssessmentComponent";
            this.tabAssessmentComponent.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssessmentComponent.Size = new System.Drawing.Size(456, 293);
            this.tabAssessmentComponent.TabIndex = 4;
            this.tabAssessmentComponent.Text = "Assesssment Component";
            this.tabAssessmentComponent.UseVisualStyleBackColor = true;
            this.tabAssessmentComponent.Click += new System.EventHandler(this.tabAssessmentComponent_Click);
            // 
            // btnAssessmentComponentDelete
            // 
            this.btnAssessmentComponentDelete.Location = new System.Drawing.Point(240, 232);
            this.btnAssessmentComponentDelete.Name = "btnAssessmentComponentDelete";
            this.btnAssessmentComponentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAssessmentComponentDelete.TabIndex = 35;
            this.btnAssessmentComponentDelete.Text = "Delete";
            this.btnAssessmentComponentDelete.UseVisualStyleBackColor = true;
            // 
            // btnassessmentComponentedit
            // 
            this.btnassessmentComponentedit.Location = new System.Drawing.Point(135, 232);
            this.btnassessmentComponentedit.Name = "btnassessmentComponentedit";
            this.btnassessmentComponentedit.Size = new System.Drawing.Size(75, 23);
            this.btnassessmentComponentedit.TabIndex = 34;
            this.btnassessmentComponentedit.Text = "Edit";
            this.btnassessmentComponentedit.UseVisualStyleBackColor = true;
            // 
            // btnAssessmentcomponentadd
            // 
            this.btnAssessmentcomponentadd.Location = new System.Drawing.Point(38, 232);
            this.btnAssessmentcomponentadd.Name = "btnAssessmentcomponentadd";
            this.btnAssessmentcomponentadd.Size = new System.Drawing.Size(75, 23);
            this.btnAssessmentcomponentadd.TabIndex = 33;
            this.btnAssessmentcomponentadd.Text = "Add";
            this.btnAssessmentcomponentadd.UseVisualStyleBackColor = true;
            // 
            // cmbTotalmarks
            // 
            this.cmbTotalmarks.FormattingEnabled = true;
            this.cmbTotalmarks.Location = new System.Drawing.Point(195, 167);
            this.cmbTotalmarks.Name = "cmbTotalmarks";
            this.cmbTotalmarks.Size = new System.Drawing.Size(121, 21);
            this.cmbTotalmarks.TabIndex = 30;
            // 
            // combrubricID2
            // 
            this.combrubricID2.FormattingEnabled = true;
            this.combrubricID2.Location = new System.Drawing.Point(195, 97);
            this.combrubricID2.Name = "combrubricID2";
            this.combrubricID2.Size = new System.Drawing.Size(121, 21);
            this.combrubricID2.TabIndex = 29;
            // 
            // lblassessmentID2
            // 
            this.lblassessmentID2.AutoSize = true;
            this.lblassessmentID2.Location = new System.Drawing.Point(34, 167);
            this.lblassessmentID2.Name = "lblassessmentID2";
            this.lblassessmentID2.Size = new System.Drawing.Size(77, 13);
            this.lblassessmentID2.TabIndex = 28;
            this.lblassessmentID2.Text = "Assessment ID\r\n";
            // 
            // lblTotalmark
            // 
            this.lblTotalmark.AutoSize = true;
            this.lblTotalmark.Location = new System.Drawing.Point(34, 135);
            this.lblTotalmark.Name = "lblTotalmark";
            this.lblTotalmark.Size = new System.Drawing.Size(63, 13);
            this.lblTotalmark.TabIndex = 27;
            this.lblTotalmark.Text = "Total Marks\r\n";
            // 
            // lblrubricID2
            // 
            this.lblrubricID2.AutoSize = true;
            this.lblrubricID2.Location = new System.Drawing.Point(34, 97);
            this.lblrubricID2.Name = "lblrubricID2";
            this.lblrubricID2.Size = new System.Drawing.Size(52, 13);
            this.lblrubricID2.TabIndex = 26;
            this.lblrubricID2.Text = "Rubric ID\r\n";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(195, 135);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(121, 20);
            this.textBox10.TabIndex = 25;
            // 
            // txtComponentName
            // 
            this.txtComponentName.Location = new System.Drawing.Point(195, 64);
            this.txtComponentName.Name = "txtComponentName";
            this.txtComponentName.Size = new System.Drawing.Size(121, 20);
            this.txtComponentName.TabIndex = 23;
            // 
            // lblcomponentName
            // 
            this.lblcomponentName.AutoSize = true;
            this.lblcomponentName.Location = new System.Drawing.Point(34, 64);
            this.lblcomponentName.Name = "lblcomponentName";
            this.lblcomponentName.Size = new System.Drawing.Size(92, 13);
            this.lblcomponentName.TabIndex = 22;
            this.lblcomponentName.Text = "Component Name";
            // 
            // tabassessment
            // 
            this.tabassessment.Controls.Add(this.btnassessemntDelete);
            this.tabassessment.Controls.Add(this.btnassessementedit);
            this.tabassessment.Controls.Add(this.btnassessmentAdd);
            this.tabassessment.Controls.Add(this.txtTotalweightage);
            this.tabassessment.Controls.Add(this.txtTotalMarks2);
            this.tabassessment.Controls.Add(this.lbltotalweightage);
            this.tabassessment.Controls.Add(this.lbltotalMarks2);
            this.tabassessment.Controls.Add(this.lblAssessmenttitle);
            this.tabassessment.Controls.Add(this.txtAssenssmentTitle);
            this.tabassessment.Location = new System.Drawing.Point(4, 22);
            this.tabassessment.Name = "tabassessment";
            this.tabassessment.Padding = new System.Windows.Forms.Padding(3);
            this.tabassessment.Size = new System.Drawing.Size(456, 293);
            this.tabassessment.TabIndex = 5;
            this.tabassessment.Text = "Assessment";
            this.tabassessment.UseVisualStyleBackColor = true;
            this.tabassessment.Click += new System.EventHandler(this.tabassessment_Click);
            // 
            // btnassessemntDelete
            // 
            this.btnassessemntDelete.Location = new System.Drawing.Point(234, 215);
            this.btnassessemntDelete.Name = "btnassessemntDelete";
            this.btnassessemntDelete.Size = new System.Drawing.Size(75, 23);
            this.btnassessemntDelete.TabIndex = 35;
            this.btnassessemntDelete.Text = "Delete";
            this.btnassessemntDelete.UseVisualStyleBackColor = true;
            // 
            // btnassessementedit
            // 
            this.btnassessementedit.Location = new System.Drawing.Point(129, 215);
            this.btnassessementedit.Name = "btnassessementedit";
            this.btnassessementedit.Size = new System.Drawing.Size(75, 23);
            this.btnassessementedit.TabIndex = 34;
            this.btnassessementedit.Text = "Edit";
            this.btnassessementedit.UseVisualStyleBackColor = true;
            // 
            // btnassessmentAdd
            // 
            this.btnassessmentAdd.Location = new System.Drawing.Point(32, 215);
            this.btnassessmentAdd.Name = "btnassessmentAdd";
            this.btnassessmentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnassessmentAdd.TabIndex = 33;
            this.btnassessmentAdd.Text = "Add";
            this.btnassessmentAdd.UseVisualStyleBackColor = true;
            // 
            // txtTotalweightage
            // 
            this.txtTotalweightage.Location = new System.Drawing.Point(185, 143);
            this.txtTotalweightage.Name = "txtTotalweightage";
            this.txtTotalweightage.Size = new System.Drawing.Size(100, 20);
            this.txtTotalweightage.TabIndex = 31;
            // 
            // txtTotalMarks2
            // 
            this.txtTotalMarks2.Location = new System.Drawing.Point(185, 105);
            this.txtTotalMarks2.Name = "txtTotalMarks2";
            this.txtTotalMarks2.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMarks2.TabIndex = 30;
            // 
            // lbltotalweightage
            // 
            this.lbltotalweightage.AutoSize = true;
            this.lbltotalweightage.Location = new System.Drawing.Point(54, 150);
            this.lbltotalweightage.Name = "lbltotalweightage";
            this.lbltotalweightage.Size = new System.Drawing.Size(86, 13);
            this.lbltotalweightage.TabIndex = 29;
            this.lbltotalweightage.Text = "Total Weightage";
            // 
            // lbltotalMarks2
            // 
            this.lbltotalMarks2.AutoSize = true;
            this.lbltotalMarks2.Location = new System.Drawing.Point(54, 112);
            this.lbltotalMarks2.Name = "lbltotalMarks2";
            this.lbltotalMarks2.Size = new System.Drawing.Size(63, 13);
            this.lbltotalMarks2.TabIndex = 28;
            this.lbltotalMarks2.Text = "Total Marks";
            // 
            // lblAssessmenttitle
            // 
            this.lblAssessmenttitle.AutoSize = true;
            this.lblAssessmenttitle.Location = new System.Drawing.Point(54, 69);
            this.lblAssessmenttitle.Name = "lblAssessmenttitle";
            this.lblAssessmenttitle.Size = new System.Drawing.Size(86, 13);
            this.lblAssessmenttitle.TabIndex = 27;
            this.lblAssessmenttitle.Text = "Assessment Title";
            // 
            // txtAssenssmentTitle
            // 
            this.txtAssenssmentTitle.Location = new System.Drawing.Point(185, 62);
            this.txtAssenssmentTitle.Name = "txtAssenssmentTitle";
            this.txtAssenssmentTitle.Size = new System.Drawing.Size(100, 20);
            this.txtAssenssmentTitle.TabIndex = 25;
            // 
            // tabStudentAttendance
            // 
            this.tabStudentAttendance.Controls.Add(this.btnAttendanceMark);
            this.tabStudentAttendance.Controls.Add(this.comboBox1);
            this.tabStudentAttendance.Controls.Add(this.lblattendanceStatus);
            this.tabStudentAttendance.Controls.Add(this.label1);
            this.tabStudentAttendance.Controls.Add(this.txtStudentAttendence);
            this.tabStudentAttendance.Location = new System.Drawing.Point(4, 22);
            this.tabStudentAttendance.Name = "tabStudentAttendance";
            this.tabStudentAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentAttendance.Size = new System.Drawing.Size(456, 293);
            this.tabStudentAttendance.TabIndex = 6;
            this.tabStudentAttendance.Text = "Attendance";
            this.tabStudentAttendance.UseVisualStyleBackColor = true;
            this.tabStudentAttendance.Click += new System.EventHandler(this.tabStudentAttendance_Click);
            // 
            // btnAttendanceMark
            // 
            this.btnAttendanceMark.Location = new System.Drawing.Point(53, 183);
            this.btnAttendanceMark.Name = "btnAttendanceMark";
            this.btnAttendanceMark.Size = new System.Drawing.Size(75, 23);
            this.btnAttendanceMark.TabIndex = 31;
            this.btnAttendanceMark.Text = "Mark";
            this.btnAttendanceMark.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // lblattendanceStatus
            // 
            this.lblattendanceStatus.AutoSize = true;
            this.lblattendanceStatus.Location = new System.Drawing.Point(50, 116);
            this.lblattendanceStatus.Name = "lblattendanceStatus";
            this.lblattendanceStatus.Size = new System.Drawing.Size(95, 13);
            this.lblattendanceStatus.TabIndex = 29;
            this.lblattendanceStatus.Text = "Attendance Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Student";
            // 
            // txtStudentAttendence
            // 
            this.txtStudentAttendence.Location = new System.Drawing.Point(188, 74);
            this.txtStudentAttendence.Name = "txtStudentAttendence";
            this.txtStudentAttendence.Size = new System.Drawing.Size(121, 20);
            this.txtStudentAttendence.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 293);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Student Evaluation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GVStudent
            // 
            this.GVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVStudent.Location = new System.Drawing.Point(514, 57);
            this.GVStudent.Name = "GVStudent";
            this.GVStudent.Size = new System.Drawing.Size(543, 254);
            this.GVStudent.TabIndex = 1;
            this.GVStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVStudent_CellClick);
            this.GVStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVStudent_CellContentClick);
            this.GVStudent.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVStudent_CellMouseClick);
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lookupBindingSource
            // 
            this.lookupBindingSource.DataMember = "Lookup";
            this.lookupBindingSource.DataSource = this.projectBDataSet;
            // 
            // lookupTableAdapter
            // 
            this.lookupTableAdapter.ClearBeforeFill = true;
            // 
            // lblRecord
            // 
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(581, 18);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(85, 36);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "Records";
            this.lblRecord.Click += new System.EventHandler(this.label2_Click);
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // fmCLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 343);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.GVStudent);
            this.Controls.Add(this.tabCTRLCLO);
            this.Name = "fmCLO";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCTRLCLO.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.tabclo.ResumeLayout(false);
            this.tabclo.PerformLayout();
            this.tabRubric.ResumeLayout(false);
            this.tabRubric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            this.tabRubriclevel.ResumeLayout(false);
            this.tabRubriclevel.PerformLayout();
            this.tabAssessmentComponent.ResumeLayout(false);
            this.tabAssessmentComponent.PerformLayout();
            this.tabassessment.ResumeLayout(false);
            this.tabassessment.PerformLayout();
            this.tabStudentAttendance.ResumeLayout(false);
            this.tabStudentAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void GVStudent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabCTRLCLO;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabclo;
        private System.Windows.Forms.TextBox txtstdregistrationNo;
        private System.Windows.Forms.TextBox txtstdemail;
        private System.Windows.Forms.TextBox txtstdcontact;
        private System.Windows.Forms.TextBox txtstdlastname;
        private System.Windows.Forms.TextBox txtstdfirstname;
        private System.Windows.Forms.Label lbstdregistrationNo;
        private System.Windows.Forms.Label lbstdemail;
        private System.Windows.Forms.Label lbstdcontact;
        private System.Windows.Forms.Label lblastname;
        private System.Windows.Forms.Label lbStdfirstname;
        private System.Windows.Forms.DataGridView GVStudent;
        private System.Windows.Forms.Button btnStudentadd;
        private System.Windows.Forms.TextBox txtcloname;
        private System.Windows.Forms.Label lblcloname;
        private System.Windows.Forms.Label lbstdstatus;
        private System.Windows.Forms.ComboBox cmbstdstatus;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource lookupBindingSource;
        private ProjectBDataSetTableAdapters.LookupTableAdapter lookupTableAdapter;
        private System.Windows.Forms.Button btnCLODelete;
        private System.Windows.Forms.Button btnCLOEdit;
        private System.Windows.Forms.Button btnCLOcadd;
        private System.Windows.Forms.TabPage tabRubric;
        private System.Windows.Forms.Button btnRubricDelete;
        private System.Windows.Forms.Button btnRubricEdit;
        private System.Windows.Forms.Button btnRubricadd;
        private System.Windows.Forms.TextBox txtrubricDetails;
        private System.Windows.Forms.Label lblRubric;
        private System.Windows.Forms.Label lblselectclo;
        private System.Windows.Forms.ComboBox cmbselectClo;
        private System.Windows.Forms.TabPage tabRubriclevel;
        private System.Windows.Forms.Button btnRubricLeveldelete;
        private System.Windows.Forms.Button btnRubricLeveledit;
        private System.Windows.Forms.Button btnrubriclevelAdd;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblMeasurementLevel;
        private System.Windows.Forms.TextBox txtRubriclvl_detail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMeasurementLevel;
        private System.Windows.Forms.ComboBox cmbRubricId;
        private System.Windows.Forms.TabPage tabAssessmentComponent;
        private System.Windows.Forms.Button btnAssessmentComponentDelete;
        private System.Windows.Forms.Button btnassessmentComponentedit;
        private System.Windows.Forms.Button btnAssessmentcomponentadd;
        private System.Windows.Forms.ComboBox cmbTotalmarks;
        private System.Windows.Forms.ComboBox combrubricID2;
        private System.Windows.Forms.Label lblassessmentID2;
        private System.Windows.Forms.Label lblTotalmark;
        private System.Windows.Forms.Label lblrubricID2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtComponentName;
        private System.Windows.Forms.Label lblcomponentName;
        private System.Windows.Forms.TabPage tabassessment;
        private System.Windows.Forms.Button btnassessemntDelete;
        private System.Windows.Forms.Button btnassessementedit;
        private System.Windows.Forms.Button btnassessmentAdd;
        private System.Windows.Forms.TextBox txtTotalweightage;
        private System.Windows.Forms.TextBox txtTotalMarks2;
        private System.Windows.Forms.Label lbltotalweightage;
        private System.Windows.Forms.Label lbltotalMarks2;
        private System.Windows.Forms.Label lblAssessmenttitle;
        private System.Windows.Forms.TextBox txtAssenssmentTitle;
        private System.Windows.Forms.TabPage tabStudentAttendance;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblattendanceStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentAttendence;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnstudentEdit;
        private System.Windows.Forms.Button btnAttendanceMark;
        private ProjectBDataSet1 projectBDataSet1;
        private BindingSource cloBindingSource;
        private ProjectBDataSet1TableAdapters.CloTableAdapter cloTableAdapter;
    }
}

