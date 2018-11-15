using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class May_2017_Robbery
     {
         public static IEnumerable<May_2017_Robbery_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new May_2017_Robbery_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7603817642685, -95.3473993706196);
              yield return new LatLng(29.7473244634146, -95.3302562195122);
              yield return new LatLng(29.754947, -95.335181);
              yield return new LatLng(29.7301119591837, -95.3295647755102);
              yield return new LatLng(29.7401859191919, -95.3394058686869);
              yield return new LatLng(29.83249, -95.4071105116279);
              yield return new LatLng(29.7346738163265, -95.3520917346939);
              yield return new LatLng(29.7463449387755, -95.3719210612245);
              yield return new LatLng(29.7439481774088, -95.3272084389699);
              yield return new LatLng(29.747970640008, -95.3947224397689);
              yield return new LatLng(29.7274284137931, -95.3549580344828);
              yield return new LatLng(29.726661755102, -95.354926122449);
              yield return new LatLng(29.8327321502283, -95.3214012213329);
              yield return new LatLng(29.7197504285714, -95.3709879387755);
              yield return new LatLng(29.6902008163265, -95.3584729591837);
              yield return new LatLng(29.7070478163265, -95.3735888571429);
              yield return new LatLng(29.6022606827887, -95.4578992084818);
              yield return new LatLng(29.7232693877551, -95.3686948979592);
              yield return new LatLng(29.6634946744186, -95.3468074418605);
              yield return new LatLng(29.7123669090909, -95.3611858686869);
              yield return new LatLng(29.713059, -95.369181);
              yield return new LatLng(29.7036892556776, -95.3545932922665);
              yield return new LatLng(29.7035046, -95.8302728);
              yield return new LatLng(29.7028705306122, -95.4227835102041);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.7086116530612, -95.2934764081633);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7059767690184, -95.3384905463317);
              yield return new LatLng(29.7772901836735, -95.324925);
              yield return new LatLng(29.6502513333333, -95.2278686666667);
              yield return new LatLng(29.6380243115957, -95.2555375082055);
              yield return new LatLng(29.606512426779, -95.2281037972712);
              yield return new LatLng(29.6023906432989, -95.2481139661855);
              yield return new LatLng(29.6023906432989, -95.2481139661855);
              yield return new LatLng(29.6112877070707, -95.2387616464646);
              yield return new LatLng(29.65077278125, -95.233031375);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7007125102041, -95.3079606530612);
              yield return new LatLng(29.702856, -95.294799);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6896895102041, -95.3036785306122);
              yield return new LatLng(29.7140626122449, -95.3175034897959);
              yield return new LatLng(29.7042713872221, -95.3094662839115);
              yield return new LatLng(29.6931526031315, -95.3210597959064);
              yield return new LatLng(29.6144218686869, -95.2722534343434);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.685835, -95.289185625);
              yield return new LatLng(29.6610989, -95.2888579);
              yield return new LatLng(29.6540009854422, -95.2539019458452);
              yield return new LatLng(29.7250718989899, -95.3631046262626);
              yield return new LatLng(29.6656085198087, -95.2776962247651);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6903630633079, -95.3413099807876);
              yield return new LatLng(29.6977416122449, -95.3611571836735);
              yield return new LatLng(29.6985211428571, -95.3584497755102);
              yield return new LatLng(29.6946692437164, -95.3366104564096);
              yield return new LatLng(29.7015572121212, -95.347595969697);
              yield return new LatLng(29.697106625, -95.36625725);
              yield return new LatLng(29.7018378472222, -95.3490594444444);
              yield return new LatLng(29.6932067565645, -95.3371896214654);
              yield return new LatLng(29.6370664609375, -95.3592958125);
              yield return new LatLng(29.667708969697, -95.3472837878788);
              yield return new LatLng(29.677225122449, -95.3728350408163);
              yield return new LatLng(29.6834729591837, -95.373995755102);
              yield return new LatLng(29.6549162653061, -95.344118244898);
              yield return new LatLng(29.6630830777377, -95.3137072812423);
              yield return new LatLng(29.643985, -95.372117);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6598845070454, -95.3671007698668);
              yield return new LatLng(29.6584112244898, -95.362751755102);
              yield return new LatLng(29.6737454036426, -95.3444356586195);
              yield return new LatLng(29.693798, -95.3753406666667);
              yield return new LatLng(29.643985, -95.372117);
              yield return new LatLng(29.6834729591837, -95.373995755102);
              yield return new LatLng(29.7150834723225, -95.2858183648215);
              yield return new LatLng(29.6750084089027, -95.372797975851);
              yield return new LatLng(29.677225122449, -95.3728350408163);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.592691, -95.454914);
              yield return new LatLng(29.6415986060606, -95.3660074242424);
              yield return new LatLng(29.6348763, -95.4790943);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.6428789806409, -95.4900587176324);
              yield return new LatLng(29.6453757857143, -95.4888310714286);
              yield return new LatLng(29.8454679, -95.377619);
              yield return new LatLng(29.6820297843035, -95.414703347143);
              yield return new LatLng(29.6916678, -95.3892194);
              yield return new LatLng(29.6832191838487, -95.3954313822431);
              yield return new LatLng(29.5942955521694, -95.4696748743704);
              yield return new LatLng(29.5963425510204, -95.4931995918367);
              yield return new LatLng(29.6178019230058, -95.4276660419617);
              yield return new LatLng(29.612341757785, -95.371099949237);
              yield return new LatLng(29.7361066112446, -95.4951988245413);
              yield return new LatLng(29.6338520769231, -95.4751185);
              yield return new LatLng(29.6407899194631, -95.459073295302);
              yield return new LatLng(29.7100466966093, -95.4741237585471);
              yield return new LatLng(29.6923091605586, -95.3430203826017);
              yield return new LatLng(29.7200126229844, -95.4819969997463);
              yield return new LatLng(29.7162611020408, -95.4921939387755);
              yield return new LatLng(29.7229639640895, -95.4845697726588);
              yield return new LatLng(29.6930498427242, -95.5085384805235);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.6750274081633, -95.506853122449);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.6231786363636, -95.4360081212121);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.6742027862851, -95.5715125598617);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6889799327404, -95.5992793604477);
              yield return new LatLng(29.6745942083662, -95.5785471378117);
              yield return new LatLng(29.6745942083662, -95.5785471378117);
              yield return new LatLng(29.7381328, -95.3327748);
              yield return new LatLng(29.7396952653061, -95.3753927346939);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.706886, -95.551576);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7299320039905, -95.5758689081626);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.7843995306122, -95.3526570408163);
              yield return new LatLng(29.773633, -95.192465);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.8030304411336, -95.3679616984058);
              yield return new LatLng(29.9569443, -95.3602904);
              yield return new LatLng(29.7983303877551, -95.3633678571429);
              yield return new LatLng(29.8135301, -95.3611359);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7903561565445, -95.420713283035);
              yield return new LatLng(29.478761, -95.0503024);
              yield return new LatLng(29.7757968301747, -95.3896193185965);
              yield return new LatLng(29.817079764908, -95.4750750462904);
              yield return new LatLng(29.828002877551, -95.4836255714286);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.8524726326531, -95.5205063265306);
              yield return new LatLng(29.837180899182, -95.411814969904);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.8797323222222, -95.3053598222222);
              yield return new LatLng(29.818704755102, -95.3800655714286);
              yield return new LatLng(29.8292575220121, -95.4076463667374);
              yield return new LatLng(29.8457143682549, -95.3730964639952);
              yield return new LatLng(29.8340534848485, -95.3670186666667);
              yield return new LatLng(29.8402615166895, -95.3582088502901);
              yield return new LatLng(29.785324605, -95.467904);
              yield return new LatLng(29.8231562114948, -95.5040701840106);
              yield return new LatLng(29.8051338571429, -95.4849743877551);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.859452779925, -95.3582827561746);
              yield return new LatLng(29.8591635151515, -95.3847932020202);
              yield return new LatLng(29.8459216938775, -95.3845794081633);
              yield return new LatLng(29.859452779925, -95.3582827561746);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8629339045226, -95.4735072512563);
              yield return new LatLng(29.8834139400998, -95.4338333572764);
              yield return new LatLng(29.8866732171223, -95.4582777617375);
              yield return new LatLng(29.589581, -95.513763);
              yield return new LatLng(29.8807543714895, -95.4439432204783);
              yield return new LatLng(29.8679647142857, -95.4296791836735);
              yield return new LatLng(29.922370101344, -95.4070732752013);
              yield return new LatLng(29.7838378571429, -95.3507092653061);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8699183684211, -95.4247567368421);
              yield return new LatLng(29.950176, -95.4113291428571);
              yield return new LatLng(29.9252572805138, -95.4040057959984);
              yield return new LatLng(29.949261, -95.388183);
              yield return new LatLng(29.949261, -95.388183);
              yield return new LatLng(29.7693397171717, -95.3271055959596);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.7674167755102, -95.3251659387755);
              yield return new LatLng(29.7843733673469, -95.3319294897959);
              yield return new LatLng(29.8059987171717, -95.3194002121212);
              yield return new LatLng(29.8637889077825, -95.3442314160535);
              yield return new LatLng(29.8374977959184, -95.3308837551021);
              yield return new LatLng(29.8434790311549, -95.3421713040507);
              yield return new LatLng(29.8488270613772, -95.3100716824551);
              yield return new LatLng(29.9848746635823, -95.2960173529159);
              yield return new LatLng(29.8303213011182, -95.3189323723728);
              yield return new LatLng(29.7746721, -95.6222597);
              yield return new LatLng(29.8394945555556, -95.262322969697);
              yield return new LatLng(29.847239, -95.2841555);
              yield return new LatLng(29.8366820542816, -95.2543116180796);
              yield return new LatLng(29.8495297336394, -95.2623028146728);
              yield return new LatLng(29.8858852609462, -95.2945530004406);
              yield return new LatLng(29.8655373265306, -95.3006544693878);
              yield return new LatLng(29.7805427777778, -95.3010675925926);
              yield return new LatLng(29.7615803684211, -95.2836000263158);
              yield return new LatLng(29.8004302121212, -95.3630299393939);
              yield return new LatLng(29.7753160408163, -95.2178001632653);
              yield return new LatLng(29.6943489, -95.3266278);
              yield return new LatLng(29.7098515, -95.278095);
          }
     }

     public class May_2017_Robbery_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}