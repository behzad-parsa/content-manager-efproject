using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username  { get; set; }
        public string Pass { get; set; }
        public DateTime Birth { get; set; }

        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }


        public virtual ICollection<Post> Posts { get; set; }


        public virtual ICollection<Comment> Comments { get; set; }


        public User()
        {

        }
        public User(string firstname , string lastname , string username , string pass , DateTime birth , int roleID)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Pass = pass;
            Birth = birth;
            RoleID = roleID;


        }


    }
}
