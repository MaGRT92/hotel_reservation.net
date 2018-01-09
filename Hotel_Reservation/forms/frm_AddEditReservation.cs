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
    public partial class frm_AddEditReservation : Form
    {
        // stores ID guest who reserves a room 
        public string guestID = string.Empty;

        public frm_AddEditReservation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectGuest_Click(object sender, EventArgs e)
        {
            frm_Guests theGuest = new frm_Guests(this);
            theGuest.ShowDialog();
        }

        private void frm_AddEditReservation_Load(object sender, EventArgs e)
        {
            dtpStartReservation.MinDate = DateTime.Today;
            dtpEndReservation.MinDate = DateTime.Today;
            dtpEndReservation.Value = DateTime.Today.AddDays(3);
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            frm_Rooms theRoom = new frm_Rooms(dtpStartReservation.Value, dtpEndReservation.Value);
            theRoom.ShowDialog();
        }
    }
}
