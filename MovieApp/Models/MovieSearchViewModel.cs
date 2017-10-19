using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
  public class MovieSearchViewModel
  {
    public string Search { get; set; }
    public string[] Movies { get; set; }
  }
}