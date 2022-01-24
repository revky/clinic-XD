
namespace formsClinicProject
{
    partial class AdminPanelForm
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelCalendarSubmenu = new System.Windows.Forms.Panel();
            this.buttonManageTerms = new System.Windows.Forms.Button();
            this.buttonCreateCalendar = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.panelUsersSubmenu = new System.Windows.Forms.Panel();
            this.buttonReviewPermissions = new System.Windows.Forms.Button();
            this.btnReviewAdmins = new System.Windows.Forms.Button();
            this.btnReviewEmplOfReg = new System.Windows.Forms.Button();
            this.btnReviewNurses = new System.Windows.Forms.Button();
            this.btnReviewDoctors = new System.Windows.Forms.Button();
            this.btnReviewUsers = new System.Windows.Forms.Button();
            this.btnReviews = new System.Windows.Forms.Button();
            this.panelDoctorsSubmenu = new System.Windows.Forms.Panel();
            this.btnAddCabinet = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelCalendarSubmenu.SuspendLayout();
            this.panelUsersSubmenu.SuspendLayout();
            this.panelDoctorsSubmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Controls.Add(this.panelCalendarSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonCalendar);
            this.panelSideMenu.Controls.Add(this.panelUsersSubmenu);
            this.panelSideMenu.Controls.Add(this.btnReviews);
            this.panelSideMenu.Controls.Add(this.panelDoctorsSubmenu);
            this.panelSideMenu.Controls.Add(this.btnManagement);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(220, 690);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelCalendarSubmenu
            // 
            this.panelCalendarSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelCalendarSubmenu.Controls.Add(this.buttonManageTerms);
            this.panelCalendarSubmenu.Controls.Add(this.buttonCreateCalendar);
            this.panelCalendarSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalendarSubmenu.Location = new System.Drawing.Point(0, 553);
            this.panelCalendarSubmenu.Name = "panelCalendarSubmenu";
            this.panelCalendarSubmenu.Size = new System.Drawing.Size(220, 88);
            this.panelCalendarSubmenu.TabIndex = 6;
            this.panelCalendarSubmenu.Visible = false;
            // 
            // buttonManageTerms
            // 
            this.buttonManageTerms.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManageTerms.FlatAppearance.BorderSize = 0;
            this.buttonManageTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageTerms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonManageTerms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonManageTerms.Location = new System.Drawing.Point(0, 40);
            this.buttonManageTerms.Name = "buttonManageTerms";
            this.buttonManageTerms.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonManageTerms.Size = new System.Drawing.Size(220, 48);
            this.buttonManageTerms.TabIndex = 1;
            this.buttonManageTerms.Text = "Manage terms";
            this.buttonManageTerms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManageTerms.UseVisualStyleBackColor = true;
            this.buttonManageTerms.Click += new System.EventHandler(this.buttonManageTerms_Click);
            // 
            // buttonCreateCalendar
            // 
            this.buttonCreateCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateCalendar.FlatAppearance.BorderSize = 0;
            this.buttonCreateCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateCalendar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateCalendar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCreateCalendar.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateCalendar.Name = "buttonCreateCalendar";
            this.buttonCreateCalendar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonCreateCalendar.Size = new System.Drawing.Size(220, 40);
            this.buttonCreateCalendar.TabIndex = 0;
            this.buttonCreateCalendar.Text = "Calendars";
            this.buttonCreateCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateCalendar.UseVisualStyleBackColor = true;
            this.buttonCreateCalendar.Click += new System.EventHandler(this.buttonCreateCalendar_Click);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCalendar.FlatAppearance.BorderSize = 0;
            this.buttonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCalendar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalendar.Location = new System.Drawing.Point(0, 508);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCalendar.Size = new System.Drawing.Size(220, 45);
            this.buttonCalendar.TabIndex = 5;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // panelUsersSubmenu
            // 
            this.panelUsersSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelUsersSubmenu.Controls.Add(this.buttonReviewPermissions);
            this.panelUsersSubmenu.Controls.Add(this.btnReviewAdmins);
            this.panelUsersSubmenu.Controls.Add(this.btnReviewEmplOfReg);
            this.panelUsersSubmenu.Controls.Add(this.btnReviewNurses);
            this.panelUsersSubmenu.Controls.Add(this.btnReviewDoctors);
            this.panelUsersSubmenu.Controls.Add(this.btnReviewUsers);
            this.panelUsersSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsersSubmenu.Location = new System.Drawing.Point(0, 272);
            this.panelUsersSubmenu.Name = "panelUsersSubmenu";
            this.panelUsersSubmenu.Size = new System.Drawing.Size(220, 236);
            this.panelUsersSubmenu.TabIndex = 4;
            // 
            // buttonReviewPermissions
            // 
            this.buttonReviewPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReviewPermissions.FlatAppearance.BorderSize = 0;
            this.buttonReviewPermissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReviewPermissions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReviewPermissions.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonReviewPermissions.Location = new System.Drawing.Point(0, 194);
            this.buttonReviewPermissions.Name = "buttonReviewPermissions";
            this.buttonReviewPermissions.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonReviewPermissions.Size = new System.Drawing.Size(220, 40);
            this.buttonReviewPermissions.TabIndex = 7;
            this.buttonReviewPermissions.Text = "Review permissions";
            this.buttonReviewPermissions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReviewPermissions.UseVisualStyleBackColor = true;
            this.buttonReviewPermissions.Click += new System.EventHandler(this.buttonReviewPermissions_Click_1);
            // 
            // btnReviewAdmins
            // 
            this.btnReviewAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnReviewAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReviewAdmins.FlatAppearance.BorderSize = 0;
            this.btnReviewAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewAdmins.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReviewAdmins.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReviewAdmins.Location = new System.Drawing.Point(0, 154);
            this.btnReviewAdmins.Name = "btnReviewAdmins";
            this.btnReviewAdmins.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReviewAdmins.Size = new System.Drawing.Size(220, 40);
            this.btnReviewAdmins.TabIndex = 6;
            this.btnReviewAdmins.Text = "Review administrators";
            this.btnReviewAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewAdmins.UseVisualStyleBackColor = false;
            this.btnReviewAdmins.Click += new System.EventHandler(this.btnReviewAdmins_Click_1);
            // 
            // btnReviewEmplOfReg
            // 
            this.btnReviewEmplOfReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReviewEmplOfReg.FlatAppearance.BorderSize = 0;
            this.btnReviewEmplOfReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewEmplOfReg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReviewEmplOfReg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReviewEmplOfReg.Location = new System.Drawing.Point(0, 114);
            this.btnReviewEmplOfReg.Name = "btnReviewEmplOfReg";
            this.btnReviewEmplOfReg.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReviewEmplOfReg.Size = new System.Drawing.Size(220, 40);
            this.btnReviewEmplOfReg.TabIndex = 3;
            this.btnReviewEmplOfReg.Text = "Review employees of reg.";
            this.btnReviewEmplOfReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewEmplOfReg.UseVisualStyleBackColor = true;
            this.btnReviewEmplOfReg.Click += new System.EventHandler(this.btnReviewEmplOfReg_Click);
            // 
            // btnReviewNurses
            // 
            this.btnReviewNurses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReviewNurses.FlatAppearance.BorderSize = 0;
            this.btnReviewNurses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewNurses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReviewNurses.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReviewNurses.Location = new System.Drawing.Point(0, 77);
            this.btnReviewNurses.Name = "btnReviewNurses";
            this.btnReviewNurses.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReviewNurses.Size = new System.Drawing.Size(220, 37);
            this.btnReviewNurses.TabIndex = 2;
            this.btnReviewNurses.Text = "Review nurses";
            this.btnReviewNurses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewNurses.UseVisualStyleBackColor = true;
            this.btnReviewNurses.Click += new System.EventHandler(this.btnReviewNurses_Click);
            // 
            // btnReviewDoctors
            // 
            this.btnReviewDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReviewDoctors.FlatAppearance.BorderSize = 0;
            this.btnReviewDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewDoctors.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReviewDoctors.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReviewDoctors.Location = new System.Drawing.Point(0, 40);
            this.btnReviewDoctors.Name = "btnReviewDoctors";
            this.btnReviewDoctors.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReviewDoctors.Size = new System.Drawing.Size(220, 37);
            this.btnReviewDoctors.TabIndex = 1;
            this.btnReviewDoctors.Text = "Review doctors";
            this.btnReviewDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewDoctors.UseVisualStyleBackColor = true;
            this.btnReviewDoctors.Click += new System.EventHandler(this.btnReviewDoctor_Click);
            // 
            // btnReviewUsers
            // 
            this.btnReviewUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReviewUsers.FlatAppearance.BorderSize = 0;
            this.btnReviewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewUsers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReviewUsers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReviewUsers.Location = new System.Drawing.Point(0, 0);
            this.btnReviewUsers.Name = "btnReviewUsers";
            this.btnReviewUsers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReviewUsers.Size = new System.Drawing.Size(220, 40);
            this.btnReviewUsers.TabIndex = 0;
            this.btnReviewUsers.Text = "Review users";
            this.btnReviewUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewUsers.UseVisualStyleBackColor = true;
            this.btnReviewUsers.Click += new System.EventHandler(this.btnReviewUsers_Click);
            // 
            // btnReviews
            // 
            this.btnReviews.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReviews.FlatAppearance.BorderSize = 0;
            this.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviews.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReviews.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReviews.Location = new System.Drawing.Point(0, 227);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReviews.Size = new System.Drawing.Size(220, 45);
            this.btnReviews.TabIndex = 3;
            this.btnReviews.Text = "Reviews";
            this.btnReviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviews.UseVisualStyleBackColor = true;
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
            // 
            // panelDoctorsSubmenu
            // 
            this.panelDoctorsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelDoctorsSubmenu.Controls.Add(this.btnAddCabinet);
            this.panelDoctorsSubmenu.Controls.Add(this.btnAddEmployee);
            this.panelDoctorsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoctorsSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelDoctorsSubmenu.Name = "panelDoctorsSubmenu";
            this.panelDoctorsSubmenu.Size = new System.Drawing.Size(220, 82);
            this.panelDoctorsSubmenu.TabIndex = 2;
            // 
            // btnAddCabinet
            // 
            this.btnAddCabinet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCabinet.FlatAppearance.BorderSize = 0;
            this.btnAddCabinet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddCabinet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddCabinet.Location = new System.Drawing.Point(0, 40);
            this.btnAddCabinet.Name = "btnAddCabinet";
            this.btnAddCabinet.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddCabinet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddCabinet.Size = new System.Drawing.Size(220, 40);
            this.btnAddCabinet.TabIndex = 1;
            this.btnAddCabinet.Text = "Add new cabinet";
            this.btnAddCabinet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCabinet.UseVisualStyleBackColor = true;
            this.btnAddCabinet.Click += new System.EventHandler(this.btnAddCabinet_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddEmployee.Size = new System.Drawing.Size(220, 40);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add new employee";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManagement.Location = new System.Drawing.Point(0, 100);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManagement.Size = new System.Drawing.Size(220, 45);
            this.btnManagement.TabIndex = 1;
            this.btnManagement.Text = "Management";
            this.btnManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 99);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.Location = new System.Drawing.Point(812, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(88, 34);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(52, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(152, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Hello login";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(366, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = ".NET MED CLINIC ";
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1123, 690);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.panelSideMenu.ResumeLayout(false);
            this.panelCalendarSubmenu.ResumeLayout(false);
            this.panelUsersSubmenu.ResumeLayout(false);
            this.panelDoctorsSubmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelDoctorsSubmenu;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAddCabinet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelUsersSubmenu;
        private System.Windows.Forms.Button btnReviewDoctors;
        private System.Windows.Forms.Button btnReviewUsers;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnReviewEmplOfReg;
        private System.Windows.Forms.Button btnReviewNurses;
        private System.Windows.Forms.Button btnReviewAdmins;
        private System.Windows.Forms.Button buttonReviewPermissions;
        private System.Windows.Forms.Panel panelCalendarSubmenu;
        private System.Windows.Forms.Button buttonCreateCalendar;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonManageTerms;
    }
}