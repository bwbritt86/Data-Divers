using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class May_2017_AutoTheft
     {
         public static IEnumerable<May_2017_AutoTheft_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new May_2017_AutoTheft_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7401774897959, -95.3015943061225);
              yield return new LatLng(29.7462103241735, -95.3487510687767);
              yield return new LatLng(29.7503357959184, -95.3555989387755);
              yield return new LatLng(29.7495876938776, -95.3554246122449);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7503357959184, -95.3555989387755);
              yield return new LatLng(29.7456655404604, -95.3737527719834);
              yield return new LatLng(29.7478095510204, -95.3715315918367);
              yield return new LatLng(29.7277086326531, -95.3714907959184);
              yield return new LatLng(29.9675636767677, -95.4303862323232);
              yield return new LatLng(29.7456655404604, -95.3737527719834);
              yield return new LatLng(29.7280367, -95.3480321);
              yield return new LatLng(29.7312160408163, -95.3523428571429);
              yield return new LatLng(29.7022014186559, -95.3703776181183);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7056969591837, -95.3844606530612);
              yield return new LatLng(29.7246637755102, -95.2879468163265);
              yield return new LatLng(29.717304100223, -95.2917721837321);
              yield return new LatLng(29.6333695734466, -95.4550584953334);
              yield return new LatLng(29.7251326938776, -95.312232244898);
              yield return new LatLng(29.6719375918367, -95.3377397346939);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7187605510204, -95.2795898571429);
              yield return new LatLng(29.623515, -95.2377083);
              yield return new LatLng(29.6395681185236, -95.2237386891968);
              yield return new LatLng(29.6866541, -95.2567664);
              yield return new LatLng(29.5479049, -95.3830609);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.6463133421374, -95.2400980250226);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.6790185007912, -95.2949128693128);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.8024135294118, -95.5403575294118);
              yield return new LatLng(29.6866541, -95.2567664);
              yield return new LatLng(29.6861755102041, -95.2997476938775);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6685956246296, -95.2719332948472);
              yield return new LatLng(29.6915799380912, -95.3433197610184);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6556698322148, -95.3702801744966);
              yield return new LatLng(29.7004154204892, -95.3405934810689);
              yield return new LatLng(29.6758167644767, -95.3599137552534);
              yield return new LatLng(29.6632119387755, -95.3388928367347);
              yield return new LatLng(29.6899647474747, -95.3648241515152);
              yield return new LatLng(29.6560061729979, -95.3498556111683);
              yield return new LatLng(29.6784608461538, -95.4412843076923);
              yield return new LatLng(29.8380127, -95.4487664);
              yield return new LatLng(29.6787530536913, -95.3997871677852);
              yield return new LatLng(29.6524682286636, -95.5042990963382);
              yield return new LatLng(29.8265088951837, -95.2826263035321);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.6089121212121, -95.4451162525253);
              yield return new LatLng(29.5919245740754, -95.4581905518169);
              yield return new LatLng(29.7051147272727, -95.4782792121212);
              yield return new LatLng(29.7213503571429, -95.4889312142857);
              yield return new LatLng(29.7117625, -95.488791);
              yield return new LatLng(29.7163082380952, -95.4879661904762);
              yield return new LatLng(29.677712, -95.463628);
              yield return new LatLng(29.6423107317073, -95.5121245121951);
              yield return new LatLng(29.7068653043478, -95.4866440869565);
              yield return new LatLng(29.6328138651001, -95.3446837133638);
              yield return new LatLng(29.7299320039905, -95.5758689081626);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7308314897959, -95.4708951020408);
              yield return new LatLng(29.7280926923077, -95.4956195);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7247177593578, -95.5029351711003);
              yield return new LatLng(29.7236779756098, -95.5219004634146);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.6932062857143, -95.5520041632653);
              yield return new LatLng(29.7035993221476, -95.5807592281879);
              yield return new LatLng(29.7070524285714, -95.610753);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6751578979592, -95.545957122449);
              yield return new LatLng(29.7595994285714, -95.3673084693878);
              yield return new LatLng(29.7595104489796, -95.3597120204082);
              yield return new LatLng(29.7682729387755, -95.3538609795918);
              yield return new LatLng(29.7677815306122, -95.3521649591837);
              yield return new LatLng(29.5784073757225, -95.1560032947977);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.7487366530612, -95.3892518163265);
              yield return new LatLng(29.7523529387755, -95.3968870408163);
              yield return new LatLng(29.7418196122449, -95.4075963877551);
              yield return new LatLng(29.7432844693878, -95.4019826326531);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7167233333333, -95.5550051666667);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7299320039905, -95.5758689081626);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.8341509189189, -95.2898677972973);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7604091735953, -95.6186266567527);
              yield return new LatLng(29.716209, -95.6149275454545);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7290494864865, -95.6446068918919);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.800977980338, -95.3835819008139);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.7791265510204, -95.4101881632653);
              yield return new LatLng(29.7837806326531, -95.3761621428571);
              yield return new LatLng(29.8287136122449, -95.3850944285714);
              yield return new LatLng(29.8285557, -95.3818328);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8286277575758, -95.3925822727273);
              yield return new LatLng(29.789868668665, -95.5587988678373);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7005543333333, -95.596015);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.881009, -95.370856);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8599322638636, -95.4244622476849);
              yield return new LatLng(29.8459822040816, -95.2901555102041);
              yield return new LatLng(29.8376373673469, -95.2951574489796);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.9252572805138, -95.4040057959984);
              yield return new LatLng(29.7952391632653, -95.4013581020408);
              yield return new LatLng(29.7756383877551, -95.3484351020408);
              yield return new LatLng(29.7888882857143, -95.3378526326531);
              yield return new LatLng(29.7812986938776, -95.3327102857143);
              yield return new LatLng(29.78939584375, -95.3352028125);
              yield return new LatLng(29.798977361809, -95.3188611557789);
              yield return new LatLng(29.8299769393939, -95.3399621515152);
              yield return new LatLng(29.841267, -95.339522);
              yield return new LatLng(29.81693, -95.284544);
              yield return new LatLng(29.8367805897436, -95.2899131153846);
              yield return new LatLng(29.6610989, -95.2888579);
              yield return new LatLng(29.83534, -95.2981194693878);
              yield return new LatLng(29.8244913636364, -95.2720941818182);
              yield return new LatLng(29.8248674, -95.2845541);
              yield return new LatLng(29.8183565454545, -95.2799755454545);
              yield return new LatLng(29.8444906711409, -95.2666210067114);
              yield return new LatLng(29.850939, -95.269267);
              yield return new LatLng(29.8595077, -95.3366482);
              yield return new LatLng(29.8481734245893, -95.4627066118099);
              yield return new LatLng(29.8683694081633, -95.3065432040816);
              yield return new LatLng(29.8888576756757, -95.2962981621622);
              yield return new LatLng(29.7810669591837, -95.3093629591837);
              yield return new LatLng(29.8314997010078, -95.2736351778573);
              yield return new LatLng(29.7783684693878, -95.2962585918367);
              yield return new LatLng(29.6842306170213, -95.3035132340426);
              yield return new LatLng(29.8314997010078, -95.2736351778573);
              yield return new LatLng(29.639282, -95.3483835);
              yield return new LatLng(29.7703269, -95.2061028);
              yield return new LatLng(29.7637700246574, -95.2167010552893);
              yield return new LatLng(29.7988304897959, -95.2187391836735);
              yield return new LatLng(29.6866397114094, -95.3119623422819);
              yield return new LatLng(29.7674712352941, -95.2105218823529);
              yield return new LatLng(29.7879877959184, -95.1923532653061);
          }
     }

     public class May_2017_AutoTheft_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
