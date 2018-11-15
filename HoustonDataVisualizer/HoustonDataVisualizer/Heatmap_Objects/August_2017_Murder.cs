using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class August_2017_Murder
     {
         public static IEnumerable<August_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new August_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7378787142857, -95.3557579795918);
          }
     }

     public class August_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
