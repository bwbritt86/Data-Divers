using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class October_2017_Murder
     {
         public static IEnumerable<October_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new October_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.6762760816327, -95.370367244898);
              yield return new LatLng(29.834903293302, -95.3583457741562);
              yield return new LatLng(29.9568563, -95.2646183);
              yield return new LatLng(29.8204749795918, -95.3072886530612);
          }
     }

     public class October_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
