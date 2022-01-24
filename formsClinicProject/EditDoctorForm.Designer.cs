
namespace formsClinicProject
{
    partial class EditDoctorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonActive = new System.Windows.Forms.RadioButton();
            this.radioButtonInactive = new System.Windows.Forms.RadioButton();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecialty = new System.Windows.Forms.ComboBox();
            this.txtBoxHourEnd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxHourStart = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxPhoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxPeselNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxEmailAddres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxSecondName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtboxFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonActive);
            this.groupBox1.Controls.Add(this.radioButtonInactive);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(372, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 88);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS:";
            // 
            // radioButtonActive
            // 
            this.radioButtonActive.AutoSize = true;
            this.radioButtonActive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonActive.Location = new System.Drawing.Point(6, 25);
            this.radioButtonActive.Name = "radioButtonActive";
            this.radioButtonActive.Size = new System.Drawing.Size(76, 24);
            this.radioButtonActive.TabIndex = 35;
            this.radioButtonActive.TabStop = true;
            this.radioButtonActive.Text = "Active";
            this.radioButtonActive.UseVisualStyleBackColor = true;
            // 
            // radioButtonInactive
            // 
            this.radioButtonInactive.AutoSize = true;
            this.radioButtonInactive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonInactive.Location = new System.Drawing.Point(6, 55);
            this.radioButtonInactive.Name = "radioButtonInactive";
            this.radioButtonInactive.Size = new System.Drawing.Size(89, 24);
            this.radioButtonInactive.TabIndex = 36;
            this.radioButtonInactive.TabStop = true;
            this.radioButtonInactive.Text = "Inactive";
            this.radioButtonInactive.UseVisualStyleBackColor = true;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboBoxRoom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxRoom.Location = new System.Drawing.Point(371, 234);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxRoom.Size = new System.Drawing.Size(216, 28);
            this.comboBoxRoom.TabIndex = 62;
            // 
            // comboBoxSpecialty
            // 
            this.comboBoxSpecialty.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboBoxSpecialty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSpecialty.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSpecialty.FormattingEnabled = true;
            this.comboBoxSpecialty.Items.AddRange(new object[] {
            "Anesthosiology",
            "Dermatology",
            "Pediatrics"});
            this.comboBoxSpecialty.Location = new System.Drawing.Point(371, 166);
            this.comboBoxSpecialty.Name = "comboBoxSpecialty";
            this.comboBoxSpecialty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxSpecialty.Size = new System.Drawing.Size(216, 28);
            this.comboBoxSpecialty.TabIndex = 61;
            // 
            // txtBoxHourEnd
            // 
            this.txtBoxHourEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxHourEnd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxHourEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxHourEnd.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxHourEnd.HintText = "";
            this.txtBoxHourEnd.isPassword = false;
            this.txtBoxHourEnd.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBoxHourEnd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxHourEnd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBoxHourEnd.LineThickness = 4;
            this.txtBoxHourEnd.Location = new System.Drawing.Point(775, 369);
            this.txtBoxHourEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxHourEnd.Name = "txtBoxHourEnd";
            this.txtBoxHourEnd.Size = new System.Drawing.Size(49, 38);
            this.txtBoxHourEnd.TabIndex = 60;
            this.txtBoxHourEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(746, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 59;
            this.label14.Text = " - ";
            // 
            // txtBoxHourStart
            // 
            this.txtBoxHourStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxHourStart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxHourStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxHourStart.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxHourStart.HintText = "";
            this.txtBoxHourStart.isPassword = false;
            this.txtBoxHourStart.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBoxHourStart.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxHourStart.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBoxHourStart.LineThickness = 4;
            this.txtBoxHourStart.Location = new System.Drawing.Point(690, 369);
            this.txtBoxHourStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxHourStart.Name = "txtBoxHourStart";
            this.txtBoxHourStart.Size = new System.Drawing.Size(49, 38);
            this.txtBoxHourStart.TabIndex = 58;
            this.txtBoxHourStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(22, 428);
            this.txtboxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(216, 38);
            this.txtboxPhoneNumber.TabIndex = 57;
            this.txtboxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtboxPeselNumber
            // 
            this.txtboxPeselNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPeselNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxPeselNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxPeselNumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxPeselNumber.HintText = "";
            this.txtboxPeselNumber.isPassword = false;
            this.txtboxPeselNumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxPeselNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxPeselNumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxPeselNumber.LineThickness = 4;
            this.txtboxPeselNumber.Location = new System.Drawing.Point(22, 360);
            this.txtboxPeselNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPeselNumber.Name = "txtboxPeselNumber";
            this.txtboxPeselNumber.Size = new System.Drawing.Size(216, 38);
            this.txtboxPeselNumber.TabIndex = 56;
            this.txtboxPeselNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtboxEmailAddres.Location = new System.Drawing.Point(22, 292);
            this.txtboxEmailAddres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxEmailAddres.Name = "txtboxEmailAddres";
            this.txtboxEmailAddres.Size = new System.Drawing.Size(216, 38);
            this.txtboxEmailAddres.TabIndex = 55;
            this.txtboxEmailAddres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtboxSecondName
            // 
            this.txtboxSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxSecondName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxSecondName.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxSecondName.HintText = "";
            this.txtboxSecondName.isPassword = false;
            this.txtboxSecondName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxSecondName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxSecondName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxSecondName.LineThickness = 4;
            this.txtboxSecondName.Location = new System.Drawing.Point(22, 224);
            this.txtboxSecondName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSecondName.Name = "txtboxSecondName";
            this.txtboxSecondName.Size = new System.Drawing.Size(216, 38);
            this.txtboxSecondName.TabIndex = 54;
            this.txtboxSecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtboxFirstName.Location = new System.Drawing.Point(22, 156);
            this.txtboxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(216, 38);
            this.txtboxFirstName.TabIndex = 53;
            this.txtboxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "MONDAY",
            "TUESDAY",
            "WEDNESDAY",
            "THURSDAY",
            "FRIDAY",
            "SATURDAY",
            "SUNDAY"});
            this.checkedListBox1.Location = new System.Drawing.Point(690, 166);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(134, 130);
            this.checkedListBox1.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(686, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "WORKING HOURS:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(686, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "WORKING DAYS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(367, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "ROOM:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(368, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Optional Data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(19, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "Mandatory data:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(367, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "SPECIALTY:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(18, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "PHONE NUMBER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(18, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "PESEL NUMBER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "E-MAIL ADDRES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "SECOND NAME:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(731, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 33);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "FIRST NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "Edit doctor\'s data";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(579, 513);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 33);
            this.btnConfirm.TabIndex = 38;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // EditDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(868, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.comboBoxSpecialty);
            this.Controls.Add(this.txtBoxHourEnd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBoxHourStart);
            this.Controls.Add(this.txtboxPhoneNumber);
            this.Controls.Add(this.txtboxPeselNumber);
            this.Controls.Add(this.txtboxEmailAddres);
            this.Controls.Add(this.txtboxSecondName);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Name = "EditDoctorForm";
            this.Text = "EditDoctorForm";
            this.Load += new System.EventHandler(this.EditDoctorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonActive;
        private System.Windows.Forms.RadioButton radioButtonInactive;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.ComboBox comboBoxSpecialty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxHourEnd;
        internal System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxHourStart;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxPhoneNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxPeselNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxEmailAddres;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxSecondName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxFirstName;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
    }
}