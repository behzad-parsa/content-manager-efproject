using ContentManager.Context;
using ContentManager.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var frm = new SignedUser();
            pnlTop.Controls.Add(frm);
            UserService u = new UserService();
            var user = u.GetByUsername("behzad.p1996").Item1;
            CurrentUser.User = user;
           // CurrentUser.ID = 4;

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MainContext>());

            // MainContext m = new MainContext();

            //  m.Users.Find(1);

            PostService p = new PostService();
            p.GetAll();

        }

        private void homePnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homePnl_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(new Home());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(new UserList());

        }

        private void pnlPro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPro_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(new Profile());
        }
    }
    
}
