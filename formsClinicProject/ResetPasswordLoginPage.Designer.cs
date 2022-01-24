
namespace formsClinicProject
{
    partial class ResetPasswordLoginPage
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
            this.txtNewPasswordConfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bntAcceptPassword = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNewPasswordConfirm
            // 
            this.txtNewPasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPasswordConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPasswordConfirm.HintForeColor = System.Drawing.Color.Empty;
            this.txtNewPasswordConfirm.HintText = "";
            this.txtNewPasswordConfirm.isPassword = false;
            this.txtNewPasswordConfirm.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNewPasswordConfirm.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNewPasswordConfirm.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNewPasswordConfirm.LineThickness = 3;
            this.txtNewPasswordConfirm.Location = new System.Drawing.Point(43, 65);
            this.txtNewPasswordConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm";
            this.txtNewPasswordConfirm.Size = new System.Drawing.Size(207, 33);
            this.txtNewPasswordConfirm.TabIndex = 13;
            this.txtNewPasswordConfirm.Text = "New password";
            this.txtNewPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword.HintText = "";
            this.txtNewPassword.isPassword = false;
            this.txtNewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNewPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNewPassword.LineThickness = 3;
            this.txtNewPassword.Location = new System.Drawing.Point(43, 24);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(207, 33);
            this.txtNewPassword.TabIndex = 12;
            this.txtNewPassword.Text = "New password";
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bntAcceptPassword
            // 
            this.bntAcceptPassword.BackColor = System.Drawing.Color.Black;
            this.bntAcceptPassword.FlatAppearance.BorderSize = 0;
            this.bntAcceptPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bntAcceptPassword.ForeColor = System.Drawing.Color.White;
            this.bntAcceptPassword.Location = new System.Drawing.Point(150, 105);
            this.bntAcceptPassword.Name = "bntAcceptPassword";
            this.bntAcceptPassword.Size = new System.Drawing.Size(100, 43);
            this.bntAcceptPassword.TabIndex = 14;
            this.bntAcceptPassword.Text = "Accept";
            this.bntAcceptPassword.UseVisualStyleBackColor = false;
            this.bntAcceptPassword.Click += new System.EventHandler(this.bntAcceptPassword_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ResetPasswordLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 165);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bntAcceptPassword);
            this.Controls.Add(this.txtNewPasswordConfirm);
            this.Controls.Add(this.txtNewPassword);
            this.Name = "ResetPasswordLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset password";
            this.Load += new System.EventHandler(this.ResetPasswordLoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPasswordConfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPassword;
        private System.Windows.Forms.Button bntAcceptPassword;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}