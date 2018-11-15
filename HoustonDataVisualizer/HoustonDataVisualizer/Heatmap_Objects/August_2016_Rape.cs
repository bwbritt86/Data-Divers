using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class August_2016_Rape
     {
         public static IEnumerable<August_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new August_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.740623244898, -95.3797836938776);
              yield return new LatLng(29.711500030635, -95.3993462895355);
              yield return new LatLng(29.7092812679204, -95.405005760788);
              yield return new LatLng(29.7276330425532, -95.3206044893617);
              yield return new LatLng(29.7260097142857, -95.2885923265306);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6247271643851, -95.2439637653133);
              yield return new LatLng(29.6209803673469, -95.2544454489796);
              yield return new LatLng(29.5562561990576, -95.1273209818064);
              yield return new LatLng(29.6980601081081, -95.3060919189189);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.6953771410578, -95.3362653347718);
              yield return new LatLng(29.6938504693878, -95.3393275510204);
              yield return new LatLng(29.643985, -95.372117);
              yield return new LatLng(29.6612971836735, -95.3632052244898);
              yield return new LatLng(29.6686343937013, -95.3693569764185);
              yield return new LatLng(29.6784107777778, -95.3558421111111);
              yield return new LatLng(29.6834457, -95.3656674);
              yield return new LatLng(29.6691536896552, -95.3475393448276);
              yield return new LatLng(29.6626897959184, -95.326881877551);
              yield return new LatLng(29.6509721428571, -95.4770705238095);
              yield return new LatLng(29.6222259979309, -95.398475886578);
              yield return new LatLng(29.6414946441004, -95.4017707814504);
              yield return new LatLng(29.6123189432289, -95.3652914018306);
              yield return new LatLng(29.6326872071708, -95.4960132108338);
              yield return new LatLng(29.7200126229844, -95.4819969997463);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6620113030303, -95.5418081515152);
              yield return new LatLng(29.6378818041522, -95.4952816522666);
              yield return new LatLng(29.6478872653061, -95.5172489183673);
              yield return new LatLng(29.665709, -95.5105907070707);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7159176346154, -95.5104988846154);
              yield return new LatLng(29.6932384615385, -95.5836745384615);
              yield return new LatLng(29.6988976, -95.4971316);
              yield return new LatLng(29.6632977587128, -95.5801784133766);
              yield return new LatLng(29.6832395032041, -95.6028781493761);
              yield return new LatLng(29.6697977959184, -95.5810964693878);
              yield return new LatLng(29.667201, -95.5638987586207);
              yield return new LatLng(29.7542996326531, -95.3669135510204);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.770085244898, -95.6000634897959);
              yield return new LatLng(29.8085629387755, -95.3560045510204);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.7933879539433, -95.4013196252361);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.832435875, -95.39693675);
              yield return new LatLng(29.7641789, -95.4094167);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.82362425, -95.5314646252594);
              yield return new LatLng(29.7852122040816, -95.569893);
              yield return new LatLng(29.8241359795918, -95.522740244898);
              yield return new LatLng(29.8294505, -95.505946);
              yield return new LatLng(29.84128990625, -95.49962675);
              yield return new LatLng(29.8487311792802, -95.5092121169546);
              yield return new LatLng(29.8840680617284, -95.3742204938272);
              yield return new LatLng(29.878753030303, -95.433661030303);
              yield return new LatLng(29.9252572805138, -95.4040057959984);
              yield return new LatLng(29.920472111679, -95.4068398655152);
              yield return new LatLng(29.9252572805138, -95.4040057959984);
              yield return new LatLng(29.7790405306122, -95.3467579183673);
              yield return new LatLng(29.7937332655659, -95.3207409357552);
              yield return new LatLng(29.7983018592965, -95.3080374874372);
              yield return new LatLng(29.7847814285714, -95.3360720816327);
              yield return new LatLng(29.8607583082707, -95.3561179172932);
              yield return new LatLng(29.8236026725049, -95.3196157830781);
              yield return new LatLng(29.8206134489796, -95.3338874285714);
              yield return new LatLng(29.8443375539285, -95.2901979956004);
              yield return new LatLng(29.8245901631216, -95.272945766192);
              yield return new LatLng(29.8588452323232, -95.2523994747475);
              yield return new LatLng(29.8675218397364, -95.2917130957098);
              yield return new LatLng(29.770006, -95.350268);
              yield return new LatLng(29.8198773469388, -95.2401789387755);
              yield return new LatLng(29.7912115, -95.205692);
              yield return new LatLng(29.770006, -95.350268);
          }
     }

     public class August_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
