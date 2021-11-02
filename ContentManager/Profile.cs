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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContentManager
{
    public partial class Profile : UserControl
    {

        private int bottom = 0; 
        public Profile()
        {
            InitializeComponent();
        }
        private void AddProfileItem(PostItem pf )
        {
           
            pf.Top = bottom;
            bottom = pf.Bottom + 3;
            this.Controls.Add(pf);
        }
        
        private void Profile_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User.Posts.Count() ==0 )
            {
                
                return;
            }
            foreach (var item in CurrentUser.User.Posts)
            {
                AddProfileItem(new PostItem(item, this.Width , false));
                //var frm = new ProfileItem(item , this.Width);
                //frm.Top = bottom;
                //bottom = frm.Bottom+3;
                //this.Controls.Add(frm);

            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var frm = new ProfileNewTwitt();
            frm.ShowDialog();
            var post = frm.SendedPost();
            if(post !=null) AddProfileItem(new PostItem(post, this.Width ,false));
            this.Refresh();
        }
    }
}
