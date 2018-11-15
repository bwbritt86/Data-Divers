using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class January_2016_Murder
     {
         public static IEnumerable<January_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new January_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7053590604088, -95.3705816502392);
              yield return new LatLng(29.7190137481228, -95.3794276946017);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.680063, -95.364346);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7000983714952, -95.5923302361482);
              yield return new LatLng(29.7034852857143, -95.5990405714286);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.8125993061224, -95.5399292653061);
              yield return new LatLng(29.8617474, -95.5442895);
              yield return new LatLng(29.7747363951613, -95.3167056935484);
              yield return new LatLng(29.8619575, -95.34303);
              yield return new LatLng(29.7671745254949, -95.2170786430713);
              yield return new LatLng(29.7786187959184, -95.1866182653061);
              yield return new LatLng(29.9820651, -95.4221464);
          }
     }

     public class January_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
