using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class May_2017_Burglary
     {
         public static IEnumerable<May_2017_Burglary_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new May_2017_Burglary_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7424263541667, -95.3239259375);
              yield return new LatLng(29.7430696734694, -95.3260237142857);
              yield return new LatLng(29.7427786530612, -95.3250384489796);
              yield return new LatLng(29.7424263541667, -95.3239259375);
              yield return new LatLng(29.7427786530612, -95.3250384489796);
              yield return new LatLng(29.7504240204082, -95.3432051836735);
              yield return new LatLng(29.7554985384615, -95.3379028461539);
              yield return new LatLng(29.7525605, -95.330941);
              yield return new LatLng(29.7423019183673, -95.3372223673469);
              yield return new LatLng(29.7348371683276, -95.3305911362267);
              yield return new LatLng(29.738542877551, -95.3339430816327);
              yield return new LatLng(29.7322233265306, -95.3205823061225);
              yield return new LatLng(29.9277864612329, -95.3619166230373);
              yield return new LatLng(29.7353177755102, -95.3460545918367);
              yield return new LatLng(29.699822, -95.371404);
              yield return new LatLng(29.7359490612245, -95.3637167755102);
              yield return new LatLng(29.727599244898, -95.3512696938776);
              yield return new LatLng(29.7300966352384, -95.365334058868);
              yield return new LatLng(29.843676, -95.330574);
              yield return new LatLng(29.7905560043146, -95.27560491093);
              yield return new LatLng(29.7350686326531, -95.3593671020408);
              yield return new LatLng(29.6626663673469, -95.5111988571429);
              yield return new LatLng(29.7292318484848, -95.3684504242424);
              yield return new LatLng(29.7257288965517, -95.3612781896552);
              yield return new LatLng(29.7044868571429, -95.3702507142857);
              yield return new LatLng(29.7308524489796, -95.3634703673469);
              yield return new LatLng(29.7195491641791, -95.352500880597);
              yield return new LatLng(29.7018694189632, -95.3731829365338);
              yield return new LatLng(29.7234450612245, -95.3819774489796);
              yield return new LatLng(29.6203564897959, -95.4044281836735);
              yield return new LatLng(29.7331311538462, -95.3495515384615);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7303308571429, -95.4007662653061);
              yield return new LatLng(29.714984122449, -95.4157675102041);
              yield return new LatLng(29.7229814079304, -95.4158592898156);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.7332423823529, -95.2991513088235);
              yield return new LatLng(29.7549829, -95.3352614);
              yield return new LatLng(29.7295991206919, -95.2875386953885);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.6502316, -95.4046619);
              yield return new LatLng(29.7089956122449, -95.2900276326531);
              yield return new LatLng(29.7255975102041, -95.2784677959184);
              yield return new LatLng(29.6882961428571, -95.2774424693878);
              yield return new LatLng(29.7012341818182, -95.2777895227273);
              yield return new LatLng(29.761659122449, -95.0809684693878);
              yield return new LatLng(29.7044596090442, -95.2417852574959);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6562624848485, -95.2506577878788);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.5799723185368, -95.235258922848);
              yield return new LatLng(29.6435046, -95.2386094);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.6253523127414, -95.2297680130309);
              yield return new LatLng(29.6101094426229, -95.227754295082);
              yield return new LatLng(29.6134144285714, -95.2388199183674);
              yield return new LatLng(29.6678632901554, -95.2039498290155);
              yield return new LatLng(29.6238252398435, -95.1968407012633);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.5958034510782, -95.1973057371586);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.5906770767235, -95.1098390580338);
              yield return new LatLng(29.5622327272727, -95.1167006666667);
              yield return new LatLng(29.6866541, -95.2567664);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6850783368332, -95.3128585136091);
              yield return new LatLng(29.6801284602495, -95.3204600919037);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7144329, -95.2901635);
              yield return new LatLng(29.7120796315789, -95.3154526315789);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.7047825801916, -95.2886099931975);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6610989, -95.2888579);
              yield return new LatLng(29.6610989, -95.2888579);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.634259, -95.286418);
              yield return new LatLng(29.7018378472222, -95.3490594444444);
              yield return new LatLng(29.7015572121212, -95.347595969697);
              yield return new LatLng(29.7018378472222, -95.3490594444444);
              yield return new LatLng(29.7018378472222, -95.3490594444444);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6808611515152, -95.3624140505051);
              yield return new LatLng(29.6705821297485, -95.3355983676923);
              yield return new LatLng(29.6731489795918, -95.3609632244898);
              yield return new LatLng(29.6853550302219, -95.306701095134);
              yield return new LatLng(29.6746895385054, -95.3578797058633);
              yield return new LatLng(29.6783752432432, -95.3408551081081);
              yield return new LatLng(29.6564575, -95.355375);
              yield return new LatLng(29.652734, -95.352984);
              yield return new LatLng(29.6884988181818, -95.3669210606061);
              yield return new LatLng(29.6533700909091, -95.3668452424242);
              yield return new LatLng(29.667988, -95.373827);
              yield return new LatLng(29.6765778979592, -95.3518949387755);
              yield return new LatLng(29.6564575, -95.355375);
              yield return new LatLng(29.65452925, -95.3675673333333);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6834911875, -95.323491296875);
              yield return new LatLng(29.6870265285543, -95.3291107056972);
              yield return new LatLng(29.7961580950061, -95.2757267030387);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.637263, -95.33735125);
              yield return new LatLng(29.6049501862501, -95.3069052177935);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6763856173434, -95.4656636188168);
              yield return new LatLng(29.6818321169149, -95.4627992847242);
              yield return new LatLng(29.6771134229282, -95.4620291920376);
              yield return new LatLng(29.6775398163265, -95.4959341632653);
              yield return new LatLng(29.6800751825883, -95.4959219022357);
              yield return new LatLng(29.6794932761911, -95.499047951863);
              yield return new LatLng(29.798968244898, -95.3979396938775);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.6399149801816, -95.4914686964655);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.753442, -95.366406);
              yield return new LatLng(29.6157539387755, -95.4249930816326);
              yield return new LatLng(29.755575755102, -95.367956244898);
              yield return new LatLng(29.6414946441004, -95.4017707814504);
              yield return new LatLng(29.62806, -95.360877);
              yield return new LatLng(29.62806, -95.360877);
              yield return new LatLng(29.7162119096303, -95.3760693704385);
              yield return new LatLng(29.6154453448335, -95.4486338277474);
              yield return new LatLng(29.6396457297297, -95.4263908918919);
              yield return new LatLng(29.6545465454545, -95.440174030303);
              yield return new LatLng(29.6249580204082, -95.4569361428571);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6178827987411, -95.4784261750209);
              yield return new LatLng(29.6178827987411, -95.4784261750209);
              yield return new LatLng(29.66738, -95.3286);
              yield return new LatLng(29.697268, -95.495019);
              yield return new LatLng(29.5929765620431, -95.4495891673709);
              yield return new LatLng(29.6014628484848, -95.500649);
              yield return new LatLng(29.609291, -95.5084846734694);
              yield return new LatLng(29.6047092040816, -95.5050466326531);
              yield return new LatLng(29.592034, -95.452091);
              yield return new LatLng(29.7146304, -95.484689);
              yield return new LatLng(29.7133852541773, -95.4929901752125);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7193825652174, -95.4888976521739);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7193825652174, -95.4888976521739);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.6697351071429, -95.580509);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6696287927198, -95.5329880194957);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.6462062351428, -95.5448359080044);
              yield return new LatLng(29.6654119387755, -95.5203619387755);
              yield return new LatLng(29.9562325724244, -95.5434086407402);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.64677775, -95.50513525);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7376292857143, -95.4666810612245);
              yield return new LatLng(29.7167560681828, -95.5109625700638);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7328357857233, -95.4959019983648);
              yield return new LatLng(29.7304647894737, -95.4958658026316);
              yield return new LatLng(29.8194440535295, -95.7803342954049);
              yield return new LatLng(29.7546230204082, -95.4795150408163);
              yield return new LatLng(29.755458, -95.4828042777778);
              yield return new LatLng(29.7300991020408, -95.4813865918367);
              yield return new LatLng(29.6938946026761, -95.550291413998);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.730290969697, -95.520386010101);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7666506, -95.4551646);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.738651, -95.494111);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7143254725632, -95.5190380110774);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7157261157375, -95.5206077971656);
              yield return new LatLng(29.8284526856243, -95.7473454357363);
              yield return new LatLng(29.7177907142857, -95.5290335714286);
              yield return new LatLng(29.8637920697469, -95.5423905729574);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6823845, -95.5744802727273);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7029809452774, -95.5489545359754);
              yield return new LatLng(29.7034637777778, -95.6003113333333);
              yield return new LatLng(29.675098890411, -95.5865231369863);
              yield return new LatLng(29.6797157901901, -95.5859296259901);
              yield return new LatLng(29.7552639387755, -95.3656179183673);
              yield return new LatLng(29.7552639387755, -95.3656179183673);
              yield return new LatLng(29.7569944897959, -95.376479755102);
              yield return new LatLng(29.7454697142857, -95.3493443061224);
              yield return new LatLng(29.7575407, -95.3923592);
              yield return new LatLng(29.7459543469388, -95.3666387959184);
              yield return new LatLng(29.7382243, -95.3803352);
              yield return new LatLng(29.7568478163265, -95.3682189591837);
              yield return new LatLng(29.7544675102041, -95.376452244898);
              yield return new LatLng(29.7451307142857, -95.3941603877551);
              yield return new LatLng(29.7461015596664, -95.3938471284636);
              yield return new LatLng(29.7337976122449, -95.4185957346939);
              yield return new LatLng(29.7357367142857, -95.376253);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7479256658483, -95.4187270524921);
              yield return new LatLng(29.7460897477209, -95.454822660532);
              yield return new LatLng(29.8466878255034, -95.3059573355705);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7282839387755, -95.3647353673469);
              yield return new LatLng(29.7328670125864, -95.5458306290917);
              yield return new LatLng(29.7164506357301, -95.5496666960183);
              yield return new LatLng(29.7344025578224, -95.548803788885);
              yield return new LatLng(29.7328431130905, -95.5689703542153);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.9157677382066, -95.3364132820545);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.7321193425374, -95.5991379740698);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7447932020202, -95.5762127272727);
              yield return new LatLng(29.74032015, -95.5763157166667);
              yield return new LatLng(29.74032015, -95.5763157166667);
              yield return new LatLng(29.748006375, -95.5893899375);
              yield return new LatLng(29.777971, -95.5635565102041);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7769537337626, -95.5961707736371);
              yield return new LatLng(29.7769537337626, -95.5961707736371);
              yield return new LatLng(29.7769537337626, -95.5961707736371);
              yield return new LatLng(29.7769537337626, -95.5961707736371);
              yield return new LatLng(29.6446288, -95.4875455);
              yield return new LatLng(29.716209, -95.6149275454545);
              yield return new LatLng(29.747012, -95.307224);
              yield return new LatLng(29.9569443, -95.3602904);
              yield return new LatLng(29.9569443, -95.3602904);
              yield return new LatLng(29.7834983976829, -95.3492484052916);
              yield return new LatLng(29.7884917959184, -95.3540973469388);
              yield return new LatLng(29.7857667764776, -95.3568782352236);
              yield return new LatLng(29.7746194285714, -95.3509144693878);
              yield return new LatLng(29.8027056363636, -95.3844947575758);
              yield return new LatLng(29.7395764125014, -95.5772319263732);
              yield return new LatLng(29.7976150612245, -95.373921877551);
              yield return new LatLng(29.6255181, -95.2162955);
              yield return new LatLng(29.6255181, -95.2162955);
              yield return new LatLng(29.7709200204082, -95.421505755102);
              yield return new LatLng(29.770398122449, -95.4077836530612);
              yield return new LatLng(29.7954895918367, -95.4420654489796);
              yield return new LatLng(29.677502, -95.353798);
              yield return new LatLng(29.7344025578224, -95.548803788885);
              yield return new LatLng(29.677502, -95.353798);
              yield return new LatLng(29.8170294770612, -95.4772801010643);
              yield return new LatLng(29.8409245306122, -95.4620041632653);
              yield return new LatLng(29.8486028758478, -95.4769555381579);
              yield return new LatLng(29.7549829, -95.3352614);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8457143682549, -95.3730964639952);
              yield return new LatLng(29.8180495025126, -95.3676984874372);
              yield return new LatLng(29.8408285560672, -95.3667495463957);
              yield return new LatLng(29.8286583548387, -95.3888372580645);
              yield return new LatLng(29.838187755102, -95.3616590816327);
              yield return new LatLng(29.8338136262626, -95.362649);
              yield return new LatLng(29.8417731792186, -95.3683532539);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.7857304423964, -95.5214329757893);
              yield return new LatLng(29.7879801504211, -95.5537245117786);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8335010677966, -95.5462543728814);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8218460833333, -95.5278460833333);
              yield return new LatLng(29.8152860816327, -95.5422024081633);
              yield return new LatLng(29.812631, -95.541081);
              yield return new LatLng(29.7841390506329, -95.5966115063291);
              yield return new LatLng(29.7936089, -95.5214399);
              yield return new LatLng(29.817171, -95.556958);
              yield return new LatLng(29.8109061190476, -95.5054024761905);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.828838020202, -95.5093564343434);
              yield return new LatLng(29.8176880339599, -95.4914740060676);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8659422258065, -95.558707516129);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8428011271021, -95.5106897471423);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8675903576584, -95.3978816936079);
              yield return new LatLng(29.8606458, -95.3857097);
              yield return new LatLng(29.8588665454545, -95.3847836060606);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8463149782577, -95.364270913621);
              yield return new LatLng(29.8606458, -95.3857097);
              yield return new LatLng(29.8588665454545, -95.3847836060606);
              yield return new LatLng(29.8352883469388, -95.3189695510204);
              yield return new LatLng(29.859112261745, -95.3706556375839);
              yield return new LatLng(29.8506382857143, -95.4376525102041);
              yield return new LatLng(29.8795406158397, -95.5023212655993);
              yield return new LatLng(29.8857125844491, -95.4741389295365);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8802284049702, -95.4487253075589);
              yield return new LatLng(29.7468954035481, -95.4825018000486);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.9176370983607, -95.4058175901639);
              yield return new LatLng(29.9176370983607, -95.4058175901639);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.938146, -95.4037715);
              yield return new LatLng(29.9050461829334, -95.3339811470321);
              yield return new LatLng(29.9507094081633, -95.3963921020408);
              yield return new LatLng(29.9485980408163, -95.4220784897959);
              yield return new LatLng(29.9718046292387, -95.4208226940443);
              yield return new LatLng(29.9590155770382, -95.4235065229033);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.9507094081633, -95.3963921020408);
              yield return new LatLng(29.9590155770382, -95.4235065229033);
              yield return new LatLng(29.9545776767471, -95.4231410911162);
              yield return new LatLng(29.9506993414634, -95.3976742439024);
              yield return new LatLng(29.9616060816327, -95.4249402040816);
              yield return new LatLng(29.7763034897959, -95.3243244693878);
              yield return new LatLng(29.7804388847807, -95.3257684582363);
              yield return new LatLng(29.7737810204082, -95.3358843673469);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.781879, -95.313003);
              yield return new LatLng(29.7790644897959, -95.3419418571429);
              yield return new LatLng(29.7847494081633, -95.3378774285714);
              yield return new LatLng(29.7790203469388, -95.3318123877551);
              yield return new LatLng(29.7714540789474, -95.3358366842105);
              yield return new LatLng(29.7680460406665, -95.3183571356091);
              yield return new LatLng(29.8067804141414, -95.3431226060606);
              yield return new LatLng(29.8075831791045, -95.3157364328358);
              yield return new LatLng(29.7885994736842, -95.3359503157895);
              yield return new LatLng(29.8046904137097, -95.2989791607745);
              yield return new LatLng(29.8046904137097, -95.2989791607745);
              yield return new LatLng(29.8010888011631, -95.306711423148);
              yield return new LatLng(29.7865849591837, -95.3388499591837);
              yield return new LatLng(29.7828481428571, -95.3547849795918);
              yield return new LatLng(29.7862956363636, -95.3433615757576);
              yield return new LatLng(29.7970034444444, -95.3245544848485);
              yield return new LatLng(29.8507367155704, -95.3464262568368);
              yield return new LatLng(29.828282125, -95.3464040454545);
              yield return new LatLng(29.8450436054297, -95.3494583487282);
              yield return new LatLng(29.8508895, -95.329464625);
              yield return new LatLng(29.8460461630465, -95.3489995690859);
              yield return new LatLng(29.8299769393939, -95.3399621515152);
              yield return new LatLng(29.8412644545455, -95.3419513333333);
              yield return new LatLng(29.8585150748284, -95.3315395078628);
              yield return new LatLng(29.9530113773585, -95.3921516037736);
              yield return new LatLng(29.9919630529573, -95.2967955906694);
              yield return new LatLng(29.8209833333333, -95.3334677575758);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8476384630872, -95.3139129395973);
              yield return new LatLng(29.8314402828283, -95.2990486666667);
              yield return new LatLng(29.8232521897572, -95.2943012231234);
              yield return new LatLng(29.8263806, -95.2843775);
              yield return new LatLng(29.8251328571429, -95.2852980408163);
              yield return new LatLng(29.8428037676768, -95.2623654848485);
              yield return new LatLng(29.8199636030151, -95.2762145276382);
              yield return new LatLng(29.8142398695652, -95.2761407173913);
              yield return new LatLng(29.8256866938776, -95.2826236326531);
              yield return new LatLng(29.825898, -95.267873);
              yield return new LatLng(29.8154434851891, -95.2826896839273);
              yield return new LatLng(29.8377293877551, -95.2481089183674);
              yield return new LatLng(29.8484406122449, -95.2592189795918);
              yield return new LatLng(29.8231973877551, -95.2529726326531);
              yield return new LatLng(29.8495297336394, -95.2623028146728);
              yield return new LatLng(29.8523672978723, -95.2624699574468);
              yield return new LatLng(29.853529, -95.279719);
              yield return new LatLng(29.8547023870968, -95.2730910967742);
              yield return new LatLng(29.9419086, -95.2496622);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8741251818182, -95.2626808888889);
              yield return new LatLng(29.8597208181818, -95.2540946363636);
              yield return new LatLng(29.8684586900452, -95.3113509714572);
              yield return new LatLng(29.7320625151515, -95.2546736666667);
              yield return new LatLng(29.7853050204082, -95.3031075102041);
              yield return new LatLng(29.78693, -95.304676979798);
              yield return new LatLng(29.7871032222222, -95.3017314848485);
              yield return new LatLng(29.7874805, -95.297292);
              yield return new LatLng(29.7532941707317, -95.2834412682927);
              yield return new LatLng(29.7862817878788, -95.300561969697);
              yield return new LatLng(29.7578587981546, -95.3055131455904);
              yield return new LatLng(29.7838586756757, -95.3118034054054);
              yield return new LatLng(29.7827890937538, -95.2838685648804);
              yield return new LatLng(29.7922447585813, -95.2603251344082);
              yield return new LatLng(29.7758349166667, -95.2214492916667);
              yield return new LatLng(29.7849305693899, -95.2209536447684);
              yield return new LatLng(29.7790557222222, -95.1888048611111);
              yield return new LatLng(29.7860186595745, -95.3722006808511);
          }
     }

     public class May_2017_Burglary_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}