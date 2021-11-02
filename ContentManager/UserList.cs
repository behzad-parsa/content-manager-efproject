using ContentManager.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManager
{
    public partial class UserList : UserControl
    {
        Stopwatch stopwatch = new Stopwatch();
        private readonly UserService _userService;
        private readonly RoleService _roleService;
       private int bottom = 0;
        //List<UserItem> userItemList = new List<UserItem>();
        public UserList()
        {
            InitializeComponent();
            _userService = new UserService();
            _roleService = new RoleService();

        }
        private void Loading()
        {
            //this.Controls.GetChildIndex()
            
            stopwatch.Start();

            pnlUserlist.Controls.Clear();
            //Getting Role From DB
            var roles = _roleService.GetAll();
            comboBox1.DataSource = roles.ToList();
            comboBox1.DisplayMember = "Title";


            
            var userList = _userService.GetAll();
            if (userList.Count() == 0)
            {
                pnlUserlist.Controls.Add(new Label() { Text = "Empty", Location = new Point(20, 20), AutoSize = true, Top = 20 });
                return;

            }
            foreach (var item in userList)
            {

                UserItem userItem = new UserItem(item);
                userItem.Top = bottom;
                pnlUserlist.Controls.Add(userItem);

                bottom = userItem.Bottom;

                //this.Controls.GetChildIndex(userItem);
                //MessageBox.Show(this.pnlUserlist.Controls.IndexOf(userItem).ToString());

                //userItemList.Add(userItem);
               
            }
            stopwatch.Stop();
            MessageBox.Show(stopwatch.ElapsedMilliseconds.ToString() +"   |     "+stopwatch.Elapsed.TotalSeconds.ToString());
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblBirthday.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void lblSub_Click(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
            {
                if ((item.GetType() == typeof(TextBox) && string.IsNullOrEmpty((item as TextBox).Text)))
                {
                    MessageBox.Show("the Textbox Can't Be Null");
                    return;
                }

            }
            var userDto = new UserDTO(txtFirst.Text, txtLast.Text, txtUsername.Text, txtPass.Text, monthCalendar1.SelectionStart.Date, ((comboBox1.SelectedItem) as RoleDto).ID , new RoleDto());
            var res = _userService.Insert(userDto);
            if (res.Item1)
            {
                MessageBox.Show("SUCCCESSSSSSSSS");
                //First Way TO Dynamic Adding In User List at the momment With conection TO DB and Take Time As 2 Sec

                //Loading();

                //Second Way Without Connecting TO DB
                //stopwatch.Start();
                 userDto.Role.Title = comboBox1.Text;
                userDto.ID = res.Item2;
                 UserItem userItem = new UserItem(userDto);
                 userItem.Top = pnlUserlist.Controls[pnlUserlist.Controls.Count - 1].Bottom;
                
                 pnlUserlist.Controls.Add(userItem);

                 bottom = userItem.Bottom;
                this.Refresh();
                //stopwatch.Stop();

                MessageBox.Show(stopwatch.ElapsedMilliseconds.ToString() + "    |     " + stopwatch.Elapsed.TotalSeconds.ToString());
                


            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var o = comboBox1.SelectedItem;
            //MessageBox.Show( (o as RoleDto).ID.ToString());
        }

        private void pnlUserlist_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
