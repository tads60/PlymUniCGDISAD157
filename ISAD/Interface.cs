using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ISAD
{
    public partial class Interface : Form
    {            
        string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

        DataTable allUserData = new DataTable();

        public Interface()
        {
            InitializeComponent();

            connectToDatabase();

            this.AcceptButton = this.btnSearch;
            comboType.SelectedIndex = 0;
            comboGender.SelectedIndex = 0;
        }

        public void connectToDatabase()
        {
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM `isad157_pscutter-cairns`.users";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                sqlDA.Fill(allUserData);

                dataGridUsers.DataSource = allUserData;
            }
        }

        private void DataGridUsers_SelectionChanged(object sender, EventArgs e)
        {
            lstFriends.Items.Clear();
            lstSchools.Items.Clear();
            lstWorkplaces.Items.Clear();

            if (dataGridUsers.CurrentRow != null)
            {
                WorkplaceDisplay();
                SchoolDisplay();
                FriendDisplay();
            }
        }
        private void FriendDisplay()
        {

            List<string> idList = new List<string>();

            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
                string friendsQuery = String.Format("SELECT FriendsID FROM `isad157_pscutter-cairns`.userfriends WHERE UserID = {0}", dataGridUsers.CurrentRow.Cells[0].Value.ToString());

                MySqlCommand friendcmd = new MySqlCommand(friendsQuery, connection);

                MySqlDataAdapter sqlDAfriends = new MySqlDataAdapter(friendcmd);
                DataTable friendsTable = new DataTable();
                sqlDAfriends.Fill(friendsTable);

                foreach (DataRow friendID in friendsTable.Rows)
                {
                    string id = friendID[0].ToString();
                    string firstname = "";
                    string lastname = "";

                    foreach (DataRow row in allUserData.Rows)
                    {
                        if (row[0] != null)
                        {
                            if (row[0].ToString().Equals(id))
                            {
                                DataRow friendData = allUserData.Rows[Convert.ToInt32(id) - 1];

                                firstname = friendData[1].ToString();
                                lastname = friendData[2].ToString();
                                break;
                            }
                        }
                    }

                    string friendDetails = String.Format("{0} {1}, ID: {2}", firstname, lastname, id);

                    if (!idList.Contains(id))
                    {
                        lstFriends.Items.Add(friendDetails);

                        idList.Add(id);
                    }
                }

                string friends2Query = String.Format("SELECT UserID FROM `isad157_pscutter-cairns`.userfriends WHERE FriendsID = {0}", dataGridUsers.CurrentRow.Cells[0].Value.ToString());

                MySqlCommand friendcmd2 = new MySqlCommand(friends2Query, connection);

                MySqlDataAdapter sqlDAfriends2 = new MySqlDataAdapter(friendcmd2);
                DataTable friendsTable2 = new DataTable();
                sqlDAfriends2.Fill(friendsTable2);

                foreach (DataRow friendID in friendsTable2.Rows)
                {
                    string id = friendID[0].ToString();
                    string firstname = "";
                    string lastname = "";

                    foreach (DataRow row in allUserData.Rows)
                    {
                        if (row[0] != null)
                        {
                            if (row[0].ToString().Equals(id))
                            {
                                DataRow friendData = allUserData.Rows[Convert.ToInt32(id) - 1];

                                firstname = friendData[1].ToString();
                                lastname = friendData[2].ToString();
                                break;
                            }
                        }
                    }

                    string friendDetails = String.Format("{0} {1}, ID: {2}", firstname, lastname, id);

                    if (!idList.Contains(id))
                    {
                        lstFriends.Items.Add(friendDetails);

                        idList.Add(id);
                    }
                }
            }
        }
        private void SchoolDisplay()
        {


            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
                string SchoolQuery = String.Format("SELECT SchoolID FROM `isad157_pscutter-cairns`.userschool WHERE UserID = {0}", dataGridUsers.CurrentRow.Cells[0].Value.ToString());

                MySqlCommand schoolcmd = new MySqlCommand(SchoolQuery, connection);

                MySqlDataAdapter sqlDAschool = new MySqlDataAdapter(schoolcmd);
                DataTable schoolTable = new DataTable();
                sqlDAschool.Fill(schoolTable);

                DataTable schoolNameTable = new DataTable();

                foreach (DataRow SchoolID in schoolTable.Rows)
                {
                    string id = SchoolID[0].ToString();

                    string nameQuery = String.Format("SELECT `School name` FROM `isad157_pscutter-cairns`.schools WHERE SchoolID = {0}", id);

                    MySqlCommand namecmd = new MySqlCommand(nameQuery, connection);

                    MySqlDataAdapter sqlDAworkplaceName = new MySqlDataAdapter(namecmd);
                    sqlDAworkplaceName.Fill(schoolNameTable);
                }

                foreach (DataRow SchoolName in schoolNameTable.Rows)
                {
                    string name = SchoolName[0].ToString();

                    lstSchools.Items.Add(name);
                }
            }
        }
        private void WorkplaceDisplay()
        {


            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
                string workplaceQuery = String.Format("SELECT WorkplaceID FROM `isad157_pscutter-cairns`.userworkplace WHERE UserID = {0}", dataGridUsers.CurrentRow.Cells[0].Value.ToString());

                MySqlCommand workplacecmd = new MySqlCommand(workplaceQuery, connection);

                MySqlDataAdapter sqlDAworkplace = new MySqlDataAdapter(workplacecmd);
                DataTable workplaceTable = new DataTable();
                sqlDAworkplace.Fill(workplaceTable);

                DataTable workplaceNameTable = new DataTable();

                foreach (DataRow workplaceID in workplaceTable.Rows)
                {
                    string id = workplaceID[0].ToString();

                    string nameQuery = String.Format("SELECT `Workplace name` FROM `isad157_pscutter-cairns`.workplaces WHERE WorkplaceID = {0}", id);

                    MySqlCommand namecmd = new MySqlCommand(nameQuery, connection);

                    MySqlDataAdapter sqlDAworkplaceName = new MySqlDataAdapter(namecmd);
                    sqlDAworkplaceName.Fill(workplaceNameTable);
                }

                foreach (DataRow workplaceName in workplaceNameTable.Rows)
                {
                    string name = workplaceName[0].ToString();

                    lstWorkplaces.Items.Add(name);
                }
            }
        }
        //Searching through users
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Searching via user_id
            if(comboType.SelectedItem.ToString() == "UserId")
            {
                //No text
                if (string.IsNullOrEmpty(txtSearchInput.Text))
                {
                    //Any Gender
                    if (comboGender.SelectedItem.ToString() == "Any")
                    {               (dataGridUsers.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    }
                    //Female/Male/Other
                    else
                    {
                        (dataGridUsers.DataSource as DataTable).DefaultView.RowFilter = string.Format("gender= '{0}'", comboGender.SelectedItem);
                    }
                }
                //Number specified
                else if (int.TryParse(txtSearchInput.Text, out int value))
                {
                    //Any Gender
                    if (comboGender.SelectedItem.ToString() == "Any")
                    {
                        (dataGridUsers.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}]= '{1}'", comboType.SelectedItem, value);
                    }
                    //Female/Male/Other
                    else
                    {
                        (dataGridUsers.DataSource as DataTable).DefaultView.RowFilter = string.Format("gender= '{0}' AND [{1}]= '{2}'", comboGender.SelectedItem, comboType.SelectedItem, value);
                    }
                }
                //No number specified
                else
                {
                    MessageBox.Show("Invalid Input: The input is not a valid integer.");
                }
            }
            //Searching via any other option
            else
            {
                //Any Gender
                if (comboGender.SelectedItem.ToString() == "Any")
                {
                    (dataGridUsers.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", comboType.SelectedItem, txtSearchInput.Text);
                }
                //Female/Male/Other
                else
                {
                    (dataGridUsers.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' AND gender= '{2}'", comboType.SelectedItem, txtSearchInput.Text, comboGender.SelectedItem);
                }
            }
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstFriends_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
