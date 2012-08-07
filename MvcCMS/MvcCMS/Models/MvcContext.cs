using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcCMS.Models
{
    public class MvcContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}