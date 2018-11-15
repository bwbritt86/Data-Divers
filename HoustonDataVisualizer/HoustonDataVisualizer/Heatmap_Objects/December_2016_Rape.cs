using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class December_2016_Rape
     {
         public static IEnumerable<December_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new December_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7337368974359, -95.3289387692308);
              yield return new LatLng(29.7397936938776, -95.326234122449);
              yield return new LatLng(29.728077, -95.332184);
              yield return new LatLng(29.7300243421053, -95.3565575526316);
              yield return new LatLng(29.7082498947368, -95.4019241578947);
              yield return new LatLng(29.7145610408163, -95.3969194693878);
              yield return new LatLng(29.7190727539908, -95.3941621985548);
              yield return new LatLng(29.7181797346939, -95.4175567755102);
              yield return new LatLng(29.730983625, -95.309527375);
              yield return new LatLng(29.6795284899329, -95.2568642483221);
              yield return new LatLng(29.6897934615385, -95.2357523846154);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.6980601081081, -95.3060919189189);
              yield return new LatLng(29.6937842727273, -95.2973813333333);
              yield return new LatLng(29.662363551361, -95.2912356266797);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6877243242131, -95.3754131531957);
              yield return new LatLng(29.6673788691283, -95.333970129139);
              yield return new LatLng(29.6425081941306, -95.4919546995366);
              yield return new LatLng(29.7038957681654, -95.3814972171098);
              yield return new LatLng(29.6976419567298, -95.3988842164514);
              yield return new LatLng(29.6419491192042, -95.4032792024292);
              yield return new LatLng(29.6066575121951, -95.434648097561);
              yield return new LatLng(29.6030294873665, -95.465377093983);
              yield return new LatLng(29.7094035454545, -95.5026453409091);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6687234444444, -95.5042262525253);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7336044230769, -95.4897194038462);
              yield return new LatLng(29.709130775433, -95.5109674926786);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7327835, -95.5716659);
              yield return new LatLng(29.6744348367347, -95.5621118163265);
              yield return new LatLng(29.6958095, -95.5522755);
              yield return new LatLng(29.7061437857143, -95.6060566428571);
              yield return new LatLng(29.6626810671141, -95.5682114630873);
              yield return new LatLng(29.7592542857143, -95.3611800408163);
              yield return new LatLng(29.7523407489211, -95.3604139519699);
              yield return new LatLng(29.756719798995, -95.3912218743719);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7358126734694, -95.3853000612245);
              yield return new LatLng(29.7542091632653, -95.3820960612245);
              yield return new LatLng(29.7615550600459, -95.3917107076763);
              yield return new LatLng(29.7365447, -95.5531697);
              yield return new LatLng(29.7357246783175, -95.5979932235881);
              yield return new LatLng(29.7305870438773, -95.5943704231359);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.750601, -95.6200225);
              yield return new LatLng(29.8140246479224, -95.4493728729227);
              yield return new LatLng(29.79272316, -95.54022348);
              yield return new LatLng(29.8014901020408, -95.5699578979592);
              yield return new LatLng(29.815380127907, -95.4850717790698);
              yield return new LatLng(29.8098218237182, -95.5024767653921);
              yield return new LatLng(29.8489989010497, -95.5469826348961);
              yield return new LatLng(29.9496847596783, -95.546969696259);
              yield return new LatLng(29.8569061086957, -95.3942959565217);
              yield return new LatLng(29.8542808571429, -95.3720074897959);
              yield return new LatLng(29.8702994411765, -95.4803466764706);
              yield return new LatLng(29.9590155770382, -95.4235065229033);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.8488248297479, -95.3427845473333);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8579966934673, -95.3185071557789);
              yield return new LatLng(29.8287551704548, -95.2823448107087);
              yield return new LatLng(29.8101730816327, -95.2854869591837);
              yield return new LatLng(29.8483329795918, -95.2582884693878);
              yield return new LatLng(29.8414482357095, -95.251867576782);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.8579576969697, -95.2540926666667);
              yield return new LatLng(29.854973941334, -95.2662207688778);
              yield return new LatLng(29.8760884545455, -95.2848672272727);
              yield return new LatLng(29.8149896501543, -95.2029275872449);
              yield return new LatLng(29.7778867692308, -95.2184311538462);
              yield return new LatLng(29.7314025102041, -95.3308536938775);
          }
     }

     public class December_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
