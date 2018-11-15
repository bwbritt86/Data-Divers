using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class November_2017_Rape
     {
         public static IEnumerable<November_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new November_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7605008424654, -95.3475910120928);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.8778325552908, -95.5088478793263);
              yield return new LatLng(29.7341759795918, -95.290358244898);
              yield return new LatLng(29.7047825801916, -95.2886099931975);
              yield return new LatLng(29.711436, -95.4009096);
              yield return new LatLng(29.674962, -95.2699238);
              yield return new LatLng(29.6889726093967, -95.362188620961);
              yield return new LatLng(29.6644267142857, -95.3572027346939);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.707378755102, -95.4733342857143);
              yield return new LatLng(29.6981726363636, -95.5786790808081);
              yield return new LatLng(29.7610274081633, -95.3585149183673);
              yield return new LatLng(29.7575407, -95.3923592);
              yield return new LatLng(29.825405, -95.4623310909091);
              yield return new LatLng(29.8312560553982, -95.3726838742516);
              yield return new LatLng(29.8198585779508, -95.5307355086236);
              yield return new LatLng(29.8539651724138, -95.3845154551724);
              yield return new LatLng(29.8438820859567, -95.3306833443529);
              yield return new LatLng(29.7967525918367, -95.2754537755102);
          }
     }

     public class November_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
