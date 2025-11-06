using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using InventoryManager.Library;

namespace InventoryManager
{
    public partial class CoffeeInventory : Form
    {

        private InventoryManager.Library.InventoryManager inventoryManager = new InventoryManager.Library.InventoryManager();
        private string currentFilePath = "";




        public CoffeeInventory()
        {
            InitializeComponent();


            //"C:\Users\Kelton\source\repos\Milestone Project"
            selectFileDialog.InitialDirectory = Application.StartupPath + @"\Data";
            selectFileDialog.Title = "Browse Txt Files";
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|";
            selectFileDialog.FilterIndex = 1;
            selectFileDialog.RestoreDirectory = true;

            InventoryLbl.Visible = false;
            SelectFileLbl.Visible = false;
        }

        private void ShowInventoryBtn_Click(object sender, EventArgs e)
        {
            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = selectFileDialog.FileName;
                SelectFileLbl.Text = currentFilePath;
                SelectFileLbl.Visible = true;

                try
                {
                    inventoryManager.ReadInventory(currentFilePath);

                    RowSelectorComboBox.DataSource = null;
                    RowSelectorComboBox.DataSource = inventoryManager.GetInventory();
                    RowSelectorComboBox.DisplayMember = "Name";

                    DisplayInventory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddNewItemBtn_Click(object sender, EventArgs e)
        {
            if (RowSelectorComboBox.SelectedItem is CoffeeItem selectedItem)
            {
                try
                {
                    inventoryManager.IncrementItemQty(selectedItem.Name);
                    DisplayInventory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select an item first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //FIXME
        private void ViewEditBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit feature not implemented yet.");

        }

        private void DisplayInventory()
        {
            const int PadSpace = 20;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{"Item".PadRight(PadSpace)}{"Category".PadRight(PadSpace)}{"Qty".PadRight(PadSpace)}");
            sb.AppendLine($"{"----".PadRight(PadSpace)}{"---------".PadRight(PadSpace)}{"---".PadRight(PadSpace)}");

            foreach (var item in inventoryManager.GetInventory())
            {
                sb.AppendLine($"{item.Name.PadRight(PadSpace)}{item.Category.PadRight(PadSpace)}{item.Qty.ToString().PadRight(PadSpace)}");
            }

            InventoryLbl.Text = sb.ToString();
            InventoryLbl.Visible = true;
        }






    }
}
