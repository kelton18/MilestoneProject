namespace Milestone_Project
{
    partial class CoffeeInventory
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
            AddNewItemBtn = new Button();
            ViewEditBtn = new Button();
            label1 = new Label();
            ShowInventoryBtn = new Button();
            selectFileDialog = new OpenFileDialog();
            InventoryLbl = new Label();
            SelectFileLbl = new Label();
            RowSelectorComboBox = new ComboBox();
            SuspendLayout();
            // 
            // AddNewItemBtn
            // 
            AddNewItemBtn.Location = new Point(198, 408);
            AddNewItemBtn.Margin = new Padding(4, 3, 4, 3);
            AddNewItemBtn.Name = "AddNewItemBtn";
            AddNewItemBtn.Size = new Size(105, 38);
            AddNewItemBtn.TabIndex = 1;
            AddNewItemBtn.Text = "Add Item";
            AddNewItemBtn.UseVisualStyleBackColor = true;
            AddNewItemBtn.Click += this.AddNewItemBtn_Click;
            // 
            // ViewEditBtn
            // 
            ViewEditBtn.Location = new Point(506, 408);
            ViewEditBtn.Margin = new Padding(4, 3, 4, 3);
            ViewEditBtn.Name = "ViewEditBtn";
            ViewEditBtn.Size = new Size(133, 38);
            ViewEditBtn.TabIndex = 2;
            ViewEditBtn.Text = "View/Edit";
            ViewEditBtn.UseVisualStyleBackColor = true;
            ViewEditBtn.Click += this.ViewEditBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 3;
            label1.Text = "Coffee Shop Inventory";
            // 
            // ShowInventoryBtn
            // 
            ShowInventoryBtn.Location = new Point(347, 408);
            ShowInventoryBtn.Margin = new Padding(4, 3, 4, 3);
            ShowInventoryBtn.Name = "ShowInventoryBtn";
            ShowInventoryBtn.Size = new Size(105, 38);
            ShowInventoryBtn.TabIndex = 11;
            ShowInventoryBtn.Text = "Show Items";
            ShowInventoryBtn.UseVisualStyleBackColor = true;
            ShowInventoryBtn.Click += ShowInventoryBtn_Click;
            // 
            // selectFileDialog
            // 
            selectFileDialog.FileName = "openFileDialog1";
            // 
            // InventoryLbl
            // 
            InventoryLbl.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryLbl.Location = new Point(31, 97);
            InventoryLbl.Name = "InventoryLbl";
            InventoryLbl.Size = new Size(798, 289);
            InventoryLbl.TabIndex = 12;
            InventoryLbl.Text = "InventoryLbl";
            // 
            // SelectFileLbl
            // 
            SelectFileLbl.Location = new Point(31, 59);
            SelectFileLbl.Name = "SelectFileLbl";
            SelectFileLbl.Size = new Size(482, 25);
            SelectFileLbl.TabIndex = 13;
            SelectFileLbl.Text = "selectFileLbl";
            // 
            // RowSelectorComboBox
            // 
            RowSelectorComboBox.FormattingEnabled = true;
            RowSelectorComboBox.Location = new Point(29, 408);
            RowSelectorComboBox.Name = "RowSelectorComboBox";
            RowSelectorComboBox.Size = new Size(151, 36);
            RowSelectorComboBox.TabIndex = 14;
            // 
            // CoffeeInventory
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 473);
            Controls.Add(RowSelectorComboBox);
            Controls.Add(SelectFileLbl);
            Controls.Add(InventoryLbl);
            Controls.Add(ShowInventoryBtn);
            Controls.Add(label1);
            Controls.Add(ViewEditBtn);
            Controls.Add(AddNewItemBtn);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CoffeeInventory";
            Text = "Coffee shop inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddNewItemBtn;
        private Button ViewEditBtn;
        private Label label1;
        private Button ShowInventoryBtn;
        private OpenFileDialog selectFileDialog;
        private Label InventoryLbl;
        private Label SelectFileLbl;
        private ComboBox RowSelectorComboBox;
    }
}
