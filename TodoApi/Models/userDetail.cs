using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Controllers
{
  public class UserDetails
  {
    public int ID{ get; set;}
    
    [MinLength(3)]
    public string Name{get; set;}

  }
}