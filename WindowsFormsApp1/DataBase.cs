using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DataBase
    {

        MySqlConnection conn = new MySqlConnection("server = localhost; port = 3306; username = root; password =; database = production_company");

        public void openConn()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConn()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public MySqlConnection getConn()
        {
            return conn;
        }

        // Получение информации о партнерах partner_id, type_partner, company_name, legal_address, INN, director_name, phone, email, rating
        public DataTable GetPartnerData()
        {
            DataTable partnerData = new DataTable();
            try
            {
                conn.Open();

                string query = "SELECT partner_id, type_partner, company_name, legal_address, INN, director_name, phone, email, rating FROM Partners";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(partnerData);
            }
            finally
            {
                conn.Close();
            }
            return partnerData;
        }

    }
}
