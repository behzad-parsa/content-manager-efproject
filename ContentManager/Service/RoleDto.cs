using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Service
{
    public class RoleDto
    {
        public RoleDto()
        {
        }

        public RoleDto(int iD, string title)
        {
            ID = iD;
            Title = title;
        }

        public int ID { get; set; }
        public string Title { get; set; }



    }
}
