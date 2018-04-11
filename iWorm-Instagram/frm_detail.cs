using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace iWorm_Instagram
{
    public partial class frm_detail : MaterialForm
    {
        public string id, token,post_id;
        public bool refresh=false;
        private RelationshipData rel;
        public frm_detail()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btn_comment_Click(object sender, EventArgs e)
        {
            if(txt_comment.Text.Length>20)
            {
                MessageBox.Show("Comment Length most betwen 0-20 character.");
                return;
            }
            Instagram.Comment(this.post_id, this.token, txt_comment.Text);
        }

        private void btn_like_Click(object sender, EventArgs e)
        {
            switch (btn_like.Text)
            {
                case "Like":
                    Instagram.Like(post_id, token);
                    btn_like.Text = "Remove Like";
                    break;
                case "Remove Like":
                    Instagram.RemoveLike(post_id, token);
                    btn_like.Text = "Like";
                    break;
            }
        }

    
        private void frm_detail_Load(object sender, EventArgs e)
        {
      
               
                WebClient client = new WebClient();
                Stream stm = client.OpenRead("https://api.instagram.com/v1/users/"+this.id+"/?access_token=" + this.token);
                StreamReader str = new StreamReader(stm);
                var user = JsonConvert.DeserializeObject<InstagramInformation>(str.ReadToEnd());
                this.Text =user.data.full_name;
                pic_user.ImageLocation = user.data.profile_picture;
                lbl_username.Text = user.data.username;
                lbl_fullname.Text = user.data.full_name;
                lbl_follower.Text = user.data.counts.followed_by.ToString() + " Follower";
                lbl_following.Text = user.data.counts.follows.ToString() + " Following";
                lbl_post.Text = user.data.counts.media.ToString() + " Post";
                stm.Close();
                str.Close();
                stm = client.OpenRead("https://api.instagram.com/v1/users/" + this.id + "/relationship?access_token=" + this.token);
                str = new StreamReader(stm);
                rel = JsonConvert.DeserializeObject<RelationshipData>(str.ReadToEnd());
            
                switch (rel.data.outgoing_status)
                {
                    case "follows":
                        btn_follow.Text = "Unfollow";
                        break;
                    case "requested":
                        btn_follow.Text = "Cancel Request";
                        break;
                    case "none":
                        btn_follow.Text = "Follow";
                        break;
                }

            stm.Close();
            str.Close();
            stm = client.OpenRead("https://api.instagram.com/v1/users/"+this.id+"/media/recent/?access_token="+this.token+"&count=1");
            str = new StreamReader(stm);
            Post post = JsonConvert.DeserializeObject<Post>(str.ReadToEnd());
            pic_bestpost.ImageLocation = post.data[0].images.thumbnail.url;
            this.post_id = post.data[0].id;
            if (post.data[0].user_has_liked)
                btn_like.Text = "Remove Like";
            else
                btn_like.Text = "Like";
        }

        private void btn_follow_Click(object sender, EventArgs e)
        {
            switch (btn_follow.Text)
            {
                case "Follow":
                    Instagram.Follow(id, token);
                    if (rel.data.target_user_is_private)
                        btn_follow.Text = "Cancel Request";
                    else
                        btn_follow.Text = "Unfollow";
                    break;
                case "Unfollow":
                    Instagram.Unfollow(id, token);
                    btn_follow.Text = "Follow";
                    break;


            }
            refresh = true;
        }

       
    }
}
