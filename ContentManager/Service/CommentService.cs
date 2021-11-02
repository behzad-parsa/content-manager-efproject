using ContentManager.Context;
using ContentManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Service
{
    class CommentService
    {
        private readonly MainContext _con;
        private readonly DbSet<Comment> _comment;

        public CommentService()
        {

            _con = new MainContext();
            _comment = _con.Set<Comment>();
        }

        public  bool Insert (CommentDto commentDto)
        {
            var comment = AutoMapperConfig.InitilizeUserMapperReverse().Map<Comment>(commentDto);

            // _comment.Add(new Comment(comment.Content, comment.Date, comment.PostID, comment.UserID));
            _comment.Add(comment);
            return Convert.ToBoolean(_con.SaveChanges());

        }
        public IEnumerable<Comment> GetByUserID(int userID)
        {
            var comments = _comment.Where(u => u.UserID == userID).Include(u=>u.User);

            return comments.ToList();
        }
        public bool DeleteRange (UserDTO userDto)
        {
            var comments = GetByUserID(userDto.ID);
            
            //var comments = _comment.Where(u => u.ID == user.CommentsD);
            _comment.RemoveRange(comments);
           // _con.Entry(user.Comments).State = EntityState.Deleted;
            return Convert.ToBoolean(_con.SaveChanges());
        }
        



    }
}
