namespace Milestone_Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EspressoBeansQtyLbl.Visible = false;
            MilkQtyLbl.Visible = false;
            CupsQtyLbl.Visible = false;
        }

        private void ShowInventoryBtn_Click(object sender, EventArgs e)
        {
            EspressoBeansQtyLbl.Visible = true;
            MilkQtyLbl.Visible = true;
            CupsQtyLbl.Visible = true;
        }
    }
}
