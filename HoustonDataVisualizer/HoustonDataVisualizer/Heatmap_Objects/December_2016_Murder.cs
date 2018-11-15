using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class December_2016_Murder
     {
         public static IEnumerable<December_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new December_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.737052125, -95.379277375);
              yield return new LatLng(29.7265809591837, -95.3711365102041);
              yield return new LatLng(29.542893, -95.154053);
              yield return new LatLng(29.7003493822808, -95.2987683148395);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6790185007912, -95.2949128693128);
              yield return new LatLng(29.6591517360798, -95.3654188787805);
              yield return new LatLng(29.6829483333333, -95.3389245151515);
              yield return new LatLng(29.6943489, -95.3266278);
              yield return new LatLng(29.5920551309292, -95.4757442197642);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.6789146538462, -95.5526367307692);
              yield return new LatLng(29.7325154465048, -95.5637366370731);
              yield return new LatLng(29.7769537337626, -95.5961707736371);
              yield return new LatLng(29.8352096345057, -95.4339706410438);
              yield return new LatLng(29.8372626, -95.4107545);
              yield return new LatLng(29.7746865335028, -95.3273737389239);
          }
     }

     public class December_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
