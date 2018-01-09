namespace Hotel_Reservation.forms
{
    partial class frm_Rooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddRoom = new System.Windows.Forms.Button();
            this.btn_DeleteRoom = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_EditRoom = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.rbAllRooms = new System.Windows.Forms.RadioButton();
            this.rbAvaibleRooms = new System.Windows.Forms.RadioButton();
            this.rbOccupiedRooms = new System.Windows.Forms.RadioButton();
            this.gbxAvaibilityOfRooms = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRoomToReservation = new System.Windows.Forms.Button();
            this.nudSelectRoomSeats = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.gbxAvaibilityOfRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectRoomSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddRoom
            // 
            this.btn_AddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_AddRoom.Location = new System.Drawing.Point(488, 55);
            this.btn_AddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddRoom.Name = "btn_AddRoom";
            this.btn_AddRoom.Size = new System.Drawing.Size(120, 30);
            this.btn_AddRoom.TabIndex = 1;
            this.btn_AddRoom.Text = "Dodaj pokój";
            this.btn_AddRoom.UseVisualStyleBackColor = true;
            this.btn_AddRoom.Click += new System.EventHandler(this.btn_AddRoom_Click);
            // 
            // btn_DeleteRoom
            // 
            this.btn_DeleteRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_DeleteRoom.Location = new System.Drawing.Point(488, 131);
            this.btn_DeleteRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeleteRoom.Name = "btn_DeleteRoom";
            this.btn_DeleteRoom.Size = new System.Drawing.Size(120, 30);
            this.btn_DeleteRoom.TabIndex = 2;
            this.btn_DeleteRoom.Text = "Usuń pokój";
            this.btn_DeleteRoom.UseVisualStyleBackColor = true;
            this.btn_DeleteRoom.Click += new System.EventHandler(this.btn_DeleteRoom_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Close.Location = new System.Drawing.Point(571, 565);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 30);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Zamknij";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_EditRoom
            // 
            this.btn_EditRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_EditRoom.Location = new System.Drawing.Point(488, 93);
            this.btn_EditRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EditRoom.Name = "btn_EditRoom";
            this.btn_EditRoom.Size = new System.Drawing.Size(120, 30);
            this.btn_EditRoom.TabIndex = 4;
            this.btn_EditRoom.Text = "Edytuj pokój";
            this.btn_EditRoom.UseVisualStyleBackColor = true;
            this.btn_EditRoom.Click += new System.EventHandler(this.btn_EditRoom_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(28, 55);
            this.dgvRooms.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersWidth = 20;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(440, 485);
            this.dgvRooms.TabIndex = 5;
            // 
            // rbAllRooms
            // 
            this.rbAllRooms.AutoSize = true;
            this.rbAllRooms.Location = new System.Drawing.Point(13, 31);
            this.rbAllRooms.Name = "rbAllRooms";
            this.rbAllRooms.Size = new System.Drawing.Size(133, 20);
            this.rbAllRooms.TabIndex = 6;
            this.rbAllRooms.Text = "Wszystkie Pokoje";
            this.rbAllRooms.UseVisualStyleBackColor = true;
            this.rbAllRooms.CheckedChanged += new System.EventHandler(this.rbAllRooms_CheckedChanged);
            // 
            // rbAvaibleRooms
            // 
            this.rbAvaibleRooms.AutoSize = true;
            this.rbAvaibleRooms.Location = new System.Drawing.Point(13, 57);
            this.rbAvaibleRooms.Name = "rbAvaibleRooms";
            this.rbAvaibleRooms.Size = new System.Drawing.Size(131, 20);
            this.rbAvaibleRooms.TabIndex = 7;
            this.rbAvaibleRooms.Text = "Dostępne Pokoje";
            this.rbAvaibleRooms.UseVisualStyleBackColor = true;
            this.rbAvaibleRooms.CheckedChanged += new System.EventHandler(this.rbAvaibleRooms_CheckedChanged);
            // 
            // rbOccupiedRooms
            // 
            this.rbOccupiedRooms.AutoSize = true;
            this.rbOccupiedRooms.Location = new System.Drawing.Point(13, 83);
            this.rbOccupiedRooms.Name = "rbOccupiedRooms";
            this.rbOccupiedRooms.Size = new System.Drawing.Size(110, 20);
            this.rbOccupiedRooms.TabIndex = 8;
            this.rbOccupiedRooms.Text = "Zajęte Pokoje";
            this.rbOccupiedRooms.UseVisualStyleBackColor = true;
            this.rbOccupiedRooms.CheckedChanged += new System.EventHandler(this.rbOccupiedRooms_CheckedChanged);
            // 
            // gbxAvaibilityOfRooms
            // 
            this.gbxAvaibilityOfRooms.Controls.Add(this.rbAllRooms);
            this.gbxAvaibilityOfRooms.Controls.Add(this.rbOccupiedRooms);
            this.gbxAvaibilityOfRooms.Controls.Add(this.rbAvaibleRooms);
            this.gbxAvaibilityOfRooms.Location = new System.Drawing.Point(488, 195);
            this.gbxAvaibilityOfRooms.Name = "gbxAvaibilityOfRooms";
            this.gbxAvaibilityOfRooms.Size = new System.Drawing.Size(158, 135);
            this.gbxAvaibilityOfRooms.TabIndex = 10;
            this.gbxAvaibilityOfRooms.TabStop = false;
            this.gbxAvaibilityOfRooms.Text = "Dostosuj";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(488, 372);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(158, 22);
            this.dtpStartDate.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(488, 411);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(158, 22);
            this.dtpEndDate.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "W dniach:";
            // 
            // btnAddRoomToReservation
            // 
            this.btnAddRoomToReservation.Location = new System.Drawing.Point(488, 488);
            this.btnAddRoomToReservation.Name = "btnAddRoomToReservation";
            this.btnAddRoomToReservation.Size = new System.Drawing.Size(158, 30);
            this.btnAddRoomToReservation.TabIndex = 13;
            this.btnAddRoomToReservation.Text = "Dodaj Do Rezerwacji";
            this.btnAddRoomToReservation.UseVisualStyleBackColor = true;
            this.btnAddRoomToReservation.Visible = false;
            // 
            // nudSelectRoomSeats
            // 
            this.nudSelectRoomSeats.Location = new System.Drawing.Point(571, 450);
            this.nudSelectRoomSeats.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSelectRoomSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSelectRoomSeats.Name = "nudSelectRoomSeats";
            this.nudSelectRoomSeats.ReadOnly = true;
            this.nudSelectRoomSeats.Size = new System.Drawing.Size(75, 22);
            this.nudSelectRoomSeats.TabIndex = 14;
            this.nudSelectRoomSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSelectRoomSeats.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ilość Miejsc";
            this.label2.Visible = false;
            // 
            // frm_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 622);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSelectRoomSeats);
            this.Controls.Add(this.btnAddRoomToReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.gbxAvaibilityOfRooms);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.btn_EditRoom);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_DeleteRoom);
            this.Controls.Add(this.btn_AddRoom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Rooms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokoje";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.gbxAvaibilityOfRooms.ResumeLayout(false);
            this.gbxAvaibilityOfRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectRoomSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddRoom;
        private System.Windows.Forms.Button btn_DeleteRoom;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_EditRoom;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.RadioButton rbAllRooms;
        private System.Windows.Forms.RadioButton rbAvaibleRooms;
        private System.Windows.Forms.RadioButton rbOccupiedRooms;
        private System.Windows.Forms.GroupBox gbxAvaibilityOfRooms;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRoomToReservation;
        private System.Windows.Forms.NumericUpDown nudSelectRoomSeats;
        private System.Windows.Forms.Label label2;
    }
}