using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Service
{
    public class PostDto
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public int UserID { get; set; }
        public UserDTO User { get; set; }


        public ICollection<CommentDto> Comments { get; set; }



        public PostDto()
        {

        }
        public PostDto(string content , string title , DateTime date )
        {
            Content = content;
            Title = title;
            Date = date;


        }

        public PostDto(string content, string title, DateTime date , int userid)
        {
            Content = content;
            Title = title;
            Date = date;
            UserID = userid;

        }


        public PostDto(string content, string title, DateTime date , UserDTO user)
        {
            Content = content;
            Title = title;
            Date = date;
            User = user;

        }

        public PostDto(int iD, string title, string content, DateTime date)
        {
            ID = iD;
            Title = title;
            Content = content;
            Date = date;
        }
    }
}
