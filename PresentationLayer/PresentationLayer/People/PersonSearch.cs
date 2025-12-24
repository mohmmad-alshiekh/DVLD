using System;
using System.Data;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class PersonSearch : UserControl
    {
        public event EventHandler btnNext_Clicked;

        public int PersonID
        {
            get => personCard.Person.Id;
        }

        public PersonBusinessLayer.Person Person
        {
            get => personCard.Person;
        }

        public PersonSearch()
        {
            InitializeComponent();   
        }

        private void _InitializeMainData()
        {
            SwitchPage(pnlNoData);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID",typeof(int));
            dataTable.Columns.Add("National No", typeof(string));
            search.Columns = dataTable.Columns;
            search.LoadComboBoxData();
            search.FilterSelectedIndex = 0;
            search.btnSearchFont = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
            search.cmbFilterFont = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
        }

        private void SwitchPage(Panel page)
        {
            if (pnlNoData != page)
                pnlNoData.Visible = false;

            if (pnlData != page)
                pnlData.Visible = false;

            page.Visible = true;
        }

        private void search_SearchClicked(object sender, EventArgs e)
        {
            if(search.FilterSelectedItem == "ID" && !string.IsNullOrEmpty(search.SearchText))
            {
                PersonBusinessLayer.Person person = PersonBusinessLayer.Person.GetPersonInfoByID(Convert.ToInt32(search.SearchText));
                if (person != null)
                {
                    personCard.Person = person;
                    personCard.LoadPersonCardInformation();
                    SwitchPage(pnlData);
                }
                else
                    SwitchPage(pnlNoData);
            }
            else if(!string.IsNullOrEmpty(search.SearchText))
            {
                PersonBusinessLayer.Person person = PersonBusinessLayer.Person.GetPersonInfoByNationalNo(search.SearchText);
                if (person != null)
                {
                    personCard.Person = person;
                    personCard.LoadPersonCardInformation();
                    SwitchPage(pnlData);
                }
                else
                    SwitchPage(pnlNoData);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SwitchPage(pnlNoData);
        }

        private void PersonSearch_Load(object sender, EventArgs e)
        {
            _InitializeMainData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext_Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            new Add_Update_Person().ShowDialog();
        }
    }
}
