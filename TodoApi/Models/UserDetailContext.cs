using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Controllers
{
    public class UserDetailContext : DbContext
    {
      public UserDetailContext(DbContextOptions<UserDetailContext> options):base(options)
      {
        
      }
    }
}