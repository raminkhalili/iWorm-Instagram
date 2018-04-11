using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iWorm_Instagram
{
    public partial class ListProfileDetail : UserControl
    {

        private List<ProfileDetail> profiles;// { set { profiles = value; }get { return profiles; } }
        public ProfileDetail profile ;
        public ListProfileDetail()
        {
            InitializeComponent();
            profiles = new List<ProfileDetail>();
        }
      public void reset()
        {
            profiles = new List<ProfileDetail>();
        }
        public ListProfileDetail(List<ProfileDetail> profiles)
        {
            InitializeComponent();
            this.profiles = profiles;
            refresh();
        }
        public bool searchById(string id)
        {
            for (int i = 0; i < this.profiles.Count; i++)
            {
                if (id == this.profiles[i].Id)
                    return true;
            }
            return false;
        }
        public ProfileDetail getProfileDetailById(string id)
        {
            for (int i = 0; i < this.profiles.Count; i++)
            {
                if (id == this.profiles[i].Id)
                    return this.profiles[i];
            }
            return this.profile;
        }
        public void add(ProfileDetail profile,string[] menu)
        {
            MaterialSkin.Controls.MaterialContextMenuStrip men = new MaterialSkin.Controls.MaterialContextMenuStrip();
            for (int i = 0; i < menu.Length; i++)
                men.Items.Add(menu[i]);
            profile.SetMenu(men);
            this.profiles.Add(profile);
        }
        public void remove(ProfileDetail profile)
        {
            this.profiles.Remove(profile);
        }
        public void refresh()
        {
            ProfileDetail pr = new ProfileDetail();
            int top=10, left=10,mainWidth=this.Size.Width,profileWidth=pr.Size.Width,profileHeight=pr.Size.Height;
            this.Controls.Clear();
            Point point= new Point();
            for (int i=0,j=0,k=0;i<this.profiles.Count;i++,j++)
            {
                point.X = (j * profileWidth) + (left*(j+1));
                point.Y = (k * Height) + (top * (k + 1));
                this.profiles[i].Location = point;
                this.Controls.Add(profiles[i]);
                if ((j * profileWidth) + (j * left) > this.Size.Width)
                {
                    k++;
                    j = 0;
                }
            }
        }

        private void ListProfileDetail_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
