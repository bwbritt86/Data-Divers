using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class December_2017_Murder
     {
         public static IEnumerable<December_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new December_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7265485918367, -95.3625132857143);
              yield return new LatLng(29.7256851818182, -95.3687265151515);
              yield return new LatLng(29.9024465, -95.5024409);
              yield return new LatLng(29.8286277575758, -95.3925822727273);
              yield return new LatLng(29.8461876734694, -95.5469647755102);
              yield return new LatLng(29.8799631169715, -95.4179501391562);
              yield return new LatLng(29.7082498947368, -95.4019241578947);
              yield return new LatLng(29.7765939795918, -95.306056877551);
          }
     }

     public class December_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
