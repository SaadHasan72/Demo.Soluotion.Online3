using Demo.DAL.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositiories
{
    internal class DepartmentRepo(ApplicationDBContext context)


    {

        
        private readonly ApplicationDBContext context = context;

        //ApplicationDBContext context = new ApplicationDBContext();
        public Department ? GetById (int id )
        {
            var department = context. Departments .Find ( id );
            return department;
        }

    }
}
