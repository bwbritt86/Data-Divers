using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class February_2016_Murder
     {
         public static IEnumerable<February_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new February_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7318382439024, -95.3529433658537);
              yield return new LatLng(29.6887908163265, -95.3537368163265);
              yield return new LatLng(29.6720556097561, -95.3675772682927);
              yield return new LatLng(29.6633346122449, -95.3571769591837);
              yield return new LatLng(29.6399702608696, -95.3642873946488);
              yield return new LatLng(29.6331708300649, -95.4176710715948);
              yield return new LatLng(29.7072875306122, -95.4828114081633);
              yield return new LatLng(29.7163303888889, -95.4857946388889);
              yield return new LatLng(29.7193825652174, -95.4888976521739);
              yield return new LatLng(29.7402987894737, -95.496551631579);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6993262222222, -95.6169391111111);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.9552981707317, -95.4185784390244);
              yield return new LatLng(29.7983018592965, -95.3080374874372);
              yield return new LatLng(29.793991877551, -95.337814122449);
              yield return new LatLng(29.7880591, -95.3273736);
              yield return new LatLng(29.7323219, -95.3427822);
          }
     }

     public class February_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
