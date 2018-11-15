using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class February_2017_Murder
     {
         public static IEnumerable<February_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new February_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7298493030303, -95.3679711515151);
              yield return new LatLng(29.7311079795918, -95.356573877551);
              yield return new LatLng(29.7141420857143, -95.3597726285714);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6886587992069, -95.3415325091711);
              yield return new LatLng(29.6544753469388, -95.3455946122449);
              yield return new LatLng(29.693798, -95.3753406666667);
              yield return new LatLng(29.6712741111111, -95.3777891313131);
              yield return new LatLng(29.6673758163265, -95.3651536326531);
              yield return new LatLng(29.6376743142645, -95.3319637802664);
              yield return new LatLng(29.7200735, -95.490992);
              yield return new LatLng(29.6963482332076, -95.5561584636631);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.667201, -95.5638987586207);
              yield return new LatLng(29.7609851041723, -95.576358255897);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.9545776767471, -95.4231410911162);
              yield return new LatLng(29.8529208433735, -95.3277213855422);
              yield return new LatLng(29.8468098168182, -95.2815718773223);
              yield return new LatLng(29.7327835, -95.5716659);
          }
     }

     public class February_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
