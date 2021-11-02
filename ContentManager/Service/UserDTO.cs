using ContentManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Service
{
    public class UserDTO
    {
        public UserDTO()
        {

        }

        //public UserDTO(string firstname, string lastname, string username, string pass, DateTime birth , int roleID)
        //{
        //    Firstname = firstname;
        //    Lastname = lastname;
        //    Username = username;
        //    Pass = pass;
        //    Birth = birth;
        //    RoleID = roleID;
        //}
        public UserDTO(string firstname, string lastname, string username, string pass, DateTime birth, int roleID ,RoleDto role)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Pass = pass;
            Birth = birth;
            RoleID = roleID;
            Role = role;
        }

        //public UserDTO(string firstname, string lastname, string username, string pass, DateTime birth, RoleDto role, List<CommentDto> comments, List<PostDto> posts)
        //{
        //    Firstname = firstname;
        //    Lastname = lastname;
        //    Username = username;
        //    Pass = pass;
        //    Birth = birth;
        //    this.Role = role;
        //    Comments = comments;
        //    Posts = posts;
        //}

        //public UserDTO(int iD, string firstname, string lastname, string username, string pass, DateTime birth, RoleDto role, List<CommentDto> comments, List<PostDto> posts)
        //{
        //    ID = iD;
        //    Firstname = firstname;
        //    Lastname = lastname;
        //    Username = username;
        //    Pass = pass;
        //    Birth = birth;
        //    Role = role;
        //    Comments = comments;
        //    Posts= posts;
        //}

        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public DateTime Birth { get; set; }
        public int RoleID { get; set; }
        public RoleDto Role { get; set; }
        public ICollection<PostDto> Posts { get; set; }
        public ICollection<CommentDto> Comments { get; set; }

    }
}
