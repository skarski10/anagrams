using Nancy;
using System.Collections.Generic;
using AnagramApp.Objects;

namespace AnagramApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        Anagram.ClearList();
        string userInput = (Request.Form["user-input"]);
        Anagram newAnagram = new Anagram(userInput);
        newAnagram.RearrangeArray();
        List<string> result = Anagram.GetList();
        return View["index.cshtml", result];
      };
    }
  }
}
