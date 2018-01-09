using Hotel_Reservation.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            frm_Rooms rooms = new frm_Rooms();
            rooms.Show();
        }

        private void btn_Guests_Click(object sender, EventArgs e)
        {
            frm_Guests theGuests = new frm_Guests();
            theGuests.Show();
        }

        private void btn_Reservations_Click(object sender, EventArgs e)
        {
            frm_Reservations theFrmReservations = new frm_Reservations();
            theFrmReservations.Show();
        }
    }
}
