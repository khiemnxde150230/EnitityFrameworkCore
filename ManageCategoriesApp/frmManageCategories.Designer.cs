namespace ManageCategoriesApp
{
    partial class frmManageCategories
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
            lbCategoryID = new Label();
            lbCategoryName = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            dgvCategories = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(117, 45);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(84, 20);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "CategoryID";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new Point(117, 85);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(109, 20);
            lbCategoryName.TabIndex = 1;
            lbCategoryName.Text = "CategoryName";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(277, 38);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(288, 27);
            txtCategoryID.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(277, 78);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(288, 27);
            txtCategoryName.TabIndex = 3;
            // 
            // dgvCategories
            // 
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(117, 130);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 29;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(448, 233);
            dgvCategories.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(117, 388);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(115, 29);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(286, 388);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(450, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmManageCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvCategories);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(lbCategoryName);
            Controls.Add(lbCategoryID);
            Name = "frmManageCategories";
            Text = "Manage Categories";
            Load += frmManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategoryID;
        private Label lbCategoryName;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private DataGridView dgvCategories;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}