using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DisplayPersonInfo : Form
    {
        public Person Person
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

        public DisplayPersonInfo(Person person)
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;
            personCard.Person = person;
        }
    }
}
