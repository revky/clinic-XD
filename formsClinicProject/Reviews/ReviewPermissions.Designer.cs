
namespace formsClinicProject.Reviews
{
    partial class ReviewPermissions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewListOfPermissions = new System.Windows.Forms.DataGridView();
            this.Permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxPermissionGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPermission = new System.Windows.Forms.Button();
            this.buttonDeletePermission = new System.Windows.Forms.Button();
            this.dataGridViewAvaliblePermissions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvaliblePermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListOfPermissions
            // 
            this.dataGridViewListOfPermissions.AllowUserToAddRows = false;
            this.dataGridViewListOfPermissions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListOfPermissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListOfPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListOfPermissions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListOfPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListOfPermissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListOfPermissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListOfPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListOfPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Permission});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListOfPermissions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListOfPermissions.EnableHeadersVisualStyles = false;
            this.dataGridViewListOfPermissions.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewListOfPermissions.Name = "dataGridViewListOfPermissions";
            this.dataGridViewListOfPermissions.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListOfPermissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewListOfPermissions.RowHeadersVisible = false;
            this.dataGridViewListOfPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListOfPermissions.Size = new System.Drawing.Size(418, 452);
            this.dataGridViewListOfPermissions.TabIndex = 6;
            // 
            // Permission
            // 
            this.Permission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Permission.HeaderText = "Permissions assigned to group";
            this.Permission.Name = "Permission";
            this.Permission.ReadOnly = true;
            // 
            // comboBoxPermissionGroup
            // 
            this.comboBoxPermissionGroup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPermissionGroup.FormattingEnabled = true;
            this.comboBoxPermissionGroup.Items.AddRange(new object[] {
            "Administrator",
            "Doctor",
            "Nurse",
            "Employee of registration"});
            this.comboBoxPermissionGroup.Location = new System.Drawing.Point(602, 35);
            this.comboBoxPermissionGroup.Name = "comboBoxPermissionGroup";
            this.comboBoxPermissionGroup.Size = new System.Drawing.Size(270, 29);
            this.comboBoxPermissionGroup.TabIndex = 7;
            this.comboBoxPermissionGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Review permission groups";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(599, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Permission group:";
            // 
            // btnAddPermission
            // 
            this.btnAddPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPermission.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPermission.FlatAppearance.BorderSize = 0;
            this.btnAddPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPermission.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddPermission.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPermission.Location = new System.Drawing.Point(454, 557);
            this.btnAddPermission.Name = "btnAddPermission";
            this.btnAddPermission.Size = new System.Drawing.Size(141, 33);
            this.btnAddPermission.TabIndex = 10;
            this.btnAddPermission.Text = "Add permission";
            this.btnAddPermission.UseVisualStyleBackColor = false;
            this.btnAddPermission.Click += new System.EventHandler(this.btnShowPermissions_Click);
            // 
            // buttonDeletePermission
            // 
            this.buttonDeletePermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletePermission.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeletePermission.FlatAppearance.BorderSize = 0;
            this.buttonDeletePermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePermission.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeletePermission.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeletePermission.Location = new System.Drawing.Point(12, 557);
            this.buttonDeletePermission.Name = "buttonDeletePermission";
            this.buttonDeletePermission.Size = new System.Drawing.Size(141, 33);
            this.buttonDeletePermission.TabIndex = 11;
            this.buttonDeletePermission.Text = "Delete permission";
            this.buttonDeletePermission.UseVisualStyleBackColor = false;
            this.buttonDeletePermission.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewAvaliblePermissions
            // 
            this.dataGridViewAvaliblePermissions.AllowUserToAddRows = false;
            this.dataGridViewAvaliblePermissions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAvaliblePermissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAvaliblePermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAvaliblePermissions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAvaliblePermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAvaliblePermissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAvaliblePermissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAvaliblePermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAvaliblePermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvaliblePermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAvaliblePermissions.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAvaliblePermissions.EnableHeadersVisualStyles = false;
            this.dataGridViewAvaliblePermissions.Location = new System.Drawing.Point(454, 87);
            this.dataGridViewAvaliblePermissions.Name = "dataGridViewAvaliblePermissions";
            this.dataGridViewAvaliblePermissions.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvaliblePermissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewAvaliblePermissions.RowHeadersVisible = false;
            this.dataGridViewAvaliblePermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvaliblePermissions.Size = new System.Drawing.Size(418, 452);
            this.dataGridViewAvaliblePermissions.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Avalible permissions";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ReviewPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 626);
            this.Controls.Add(this.dataGridViewAvaliblePermissions);
            this.Controls.Add(this.buttonDeletePermission);
            this.Controls.Add(this.btnAddPermission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPermissionGroup);
            this.Controls.Add(this.dataGridViewListOfPermissions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReviewPermissions";
            this.Text = "ReviewPermissions";
            this.Load += new System.EventHandler(this.ReviewPermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvaliblePermissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListOfPermissions;
        private System.Windows.Forms.ComboBox comboBoxPermissionGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permission;
        private System.Windows.Forms.Button buttonDeletePermission;
        private System.Windows.Forms.DataGridView dataGridViewAvaliblePermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}