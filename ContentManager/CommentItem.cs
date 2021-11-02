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
    public partial class CommentItem : UserControl
    {
        public CommentItem(CommentDto commentDto)
        {
            InitializeComponent();

            lblComment.Text = commentDto.Content;
            lblDate.Text = "By " + commentDto.User.Firstname + " " + commentDto.User.Lastname+" On"+commentDto.Date.ToString();

            this.Cursor = Cursors.Default;

        }

    }
}
