
namespace formsClinicProject
{
    partial class EditEmployeeForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtboxMobile = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecialty = new System.Windows.Forms.ComboBox();
            this.txtboxPhoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxEmailAddres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clinic4DataSet = new formsClinicProject.clinic4DataSet();
            this.clinic4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic4DataSet1 = new formsClinicProject.clinic4DataSet1();
            this.employeeroleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_roleTableAdapter = new formsClinicProject.clinic4DataSet1TableAdapters.Employee_roleTableAdapter();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.employeeRoleDataSet = new formsClinicProject.employeeRoleDataSet();
            this.employeeroleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_roleTableAdapter1 = new formsClinicProject.employeeRoleDataSetTableAdapters.Employee_roleTableAdapter();
            this.employeeroleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeroleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeroleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeroleBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(698, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 33);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(543, 513);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 33);
            this.btnConfirm.TabIndex = 38;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "Review/Edit employee\'s data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(539, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "DATE OF BIRTH:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(543, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 24);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // txtboxMobile
            // 
            this.txtboxMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxMobile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxMobile.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxMobile.HintText = "";
            this.txtboxMobile.isPassword = false;
            this.txtboxMobile.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxMobile.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxMobile.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxMobile.LineThickness = 4;
            this.txtboxMobile.Location = new System.Drawing.Point(65, 341);
            this.txtboxMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxMobile.Name = "txtboxMobile";
            this.txtboxMobile.Size = new System.Drawing.Size(216, 38);
            this.txtboxMobile.TabIndex = 52;
            this.txtboxMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxMobile_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(61, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "MOBILE:";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboBoxRole.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxRole.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(543, 215);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxRole.Size = new System.Drawing.Size(216, 28);
            this.comboBoxRole.TabIndex = 55;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // comboBoxSpecialty
            // 
            this.comboBoxSpecialty.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboBoxSpecialty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSpecialty.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSpecialty.FormattingEnabled = true;
            this.comboBoxSpecialty.Location = new System.Drawing.Point(543, 283);
            this.comboBoxSpecialty.Name = "comboBoxSpecialty";
            this.comboBoxSpecialty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxSpecialty.Size = new System.Drawing.Size(216, 28);
            this.comboBoxSpecialty.TabIndex = 56;
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxPhoneNumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxPhoneNumber.HintText = "";
            this.txtboxPhoneNumber.isPassword = false;
            this.txtboxPhoneNumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxPhoneNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxPhoneNumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxPhoneNumber.LineThickness = 4;
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(66, 273);
            this.txtboxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(216, 38);
            this.txtboxPhoneNumber.TabIndex = 51;
            this.txtboxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxPhoneNumber_KeyPress_1);
            // 
            // txtboxEmailAddres
            // 
            this.txtboxEmailAddres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxEmailAddres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxEmailAddres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxEmailAddres.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxEmailAddres.HintText = "";
            this.txtboxEmailAddres.isPassword = false;
            this.txtboxEmailAddres.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxEmailAddres.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxEmailAddres.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxEmailAddres.LineThickness = 4;
            this.txtboxEmailAddres.Location = new System.Drawing.Point(66, 411);
            this.txtboxEmailAddres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxEmailAddres.Name = "txtboxEmailAddres";
            this.txtboxEmailAddres.Size = new System.Drawing.Size(216, 38);
            this.txtboxEmailAddres.TabIndex = 53;
            this.txtboxEmailAddres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxLastName.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxLastName.HintText = "";
            this.txtboxLastName.isPassword = false;
            this.txtboxLastName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxLastName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxLastName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxLastName.LineThickness = 4;
            this.txtboxLastName.Location = new System.Drawing.Point(65, 205);
            this.txtboxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(216, 38);
            this.txtboxLastName.TabIndex = 50;
            this.txtboxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxFirstName.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxFirstName.HintText = "";
            this.txtboxFirstName.isPassword = false;
            this.txtboxFirstName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxFirstName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxFirstName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxFirstName.LineThickness = 4;
            this.txtboxFirstName.Location = new System.Drawing.Point(65, 137);
            this.txtboxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(216, 38);
            this.txtboxFirstName.TabIndex = 49;
            this.txtboxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(539, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "ROLE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(539, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "SPECIALTY:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(62, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "PHONE NUMBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(62, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "E-MAIL ADDRES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(61, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "LAST NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "FIRST NAME:";
            // 
            // clinic4DataSet
            // 
            this.clinic4DataSet.DataSetName = "clinic4DataSet";
            this.clinic4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinic4DataSetBindingSource
            // 
            this.clinic4DataSetBindingSource.DataSource = this.clinic4DataSet;
            this.clinic4DataSetBindingSource.Position = 0;
            // 
            // clinic4DataSet1
            // 
            this.clinic4DataSet1.DataSetName = "clinic4DataSet1";
            this.clinic4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeroleBindingSource
            // 
            this.employeeroleBindingSource.DataMember = "Employee_role";
            this.employeeroleBindingSource.DataSource = this.clinic4DataSet1;
            // 
            // employee_roleTableAdapter
            // 
            this.employee_roleTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateUser.FlatAppearance.BorderSize = 0;
            this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateUser.Location = new System.Drawing.Point(543, 463);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(278, 33);
            this.buttonCreateUser.TabIndex = 62;
            this.buttonCreateUser.Text = "Create system user";
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // employeeRoleDataSet
            // 
            this.employeeRoleDataSet.DataSetName = "employeeRoleDataSet";
            this.employeeRoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeroleBindingSource1
            // 
            this.employeeroleBindingSource1.DataMember = "Employee_role";
            this.employeeroleBindingSource1.DataSource = this.employeeRoleDataSet;
            // 
            this.employeeRoleDataSet.DataSetName = "employeeRoleDataSet";
            this.employeeRoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeroleBindingSource1
            // 
            this.employeeroleBindingSource1.DataMember = "Employee_role";
            this.employeeroleBindingSource1.DataSource = this.employeeRoleDataSet;
            // 
            // employee_roleTableAdapter1
            // 
            this.employee_roleTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeroleBindingSource2
            // 
            this.employeeroleBindingSource2.DataMember = "Employee_role";
            this.employeeroleBindingSource2.DataSource = this.employeeRoleDataSet;
            // 

            // employee_roleTableAdapter1
            // 
            this.employee_roleTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeroleBindingSource2
            // 
            this.employeeroleBindingSource2.DataMember = "Employee_role";
            this.employeeroleBindingSource2.DataSource = this.employeeRoleDataSet;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(868, 587);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtboxMobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.comboBoxSpecialty);
            this.Controls.Add(this.txtboxPhoneNumber);
            this.Controls.Add(this.txtboxEmailAddres);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeroleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeroleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeroleBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxMobile;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.ComboBox comboBoxSpecialty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxPhoneNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxEmailAddres;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxFirstName;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource clinic4DataSetBindingSource;
        private clinic4DataSet clinic4DataSet;
        private clinic4DataSet1 clinic4DataSet1;
        private System.Windows.Forms.BindingSource employeeroleBindingSource;
        private clinic4DataSet1TableAdapters.Employee_roleTableAdapter employee_roleTableAdapter;
        private System.Windows.Forms.Button buttonCreateUser;
        private employeeRoleDataSet employeeRoleDataSet;
        private System.Windows.Forms.BindingSource employeeroleBindingSource1;
        private employeeRoleDataSetTableAdapters.Employee_roleTableAdapter employee_roleTableAdapter1;
        private System.Windows.Forms.BindingSource employeeroleBindingSource2;
    }
}