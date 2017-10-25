using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
  public class MovieListViewModel
  {
    public string Search { get; set; }
    public Movie[] Movies { get; set; }
    public Movie NewMovie { get; set; }
  }
}