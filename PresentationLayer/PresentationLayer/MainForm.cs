using ApplicationTypeBusinessLayer;
using DriverBusinessLayer;
using InternationalLicenseBusinessLayer;
using LicenseBusinessLayer;
using LicenseClassBusinessLayer;
using LocalDrivingLicenseApplicationBusinessLayer;
using PersonBusinessLayer;
using PresentationLayer.ApplicationTypes;
using PresentationLayer.Drivers;
using PresentationLayer.InternationalLicenses;
using PresentationLayer.Licenses;
using DetainedLicenseBusinessLayer;
using PresentationLayer.LocalDrivingLicenseApplications;
using PresentationLayer.TestAppointments;
using PresentationLayer.TestTypes;
using PresentationLayer.Users;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using TestTypeBusinessLayer;
using UserBusinessLayer;
using Utilities;
using static LicenseBusinessLayer.License;
using PresentationLayer.DetainedLicenses;
using PresentationLayer.LicenseClasses;


namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        enum enMainSidebarSize
        {
            Maximized = 0,
            Minimized = 1
        }



        // private Members :

        private enMainSidebarSize _MainSidebarSize = enMainSidebarSize.Maximized;

        private User _User;



        // Main Form :

        public MainForm(User user)
        {
            InitializeComponent();


            titleBar.IsMainForm = true;

            _User = user;
        }


        private void _InitializeMainData()
        {
            titleBar.Form = this;
            _MainSidebarSize = enMainSidebarSize.Maximized;

            /*
            When you start the application, 
            we will display the home page. 
            */
            _SwitchPage(pnlHome);
            _HandlePageChange();

            _MainSidebarSize = enMainSidebarSize.Maximized;

            dgvPeople.ContextMenuStrip = cmsPeople;
            _ApplyModernNeutralStyle(dgvPeople, Color.FromArgb(59, 66, 82), Color.FromArgb(94, 129, 172));


            dgvUsers.ContextMenuStrip = cmsUsers;
            _ApplyModernNeutralStyle(dgvUsers, Color.Green, Color.SeaGreen);

            dgvApplicationsType.ContextMenuStrip = cmsApplicationTypes;
            _ApplyModernNeutralStyle(dgvApplicationsType, Color.Green, Color.SeaGreen);

            dgvTestTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTestTypes.ContextMenuStrip = cmsTestType;
            _ApplyModernNeutralStyle(dgvTestTypes, Color.FromArgb(59, 66, 82), Color.FromArgb(94, 129, 172));


            dgvLocalDrivingLicenseApplications.ContextMenuStrip = cmsLocalDrivingLicenses;
            _ApplyModernNeutralStyle(dgvLocalDrivingLicenseApplications, Color.Green, Color.SeaGreen);

             dgvLicenseClasses.ContextMenuStrip = cmsLicenseClasses;
            _ApplyModernNeutralStyle(dgvLicenseClasses, Color.Green, Color.SeaGreen);


            // dgvLicenses.ContextMenuStrip = cmsLocalDrivingLicenses;
            _ApplyModernNeutralStyle(dgvLicenses, Color.FromArgb(59, 66, 82), Color.FromArgb(94, 129, 172) );


            dgvDrivers.ContextMenuStrip = cmsDrivers;
            _ApplyModernNeutralStyle(dgvDrivers, Color.FromArgb(59, 66, 82), Color.FromArgb(94, 129, 172));


            // dgvInternationalLicenseApplications.ContextMenuStrip = cmsInternationalLicenseApplications;
            _ApplyModernNeutralStyle(dgvInternationalLicenseApplications, Color.FromArgb(59, 66, 82), Color.FromArgb(94, 129, 172));
            dgvInternationalLicenses.ContextMenuStrip = cmsInternationalLicenses;   

            _ApplyModernNeutralStyle(dgvInternationalLicenses, Color.Green, Color.SeaGreen);
            _ApplyModernNeutralStyle(dgvDetainedLicenses, Color.FromArgb(59, 66, 82), Color.FromArgb(94, 129, 172));
            dgvDetainedLicenses.ContextMenuStrip = cmsDetainedLicenses;


            menuStrip.Renderer = new Renderer();

        }

        private void _LoadFormInformation()
        {
            // user information:

            lblUserID.Text = _User.Id.ToString();
            lblUserName.Text = _User.Name;

            if (_User.Person.ImagePath != null)
                try
                {
                    ptbUserImage.Image = System.Drawing.Image.FromFile(_User.Person.ImagePath);
                }
                catch(Exception ex)  
                {
                    MessageBox.Show(ex.Message, "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            _InitializeMainData();

            if (_User != null)
            {
                _LoadFormInformation();
            }
            else
            {
                Close();
            }
        }

        private DataTable _GetFilteredTable(string filterBy, string searchText,Func<DataTable> dataTable)
        {
            if (filterBy == null || filterBy.Length == 0 || searchText == null || searchText.Length == 0)
                return null;

            DataView dataView = dataTable().DefaultView;
            dataView.RowFilter = $"{filterBy}='{searchText}'";

            return dataView.ToTable();
        }

        private void _ApplyModernNeutralStyle(DataGridView dgv,Color headerBackColor,Color altRowBackColor)
        {
            Font font = new System.Drawing.Font("Simplified Arabic", 16.2F, System.Drawing.FontStyle.Bold);
            Color headerForeColor = Color.FromArgb(236, 239, 244);
            Color rowsDefaulBakColor = Color.FromArgb(81, 81, 81);
            Color rowsDefaulForeColor = Color.White;
            Color gridColor = Color.FromArgb(190, 195, 202);
            Color selectionBackColor = Color.Gray; 
            Color selectionForeColor = Color.FromArgb(250, 250, 250); 
            Color textColor = Color.FromArgb(46, 52, 64);            

            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = gridColor;


            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = altRowBackColor;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowBackColor;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = rowsDefaulForeColor;
            dgv.AlternatingRowsDefaultCellStyle.Font = font;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = selectionForeColor;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = selectionBackColor;


            dgv.DefaultCellStyle.ForeColor = textColor;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = selectionBackColor;
            dgv.DefaultCellStyle.SelectionForeColor = selectionForeColor;

            dgv.RowsDefaultCellStyle.BackColor = rowsDefaulBakColor;
            dgv.RowsDefaultCellStyle.Font = font;
            dgv.RowsDefaultCellStyle.ForeColor = rowsDefaulForeColor;
            dgv.RowsDefaultCellStyle.SelectionBackColor= selectionBackColor;
            dgv.RowsDefaultCellStyle.SelectionForeColor= selectionForeColor;


            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowTemplate.Height = 60;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.DefaultCellStyle.Padding = new Padding(5, 3, 5, 3);



            dgv.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
        }


        // Main Sidebar Buttons

        private void _SwitchPage(Panel page)
        {
            if (pnlHome != page)
                pnlHome.Visible = false;

            if (pnlPeople != page)
                pnlPeople.Visible = false;

            if(pnlUsers != page)
                pnlUsers.Visible = false;

            if (pnlDrivers != page)
                pnlDrivers.Visible = false;

            if(pnlApplications != page)
                pnlApplications.Visible = false;

            if(pnlLicenses != page)
                pnlLicenses.Visible = false;

            page.Visible = true;
        }

        private void _HandlePageChange()
        {
            if (pnlPeople.Visible != true)
            {
                dgvPeople.DataSource = null;
                dgvPeople.Rows.Clear();
                _LightGrayButton(btnPeople);
            }
            else
            {
                _GrayButton(btnPeople);
                DataTable dt = PersonBusinessLayer.Person.GetAllPeople();
                dgvPeople.DataSource = dt;

                if (searchPeople.Columns == null)
                {
                    searchPeople.Columns = dt.Columns;
                    searchPeople.LoadComboBoxData();
                    searchPeople.FilterSelectedIndex = 0;
                }
            }

            if (pnlUsers.Visible != true)
            {
                _LightGrayButton(btnUsers);
                dgvUsers.DataSource = null;
                dgvUsers.Rows.Clear();
            }
            else
            {
                _GrayButton(btnUsers);
                DataTable dt = UserBusinessLayer.User.GetAllUsers();
                dgvUsers.DataSource = dt;

                if (searchUsers.Columns == null)
                {
                    searchUsers.Columns = dt.Columns;
                    searchUsers.LoadComboBoxData();
                    searchUsers.FilterSelectedIndex = 0;
                }
            }
            if (pnlDrivers.Visible != true)
            {
                _LightGrayButton(btnDrivers);
                dgvDrivers.DataSource = null;
                dgvDrivers.Rows.Clear();
            }
            else
            {
                _GrayButton(btnDrivers);
                _LoadDrivers();
            }
            if (pnlApplications.Visible != true)
            {
                _LightGrayButton(btnApplications);
            }
            else
                _GrayButton(btnApplications);
            if (pnlLicenses.Visible != true)
            {
                _LightGrayButton(btnLicenses);
            }
            else
                _GrayButton(btnLicenses);
            if (pnlHome.Visible != true)
            {
                _LightGrayButton(btnHome);
            }
            else
            {
                _GrayButton(btnHome);
                _LoadHomePageInfo();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _SwitchPage(pnlHome);
            _HandlePageChange();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            _SwitchPage(pnlPeople);
            _HandlePageChange(); 
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            _SwitchPage(pnlUsers);
            _HandlePageChange();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            _SwitchPage(pnlDrivers);
            _HandlePageChange();
        }

        private void btnLicenses_Click(object sender, EventArgs e)
        {
            _SwitchPage(pnlLicenses);
            _HandlePageChange();

            /*
             When you open the Licenses page, which consists of more than one page, 
             you will start by displaying the Licenses List page. 
            */

            _SwitchLicensesPage(pnlLicensesList);
            _HandlesLicensesPageChange();
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            _SwitchPage(pnlApplications);
            _HandlePageChange();

            /*
             When you open the application page, which consists of more than one page, 
             you will start by displaying the Local Driving License Applications page. 
            */

            _SwitchApplicationsPage(pnlLocalDrivingLicenseApplications);
            _HandleApplicationsPageChange();
        }

        private void lklUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayUserInfo(_User).ShowDialog();
        }
       
        private void btnSize_Click(object sender, EventArgs e)
        {
            if(_MainSidebarSize == enMainSidebarSize.Maximized)
            {
                pnlMainSidebar.Width = 60;
                btnSize.Location = new Point(5, btnSize.Location.Y);
                lklUserInfo.Visible = false;
                ptbUserImage.Visible = false;
                _MainSidebarSize = enMainSidebarSize.Minimized;

                groupBox1.Size = new Size(50,btnSize.Height + 5);
                btnHome.Width = 50;
                btnHome.Text = "";
                btnPeople.Width = 50;
                btnPeople.Text = "";
                btnUsers.Width = 50;
                btnUsers.Text = "";
                btnDrivers .Width = 50;
                btnDrivers.Text = "";
                btnApplications .Width = 50;
                btnApplications.Text = "";
                btnLicenses .Width = 50;
                btnLicenses.Text = "";
            }
            else
            {
                pnlMainSidebar.Width = 214;
                btnSize.Location = new Point(159, btnSize.Location.Y);
                lklUserInfo.Visible = true;
                ptbUserImage.Visible = true;
                _MainSidebarSize = enMainSidebarSize.Maximized;

                groupBox1.Size = new Size(207,153);
                btnHome.Width = 207;
                btnHome.Text = "Home";
                btnPeople.Width = 207;
                btnPeople.Text = "People";
                btnUsers.Width = 207;
                btnUsers.Text = "Users";
                btnDrivers.Width = 207;
                btnDrivers.Text = "Drivers";
                btnApplications.Width = 207;
                btnApplications.Text = "Applications";
                btnLicenses.Width = 207;
                btnLicenses.Text = "Licenses";
            }
        }


        // Home:

        private void _LoadHomePageInfo()
        {
            try
            {
                lblNumberOfPeople.Text = Person.NumberOfPeople.ToString();
                lbllblNumberOfUsers.Text = User.NumberOfUsers.ToString();
                lblNumberOfDrivers.Text = Driver.NumberOfDrivers.ToString();

                int numberOfLocalLicenses = License.NumberOfLicenses;
                int numberOfInternationalLicenses = InternationalLicense.NumberOfInternationalLicenses;

                lblNumberOfLicenses.Text = (numberOfLocalLicenses + numberOfInternationalLicenses).ToString();
                lblNumberOfLocalDrivingLicenses.Text = numberOfLocalLicenses.ToString();
                lblNumberOfInternationalLicenses.Text = numberOfInternationalLicenses.ToString();
                lblDetainedLicsenses.Text = DetainedLicense.NumberOfDetainedLicenses.ToString();

                DataRowCollection dataRow = ApplicationBusinessLayer.Application.GetNumberOfApplications().Rows;
                
                int numberOfApplications = 0;
                
                foreach (DataRow row in dataRow)
                {
                    numberOfApplications += Convert.ToInt32(row[0]);
                }

                lbllblNumberOfApplications.Text = numberOfApplications.ToString();
                lblNumberOfLocalDrivingLicenseApplications.Text = dataRow[0][0].ToString();
                lblNumberOFReleaseDetainedLicsenseApplications.Text = dataRow[3][0].ToString();
                lblNumberOfInternationalLicenseApplications.Text = dataRow[4][0].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pnlHome_Resize(object sender, EventArgs e)
        {
            int margin = 25;              
            int horizontalSpacing = 20;   


            int topRowHeight = gbPeople.Height;
            int bottomRowHeight = gbApplications.Height;


            int topRowY = gbPeople.Top;
            int bottomRowY = gbApplications.Top;

            int availableWidth = pnlHome.ClientSize.Width - (margin * 2) - (horizontalSpacing * 2);


            int topBoxWidth = availableWidth / 3;
            int bottomBoxWidth = (availableWidth - horizontalSpacing) / 2; 

            gbPeople.SetBounds(margin, topRowY, topBoxWidth, topRowHeight);
            gbUsers.SetBounds(gbPeople.Right + horizontalSpacing, topRowY, topBoxWidth, topRowHeight);
            gbDrivers.SetBounds(gbUsers.Right + horizontalSpacing, topRowY, topBoxWidth, topRowHeight);

            gbApplications.SetBounds(margin, bottomRowY, bottomBoxWidth, bottomRowHeight);
            gbLicenses.SetBounds(gbApplications.Right + horizontalSpacing, bottomRowY, bottomBoxWidth, bottomRowHeight);
        }


        // People :

        private void _LoadFilteredPeople(string filterBy,string searchText)
        {
            DataTable dt = _GetFilteredTable(filterBy,searchText,Person.GetAllPeople);

            if(dt != null ) 
                dgvPeople.DataSource = dt;
        }

        private void _UpdatePersonRow(Person person, DataRow row)
        {
            if (person != null)
            {
                row["NationalNo"] = person.NationalNumber;
                row["FirstName"] = person.FirstName;
                row["SecondName"] = person.SecondName;
                row["LastName"] = person.LastName;
                row["Address"] = person.Address;
                row["Email"] = person.Email;
                row["DateOfBirth"] = person.DateOfBirth;
            }
        }

        private void _UpdatePersonInfo()
        {
            if (dgvPeople.RowCount == 0)
            {
                MessageBox.Show("There is no specific person to be update.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personID = -1;

            if (dgvPeople.CurrentRow.Cells["PersonID"].Value != null)
                personID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;

            if (personID != -1)
            {
                Person person = Person.GetPersonInfoByID(personID);
                Add_Update_Person form = new Add_Update_Person(person);
                form.ShowDialog();

                if (form.IsSaved)
                {
                    //  Update Person Info
                    DataTable data = dgvPeople.DataSource as DataTable;
                    _UpdatePersonRow(person, data.Rows[dgvPeople.CurrentRow.Index]);
                }
            }
        }

        private void _DeletePerson()
        {
            if (dgvPeople.RowCount == 0)
            {
                MessageBox.Show("There is no specific person to be deleted.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete it?", "DVLD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int personID = -1;

                if (dgvPeople.CurrentRow.Cells["PersonID"].Value != null)
                    personID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;

                try
                {
                    if (Person.DeletePerson(personID))
                    {
                        dgvPeople.Rows.Remove(dgvPeople.CurrentRow);
                        MessageBox.Show("The deletion process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"Deletion operation failed.\nThe person whose ID is {personID} does not exist.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex) , "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _AddNewPerson()
        {
            new Add_Update_Person().ShowDialog();
            dgvPeople.DataSource = Person.GetAllPeople();
        }

        private void _DisplayPersonInfo()
        {
            if (dgvPeople.RowCount == 0)
            {
                MessageBox.Show("There is no specific person to be display.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personID = -1;

            if (dgvPeople.CurrentRow.Cells["PersonID"].Value != null)
                personID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;

            DisplayPersonInfo form = new DisplayPersonInfo(personID);
            form.ShowDialog();

            // Update Person Info
            Person person = form.Person;
            DataTable data = dgvPeople.DataSource as DataTable;
            _UpdatePersonRow(person, data.Rows[dgvPeople.CurrentRow.Index]);
        }


        // Page People Buttons
        private void searchPeople_SearchClicked(object sender, EventArgs e)
        {
            _LoadFilteredPeople(searchPeople.FilterSelectedItem, searchPeople.SearchText);
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            _DeletePerson();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            _UpdatePersonInfo();
        }

        private void btnDisplayPerson_Click(object sender, EventArgs e)
        {
            _DisplayPersonInfo();
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this feature is currently under development and will be available soon.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this feature is currently under development and will be available soon.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdatePersonInfo();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DisplayPersonInfo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeletePerson();
        }



        // Users:
        private void _LoadFilteredUsers(string filterBy, string searchText)
        {
            DataTable dt = _GetFilteredTable(filterBy, searchText,User.GetAllUsers);
            
            if(dt != null)
                dgvUsers.DataSource = dt;
        }

        private void _UpdateUserRow(User user, DataRow row)
        {
            if (user != null)
            {
                row["UserName"] = user.Name;
                row["IsActive"] = user.isActive;
            }
        }

        private void _UpdateUserInfo()
        {
            if (dgvUsers.RowCount == 0)
            {
                MessageBox.Show("There is no specific user to be update.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userID = -1;

            if (dgvUsers.CurrentRow.Cells["UserID"].Value != null)
                userID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;

            Add_Update_User form = new Add_Update_User(userID);
            form.ShowDialog();

            if (form.IsSaved)
            {
                //  Update Person Info
                User user = form.User;
                DataTable data = dgvUsers.DataSource as DataTable;
                _UpdateUserRow(user, data.Rows[dgvUsers.CurrentRow.Index]);
            }
        }

        private void _AddNewUser()
        {
            new Add_Update_User().ShowDialog();
            dgvUsers.DataSource = User.GetAllUsers();
        }

        private void _DeleteUser()
        {
            if (dgvUsers.RowCount == 0)
            {
                MessageBox.Show("There is no specific User to be deleted.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete it?", "DVLD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int UserID = -1;
                if (dgvUsers.CurrentRow.Cells["UserID"].Value != null)
                    UserID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
                try
                {
                    if (User.DeleteUser(UserID))
                    {
                        dgvUsers.Rows.Remove(dgvUsers.CurrentRow);
                        MessageBox.Show("The deletion process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"Deletion operation failed.\nThe User whose ID is {UserID} does not exist ", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _DisplayUserInfo()
        {
            if (dgvUsers.RowCount == 0)
            {
                MessageBox.Show("There is no specific user to be display.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userID = -1;
            
            if (dgvUsers.CurrentRow.Cells["UserID"].Value != null)
                userID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;

            DisplayUserInfo form = new DisplayUserInfo(userID);
            form.ShowDialog();

            //  Update Person Info
            User user = form.User;
            DataTable data = dgvUsers.DataSource as DataTable;
            _UpdateUserRow(user, data.Rows[dgvUsers.CurrentRow.Index]);
        }



        // page Users Buttons

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            _AddNewUser();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            _UpdateUserInfo();
        }

        private void searchUsers_SearchClicked(object sender, EventArgs e)
        {
            _LoadFilteredUsers(searchUsers.FilterSelectedItem,searchUsers.SearchText);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            _DeleteUser();
        }

        private void btnDisplayUser_Click(object sender, EventArgs e)
        {
            _DisplayUserInfo();
        }

        private void deleteUsertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteUser();
        }

        private void displayUsertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DisplayUserInfo();
        }

        private void updateUsertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateUserInfo();
        }


        // Drivers :

        private void _LoadDrivers()
        {
            try
            {
                int currentIndex = dgvDrivers.CurrentRow?.Index ?? -1;

                DataTable dt = Driver.GetAllDrivers();
                dgvDrivers.DataSource = dt;
                
                if(searchDrivers.Columns == null)
                {
                    searchDrivers.Columns = dt.Columns;
                    searchDrivers.LoadComboBoxData();
                    searchDrivers.FilterSelectedIndex = 0;
                }

                if (currentIndex >= 0 && currentIndex < dgvDrivers.Rows.Count)
                {
                    dgvDrivers.ClearSelection();
                    dgvDrivers.Rows[currentIndex].Selected = true;
                    dgvDrivers.CurrentCell = dgvDrivers.Rows[currentIndex].Cells[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex),"DVLD",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void _LoadFilteredDrivers(string filterBy, string searchText)
        {
            DataTable dt = _GetFilteredTable(filterBy, searchText,Driver.GetAllDrivers);

            if (dt != null)
                dgvDrivers.DataSource = dt;
        }

        private void _DisplayDriverInfo()
        {
            if (dgvDrivers.RowCount == 0)
            {
                MessageBox.Show("There is no specific driver to be display.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int driverID = -1;

            if (dgvDrivers.CurrentRow.Cells["DriverID"].Value != null)
                driverID = (int)dgvDrivers.CurrentRow.Cells["DriverID"].Value;

            new DisplayDriverInfo(driverID).ShowDialog();
            _LoadDrivers();
        }


        // page Drivers Buttons :

        private void searchDrivers_SearchClicked(object sender, EventArgs e)
        {
            _LoadDrivers();
            _LoadFilteredDrivers(searchDrivers.FilterSelectedItem, searchDrivers.SearchText);
        }

        private void displayDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DisplayDriverInfo();
        }


        // StripMenu  Buttons
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddNewUser();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }

        private void displayUserINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DisplayUserInfo(_User).ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
        }

        private void modifyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModifyUserPassword(_User).ShowDialog();
        }

        private void applicationsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SwitchPage(pnlApplications);
            _HandlePageChange();

            btnApplicationsType.Focus();
            _SwitchApplicationsPage(pnlApplicationsType);
            _HandleApplicationsPageChange();
        }

        private void testTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SwitchPage(pnlApplications);
            _HandlePageChange();

            btnTestType.Focus();
            _SwitchApplicationsPage(pnlTestType);
            _HandleApplicationsPageChange();
        }
   
        private void addLocalDrivingLicenseApplicationFormNewAddLocaLDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddNewLocalDrivingLicenseApplication();
        }


        // Effects on buttons:

        private void _WhiteButton(Button button)
        {
            button.BackColor = System.Drawing.Color.White;
            button.ForeColor = System.Drawing.Color.Gray;
        }

        private void _GrayButton(Button button)
        {
            button.BackColor = System.Drawing.Color.Gray;
            button.ForeColor = System.Drawing.Color.White;
        }

        private void _LightGrayButton(Button button)
        {
            button.BackColor = Color.FromArgb(64, 64, 64);
            button.ForeColor = System.Drawing.Color.White;
        }



        // panel Applications :

        private void _SwitchApplicationsPage(Panel page)
        {
            if(pnlLocalDrivingLicenseApplications != page)
                pnlLocalDrivingLicenseApplications.Visible = false;

            if (pnlApplicationsType != page)
                pnlApplicationsType.Visible = false;

            if (pnlTestType != page)
                pnlTestType.Visible = false;

            if(pnlInternationalLicenseApplications != page)
                pnlInternationalLicenseApplications.Visible = false;

            page.Visible = true;
        }

        private void _HandleApplicationsPageChange()
        {
            if(pnlApplicationsType.Visible == false)
            {
                _GrayButton(btnApplicationsType);
                dgvApplicationsType.DataSource = null;
                dgvApplicationsType.Rows.Clear();
            }
            else
            {
                _WhiteButton(btnApplicationsType);
                dgvApplicationsType.DataSource = ApplicationTypeBusinessLayer.ApplicationType.GetAllApplicationTypes();
            }
            if(pnlTestType.Visible == false)
            {
                _GrayButton(btnTestType);
                dgvTestTypes.DataSource = null;
                dgvTestTypes.Rows.Clear();
            }
            else
            {
                _WhiteButton(btnTestType);
                dgvTestTypes.DataSource = TestType.GetAllTestTypes();
            }
            if(pnlLocalDrivingLicenseApplications.Visible == false)
            {
                _GrayButton(btnLocalDrivingLicenseApplications);

                dgvLocalDrivingLicenseApplications.DataSource = null;
                dgvLocalDrivingLicenseApplications.Rows.Clear();
            }
            else
            {
                _WhiteButton(btnLocalDrivingLicenseApplications);
                _LoadLocalDrivingLicenseApplications();
            }
            if (pnlInternationalLicenseApplications.Visible == false)
            {
                _GrayButton(btnInternationalLicenseApplications);

                dgvInternationalLicenseApplications.DataSource = null;
                dgvInternationalLicenseApplications.Rows.Clear();
            }
            else
            {
                _WhiteButton(btnInternationalLicenseApplications);
                _LoadInternationalLicenseApplications();
            }
        }

        private void btnApplicationsList_Click(object sender, EventArgs e)
        {
            _SwitchApplicationsPage(pnlLocalDrivingLicenseApplications);
            _HandleApplicationsPageChange();
        }

        private void btnApplicationsType_Click(object sender, EventArgs e)
        {
            _SwitchApplicationsPage(pnlApplicationsType);
            _HandleApplicationsPageChange();
        }

        private void btnTestType_Click(object sender, EventArgs e)
        {
            _SwitchApplicationsPage(pnlTestType);
            _HandleApplicationsPageChange();
        }

        private void btnInternationalLicensesApplications_Click(object sender, EventArgs e)
        {
            _SwitchApplicationsPage(pnlInternationalLicenseApplications);
            _HandleApplicationsPageChange();
        }



        // Application Type :

        private void _UpdateApplicationTypeRow(ApplicationType  applicationType, DataRow row)
        {
            if (applicationType != null)
            {
                row["ApplicationTypeTitle"] = applicationType.Title;
                row["ApplicationFees"] = applicationType.Fees;
            }
        }

        private void _UpdateApplicationTypeInfo()
        {
            if (dgvApplicationsType.RowCount == 0)
            {
                MessageBox.Show("There is no specific Application Type to be update.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int applicationTypeId = -1;

            if (dgvApplicationsType.CurrentRow.Cells["ApplicationTypeID"].Value != null)
                applicationTypeId = (int)dgvApplicationsType.CurrentRow.Cells["ApplicationTypeID"].Value;

            Update_ApplicationType form = new Update_ApplicationType(applicationTypeId);
            form.ShowDialog();

            if (form.IsSaved)
            {
                //  Update Person Info
                ApplicationType applicationType = form.ApplicationType;
                DataTable data = dgvApplicationsType.DataSource as DataTable;
                _UpdateApplicationTypeRow(applicationType, data.Rows[dgvApplicationsType.CurrentRow.Index]);
            }
        }

        private void updateAppTypestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateApplicationTypeInfo();
        }


        // Test Type :
        private void _UpdateTestTypeRow(TestType testType, DataRow row)
        {
            if (testType != null)
            {
                row["TestTypeTitle"] = testType.Title;
                row["TestTypeFees"] = testType.Fees;
                row["TestTypeDescription"] = testType.Description;
            }
        }

        private void _UpdateTestTypeInfo()
        {
            if (dgvTestTypes.RowCount == 0)
            {
                MessageBox.Show("There is no specific Test Type to be update.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int testTypeId = -1;

            if (dgvTestTypes.CurrentRow.Cells["TestTypeID"].Value != null)
                testTypeId = (int)dgvTestTypes.CurrentRow.Cells["TestTypeID"].Value;

            Update_TestType form = new Update_TestType(testTypeId);
            form.ShowDialog();

            if (form.IsSaved)
            {
                //  Update Test Type Info
                TestType testType = form.TestType;
                DataTable data = dgvTestTypes.DataSource as DataTable;
                _UpdateTestTypeRow(testType, data.Rows[dgvTestTypes.CurrentRow.Index]);
            }
        }

        private void updateTestTypestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateTestTypeInfo();
        }


        // Local Driving License Applications

        private void _LoadFilteredLocalDrivingLicenseApplications(string filterBy, string searchText)
        {
            DataTable dt = _GetFilteredTable(filterBy, searchText,LocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications);
            
            if(dt != null)
                dgvLocalDrivingLicenseApplications.DataSource = dt;
        }

        private void _LoadLocalDrivingLicenseApplications()
        {
            int currentIndex = dgvLocalDrivingLicenseApplications.CurrentRow?.Index ?? -1;

            DataTable dt = LocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgvLocalDrivingLicenseApplications.DataSource = dt;

            if (searchLocalDrivingLicenseApplications.Columns == null)
            {
                searchLocalDrivingLicenseApplications.Columns = dt.Columns;
                searchLocalDrivingLicenseApplications.LoadComboBoxData();
                searchLocalDrivingLicenseApplications.FilterSelectedIndex = 0;
            }


            if (currentIndex >= 0 && currentIndex < dgvLocalDrivingLicenseApplications.Rows.Count)
            {
                dgvLocalDrivingLicenseApplications.ClearSelection();
                dgvLocalDrivingLicenseApplications.Rows[currentIndex].Selected = true;
                dgvLocalDrivingLicenseApplications.CurrentCell = dgvLocalDrivingLicenseApplications.Rows[currentIndex].Cells[0];
            }
        }

        private void _AddNewLocalDrivingLicenseApplication()
        {
            Add_LocalDrivingLicenseApplication form = new Add_LocalDrivingLicenseApplication(_User.Id);
            form.ShowDialog();

            if (form.IsSaved)
                _LoadLocalDrivingLicenseApplications();
        }

        private void _DisplayLocalDrivinglicenseApplication()
        {
            if (dgvLocalDrivingLicenseApplications.RowCount == 0)
            {
                MessageBox.Show("There is no specific Local Driving license Application to Display.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int localDrivingLicenseId = -1;
            if(dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value != null)
                localDrivingLicenseId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            LocalDrivingLicenseApplication localDrivingLicense = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationById(localDrivingLicenseId);
            new DisplayLocalDrivingLicenseApplicationInfo(localDrivingLicense).ShowDialog();
        }

        private void _CancelledLocalDrivingLicenseApplication()
        {
            if (dgvLocalDrivingLicenseApplications.RowCount == 0)
            {
                MessageBox.Show("There is no specific Local Driving license Application to be Cancelled.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to cancelled it?", "DVLD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int localDrivingLicenseId = -1;

                if (dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value != null)
                    localDrivingLicenseId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

                if (localDrivingLicenseId != -1)
                {
                    ApplicationBusinessLayer.Application application = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationById(localDrivingLicenseId).Application;

                    if (application.Status != ApplicationBusinessLayer.Application.enStatus.Completed)
                        application.Status = ApplicationBusinessLayer.Application.enStatus.Cancelled;
                    else
                        return;
                    try
                    {
                        if (!application.Save())
                            MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        _LoadLocalDrivingLicenseApplications();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void _DeleteLocalDrivingLicenseApplication()
        {
            if (dgvLocalDrivingLicenseApplications.RowCount == 0)
            {
                MessageBox.Show("There is no specific Local Driving license Application to be Delete.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete it?", "DVLD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int localDrivingLicenseId = -1;

                if (dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value != null)
                    localDrivingLicenseId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

                if (localDrivingLicenseId != -1)
                {

                    int applicationId = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationById(localDrivingLicenseId).Application.Id;

                    try
                    {
                        if (!LocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication(localDrivingLicenseId))
                        {
                            MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            if (ApplicationBusinessLayer.Application.DeleteApplication(applicationId))
                                MessageBox.Show("The deletion process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        _LoadLocalDrivingLicenseApplications();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex) , "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void _TakeTest(TestType testType)
        {
            if (dgvLocalDrivingLicenseApplications.RowCount == 0)
            {
                MessageBox.Show("There is no specific Local Driving license Application.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int localDrivingLicenseId = -1;

            if (dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value != null)
            {
                localDrivingLicenseId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            }
            if (localDrivingLicenseId != -1)
            {
                LocalDrivingLicenseApplication localDrivingLicense = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationById(localDrivingLicenseId);
                new TestAppointment_Form(localDrivingLicense, testType , _User.Id).ShowDialog();

                _LoadLocalDrivingLicenseApplications();
            }
        }

        private void _IssueLicense()
        {
            if (dgvLocalDrivingLicenseApplications.RowCount == 0)
            {
                MessageBox.Show("There is no specific Local Driving license Application.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int localDrivingLicenseId = -1;
            string personNationalNo = "";

            if (dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value != null)
            {
                localDrivingLicenseId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            }
            if(dgvLocalDrivingLicenseApplications.CurrentRow.Cells["NationalNo"].Value != null)
            {
                personNationalNo = (string)dgvLocalDrivingLicenseApplications.CurrentRow.Cells["NationalNo"].Value;
            }
            if (localDrivingLicenseId != -1 && !string.IsNullOrEmpty(personNationalNo))
            {
                LocalDrivingLicenseApplication localDrivingLicense = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationById(localDrivingLicenseId);
                new IssueLicense_Form(localDrivingLicense.Application,localDrivingLicense.LicenseClass,personNationalNo,_User.Id).ShowDialog();
                _LoadLocalDrivingLicenseApplications();
            }
        }

        private bool _ShowAllPersonDrivingLocalLicensesHistory()
        {
            if (dgvLocalDrivingLicenseApplications.RowCount == 0)
            {
                MessageBox.Show("There is no specific Local Driving license Application.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string personNationalNo = "";
            int driverId = -1;


            if (dgvLocalDrivingLicenseApplications.CurrentRow.Cells["NationalNo"].Value != null)
            {
                personNationalNo = (string)dgvLocalDrivingLicenseApplications.CurrentRow.Cells["NationalNo"].Value;
            }
            if (!string.IsNullOrEmpty(personNationalNo))
            {
                Person person = Person.GetPersonInfoByNationalNo(personNationalNo);

                Driver driver = Driver.GetDriverByPersonId(person.Id);

                if (driver != null)
                {
                    driverId = driver.Id;
                }
            }

            if (driverId != -1)
            {
                _SwitchPage(pnlLicenses);
                _HandlePageChange();

                _SwitchLicensesPage(pnlLicensesList);
                _HandlesLicensesPageChange();



                _LoadFilteredLicenses("DriverID", $"{driverId}");
                return true;
            }

            return false;
        }

        private void _ShowPersonActiveDrivingLocalLicensesHistory()
        {
            if (_ShowAllPersonDrivingLocalLicensesHistory())
            {
                DataView dataView = ((DataTable)dgvLicenses.DataSource).DefaultView;
                dataView.RowFilter = $"IsActive =True";
                dgvLicenses.DataSource = dataView;
            }
        }

        private void _ShowDriverInfo()
        {
            if (dgvLocalDrivingLicenseApplications.RowCount == 0)
            {
                MessageBox.Show("There is no specific Local Driving license Application.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string personNationalNo = "";
            Driver driver = null;


            if (dgvLocalDrivingLicenseApplications.CurrentRow.Cells["NationalNo"].Value != null)
            {
                personNationalNo = (string)dgvLocalDrivingLicenseApplications.CurrentRow.Cells["NationalNo"].Value;
            }
            if (!string.IsNullOrEmpty(personNationalNo))
            {
                Person person = Person.GetPersonInfoByNationalNo(personNationalNo);

                driver = Driver.GetDriverByPersonId(person.Id);
            }
            if (driver != null)
            {
               new DisplayDriverInfo(driver).ShowDialog();
            }
        }


        // Local Driving License Applications Buttons
        private void searchLocalDrivingLicenses_SearchClicked(object sender, EventArgs e)
        {
            _LoadFilteredLocalDrivingLicenseApplications(searchLocalDrivingLicenseApplications.FilterSelectedItem, searchLocalDrivingLicenseApplications.SearchText);
        }

        private void btnAddNewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            _AddNewLocalDrivingLicenseApplication();
        }

        private void cmsLocalDrivingLicenses_VisibleChanged(object sender, EventArgs e)
        {
            if (cmsLocalDrivingLicenses.Visible == true)
            {
                int passedTestCount = Convert.ToInt32(dgvLocalDrivingLicenseApplications.CurrentRow.Cells["PassedTestCount"].Value);
                string applicationStatus = (string) dgvLocalDrivingLicenseApplications.CurrentRow.Cells["Status"].Value;

                visionTestToolStripMenuItem.Enabled = false;
                writtenTestToolStripMenuItem.Enabled = false;
                practicalTestToolStripMenuItem.Enabled = false;
                cancelledLocalDrivingLicenseToolStripMenuItem.Enabled = true;
                deleteLocalDrivingLicenseToolStripMenuItem.Enabled = true;
                viewTestsToolStripMenuItem.Enabled = true;
                issueLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showDriverInformationToolStripMenuItem.Enabled = false;


                if(applicationStatus == "Cancelled")
                {
                    cancelledLocalDrivingLicenseToolStripMenuItem.Enabled = false;
                    viewTestsToolStripMenuItem.Enabled = false;
                }
                else if (applicationStatus == "Completed")
                {
                    showDriverInformationToolStripMenuItem.Enabled = true;
                    viewTestsToolStripMenuItem.Enabled = false;
                    cancelledLocalDrivingLicenseToolStripMenuItem.Enabled = false;
                    deleteLocalDrivingLicenseToolStripMenuItem.Enabled = false;
                }
                else if (passedTestCount == 0)
                    visionTestToolStripMenuItem.Enabled = true;
                else if (passedTestCount == 1)
                    writtenTestToolStripMenuItem.Enabled = true;
                else if (passedTestCount == 2)
                    practicalTestToolStripMenuItem.Enabled = true;
                else if (passedTestCount == 3)
                {
                    cancelledLocalDrivingLicenseToolStripMenuItem.Enabled = false;
                    deleteLocalDrivingLicenseToolStripMenuItem.Enabled = false;
                    viewTestsToolStripMenuItem.Enabled = false;

                    if (applicationStatus == "New")
                        issueLicenseFirstTimeToolStripMenuItem.Enabled = true;
                }
                
            }
        }

        private void displayLocalDrivingLicenseInfoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _DisplayLocalDrivinglicenseApplication();
        }

        private void cancelledLocalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CancelledLocalDrivingLicenseApplication();
        }

        private void deleteLocalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteLocalDrivingLicenseApplication();
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestType testType = TestType.GetTestTypeById(1);
            _TakeTest(testType);
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestType testType = TestType.GetTestTypeById(2);
            _TakeTest(testType);
        }

        private void practicalTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestType testType = TestType.GetTestTypeById(3);
            _TakeTest(testType);
        }

        private void issueLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _IssueLicense();
        }

        private void allLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowAllPersonDrivingLocalLicensesHistory();
        }

        private void activeLicensesOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowPersonActiveDrivingLocalLicensesHistory();
        }

        private void showDriverInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowDriverInfo();
        }

        // International License Applications :

        public void _LoadInternationalLicenseApplications()
        {
            try
            {
                int currentIndex = dgvInternationalLicenseApplications.CurrentRow?.Index ?? -1;

                DataTable dt = ApplicationBusinessLayer.Application.GetApplicationsByTypeId(6);
                dgvInternationalLicenseApplications.DataSource = dt;


                if (currentIndex >= 0 && currentIndex < dgvInternationalLicenseApplications.Rows.Count)
                {
                    dgvInternationalLicenseApplications.ClearSelection();
                    dgvInternationalLicenseApplications.Rows[currentIndex].Selected = true;
                    dgvInternationalLicenseApplications.CurrentCell = dgvInternationalLicenseApplications.Rows[currentIndex].Cells[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // panel Licenses :

        private void _SwitchLicensesPage(Panel page)
        {
            if (pnlLicenseClasses != page)
                pnlLicenseClasses.Visible = false;

            if (pnlLicensesList != page)
                pnlLicensesList.Visible = false;

            if (pnlInternationalLicenses != page)
                pnlInternationalLicenses.Visible = false;

            if (pnlDetainedLicenses != page)
                pnlDetainedLicenses.Visible = false;

            page.Visible = true;
        }

        private void _HandlesLicensesPageChange()
        {
            if (pnlLicensesList.Visible == false)
            {
                _GrayButton(btnLicensesList);
                dgvLicenses.DataSource = null;
                dgvLicenses.Rows.Clear();
            }
            else
            {
                _WhiteButton(btnLicensesList);
                _LoadLicenses();
            }
            if (pnlLicenseClasses.Visible == false)
            {
                _GrayButton(btnLicenseClasses);
                dgvLicenseClasses.DataSource = null;
                dgvLicenseClasses.Rows.Clear();
            }
            else
            {
                _WhiteButton(btnLicenseClasses);
                _LoadLicenseClasses();
            }
            if (pnlDetainedLicenses.Visible == false)
            {
                _GrayButton(btnDetainedLicenses);
                dgvDetainedLicenses.DataSource = null;
                dgvDetainedLicenses.Rows.Clear();
            }
            else
            {
                _WhiteButton(btnDetainedLicenses);
                _LoadDetainedLicenses();
            }
            if (pnlInternationalLicenses.Visible == false)
            {
                _GrayButton(btnInternationalLicenses);
                dgvInternationalLicenses.DataSource = null;
                dgvInternationalLicenses.Rows.Clear();
            }
            else
            {
                _WhiteButton(btnInternationalLicenses);
                _LoadInternationalLicenses();
            }
        }

        private void btnLicensesList_Click(object sender, EventArgs e)
        {
            _SwitchLicensesPage(pnlLicensesList);
            _HandlesLicensesPageChange();
        }

        private void btnInternationalLicenses_Click(object sender, EventArgs e)
        {
            _SwitchLicensesPage(pnlInternationalLicenses);
            _HandlesLicensesPageChange();
        }

        private void btnDetainedLicenses_Click(object sender, EventArgs e)
        {
            _SwitchLicensesPage(pnlDetainedLicenses);
            _HandlesLicensesPageChange();
        }

        private void btnLicenseClasses_Click(object sender, EventArgs e)
        {
            _SwitchLicensesPage(pnlLicenseClasses);
            _HandlesLicensesPageChange();
        }


        // License Classes :

        private void _LoadLicenseClasses()
        {
            try
            {
                int currentIndex = dgvLicenseClasses.CurrentRow?.Index ?? -1;

                DataTable dt = LicenseClass.GetAllLicenseClasses();
                dgvLicenseClasses.DataSource = dt;

                if (currentIndex >= 0 && currentIndex < dgvLicenseClasses.Rows.Count)
                {
                    dgvLicenseClasses.ClearSelection();
                    dgvLicenseClasses.Rows[currentIndex].Selected = true;
                    dgvLicenseClasses.CurrentCell = dgvLicenseClasses.Rows[currentIndex].Cells[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _UpdateLicenseClasse()
        {
            if (dgvLicenseClasses.RowCount == 0)
            {
                MessageBox.Show("There is no specific license Class to be update.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseClassId = -1;

            if (dgvLicenseClasses.CurrentRow.Cells["LicenseClassID"].Value != null)
                licenseClassId = (int)dgvLicenseClasses.CurrentRow.Cells["LicenseClassID"].Value;

            if (licenseClassId != -1) 
            {
                LicenseClass licenseClass = LicenseClass.GetLicenseClasseById(licenseClassId);
                new Update_LicenseClass(licenseClass).ShowDialog();
                _LoadLicenseClasses();
            }
        }

        private void updateLicenseClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateLicenseClasse();
        }


        // local Licenses List:

        private void _LoadLicenses()
        {
            try
            {
                int currentIndex = dgvLicenses.CurrentRow?.Index ?? -1;

                DataTable dt = License.GetAllLicenses();
                dgvLicenses.DataSource = dt;

                if (searchLicenses.Columns == null)
                {
                    searchLicenses.Columns = dt.Columns;
                    searchLicenses.LoadComboBoxData();
                    searchLicenses.FilterSelectedIndex = 0;
                }

                if (currentIndex >= 0 && currentIndex < dgvLicenses.Rows.Count)
                {
                    dgvLicenses.ClearSelection();
                    dgvLicenses.Rows[currentIndex].Selected = true;
                    dgvLicenses.CurrentCell = dgvLicenses.Rows[currentIndex].Cells[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _LoadFilteredLicenses(string filterBy, string searchText)
        {
            DataTable dt = _GetFilteredTable(filterBy, searchText,License.GetAllLicenses);

            if (dt != null) 
                dgvLicenses.DataSource = dt;
        }

        private void _DrivingLicenseService(License.enIssueReason issueReason)
        {
            if (dgvLicenses.RowCount == 0)
            {
                MessageBox.Show($"There is no specific license to be {License.IssueReasonToString(issueReason)}.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseId = -1;
            int driverId = -1;

            if (dgvLicenses.CurrentRow.Cells["LicenseID"].Value != null)
            {
                licenseId = (int)dgvLicenses.CurrentRow.Cells["LicenseID"].Value;
            }
            if (dgvLicenses.CurrentRow.Cells["DriverId"].Value != null)
            {
                driverId = (int)dgvLicenses.CurrentRow.Cells["DriverId"].Value;
            }
            if (licenseId != -1 && driverId != -1)
            {
                License license = License.GetLicenseById(licenseId);
                Driver driver = Driver.GetDriverById(driverId);

                if (license != null)
                {
                    if (!license.IsActive)
                    {
                        MessageBox.Show($"Your current driver's license is inactive. You cannot {License.IssueReasonToString(issueReason)} it.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (license.IsValidLicense && issueReason == License.enIssueReason.Renew)
                    {
                        MessageBox.Show($"Your current driver's license is valid. You cannot {License.IssueReasonToString(issueReason)} it.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"No driver's license found for ID {licenseId}.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (driver == null)
                {
                    MessageBox.Show($"No driver found for ID {licenseId}.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                new IssueLicense_Form(driver, license, issueReason,_User.Id).ShowDialog();
                _LoadLicenses();
            }
        }

        private void _AddNewInternationalLicense()
        {
            if (dgvLicenses.RowCount == 0)
            {
                MessageBox.Show($"There is no specific license to be International License.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseId = -1;
            int driverId = -1;

            if (dgvLicenses.CurrentRow.Cells["LicenseID"].Value != null)
            {
                licenseId = (int)dgvLicenses.CurrentRow.Cells["LicenseID"].Value;
            }
            if (dgvLicenses.CurrentRow.Cells["DriverId"].Value != null)
            {
                driverId = (int)dgvLicenses.CurrentRow.Cells["DriverId"].Value;
            }
            if (licenseId != -1 && driverId != -1)
            {
                License license = License.GetLicenseById(licenseId);
                Driver driver = Driver.GetDriverById(driverId);

                if (license != null)
                {
                    if (!license.IsActive)
                    {
                        MessageBox.Show("Your current driver's license is inactive.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!license.IsValidLicense)
                    {
                        MessageBox.Show("Your current driver's license is not valid.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(License.IsLocalLicenseLinkedToInternational(licenseId))
                    {
                        MessageBox.Show("You already have an international license.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"No driver's license found for ID {licenseId}.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (driver == null)
                {
                    MessageBox.Show($"No driver found for ID {licenseId}.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                new IssueInternationalLicense_Form(license , driver , _User.Id).ShowDialog();
                _LoadLicenses();
            }
        }

        private void _DetainedLicense()
        {
            if (dgvLicenses.RowCount == 0)
            {
                MessageBox.Show($"There is no specific license to be Detained.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseId = -1;

            if (dgvLicenses.CurrentRow.Cells["LicenseID"].Value != null)
            {
                licenseId = (int)dgvLicenses.CurrentRow.Cells["LicenseID"].Value;
            }
            if (licenseId != -1)
            {
                if (License.IsDetainedLicenseL(licenseId))
                {
                    MessageBox.Show($"Driving license already Detained.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                License license = License.GetLicenseById(licenseId);

                if (license != null )
                {
                    new DetainedLicense_Form(license, _User.Id).ShowDialog();
                }
            }
        }

        private void _DisplayLicensesInfo()
        {
            if (dgvLicenses.RowCount == 0)
            {
                MessageBox.Show($"There is no specific license to be Detained.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseId = -1;

            if (dgvLicenses.CurrentRow.Cells["LicenseID"].Value != null)
            {
                licenseId = (int)dgvLicenses.CurrentRow.Cells["LicenseID"].Value;
            }
            if (licenseId != -1)
            {
               
                License license = License.GetLicenseById(licenseId);

                if (license != null)
                {
                    new DisplayLicenseInfo(license).ShowDialog();
                }
            }
        }

        // Licenses List Buttons

        private void searchLicenses_SearchClicked(object sender, EventArgs e)
        {
            _LoadFilteredLicenses(searchLicenses.FilterSelectedItem, searchLicenses.SearchText);
        }

        private void btnRenewDrivingLicenseService_Click(object sender, EventArgs e)
        {
            _DrivingLicenseService(License.enIssueReason.Renew);
        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {
            Point screenPoint = btnReplacement.PointToScreen(Point.Empty);


            cmsReplacement.Show(
                screenPoint.X,
                screenPoint.Y - cmsReplacement.Height
            );

        }

        private void replacementForALostDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DrivingLicenseService(License.enIssueReason.ReplacementForLost);
        }

        private void replacementForADamagedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DrivingLicenseService(License.enIssueReason.ReplacementForDamaged);
        }

        private void btnNewInternationalLicense_Click(object sender, EventArgs e)
        {
            _AddNewInternationalLicense();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            _DetainedLicense();
        }

        private void btnDisplayLicensesInfo_Click(object sender, EventArgs e)
        {
            _DisplayLicensesInfo();
        }

        // International Licenses :

        private void _LoadInternationalLicenses()
        {
            try
            {
                int currentIndex = dgvInternationalLicenses.CurrentRow?.Index ?? -1;

                DataTable dt = InternationalLicense.GetAllInternationalLicenses();
                dgvInternationalLicenses.DataSource = dt;

                if (searchInternationalLicenses.Columns == null)
                {
                    searchInternationalLicenses.Columns = dt.Columns;
                    searchInternationalLicenses.LoadComboBoxData();
                    searchInternationalLicenses.FilterSelectedIndex = 0;
                }

                if (currentIndex >= 0 && currentIndex < dgvInternationalLicenses.Rows.Count)
                {
                    dgvInternationalLicenses.ClearSelection();
                    dgvInternationalLicenses.Rows[currentIndex].Selected = true;
                    dgvInternationalLicenses.CurrentCell = dgvInternationalLicenses.Rows[currentIndex].Cells[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _LoadFilteredInternationalLicenses(string filterBy, string searchText)
        {
            DataTable dt = _GetFilteredTable(filterBy, searchText, InternationalLicense.GetAllInternationalLicenses);

            if (dt != null)
                dgvInternationalLicenses.DataSource = dt;
        }

        private void _DisplayInternationalLicense()
        {
            if (dgvInternationalLicenses.RowCount == 0)
            {
                MessageBox.Show($"There is no specific International Licenses to be Display.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int internationalLicenseId = -1;

            if (dgvInternationalLicenses.CurrentRow.Cells["InternationalLicenseID"].Value != null)
            {
                internationalLicenseId = (int)dgvInternationalLicenses.CurrentRow.Cells["InternationalLicenseID"].Value;
            }
            if (internationalLicenseId != -1)
            {

                InternationalLicense internationalLicense = InternationalLicense.GetInternationalLicenseById(internationalLicenseId);

                if (internationalLicense != null)
                {
                    new DisplayInternationalLicensesInfo(internationalLicense).ShowDialog();
                }
            }
        }

        private void searchInternationalLicenses_SearchClicked(object sender, EventArgs e)
        {
            _LoadInternationalLicenses();
            _LoadFilteredInternationalLicenses(searchInternationalLicenses.FilterSelectedItem, searchInternationalLicenses.SearchText);
        }

        private void displayInternationalLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DisplayInternationalLicense();
        }

        // Detained Licenses

        private void _LoadDetainedLicenses()
        {
            try
            {
                int currentIndex = dgvDetainedLicenses.CurrentRow?.Index ?? -1;

                DataTable dt = DetainedLicense.GetAllDetainedLicenses();
                dgvDetainedLicenses.DataSource = dt;

                if (searchDetainedLicenses.Columns == null)
                {
                    searchDetainedLicenses.Columns = dt.Columns;
                    searchDetainedLicenses.LoadComboBoxData();
                    searchDetainedLicenses.FilterSelectedIndex = 0;
                }

                if (currentIndex >= 0 && currentIndex < dgvDetainedLicenses.Rows.Count)
                {
                    dgvDetainedLicenses.ClearSelection();
                    dgvDetainedLicenses.Rows[currentIndex].Selected = true;
                    dgvDetainedLicenses.CurrentCell = dgvDetainedLicenses.Rows[currentIndex].Cells[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _LoadFilteredDetainedLicenses(string filterBy, string searchText)
        {
            DataTable dt = _GetFilteredTable(filterBy, searchText, DetainedLicense.GetAllDetainedLicenses);

            if (dt != null)
                dgvDetainedLicenses.DataSource = dt;
        }

        private void _ReleasedLicense()
        {
            if (dgvDetainedLicenses.RowCount == 0)
            {
                MessageBox.Show($"There is no specific license to be Released.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int detainedLicenseId = -1;

            if (dgvDetainedLicenses.CurrentRow.Cells["DetainID"].Value != null)
            {
                detainedLicenseId = (int)dgvDetainedLicenses.CurrentRow.Cells["DetainID"].Value;
            }
            if (detainedLicenseId != -1)
            {
                DetainedLicense detainedLicense = DetainedLicense.GetDetainedLicenseById(detainedLicenseId);

                if (detainedLicense.IsReleased)
                {
                    MessageBox.Show("The driving license has already been released.","DVLD",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (detainedLicense != null)
                {
                    new ReleasedLicense_Form(detainedLicense, _User.Id).ShowDialog();
                    _LoadDetainedLicenses();
                }
            }
        }

        private void cmsDetainedLicenses_VisibleChanged(object sender, EventArgs e)
        {
            if (cmsDetainedLicenses.Visible == true)
            {
                string IsReleased = dgvDetainedLicenses.CurrentRow.Cells["IsReleased"].Value as string ?? string.Empty;

                releasedToolStripMenuItem.Enabled = IsReleased != "True";
            }
        }

        private void searchDetainedLicenses_SearchClicked(object sender, EventArgs e)
        {
            _LoadFilteredDetainedLicenses(searchDetainedLicenses.FilterSelectedItem, searchDetainedLicenses.SearchText);
        }

        private void releasedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ReleasedLicense();
        }



        // Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object cell = dgvLocalDrivingLicenseApplications.CurrentCell.Value as object ?? null;

            if (cell != null)
            {
                Clipboard.SetText(cell.ToString());
                MessageBox.Show("Copy done","DVLD");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        
    }

}
