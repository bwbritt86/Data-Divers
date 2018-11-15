using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class September_2016_Rape
     {
         public static IEnumerable<September_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new September_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7605008424654, -95.3475910120928);
              yield return new LatLng(29.7439486530612, -95.3669608571429);
              yield return new LatLng(29.704269914529, -95.382283698411);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7035717647059, -95.290419);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.68691, -95.3168931818182);
              yield return new LatLng(29.7083304277214, -95.3132260418012);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6803892272727, -95.3633287828283);
              yield return new LatLng(29.6618270769231, -95.3554694871795);
              yield return new LatLng(29.5438589, -95.3680052);
              yield return new LatLng(29.6743293617114, -95.3804806153121);
              yield return new LatLng(29.668021010101, -95.3592483535354);
              yield return new LatLng(29.6493449653395, -95.3348737826109);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6369992020125, -95.3494007123483);
              yield return new LatLng(29.6430925510204, -95.3614119795918);
              yield return new LatLng(29.6820673018868, -95.4167525849057);
              yield return new LatLng(29.6341460294118, -95.4961811176471);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6398775153154, -95.4952952282314);
              yield return new LatLng(29.6512912012852, -95.5071866101962);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7419375, -95.4826225);
              yield return new LatLng(29.7308087189168, -95.5139903268716);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6909256105245, -95.5896835348798);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.6646335397727, -95.5741205340909);
              yield return new LatLng(29.747461755102, -95.3799320612245);
              yield return new LatLng(29.7489515714286, -95.3762434897959);
              yield return new LatLng(29.7499761836735, -95.3779338571429);
              yield return new LatLng(29.7520665918367, -95.3686781428571);
              yield return new LatLng(29.7301862904032, -95.438226091581);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7433348923834, -95.5743691916883);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7889101020408, -95.387342122449);
              yield return new LatLng(29.7968910612245, -95.4133036122449);
              yield return new LatLng(29.7641789, -95.4094167);
              yield return new LatLng(29.7909320769231, -95.5473729102564);
              yield return new LatLng(29.8125993061224, -95.5399292653061);
              yield return new LatLng(29.8077027294411, -95.4851967992959);
              yield return new LatLng(29.7920872857143, -95.5218854285714);
              yield return new LatLng(29.8293510717917, -95.5004227169421);
              yield return new LatLng(29.8467143392621, -95.3627262998535);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.865595375, -95.47710175);
              yield return new LatLng(29.9436448636364, -95.4035425959596);
              yield return new LatLng(29.9600771318542, -95.4207963287366);
              yield return new LatLng(29.950750755102, -95.3924097346939);
              yield return new LatLng(29.9616060816327, -95.4249402040816);
              yield return new LatLng(29.597819, -95.487495);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.7969644693878, -95.3279762040816);
              yield return new LatLng(29.8393444, -95.4348556400342);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8448270963402, -95.3429787997718);
              yield return new LatLng(29.8617874228188, -95.3477170067114);
              yield return new LatLng(29.8466633288591, -95.3073237718121);
              yield return new LatLng(29.8172025555556, -95.307726);
              yield return new LatLng(29.8323562236604, -95.304923892994);
              yield return new LatLng(29.8261166510067, -95.2785928389262);
              yield return new LatLng(29.8523672978723, -95.2624699574468);
              yield return new LatLng(29.8630064411721, -95.3127633954695);
              yield return new LatLng(29.7650671865995, -95.2714958681338);
              yield return new LatLng(29.7828794897959, -95.3103843877551);
              yield return new LatLng(29.7612358979592, -95.2844415306122);
              yield return new LatLng(29.7747367983871, -95.3160645645161);
          }
     }

     public class September_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
