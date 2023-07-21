using Microsoft.AspNetCore.Mvc;
using BackyardGleanersClient.Models;
using System.Text.Json; 
using Newtonsoft.Json;

namespace BackyardGleanersClient.Controllers;

public class GardenersController : Controller
{
  public IActionResult Index()
  {
    List<Gardener> gardeners = Gardener.GetGardeners();
    return View(gardeners);
  }

  public IActionResult Details(int id)
  {
    Gardener gardener = Gardener.GetDetails(id);
    return View(gardener);
  }
  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Gardener gardener)
  {
    Gardener.Post(gardener);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    Gardener gardener = Gardener.GetDetails(id);
    return View(gardener);
  }

  [HttpPost]
  public ActionResult Edit(Gardener gardener)
  {
    Gardener.Put(gardener);
    return RedirectToAction("Details", new { id = gardener.GardenerId });
  }
  
  public ActionResult Delete(int id)
  {
    Gardener gardener = Gardener.GetDetails(id);
    return View(gardener);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Gardener.Delete(id);
    return RedirectToAction("Index");
  }

  public ActionResult Search()
  {
    return View();
  }

  [HttpPost]
  public async Task<ActionResult> Results(string food, string location)
  {
    string jsonContent = await ApiHelper.Search(food, location);

    if (!string.IsNullOrEmpty(jsonContent))
    {
      List<Gardener> searchResults = JsonConvert.DeserializeObject<List<Gardener>>(jsonContent);

      return View("Results", searchResults);
    }
    else
    {
      return View("NoResults");
    }

  }
}
