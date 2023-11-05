using Microsoft.AspNetCore.Mvc;
using BackyardGleanersClient.Models;

namespace BackyardGleanersClient.Controllers;

// public class GardenersController : Controller
// {
//   private List<Gardener> hardcodedGardeners;

//   public IActionResult Index()
//   {
//     return View();
//   }

//   public IActionResult Search()
//   {
//     hardcodedGardeners = new List<Gardener>
//     {
//       new Gardener { Food = "Tomatoes", Location = "97215" },
//     };
//     return View(hardcodedGardeners);
//   }

//   [HttpPost]
//   public IActionResult Results(string food, string location)
//   {
//     // Filter the list of hardcoded gardeners based on the search criteria
//     var filteredGardeners = hardcodedGardeners
//         .Where(g => (string.IsNullOrEmpty(food) || g.Food.Contains(food)) && (string.IsNullOrEmpty(location) || g.Location.Contains(location)))
//         .ToList();

//     return View(filteredGardeners);
//   }

//   // public ActionResult Details ()
//   // {
//   //   return View();
//   // }
//   // public ActionResult Create()
//   // {
//   //   Gardener gardener = new Gardener();
//   //   gardener.ProfilePic = "/img/tombackground.jpeg";
//   //   return View("");
//   // }

//   // [HttpPost]
//   // public ActionResult Create(Gardener gardener)
//   // {
//   //   Gardener.Post(gardener);
//   //   gardener.ProfilePic = "/img/tombackground.jpeg";
//   //   return RedirectToAction("Index");
//   // }

//   // public ActionResult Edit(int id)
//   // {
//   //   Gardener gardener = Gardener.GetDetails(id);
//   //   return View(gardener);
//   // }

//   // [HttpPost]
//   // public ActionResult Edit(Gardener gardener)
//   // {
//   //   Gardener.Put(gardener);
//   //   return RedirectToAction("Details", new { id = gardener.GardenerId });
//   // }

//   // public ActionResult Delete(int id)
//   // {
//   //   Gardener gardener = Gardener.GetDetails(id);
//   //   return View(gardener);
//   // }

//   // [HttpPost, ActionName("Delete")]
//   // public ActionResult DeleteConfirmed(int id)
//   // {
//   //   Gardener.Delete(id);
//   //   return RedirectToAction("Index");
//   // }


//   public ActionResult About ()
//   {
//     return View();
//   }
//   public ActionResult Map ()
//   {
//     return View();
//   }
//   public ActionResult History ()
//   {
//     return View();
//   }

//   public ActionResult Resources ()
//   {
//     return View();
//   }
//   public ActionResult Contact ()
//   {
//     return View();
//   }

//   public ActionResult Gleen1()
//   {
//       return View("Gleen-1");
//   }
// }

public class GardenersController : Controller
{
  private List<Gardener> hardcodedGardeners;

  public GardenersController()
  {
    hardcodedGardeners = new List<Gardener>
    {
      new Gardener { Name = "Eusebie & Kate", Food = "Tomatoes", Location = "97215" },
      new Gardener { Name = "Berry Sweetwater", Food = "Strawberries", Location = "97239" },
      new Gardener { Name = "Cherry Bark", Food = "Cherries", Location = "97203" },
      new Gardener { Name = "Priscilla Plum", Food = "Plumbs", Location = "97209" },
      new Gardener { Name = "Zack and Inna Thompson", Food = "Zucchinis", Location = "97214" },
      new Gardener { Name = "Granny Smith", Food = "Apples", Location = "97211" },
      new Gardener { Name = "Padma Periwinkle", Food = "Persimmons", Location = "97232" },
      new Gardener { Name = "Hazel Folgelstein", Food = "Hazelnuts", Location = "97229" },
      new Gardener { Name = "Carrie Cuke", Food = "Cucumbers", Location = "97227" },
      new Gardener { Name = "Ronnie Romulus", Food = "Romaine Lettuce", Location = "97217" },
      new Gardener { Name = "Kaley Green", Food = "Kale", Location = "97206" },
      new Gardener { Name = "Bill Bloom", Food = "Blueberries", Location = "97211" },
    };
  }

  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Search()
  {
    return View(hardcodedGardeners);
  }

  [HttpPost]
  public IActionResult Results(string food, string location)
  {
    // Check if the search criteria is empty
    if (string.IsNullOrEmpty(food) && string.IsNullOrEmpty(location))
    {
      // Return an empty list if the search criteria is empty
      return View(new List<Gardener>());
    }
    // Filter the list of hardcoded gardeners based on the search criteria
    var filteredGardeners = hardcodedGardeners
      .Where(g => (string.IsNullOrEmpty(food) || g.Food.Contains(food)) && (string.IsNullOrEmpty(location) || g.Location.Contains(location)))
      .ToList();
    // Return the filtered list of gardeners
    return View(filteredGardeners);
  }

  // public ActionResult Details ()
  // {
  //   return View();
  // }
  // public ActionResult Create()
  // {
  //   Gardener gardener = new Gardener();
  //   gardener.ProfilePic = "/img/tombackground.jpeg";
  //   return View("");
  // }

  // [HttpPost]
  // public ActionResult Create(Gardener gardener)
  // {
  //   Gardener.Post(gardener);
  //   gardener.ProfilePic = "/img/tombackground.jpeg";
  //   return RedirectToAction("Index");
  // }

  // public ActionResult Edit(int id)
  // {
  //   Gardener gardener = Gardener.GetDetails(id);
  //   return View(gardener);
  // }

  // [HttpPost]
  // public ActionResult Edit(Gardener gardener)
  // {
  //   Gardener.Put(gardener);
  //   return RedirectToAction("Details", new { id = gardener.GardenerId });
  // }

  // public ActionResult Delete(int id)
  // {
  //   Gardener gardener = Gardener.GetDetails(id);
  //   return View(gardener);
  // }

  // [HttpPost, ActionName("Delete")]
  // public ActionResult DeleteConfirmed(int id)
  // {
  //   Gardener.Delete(id);
  //   return RedirectToAction("Index");
  // }

  public ActionResult About()
  {
    return View();
  }
  public ActionResult Map()
  {
    return View();
  }
  public ActionResult History()
  {
    return View();
  }

  public ActionResult Resources()
  {
    return View();
  }
  public ActionResult Contact()
  {
    return View();
  }

  public ActionResult Tomatoes()
  {
    return View("Tomatoes");
  }
  public ActionResult Strawberries()
  {
    return View("Strawberries");
  }
}