using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class December_2017_Rape
     {
         public static IEnumerable<December_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new December_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7276330425532, -95.3206044893617);
              yield return new LatLng(29.6294226326531, -95.3598424489796);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.6620120799246, -95.3154101094391);
              yield return new LatLng(29.7066872, -95.399023);
              yield return new LatLng(29.6343323265306, -95.3648555102041);
              yield return new LatLng(29.615263020202, -95.4214666767677);
              yield return new LatLng(29.615304114094, -95.4789130738255);
              yield return new LatLng(29.755690119403, -95.4975524029851);
              yield return new LatLng(29.6395925357143, -95.50304725);
              yield return new LatLng(29.8316264, -95.7543887);
              yield return new LatLng(29.6956159, -95.5859441);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.750601, -95.6200225);
              yield return new LatLng(29.8265719591313, -95.3585101412288);
              yield return new LatLng(29.8087297919463, -95.363288114094);
              yield return new LatLng(29.8536633533685, -95.4017011709818);
              yield return new LatLng(29.8645851634975, -95.4267113931125);
              yield return new LatLng(29.7945132121212, -95.3187956969697);
              yield return new LatLng(29.8098985121951, -95.3897417073171);
              yield return new LatLng(29.826782877551, -95.3090048979592);
              yield return new LatLng(29.7834760284321, -95.1962708406092);
              yield return new LatLng(29.7735741836735, -95.2100990204082);
          }
     }

     public class December_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
