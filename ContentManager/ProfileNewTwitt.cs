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
    public partial class ProfileNewTwitt : Form
    {
        private readonly PostService _postService;
        private PostDto postDto;
        public ProfileNewTwitt()
        {
            InitializeComponent();
            _postService = new PostService();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            postDto = new PostDto(txtContent.Text, txtTitle.Text, DateTime.Now, CurrentUser.User.ID);
            var res = _postService.Insert(postDto);
            if (res)
            {
                this.Close();
                
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        public PostDto SendedPost()
        {
            return postDto;
            
        }
    }
}
