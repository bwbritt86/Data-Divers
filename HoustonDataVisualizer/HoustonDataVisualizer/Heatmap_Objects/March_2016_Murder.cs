using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class March_2016_Murder
     {
         public static IEnumerable<March_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new March_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7470584693878, -95.3713531428571);
              yield return new LatLng(29.7325700816327, -95.3518016938775);
              yield return new LatLng(29.6913324907843, -95.3533138432531);
              yield return new LatLng(29.770793, -95.328129);
              yield return new LatLng(29.58824436, -95.463996);
              yield return new LatLng(29.7200735, -95.490992);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7806491730922, -95.4860403681769);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.7965438131868, -95.5746595714286);
              yield return new LatLng(29.8706859387755, -95.4375015918367);
              yield return new LatLng(29.948242, -95.392628);
              yield return new LatLng(29.949327, -95.4222713333333);
              yield return new LatLng(29.864157, -95.34307);
              yield return new LatLng(29.8640286040268, -95.337825147651);
          }
     }

     public class March_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
