using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
  public class AppController : Controller
  {
    private readonly IMailService _mailService;
    private readonly IDutchRepository _repository;

    public AppController(IMailService mailService, IDutchRepository repository)
    {
      _mailService = mailService;
      _repository = repository;
    }

    public IActionResult Index(string Search)
    {
            if (!String.IsNullOrEmpty(Search))
            {
                return View(_repository.GetProductsByCategory(Search));
            }
            else
            {
      return View(_repository.GetAllProducts());
            }
    }
  }
}
