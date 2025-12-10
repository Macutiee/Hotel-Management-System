namespace HMS.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new Button();
            chkRememberMe = new CheckBox();
            imageList1 = new ImageList(components);
            lblDHACC = new Label();
            linkSignUp = new LinkLabel();
            linkForgotPassword = new LinkLabel();
            txtUserName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(22, 251);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRememberMe.Location = new Point(34, 207);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(104, 19);
            chkRememberMe.TabIndex = 3;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "google-131-32.png");
            // 
            // lblDHACC
            // 
            lblDHACC.AutoSize = true;
            lblDHACC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDHACC.Location = new Point(52, 293);
            lblDHACC.Name = "lblDHACC";
            lblDHACC.Size = new Size(131, 15);
            lblDHACC.TabIndex = 6;
            lblDHACC.Text = "Don't have an account?";
            // 
            // linkSignUp
            // 
            linkSignUp.AutoSize = true;
            linkSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkSignUp.LinkBehavior = LinkBehavior.NeverUnderline;
            linkSignUp.LinkColor = SystemColors.Highlight;
            linkSignUp.Location = new Point(177, 293);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(48, 15);
            linkSignUp.TabIndex = 7;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign Up";
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkForgotPassword.LinkBehavior = LinkBehavior.NeverUnderline;
            linkForgotPassword.LinkColor = SystemColors.Highlight;
            linkForgotPassword.Location = new Point(154, 207);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(100, 15);
            linkForgotPassword.TabIndex = 8;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password?";
            // 
            // txtUserName
            // 
            txtUserName.AnimateReadOnly = false;
            txtUserName.AutoCompleteMode = AutoCompleteMode.None;
            txtUserName.AutoCompleteSource = AutoCompleteSource.None;
            txtUserName.BackgroundImageLayout = ImageLayout.None;
            txtUserName.CharacterCasing = CharacterCasing.Normal;
            txtUserName.Depth = 0;
            txtUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserName.HideSelection = true;
            txtUserName.Hint = "Username";
            txtUserName.LeadingIcon = null;
            txtUserName.Location = new Point(22, 86);
            txtUserName.MaxLength = 32767;
            txtUserName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PrefixSuffixText = null;
            txtUserName.ReadOnly = false;
            txtUserName.RightToLeft = RightToLeft.No;
            txtUserName.SelectedText = "";
            txtUserName.SelectionLength = 0;
            txtUserName.SelectionStart = 0;
            txtUserName.ShortcutsEnabled = true;
            txtUserName.Size = new Size(250, 48);
            txtUserName.TabIndex = 11;
            txtUserName.TabStop = false;
            txtUserName.TextAlign = HorizontalAlignment.Left;
            txtUserName.TrailingIcon = null;
            txtUserName.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(22, 153);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(250, 48);
            txtPassword.TabIndex = 12;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 324);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(linkForgotPassword);
            Controls.Add(linkSignUp);
            Controls.Add(lblDHACC);
            Controls.Add(chkRememberMe);
            Controls.Add(btnLogin);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "LoginForm";
            Padding = new Padding(3, 48, 3, 2);
            Text = "                   Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private CheckBox chkRememberMe;
        private ImageList imageList1;
        private Label lblDHACC;
        private LinkLabel linkSignUp;
        private LinkLabel linkForgotPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUserName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
    }
}