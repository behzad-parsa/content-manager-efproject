using ContentManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager
{
    public static class CurrentUser
    {
        
        //public static int ID { get; set; }
        //public static string  Firstname { get; set; }
        //public static string Lastname { get; set; }
        //public static string Username { get; set; }
        //public static DateTime Date { get; set; }

        //public static List<PostDto> Posts { get; set; }
        public static UserDTO User { get; internal set; }
    }
}
