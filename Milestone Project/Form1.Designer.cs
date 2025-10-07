namespace Milestone_Project
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            EspressoBeansQtyLbl = new Label();
            MilkQtyLbl = new Label();
            CupsQtyLbl = new Label();
            ShowInventoryBtn = new Button();
            SuspendLayout();
            // 
            // AddNewItemBtn
            // 
            AddNewItemBtn.Location = new Point(72, 408);
            AddNewItemBtn.Margin = new Padding(4, 3, 4, 3);
            AddNewItemBtn.Name = "AddNewItemBtn";
            AddNewItemBtn.Size = new Size(105, 38);
            AddNewItemBtn.TabIndex = 1;
            AddNewItemBtn.Text = "Add Item";
            AddNewItemBtn.UseVisualStyleBackColor = true;
            // 
            // ViewEditBtn
            // 
            ViewEditBtn.Location = new Point(380, 408);
            ViewEditBtn.Margin = new Padding(4, 3, 4, 3);
            ViewEditBtn.Name = "ViewEditBtn";
            ViewEditBtn.Size = new Size(133, 38);
            ViewEditBtn.TabIndex = 2;
            ViewEditBtn.Text = "View/Edit";
            ViewEditBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 3;
            label1.Text = "Coffee Shop Inventory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(72, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 28);
            label2.TabIndex = 5;
            label2.Text = "Espresso Beans- Qty: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(72, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 6;
            label3.Text = "Milk- Qty: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(72, 148);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 7;
            label4.Text = "Cups- Qty: ";
            // 
            // EspressoBeansQtyLbl
            // 
            EspressoBeansQtyLbl.AutoSize = true;
            EspressoBeansQtyLbl.Location = new Point(278, 64);
            EspressoBeansQtyLbl.Margin = new Padding(4, 0, 4, 0);
            EspressoBeansQtyLbl.Name = "EspressoBeansQtyLbl";
            EspressoBeansQtyLbl.Size = new Size(72, 28);
            EspressoBeansQtyLbl.TabIndex = 8;
            EspressoBeansQtyLbl.Text = "5 bags";
            // 
            // MilkQtyLbl
            // 
            MilkQtyLbl.AutoSize = true;
            MilkQtyLbl.Location = new Point(184, 104);
            MilkQtyLbl.Margin = new Padding(4, 0, 4, 0);
            MilkQtyLbl.Name = "MilkQtyLbl";
            MilkQtyLbl.Size = new Size(96, 28);
            MilkQtyLbl.TabIndex = 9;
            MilkQtyLbl.Text = "2 Gallons";
            // 
            // CupsQtyLbl
            // 
            CupsQtyLbl.AutoSize = true;
            CupsQtyLbl.Location = new Point(184, 148);
            CupsQtyLbl.Margin = new Padding(4, 0, 4, 0);
            CupsQtyLbl.Name = "CupsQtyLbl";
            CupsQtyLbl.Size = new Size(42, 28);
            CupsQtyLbl.TabIndex = 10;
            CupsQtyLbl.Text = "100";
            // 
            // ShowInventoryBtn
            // 
            ShowInventoryBtn.Location = new Point(227, 408);
            ShowInventoryBtn.Margin = new Padding(4, 3, 4, 3);
            ShowInventoryBtn.Name = "ShowInventoryBtn";
            ShowInventoryBtn.Size = new Size(105, 38);
            ShowInventoryBtn.TabIndex = 11;
            ShowInventoryBtn.Text = "Show Items";
            ShowInventoryBtn.UseVisualStyleBackColor = true;
            ShowInventoryBtn.Click += ShowInventoryBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 473);
            Controls.Add(ShowInventoryBtn);
            Controls.Add(CupsQtyLbl);
            Controls.Add(MilkQtyLbl);
            Controls.Add(EspressoBeansQtyLbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ViewEditBtn);
            Controls.Add(AddNewItemBtn);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddNewItemBtn;
        private Button ViewEditBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label EspressoBeansQtyLbl;
        private Label MilkQtyLbl;
        private Label CupsQtyLbl;
        private Button ShowInventoryBtn;
    }
}
