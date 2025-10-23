using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Milestone_Project
{
    public partial class CoffeeInventory : Form
    {
        public CoffeeInventory()
        {
            InitializeComponent();

            selectFileDialog.InitialDirectory = Application.StartupPath + @"Data";
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

        private void ReadInventory()
        {
            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                string txtFile = "";
                string dirLocation = "";

                txtFile = selectFileDialog.FileName;
                dirLocation = Path.GetFullPath(selectFileDialog.FileName);
                SelectFileLbl.Text = txtFile;
                SelectFileLbl.Visible = true;

                try
                {
                    string[] lines = File.ReadAllLines(txtFile);
                    DisplayInventory(lines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void DisplayInventory(string[] lines)
        {
            
            const int PadSpace = 20;
            string header1 = "Item", header2 = "Category", header3 = "Qty";
            string headerLine1 = "----", headerLine2 = "---------", headerLine3 = "---";


            InventoryLbl.Text = "";
            InventoryLbl.Text = string.Format("{0}{1}{2}\n", header1.PadRight(PadSpace), header2.PadRight(PadSpace), header3.PadRight(PadSpace));
            InventoryLbl.Text += string.Format("{0}{1}{2}\n", headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace));

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                foreach (string item in parts)
                {
                    InventoryLbl.Text += item.PadRight(PadSpace);
                }
                InventoryLbl.Text += "\n";
            }

            InventoryLbl.Visible = true;
        }
    }
}
