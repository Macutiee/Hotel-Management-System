namespace HMS.UI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            label5 = new Label();
            checkBox8 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            flowRoomsOverview = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            label1 = new Label();
            cmbRoomType = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNumberOfGuests = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPhone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtLastname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtFirstname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            flowRoomsBooking = new FlowLayoutPanel();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            tabPage5 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 48);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1112, 520);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(flowRoomsOverview);
            tabPage1.ImageKey = "home+home+page+house+start+icon-1320196419837293956_32px.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1104, 477);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Overview";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(checkBox9);
            panel2.Controls.Add(checkBox10);
            panel2.Controls.Add(checkBox11);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(checkBox8);
            panel2.Controls.Add(checkBox5);
            panel2.Controls.Add(checkBox6);
            panel2.Controls.Add(checkBox7);
            panel2.Controls.Add(checkBox4);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 442);
            panel2.TabIndex = 59;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(15, 378);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(59, 19);
            checkBox9.TabIndex = 17;
            checkBox9.Text = "Repair";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(15, 353);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(79, 19);
            checkBox10.TabIndex = 16;
            checkBox10.Text = "Not Clean";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(15, 328);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(56, 19);
            checkBox11.TabIndex = 15;
            checkBox11.Text = "Clean";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(3, 300);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 14;
            label5.Text = "House Keeping";
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(15, 259);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(61, 19);
            checkBox8.TabIndex = 13;
            checkBox8.Text = "Family";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(15, 234);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(55, 19);
            checkBox5.TabIndex = 12;
            checkBox5.Text = "Triple";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(15, 209);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(64, 19);
            checkBox6.TabIndex = 11;
            checkBox6.Text = "Double";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(15, 184);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(58, 19);
            checkBox7.TabIndex = 10;
            checkBox7.Text = "Single";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(15, 119);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(92, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "CheckedOut";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(15, 94);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(74, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Available";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 69);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Occupied";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 44);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Reserverd";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(3, 156);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 9;
            label4.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 5;
            label2.Text = "Status";
            // 
            // panel1
            // 
            panel1.Controls.Add(poisonDateTime1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 29);
            panel1.TabIndex = 58;
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            poisonDateTime1.Location = new Point(0, 0);
            poisonDateTime1.MinimumSize = new Size(0, 29);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(200, 29);
            poisonDateTime1.TabIndex = 59;
            // 
            // flowRoomsOverview
            // 
            flowRoomsOverview.AutoScroll = true;
            flowRoomsOverview.BackColor = Color.LightGray;
            flowRoomsOverview.Location = new Point(192, 38);
            flowRoomsOverview.Name = "flowRoomsOverview";
            flowRoomsOverview.Size = new Size(909, 462);
            flowRoomsOverview.TabIndex = 57;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(cmbRoomType);
            tabPage2.Controls.Add(txtNumberOfGuests);
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(txtPhone);
            tabPage2.Controls.Add(txtLastname);
            tabPage2.Controls.Add(txtFirstname);
            tabPage2.Controls.Add(flowRoomsBooking);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(label3);
            tabPage2.ImageKey = "booking_brand_icon_211924.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1104, 477);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Booking";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 241);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 63;
            label1.Text = "Check-in Date";
            // 
            // cmbRoomType
            // 
            cmbRoomType.AutoResize = false;
            cmbRoomType.BackColor = Color.FromArgb(255, 255, 255);
            cmbRoomType.Depth = 0;
            cmbRoomType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbRoomType.DropDownHeight = 174;
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.DropDownWidth = 121;
            cmbRoomType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbRoomType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Hint = "Room Type";
            cmbRoomType.IntegralHeight = false;
            cmbRoomType.ItemHeight = 43;
            cmbRoomType.Location = new Point(19, 168);
            cmbRoomType.MaxDropDownItems = 4;
            cmbRoomType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(225, 49);
            cmbRoomType.StartIndex = 0;
            cmbRoomType.TabIndex = 62;
            // 
            // txtNumberOfGuests
            // 
            txtNumberOfGuests.AnimateReadOnly = false;
            txtNumberOfGuests.AutoCompleteMode = AutoCompleteMode.None;
            txtNumberOfGuests.AutoCompleteSource = AutoCompleteSource.None;
            txtNumberOfGuests.BackgroundImageLayout = ImageLayout.None;
            txtNumberOfGuests.CharacterCasing = CharacterCasing.Normal;
            txtNumberOfGuests.Depth = 0;
            txtNumberOfGuests.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNumberOfGuests.HideSelection = true;
            txtNumberOfGuests.Hint = "Number Of Guests";
            txtNumberOfGuests.LeadingIcon = null;
            txtNumberOfGuests.Location = new Point(277, 169);
            txtNumberOfGuests.MaxLength = 32767;
            txtNumberOfGuests.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNumberOfGuests.Name = "txtNumberOfGuests";
            txtNumberOfGuests.PasswordChar = '\0';
            txtNumberOfGuests.PrefixSuffixText = null;
            txtNumberOfGuests.ReadOnly = false;
            txtNumberOfGuests.RightToLeft = RightToLeft.No;
            txtNumberOfGuests.SelectedText = "";
            txtNumberOfGuests.SelectionLength = 0;
            txtNumberOfGuests.SelectionStart = 0;
            txtNumberOfGuests.ShortcutsEnabled = true;
            txtNumberOfGuests.Size = new Size(177, 48);
            txtNumberOfGuests.TabIndex = 61;
            txtNumberOfGuests.TabStop = false;
            txtNumberOfGuests.TextAlign = HorizontalAlignment.Left;
            txtNumberOfGuests.TrailingIcon = null;
            txtNumberOfGuests.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "E-mail";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(277, 103);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(292, 48);
            txtEmail.TabIndex = 60;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            txtPhone.AnimateReadOnly = false;
            txtPhone.AutoCompleteMode = AutoCompleteMode.None;
            txtPhone.AutoCompleteSource = AutoCompleteSource.None;
            txtPhone.BackgroundImageLayout = ImageLayout.None;
            txtPhone.CharacterCasing = CharacterCasing.Normal;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.HideSelection = true;
            txtPhone.Hint = "Phone";
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(21, 103);
            txtPhone.MaxLength = 32767;
            txtPhone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPhone.Name = "txtPhone";
            txtPhone.PasswordChar = '\0';
            txtPhone.PrefixSuffixText = null;
            txtPhone.ReadOnly = false;
            txtPhone.RightToLeft = RightToLeft.No;
            txtPhone.SelectedText = "";
            txtPhone.SelectionLength = 0;
            txtPhone.SelectionStart = 0;
            txtPhone.ShortcutsEnabled = true;
            txtPhone.Size = new Size(209, 48);
            txtPhone.TabIndex = 59;
            txtPhone.TabStop = false;
            txtPhone.TextAlign = HorizontalAlignment.Left;
            txtPhone.TrailingIcon = null;
            txtPhone.UseSystemPasswordChar = false;
            // 
            // txtLastname
            // 
            txtLastname.AnimateReadOnly = false;
            txtLastname.AutoCompleteMode = AutoCompleteMode.None;
            txtLastname.AutoCompleteSource = AutoCompleteSource.None;
            txtLastname.BackgroundImageLayout = ImageLayout.None;
            txtLastname.CharacterCasing = CharacterCasing.Normal;
            txtLastname.Depth = 0;
            txtLastname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLastname.HideSelection = true;
            txtLastname.Hint = "Lastname";
            txtLastname.LeadingIcon = null;
            txtLastname.Location = new Point(320, 34);
            txtLastname.MaxLength = 32767;
            txtLastname.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLastname.Name = "txtLastname";
            txtLastname.PasswordChar = '\0';
            txtLastname.PrefixSuffixText = null;
            txtLastname.ReadOnly = false;
            txtLastname.RightToLeft = RightToLeft.No;
            txtLastname.SelectedText = "";
            txtLastname.SelectionLength = 0;
            txtLastname.SelectionStart = 0;
            txtLastname.ShortcutsEnabled = true;
            txtLastname.Size = new Size(250, 48);
            txtLastname.TabIndex = 58;
            txtLastname.TabStop = false;
            txtLastname.TextAlign = HorizontalAlignment.Left;
            txtLastname.TrailingIcon = null;
            txtLastname.UseSystemPasswordChar = false;
            // 
            // txtFirstname
            // 
            txtFirstname.AnimateReadOnly = false;
            txtFirstname.AutoCompleteMode = AutoCompleteMode.None;
            txtFirstname.AutoCompleteSource = AutoCompleteSource.None;
            txtFirstname.BackgroundImageLayout = ImageLayout.None;
            txtFirstname.CharacterCasing = CharacterCasing.Normal;
            txtFirstname.Depth = 0;
            txtFirstname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFirstname.HideSelection = true;
            txtFirstname.Hint = "Firstname";
            txtFirstname.LeadingIcon = null;
            txtFirstname.Location = new Point(19, 34);
            txtFirstname.MaxLength = 32767;
            txtFirstname.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.PasswordChar = '\0';
            txtFirstname.PrefixSuffixText = null;
            txtFirstname.ReadOnly = false;
            txtFirstname.RightToLeft = RightToLeft.No;
            txtFirstname.SelectedText = "";
            txtFirstname.SelectionLength = 0;
            txtFirstname.SelectionStart = 0;
            txtFirstname.ShortcutsEnabled = true;
            txtFirstname.Size = new Size(250, 48);
            txtFirstname.TabIndex = 57;
            txtFirstname.TabStop = false;
            txtFirstname.TextAlign = HorizontalAlignment.Left;
            txtFirstname.TrailingIcon = null;
            txtFirstname.UseSystemPasswordChar = false;
            // 
            // flowRoomsBooking
            // 
            flowRoomsBooking.AutoScroll = true;
            flowRoomsBooking.BackColor = Color.LightGray;
            flowRoomsBooking.Location = new Point(638, 34);
            flowRoomsBooking.Name = "flowRoomsBooking";
            flowRoomsBooking.Size = new Size(414, 458);
            flowRoomsBooking.TabIndex = 56;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(255, 445);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 55;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(19, 334);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(584, 102);
            richTextBox1.TabIndex = 54;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 317);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 53;
            label6.Text = "Special Requests";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(311, 259);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 23);
            dateTimePicker2.TabIndex = 47;
            dateTimePicker2.Value = new DateTime(2025, 12, 7, 17, 12, 20, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(19, 259);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 46;
            dateTimePicker1.Value = new DateTime(2025, 12, 7, 17, 12, 20, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 241);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 44;
            label3.Text = "Check-out Date";
            // 
            // tabPage5
            // 
            tabPage5.ImageKey = "employee_group_line_icon_235349(1).png";
            tabPage5.Location = new Point(4, 39);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1104, 477);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Employee";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.ImageKey = "taskboardmono_105883.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1104, 477);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "HouseKeeping Tasks";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.ImageKey = "speech_report_meeting_presentation_icon_262580.png";
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1104, 477);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Report";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "online-support.png");
            imageList1.Images.SetKeyName(1, "setting-11-32.png");
            imageList1.Images.SetKeyName(2, "add-user.png");
            imageList1.Images.SetKeyName(3, "home+home+page+house+start+icon-1320196419837293956_32px.png");
            imageList1.Images.SetKeyName(4, "file.png");
            imageList1.Images.SetKeyName(5, "reservation-completed-icon.png");
            imageList1.Images.SetKeyName(6, "customer-8-32.png");
            imageList1.Images.SetKeyName(7, "tasks_113292.png");
            imageList1.Images.SetKeyName(8, "taskboardmono_105883.png");
            imageList1.Images.SetKeyName(9, "speech_report_meeting_presentation_icon_262580.png");
            imageList1.Images.SetKeyName(10, "booking_brand_icon_211924.png");
            imageList1.Images.SetKeyName(11, "employee_group_line_icon_235349(1).png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 570);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private FlowLayoutPanel flowRoomsBooking;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtFirstname;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumberOfGuests;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPhone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLastname;
        private ReaLTaiizor.Controls.MaterialComboBox cmbRoomType;
        private Label label1;
        private FlowLayoutPanel flowRoomsOverview;
        private Panel panel2;
        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private Label label2;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox8;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private Label label5;
    }
}