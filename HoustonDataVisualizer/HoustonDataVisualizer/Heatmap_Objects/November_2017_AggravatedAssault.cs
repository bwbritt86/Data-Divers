using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class November_2017_AggravatedAssault
     {
         public static IEnumerable<November_2017_AggravatedAssault_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new November_2017_AggravatedAssault_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7558498, -95.34832);
              yield return new LatLng(29.7532194462144, -95.3310979399646);
              yield return new LatLng(29.7453135336753, -95.3323142081107);
              yield return new LatLng(29.8315618, -95.7601274);
              yield return new LatLng(29.7435184343434, -95.3443165353535);
              yield return new LatLng(29.7104233469388, -95.2737503265306);
              yield return new LatLng(29.7296489615385, -95.3504091923077);
              yield return new LatLng(29.7274284137931, -95.3549580344828);
              yield return new LatLng(29.7263865, -95.36102);
              yield return new LatLng(29.6246659349137, -95.434359832201);
              yield return new LatLng(29.7315051428571, -95.3629557959184);
              yield return new LatLng(29.7257288965517, -95.3612781896552);
              yield return new LatLng(29.6620496206897, -95.3217183793103);
              yield return new LatLng(29.6598938241206, -95.3137745778894);
              yield return new LatLng(29.732061298855, -95.3700679396713);
              yield return new LatLng(29.73125415625, -95.3533458125);
              yield return new LatLng(29.7279855714286, -95.3501178163265);
              yield return new LatLng(29.7209340036401, -95.3747401288124);
              yield return new LatLng(29.6290478581304, -95.4203914442754);
              yield return new LatLng(29.7057175930138, -95.5927343351497);
              yield return new LatLng(29.6769200769231, -95.3527505384615);
              yield return new LatLng(29.711500030635, -95.3993462895355);
              yield return new LatLng(29.8615054247312, -95.4220905591398);
              yield return new LatLng(29.957776, -95.474668);
              yield return new LatLng(29.7061457272727, -95.3855957954545);
              yield return new LatLng(29.711500030635, -95.3993462895355);
              yield return new LatLng(29.6657225959596, -95.3261327676768);
              yield return new LatLng(29.7061457272727, -95.3855957954545);
              yield return new LatLng(29.6844755907787, -95.3320229904337);
              yield return new LatLng(29.7354313265306, -95.2944452244898);
              yield return new LatLng(29.7198625, -95.282355);
              yield return new LatLng(29.7126745555556, -95.2932341111111);
              yield return new LatLng(29.7131668979592, -95.2941270612245);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.7435053333333, -95.3716278181818);
              yield return new LatLng(29.6435631428571, -95.2497365714286);
              yield return new LatLng(29.6354136666667, -95.243653);
              yield return new LatLng(29.6385264452097, -95.2375187219649);
              yield return new LatLng(29.6486065587144, -95.2285244808423);
              yield return new LatLng(29.687151, -95.286979);
              yield return new LatLng(29.6402359090909, -95.2308495757576);
              yield return new LatLng(29.6386065454545, -95.2320836060606);
              yield return new LatLng(29.5944474242424, -95.2288076969697);
              yield return new LatLng(29.6079607344358, -95.2201167339757);
              yield return new LatLng(29.6364423636364, -95.2246606363636);
              yield return new LatLng(29.5620631428571, -95.1249982857143);
              yield return new LatLng(29.7201999, -95.4149742);
              yield return new LatLng(29.5541506412874, -95.1295543319285);
              yield return new LatLng(29.7159854285714, -95.3220173265306);
              yield return new LatLng(29.8447366, -95.4921838);
              yield return new LatLng(29.7589572, -95.3609124);
              yield return new LatLng(29.7047491552101, -95.3159503157034);
              yield return new LatLng(29.6756091910146, -95.2863126520881);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6230353469388, -95.2770555714286);
              yield return new LatLng(29.6726631471528, -95.3086234507209);
              yield return new LatLng(29.6401094522613, -95.2223628743719);
              yield return new LatLng(29.7495142, -95.3272656);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.692919, -95.332877);
              yield return new LatLng(29.6980053718063, -95.3483980358505);
              yield return new LatLng(29.6938398787879, -95.3649009090909);
              yield return new LatLng(29.6877386938776, -95.3585824081633);
              yield return new LatLng(29.6924033939394, -95.3654816464646);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6505127, -95.8321738);
              yield return new LatLng(29.7152020898768, -95.3741286382058);
              yield return new LatLng(29.6648838244329, -95.3461076625553);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6950325918367, -95.354598122449);
              yield return new LatLng(29.6311645102041, -95.3507772040816);
              yield return new LatLng(29.6380518979592, -95.3567864693878);
              yield return new LatLng(29.651732, -95.3656409795918);
              yield return new LatLng(29.6759949642857, -95.3509021071429);
              yield return new LatLng(29.65452925, -95.3675673333333);
              yield return new LatLng(29.7432879474049, -95.3931702380644);
              yield return new LatLng(29.6700154296356, -95.3580492482017);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.647278, -95.3801675);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6533700909091, -95.3668452424242);
              yield return new LatLng(29.6591517360798, -95.3654188787805);
              yield return new LatLng(29.6653931020408, -95.3572270204082);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.6713034219539, -95.3718964702144);
              yield return new LatLng(29.6501694374197, -95.3741875742103);
              yield return new LatLng(29.6908142424242, -95.3676044545455);
              yield return new LatLng(29.678372, -95.370649);
              yield return new LatLng(29.6089363636364, -95.4436167575758);
              yield return new LatLng(29.7035384332947, -95.3430665524823);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6764680507015, -95.3306074828449);
              yield return new LatLng(29.8503904286767, -95.1956194894548);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.7121539, -95.2768412);
              yield return new LatLng(29.6509721428571, -95.4770705238095);
              yield return new LatLng(29.6820825862069, -95.4176731724138);
              yield return new LatLng(29.692068544084, -95.3903941517987);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.685303877551, -95.4240099591837);
              yield return new LatLng(29.7326093061224, -95.3529177346939);
              yield return new LatLng(29.770793, -95.328129);
              yield return new LatLng(29.673174, -95.4948529);
              yield return new LatLng(29.693798, -95.3753406666667);
              yield return new LatLng(29.612259466971, -95.3502424340882);
              yield return new LatLng(29.6825264848485, -95.5974035151515);
              yield return new LatLng(29.6861884285714, -95.3729054897959);
              yield return new LatLng(29.6318054657606, -95.4236609893494);
              yield return new LatLng(29.6090791212121, -95.4063682727273);
              yield return new LatLng(29.6957540833609, -95.5353161611927);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.631858858156, -95.4678656808511);
              yield return new LatLng(29.677392, -95.256885);
              yield return new LatLng(29.6005005102041, -95.4689985306123);
              yield return new LatLng(29.6083539484156, -95.4863992918214);
              yield return new LatLng(29.5977155558232, -95.4726879065202);
              yield return new LatLng(29.5936613785004, -95.4798962985042);
              yield return new LatLng(29.7778066, -95.247198);
              yield return new LatLng(29.6781822857143, -95.5836766734694);
              yield return new LatLng(29.688784, -95.5919461020408);
              yield return new LatLng(29.6005670116264, -95.4875382531034);
              yield return new LatLng(29.633838086373, -95.4585103160066);
              yield return new LatLng(29.7201254166667, -95.4858726666667);
              yield return new LatLng(29.7096232727273, -95.5687218585859);
              yield return new LatLng(29.7162611020408, -95.4921939387755);
              yield return new LatLng(29.68040725, -95.5262225);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6499963469388, -95.5287013265306);
              yield return new LatLng(29.8677031972994, -95.4360866888802);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.634044678834, -95.4234604421708);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.8446439675207, -95.4579324943228);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7350603333333, -95.5307018989899);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.8630238235294, -95.6982547058823);
              yield return new LatLng(29.7147428, -95.51354356);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.7200735, -95.490992);
              yield return new LatLng(29.6755245, -95.5906665);
              yield return new LatLng(29.6755675517241, -95.5932105172414);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.6696287927198, -95.5329880194957);
              yield return new LatLng(29.7578600408163, -95.3699452653061);
              yield return new LatLng(29.7567248979592, -95.3812390408163);
              yield return new LatLng(29.7398416666667, -95.3849831212121);
              yield return new LatLng(29.7196559183673, -95.4721707346939);
              yield return new LatLng(29.6671616161616, -95.2639963636364);
              yield return new LatLng(29.6178827987411, -95.4784261750209);
              yield return new LatLng(29.6580586489695, -95.490400968922);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7284840408163, -95.2837680612245);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7323702857143, -95.5755703265306);
              yield return new LatLng(29.7555825918367, -95.3671954693878);
              yield return new LatLng(29.7517519026532, -95.6089191279714);
              yield return new LatLng(29.69728859375, -95.334682);
              yield return new LatLng(29.6026955441208, -95.5037424199973);
              yield return new LatLng(29.7208343, -95.2119019);
              yield return new LatLng(29.7448966734694, -95.6143539591837);
              yield return new LatLng(29.7290060721966, -95.6214954471848);
              yield return new LatLng(29.7274690677966, -95.5089739121726);
              yield return new LatLng(29.7355716197696, -95.6432825747321);
              yield return new LatLng(29.791948877551, -95.3502608979592);
              yield return new LatLng(29.8129700909091, -95.3719634848485);
              yield return new LatLng(29.8191424025974, -95.3460698181818);
              yield return new LatLng(29.7744334615385, -95.6134900769231);
              yield return new LatLng(29.7544714362416, -95.3896145503356);
              yield return new LatLng(29.768138901637, -95.3746546157016);
              yield return new LatLng(29.8377894285714, -95.3506290816327);
              yield return new LatLng(29.7704622, -95.4137459);
              yield return new LatLng(29.8140256415094, -95.4536047169811);
              yield return new LatLng(29.6820673018868, -95.4167525849057);
              yield return new LatLng(29.8282213333333, -95.385967452381);
              yield return new LatLng(29.8360478617021, -95.4029974468085);
              yield return new LatLng(29.8402546109957, -95.3905557159449);
              yield return new LatLng(29.8408264942869, -95.3653662439661);
              yield return new LatLng(29.8181433061224, -95.358969);
              yield return new LatLng(29.8346133210702, -95.3374069397993);
              yield return new LatLng(29.8190658474916, -95.5494019718564);
              yield return new LatLng(29.6701208144165, -95.4945050382124);
              yield return new LatLng(29.8218261598526, -95.5301814087041);
              yield return new LatLng(29.6821572, -95.7627048);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.8267370816327, -95.5045629183674);
              yield return new LatLng(29.8294505, -95.505946);
              yield return new LatLng(29.8528021477273, -95.5319280795455);
              yield return new LatLng(29.845253456728, -95.5469648611925);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8549891643836, -95.394369609589);
              yield return new LatLng(29.8549891643836, -95.394369609589);
              yield return new LatLng(29.798968244898, -95.3979396938775);
              yield return new LatLng(29.8611723288591, -95.436776704698);
              yield return new LatLng(29.8672919763869, -95.290625412658);
              yield return new LatLng(29.8834347142857, -95.499388);
              yield return new LatLng(29.8795406158397, -95.5023212655993);
              yield return new LatLng(29.7760597391304, -95.331611326087);
              yield return new LatLng(29.8705385714286, -95.4313522857143);
              yield return new LatLng(29.9545776767471, -95.4231410911162);
              yield return new LatLng(29.9507094081633, -95.3963921020408);
              yield return new LatLng(29.7819673, -95.3212443);
              yield return new LatLng(29.7755933191721, -95.3265177576626);
              yield return new LatLng(29.7765818979592, -95.3138293673469);
              yield return new LatLng(29.9681552, -95.55624);
              yield return new LatLng(29.7764278571429, -95.3182039795918);
              yield return new LatLng(29.7668578979592, -95.3258714489796);
              yield return new LatLng(29.7823628571429, -95.3319028163265);
              yield return new LatLng(29.8053395757576, -95.3207271919192);
              yield return new LatLng(29.7843733673469, -95.3319294897959);
              yield return new LatLng(29.8042761268534, -95.3336278204291);
              yield return new LatLng(29.8685014489796, -95.3393422653061);
              yield return new LatLng(29.8218205, -95.2844685);
              yield return new LatLng(29.8181085100671, -95.3389445973154);
              yield return new LatLng(29.7823773673469, -95.3310814081633);
              yield return new LatLng(29.6610316984977, -95.3306117142897);
              yield return new LatLng(29.795737, -95.342213);
              yield return new LatLng(29.8120803557047, -95.3445629194631);
              yield return new LatLng(29.7901871627907, -95.337491);
              yield return new LatLng(29.7912089387755, -95.3170028163265);
              yield return new LatLng(29.7973893253012, -95.3205971686747);
              yield return new LatLng(29.8075141407035, -95.3225286683417);
              yield return new LatLng(29.7894612998496, -95.3368751927953);
              yield return new LatLng(29.8181179060403, -95.3380687583893);
              yield return new LatLng(29.792500804009, -95.3599975358667);
              yield return new LatLng(29.8488248297479, -95.3427845473333);
              yield return new LatLng(29.8320900255689, -95.3395801953662);
              yield return new LatLng(29.8619575, -95.34303);
              yield return new LatLng(29.8677822790698, -95.3395795581395);
              yield return new LatLng(29.6913862605258, -95.2473699620479);
              yield return new LatLng(29.8179258704364, -95.2826752867075);
              yield return new LatLng(29.8460258657718, -95.3176391812081);
              yield return new LatLng(29.8326331409396, -95.3141068657718);
              yield return new LatLng(29.8364944646465, -95.3193263535354);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.7297798875502, -95.3428296305221);
              yield return new LatLng(29.8377224618848, -95.3226799271826);
              yield return new LatLng(29.852718122449, -95.2837285714286);
              yield return new LatLng(29.6598917272727, -95.3610092424242);
              yield return new LatLng(29.8332133301411, -95.3027409880744);
              yield return new LatLng(29.6619882, -95.4444086);
              yield return new LatLng(29.8102733030303, -95.2822128484848);
              yield return new LatLng(29.8240733023256, -95.2762555116279);
              yield return new LatLng(29.8541337346939, -95.2843718979592);
              yield return new LatLng(29.854973941334, -95.2662207688778);
              yield return new LatLng(29.854973941334, -95.2662207688778);
              yield return new LatLng(29.8786193950848, -95.2840824994509);
              yield return new LatLng(29.8835656139005, -95.2950214876025);
              yield return new LatLng(29.8790297959184, -95.4180864693878);
              yield return new LatLng(29.8625611538462, -95.2996346923077);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8844193737374, -95.3017712929293);
              yield return new LatLng(29.7581341515152, -95.2763194848485);
              yield return new LatLng(29.7568662653061, -95.2552037142857);
              yield return new LatLng(29.7974755443667, -95.2760890956328);
              yield return new LatLng(29.6672774025551, -95.3389626209009);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.7774295510204, -95.3051909795918);
              yield return new LatLng(29.767676205068, -95.2897043697599);
              yield return new LatLng(29.8081208896321, -95.2387155384615);
              yield return new LatLng(29.7749681010101, -95.1837664343434);
              yield return new LatLng(29.6563001073083, -95.549475478108);
              yield return new LatLng(29.7844926938775, -95.1890990816326);
              yield return new LatLng(29.8273170282517, -95.200194554286);
              yield return new LatLng(29.7824784897959, -95.2248056734694);
              yield return new LatLng(29.8011671, -95.2218374);
              yield return new LatLng(29.862339258696, -95.7168221933346);
              yield return new LatLng(29.7835808, -95.1869253);
              yield return new LatLng(29.9556416216216, -95.5543264324324);
          }
     }

     public class November_2017_AggravatedAssault_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}