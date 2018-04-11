namespace iWorm_Instagram
{
    partial class frm_detail
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
            this.lbl_username = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_fullname = new MaterialSkin.Controls.MaterialLabel();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.lbl_follower = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_following = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_post = new MaterialSkin.Controls.MaterialLabel();
            this.pic_bestpost = new System.Windows.Forms.PictureBox();
            this.txt_comment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_like = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_comment = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_lastpost = new MaterialSkin.Controls.MaterialLabel();
            this.btn_follow = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bestpost)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Depth = 0;
            this.lbl_username.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_username.Location = new System.Drawing.Point(168, 76);
            this.lbl_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(77, 19);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Depth = 0;
            this.lbl_fullname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_fullname.Location = new System.Drawing.Point(168, 95);
            this.lbl_fullname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(70, 19);
            this.lbl_fullname.TabIndex = 1;
            this.lbl_fullname.Text = "Fullname";
            // 
            // pic_user
            // 
            this.pic_user.Location = new System.Drawing.Point(12, 76);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(150, 150);
            this.pic_user.TabIndex = 2;
            this.pic_user.TabStop = false;
            // 
            // lbl_follower
            // 
            this.lbl_follower.AutoSize = true;
            this.lbl_follower.Depth = 0;
            this.lbl_follower.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_follower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_follower.Location = new System.Drawing.Point(168, 114);
            this.lbl_follower.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_follower.Name = "lbl_follower";
            this.lbl_follower.Size = new System.Drawing.Size(79, 19);
            this.lbl_follower.TabIndex = 3;
            this.lbl_follower.Text = "0 Follower";
            // 
            // lbl_following
            // 
            this.lbl_following.AutoSize = true;
            this.lbl_following.Depth = 0;
            this.lbl_following.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_following.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_following.Location = new System.Drawing.Point(168, 133);
            this.lbl_following.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_following.Name = "lbl_following";
            this.lbl_following.Size = new System.Drawing.Size(86, 19);
            this.lbl_following.TabIndex = 4;
            this.lbl_following.Text = "0 Following";
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Depth = 0;
            this.lbl_post.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_post.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_post.Location = new System.Drawing.Point(168, 152);
            this.lbl_post.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(52, 19);
            this.lbl_post.TabIndex = 5;
            this.lbl_post.Text = "0 Post";
            // 
            // pic_bestpost
            // 
            this.pic_bestpost.Location = new System.Drawing.Point(328, 76);
            this.pic_bestpost.Name = "pic_bestpost";
            this.pic_bestpost.Size = new System.Drawing.Size(150, 150);
            this.pic_bestpost.TabIndex = 6;
            this.pic_bestpost.TabStop = false;
            // 
            // txt_comment
            // 
            this.txt_comment.Depth = 0;
            this.txt_comment.Hint = "Comment Text";
            this.txt_comment.Location = new System.Drawing.Point(484, 98);
            this.txt_comment.MaxLength = 32767;
            this.txt_comment.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.PasswordChar = '\0';
            this.txt_comment.SelectedText = "";
            this.txt_comment.SelectionLength = 0;
            this.txt_comment.SelectionStart = 0;
            this.txt_comment.Size = new System.Drawing.Size(201, 23);
            this.txt_comment.TabIndex = 7;
            this.txt_comment.TabStop = false;
            this.txt_comment.UseSystemPasswordChar = false;
            // 
            // btn_like
            // 
            this.btn_like.AutoSize = true;
            this.btn_like.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_like.Depth = 0;
            this.btn_like.Icon = null;
            this.btn_like.Location = new System.Drawing.Point(582, 125);
            this.btn_like.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_like.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_like.Name = "btn_like";
            this.btn_like.Primary = false;
            this.btn_like.Size = new System.Drawing.Size(49, 36);
            this.btn_like.TabIndex = 8;
            this.btn_like.Text = "Like";
            this.btn_like.UseVisualStyleBackColor = true;
            this.btn_like.Click += new System.EventHandler(this.btn_like_Click);
            // 
            // btn_comment
            // 
            this.btn_comment.AutoSize = true;
            this.btn_comment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_comment.Depth = 0;
            this.btn_comment.Icon = null;
            this.btn_comment.Location = new System.Drawing.Point(485, 125);
            this.btn_comment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_comment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Primary = false;
            this.btn_comment.Size = new System.Drawing.Size(89, 36);
            this.btn_comment.TabIndex = 9;
            this.btn_comment.Text = "Comment";
            this.btn_comment.UseVisualStyleBackColor = true;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // lbl_lastpost
            // 
            this.lbl_lastpost.AutoSize = true;
            this.lbl_lastpost.Depth = 0;
            this.lbl_lastpost.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_lastpost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_lastpost.Location = new System.Drawing.Point(484, 76);
            this.lbl_lastpost.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_lastpost.Name = "lbl_lastpost";
            this.lbl_lastpost.Size = new System.Drawing.Size(73, 19);
            this.lbl_lastpost.TabIndex = 10;
            this.lbl_lastpost.Text = "Last Post";
            // 
            // btn_follow
            // 
            this.btn_follow.AutoSize = true;
            this.btn_follow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_follow.Depth = 0;
            this.btn_follow.Icon = null;
            this.btn_follow.Location = new System.Drawing.Point(169, 190);
            this.btn_follow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_follow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_follow.Name = "btn_follow";
            this.btn_follow.Primary = false;
            this.btn_follow.Size = new System.Drawing.Size(111, 36);
            this.btn_follow.TabIndex = 0;
            this.btn_follow.Text = "Follow User";
            this.btn_follow.UseVisualStyleBackColor = true;
            this.btn_follow.Click += new System.EventHandler(this.btn_follow_Click);
            // 
            // frm_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 239);
            this.Controls.Add(this.btn_follow);
            this.Controls.Add(this.lbl_lastpost);
            this.Controls.Add(this.btn_comment);
            this.Controls.Add(this.btn_like);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.pic_bestpost);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.lbl_following);
            this.Controls.Add(this.lbl_follower);
            this.Controls.Add(this.pic_user);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.lbl_username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_detail";
            this.Text = "frm_detail";
            this.Load += new System.EventHandler(this.frm_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bestpost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialLabel lbl_username;
        public MaterialSkin.Controls.MaterialLabel lbl_fullname;
        public System.Windows.Forms.PictureBox pic_user;
        public MaterialSkin.Controls.MaterialLabel lbl_follower;
        public MaterialSkin.Controls.MaterialLabel lbl_following;
        public MaterialSkin.Controls.MaterialLabel lbl_post;
        public System.Windows.Forms.PictureBox pic_bestpost;
        public MaterialSkin.Controls.MaterialSingleLineTextField txt_comment;
        public MaterialSkin.Controls.MaterialFlatButton btn_like;
        public MaterialSkin.Controls.MaterialFlatButton btn_comment;
        public MaterialSkin.Controls.MaterialLabel lbl_lastpost;
        public MaterialSkin.Controls.MaterialFlatButton btn_follow;
    }
}