using AutoMapper;
using ContentManager.Model;
using ContentManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager
{
    public static class AutoMapperConfig
    {

        public static Mapper InitilizeUserMapper()
        {

            var config = new MapperConfiguration(cfg => {
                //cfg.CreateMap<User, UserDTO>().MaxDepth(4);

                //cfg.CreateMap<Post, PostDto>().MaxDepth(4);
                //cfg.CreateMap<Comment, CommentDto>().MaxDepth(4);
                //cfg.CreateMap<Role, RoleDto>().ReverseMap();

                //cfg.CreateMap<User, UserDTO>().ReverseMap().PreserveReferences();

                //cfg.CreateMap<Post, PostDto>().ReverseMap().PreserveReferences();
                //cfg.CreateMap<Comment, CommentDto>().ReverseMap().PreserveReferences();
                //cfg.CreateMap<Role, RoleDto>().ReverseMap().PreserveReferences();


                cfg.CreateMap<User, UserDTO>().PreserveReferences();

                cfg.CreateMap<Post, PostDto>().PreserveReferences();
                cfg.CreateMap<Comment, CommentDto>().PreserveReferences();
                cfg.CreateMap<Role, RoleDto>().PreserveReferences();


            });

            return new Mapper(config);



        }

        public static Mapper InitilizeUserMapperReverse()
        {

            var config = new MapperConfiguration(cfg => {


                cfg.CreateMap<UserDTO , User >().PreserveReferences();

                cfg.CreateMap<PostDto , Post>().PreserveReferences();
                cfg.CreateMap<CommentDto, Comment>().PreserveReferences();
                cfg.CreateMap<RoleDto , Role>().PreserveReferences();


            });

            return new Mapper(config);



        }





    }
}
