namespace DBMS_SQL_EmployeeSales
{
    partial class DBMS_SQL_EmployeeSales
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmployee = new DataGridView();
            dgvOrderList = new DataGridView();
            dgvEmployeeLabel = new Label();
            dgvOrderListLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AllowUserToDeleteRows = false;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(28, 39);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(750, 282);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellMouseUp += dgvEmployee_CellMouseUp;
            // 
            // dgvOrderList
            // 
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.AllowUserToDeleteRows = false;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(28, 350);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.Size = new Size(750, 366);
            dgvOrderList.TabIndex = 1;
            // 
            // dgvEmployeeLabel
            // 
            dgvEmployeeLabel.AutoSize = true;
            dgvEmployeeLabel.Location = new Point(28, 21);
            dgvEmployeeLabel.Name = "dgvEmployeeLabel";
            dgvEmployeeLabel.Size = new Size(64, 15);
            dgvEmployeeLabel.TabIndex = 2;
            dgvEmployeeLabel.Text = "Employees";
            // 
            // dgvOrderListLabel
            // 
            dgvOrderListLabel.AutoSize = true;
            dgvOrderListLabel.Location = new Point(28, 332);
            dgvOrderListLabel.Name = "dgvOrderListLabel";
            dgvOrderListLabel.Size = new Size(55, 15);
            dgvOrderListLabel.TabIndex = 3;
            dgvOrderListLabel.Text = "OrderList";
            // 
            // DBMS_SQL_EmployeeSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 742);
            Controls.Add(dgvOrderListLabel);
            Controls.Add(dgvEmployeeLabel);
            Controls.Add(dgvOrderList);
            Controls.Add(dgvEmployee);
            Name = "DBMS_SQL_EmployeeSales";
            Text = "DBMS SQL EmployeeSales";
            Load += DBMS_SQL_EmployeeSales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private DataGridView dgvOrderList;
        private Label dgvEmployeeLabel;
        private Label dgvOrderListLabel;
    }
}
