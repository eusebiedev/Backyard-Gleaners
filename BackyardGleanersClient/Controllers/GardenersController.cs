using Microsoft.AspNetCore.Mvc;
using BackyardGleanersClient.Models;

namespace BackyardGleanersClient.Controllers;

public class GardenersController : Controller
{
  public IActionResult Index()
  {
    List<Gardener> gardeners = Gardener.GetGardeners();
    return View(gardeners);
  }
}