
namespace formsClinicProject.Management
{
    partial class TermsManagementForm
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
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxCalendar = new System.Windows.Forms.ComboBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelCalendar = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewTerms = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownStartHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndHour = new System.Windows.Forms.NumericUpDown();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.comboBoxCabinets = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelStartHour = new System.Windows.Forms.Label();
            this.labelFinalHour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndHour)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.BackColor = System.Drawing.Color.White;
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(49, 60);
            this.comboBoxEmployee.MaxDropDownItems = 50;
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(292, 29);
            this.comboBoxEmployee.TabIndex = 0;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployee_SelectedIndexChanged);
            // 
            // comboBoxCalendar
            // 
            this.comboBoxCalendar.BackColor = System.Drawing.Color.White;
            this.comboBoxCalendar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCalendar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCalendar.FormattingEnabled = true;
            this.comboBoxCalendar.Location = new System.Drawing.Point(49, 130);
            this.comboBoxCalendar.Name = "comboBoxCalendar";
            this.comboBoxCalendar.Size = new System.Drawing.Size(292, 29);
            this.comboBoxCalendar.TabIndex = 1;
            this.comboBoxCalendar.Visible = false;
            this.comboBoxCalendar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmployee.Location = new System.Drawing.Point(49, 41);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(69, 17);
            this.labelEmployee.TabIndex = 2;
            this.labelEmployee.Text = "Employee:";
            // 
            // labelCalendar
            // 
            this.labelCalendar.AutoSize = true;
            this.labelCalendar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCalendar.Location = new System.Drawing.Point(46, 110);
            this.labelCalendar.Name = "labelCalendar";
            this.labelCalendar.Size = new System.Drawing.Size(66, 17);
            this.labelCalendar.TabIndex = 3;
            this.labelCalendar.Text = "Calendar:";
            this.labelCalendar.Visible = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar.Location = new System.Drawing.Point(62, 175);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // dataGridViewTerms
            // 
            this.dataGridViewTerms.AllowUserToAddRows = false;
            this.dataGridViewTerms.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTerms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTerms.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewTerms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTerms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTerms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTerms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTerms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Time,
            this.Cabinet});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTerms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTerms.EnableHeadersVisualStyles = false;
            this.dataGridViewTerms.Location = new System.Drawing.Point(394, 41);
            this.dataGridViewTerms.Name = "dataGridViewTerms";
            this.dataGridViewTerms.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTerms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTerms.RowHeadersVisible = false;
            this.dataGridViewTerms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTerms.Size = new System.Drawing.Size(444, 474);
            this.dataGridViewTerms.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Cabinet
            // 
            this.Cabinet.HeaderText = "Cabinet";
            this.Cabinet.Name = "Cabinet";
            this.Cabinet.ReadOnly = true;
            // 
            // numericUpDownStartHour
            // 
            this.numericUpDownStartHour.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownStartHour.Location = new System.Drawing.Point(94, 413);
            this.numericUpDownStartHour.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownStartHour.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownStartHour.Name = "numericUpDownStartHour";
            this.numericUpDownStartHour.Size = new System.Drawing.Size(84, 31);
            this.numericUpDownStartHour.TabIndex = 16;
            this.numericUpDownStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownStartHour.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownStartHour.Visible = false;
            // 
            // numericUpDownEndHour
            // 
            this.numericUpDownEndHour.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownEndHour.Location = new System.Drawing.Point(211, 413);
            this.numericUpDownEndHour.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownEndHour.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownEndHour.Name = "numericUpDownEndHour";
            this.numericUpDownEndHour.Size = new System.Drawing.Size(84, 31);
            this.numericUpDownEndHour.TabIndex = 17;
            this.numericUpDownEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownEndHour.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownEndHour.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfirm.Location = new System.Drawing.Point(110, 469);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(157, 45);
            this.buttonConfirm.TabIndex = 39;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // comboBoxCabinets
            // 
            this.comboBoxCabinets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCabinets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCabinets.FormattingEnabled = true;
            this.comboBoxCabinets.Location = new System.Drawing.Point(94, 359);
            this.comboBoxCabinets.Name = "comboBoxCabinets";
            this.comboBoxCabinets.Size = new System.Drawing.Size(201, 26);
            this.comboBoxCabinets.TabIndex = 40;
            this.comboBoxCabinets.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(110, 469);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(157, 45);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStartHour.Location = new System.Drawing.Point(91, 397);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(60, 16);
            this.labelStartHour.TabIndex = 42;
            this.labelStartHour.Text = "Start hour";
            this.labelStartHour.Visible = false;
            // 
            // labelFinalHour
            // 
            this.labelFinalHour.AutoSize = true;
            this.labelFinalHour.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFinalHour.Location = new System.Drawing.Point(208, 397);
            this.labelFinalHour.Name = "labelFinalHour";
            this.labelFinalHour.Size = new System.Drawing.Size(59, 16);
            this.labelFinalHour.TabIndex = 43;
            this.labelFinalHour.Text = "Final hour";
            this.labelFinalHour.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(91, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cabinet";
            this.label1.Visible = false;
            // 
            // TermsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFinalHour);
            this.Controls.Add(this.labelStartHour);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxCabinets);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.numericUpDownEndHour);
            this.Controls.Add(this.numericUpDownStartHour);
            this.Controls.Add(this.dataGridViewTerms);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.labelCalendar);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.comboBoxCalendar);
            this.Controls.Add(this.comboBoxEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TermsManagementForm";
            this.Text = "TermsManagementForm";
            this.Load += new System.EventHandler(this.TermsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxCalendar;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView dataGridViewTerms;
        private System.Windows.Forms.NumericUpDown numericUpDownStartHour;
        private System.Windows.Forms.NumericUpDown numericUpDownEndHour;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ComboBox comboBoxCabinets;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cabinet;
        private System.Windows.Forms.Label labelStartHour;
        private System.Windows.Forms.Label labelFinalHour;
        private System.Windows.Forms.Label label1;
    }
}