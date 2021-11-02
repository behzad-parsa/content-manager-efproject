using ContentManager.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManager
{
    public partial class PostItem : UserControl
    {
        private PostDto postDto;
        public PostItem(PostDto post , int width , bool isHome)
        {
            InitializeComponent();

            lblTitle.Text = post.Title;
            lblContent.Text = post.Content;
            lblDate.Text = post.Date.ToString();
            if (isHome) lblDate.Text +=  "    Sended By : " + post.User.Firstname + " " + post.User.Lastname;
            lblComment.Text = ((post.Comments == null) ? string.Format("0") : post.Comments.Count().ToString())  + " " + "Comment";
            
           this.Width = width;

            postDto = post;
        }

        private void lblComment_Click(object sender, EventArgs e)
        {

        }

        private void ProfileItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void ProfileItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void PostItem_Load(object sender, EventArgs e)
        {

        }

        private void PostItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var frmCommnet = new CommentPage(postDto);
            frmCommnet.Show();
        }
    }
}
