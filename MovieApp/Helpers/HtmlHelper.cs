using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MovieApp.Helpers
{
  public static class HtmlHelper
  {
    public static MvcForm BeginInlineForm<T>(this HtmlHelper<T> helper, string actionName, string controllerName)
    {
      var attributes = new { @class = "inline-form" };
      return helper.BeginForm(actionName, controllerName, FormMethod.Post, attributes);
    }
  }
}