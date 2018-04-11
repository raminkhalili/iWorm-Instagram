namespace iWorm_Instagram
{
    partial class frm_main
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
            this.tc_main = new MaterialSkin.Controls.MaterialTabControl();
            this.tc_main_follower = new System.Windows.Forms.TabPage();
            this.lpd_follower = new iWorm_Instagram.ListProfileDetail();
            this.tc_main_following = new System.Windows.Forms.TabPage();
            this.lpd_following = new iWorm_Instagram.ListProfileDetail();
            this.tc_main_not_follow = new System.Windows.Forms.TabPage();
            this.lpd_notfollow = new iWorm_Instagram.ListProfileDetail();
            this.tc_main_notfollowback = new System.Windows.Forms.TabPage();
            this.lpd_notfollowback = new iWorm_Instagram.ListProfileDetail();
            this.tc_main_safe_follow = new System.Windows.Forms.TabPage();
            this.lpd_alwaysfollow = new iWorm_Instagram.ListProfileDetail();
            this.tc_main_fav = new System.Windows.Forms.TabPage();
            this.lpd_favorite = new iWorm_Instagram.ListProfileDetail();
            this.ts_main = new MaterialSkin.Controls.MaterialTabSelector();
            this.lbl_refresh = new MaterialSkin.Controls.MaterialLabel();
            this.tc_main.SuspendLayout();
            this.tc_main_follower.SuspendLayout();
            this.tc_main_following.SuspendLayout();
            this.tc_main_not_follow.SuspendLayout();
            this.tc_main_notfollowback.SuspendLayout();
            this.tc_main_safe_follow.SuspendLayout();
            this.tc_main_fav.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tc_main_follower);
            this.tc_main.Controls.Add(this.tc_main_following);
            this.tc_main.Controls.Add(this.tc_main_not_follow);
            this.tc_main.Controls.Add(this.tc_main_notfollowback);
            this.tc_main.Controls.Add(this.tc_main_safe_follow);
            this.tc_main.Controls.Add(this.tc_main_fav);
            this.tc_main.Depth = 0;
            this.tc_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tc_main.Location = new System.Drawing.Point(0, 263);
            this.tc_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(841, 270);
            this.tc_main.TabIndex = 0;
            // 
            // tc_main_follower
            // 
            this.tc_main_follower.AutoScroll = true;
            this.tc_main_follower.Controls.Add(this.lpd_follower);
            this.tc_main_follower.Location = new System.Drawing.Point(4, 22);
            this.tc_main_follower.Name = "tc_main_follower";
            this.tc_main_follower.Padding = new System.Windows.Forms.Padding(3);
            this.tc_main_follower.Size = new System.Drawing.Size(833, 244);
            this.tc_main_follower.TabIndex = 0;
            this.tc_main_follower.Text = "Follower";
            this.tc_main_follower.UseVisualStyleBackColor = true;
            // 
            // lpd_follower
            // 
            this.lpd_follower.AutoScroll = true;
            this.lpd_follower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpd_follower.Location = new System.Drawing.Point(3, 3);
            this.lpd_follower.Name = "lpd_follower";
            this.lpd_follower.Size = new System.Drawing.Size(827, 238);
            this.lpd_follower.TabIndex = 0;
            // 
            // tc_main_following
            // 
            this.tc_main_following.Controls.Add(this.lpd_following);
            this.tc_main_following.Location = new System.Drawing.Point(4, 22);
            this.tc_main_following.Name = "tc_main_following";
            this.tc_main_following.Padding = new System.Windows.Forms.Padding(3);
            this.tc_main_following.Size = new System.Drawing.Size(833, 244);
            this.tc_main_following.TabIndex = 1;
            this.tc_main_following.Text = "Following";
            this.tc_main_following.UseVisualStyleBackColor = true;
            // 
            // lpd_following
            // 
            this.lpd_following.AutoScroll = true;
            this.lpd_following.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpd_following.Location = new System.Drawing.Point(3, 3);
            this.lpd_following.Name = "lpd_following";
            this.lpd_following.Size = new System.Drawing.Size(827, 238);
            this.lpd_following.TabIndex = 0;
            // 
            // tc_main_not_follow
            // 
            this.tc_main_not_follow.Controls.Add(this.lpd_notfollow);
            this.tc_main_not_follow.Location = new System.Drawing.Point(4, 22);
            this.tc_main_not_follow.Name = "tc_main_not_follow";
            this.tc_main_not_follow.Size = new System.Drawing.Size(833, 244);
            this.tc_main_not_follow.TabIndex = 2;
            this.tc_main_not_follow.Text = "Not Follow";
            this.tc_main_not_follow.UseVisualStyleBackColor = true;
            // 
            // lpd_notfollow
            // 
            this.lpd_notfollow.AutoScroll = true;
            this.lpd_notfollow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpd_notfollow.Location = new System.Drawing.Point(0, 0);
            this.lpd_notfollow.Name = "lpd_notfollow";
            this.lpd_notfollow.Size = new System.Drawing.Size(833, 244);
            this.lpd_notfollow.TabIndex = 0;
            // 
            // tc_main_notfollowback
            // 
            this.tc_main_notfollowback.Controls.Add(this.lpd_notfollowback);
            this.tc_main_notfollowback.Location = new System.Drawing.Point(4, 22);
            this.tc_main_notfollowback.Name = "tc_main_notfollowback";
            this.tc_main_notfollowback.Size = new System.Drawing.Size(833, 244);
            this.tc_main_notfollowback.TabIndex = 3;
            this.tc_main_notfollowback.Text = "Not Followback";
            this.tc_main_notfollowback.UseVisualStyleBackColor = true;
            // 
            // lpd_notfollowback
            // 
            this.lpd_notfollowback.AutoScroll = true;
            this.lpd_notfollowback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpd_notfollowback.Location = new System.Drawing.Point(0, 0);
            this.lpd_notfollowback.Name = "lpd_notfollowback";
            this.lpd_notfollowback.Size = new System.Drawing.Size(833, 244);
            this.lpd_notfollowback.TabIndex = 0;
            // 
            // tc_main_safe_follow
            // 
            this.tc_main_safe_follow.Controls.Add(this.lpd_alwaysfollow);
            this.tc_main_safe_follow.Location = new System.Drawing.Point(4, 22);
            this.tc_main_safe_follow.Name = "tc_main_safe_follow";
            this.tc_main_safe_follow.Size = new System.Drawing.Size(833, 244);
            this.tc_main_safe_follow.TabIndex = 4;
            this.tc_main_safe_follow.Text = "Always Follow";
            this.tc_main_safe_follow.UseVisualStyleBackColor = true;
            // 
            // lpd_alwaysfollow
            // 
            this.lpd_alwaysfollow.AutoScroll = true;
            this.lpd_alwaysfollow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpd_alwaysfollow.Location = new System.Drawing.Point(0, 0);
            this.lpd_alwaysfollow.Name = "lpd_alwaysfollow";
            this.lpd_alwaysfollow.Size = new System.Drawing.Size(833, 244);
            this.lpd_alwaysfollow.TabIndex = 0;
            // 
            // tc_main_fav
            // 
            this.tc_main_fav.Controls.Add(this.lpd_favorite);
            this.tc_main_fav.Location = new System.Drawing.Point(4, 22);
            this.tc_main_fav.Name = "tc_main_fav";
            this.tc_main_fav.Size = new System.Drawing.Size(833, 244);
            this.tc_main_fav.TabIndex = 5;
            this.tc_main_fav.Text = "Favorite";
            this.tc_main_fav.UseVisualStyleBackColor = true;
            // 
            // lpd_favorite
            // 
            this.lpd_favorite.AutoScroll = true;
            this.lpd_favorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpd_favorite.Location = new System.Drawing.Point(0, 0);
            this.lpd_favorite.Name = "lpd_favorite";
            this.lpd_favorite.Size = new System.Drawing.Size(833, 244);
            this.lpd_favorite.TabIndex = 0;
            // 
            // ts_main
            // 
            this.ts_main.BaseTabControl = this.tc_main;
            this.ts_main.Depth = 0;
            this.ts_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ts_main.Location = new System.Drawing.Point(0, 225);
            this.ts_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(841, 38);
            this.ts_main.TabIndex = 1;
            this.ts_main.Text = "materialTabSelector1";
            // 
            // lbl_refresh
            // 
            this.lbl_refresh.AutoSize = true;
            this.lbl_refresh.BackColor = System.Drawing.Color.Transparent;
            this.lbl_refresh.Depth = 0;
            this.lbl_refresh.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_refresh.Location = new System.Drawing.Point(101, 33);
            this.lbl_refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_refresh.Name = "lbl_refresh";
            this.lbl_refresh.Size = new System.Drawing.Size(60, 19);
            this.lbl_refresh.TabIndex = 2;
            this.lbl_refresh.Text = "Refresh";
            this.lbl_refresh.Click += new System.EventHandler(this.lbl_refresh_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 533);
            this.Controls.Add(this.lbl_refresh);
            this.Controls.Add(this.ts_main);
            this.Controls.Add(this.tc_main);
            this.Name = "frm_main";
            this.Sizable = false;
            this.Text = "iWorm - IG";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.SizeChanged += new System.EventHandler(this.frm_main_SizeChanged);
            this.tc_main.ResumeLayout(false);
            this.tc_main_follower.ResumeLayout(false);
            this.tc_main_following.ResumeLayout(false);
            this.tc_main_not_follow.ResumeLayout(false);
            this.tc_main_notfollowback.ResumeLayout(false);
            this.tc_main_safe_follow.ResumeLayout(false);
            this.tc_main_fav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tc_main;
        private System.Windows.Forms.TabPage tc_main_follower;
        private System.Windows.Forms.TabPage tc_main_following;
        private MaterialSkin.Controls.MaterialTabSelector ts_main;
        private System.Windows.Forms.TabPage tc_main_not_follow;
        private System.Windows.Forms.TabPage tc_main_notfollowback;
        private System.Windows.Forms.TabPage tc_main_safe_follow;
        private System.Windows.Forms.TabPage tc_main_fav;
        private ListProfileDetail lpd_follower;
        private ListProfileDetail lpd_following;
        private ListProfileDetail lpd_notfollow;
        private ListProfileDetail lpd_notfollowback;
        private ListProfileDetail lpd_alwaysfollow;
        private ListProfileDetail lpd_favorite;
        private MaterialSkin.Controls.MaterialLabel lbl_refresh;
    }
}