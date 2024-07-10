using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DogWalker.Models;
// using DogGo.Models;

namespace DogWalker.Controllers;

public class WalkerController : Controller
{   
    private readonly DogWalkerDbContext _dbContext;

    public WalkerController(DogWalkerDbContext context)
    {
        _dbContext = context;
    }

   // GET: Walkers
  public ActionResult Index()
{
    List<Walker> walkers = _dbContext.Walkers.ToList();//Use the approprate EF Core method to get all the walkers*

    return View(walkers);
}

   
}
