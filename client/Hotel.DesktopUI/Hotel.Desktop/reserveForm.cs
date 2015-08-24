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
    public partial class reserveForm : Form
    {
        public int IdRoom      { get; set; }
        public string NameRoom { get; set; }
        private Action<string[]> reserveRoom;

        public reserveForm(int id, string name, Action<string[]>  reserveRoom)
        {
            IdRoom = id;
            NameRoom = name;
            this.reserveRoom = reserveRoom;
            InitializeComponent();
        }

        private void reserveForm_Load(object sender, EventArgs e)
        {
            lbRoom.Text = String.Format("{0}:\n{1}", lbRoom.Text, NameRoom);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text != string.Empty &&
                tbPhone.Text    != string.Empty &&
                tbEmail.Text    != string.Empty
                )
            {
                string[] fieldsValue = {
                this.tbFullName.Text.ToString(),
                this.IdRoom.ToString(),
                this.tbPhone.Text.ToString(),
                this.tbEmail.Text.ToString()
                };
                try
                {
                    reserveRoom(fieldsValue);
                    MessageBox.Show("Номер заброньовано", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
