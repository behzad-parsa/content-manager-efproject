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
    public partial class CommentPage : Form
    {
        private PostDto postDto;
        private CommentService commentService;
        public CommentPage(PostDto postDto)
        {
            InitializeComponent();
            this.postDto = postDto;
            commentService = new CommentService();

        }
        private void AddProfileItem(CommentItem pf)
        {

            pf.Top = bottom;
            bottom = pf.Bottom + 1;
            pnlBottom.Controls.Add(pf);
        }

        int bottom = 0; 
        private void CommentPage_Load(object sender, EventArgs e)
        {

            foreach (var item in postDto.Comments)
            {
                AddProfileItem(new CommentItem(item));

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var comDto = new CommentDto(txtComment.Text, DateTime.Now, CurrentUser.User.ID, postDto.ID);
            var res = commentService.Insert(comDto);
            if (res) MessageBox.Show("Success");
            comDto.User = CurrentUser.User;
            AddProfileItem(new CommentItem(comDto));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
