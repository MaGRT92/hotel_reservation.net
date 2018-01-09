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
    public partial class frm_AddEditRoom : Form
    {
        Rooms theRooms = new Rooms();
        frm_Rooms theFrmRooms = new frm_Rooms();
        bool isUpdate = false;
        string roomID = string.Empty;

        public frm_AddEditRoom()
        {
            InitializeComponent();
        }

        public frm_AddEditRoom(bool isUpdate, string roomID)
            : this()
        {
            this.isUpdate = isUpdate;
            this.roomID = roomID;
            this.Text = "Edytuj Pokoj";
            txtRoomNumber.ReadOnly = true;
            FillTextboxes();
        }

        /// <summary>
        /// Fill textboxes with room number, room floor and room seats
        /// </summary>
        private void FillTextboxes()
        {
            DataTable dt = new DataTable();
            dt = theRooms.GetOneRoom(roomID);
            txtRoomNumber.Text = dt.Rows[0][0].ToString();
            txtRoomFloor.Text = dt.Rows[0][1].ToString();
            nupRoomSeats.Value = Convert.ToDecimal(dt.Rows[0][2]);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            theFrmRooms.Show();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (theRooms.UpdateRoom(roomID, txtRoomNumber.Text, txtRoomFloor.Text, nupRoomSeats.Value.ToString()))
                {
                    this.Close();
                    theFrmRooms.Show();
                }
            }
            else
            {
                if (theRooms.InsertRoom(txtRoomNumber.Text, txtRoomFloor.Text, nupRoomSeats.Value.ToString()))
                {
                    this.Close();
                    theFrmRooms.Show();
                }
            }
        }


    }
}
