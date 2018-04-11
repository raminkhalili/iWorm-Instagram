using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class frm_login : MaterialForm
    {
        private string token = "", secret= "", client_id = "", redirect_uri = "";

        private void btn_letsgo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main main = new frm_main();
            main.token = this.token;
            main.Show();
        }

        public frm_login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            
            //Process.Start("RunDll32.exe","InetCpl.cpl,ClearMyTracksByProcess 2");
            login_insta.Navigate("https://www.instagram.com/oauth/authorize/?client_id=" + client_id + "&redirect_uri=" + redirect_uri + "&response_type=token&scope=basic+likes+comments+relationships+follower_list+public_content");
        }


        private void login_insta_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

         
            if (e.Url.ToString().Length>31)
                if (e.Url.ToString().Substring(0, 31) == "http://localhost/#access_token=")
                {
                    this.token = e.Url.ToString().Substring(31);
                    WebClient client = new WebClient();
                    Stream stm = client.OpenRead("https://api.instagram.com/v1/users/self/?access_token=" + this.token);
                    StreamReader str = new StreamReader(stm);
                    var jso = JsonConvert.DeserializeObject<InstagramInformation>(str.ReadToEnd());
                    if (jso.meta.code == 200)
                    {
                        login_insta.Visible = false;
                        pic_profile.Visible = true;
                        pic_profile.ImageLocation = jso.data.profile_picture;
                        lbl_status.Text = "Full Name : " + jso.data.full_name+ "\nUsername : " +jso.data.username + "\nPost : " + jso.data.counts.media + "\nFollower : " + jso.data.counts.follows + "\nFollowing : " + jso.data.counts.followed_by;
                        btn_letsgo.Enabled = true;
                    }
                }
           /* }
            catch
            {
                login_insta.Navigate("https://www.instagram.com/oauth/authorize/?client_id=" + client_id + "&redirect_uri=" + redirect_uri + "&response_type=token&scope=basic+likes+comments+relationships+follower_list+public_content");
                MessageBox.Show("hey");
            }*/

        }

    }

}
