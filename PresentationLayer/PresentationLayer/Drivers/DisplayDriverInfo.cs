using System.Windows.Forms;
using DriverBusinessLayer;

namespace PresentationLayer.Drivers
{
    public partial class DisplayDriverInfo : Form
    {
        public DisplayDriverInfo(Driver driver)
        {
            InitializeComponent();

            driverCard.Driver = driver;
            personCard.Person = driver.Person;

            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }

        public DisplayDriverInfo(int driverId)
        {
            InitializeComponent();

            Driver driver = Driver.GetDriverById(driverId);
            driverCard.Driver = driver;
            personCard.Person = driver.Person;

            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }
    }
}
