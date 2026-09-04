using DetainedLicenseBusinessLayer;
using LicenseClassBusinessLayer;
using LocalDrivingLicenseApplicationBusinessLayer;
using PersonBusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer.Applications
{
    public partial class ApplicationCard : UserControl
    {

        private ApplicationBusinessLayer.Application _Application;

        public ApplicationBusinessLayer.Application Application
        {
            get { return _Application; }
            set {_Application = value; }
        }

        public ApplicationCard()
        {
            InitializeComponent();
        }

        private void _LoadApplicationCardInformation()
        {  
            if (_Application != null)
            {
                lblPersonID.Text = _Application.Person.Id.ToString();
                lblCreatedBy.Text = _Application.CreatedByUserId.ToString();
                lblApplicationDate.Text = _Application.CreationDate.ToString("MM/dd/yyyy");
                lblApplicationId.Text = _Application.Id.ToString();
                lblApplicationFees.Text = _Application.PaidFees.ToString();
                lblApplicationType.Text = _Application.ApplicationType.Title.ToString();
                lblApplicationStatus.Text = _Application.StatusToString;
            }

        }

        private void ApplicationCard_Load(object sender, EventArgs e)
        {
             if(Application != null) 
                _LoadApplicationCardInformation();
        }


        private void lklPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayPersonInfo(_Application.Person).ShowDialog();
        }
    }
}
