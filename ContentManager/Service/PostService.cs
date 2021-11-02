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
    public class PostService
    {

        private readonly MainContext _con;
        private readonly DbSet<Post> _post;


        public PostService()
        {
            _con = new MainContext();
            _post = _con.Set<Post>();
        }


        public bool Insert (PostDto postDto)
        {
            var post = AutoMapperConfig.InitilizeUserMapperReverse().Map<Post>(postDto);

            _post.Add(post);


           // _post.Add(new Post(postDto.Title, postDto.Content, postDto.Date, postDto.UserID));
            


            return Convert.ToBoolean(_con.SaveChanges());
            

        }

        public IEnumerable<PostDto> GetAll()
        {

            //var postes = _post.AsNoTracking().ToList().Select(u => new PostDto(u.ID, u.Title, u.Content, u.Date));


            var postes = _post.ToList();

            var postDto = AutoMapperConfig.InitilizeUserMapper().Map<List<PostDto>>(postes);

            return postDto;






        }













    }
}
