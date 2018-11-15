using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class June_2017_Murder
     {
         public static IEnumerable<June_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new June_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.7159720506779, -95.5044684665333);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8879257272727, -95.2964085353535);
          }
     }

     public class June_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
