using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation.forms
{
    public partial class frm_Reservations : Form
    {
        Reservations theReservations = new Reservations();

        public frm_Reservations()
        {
            InitializeComponent();
        }

        private void frm_Reservations_Load(object sender, EventArgs e)
        {
            string query = "SELECT reservation_ID AS 'Numer Rezerwacji', guest_fname AS 'Imię', guest_lname AS 'Nazwisko', room_number AS 'Numer Pokoju', room_floor AS 'Numer Piętra', room_seats AS 'Ilość Miejsc', reservation_check_in AS 'Początek Rezerwacji', reservation_check_out AS 'Koniec Rezerwacji' FROM reservations AS rs JOIN guests AS g JOIN rooms AS r WHERE rs.guest_ID=g.guest_ID AND rs.room_ID=r.room_ID ORDER BY rs.reservation_check_in DESC";
            dgvReservations.DataSource = theReservations.GetReservations(query);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbxCurrentReservations_CheckedChanged(object sender, EventArgs e)
        {
            string query = string.Empty;

            if(chbxCurrentReservations.Checked)
            {
                query = "SELECT reservation_ID AS 'Numer Rezerwacji', guest_fname AS 'Imię', guest_lname AS 'Nazwisko', room_number AS 'Numer Pokoju', room_floor AS 'Numer Piętra', room_seats AS 'Ilość Miejsc', reservation_check_in AS 'Początek Rezerwacji', reservation_check_out AS 'Koniec Rezerwacji' FROM reservations AS rs JOIN guests AS g JOIN rooms AS r WHERE rs.guest_ID=g.guest_ID AND rs.room_ID=r.room_ID AND curdate() <= rs.reservation_check_out  ORDER BY rs.reservation_check_in DESC";
                dgvReservations.DataSource = theReservations.GetReservations(query);
            }
            else
            {
                query = "SELECT reservation_ID AS 'Numer Rezerwacji', guest_fname AS 'Imię', guest_lname AS 'Nazwisko', room_number AS 'Numer Pokoju', room_floor AS 'Numer Piętra', room_seats AS 'Ilość Miejsc', reservation_check_in AS 'Początek Rezerwacji', reservation_check_out AS 'Koniec Rezerwacji' FROM reservations AS rs JOIN guests AS g JOIN rooms AS r WHERE rs.guest_ID=g.guest_ID AND rs.room_ID=r.room_ID ORDER BY rs.reservation_check_in DESC";
                dgvReservations.DataSource = theReservations.GetReservations(query);
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            frm_AddEditReservation theFrmAddEditReservation = new frm_AddEditReservation();
            theFrmAddEditReservation.ShowDialog();
        }


    }
}
