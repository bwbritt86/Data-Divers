using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class May_2017_AggravatedAssault
     {
         public static IEnumerable<May_2017_AggravatedAssault_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new May_2017_AggravatedAssault_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7443184266581, -95.3292660085824);
              yield return new LatLng(29.7528676938776, -95.3303825102041);
              yield return new LatLng(29.7416784848485, -95.3159955151515);
              yield return new LatLng(29.7484777755102, -95.3248424285714);
              yield return new LatLng(29.742485, -95.35374);
              yield return new LatLng(29.7401859191919, -95.3394058686869);
              yield return new LatLng(29.7280367, -95.3480321);
              yield return new LatLng(29.7499769387755, -95.3652375918367);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.6309694, -95.4767312);
              yield return new LatLng(29.7346034897959, -95.3509904489796);
              yield return new LatLng(29.7311079795918, -95.356573877551);
              yield return new LatLng(29.7308965, -95.3629115);
              yield return new LatLng(29.7257288965517, -95.3612781896552);
              yield return new LatLng(29.7287796326531, -95.3553205510204);
              yield return new LatLng(29.7321579591837, -95.3577049795918);
              yield return new LatLng(29.7344174285714, -95.3674398979592);
              yield return new LatLng(29.8763825392292, -95.5016429608304);
              yield return new LatLng(29.711806375, -95.3563085);
              yield return new LatLng(29.7092443957774, -95.344578224622);
              yield return new LatLng(29.6045775151515, -95.4541263232323);
              yield return new LatLng(29.7047825801916, -95.2886099931975);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.7341759795918, -95.290358244898);
              yield return new LatLng(29.7189453877551, -95.3199644897959);
              yield return new LatLng(29.7174026666667, -95.2965565);
              yield return new LatLng(29.8108729, -95.513694);
              yield return new LatLng(29.7066933877551, -95.2787026530612);
              yield return new LatLng(29.5912302121212, -95.2245356565657);
              yield return new LatLng(29.6273074489796, -95.2340237755102);
              yield return new LatLng(29.6470799373954, -95.2278933049073);
              yield return new LatLng(29.6444861632653, -95.2452819795918);
              yield return new LatLng(29.7169242899554, -95.3729768817224);
              yield return new LatLng(29.6417668888889, -95.2337957777778);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.5919306666667, -95.2362897878788);
              yield return new LatLng(29.6402359090909, -95.2308495757576);
              yield return new LatLng(29.5964022117653, -95.1993424529439);
              yield return new LatLng(29.6632903592459, -95.3127557604141);
              yield return new LatLng(29.6866541, -95.2567664);
              yield return new LatLng(29.693168, -95.595205);
              yield return new LatLng(29.7159854285714, -95.3220173265306);
              yield return new LatLng(29.6865040204082, -95.3049676530612);
              yield return new LatLng(29.6719832653061, -95.3473613061225);
              yield return new LatLng(29.6891217606161, -95.2965052607335);
              yield return new LatLng(29.6908142424242, -95.3676044545455);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6821323835616, -95.3094310273973);
              yield return new LatLng(29.6731190391726, -95.2857140545665);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6610989, -95.2888579);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6745395090346, -95.2858233983958);
              yield return new LatLng(29.7966135252525, -95.3118202727273);
              yield return new LatLng(29.7114788484848, -95.2816606060606);
              yield return new LatLng(29.6877386938776, -95.3585824081633);
              yield return new LatLng(29.7079748756922, -95.3335974754013);
              yield return new LatLng(29.6858828383838, -95.3628660808081);
              yield return new LatLng(29.6868982423264, -95.3470521058941);
              yield return new LatLng(29.7076006161616, -95.3369105151515);
              yield return new LatLng(29.6960274897959, -95.3384520204082);
              yield return new LatLng(29.697628, -95.399315);
              yield return new LatLng(29.7835808, -95.1869253);
              yield return new LatLng(29.7398444887082, -95.3488064166785);
              yield return new LatLng(29.6700504897959, -95.3630061428571);
              yield return new LatLng(29.6545181414141, -95.3408037373737);
              yield return new LatLng(29.6769200769231, -95.3527505384615);
              yield return new LatLng(29.6793608367347, -95.3624377346939);
              yield return new LatLng(29.6899647474747, -95.3648241515152);
              yield return new LatLng(29.6705928163265, -95.3623814693878);
              yield return new LatLng(29.6886615745544, -95.3718974968025);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.6493509512195, -95.3499504634146);
              yield return new LatLng(29.665775426237, -95.3223088372631);
              yield return new LatLng(29.6702426, -95.3556421);
              yield return new LatLng(29.6702426, -95.3556421);
              yield return new LatLng(29.6544512244898, -95.347885);
              yield return new LatLng(29.648051, -95.3801855);
              yield return new LatLng(29.6653931020408, -95.3572270204082);
              yield return new LatLng(29.6843680816327, -95.3767322653061);
              yield return new LatLng(29.6653051212121, -95.3611158484848);
              yield return new LatLng(29.6903595, -95.3707509);
              yield return new LatLng(29.64972809375, -95.33756825);
              yield return new LatLng(29.6858828383838, -95.3628660808081);
              yield return new LatLng(29.6331708300649, -95.4176710715948);
              yield return new LatLng(29.6825177159496, -95.3725253456453);
              yield return new LatLng(29.6692305714286, -95.364241);
              yield return new LatLng(29.651732, -95.3656409795918);
              yield return new LatLng(29.6354136666667, -95.243653);
              yield return new LatLng(29.6831932227049, -95.3410353118864);
              yield return new LatLng(29.6563456015198, -95.330624687928);
              yield return new LatLng(29.6626897959184, -95.326881877551);
              yield return new LatLng(29.6692052727273, -95.3467135757576);
              yield return new LatLng(29.6229957, -95.346475);
              yield return new LatLng(29.6802089492403, -95.3501901356332);
              yield return new LatLng(29.6863110644818, -95.3285772327806);
              yield return new LatLng(29.6863110644818, -95.3285772327806);
              yield return new LatLng(29.6647836530612, -95.3349755510204);
              yield return new LatLng(29.6386099289806, -95.3437660005859);
              yield return new LatLng(29.664476233166, -95.3670967719639);
              yield return new LatLng(29.6633586671671, -95.3306664850921);
              yield return new LatLng(29.621864010101, -95.367251050505);
              yield return new LatLng(29.6853318420272, -95.336370342035);
              yield return new LatLng(29.6327478930595, -95.3468964480365);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.8136342666667, -95.5210174666667);
              yield return new LatLng(29.6759690447023, -95.4417820827426);
              yield return new LatLng(29.69728859375, -95.334682);
              yield return new LatLng(29.6654719543456, -95.4431084744691);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7404658, -95.2674148);
              yield return new LatLng(29.6374750306699, -95.3765905780835);
              yield return new LatLng(29.685303877551, -95.4240099591837);
              yield return new LatLng(29.6814395792853, -95.4190562093379);
              yield return new LatLng(29.6624331836735, -95.3459726938776);
              yield return new LatLng(29.6971745, -95.3731438333333);
              yield return new LatLng(29.6091926161616, -95.4376497878788);
              yield return new LatLng(29.6570404, -95.3743902);
              yield return new LatLng(29.831128, -95.7542164);
              yield return new LatLng(29.6179301495325, -95.4439068130845);
              yield return new LatLng(29.6122279407746, -95.342106048232);
              yield return new LatLng(29.6339015962697, -95.4297297866137);
              yield return new LatLng(29.597819, -95.487495);
              yield return new LatLng(29.5970526847565, -95.4970746648079);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6660212857143, -95.2218403061224);
              yield return new LatLng(29.7201615, -95.483087);
              yield return new LatLng(29.730651, -95.524165);
              yield return new LatLng(29.7359434496644, -95.4414428389262);
              yield return new LatLng(29.7163455625, -95.484514);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7087857058824, -95.4977005294118);
              yield return new LatLng(29.736804, -95.4579444);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6915731632653, -95.4870965918367);
              yield return new LatLng(29.6988362149506, -95.4998600663798);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.6443120816327, -95.36234);
              yield return new LatLng(29.68664509375, -95.5590162604167);
              yield return new LatLng(29.6354893469388, -95.5018346734694);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.6395925357143, -95.50304725);
              yield return new LatLng(29.7127536854846, -95.6088331477732);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.74417075, -95.5041911363636);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.730290969697, -95.520386010101);
              yield return new LatLng(29.7254957142857, -95.5181136938776);
              yield return new LatLng(29.7114463673469, -95.5179400408163);
              yield return new LatLng(29.8503127, -95.6545316);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7299320039905, -95.5758689081626);
              yield return new LatLng(29.698586, -95.5813006);
              yield return new LatLng(29.6746762778025, -95.5800129567929);
              yield return new LatLng(29.6807710524689, -95.5772505187376);
              yield return new LatLng(29.7461850204082, -95.6031736530612);
              yield return new LatLng(29.6674449183673, -95.3623070408163);
              yield return new LatLng(29.6646335397727, -95.5741205340909);
              yield return new LatLng(29.6646335397727, -95.5741205340909);
              yield return new LatLng(29.5988513485922, -95.4838770421883);
              yield return new LatLng(29.7516677142857, -95.3761083877551);
              yield return new LatLng(29.7574995918367, -95.3526510408163);
              yield return new LatLng(29.7587785510204, -95.3633610612245);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.7500941020408, -95.3963491020408);
              yield return new LatLng(29.7526878478261, -95.3778132826087);
              yield return new LatLng(29.7331584848485, -95.3653621212121);
              yield return new LatLng(29.7452555102041, -95.4020006530612);
              yield return new LatLng(29.7751537021277, -95.3229409361702);
              yield return new LatLng(29.7295285306122, -95.3637371836735);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7299552067584, -95.4614990783331);
              yield return new LatLng(29.7105811886792, -95.5454211886792);
              yield return new LatLng(29.7589382, -95.3676974);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7314379309243, -95.5644525377716);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.7498160408163, -95.3704482653061);
              yield return new LatLng(29.74032015, -95.5763157166667);
              yield return new LatLng(29.7712725454545, -95.5947524545455);
              yield return new LatLng(29.7151687755102, -95.574898755102);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.8005461304348, -95.4351815217391);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.802699020202, -95.3658162222222);
              yield return new LatLng(29.8625519849023, -95.3141563703378);
              yield return new LatLng(29.7856226530612, -95.3614042244898);
              yield return new LatLng(29.7768564897959, -95.3568296734694);
              yield return new LatLng(29.7838377959184, -95.3515362653061);
              yield return new LatLng(29.6430427911647, -95.526504811245);
              yield return new LatLng(29.7862998, -95.6024288);
              yield return new LatLng(29.6427030477522, -95.4910096308004);
              yield return new LatLng(29.8481073290278, -95.352268407083);
              yield return new LatLng(29.7725336734694, -95.4129826326531);
              yield return new LatLng(29.8815137272727, -95.5030664848485);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8346993658537, -95.4627012195122);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.835346409587, -95.448936747842);
              yield return new LatLng(29.8556731212121, -95.3871143636364);
              yield return new LatLng(29.8241854693878, -95.4019534489796);
              yield return new LatLng(29.8181179060403, -95.3380687583893);
              yield return new LatLng(29.8454451151643, -95.4075496414948);
              yield return new LatLng(29.8283766363636, -95.3985314772727);
              yield return new LatLng(29.8057810614613, -95.3603200925839);
              yield return new LatLng(29.823849122449, -95.3747128367347);
              yield return new LatLng(29.7190014845361, -95.3501720412371);
              yield return new LatLng(29.854675314877, -95.5437951886183);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7936089, -95.5214399);
              yield return new LatLng(29.84128990625, -95.49962675);
              yield return new LatLng(29.8462246803518, -95.5438594108749);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8452542104973, -95.5141652955456);
              yield return new LatLng(29.9689524, -95.5423929);
              yield return new LatLng(29.8549891643836, -95.394369609589);
              yield return new LatLng(29.8549361020408, -95.3847198367347);
              yield return new LatLng(29.860835613412, -95.3639897212458);
              yield return new LatLng(29.868710277558, -95.4281441660699);
              yield return new LatLng(29.8519000204082, -95.4237639387755);
              yield return new LatLng(29.8630938627807, -95.3087984772761);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8802284049702, -95.4487253075589);
              yield return new LatLng(29.8868076070414, -95.4543362587475);
              yield return new LatLng(29.8797180294118, -95.4159184705882);
              yield return new LatLng(29.921773244898, -95.4113987959184);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.922370101344, -95.4070732752013);
              yield return new LatLng(29.9595747229091, -95.4320487974526);
              yield return new LatLng(29.8787193030303, -95.4497423030303);
              yield return new LatLng(29.7784758979592, -95.3297054489796);
              yield return new LatLng(29.7798255672991, -95.3389658970131);
              yield return new LatLng(29.7946879504169, -95.3223419194289);
              yield return new LatLng(29.7790548979592, -95.3300697346939);
              yield return new LatLng(29.8194220808081, -95.3288302424242);
              yield return new LatLng(29.7890396363636, -95.3323674848485);
              yield return new LatLng(29.7823628571429, -95.3319028163265);
              yield return new LatLng(29.785254, -95.3311304285714);
              yield return new LatLng(29.7853334693878, -95.3351538163265);
              yield return new LatLng(29.8059403061224, -95.3250736938775);
              yield return new LatLng(29.7843733673469, -95.3319294897959);
              yield return new LatLng(29.8171512214765, -95.3413956778523);
              yield return new LatLng(29.8213384623116, -95.311209879397);
              yield return new LatLng(29.7936631588003, -95.325431119341);
              yield return new LatLng(29.7885994736842, -95.3359503157895);
              yield return new LatLng(29.8194220808081, -95.3288302424242);
              yield return new LatLng(29.8142032195224, -95.3478187589363);
              yield return new LatLng(29.8599108685222, -95.2979837325402);
              yield return new LatLng(29.7979879196787, -95.3206100200803);
              yield return new LatLng(29.8437396530612, -95.3770104693878);
              yield return new LatLng(29.8639263, -95.3173057);
              yield return new LatLng(29.8006626774194, -95.3296699032258);
              yield return new LatLng(29.7843733673469, -95.3319294897959);
              yield return new LatLng(29.7346305, -95.5030413);
              yield return new LatLng(29.8306243786991, -95.3385603094002);
              yield return new LatLng(29.8376779347826, -95.3666047173913);
              yield return new LatLng(29.856309, -95.332895);
              yield return new LatLng(29.8544907763785, -95.3439813484051);
              yield return new LatLng(29.8249497142857, -95.3484303846154);
              yield return new LatLng(29.8241407272727, -95.3509485151515);
              yield return new LatLng(29.8304782323232, -95.3361299292929);
              yield return new LatLng(29.8650564897959, -95.3349854081633);
              yield return new LatLng(29.8692407959184, -95.3367404693878);
              yield return new LatLng(29.8262463020134, -95.3295146577181);
              yield return new LatLng(29.8398895, -95.402726);
              yield return new LatLng(29.782303877551, -95.3375923673469);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8348965353716, -95.3251433881923);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8207692999857, -95.3316718077419);
              yield return new LatLng(29.834696160804, -95.3131704623116);
              yield return new LatLng(29.8275068333333, -95.3240961666667);
              yield return new LatLng(29.8376373673469, -95.2951574489796);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8195269141953, -95.3073953542905);
              yield return new LatLng(29.8332840841169, -95.3050348344549);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.8416323636364, -95.2743803434343);
              yield return new LatLng(29.8490528576923, -95.2863570610786);
              yield return new LatLng(29.8248674, -95.2845541);
              yield return new LatLng(29.8062254897959, -95.2827324693878);
              yield return new LatLng(29.8569828161832, -95.2205021033317);
              yield return new LatLng(29.8487227048014, -95.261280235329);
              yield return new LatLng(29.836169, -95.273479);
              yield return new LatLng(29.8410148269231, -95.262349);
              yield return new LatLng(29.8538983080264, -95.2676972040355);
              yield return new LatLng(29.8543448666667, -95.2577378666667);
              yield return new LatLng(29.8560448, -95.2617374);
              yield return new LatLng(29.8543448666667, -95.2577378666667);
              yield return new LatLng(29.8543448666667, -95.2577378666667);
              yield return new LatLng(29.8579443939394, -95.2577271212121);
              yield return new LatLng(29.8681376558492, -95.3128711004772);
              yield return new LatLng(29.8574671737999, -95.3030042495808);
              yield return new LatLng(29.8819787514441, -95.2949322216837);
              yield return new LatLng(29.886262462963, -95.2935321111111);
              yield return new LatLng(29.8858852609462, -95.2945530004406);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.8842476838452, -95.2917732820362);
              yield return new LatLng(29.7390125918367, -95.254518877551);
              yield return new LatLng(29.739431877551, -95.2670684081633);
              yield return new LatLng(29.7792441632653, -95.3041599591837);
              yield return new LatLng(29.7916678, -95.2691466);
              yield return new LatLng(29.8014463644184, -95.2290428778626);
              yield return new LatLng(29.7635728148989, -95.2097684247588);
              yield return new LatLng(29.781324, -95.218698);
              yield return new LatLng(29.8780003725967, -95.7169651816967);
              yield return new LatLng(29.7916678, -95.2691466);
              yield return new LatLng(29.7835808, -95.1869253);
              yield return new LatLng(29.7809066538462, -95.1841863076923);
              yield return new LatLng(29.683629375, -95.2716469375);
              yield return new LatLng(29.770891, -95.341493);
              yield return new LatLng(29.8994595384615, -95.2914818461538);
              yield return new LatLng(29.6253940606061, -95.4372382222222);
          }
     }

     public class May_2017_AggravatedAssault_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
