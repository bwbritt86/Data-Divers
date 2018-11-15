using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class April_2016_Murder
     {
         public static IEnumerable<April_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new April_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7439214136686, -95.3731998465219);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6251831390263, -95.3665153085131);
              yield return new LatLng(29.7133852541773, -95.4929901752125);
              yield return new LatLng(29.6902852809858, -95.5132433163314);
              yield return new LatLng(29.725472, -95.48764);
              yield return new LatLng(29.7915739795918, -95.3555213673469);
              yield return new LatLng(29.8238687919769, -95.5326309023632);
              yield return new LatLng(29.82362425, -95.5314646252594);
              yield return new LatLng(29.8297330816327, -95.329005877551);
              yield return new LatLng(29.8825424948708, -95.2889732027647);
          }
     }

     public class April_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
