using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class July_2016_Rape
     {
         public static IEnumerable<July_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new July_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7393783877551, -95.3731163673469);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7539452, -95.3985224);
              yield return new LatLng(29.7167980639169, -95.3771620593951);
              yield return new LatLng(29.7082498947368, -95.4019241578947);
              yield return new LatLng(29.713483, -95.382066);
              yield return new LatLng(29.7145610408163, -95.3969194693878);
              yield return new LatLng(29.704269914529, -95.382283698411);
              yield return new LatLng(29.7300917142857, -95.2917352857143);
              yield return new LatLng(29.6833426, -95.241185);
              yield return new LatLng(29.6486118686869, -95.2451793535353);
              yield return new LatLng(29.6090657755102, -95.2533377346939);
              yield return new LatLng(29.6311308163265, -95.2470917959184);
              yield return new LatLng(29.6175036977997, -95.2340759220485);
              yield return new LatLng(29.6860602222222, -95.3167758888889);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6607355893802, -95.2907424798217);
              yield return new LatLng(29.5994602844416, -95.2515946964297);
              yield return new LatLng(29.6862005151515, -95.3639322424243);
              yield return new LatLng(29.6886353390246, -95.3444935314119);
              yield return new LatLng(29.6816693021011, -95.3681329093048);
              yield return new LatLng(29.6868606968348, -95.3726333214262);
              yield return new LatLng(29.652734, -95.352984);
              yield return new LatLng(29.6235330408163, -95.3639363061225);
              yield return new LatLng(29.6469570590939, -95.3552682822536);
              yield return new LatLng(29.67890675, -95.41930975);
              yield return new LatLng(29.6820673018868, -95.4167525849057);
              yield return new LatLng(29.6141092272727, -95.4240909772727);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6122515854219, -95.3482083376241);
              yield return new LatLng(29.5969139795918, -95.4884061632653);
              yield return new LatLng(29.686059479031, -95.5194517342913);
              yield return new LatLng(29.686059479031, -95.5194517342913);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6627748181818, -95.5418255151515);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6597016326531, -95.4987770408163);
              yield return new LatLng(29.6654119387755, -95.5203619387755);
              yield return new LatLng(29.7635834006181, -95.4787056697866);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7419375, -95.4826225);
              yield return new LatLng(29.7370925, -95.5348915);
              yield return new LatLng(29.7356529591837, -95.5155975306122);
              yield return new LatLng(29.725472, -95.48764);
              yield return new LatLng(29.6965021282051, -95.527715051282);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6675689591837, -95.5848889183673);
              yield return new LatLng(29.6671541462843, -95.5934734820541);
              yield return new LatLng(29.6590724545455, -95.5929534242424);
              yield return new LatLng(29.6699128409086, -95.6006612088196);
              yield return new LatLng(29.725472, -95.48764);
              yield return new LatLng(29.7416360612245, -95.4114296326531);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7788700810166, -95.599328465236);
              yield return new LatLng(29.7293937947045, -95.6489131419321);
              yield return new LatLng(29.7319967625557, -95.6542493208736);
              yield return new LatLng(29.8041447142857, -95.3706554897959);
              yield return new LatLng(29.7647492902612, -95.3918393689879);
              yield return new LatLng(29.8240488518518, -95.4841149259259);
              yield return new LatLng(29.8259213691275, -95.390121852349);
              yield return new LatLng(29.828551122449, -95.4033865918367);
              yield return new LatLng(29.8271409795918, -95.3862515918367);
              yield return new LatLng(29.8192426734694, -95.3612529591837);
              yield return new LatLng(29.9329496, -95.5075622);
              yield return new LatLng(29.9329496, -95.5075622);
              yield return new LatLng(29.9537134088502, -95.4184086546896);
              yield return new LatLng(29.8563108208498, -95.5054849075491);
              yield return new LatLng(29.8485753478261, -95.384621173913);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.9545776767471, -95.4231410911162);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.9564708571429, -95.4232503673469);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.8594548389318, -95.3357859818607);
              yield return new LatLng(29.8393092059943, -95.3303376271509);
              yield return new LatLng(29.8481073290278, -95.352268407083);
              yield return new LatLng(29.83875323412, -95.3286448290628);
              yield return new LatLng(29.8342939183673, -95.3159668571429);
              yield return new LatLng(29.8208190822024, -95.3294601203279);
              yield return new LatLng(29.8797861502108, -95.2848536971191);
              yield return new LatLng(29.7647000959957, -95.196077545155);
              yield return new LatLng(29.768018, -95.2163005);
              yield return new LatLng(29.9518719310092, -95.412631486972);
          }
     }

     public class July_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
