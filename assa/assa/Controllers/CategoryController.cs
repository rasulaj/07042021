using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assa.Controllers
{
    public class CategoryController:Controller
    {
        private AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
    }
}
