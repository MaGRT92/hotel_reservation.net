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
    class Guests
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;


        /// <summary>
        /// Gets all guests from database
        /// </summary>
        /// <returns>datatable with rooms</returns>
        public DataTable GetAllGuests()
        {
            try
            {
                string query = "SELECT * FROM guests ORDER BY guest_lname";

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

        /// <summary>
        /// Gets one guest from database based on id
        /// </summary>
        /// <returns>datatable with guest/returns>
        public DataTable GetOneGuest(string guestID)
        {
            try
            {
                string query = "SELECT guest_fname, guest_lname, guest_pesel, guest_adress, guest_city, guest_phone FROM guests WHERE guest_ID='" + guestID + "' ";

                con = new MySqlConnection(ConnectionString.GetConnectionString());

                con.Open();
                DataTable dt = new DataTable();

                da = new MySqlDataAdapter(query, con);
                da.Fill(dt);

                da.Dispose();
                con.Close();

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
        }

        /// <summary>
        /// Check if guest exist in database 
        /// </summary>
        /// <param name="guestPesel"></param>
        /// <returns>True if guest exist in database otherwise false</returns>
        private bool ValidateGuest(string guestPesel)
        {
            string checkQuery = "SELECT guest_ID FROM guests WHERE guest_pesel=@guestPesel";
            con = new MySqlConnection(ConnectionString.GetConnectionString());

            cmd = new MySqlCommand(checkQuery, con);
            cmd.Parameters.AddWithValue("guestPesel", guestPesel);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cmd.Dispose();
                dr.Dispose();
                return true;
            }
            else
            {
                cmd.Dispose();
                dr.Dispose();
                return false;
            }
        }

        /// <summary>
        /// Insert new guest in to database
        /// </summary>
        /// <param name="guestFName"></param>
        /// <param name="guestLName"></param>
        /// <param name="guestAdress"></param>
        /// <param name="guestCity"></param>
        /// <param name="guestPhone"></param>
        /// <returns>True if added succesfully otherwise false</returns>
        public bool InsertGuest(string guestFName, string guestLName, string guestPesel, string guestAdress, string guestCity, string guestPhone)
        {
            if (guestFName == string.Empty || guestLName == string.Empty || guestPesel == string.Empty || guestAdress == string.Empty || guestCity == string.Empty || guestPhone == string.Empty)
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                try
                {
                    if (ValidateGuest(guestPesel))
                    {
                        MessageBox.Show("Taki gość już istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO guests (guest_fname, guest_lname, guest_pesel, guest_adress, guest_city, guest_phone)" +
                                             "VALUES (@guestFName, @guestLName,@guestPesel, @guestAdress, @guestCity, @guestPhone)";
                        MySqlCommand cmdInsert = new MySqlCommand(insertQuery, con);
                        cmdInsert.Parameters.AddWithValue("guestFName", guestFName);
                        cmdInsert.Parameters.AddWithValue("guestLName", guestLName);
                        cmdInsert.Parameters.AddWithValue("guestPesel", guestPesel);
                        cmdInsert.Parameters.AddWithValue("guestAdress", guestAdress);
                        cmdInsert.Parameters.AddWithValue("guestCity", guestCity);
                        cmdInsert.Parameters.AddWithValue("guestPhone", guestPhone);

                        cmdInsert.ExecuteNonQuery();
                        cmdInsert.Dispose();
                        con.Close();
                        MessageBox.Show("Gość został dodany!", "Dodano!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                    return false;
                }
            }
        }


        /// <summary>
        /// Update room in database
        /// </summary>
        /// <param name="guestID"></param>
        /// <param name="guestFName"></param>
        /// <param name="guestLName"></param>
        /// <param name="guestPesel"></param>
        /// <param name="guestAdress"></param>
        /// <param name="guestCity"></param>
        /// <param name="guestPhone"></param>
        /// <returns>True if update succesfully otherwise false</returns>
        public bool UpdateGuest(string guestID, string guestFName, string guestLName, string guestPesel, string guestAdress, string guestCity, string guestPhone)
        {
            if (guestFName == string.Empty || guestLName == string.Empty || guestPesel == string.Empty || guestAdress == string.Empty || guestCity == string.Empty || guestPhone == string.Empty)
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                try
                {
                    string updateQuery = "UPDATE guests SET guest_fname=@guestFName, guest_lname=@guestLName, guest_pesel=@guestPesel, guest_adress=@guestAdress, guest_city=@guestCity, guest_phone=@guestPhone WHERE guest_ID='" + guestID + "'";
                    MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, con);
                    cmdUpdate.Parameters.AddWithValue("guestFName", guestFName);
                    cmdUpdate.Parameters.AddWithValue("guestLName", guestLName);
                    cmdUpdate.Parameters.AddWithValue("guestPesel", guestPesel);
                    cmdUpdate.Parameters.AddWithValue("guestAdress", guestAdress);
                    cmdUpdate.Parameters.AddWithValue("guestCity", guestCity);
                    cmdUpdate.Parameters.AddWithValue("guestPhone", guestPhone);
                    con.Open();
                    cmdUpdate.ExecuteNonQuery();
                    cmdUpdate.Dispose();
                    con.Close();
                    MessageBox.Show("Zmiany zostały zapisane w bazie!", "Edytowano!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                    return false;
                }
            }
        }

        /// <summary>
        /// Delete selected guest in listview from database
        /// </summary>
        /// <param name="guestID"></param>
        public void DeleteRoom(string guestID)
        {
            try
            {
                string deleteQuery = "DELETE FROM guests WHERE guest_ID='" + guestID + "'";
                MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, con);
                con.Open();
                cmdDelete.ExecuteNonQuery();
                cmdDelete.Dispose();
                con.Close();
                MessageBox.Show("Gość został usunięty z bazy!", "Usunięto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

    }
}
