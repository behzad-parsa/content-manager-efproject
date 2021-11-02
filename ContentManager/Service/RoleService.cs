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
    public class RoleService
    {
        private readonly MainContext _con;
        private readonly DbSet<Role> _role;
        public RoleService()
        {
            _con = new MainContext();
            _role = _con.Set<Role>();

        }

        public IEnumerable<RoleDto> GetAll()
        {

            var roles = _role.AsNoTracking().ToList().Select(u => new RoleDto(u.ID, u.Title));


            return roles;


        }
        public RoleDto SearchWithID(int roleID)
        {

            var role = _role.SingleOrDefault(u=>u.ID == roleID);

            return new RoleDto(role.ID, role.Title);

        }




    }
}
