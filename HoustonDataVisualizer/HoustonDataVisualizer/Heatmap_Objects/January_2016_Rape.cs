using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class January_2016_Rape
     {
         public static IEnumerable<January_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new January_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7605008424654, -95.3475910120928);
              yield return new LatLng(29.8315618, -95.7601274);
              yield return new LatLng(29.7483258163265, -95.3716365714286);
              yield return new LatLng(29.7022014186559, -95.3703776181183);
              yield return new LatLng(29.7169403517588, -95.3646727135678);
              yield return new LatLng(29.7268636530612, -95.3830445306123);
              yield return new LatLng(29.711500030635, -95.3993462895355);
              yield return new LatLng(29.6903483613191, -95.3805342326081);
              yield return new LatLng(29.7082498947368, -95.4019241578947);
              yield return new LatLng(29.7338817105263, -95.3012050921053);
              yield return new LatLng(29.7240054996934, -95.2979788763859);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.542893, -95.154053);
              yield return new LatLng(29.6667390853101, -95.3060818756323);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.70296, -95.3398563061224);
              yield return new LatLng(29.6954988238105, -95.3418559518546);
              yield return new LatLng(29.698499375, -95.357099625);
              yield return new LatLng(29.6702426, -95.3556421);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6702426, -95.3556421);
              yield return new LatLng(29.6637635102041, -95.3670601632653);
              yield return new LatLng(29.651732, -95.3656409795918);
              yield return new LatLng(29.647198, -95.343041);
              yield return new LatLng(29.6838386533721, -95.3310033347102);
              yield return new LatLng(29.7036331, -95.6169583);
              yield return new LatLng(29.674205755102, -95.4984764693878);
              yield return new LatLng(29.6875329038047, -95.3951908920714);
              yield return new LatLng(29.626152423913, -95.4345183478261);
              yield return new LatLng(29.6088151707317, -95.4426616097561);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.707378755102, -95.4733342857143);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.6760473124966, -95.5393092694078);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6378818041522, -95.4952816522666);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.736943122449, -95.5140935918367);
              yield return new LatLng(29.7190986850342, -95.5007892833723);
              yield return new LatLng(29.7106817878788, -95.5163259393939);
              yield return new LatLng(29.6871205656566, -95.544614040404);
              yield return new LatLng(29.69661875, -95.5959391428571);
              yield return new LatLng(29.7068865757576, -95.596130030303);
              yield return new LatLng(29.6613526651213, -95.59522547799);
              yield return new LatLng(29.6744348367347, -95.5621118163265);
              yield return new LatLng(29.6669040081159, -95.5743823403985);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7488286734694, -95.3775965918367);
              yield return new LatLng(29.7328670125864, -95.5458306290917);
              yield return new LatLng(29.7070995306122, -95.5455681020408);
              yield return new LatLng(29.7328670125864, -95.5458306290917);
              yield return new LatLng(29.7415746489671, -95.5891840441326);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.758054, -95.527859);
              yield return new LatLng(29.7823926734694, -95.3596505102041);
              yield return new LatLng(29.802121125, -95.3842999166667);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.7704622, -95.4137459);
              yield return new LatLng(29.7720079, -95.5590776);
              yield return new LatLng(29.7624126161616, -95.4193159494949);
              yield return new LatLng(29.7751227346939, -95.4159218979592);
              yield return new LatLng(29.770378122449, -95.3979514489796);
              yield return new LatLng(29.822311, -95.4667637142857);
              yield return new LatLng(29.8259213691275, -95.390121852349);
              yield return new LatLng(29.7895843, -95.1044499);
              yield return new LatLng(29.8241086938775, -95.4027448571429);
              yield return new LatLng(29.8617474, -95.5442895);
              yield return new LatLng(29.7961217296334, -95.5544665574907);
              yield return new LatLng(29.8069903759351, -95.4877945651173);
              yield return new LatLng(29.964267244898, -95.4192767346939);
              yield return new LatLng(29.855893969697, -95.3965295454546);
              yield return new LatLng(29.9545776767471, -95.4231410911162);
              yield return new LatLng(29.7808665, -95.323803);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.8032297101435, -95.3206943365161);
              yield return new LatLng(29.8221492727273, -95.3363320909091);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.865470244898, -95.3059613877551);
              yield return new LatLng(29.770006, -95.350268);
              yield return new LatLng(29.8439139316535, -95.655773639327);
          }
     }

     public class January_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
