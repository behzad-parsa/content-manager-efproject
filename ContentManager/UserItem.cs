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
    public partial class UserItem : UserControl
    {
        private UserDTO userDto;
        private UserService userService;
        private CommentService commentService;
        public UserItem(UserDTO userDto)
        {
            //MessageBox.Show(this.Name);
            InitializeComponent();
            userService = new UserService();
            commentService = new CommentService();

            lblName.Text = userDto.Firstname + "   " + userDto.Lastname;
            lblBirth.Text = userDto.Birth.Date.ToString("yyyy/dd/MMMM");
            lblRole.Text = userDto.Role.Title;
            this.userDto = userDto;
        }

        private void UserItem_Load(object sender, EventArgs e)
        {

        }

        private void UserItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void UserItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void UserItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lblDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(userDto.Comments != null &&  userDto.Comments.Count()  >0  ) commentService.DeleteRange(userDto);
            
            var res = userService.Delete(userDto.ID);
            if (res)
            {
                MessageBox.Show("Succcceeesss");
                //this.Controls.Remove(this);
                var index =this.Parent.Controls.IndexOf(this) +1 ;
                int top = this.Top;
                //var next = this.GetNextControl();


                // For fix the postion of Item After Deelete We Have Two Way
                //one nvaigate and change top 
                //two  top of each useritem - height

                int count = this.Parent.Controls.Count ;


                // one 
                //while (index < count && index + 1 < count) 
                //{
                //    this.Parent.Controls[index + 1].Top = this.Parent.Controls[index].Top;
                //    this.Parent.Controls[index].Top = top;


                //    index++;

                //} 


                //two

                while (index < count )
                {
                    
                    this.Parent.Controls[index].Top -=92 ;


                    index++;

                }


                this.Parent.Controls.Remove(this);








            }
        }

        private void UserItem_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(this.Parent.Controls.IndexOf(this).ToString());
        }
    }
}
