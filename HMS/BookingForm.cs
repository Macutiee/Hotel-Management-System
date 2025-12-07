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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblPhone = new Label();
            lblEmailAddress = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblRoomType = new Label();
            lblNumberOfGuests = new Label();
            cmbRoomType = new ComboBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.beach;
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(687, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.HotelRoom1;
            pictureBox2.Location = new Point(72, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.HotelRoom2;
            pictureBox3.Location = new Point(269, 148);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 127);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.hotel1;
            pictureBox4.Location = new Point(470, 148);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(147, 127);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(53, 341);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(354, 341);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 359);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(354, 359);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 23);
            textBox2.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(53, 399);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(311, 399);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(86, 15);
            lblEmailAddress.TabIndex = 9;
            lblEmailAddress.Text = "E-mail Address";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(53, 417);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(311, 417);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(326, 23);
            textBox4.TabIndex = 11;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(53, 458);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(67, 15);
            lblRoomType.TabIndex = 12;
            lblRoomType.Text = "Room Type";
            // 
            // lblNumberOfGuests
            // 
            lblNumberOfGuests.AutoSize = true;
            lblNumberOfGuests.Location = new Point(311, 458);
            lblNumberOfGuests.Name = "lblNumberOfGuests";
            lblNumberOfGuests.Size = new Size(105, 15);
            lblNumberOfGuests.TabIndex = 13;
            lblNumberOfGuests.Text = "Number Of Guests";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(53, 476);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(211, 23);
            cmbRoomType.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(311, 476);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 23);
            textBox5.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 521);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 16;
            label1.Text = "Check-in Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 521);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 17;
            label2.Text = "Check-in Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 521);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 18;
            label3.Text = "Check-out Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 521);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 19;
            label4.Text = "Check-out Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(53, 548);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2025, 12, 7, 17, 12, 20, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(354, 548);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 23);
            dateTimePicker2.TabIndex = 21;
            dateTimePicker2.Value = new DateTime(2025, 12, 7, 17, 12, 20, 0);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 548);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(104, 23);
            comboBox1.TabIndex = 22;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(484, 548);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(104, 23);
            comboBox2.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 619);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 24;
            label5.Text = "Free Pickup?";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(53, 637);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(206, 19);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yes, please! - Pick me up on arrival";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(303, 637);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(240, 19);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.Text = "No, thanks! - I'll make my own way there";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 672);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 27;
            label6.Text = "Special Requests";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(53, 689);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(584, 96);
            richTextBox1.TabIndex = 28;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(288, 791);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 29;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(495, 451);
            materialTextBoxEdit1.MaxLength = 32767;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(250, 48);
            materialTextBoxEdit1.TabIndex = 30;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.Text = "materialTextBoxEdit1";
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // BookingForm
            // 
            ClientSize = new Size(687, 820);
            Controls.Add(materialTextBoxEdit1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(cmbRoomType);
            Controls.Add(lblNumberOfGuests);
            Controls.Add(lblRoomType);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(lblEmailAddress);
            Controls.Add(lblPhone);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "BookingForm";
            Text = "Booking";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblPhone;
        private Label lblEmailAddress;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblRoomType;
        private Label lblNumberOfGuests;
        private ComboBox cmbRoomType;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private RichTextBox richTextBox1;
        private Button button1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
    }
}
