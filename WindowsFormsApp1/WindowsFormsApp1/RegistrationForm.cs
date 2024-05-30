using System.Windows.Forms;

namespace ApplicantsWindowsFormsApp
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AuthorizeForm openForm = new AuthorizeForm();
            openForm.Show();
            Visible = false;
        }

        private void roundBtn1_Click(object sender, System.EventArgs e)
        {
            AuthorizeForm openForm = new AuthorizeForm();
            openForm.Show();
            Visible = false;
        }
    }
}
