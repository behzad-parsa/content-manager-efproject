using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Service
{
    public class CommentDto
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }


        public int PostID { get; set; }
        public int? UserID { get; set; }
        public UserDTO User { get; set; }
        public PostDto Post { get; set; }

        public CommentDto()
        {
                
        }
        public CommentDto(string content , DateTime date  , int userID , int postID)
        {
            this.Content = content;
            this.Date = date;
            this.PostID = postID;
            this.UserID = userID;
    
        }
        //public CommentDto(string content, DateTime date, int userID, int postID, UserDTO user)
        //{
        //    this.Content = content;
        //    this.Date = date;
        //    this.PostID = postID;
        //    this.UserID = userID;
        //}


    }
}
