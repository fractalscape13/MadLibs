using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }
    
    [Route("/story")]
    public ActionResult Story(string adj1, string adj2, string adj3, string adj4, string adj5, string adj6, string adj7, string noun1, string noun2, string noun3, string noun4, string verb1, string verb2, string verb3, string verb4) {
      WordVariables myWords = new WordVariables();
      myWords.Adj1 = adj1;
      myWords.Adj2 = adj2;
      myWords.Adj3 = adj3;
      myWords.Adj4 = adj4;
      myWords.Adj5 = adj5;
      myWords.Adj6 = adj6;
      myWords.Adj7 = adj7;
      myWords.Noun1 = noun1;
      myWords.Noun2 = noun2;
      myWords.Noun3 = noun3;
      myWords.Noun4 = noun4;
      myWords.Verb1 = verb1;
      myWords.Verb2 = verb2;
      myWords.Verb3 = verb3;
      myWords.Verb4 = verb4;
      return View(myWords); }
  }
}