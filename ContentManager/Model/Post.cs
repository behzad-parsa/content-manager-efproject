using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Model
{
    public class Post
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }


        public Post()
        {

        }

        public Post(string title, string content, DateTime date, int userID)
        {
            Title = title;
            Content = content;
            Date = date;
            UserID = userID;
        }
    }
}
