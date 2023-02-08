using SampleMvcApp.Data_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcApp.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            //get UR Repo object.
            var repo = new CarInfoRepo();
            //Call the API to get the data
            var model = repo.GetAllCars();
            //Inject the data into the View
            return View(model);
        }

        public string HelloWorld()
        {
            return "My Customized Factory";
        }
        public ActionResult Edit(string id)
        {

            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Message = "Car ID is not set,please visit Index Page!";
                return View();
            }
            var selectedId = int.Parse(id);
            var repo = new CarInfoRepo();
            var model = repo.FindCar(selectedId);
            if(model == null)
            {
                ViewBag.Message = "Car Info is not available with Us!";
                return View();
            }
            return View(model);

        }
        [HttpPost]
        public ActionResult Edit(CarInfo updatedData)
        {
            
            var repo = new CarInfoRepo();
            repo.UpdateCar(updatedData);
            return RedirectToAction("Index");
        }

        public ActionResult AddCar() => View(new CarInfo());

        [HttpPost]
        public ActionResult AddCar(CarInfo posteddata)
        {
            var repo = new CarInfoRepo();
            repo.AddNewCar(posteddata);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        { 
            var carId = int.Parse(id);
            var repo = new CarInfoRepo();
            repo.DeleteCar(carId);
            return RedirectToAction("Index");
        }
    }
}