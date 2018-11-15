using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class June_2016_Rape
     {
         public static IEnumerable<June_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new June_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7169242899554, -95.3729768817224);
              yield return new LatLng(29.699746131841, -95.3772832776698);
              yield return new LatLng(29.711500030635, -95.3993462895355);
              yield return new LatLng(29.654483, -95.2476549);
              yield return new LatLng(29.582874943038, -95.2093695063291);
              yield return new LatLng(29.6630417651007, -95.2638808389262);
              yield return new LatLng(29.6968743564569, -95.3636747224282);
              yield return new LatLng(29.6870116530612, -95.3562005918367);
              yield return new LatLng(29.6899647474747, -95.3648241515152);
              yield return new LatLng(29.6930211, -95.3704613);
              yield return new LatLng(29.6897806122449, -95.3665032244898);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.688506, -95.331849);
              yield return new LatLng(29.6793262445343, -95.3474359232702);
              yield return new LatLng(29.6682973333333, -95.3436131212121);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.640487, -95.42907);
              yield return new LatLng(29.606104, -95.449994);
              yield return new LatLng(29.7090970775559, -95.4836200414101);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6631406447368, -95.50366325);
              yield return new LatLng(29.7304647894737, -95.4958658026316);
              yield return new LatLng(29.6891331052632, -95.5745592105263);
              yield return new LatLng(29.703390119403, -95.6057077910448);
              yield return new LatLng(29.7068865757576, -95.596130030303);
              yield return new LatLng(29.725472, -95.48764);
              yield return new LatLng(29.7603227755102, -95.3621540612245);
              yield return new LatLng(29.7609851041723, -95.576358255897);
              yield return new LatLng(29.7165005405405, -95.6150841621622);
              yield return new LatLng(29.7381136531329, -95.6136149506046);
              yield return new LatLng(29.7771509591837, -95.3653108367347);
              yield return new LatLng(29.812275, -95.376075);
              yield return new LatLng(29.8386523, -95.402823);
              yield return new LatLng(29.7796752536924, -95.4254141113931);
              yield return new LatLng(29.7961984054054, -95.4410111081081);
              yield return new LatLng(29.8140331886792, -95.4508896226415);
              yield return new LatLng(29.825405, -95.4623310909091);
              yield return new LatLng(29.8232782063492, -95.4594408412698);
              yield return new LatLng(29.828074794328, -95.4003307741891);
              yield return new LatLng(29.836863287234, -95.4030091489362);
              yield return new LatLng(29.8287126486486, -95.3822969189189);
              yield return new LatLng(29.8352320454545, -95.3758997045454);
              yield return new LatLng(29.8165558194444, -95.3546585138889);
              yield return new LatLng(29.8145305510204, -95.3612520612245);
              yield return new LatLng(29.8215642266573, -95.5413992989268);
              yield return new LatLng(29.8125993061224, -95.5399292653061);
              yield return new LatLng(29.8063734693878, -95.5339771428571);
              yield return new LatLng(29.8059215102041, -95.5408354693878);
              yield return new LatLng(29.7855947296705, -95.693187162656);
              yield return new LatLng(29.9552981707317, -95.4185784390244);
              yield return new LatLng(29.8412559850727, -95.5044782316377);
              yield return new LatLng(29.8486792040816, -95.5117476530612);
              yield return new LatLng(29.8736431818182, -95.3746700606061);
              yield return new LatLng(29.8675903576584, -95.3978816936079);
              yield return new LatLng(29.922370101344, -95.4070732752013);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.9545776767471, -95.4231410911162);
              yield return new LatLng(29.7891072857143, -95.3359690204082);
              yield return new LatLng(29.7847494081633, -95.3378774285714);
              yield return new LatLng(29.7959111395349, -95.3373506976744);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.8257172189262, -95.3426854904308);
              yield return new LatLng(29.8325731879195, -95.3189499731544);
              yield return new LatLng(29.8200685113115, -95.3186279159413);
              yield return new LatLng(29.8539362323382, -95.2624842332493);
              yield return new LatLng(29.8686038451231, -95.310478769908);
              yield return new LatLng(29.7938942121212, -95.2528162424242);
              yield return new LatLng(29.775889, -95.2191189795918);
          }
     }

     public class June_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
