namespace iWorm_Instagram
{
    partial class frm_login
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
            this.lbl_description = new MaterialSkin.Controls.MaterialLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.login_insta = new System.Windows.Forms.WebBrowser();
            this.lbl_status = new MaterialSkin.Controls.MaterialLabel();
            this.btn_letsgo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.prog_wait = new MaterialSkin.Controls.MaterialProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Depth = 0;
            this.lbl_description.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_description.Location = new System.Drawing.Point(12, 78);
            this.lbl_description.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(225, 57);
            this.lbl_description.TabIndex = 3;
            this.lbl_description.Text = "iWorm for Instagram\r\nManage your Follower,Following\r\nExport Fav List JSON Format";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(10, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 18);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Brunchhex.com";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linkLabel2.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel2.Location = new System.Drawing.Point(128, 290);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(181, 18);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Instagram.com/Brunchhex";
            // 
            // login_insta
            // 
            this.login_insta.Location = new System.Drawing.Point(315, 78);
            this.login_insta.MinimumSize = new System.Drawing.Size(20, 20);
            this.login_insta.Name = "login_insta";
            this.login_insta.Size = new System.Drawing.Size(376, 244);
            this.login_insta.TabIndex = 8;
            this.login_insta.Url = new System.Uri("", System.UriKind.Relative);
            this.login_insta.WebBrowserShortcutsEnabled = false;
            this.login_insta.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.login_insta_Navigated);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Depth = 0;
            this.lbl_status.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_status.Location = new System.Drawing.Point(12, 147);
            this.lbl_status.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(122, 19);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "Your Information";
            // 
            // btn_letsgo
            // 
            this.btn_letsgo.AutoSize = true;
            this.btn_letsgo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_letsgo.Depth = 0;
            this.btn_letsgo.Enabled = false;
            this.btn_letsgo.Icon = null;
            this.btn_letsgo.Location = new System.Drawing.Point(228, 251);
            this.btn_letsgo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_letsgo.Name = "btn_letsgo";
            this.btn_letsgo.Primary = true;
            this.btn_letsgo.Size = new System.Drawing.Size(81, 36);
            this.btn_letsgo.TabIndex = 10;
            this.btn_letsgo.Text = "Let\'s Go!";
            this.btn_letsgo.UseVisualStyleBackColor = true;
            this.btn_letsgo.Click += new System.EventHandler(this.btn_letsgo_Click);
            // 
            // pic_profile
            // 
            this.pic_profile.BackColor = System.Drawing.Color.Transparent;
            this.pic_profile.Location = new System.Drawing.Point(315, 78);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(376, 244);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_profile.TabIndex = 11;
            this.pic_profile.TabStop = false;
            this.pic_profile.Visible = false;
            // 
            // prog_wait
            // 
            this.prog_wait.Depth = 0;
            this.prog_wait.Location = new System.Drawing.Point(12, 311);
            this.prog_wait.MouseState = MaterialSkin.MouseState.HOVER;
            this.prog_wait.Name = "prog_wait";
            this.prog_wait.Size = new System.Drawing.Size(293, 5);
            this.prog_wait.TabIndex = 12;
            this.prog_wait.Visible = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 334);
            this.Controls.Add(this.prog_wait);
            this.Controls.Add(this.pic_profile);
            this.Controls.Add(this.btn_letsgo);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.login_insta);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_description);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iWorm Instagram";
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbl_description;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.WebBrowser login_insta;
        private MaterialSkin.Controls.MaterialLabel lbl_status;
        private MaterialSkin.Controls.MaterialRaisedButton btn_letsgo;
        private System.Windows.Forms.PictureBox pic_profile;
        private MaterialSkin.Controls.MaterialProgressBar prog_wait;
    }
}

