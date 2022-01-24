
namespace formsClinicProject
{
    partial class AddEmployeeForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtboxFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxEmailAddres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxPhoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBoxSpecialty = new System.Windows.Forms.ComboBox();
            this.txtboxMobile = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(698, 513);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 33);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Next";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add new employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(61, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "FIRST NAME:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(542, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(61, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "LAST NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(62, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-MAIL ADDRES:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(62, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "PHONE NUMBER:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(538, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "SPECIALTY:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(538, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "ROLE:";
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
            this.txtboxFirstName.Location = new System.Drawing.Point(65, 136);
            this.txtboxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(216, 38);
            this.txtboxFirstName.TabIndex = 20;
            this.txtboxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtboxLastName.Location = new System.Drawing.Point(65, 204);
            this.txtboxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(216, 38);
            this.txtboxLastName.TabIndex = 21;
            this.txtboxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtboxEmailAddres.Location = new System.Drawing.Point(66, 410);
            this.txtboxEmailAddres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxEmailAddres.Name = "txtboxEmailAddres";
            this.txtboxEmailAddres.Size = new System.Drawing.Size(216, 38);
            this.txtboxEmailAddres.TabIndex = 24;
            this.txtboxEmailAddres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(66, 272);
            this.txtboxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(216, 38);
            this.txtboxPhoneNumber.TabIndex = 22;
            this.txtboxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxPhoneNumber_KeyPress);
            // 
            // comboBoxSpecialty
            // 
            this.comboBoxSpecialty.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboBoxSpecialty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSpecialty.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSpecialty.FormattingEnabled = true;
            this.comboBoxSpecialty.Location = new System.Drawing.Point(542, 282);
            this.comboBoxSpecialty.Name = "comboBoxSpecialty";
            this.comboBoxSpecialty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxSpecialty.Size = new System.Drawing.Size(216, 28);
            this.comboBoxSpecialty.TabIndex = 27;
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
            this.txtboxMobile.Location = new System.Drawing.Point(65, 340);
            this.txtboxMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxMobile.Name = "txtboxMobile";
            this.txtboxMobile.Size = new System.Drawing.Size(216, 38);
            this.txtboxMobile.TabIndex = 23;
            this.txtboxMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxMobile_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(61, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "MOBILE:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(542, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 24);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboBoxRole.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxRole.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(542, 214);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxRole.Size = new System.Drawing.Size(216, 28);
            this.comboBoxRole.TabIndex = 26;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(538, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "DATE OF BIRTH:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(184, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "(optional):";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(868, 587);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxFirstName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxEmailAddres;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxSpecialty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxMobile;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxRole;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
    }
}