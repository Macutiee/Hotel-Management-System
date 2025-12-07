namespace HMS.UI
{
    partial class RoomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ReaLTaiizor.ControlRenderer controlRenderer1 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable1 = new ReaLTaiizor.MSColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomCard));
            lblRoom = new Label();
            label2 = new Label();
            label3 = new Label();
            formStatusStrip1 = new ReaLTaiizor.Controls.FormStatusStrip();
            lblDaysStayed = new ToolStripStatusLabel();
            lblCleanStatus = new ToolStripStatusLabel();
            formStatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(15, 12);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(91, 15);
            lblRoom.TabIndex = 0;
            lblRoom.Text = "Room Numbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 12);
            label2.Name = "label2";
            label2.Size = new Size(30, 12);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 60);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Room status";
            // 
            // formStatusStrip1
            // 
            formStatusStrip1.Items.AddRange(new ToolStripItem[] { lblDaysStayed, lblCleanStatus });
            formStatusStrip1.Location = new Point(0, 98);
            formStatusStrip1.Name = "formStatusStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            formStatusStrip1.Renderer = controlRenderer1;
            formStatusStrip1.Size = new Size(178, 22);
            formStatusStrip1.SizingGrip = false;
            formStatusStrip1.TabIndex = 4;
            formStatusStrip1.Text = "formStatusStrip1";
            // 
            // lblDaysStayed
            // 
            lblDaysStayed.Image = (Image)resources.GetObject("lblDaysStayed.Image");
            lblDaysStayed.Name = "lblDaysStayed";
            lblDaysStayed.Size = new Size(16, 17);
            lblDaysStayed.Click += lblDays_Click;
            // 
            // lblCleanStatus
            // 
            lblCleanStatus.Image = (Image)resources.GetObject("lblCleanStatus.Image");
            lblCleanStatus.Name = "lblCleanStatus";
            lblCleanStatus.Size = new Size(16, 17);
            // 
            // RoomCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(formStatusStrip1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblRoom);
            Name = "RoomCard";
            Size = new Size(178, 120);
            Load += RoomCard_Load;
            formStatusStrip1.ResumeLayout(false);
            formStatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoom;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.FormStatusStrip formStatusStrip1;
        private ToolStripStatusLabel lblDaysStayed;
        private ToolStripStatusLabel lblCleanStatus;
    }
}
