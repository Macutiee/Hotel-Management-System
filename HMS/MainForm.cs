using ReaLTaiizor.Forms;
using HMS.UI.Configs;

namespace HMS.UI
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            MaterialThemeConfig.Apply(this);
        }
    }
}
