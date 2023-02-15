using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApiComponents.Models;
using WebApiComponents.ViewModels;

namespace WebApiComponents.Controllers
{
    [EnableCors("*", "*", "*", "*")]
    public class PlacesController : ApiController
    {
        private readonly TouristEntities dbContext = new TouristEntities();

        [ResponseType(typeof(List<Place>))]
        public async Task<IHttpActionResult> GetAllPlaces()
        {
            var data = dbContext.TouristPlaces.Select((p)=> new Place {
                PlaceId = p.PlaceId, Description = p.Description, Name = p.Name, PinCode = p.PinCode, Significance = p.Significance, State = p.State
            }).ToList();
            return await Task.Run<IHttpActionResult>(() => Ok(data));
        }

        [ResponseType(typeof(Place))]
        public async Task<IHttpActionResult>GetPlace(int id)
        {
            var data = dbContext.TouristPlaces.FirstOrDefault((pl) => pl.PlaceId == id);
            var place = new Place
            {
                PlaceId = data.PlaceId,
                Description = data.Description,
                Name = data.Name,
                PinCode = data.PinCode,
                Significance = data.Significance,
                State = data.State
            };

            return await Task.Run<IHttpActionResult>(() => Ok(place));
        }

        [ResponseType(typeof(List<ImageFile>))]
        [Route("api/Places/Images/{id}")]
        public async Task<IHttpActionResult>GetImages(int id)
        {
            var data = dbContext.ImageFiles.Where((f) => f.PlaceId == id).Select(f=> new ImgFile {
                EntryId = f.EntryId, ImageSource = f.ImageSource, PlaceId = f.PlaceId
            }).ToList();
            return await Task.Run<IHttpActionResult>(() => Ok(data));
        }

        [ResponseType(typeof(Place))]
        [HttpPost]
        public async Task<IHttpActionResult>AddPlace(Place place)
        {
            var tPlace = new TouristPlace
            {
                Description = place.Description,
                Name = place.Name,
                PinCode = place.PinCode,
                Significance = place.Significance,
                State = place.State
            };
            dbContext.TouristPlaces.Add(tPlace);
            dbContext.SaveChanges();
            place.PlaceId = tPlace.PlaceId;
            return await Task.Run<IHttpActionResult>(() => Ok(place));
        }

        [ResponseType(typeof(TouristPlace))]
        [HttpPost]
        [Route("api/Places/Tourist")]
        public async Task<IHttpActionResult>AddNewPlace(TouristPlace place)
        {
            dbContext.TouristPlaces.Add(place);
            var rows =  await dbContext.SaveChangesAsync();
            return await Task.Run<IHttpActionResult>(() => Ok(rows));
        }

        [HttpPost]
        [Route("api/Images/{id}")]
        public async Task<IHttpActionResult> AddImages(int id, ImgFile file)
        {
            var imgFile = new ImageFile
            {
                ImageSource = file.ImageSource,
                PlaceId = file.PlaceId
            };
            dbContext.ImageFiles.Add(imgFile);
            dbContext.SaveChanges();
            return await Task.Run<IHttpActionResult>(() => Ok());
        }


        
    }
}
