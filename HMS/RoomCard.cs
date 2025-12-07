using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.UI
{
    public partial class RoomCard : UserControl
    {
        public RoomCard()
        {
            InitializeComponent();
        }

        private void RoomCard_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string room, string status, string guest)
        {
            lblRoom.Text = room;
            label2.Text = status;
            label3.Text = guest;
        }

        private void lblDays_Click(object sender, EventArgs e)
        {

        }
    }
}
