using SmartMonitor.UI.Extensions;
using System.Windows.Forms;
using MetroFramework;

namespace SmartMonitor.UI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.components.SetStyle(this);
            this.components.SetDefaultTheme(this, MetroThemeStyle.Dark);

        }
    }
}
