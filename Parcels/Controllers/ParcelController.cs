using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/")]
    public ActionResult Home() { return View(); }

    [HttpGet("AddParcelForm")]
    public ActionResult AddParcelForm() { return View(); }

    [HttpPost("/DisplayParcel")]
    public ActionResult AddParcelForm(int length, int width, int weight, int height, int volume)
    {
      Parcel newParcel = new Parcel(length, width, weight, height, volume);
      double cost = newParcel.GetCost();
    }
    [HttpGet("/DisplayParcel")]
    public ActionResult DisplayParcel()
    {
      List<Parcel> newParcelList = Parcel.ShowParcel();
      return View(newParcelList);
    }
  }


}