using Hotel.Desktop.HotelServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel.Desktop
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private HotelServiceClient _service = new HotelServiceClient();

        public HotelServiceClient Service
        {
            get
            {
                return _service;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            RoomTypeDTO[] RoomType = this.Service.GetAllType(); 

            this.gdvHotelRooms.DataSource = RoomType;
            this.gdvHotelRooms.Columns["Id"].Visible          = false;
            this.gdvHotelRooms.Columns["Quentity"].HeaderText = "Кількість";
            this.gdvHotelRooms.Columns["Price"].HeaderText    = "Ціна";
            this.gdvHotelRooms.Columns["Name"].HeaderText     = "Назва";
        }

        private void btnReserveRoom_Click(object sender, EventArgs e)
        {
            if (this.gdvHotelRooms.SelectedRows.Count == 1)//>0
            {
                DataGridViewRow row = this.gdvHotelRooms.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                string name = row.Cells["Name"].Value.ToString();

                reserveForm reserve = new reserveForm(id, name, new Action<string[]>(Service.InsertOneRoomReserve));//ReserverRoom
                reserve.Show();
            }
            else
            {
                MessageBox.Show("Виберіть номер", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
