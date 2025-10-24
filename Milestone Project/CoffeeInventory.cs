using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Milestone_Project
{


    public partial class CoffeeInventory : Form
    {
        private List<CoffeeItem> inventoryList = new List<CoffeeItem>();
        public CoffeeInventory()
        {
            InitializeComponent();

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
            ReadInventory();
        }

        private void AddNewItemBtn_Click(object sender, EventArgs e)
        {
            IncrementItemQty();
        }

        //FIXME
        private void ViewEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void IncrementItemQty()
        {
            if (RowSelectorComboBox.SelectedItem is CoffeeItem selectedItem)
            {
                selectedItem.Qty++;
                DisplayInventory();
            }
            else
            {
                MessageBox.Show("Please select an item first", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ReadInventory()
        {
            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                string txtFile = "";
                string dirLocation = "";
                dirLocation = Path.GetFullPath(selectFileDialog.FileName);


                txtFile = selectFileDialog.FileName;
                SelectFileLbl.Text = txtFile;
                SelectFileLbl.Visible = true;

       
                    string[] lines = File.ReadAllLines(txtFile);
                    inventoryList.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3 && int.TryParse(parts[2], out int qty))
                    {
                        inventoryList.Add(new CoffeeItem
                        {
                            Name = parts[0].Trim(),
                            Category = parts[1].Trim(),
                            Qty = qty
                        });
                    }
                }

                RowSelectorComboBox.DataSource = null;
                RowSelectorComboBox.DataSource = inventoryList;
                RowSelectorComboBox.DisplayMember = "Name";

                DisplayInventory();
  
            }

        }

        //private void SaveInventoryToFile(string filePath)
        //{
        //    var lines = inventoryList.Select(i => $"{i.Name},{i.Category},{i.Qty}");
        //    File.WriteAllLines(filePath, lines);
        //}

 
        private void DisplayInventory()
        {
            const int PadSpace = 20;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{"Item".PadRight(PadSpace)}{"Category".PadRight(PadSpace)}{"Qty".PadRight(PadSpace)}");
            sb.AppendLine($"{"----".PadRight(PadSpace)}{"---------".PadRight(PadSpace)}{"---".PadRight(PadSpace)}");

            foreach (var item in inventoryList)
            {
                sb.AppendLine($"{item.Name.PadRight(PadSpace)}{item.Category.PadRight(PadSpace)}{item.Qty.ToString().PadRight(PadSpace)}");
            }

            InventoryLbl.Text = sb.ToString();
            InventoryLbl.Visible = true;
        }
    }
}
