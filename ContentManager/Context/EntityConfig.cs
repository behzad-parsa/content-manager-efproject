using ContentManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Context
{
    class EntityConfig
    {
    }

    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
           //this.HasMany(u => u.Posts).WithRequired(u => u.User).WillCascadeOnDelete(true);
           //this.HasMany(u => u.Comments).WithOptional(u => u.User).WillCascadeOnDelete(true);
        }
    }

    public class CommentConfig : EntityTypeConfiguration<Comment>
    {
        public CommentConfig()
        {
            this.HasOptional(u => u.User).WithMany(u => u.Comments).WillCascadeOnDelete(false) ;
            this.HasRequired(u => u.Post).WithMany(u => u.Comments).WillCascadeOnDelete(false);
            //this.Property(u => u.Content).IsOptional();
            

        }

    }


    public class PostConfig : EntityTypeConfiguration<Post>
    {
        public PostConfig()
        {

            //this.HasMany(u => u.Comments).WithRequired(u => u.Post).WillCascadeOnDelete(true);
            this.HasRequired(u => u.User).WithMany(u => u.Posts).WillCascadeOnDelete(true);
        }

    }




}
