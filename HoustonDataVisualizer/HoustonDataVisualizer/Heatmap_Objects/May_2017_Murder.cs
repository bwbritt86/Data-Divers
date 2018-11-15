using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class May_2017_Murder
     {
         public static IEnumerable<May_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new May_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.6533806969697, -95.3654957474748);
              yield return new LatLng(29.6537060612245, -95.5806830612245);
              yield return new LatLng(29.7769537337626, -95.5961707736371);
              yield return new LatLng(29.9506993414634, -95.3976742439024);
              yield return new LatLng(29.8630212929293, -95.3097687373737);
              yield return new LatLng(29.8493670204018, -95.256562450543);
          }
     }

     public class May_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
