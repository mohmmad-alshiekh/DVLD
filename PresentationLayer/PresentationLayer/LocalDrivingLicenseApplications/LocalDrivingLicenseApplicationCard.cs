using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalDrivingLicenseApplicationBusinessLayer;

namespace PresentationLayer.LocalDrivingLicenseApplications
{
    public partial class LocalDrivingLicenseApplicationCard : UserControl
    {
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;


        public LocalDrivingLicenseApplication LocalDrivingLicenseApplication { get => _localDrivingLicenseApplication; set => _localDrivingLicenseApplication = value; }




        private void _LoadApplicationCardInformation()
        {
            if (_localDrivingLicenseApplication != null)
            {
                lblLocalDrivingLicenseApplicationId.Text = _localDrivingLicenseApplication.Id.ToString();
                lblClassName.Text = _localDrivingLicenseApplication.LicenseClass.Name;
            }
        }

        public LocalDrivingLicenseApplicationCard()
        {
            InitializeComponent();
        }

        private void LocalDrivingLicenseApplicationCard_Load(object sender, EventArgs e)
        {
            _LoadApplicationCardInformation();
        }
    }
}
