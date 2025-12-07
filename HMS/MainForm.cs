using ReaLTaiizor.Forms;
using HMS.UI.Configs;

namespace HMS.UI
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            MaterialThemeConfig.Apply(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RoomCard card = new RoomCard();
            card.SetData("Room 101", "Available", "Free Room");
            flowRoomsBooking.Controls.Add(card);

            RoomCard card2 = new RoomCard();
            card2.SetData("Room 102", "Occupied", "Andrew");
            flowRoomsBooking.Controls.Add(card2);

            RoomCard card1 = new RoomCard();
            card1.SetData("Room 101", "Available", "Free Room");
            flowRoomsOverview.Controls.Add(card1);

        }

        private void LoadRoomsBooking()
        {
            flowRoomsBooking.Controls.Clear();

            for (int i = 101; i <= 110; i++)
            {
                RoomCard card = new RoomCard();
                card.SetData("Room " + i, "Available", "Free Room");
                flowRoomsBooking.Controls.Add(card);
            }
        }

        private void LoadRoomsOverview()
        {
            flowRoomsBooking.Controls.Clear();

            for (int i = 101; i <= 110; i++)
            {
                RoomCard card = new RoomCard();
                card.SetData("Room " + i, "Available", "Free Room");
                flowRoomsOverview.Controls.Add(card);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
