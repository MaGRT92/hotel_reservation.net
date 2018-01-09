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
    public partial class frm_AddEditGuest : Form
    {
        frm_Guests theFrmGuests = new frm_Guests();
        Guests theGuest = new Guests();
        bool isUpdate = false;
        string guestID = string.Empty;

        public frm_AddEditGuest()
        {
            InitializeComponent();
        }

        public frm_AddEditGuest(bool isUpdate, string guestID) : this()
        {
            this.Text = "Edytuj Gościa";
            this.isUpdate = isUpdate;
            this.guestID = guestID;
            FillTextboxes();
        }

        /// <summary>
        /// Fill textboxes with guest name, adress and phone
        /// </summary>
        private void FillTextboxes()
        {
            DataTable dt = new DataTable();
            dt = theGuest.GetOneGuest(guestID);
            txtFName.Text = dt.Rows[0][0].ToString();
            txtLName.Text = dt.Rows[0][1].ToString();
            txtPesel.Text = dt.Rows[0][2].ToString();
            txtAdress.Text = dt.Rows[0][3].ToString();
            txtCity.Text = dt.Rows[0][4].ToString();
            txtPhone.Text = dt.Rows[0][5].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            theFrmGuests.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (theGuest.UpdateGuest(guestID, txtFName.Text, txtLName.Text, txtPesel.Text, txtAdress.Text, txtCity.Text, txtPhone.Text))
                {
                    this.Close();
                    theFrmGuests.Show();
                }
            }
            else
            {
                if (theGuest.InsertGuest(txtFName.Text, txtLName.Text, txtPesel.Text, txtAdress.Text, txtCity.Text, txtPhone.Text))
                {
                    this.Close();
                    theFrmGuests.Show();
                }
            }
            
        }


    }
}
