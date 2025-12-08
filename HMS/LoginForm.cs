using HMS.BLL.Services;
using HMS.UI.Configs;
using ReaLTaiizor.Forms;
using System.Runtime.InteropServices;

namespace HMS.UI
{
    public partial class LoginForm : MaterialForm
    {
        private readonly IUserService _userService;
        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            MaterialThemeConfig.Apply(this);
            _userService = userService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = _userService.Authenticate(username, password);

            if (user != null)
            {
                this.Hide();
                var mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;
    }
}
