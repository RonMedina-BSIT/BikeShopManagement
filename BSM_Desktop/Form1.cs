using BSM_BusinessDataLogic;
using BSM_DataService;
namespace BSM_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtbPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var password = txtbPassword.Text;
           

            var result = BSM_BusinessDataLogic.BSMService.ValidateAdmin(password);
            if (result)
            {
                MessageBox.Show("Login successful!");
                ShowBike_Form showBike_Form = new ShowBike_Form();
                showBike_Form.Show();

                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
