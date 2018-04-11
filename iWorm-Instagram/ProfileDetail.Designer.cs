namespace iWorm_Instagram
{
    partial class ProfileDetail
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
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.lbl_fullname = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_username = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_profile
            // 
            this.pic_profile.Location = new System.Drawing.Point(0, 38);
            this.pic_profile.Margin = new System.Windows.Forms.Padding(0);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(150, 150);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_profile.TabIndex = 5;
            this.pic_profile.TabStop = false;
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Depth = 0;
            this.lbl_fullname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_fullname.Location = new System.Drawing.Point(3, 19);
            this.lbl_fullname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(73, 19);
            this.lbl_fullname.TabIndex = 4;
            this.lbl_fullname.Text = "FullName";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Depth = 0;
            this.lbl_username.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_username.Location = new System.Drawing.Point(3, 0);
            this.lbl_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(77, 19);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // ProfileDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pic_profile);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.lbl_username);
            this.Name = "ProfileDetail";
            this.Size = new System.Drawing.Size(150, 188);
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_profile;
        private MaterialSkin.Controls.MaterialLabel lbl_fullname;
        private MaterialSkin.Controls.MaterialLabel lbl_username;
    }
}
