using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace iWorm_Instagram
{
    public partial class frm_main : MaterialForm
    {
        public string token = "";
        InstagramFollows dataFollowing;
        InstagramFollows dataFollower;
        Timer tm_refresh;
        public frm_main()
        {
            
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);
            tm_refresh = new Timer();
            tm_refresh.Interval = 600000;
            tm_refresh.Enabled = true;
            tm_refresh.Tick += Tm_refresh_Tick;
            
        }

        private void Tm_refresh_Tick(object sender, EventArgs e)
        {
            lbl_refresh.Enabled = true;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
           
            lbl_refresh.ForeColor = Color.LawnGreen;
            tc_main.Height = this.Height - 99;
            dataFollowing = null;
            dataFollower = null;

            lpd_follower.Controls.Clear();
            lpd_following.Controls.Clear();
            lpd_notfollow.Controls.Clear();
            lpd_notfollowback.Controls.Clear();
            lpd_alwaysfollow.Controls.Clear();
            lpd_favorite.Controls.Clear();

            lpd_follower.reset();
            lpd_following.reset();
            lpd_notfollow.reset();
            lpd_notfollowback.reset();
            lpd_alwaysfollow.reset();
            lpd_favorite.reset();
            try
            {

                WebClient client = new WebClient();
                Stream stm = client.OpenRead("https://api.instagram.com/v1/users/self/follows?access_token=" + this.token);
                StreamReader str = new StreamReader(stm);
                this.dataFollowing = JsonConvert.DeserializeObject<InstagramFollows>(str.ReadToEnd());
                ProfileDetail profile;
                str.Close();
                stm.Close();
                //for insert in follow
                
                for (int i = 0; i < dataFollowing.data.Length; i++)
                {
                    profile = new ProfileDetail();
                    profile.Username = dataFollowing.data[i].username;
                    profile.Fullname = dataFollowing.data[i].full_name;
                    profile.Picture = dataFollowing.data[i].profile_picture;
                    profile.Id = dataFollowing.data[i].id;
                    profile.Name = "Profile" + i;
                    this.lpd_following.add(profile, new string[] { "Unfollow", "Add to Always Follow", "Add To Favorite" });
                    profile.GetDetail += Profile_GetDetail;
                    profile.ShowDetailUser += Profile_ShowDetailUser;
                    this.lpd_following.refresh();
                }
                stm = client.OpenRead("https://api.instagram.com/v1/users/self/followed-by?access_token=" + this.token);
                str = new StreamReader(stm);
                this.dataFollower = JsonConvert.DeserializeObject<InstagramFollows>(str.ReadToEnd());

                //for insert follower
                for (int i = 0; i < dataFollower.data.Length; i++)
                {
                    profile = new ProfileDetail();
                    profile.Username = dataFollower.data[i].username;
                    profile.Fullname = dataFollower.data[i].full_name;
                    profile.Picture = dataFollower.data[i].profile_picture;
                    profile.Id = dataFollower.data[i].id;
                    profile.Name = "Profile" + i;
                    this.lpd_follower.add(profile, new string[] { "Add to Always Follow", "Add To Favorite" });
                    profile.GetDetail += Profile_GetDetail;
                    profile.ShowDetailUser += Profile_ShowDetailUser;
                    this.lpd_follower.refresh();
                }



                //for not follow
                bool has = false;
                for (int i = 0; i < dataFollower.data.Length; i++)
                {
                    has = false;
                    for (int j = 0; j < dataFollowing.data.Length; j++)
                    {
                        if (dataFollower.data[i].id == dataFollowing.data[j].id)
                            has = true;
                    }
                    if (!has)
                    {
                        profile = new ProfileDetail();
                        profile.Username = dataFollower.data[i].username;
                        profile.Fullname = dataFollower.data[i].full_name;
                        profile.Picture = dataFollower.data[i].profile_picture;
                        profile.Id = dataFollower.data[i].id;
                        profile.Name = "Profile" + i;
                        this.lpd_notfollow.add(profile, new string[] { "Follow", "Add to Always Follow", "Add To Favorite" });
                        profile.GetDetail += Profile_GetDetail;
                        profile.ShowDetailUser += Profile_ShowDetailUser;
                        this.lpd_notfollow.refresh();
                    }
                }


                //


                for (int i = 0; i < dataFollowing.data.Length; i++)
                {
                    has = false;
                    for (int j = 0; j < dataFollower.data.Length; j++)
                    {
                        if (dataFollower.data[j].id == dataFollowing.data[i].id)
                            has = true;
                    }
                    if (!has)
                    {
                        profile = new ProfileDetail();
                        profile.Username = dataFollowing.data[i].username;
                        profile.Fullname = dataFollowing.data[i].full_name;
                        profile.Picture = dataFollowing.data[i].profile_picture;
                        profile.Id = dataFollowing.data[i].id;
                        profile.Name = "Profile" + i;
                        this.lpd_notfollowback.add(profile, new string[] { "Unfollow", "Add to Always Follow", "Add To Favorite" });
                        profile.GetDetail += Profile_GetDetail;
                        profile.ShowDetailUser += Profile_ShowDetailUser;
                        this.lpd_notfollowback.refresh();
                    }
                }

            }
            catch
            {
                tc_main_follower.Controls.Clear();
                MaterialLabel lbl_none = new MaterialLabel();
                lbl_none.Text = @"Please Checked Internet Connection or Login Failed Instagram.";
                lbl_none.Width = lbl_none.Text.Length * 10;
                tc_main_follower.Controls.Add(lbl_none);

            }
        }

        private void Profile_ShowDetailUser(object sender, string id)
        { 
            frm_detail detail = new frm_detail();
            detail.id = id;
            detail.token = this.token;
            detail.ShowDialog();
            if(detail.refresh)
                lbl_refresh_Click(this,EventArgs.Empty);
        }

        private void Profile_GetDetail(object sender, string id, string menu)
        {
            ProfileDetail pf = sender as ProfileDetail;
            ProfileDetail profile;
            menu = menu.Trim();
            switch (menu)
            {
                case "Unfollow":
                    lpd_notfollowback.remove(lpd_notfollowback.getProfileDetailById(id));
                    lpd_notfollowback.refresh();
                    lpd_following.remove(lpd_following.getProfileDetailById(id));
                    Instagram.Unfollow(id, this.token);
                    lpd_following.refresh();
                    if (lpd_follower.searchById(id))
                    {
                        profile = new ProfileDetail();
                        profile.Username = pf.Username;
                        profile.Fullname = pf.Fullname;
                        profile.Picture = pf.Picture;
                        profile.Id = pf.Id;
                        profile.Name = "Profile";
                        this.lpd_notfollow.add(profile, new string[] { "Follow", "Add to Always Follow", "Add To Favorite" });
                        profile.GetDetail += Profile_GetDetail;
                        this.lpd_notfollow.refresh();
                    }

                    break;
                case "Follow":
                    lpd_following.add(pf, new string[] { "Unfollow", "Add to Always Follow", "Add To Favorite" });
                    Instagram.Follow(id, this.token);
                    lpd_notfollow.remove(pf);
                    lpd_following.refresh();
                    lpd_notfollow.refresh();
                    break;
                case "Add To Favorite":
                    if (this.lpd_favorite.searchById(id))
                        break;
                    profile = new ProfileDetail();
                    profile.Username = pf.Username;
                    profile.Id = pf.Id;
                    profile.Picture = pf.Picture;
                    profile.Fullname = pf.Fullname;
                    lpd_favorite.add(profile, new string[] { "Remove on Favorite" });
                    profile.GetDetail += Profile_GetDetail;
                    lpd_favorite.refresh();
                    lpd_follower.refresh();
                    break;
                case "Remove on Favorite":
                    lpd_favorite.remove(pf);
                    lpd_favorite.refresh();
                    break;
                case "Add to Always Follow":
                    if (this.lpd_alwaysfollow.searchById(id))
                        break;
                    profile = new ProfileDetail();
                    profile.Username = pf.Username;
                    profile.Id = pf.Id;
                    profile.Picture = pf.Picture;
                    profile.Fullname = pf.Fullname;
                    lpd_alwaysfollow.add(profile, new string[] { "Remove on Always Follow" });
                    profile.GetDetail += Profile_GetDetail;
                    lpd_alwaysfollow.refresh();
                    lpd_alwaysfollow.refresh();
                    break;

            }
        }

        private void frm_main_SizeChanged(object sender, EventArgs e)
        {
            tc_main.Height = this.Height - 99;
        }

  

        private void lbl_refresh_Click(object sender, EventArgs e)
        {
            frm_main_Load(sender, e);
            tm_refresh.Stop();
            tm_refresh.Start();
            lbl_refresh.Enabled = false;
        }

    
    }
}
