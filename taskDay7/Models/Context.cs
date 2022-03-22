using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace taskDay7.Models
{
    public class Context :DbContext
    {

    public Context() : base("Data Source=localhost;Initial Catalog=CrudOperations;Integrated Security=True")
    {
    }

    public virtual DbSet<Student> students { get; set; }
    public virtual DbSet<User> users { get; set; }
}
}