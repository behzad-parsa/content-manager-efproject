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
    public partial class Home : UserControl
    {
        private PostService postService;
        public Home()
        {
            InitializeComponent();
        }
        private int bottom = 0;
        private void AddProfileItem(PostItem pf)
        {

            pf.Top = bottom;
            bottom = pf.Bottom + 3;
            this.Controls.Add(pf);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //vScrollBar1.Scroll += (sender, e) => { panel1.VerticalScroll.Value = vScrollBar1.Value; };

            postService = new PostService();

            var allPostes = postService.GetAll().OrderByDescending(u=>u.Date);

            if (allPostes.Count() == 0) return;
            foreach (var item in allPostes)
            {
               AddProfileItem(new PostItem(item, this.Width, true));

            }
        
        }
    }
}
