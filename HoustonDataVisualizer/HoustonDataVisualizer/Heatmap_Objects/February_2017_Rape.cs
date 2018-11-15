using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class February_2017_Rape
     {
         public static IEnumerable<February_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new February_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.7190014845361, -95.3501720412371);
              yield return new LatLng(29.742485, -95.35374);
              yield return new LatLng(29.7282058275862, -95.3508984482759);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.7082498947368, -95.4019241578947);
              yield return new LatLng(29.730467796875, -95.32037403125);
              yield return new LatLng(29.7092473333333, -95.2827966969697);
              yield return new LatLng(29.6783173171561, -95.269263597);
              yield return new LatLng(29.7000365714286, -95.2741798163265);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6762639795918, -95.2671933469388);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.5995028888889, -95.2124114040404);
              yield return new LatLng(29.6384852046948, -95.2080442867469);
              yield return new LatLng(29.7007125102041, -95.3079606530612);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6680608383838, -95.2727770505051);
              yield return new LatLng(29.6599000204179, -95.3654337311903);
              yield return new LatLng(29.6611652653061, -95.3459487755102);
              yield return new LatLng(29.6822125101691, -95.3440453420983);
              yield return new LatLng(29.753442, -95.366406);
              yield return new LatLng(29.6988202, -95.3868178);
              yield return new LatLng(29.699108082633, -95.4865565990251);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.804749, -95.264772);
              yield return new LatLng(29.7428494817681, -95.4670921739597);
              yield return new LatLng(29.7324744375, -95.51954746875);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.6751237578125, -95.5544101328125);
              yield return new LatLng(29.6864043469388, -95.5651479183674);
              yield return new LatLng(29.6995915, -95.5890850714286);
              yield return new LatLng(29.6851229534884, -95.5757647674419);
              yield return new LatLng(29.7492859591837, -95.3703482244898);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.736293, -95.416337);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.80760825, -95.37401575);
              yield return new LatLng(29.7647492902612, -95.3918393689879);
              yield return new LatLng(29.817079764908, -95.4750750462904);
              yield return new LatLng(29.8253026044366, -95.481246477251);
              yield return new LatLng(29.8386150995638, -95.3942039350482);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.8398161818182, -95.3749873636364);
              yield return new LatLng(29.8025261020408, -95.5432254489796);
              yield return new LatLng(29.8063543673469, -95.5361800408163);
              yield return new LatLng(29.8074847227575, -95.4876262841537);
              yield return new LatLng(29.827025, -95.50913);
              yield return new LatLng(29.815380127907, -95.4850717790698);
              yield return new LatLng(29.815380127907, -95.4850717790698);
              yield return new LatLng(29.8090355855364, -95.4911185014885);
              yield return new LatLng(29.9552981707317, -95.4185784390244);
              yield return new LatLng(29.9537134088502, -95.4184086546896);
              yield return new LatLng(29.8545150457186, -95.3625804072535);
              yield return new LatLng(29.8463720204082, -95.3718984285714);
              yield return new LatLng(29.88271936, -95.47395928);
              yield return new LatLng(29.8858661836735, -95.5007562040816);
              yield return new LatLng(29.941658244898, -95.4418860204082);
              yield return new LatLng(29.948242, -95.392628);
              yield return new LatLng(29.946196621034, -95.4351549684004);
              yield return new LatLng(29.7946879504169, -95.3223419194289);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8340877292382, -95.3028119116251);
              yield return new LatLng(29.835530122449, -95.2856496122449);
              yield return new LatLng(29.8102733030303, -95.2822128484848);
              yield return new LatLng(29.8308868104145, -95.2594714354931);
              yield return new LatLng(29.8186603316806, -95.2100417133808);
              yield return new LatLng(29.6877955192308, -95.4327350961538);
          }
     }

     public class February_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
