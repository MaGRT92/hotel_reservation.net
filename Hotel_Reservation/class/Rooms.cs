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
    class Rooms
    {

        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;


        /// <summary>
        /// Gets rooms from database identified by query
        /// </summary>
        /// <returns>datatable with rooms</returns>
        public DataTable GetRooms()
        {
            try
            {
                string query = "SELECT room_ID AS 'ID', room_number AS 'Numer Pokoju', room_floor AS 'Numer Piętra', room_seats AS 'Ilość Miejsc' FROM rooms ORDER BY room_number";

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
        /// Gets one room from database based on id
        /// </summary>
        /// <returns>datatable with room</returns>
        public DataTable GetOneRoom(string roomID)
        {
            try
            {
                string query = "SELECT room_number, room_floor, room_seats FROM rooms WHERE room_ID ='" + roomID + "' ";

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
        /// Check if room exist in database 
        /// </summary>
        /// <param name="room_number"></param>
        /// <returns>True if room exist in database otherwise false</returns>
        private bool ValidateRoom(string room_number)
        {
            string checkQuery = "SELECT room_number FROM rooms WHERE room_number=@roomNumber";
            con = new MySqlConnection(ConnectionString.GetConnectionString());

            cmd = new MySqlCommand(checkQuery, con);
            cmd.Parameters.AddWithValue("roomNumber", room_number);
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
        /// Insert new room in to database
        /// </summary>
        /// <param name="room_number"></param>
        /// <param name="room_floor"></param>
        /// <param name="room_seats"></param>
        /// <returns>True if added succesfully otherwise false</returns>
        public bool InsertRoom(string room_number, string room_floor, string room_seats)
        {
            if (room_number == string.Empty || room_floor == string.Empty || room_seats == string.Empty)
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                try
                {
                    if (ValidateRoom(room_number))
                    {
                        MessageBox.Show("Taki numer pokoju już istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO rooms (room_number, room_floor, room_seats) VALUES (@roomNumber, @roomFloor, @roomSeats)";
                        MySqlCommand cmdInsert = new MySqlCommand(insertQuery, con);
                        cmdInsert.Parameters.AddWithValue("roomNumber", room_number);
                        cmdInsert.Parameters.AddWithValue("roomFloor", room_floor);
                        cmdInsert.Parameters.AddWithValue("roomSeats", room_seats);

                        cmdInsert.ExecuteNonQuery();
                        cmdInsert.Dispose();
                        con.Close();
                        MessageBox.Show("Pokój został dodany!", "Dodano!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /// <param name="room_number"></param>
        /// <param name="room_floor"></param>
        /// <param name="room_seats"></param>
        /// <returns>True if update succesfully otherwise false</returns>
        public bool UpdateRoom(string roomID, string room_number, string room_floor, string room_seats)
        {
            if (room_number == string.Empty || room_floor == string.Empty || room_seats == string.Empty)
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                try
                {
                    string updateQuery = "UPDATE rooms SET room_number=@roomNumber, room_floor=@roomFloor, room_seats=@roomSeats WHERE room_ID='" + roomID + "'";
                    MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, con);
                    cmdUpdate.Parameters.AddWithValue("roomNumber", room_number);
                    cmdUpdate.Parameters.AddWithValue("roomFloor", room_floor);
                    cmdUpdate.Parameters.AddWithValue("roomSeats", room_seats);
                    con.Open();
                    cmdUpdate.ExecuteNonQuery();
                    cmdUpdate.Dispose();
                    con.Close();
                    MessageBox.Show("Pokój edytowany dodany!", "Edytowano!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /// Delete selected room in listview from database
        /// </summary>
        /// <param name="roomID"></param>
        public void DeleteRoom(string roomID)
        {
            try
            {
                string deleteQuery = "DELETE FROM rooms WHERE room_ID='" + roomID + "'";
                MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, con);
                con.Open();
                cmdDelete.ExecuteNonQuery();
                cmdDelete.Dispose();
                con.Close();
                MessageBox.Show("Pokój został usunięty z bazy!", "Usunięto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
