
namespace formsClinicProject
{
    partial class ReviewEmployeesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.btnReviewEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vEVERYONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic4DataSet = new formsClinicProject.clinic4DataSet();
            this.clinic4DataSet1 = new formsClinicProject.clinic4DataSet1();
            this.clinic4DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeroleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_roleTableAdapter = new formsClinicProject.clinic4DataSet1TableAdapters.Employee_roleTableAdapter();
            this.v_EVERYONETableAdapter = new formsClinicProject.clinic4DataSetTableAdapters.v_EVERYONETableAdapter();
            this.dataGridViewListOfEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vEVERYONEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeroleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDoctor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteDoctor.FlatAppearance.BorderSize = 0;
            this.btnDeleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDoctor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteDoctor.Location = new System.Drawing.Point(613, 376);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(158, 33);
            this.btnDeleteDoctor.TabIndex = 1;
            this.btnDeleteDoctor.Text = "Deactivate employee";
            this.btnDeleteDoctor.UseVisualStyleBackColor = false;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // btnReviewEmployee
            // 
            this.btnReviewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReviewEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReviewEmployee.FlatAppearance.BorderSize = 0;
            this.btnReviewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewEmployee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReviewEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReviewEmployee.Location = new System.Drawing.Point(456, 376);
            this.btnReviewEmployee.Name = "btnReviewEmployee";
            this.btnReviewEmployee.Size = new System.Drawing.Size(141, 33);
            this.btnReviewEmployee.TabIndex = 2;
            this.btnReviewEmployee.Text = "Review employee";
            this.btnReviewEmployee.UseVisualStyleBackColor = false;
            this.btnReviewEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Review employees";
            // 
            // vEVERYONEBindingSource
            // 
            this.vEVERYONEBindingSource.DataMember = "v_EVERYONE";
            this.vEVERYONEBindingSource.DataSource = this.clinic4DataSet;
            // 
            // clinic4DataSet
            // 
            this.clinic4DataSet.DataSetName = "clinic4DataSet";
            this.clinic4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinic4DataSet1
            // 
            this.clinic4DataSet1.DataSetName = "clinic4DataSet1";
            this.clinic4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinic4DataSet1BindingSource
            // 
            this.clinic4DataSet1BindingSource.DataSource = this.clinic4DataSet1;
            this.clinic4DataSet1BindingSource.Position = 0;
            // 
            // employeeroleBindingSource
            // 
            this.employeeroleBindingSource.DataMember = "Employee_role";
            this.employeeroleBindingSource.DataSource = this.clinic4DataSet1BindingSource;
            // 
            // employee_roleTableAdapter
            // 
            this.employee_roleTableAdapter.ClearBeforeFill = true;
            // 
            // v_EVERYONETableAdapter
            // 
            this.v_EVERYONETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewListOfEmployees
            // 
            this.dataGridViewListOfEmployees.AllowUserToAddRows = false;
            this.dataGridViewListOfEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListOfEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListOfEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListOfEmployees.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListOfEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListOfEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListOfEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListOfEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListOfEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListOfEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListOfEmployees.EnableHeadersVisualStyles = false;
            this.dataGridViewListOfEmployees.Location = new System.Drawing.Point(46, 94);
            this.dataGridViewListOfEmployees.Name = "dataGridViewListOfEmployees";
            this.dataGridViewListOfEmployees.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListOfEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewListOfEmployees.RowHeadersVisible = false;
            this.dataGridViewListOfEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListOfEmployees.Size = new System.Drawing.Size(693, 276);
            this.dataGridViewListOfEmployees.TabIndex = 5;
            this.dataGridViewListOfEmployees.SelectionChanged += new System.EventHandler(this.dataGridViewListOfEmployees_SelectionChanged);
            // 
            // ReviewEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewListOfEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReviewEmployee);
            this.Controls.Add(this.btnDeleteDoctor);
            this.Name = "ReviewEmployeesForm";
            this.Text = "ReviewEmployeesForm";
            this.Load += new System.EventHandler(this.ReviewEmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vEVERYONEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic4DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeroleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.Button btnReviewEmployee;
        private System.Windows.Forms.Label label1;
        private clinic4DataSet clinic4DataSet;
        private System.Windows.Forms.BindingSource vEVERYONEBindingSource;
        private clinic4DataSetTableAdapters.v_EVERYONETableAdapter v_EVERYONETableAdapter;
        private clinic4DataSet1 clinic4DataSet1;
        private System.Windows.Forms.BindingSource clinic4DataSet1BindingSource;
        private System.Windows.Forms.BindingSource employeeroleBindingSource;
        private clinic4DataSet1TableAdapters.Employee_roleTableAdapter employee_roleTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewListOfEmployees;
    }
}