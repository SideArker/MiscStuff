using System.Windows.Forms;

namespace AutoClicker
{
    public partial class SelectKey : Form
    {
        public KeyEventArgs Key;
        public SelectKey()
        {
            InitializeComponent();
        }

        private void SelectKey_KeyDown(object sender, KeyEventArgs e)
        {
            Key = e;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
