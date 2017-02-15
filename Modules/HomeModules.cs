using Nancy;
using System;
using System.Collections.Generic;
using Allergies.Objects;

namespace AllergiesApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/output"] = _ => {
        Allergy object1 = new Allergy();
        object1.AllergyCheck(Request.Form["user-number"]);
        return View["output.cshtml", object1.dictionary];
      };
    }
  }
}
