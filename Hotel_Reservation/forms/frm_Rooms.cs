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
    public partial class frm_Rooms : Form
    {
        Rooms theRoom = new Rooms();
       

        public frm_Rooms()
        {
            InitializeComponent();
            rbAllRooms.Checked = true;
            dtpEndDate.Value = DateTime.Today.AddDays(10);
        }

        public frm_Rooms(DateTime startDate, DateTime endDate) : this()
        {
            rbAvaibleRooms.Checked = true;
            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;
            btnAddRoomToReservation.Visible = true;
            label2.Visible = true;
            nudSelectRoomSeats.Visible = true;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Rooms_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_AddEditRoom theAddEditRoom = new frm_AddEditRoom();
            theAddEditRoom.ShowDialog();
           
        }

        private void btn_EditRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                frm_AddEditRoom theAddEditRoom = new frm_AddEditRoom(true, dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
                this.Close();
                theAddEditRoom.Show();
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć pokój na liście!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Czy napewno chcesz usunąć ten pokój z bazy?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    theRoom.DeleteRoom(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
                    dgvRooms.DataSource = theRoom.GetRooms();  
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć pokój na liście!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void rbAllRooms_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnAddRoomToReservation.Enabled = false;
            dgvRooms.DataSource = theRoom.GetRooms();
        }

        private void rbAvaibleRooms_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnAddRoomToReservation.Enabled = true;
        }

        private void rbOccupiedRooms_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnAddRoomToReservation.Enabled = false;
        }

       


    }
}
