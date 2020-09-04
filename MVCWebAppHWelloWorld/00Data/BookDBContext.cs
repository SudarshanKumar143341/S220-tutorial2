using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCWebAppHWelloWorld._00Data
{



    public class BookDBContext : DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options)
            : base(options)
        { }

        public DbSet<Book> Books_DB { get; set; }
    }
   
   }

