using AutoMapper;
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
    public class UserService
    {
        private readonly MainContext _context;
        private readonly DbSet<User> _user;

        public UserService()
        {
            _context = new MainContext();
            _user = _context.Set<User>();
        }

        public (bool , int) Insert(UserDTO user)
        {
            var userModel = new User(user.Firstname, user.Lastname, user.Username, user.Pass , user.Birth , user.RoleID);

             _user.Add(userModel);
             var res = _context.SaveChanges();
            
            return  (Convert.ToBoolean(res) , userModel.ID);

        }
        public List<UserDTO> GetAll()
        {
            //var query = _user as IQueryable;
            //query = (from u in query
            //        join r in Role
            //        on u.RoleID equals r.RoleID)

            //var userList = _user.AsNoTracking().ToList().Select(u => new UserDTO(u.Firstname, u.Lastname, u.Username, u.Pass, u.Birth , u.RoleID  , new RoleDto(u.Role.ID , u.Role.Title))) ;

            var userList = _user.ToList();
            
            return AutoMapperConfig.InitilizeUserMapper().Map<List<UserDTO>>(userList);
        }

        public (UserDTO , User) GetByUsername(string username)
        {

            var user = _user.SingleOrDefault(u => u.Username == username);

            

            var mapper = AutoMapperConfig.InitilizeUserMapper();
            var userDto = mapper.Map<UserDTO>(user);

           //Reverse  ----> var user2 = mapper.Map<User>(userDto);
            return (userDto , user);
        }


        public bool Delete(int Id)
        {

            var user = _user.Find(Id);

            var res = _user.Remove(user);
            _context.Entry(user).State = EntityState.Deleted;
           
            return Convert.ToBoolean(_context.SaveChanges());


        }
        public bool Delete(string username)
        {

            var user = GetByUsername(username).Item2;


             _user.Remove(user);
            _context.Entry(user).State = EntityState.Deleted;

            return Convert.ToBoolean(_context.SaveChanges());


        }
    }
}
