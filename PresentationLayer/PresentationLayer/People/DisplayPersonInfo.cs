using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DisplayPersonInfo : Form
    {
        public PersonBusinessLayer.Person Person
        {
            get => personCard.Person;
        }


        public DisplayPersonInfo(int _personID)
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;
            personCard.PersonID = _personID;

        }

        public DisplayPersonInfo(PersonBusinessLayer.Person person)
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;
            personCard.Person = person;
        }
    }
}
