
namespace formsClinicProject
{
    partial class ReviewUsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.dataGridViewListOfUsers = new System.Windows.Forms.DataGridView();
            this.btnDeactivatelUser = new System.Windows.Forms.Button();
            this.btnSetChangePasswordUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Review users";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditUser.Location = new System.Drawing.Point(359, 375);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(122, 33);
            this.btnEditUser.TabIndex = 6;
            this.btnEditUser.Text = "Edit user\'s data";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // dataGridViewListOfUsers
            // 
            this.dataGridViewListOfUsers.AllowUserToAddRows = false;
            this.dataGridViewListOfUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListOfUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListOfUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListOfUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListOfUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListOfUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListOfUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListOfUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListOfUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListOfUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListOfUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewListOfUsers.Location = new System.Drawing.Point(65, 73);
            this.dataGridViewListOfUsers.Name = "dataGridViewListOfUsers";
            this.dataGridViewListOfUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListOfUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewListOfUsers.RowHeadersVisible = false;
            this.dataGridViewListOfUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListOfUsers.Size = new System.Drawing.Size(693, 276);
            this.dataGridViewListOfUsers.TabIndex = 4;
            this.dataGridViewListOfUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListOfUsers_CellContentClick);
            this.dataGridViewListOfUsers.SelectionChanged += new System.EventHandler(this.dataGridViewListOfUsers_SelectionChanged);
            // 
            // btnDeactivatelUser
            // 
            this.btnDeactivatelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeactivatelUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeactivatelUser.FlatAppearance.BorderSize = 0;
            this.btnDeactivatelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivatelUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeactivatelUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeactivatelUser.Location = new System.Drawing.Point(636, 376);
            this.btnDeactivatelUser.Name = "btnDeactivatelUser";
            this.btnDeactivatelUser.Size = new System.Drawing.Size(122, 33);
            this.btnDeactivatelUser.TabIndex = 9;
            this.btnDeactivatelUser.Text = "Deactivate user";
            this.btnDeactivatelUser.UseVisualStyleBackColor = false;
            this.btnDeactivatelUser.Click += new System.EventHandler(this.btnDeactivatelUser_Click);
            // 
            // btnSetChangePasswordUser
            // 
            this.btnSetChangePasswordUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetChangePasswordUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetChangePasswordUser.FlatAppearance.BorderSize = 0;
            this.btnSetChangePasswordUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetChangePasswordUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetChangePasswordUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetChangePasswordUser.Location = new System.Drawing.Point(498, 376);
            this.btnSetChangePasswordUser.Name = "btnSetChangePasswordUser";
            this.btnSetChangePasswordUser.Size = new System.Drawing.Size(122, 33);
            this.btnSetChangePasswordUser.TabIndex = 11;
            this.btnSetChangePasswordUser.Text = "Change Password";
            this.btnSetChangePasswordUser.UseVisualStyleBackColor = false;
            this.btnSetChangePasswordUser.Click += new System.EventHandler(this.btnSetChangePasswordUser_Click);
            // 
            // ReviewUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetChangePasswordUser);
            this.Controls.Add(this.btnDeactivatelUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.dataGridViewListOfUsers);
            this.Name = "ReviewUsersForm";
            this.Text = "ReviewUsers";
            this.Load += new System.EventHandler(this.ReviewUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.DataGridView dataGridViewListOfUsers;
        private System.Windows.Forms.Button btnDeactivatelUser;
        private System.Windows.Forms.Button btnSetChangePasswordUser;
    }
}