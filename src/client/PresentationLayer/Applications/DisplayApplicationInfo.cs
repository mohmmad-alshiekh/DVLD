using System.Windows.Forms;

namespace PresentationLayer.Applications
{
    public partial class DisplayApplicationInfo : Form
    {
        public DisplayApplicationInfo(BusinessLayer.Application application)
        {
            InitializeComponent();
            titleBar.Form = this;
            titleBar.IsMainForm = false;

            applicationCard.Application = application;
        }
    }
}
