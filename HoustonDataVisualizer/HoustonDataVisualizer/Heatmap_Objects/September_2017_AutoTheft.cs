using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class September_2017_AutoTheft
     {
         public static IEnumerable<September_2017_AutoTheft_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new September_2017_AutoTheft_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7578716666667, -95.3495824646465);
              yield return new LatLng(29.7484777755102, -95.3248424285714);
              yield return new LatLng(29.7291212653061, -95.3256452857143);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7143901428571, -95.3647654693878);
              yield return new LatLng(29.710207, -95.380721);
              yield return new LatLng(29.7277376363636, -95.3876282121212);
              yield return new LatLng(29.7258965675676, -95.3775903243243);
              yield return new LatLng(29.7395985714286, -95.2997669795918);
              yield return new LatLng(29.6502316, -95.4046619);
              yield return new LatLng(29.7069821818182, -95.2987279090909);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.6993487878788, -95.2777477878788);
              yield return new LatLng(29.6562624848485, -95.2506577878788);
              yield return new LatLng(29.6691282, -95.3516875);
              yield return new LatLng(29.768186, -95.354241);
              yield return new LatLng(29.6354136666667, -95.243653);
              yield return new LatLng(29.623515, -95.2377083);
              yield return new LatLng(29.6023906432989, -95.2481139661855);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.6362163939394, -95.2326963939394);
              yield return new LatLng(29.639573244898, -95.2258012653061);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6407349060403, -95.2583479127517);
              yield return new LatLng(29.8600650408163, -95.255142);
              yield return new LatLng(29.7287188080808, -95.4831165050505);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6938869125107, -95.5717344460859);
              yield return new LatLng(29.6802218979592, -95.3141495714286);
              yield return new LatLng(29.6924581836735, -95.2816024897959);
              yield return new LatLng(29.662114, -95.2888787);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.9029767228303, -95.4254984116873);
              yield return new LatLng(29.6991694285714, -95.3605838163265);
              yield return new LatLng(29.6945055, -95.3268075);
              yield return new LatLng(29.6544964242424, -95.3430012121212);
              yield return new LatLng(29.6622704624776, -95.3503722593857);
              yield return new LatLng(29.6765778979592, -95.3518949387755);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.5423261, -95.363748);
              yield return new LatLng(29.6811199756098, -95.4864097073171);
              yield return new LatLng(29.9572799539242, -95.486516433424);
              yield return new LatLng(29.633581244898, -95.4400118367347);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6817793718593, -95.5108087839196);
              yield return new LatLng(29.6851768235332, -95.5249320589629);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.6736384141414, -95.5403718181818);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7256830434783, -95.4998258695652);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.74496, -95.497518);
              yield return new LatLng(29.7280413673469, -95.518170877551);
              yield return new LatLng(29.7236779756098, -95.5219004634146);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7151986873591, -95.5199305635968);
              yield return new LatLng(29.8733531, -95.7037225);
              yield return new LatLng(29.683358, -95.600309);
              yield return new LatLng(29.6696287927198, -95.5329880194957);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.788717, -95.552065);
              yield return new LatLng(29.703382322238, -95.6121888350957);
              yield return new LatLng(29.6774892702703, -95.6010396756757);
              yield return new LatLng(29.7549829, -95.3352614);
              yield return new LatLng(29.7619642626263, -95.3600733838384);
              yield return new LatLng(29.7340824897959, -95.3207326326531);
              yield return new LatLng(29.761542755102, -95.3593748571429);
              yield return new LatLng(29.7513880624861, -95.3730432071743);
              yield return new LatLng(29.7533646373262, -95.3607325708222);
              yield return new LatLng(29.7544650204082, -95.3773394285714);
              yield return new LatLng(29.7398416666667, -95.3849831212121);
              yield return new LatLng(29.7484876734694, -95.3816411020408);
              yield return new LatLng(29.7465749183673, -95.3776024081633);
              yield return new LatLng(29.7351086734694, -95.4031836122449);
              yield return new LatLng(29.6542128571429, -95.4777820408163);
              yield return new LatLng(29.739414, -95.418632);
              yield return new LatLng(29.7394866326531, -95.396600755102);
              yield return new LatLng(29.8285465046056, -95.3096213797298);
              yield return new LatLng(29.7549916122449, -95.3979736122449);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.73168523361, -95.6364232322608);
              yield return new LatLng(29.74032015, -95.5763157166667);
              yield return new LatLng(29.782336, -95.6298665);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7688092857143, -95.3676236326531);
              yield return new LatLng(29.8386523, -95.402823);
              yield return new LatLng(29.8314308, -95.5026231333333);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.607700047619, -95.3169804761905);
              yield return new LatLng(29.8462380234928, -95.3689792819734);
              yield return new LatLng(29.818997356293, -95.3573518062021);
              yield return new LatLng(29.8582534426934, -95.3675251230724);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7953492244898, -95.5699250204082);
              yield return new LatLng(29.7889496090067, -95.576656);
              yield return new LatLng(29.7842485918367, -95.6218925306122);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.6014754747956, -95.4577900478213);
              yield return new LatLng(29.8165962040816, -95.4853461020408);
              yield return new LatLng(29.8315618, -95.7601274);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8412685115201, -95.5145731522961);
              yield return new LatLng(29.8570436326531, -95.4107986530612);
              yield return new LatLng(29.8528709183673, -95.5155002040816);
              yield return new LatLng(29.8365048, -95.5369829);
              yield return new LatLng(29.8541153048781, -95.4031341707317);
              yield return new LatLng(29.8558366875, -95.382625625);
              yield return new LatLng(29.8570436326531, -95.4107986530612);
              yield return new LatLng(29.870225, -95.498739);
              yield return new LatLng(29.9000049353638, -95.408509);
              yield return new LatLng(29.9600771318542, -95.4207963287366);
              yield return new LatLng(29.7923723939394, -95.7347128484848);
              yield return new LatLng(29.7754900454545, -95.3319771590909);
              yield return new LatLng(29.7718359550706, -95.3462190887745);
              yield return new LatLng(29.7898194081633, -95.3180773877551);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.7921808484849, -95.3277542424242);
              yield return new LatLng(29.8207844489796, -95.3213839183674);
              yield return new LatLng(29.9066849825293, -95.3297297267807);
              yield return new LatLng(29.8251993489933, -95.3317358724832);
              yield return new LatLng(29.820022, -95.292341);
              yield return new LatLng(29.8014571086707, -95.2856473807675);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8570997262337, -95.2703446412341);
              yield return new LatLng(29.854973941334, -95.2662207688778);
              yield return new LatLng(29.8543448666667, -95.2577378666667);
              yield return new LatLng(29.776715755102, -95.297066122449);
              yield return new LatLng(29.776715755102, -95.297066122449);
              yield return new LatLng(29.7781142857143, -95.295563877551);
              yield return new LatLng(29.7750361973105, -95.2396382801779);
              yield return new LatLng(29.643139, -95.3996723);
          }
     }

     public class September_2017_AutoTheft_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
