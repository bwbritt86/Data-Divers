using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class February_2016_Rape
     {
         public static IEnumerable<February_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new February_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7284438163265, -95.3333529591837);
              yield return new LatLng(29.7365509411765, -95.3468179411765);
              yield return new LatLng(29.7314884081633, -95.3596648367347);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6971745, -95.3731438333333);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.6750084089027, -95.372797975851);
              yield return new LatLng(29.6642436694891, -95.4658684497524);
              yield return new LatLng(29.6268375495106, -95.43256650187);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6687234444444, -95.5042262525253);
              yield return new LatLng(29.7312618571429, -95.4665215510204);
              yield return new LatLng(29.7382243, -95.3803352);
              yield return new LatLng(29.7329140816327, -95.4891945306123);
              yield return new LatLng(29.7330174242424, -95.4813955151515);
              yield return new LatLng(29.674556442953, -95.5442413489933);
              yield return new LatLng(29.6836384071936, -95.5654763107115);
              yield return new LatLng(29.6799032647831, -95.6074600239796);
              yield return new LatLng(29.6746602115385, -95.5612672692308);
              yield return new LatLng(29.7588326122449, -95.4022836122449);
              yield return new LatLng(29.7410006508808, -95.5718649224446);
              yield return new LatLng(29.7305870438773, -95.5943704231359);
              yield return new LatLng(29.7286452830721, -95.6195149536285);
              yield return new LatLng(29.7165005405405, -95.6150841621622);
              yield return new LatLng(29.7754238571429, -95.4146705918367);
              yield return new LatLng(29.7638955217391, -95.416356673913);
              yield return new LatLng(29.8158621363636, -95.4731089886364);
              yield return new LatLng(29.814818220134, -95.4329175853244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8617474, -95.5442895);
              yield return new LatLng(29.8462246803518, -95.5438594108749);
              yield return new LatLng(29.9552981707317, -95.4185784390244);
              yield return new LatLng(29.8655175, -95.3661702);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.9564708571429, -95.4232503673469);
              yield return new LatLng(29.9545776767471, -95.4231410911162);
              yield return new LatLng(29.948242, -95.392628);
              yield return new LatLng(29.7838900204082, -95.3371116122449);
              yield return new LatLng(29.8143978989899, -95.3295443535354);
              yield return new LatLng(29.7939288529412, -95.3406607352941);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.8692203265306, -95.3391719387755);
              yield return new LatLng(29.8526813636364, -95.275196010101);
              yield return new LatLng(29.866607, -95.323695);
              yield return new LatLng(29.7598381751594, -95.2741726517419);
              yield return new LatLng(29.7772860632925, -95.2300094889836);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.717746, -95.5199709);
          }
     }

     public class February_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
