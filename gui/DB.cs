using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace gui
{
    class DB
    {
        string query;
        // Connection 
        public DB()
        {
        }
        public string DatabaseName;
        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }
        public bool IsConnect()
        {
            bool result = true;
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(DatabaseName))
                    result = false;
                string connstring = string.Format("Server=localhost; database={0}; UID=root; password=root ; charset=utf8;", DatabaseName);
                connection = new MySqlConnection(connstring);
                connection.Open();

                result = true;
            }

            return result;
        }
        public void Close()
        {
            connection.Close();
        }


        #region Volunteer_Form
        /// <summary>
        /// Request all volunteers
        /// </summary>
        /// <returns></returns>
        public List<Volunteer> GetAllVolunteers()
        {
            List<Volunteer> result = new List<Volunteer>();
            query = string.Format("SELECT * FROM volunteer");
            DataTable dt = Select(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    result.Add(new Volunteer(dr));
                }
            }
            return result;
        }
        public List<Volunteer> GetAllVolunteersWithTraining(Boolean is_pass_traning)
        {
            List<Volunteer> result = new List<Volunteer>();

            if (is_pass_traning)
                query = string.Format("SELECT * FROM volunteer where Volunteer_Practice = 2  "); //Pass Traning
            else
                query = string.Format("SELECT * FROM volunteer where Volunteer_Practice = 1  "); // didnt pass traning
            DataTable dt = Select(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    result.Add(new Volunteer(dr));
                }
            }
            return result;
        }
        public Boolean IsVolunteerExist(Volunteer volunteer)
        {
            Boolean result = false;
            query = string.Format("SELECT * FROM volunteer where Volunteer_Email = '{0}'", volunteer.Volunteer_Email); // didnt pass traning
            DataTable dt = Select(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var temp = dr;
                }
                if (dt.Rows.Count >= 1)
                    result = true;
            }
            return result;
        }
        /// <summary>
        /// Insert new Volunteer - ID must of null , and all infomation correct
        /// True - if update succeded 
        /// False - if update failed
        /// </summary>
        /// <param name="volunteer"></param>
        /// <returns></returns>
        public Boolean InsetNewVolunteer(Volunteer volunteer)
        {
            query = string.Format(@"INSERT INTO Volunteer 
                VALUES(null,{0},'{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}',{9});",
                volunteer.Volunteer_Practice, volunteer.Volunteer_First_Name, volunteer.Volunteer_Last_Name,
                volunteer.Volunteer_Email, volunteer.Volunteer_phone, volunteer.Volunteer_Occupation, volunteer.Volunteer_Reference,
                volunteer.Volunteer_Area_Activity, volunteer.Volunteer_Employer, volunteer.Volunteer_Number_Of_Activities); // didnt pass traning
            return Update(query);
        }  
        public Boolean UpdateVolunteerTraning(Volunteer volunteer , int new_status)
        {
            query =string.Format(@"UPDATE Volunteer SET Volunteer_Practice = {0} WHERE Volunteer_ID = {1};",new_status,volunteer.Volunteer_ID);
            return Update(query);
        }
        /// <summary>
        /// DELETE volunteer by volunter ID
        /// </summary>
        /// <param name="volunteer"></param>
        /// <returns></returns>
        public Boolean DeleteVolunteer(Volunteer volunteer)
        {
            query = string.Format(@"DELETE FROM Volunteer WHERE Volunteer_ID = {0};", volunteer.Volunteer_ID);
            return Update(query);
        }
        #endregion



        #region DB commands
        public DataTable Select(string query)
        {
            DataTable result = new DataTable();
            //Open connection
            if (this.IsConnect() == true)
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    result.Load(dataReader);

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    // this.Close();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }

            }
            return result;
        }
        public Boolean Update(string query)
        {
            Boolean result = false;
            //Open connection
            if (this.IsConnect() == true)
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a data reader and Execute the command
                    int affectedRows = cmd.ExecuteNonQuery();
                    return affectedRows > 0;
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }

            }
            return result;
        }

        #endregion

    }
}