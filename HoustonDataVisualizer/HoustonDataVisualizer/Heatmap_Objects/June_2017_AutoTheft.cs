using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class June_2017_AutoTheft
     {
         public static IEnumerable<June_2017_AutoTheft_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new June_2017_AutoTheft_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7605008424654, -95.3475910120928);
              yield return new LatLng(29.6291626363636, -95.2746160606061);
              yield return new LatLng(29.6676643396226, -95.6170062641509);
              yield return new LatLng(29.7357806122449, -95.3671203673469);
              yield return new LatLng(29.6544753469388, -95.3455946122449);
              yield return new LatLng(29.7022014186559, -95.3703776181183);
              yield return new LatLng(29.7201699591837, -95.3812609591837);
              yield return new LatLng(29.5873103877551, -95.2017382857143);
              yield return new LatLng(29.7040147201308, -95.3817622182065);
              yield return new LatLng(29.7133430612245, -95.4137486530612);
              yield return new LatLng(29.8406667346939, -95.4631259183674);
              yield return new LatLng(29.7549829, -95.3352614);
              yield return new LatLng(29.7204933703704, -95.3178608641975);
              yield return new LatLng(29.7341759795918, -95.290358244898);
              yield return new LatLng(29.6994431337793, -95.2428438862876);
              yield return new LatLng(29.768186, -95.354241);
              yield return new LatLng(29.6501963535354, -95.2452555555556);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.6354136666667, -95.243653);
              yield return new LatLng(29.6444861632653, -95.2452819795918);
              yield return new LatLng(29.6146949614861, -95.2542115019568);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.64598190625, -95.24613534375);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6077740609422, -95.2682314195937);
              yield return new LatLng(29.5927068582229, -95.202724015684);
              yield return new LatLng(29.6949963602078, -95.309353005516);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.8447366, -95.4921838);
              yield return new LatLng(29.7018425, -95.3022532);
              yield return new LatLng(29.663021295302, -95.2650825167785);
              yield return new LatLng(29.6540009854422, -95.2539019458452);
              yield return new LatLng(29.6439573265306, -95.3048798367347);
              yield return new LatLng(29.6439573265306, -95.3048798367347);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6852015918367, -95.3592598979592);
              yield return new LatLng(29.693798, -95.3753406666667);
              yield return new LatLng(29.6678296161616, -95.3582945454545);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6810235135135, -95.3457568918919);
              yield return new LatLng(29.6728892653061, -95.4311644081633);
              yield return new LatLng(29.766979, -95.3739084);
              yield return new LatLng(29.6583187179487, -95.4487292051282);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.611800132337, -95.4497360813895);
              yield return new LatLng(29.6355319432654, -95.4236145903422);
              yield return new LatLng(29.633581244898, -95.4400118367347);
              yield return new LatLng(29.6335504242424, -95.4416492727273);
              yield return new LatLng(29.6310137462454, -95.423540989901);
              yield return new LatLng(29.62826351662, -95.4576641356126);
              yield return new LatLng(29.7162882222222, -95.4898858888889);
              yield return new LatLng(29.7229072289599, -95.4889334123641);
              yield return new LatLng(29.7199316530612, -95.4884875714286);
              yield return new LatLng(29.7151402828283, -95.4888438181818);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.6950476746988, -95.4844215903614);
              yield return new LatLng(29.714632022459, -95.4752566313497);
              yield return new LatLng(29.5800079, -95.5178773);
              yield return new LatLng(29.725472, -95.48764);
              yield return new LatLng(29.7300991020408, -95.4813865918367);
              yield return new LatLng(29.7806491730922, -95.4860403681769);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7382243, -95.3803352);
              yield return new LatLng(29.7129428823529, -95.5176169411765);
              yield return new LatLng(29.7382243, -95.3803352);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.740568952381, -95.5315747142857);
              yield return new LatLng(29.7277679651384, -95.5141470880828);
              yield return new LatLng(29.7246805530401, -95.5153622980034);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.91583034362, -95.3451412578879);
              yield return new LatLng(29.7496714693878, -95.3756741632653);
              yield return new LatLng(29.752579122449, -95.3835207959184);
              yield return new LatLng(29.7383477142857, -95.3897665918367);
              yield return new LatLng(29.74682425, -95.4092397954545);
              yield return new LatLng(29.7394437346939, -95.4006405102041);
              yield return new LatLng(29.7461647142857, -95.3955154693878);
              yield return new LatLng(29.7393843061224, -95.4057486326531);
              yield return new LatLng(29.7783099189189, -95.416645);
              yield return new LatLng(29.626281089053, -95.4250524496096);
              yield return new LatLng(29.717628755102, -95.5450521836735);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.717243, -95.610042);
              yield return new LatLng(29.7447932020202, -95.5762127272727);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7692075, -95.546784337133);
              yield return new LatLng(29.7692075, -95.546784337133);
              yield return new LatLng(29.7855212283284, -95.6780460111124);
              yield return new LatLng(29.7855212283284, -95.6780460111124);
              yield return new LatLng(29.7841493421053, -95.6032477894737);
              yield return new LatLng(29.7841590909091, -95.6000317272727);
              yield return new LatLng(29.7841590909091, -95.6000317272727);
              yield return new LatLng(29.7855212283284, -95.6780460111124);
              yield return new LatLng(29.7855212283284, -95.6780460111124);
              yield return new LatLng(29.782336, -95.6298665);
              yield return new LatLng(29.8297212964824, -95.3970490904523);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.794073877551, -95.3565726326531);
              yield return new LatLng(29.82362425, -95.5314646252594);
              yield return new LatLng(29.7932381020408, -95.3585612857143);
              yield return new LatLng(29.7791193673469, -95.353914877551);
              yield return new LatLng(29.8121333061225, -95.402668);
              yield return new LatLng(29.8098197346939, -95.3952947959184);
              yield return new LatLng(29.7704622, -95.4137459);
              yield return new LatLng(29.7933212244898, -95.4056886122449);
              yield return new LatLng(29.793904, -95.4410419230769);
              yield return new LatLng(29.8299475789474, -95.4848863421053);
              yield return new LatLng(29.8179905036284, -95.4862993015965);
              yield return new LatLng(29.8168572909137, -95.4515815264817);
              yield return new LatLng(29.8233965623645, -95.4467597427994);
              yield return new LatLng(29.8205054744526, -95.4391011240876);
              yield return new LatLng(29.8147607660836, -95.3693806183138);
              yield return new LatLng(29.7972153265306, -95.5402894285714);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.8051338571429, -95.4849743877551);
              yield return new LatLng(29.7856323, -95.7949143);
              yield return new LatLng(29.792734956044, -95.4653801868132);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8041873384615, -95.4775817692308);
              yield return new LatLng(29.8314999387755, -95.5208779795918);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8815137272727, -95.5030664848485);
              yield return new LatLng(29.8735299090909, -95.3826009393939);
              yield return new LatLng(29.8731845918367, -95.3962929387755);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8536633533685, -95.4017011709818);
              yield return new LatLng(29.8562817491411, -95.3781317915176);
              yield return new LatLng(29.8061726557308, -95.4224938236157);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.9545776767471, -95.4231410911162);
              yield return new LatLng(29.805426, -95.570929);
              yield return new LatLng(29.7846234081633, -95.313901877551);
              yield return new LatLng(29.7955959393939, -95.3294973939394);
              yield return new LatLng(29.79016928125, -95.3352142708333);
              yield return new LatLng(29.7901575510204, -95.3332462244898);
              yield return new LatLng(29.8068333869347, -95.3108900251256);
              yield return new LatLng(29.849454, -95.3296437);
              yield return new LatLng(29.837831, -95.3457037435898);
              yield return new LatLng(29.8098197346939, -95.3952947959184);
              yield return new LatLng(29.8252623142857, -95.3377510571429);
              yield return new LatLng(29.8060707142857, -95.3134787142857);
              yield return new LatLng(29.8633086784444, -95.3016001951407);
              yield return new LatLng(29.6103906413043, -95.4439871630435);
              yield return new LatLng(29.9297094954795, -95.1777536629695);
              yield return new LatLng(29.81693, -95.284544);
              yield return new LatLng(29.8418246090965, -95.2623568842002);
              yield return new LatLng(29.8709198823529, -95.419726);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.7790868057259, -95.2397105184117);
              yield return new LatLng(29.790038381295, -95.2784273453237);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.7789621833333, -95.2358504666667);
              yield return new LatLng(29.7646754166667, -95.21540675);
              yield return new LatLng(29.7840460728407, -95.1998950714876);
              yield return new LatLng(29.767021, -95.296097);
          }
     }

     public class June_2017_AutoTheft_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
