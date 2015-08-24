namespace Hotel.Desktop
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gdvHotelRooms = new System.Windows.Forms.DataGridView();
            this.roomTypeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReserveRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvHotelRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvHotelRooms
            // 
            this.gdvHotelRooms.AllowUserToAddRows = false;
            this.gdvHotelRooms.AllowUserToDeleteRows = false;
            this.gdvHotelRooms.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvHotelRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvHotelRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvHotelRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvHotelRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdvHotelRooms.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gdvHotelRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvHotelRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvHotelRooms.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.roomTypeDTOBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.gdvHotelRooms.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.roomTypeDTOBindingSource, "Name", true));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvHotelRooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdvHotelRooms.Location = new System.Drawing.Point(13, 13);
            this.gdvHotelRooms.MultiSelect = false;
            this.gdvHotelRooms.Name = "gdvHotelRooms";
            this.gdvHotelRooms.ReadOnly = true;
            this.gdvHotelRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvHotelRooms.Size = new System.Drawing.Size(791, 251);
            this.gdvHotelRooms.TabIndex = 1;
            // 
            // roomTypeDTOBindingSource
            // 
            this.roomTypeDTOBindingSource.DataSource = typeof(Hotel.Desktop.HotelServiceReference.RoomTypeDTO);
            // 
            // btnReserveRoom
            // 
            this.btnReserveRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReserveRoom.Location = new System.Drawing.Point(279, 270);
            this.btnReserveRoom.Name = "btnReserveRoom";
            this.btnReserveRoom.Size = new System.Drawing.Size(259, 23);
            this.btnReserveRoom.TabIndex = 2;
            this.btnReserveRoom.Text = "Забронювати";
            this.btnReserveRoom.UseVisualStyleBackColor = true;
            this.btnReserveRoom.Click += new System.EventHandler(this.btnReserveRoom_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 305);
            this.Controls.Add(this.btnReserveRoom);
            this.Controls.Add(this.gdvHotelRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "Hotel service";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvHotelRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gdvHotelRooms;
        private System.Windows.Forms.BindingSource roomTypeDTOBindingSource;
        private System.Windows.Forms.Button btnReserveRoom;
    }
}

