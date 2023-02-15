using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiComponents.ViewModels
{
    public class Place
    {
        public int PlaceId { get; set; }
        public string Name { get; set; }
        public long PinCode { get; set; }
        public string State { get; set; }
        public string Significance { get; set; }
        public string Description { get; set; }
    }

    public class ImgFile
    {
        public int EntryId { get; set; }
        public int PlaceId { get; set; }
        public string ImageSource { get; set; }
    }
}