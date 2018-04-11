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
    public partial class ProfileDetail : UserControl
    {
        
        private string id = "";
        private MaterialSkin.Controls.MaterialContextMenuStrip mnu;
        public string Username { set { lbl_username.Text = value; } get { return lbl_username.Text; } }
        public string Fullname { set { lbl_fullname.Text = value; } get { return lbl_fullname.Text; } }
        public string Picture { set { pic_profile.ImageLocation = value; } get { return pic_profile.ImageLocation; } }
        public string Id { set { id = value; } get { return id; } }
        public delegate void GetId(object sender, string id, string menu);
        public event GetId GetDetail;

        public delegate void ShowUser(object sender, string id);
        public event ShowUser ShowDetailUser;
        public ProfileDetail()
        {
            InitializeComponent();
            lbl_fullname.MouseClick += profile_Click;
            lbl_username.MouseClick += profile_Click;
            pic_profile.MouseClick += profile_Click;
            this.MouseClick += profile_Click;
        }

        private void profile_Click(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
                if (ShowDetailUser != null)
                    ShowDetailUser(this, this.id);
        }

        
        public void SetMenu(MaterialSkin.Controls.MaterialContextMenuStrip menu)
        {
            this.mnu = menu;
            this.mnu.ItemClicked += Mnu_ItemClicked;
            pic_profile.MouseClick += Pic_profile_MouseClick;
        }

        private void Pic_profile_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            mnu.Show(new Point(MousePosition.X, MousePosition.Y));
        }

        private void Mnu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (GetDetail != null)
                GetDetail(this,this.id, e.ClickedItem.Text);
        }
    }
}
