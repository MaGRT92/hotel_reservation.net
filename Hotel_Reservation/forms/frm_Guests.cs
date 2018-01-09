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
    public partial class frm_Guests : Form
    {

        Guests theGuests = new Guests();
        frm_AddEditReservation owner = null;
        public frm_Guests()
        {
            InitializeComponent();
        }

        public frm_Guests(frm_AddEditReservation owner) : this()
        {
            this.owner = owner;
            btnAddGuestToReservation.Visible = true;
        }

        private void frm_Guests_Load(object sender, EventArgs e)
        {
            dgvGuests.DataSource = theGuests.GetAllGuests();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_AddEditGuest theFrmAddEditGuest = new frm_AddEditGuest();
            theFrmAddEditGuest.Show();
        }

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count > 0)
            {
                frm_AddEditGuest theFrmAddEditGuest = new frm_AddEditGuest(true, dgvGuests.SelectedRows[0].Cells[0].Value.ToString());
                this.Close();
                theFrmAddEditGuest.Show();
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć gościa na liście!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Czy napewno chcesz usunąć tego gościa z bazy?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    theGuests.DeleteRoom(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());
                    dgvGuests.DataSource = theGuests.GetAllGuests();
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć gościa na liście!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddGuestToReservation_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count > 0)
            {
                owner.guestID = dgvGuests.SelectedRows[0].Cells[0].Value.ToString();
                owner.txtGuestFirstLastName.Text = dgvGuests.SelectedRows[0].Cells[1].Value.ToString() + " " + dgvGuests.SelectedRows[0].Cells[2].Value.ToString();
                   
                this.Close();  
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć gościa na liście!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
