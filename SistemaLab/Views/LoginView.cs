using SistemaLab.Views;

namespace SistemaLab
{
    
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void closebtnLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            MenuView menu = new MenuView();

            menu.FormClosed += (s, args) => this.Close();
            menu.Show(this);
        }
    }
}
