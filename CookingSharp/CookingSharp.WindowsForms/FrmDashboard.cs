using CookingSharp.WindowsForms.CategoriesControl;
using CookingSharp.WindowsForms.UserControls;

namespace CookingSharp.WindowsForms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnNavCategorias_Click(object sender, EventArgs e)
        {
            UC_Categories uc = new UC_Categories();
            addUserControl(uc);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            UC_AdminPanel uc = new UC_AdminPanel();
            addUserControl(uc);
        }
    }
}
