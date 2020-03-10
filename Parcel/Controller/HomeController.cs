using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers

{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/DrugForm")]
    public ActionResult DrugForm()
    {
      return View();
    }
    [HttpPost("/price")]
    public ActionResult Price(int weight, int height, int width, int length)
    {
      ParcelObject myParcel = new ParcelObject();
      myParcel.Weight = weight;
      myParcel.Height = height; 
      myParcel.Width = width;
      myParcel.Length = length;
      myParcel.GetVolume();
      myParcel.VolumePrice();
      myParcel.WeightPrice();
      myParcel.TotalPrice();
      return View(myParcel);
    }
  }
}