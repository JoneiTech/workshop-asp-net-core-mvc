using SalesWebMvc.Data;
using SalesWebMvc.Services;
using System.Linq;
using System.Collections.Generic;
using SalesWebMvc.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
            private readonly SalesWebMvcContext _context;

            public DepartmentService(SalesWebMvcContext context)
            {
                _context = context;
            }

        public async Task<List<Department>> FindAllAsync()
        //public List<Department> FindAll() 
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
            //return _context.Department.OrderBy(x => x.Name).ToList();
        }
        }
}
