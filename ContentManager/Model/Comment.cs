using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Model
{
    public class Comment
    {
        public Comment()
        {

        }
        public Comment(string content, DateTime date, int postID, int userID)
        {
            Content = content;
            Date = date;
            PostID = postID;
            UserID = userID;
        }

        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public int? UserID { get; set; } //Int? nullabel int
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public  int PostID { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}
