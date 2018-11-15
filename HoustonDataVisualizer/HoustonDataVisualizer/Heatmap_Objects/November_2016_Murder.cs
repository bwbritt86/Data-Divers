using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class November_2016_Murder
     {
         public static IEnumerable<November_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new November_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7216811836735, -95.3750102040816);
              yield return new LatLng(29.7175785, -95.3204215);
              yield return new LatLng(29.6477938585859, -95.3777882828283);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.679273, -95.5528135);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7432879474049, -95.3931702380644);
              yield return new LatLng(29.856484, -95.545263);
              yield return new LatLng(29.9252572805138, -95.4040057959984);
              yield return new LatLng(29.9220093630126, -95.4028918889673);
              yield return new LatLng(29.9491273477181, -95.354134874381);
          }
     }

     public class November_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
