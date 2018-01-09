namespace Hotel_Reservation
{
    partial class frm_Main
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
            this.btn_Rooms = new System.Windows.Forms.Button();
            this.btn_Guests = new System.Windows.Forms.Button();
            this.btn_Reservations = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Rooms
            // 
            this.btn_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Rooms.Location = new System.Drawing.Point(111, 38);
            this.btn_Rooms.Name = "btn_Rooms";
            this.btn_Rooms.Size = new System.Drawing.Size(100, 45);
            this.btn_Rooms.TabIndex = 0;
            this.btn_Rooms.Text = "Pokoje";
            this.btn_Rooms.UseVisualStyleBackColor = true;
            this.btn_Rooms.Click += new System.EventHandler(this.btn_Rooms_Click);
            // 
            // btn_Guests
            // 
            this.btn_Guests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Guests.Location = new System.Drawing.Point(217, 38);
            this.btn_Guests.Name = "btn_Guests";
            this.btn_Guests.Size = new System.Drawing.Size(100, 45);
            this.btn_Guests.TabIndex = 1;
            this.btn_Guests.Text = "Goście";
            this.btn_Guests.UseVisualStyleBackColor = true;
            this.btn_Guests.Click += new System.EventHandler(this.btn_Guests_Click);
            // 
            // btn_Reservations
            // 
            this.btn_Reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Reservations.Location = new System.Drawing.Point(323, 38);
            this.btn_Reservations.Name = "btn_Reservations";
            this.btn_Reservations.Size = new System.Drawing.Size(100, 45);
            this.btn_Reservations.TabIndex = 2;
            this.btn_Reservations.Text = "Rezerwacje";
            this.btn_Reservations.UseVisualStyleBackColor = true;
            this.btn_Reservations.Click += new System.EventHandler(this.btn_Reservations_Click);
            // 
            // btn_About
            // 
            this.btn_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_About.Location = new System.Drawing.Point(429, 38);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(100, 45);
            this.btn_About.TabIndex = 3;
            this.btn_About.Text = "O programie";
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Exit.Location = new System.Drawing.Point(554, 204);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 30);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Wyjdź";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 262);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Reservations);
            this.Controls.Add(this.btn_Guests);
            this.Controls.Add(this.btn_Rooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno Główne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Rooms;
        private System.Windows.Forms.Button btn_Guests;
        private System.Windows.Forms.Button btn_Reservations;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Exit;
    }
}

