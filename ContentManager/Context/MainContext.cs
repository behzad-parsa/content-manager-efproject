using ContentManager.Migrations;
using ContentManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Context
{
    class MainContext :DbContext
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<LSPost> LSPosts { get; set; }

        public IDbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Configurations.Add(new CommentConfig());
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new PostConfig());
        }

        public MainContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MainContext , Configuration>());
        }






    }
}
