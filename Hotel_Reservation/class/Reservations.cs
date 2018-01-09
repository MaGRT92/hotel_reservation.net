using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Reservation
{
    class Reservations
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;

        /// <summary>
        /// Gets reservations from database
        /// </summary>
        /// <returns>datatable with reservations</returns>
        public DataTable GetReservations(string query)
        {
            try
            {
                con = new MySqlConnection(ConnectionString.GetConnectionString());

                con.Open();
                DataTable dt = new DataTable();

                da = new MySqlDataAdapter(query, con);
                da.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
        }


    }
}
