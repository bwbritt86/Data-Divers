using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class December_2017_Robbery
     {
         public static IEnumerable<December_2017_Robbery_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new December_2017_Robbery_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7394837142857, -95.3389165510204);
              yield return new LatLng(29.7401859191919, -95.3394058686869);
              yield return new LatLng(29.7331288163265, -95.3283091836735);
              yield return new LatLng(29.8942428597338, -95.4167491197831);
              yield return new LatLng(29.7390564081633, -95.3771694897959);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.8583906422235, -95.5051179012538);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7335177142857, -95.3656742040816);
              yield return new LatLng(29.5908317222934, -95.4809717022314);
              yield return new LatLng(29.7305358979592, -95.3464504693878);
              yield return new LatLng(29.7262625557664, -95.3696946329369);
              yield return new LatLng(29.7055853436372, -95.3670349554934);
              yield return new LatLng(29.713456847619, -95.3587531047619);
              yield return new LatLng(29.6611652653061, -95.3459487755102);
              yield return new LatLng(29.722751, -95.3786773265306);
              yield return new LatLng(29.722751, -95.3786773265306);
              yield return new LatLng(29.9060359311591, -95.3214961470764);
              yield return new LatLng(29.722751, -95.3786773265306);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.717362122449, -95.4175482653061);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.743499877551, -95.3362669183673);
              yield return new LatLng(29.7414351632653, -95.3055451428571);
              yield return new LatLng(29.7136948235294, -95.2961910294118);
              yield return new LatLng(29.7549829, -95.3352614);
              yield return new LatLng(29.7349419591837, -95.3040779387755);
              yield return new LatLng(29.7125026938775, -95.2913292653061);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6377378275862, -95.236465862069);
              yield return new LatLng(29.6394372, -95.2450326);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6400372, -95.2443648);
              yield return new LatLng(29.816221, -95.41171);
              yield return new LatLng(29.642145269568, -95.2415463606227);
              yield return new LatLng(29.6354136666667, -95.243653);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.642145269568, -95.2415463606227);
              yield return new LatLng(29.6112877070707, -95.2387616464646);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.6252090569024, -95.2679555532323);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.5872952, -95.2358626);
              yield return new LatLng(29.6113734489796, -95.2829985306122);
              yield return new LatLng(29.5725936627369, -95.1058822135454);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.71677425, -95.289592);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6605628282828, -95.2641035656566);
              yield return new LatLng(29.690121, -95.2715007058824);
              yield return new LatLng(29.684256381425, -95.2773192941748);
              yield return new LatLng(29.6540009854422, -95.2539019458452);
              yield return new LatLng(29.6704343540614, -95.3075270373499);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6821323835616, -95.3094310273973);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6631276204669, -95.2800498475032);
              yield return new LatLng(29.6679749141667, -95.2653859091633);
              yield return new LatLng(29.6656085198087, -95.2776962247651);
              yield return new LatLng(29.6745395090346, -95.2858233983958);
              yield return new LatLng(29.668043010101, -95.3123679494949);
              yield return new LatLng(29.6848455306122, -95.2901256938776);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.812826, -95.3700926341463);
              yield return new LatLng(29.7004598, -95.3446259833333);
              yield return new LatLng(29.692620244898, -95.3557256530612);
              yield return new LatLng(29.7312160408163, -95.3523428571429);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.695660122449, -95.3595999591837);
              yield return new LatLng(29.6604217574548, -95.2722794861273);
              yield return new LatLng(29.8780537878788, -95.484378);
              yield return new LatLng(29.667988, -95.373827);
              yield return new LatLng(29.6724393636364, -95.3752411212121);
              yield return new LatLng(29.6499987142857, -95.369571877551);
              yield return new LatLng(29.6544753469388, -95.3455946122449);
              yield return new LatLng(29.757291753619, -95.3653118533702);
              yield return new LatLng(29.6832191838487, -95.3954313822431);
              yield return new LatLng(29.6725091020408, -95.3743817346939);
              yield return new LatLng(29.6784107777778, -95.3558421111111);
              yield return new LatLng(29.6834457, -95.3656674);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6341401428571, -95.3576200408163);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.645621162805, -95.3646653099993);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.7263263265306, -95.4138895306123);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6938504693878, -95.3393275510204);
              yield return new LatLng(29.7025094693878, -95.3771860612245);
              yield return new LatLng(29.6794329148936, -95.3937274946809);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.6338520769231, -95.4751185);
              yield return new LatLng(29.7367512857143, -95.525008);
              yield return new LatLng(29.8348965353716, -95.3251433881923);
              yield return new LatLng(29.6122515854219, -95.3482083376241);
              yield return new LatLng(29.62806, -95.360877);
              yield return new LatLng(29.6122279407746, -95.342106048232);
              yield return new LatLng(29.6122791111111, -95.3558686666667);
              yield return new LatLng(29.7595994285714, -95.3673084693878);
              yield return new LatLng(29.6122279407746, -95.342106048232);
              yield return new LatLng(29.609495459782, -95.4481346590594);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7096309591837, -95.4930376734694);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7175419305556, -95.4888747361111);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.6654119387755, -95.5203619387755);
              yield return new LatLng(29.6633387841708, -95.5334986603611);
              yield return new LatLng(29.7166998, -95.5578608);
              yield return new LatLng(29.9322538464207, -95.5454612056597);
              yield return new LatLng(29.6696287927198, -95.5329880194957);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.8302292041694, -95.3677670856866);
              yield return new LatLng(29.9562325724244, -95.5434086407402);
              yield return new LatLng(29.6148424, -95.4227222);
              yield return new LatLng(29.6715498383838, -95.506812010101);
              yield return new LatLng(29.7856323, -95.7949143);
              yield return new LatLng(29.7382243, -95.3803352);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7319961632653, -95.5025651428571);
              yield return new LatLng(29.7166998, -95.5578608);
              yield return new LatLng(29.7266655005504, -95.5290533349436);
              yield return new LatLng(29.7088198214286, -95.5212426428571);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7065141, -95.5275109);
              yield return new LatLng(29.6773787236322, -95.557182292604);
              yield return new LatLng(29.625537125, -95.45833825);
              yield return new LatLng(29.6477243, -95.5656482);
              yield return new LatLng(29.7013606129032, -95.6111282580645);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.661344, -95.6192765);
              yield return new LatLng(29.8353556352507, -95.3600615726265);
              yield return new LatLng(29.7539912857143, -95.3579157346939);
              yield return new LatLng(29.7567503469388, -95.363673122449);
              yield return new LatLng(29.7441861805724, -95.3472157913337);
              yield return new LatLng(29.7470766122449, -95.3777153877551);
              yield return new LatLng(29.7558498, -95.34832);
              yield return new LatLng(29.7557995714286, -95.3664871020408);
              yield return new LatLng(29.7464733469388, -95.3674949183673);
              yield return new LatLng(29.7466346530612, -95.3892442857143);
              yield return new LatLng(29.7343627142857, -95.4699373265306);
              yield return new LatLng(29.7287752828283, -95.3677054747475);
              yield return new LatLng(29.7067777346939, -95.4258537755102);
              yield return new LatLng(29.7382243, -95.3803352);
              yield return new LatLng(29.7367134891304, -95.4186214456522);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.733325, -95.4110612059936);
              yield return new LatLng(29.7219780806452, -95.4413770645161);
              yield return new LatLng(29.6770634358383, -95.451256414452);
              yield return new LatLng(29.7257497959184, -95.441258755102);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7145460533232, -95.5473556485833);
              yield return new LatLng(29.8896972430208, -95.4342685108646);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7386139143883, -95.6011205553788);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.6954780030743, -95.5268990457204);
              yield return new LatLng(29.770121, -95.5993910204082);
              yield return new LatLng(29.782336, -95.6298665);
              yield return new LatLng(29.7842050816327, -95.6142649183674);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7448966734694, -95.6143539591837);
              yield return new LatLng(29.9569443, -95.3602904);
              yield return new LatLng(29.6916913300728, -95.3516326569895);
              yield return new LatLng(29.7747795510204, -95.3595959183673);
              yield return new LatLng(29.780933, -95.329664);
              yield return new LatLng(29.6963482332076, -95.5561584636631);
              yield return new LatLng(29.79290445107, -95.3502642714342);
              yield return new LatLng(29.6045356326531, -95.4985096938776);
              yield return new LatLng(29.8531853803586, -95.3355522212974);
              yield return new LatLng(29.809479295302, -95.3632981073826);
              yield return new LatLng(29.8034402, -95.3520308);
              yield return new LatLng(29.8386523, -95.402823);
              yield return new LatLng(29.7791265510204, -95.4101881632653);
              yield return new LatLng(29.8386523, -95.402823);
              yield return new LatLng(29.8539501794872, -95.2954433076923);
              yield return new LatLng(29.7837576122449, -95.3770937959184);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7744525, -95.3758975);
              yield return new LatLng(29.7705425714286, -95.416889244898);
              yield return new LatLng(29.7720079, -95.5590776);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.81850544, -95.45949316);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.81850544, -95.45949316);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.99693, -95.587699);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.828074794328, -95.4003307741891);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.8350269497487, -95.3693726683417);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8212321717172, -95.3430813838384);
              yield return new LatLng(29.8463149782577, -95.364270913621);
              yield return new LatLng(29.789868668665, -95.5587988678373);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.812631, -95.541081);
              yield return new LatLng(29.7907228919314, -95.5622292744778);
              yield return new LatLng(29.785324605, -95.467904);
              yield return new LatLng(29.785324605, -95.467904);
              yield return new LatLng(29.8520120621496, -95.4986369525022);
              yield return new LatLng(29.7985828139535, -95.4849515581395);
              yield return new LatLng(29.8280115838335, -95.5231999764528);
              yield return new LatLng(29.8109061190476, -95.5054024761905);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7688934489796, -95.4100048367347);
              yield return new LatLng(29.8681169, -95.5069734);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8588665454545, -95.3847836060606);
              yield return new LatLng(29.8549891643836, -95.394369609589);
              yield return new LatLng(29.8540688, -95.3737978);
              yield return new LatLng(29.8691870016064, -95.3849831525878);
              yield return new LatLng(29.7435053333333, -95.3716278181818);
              yield return new LatLng(29.8616208585859, -95.433023);
              yield return new LatLng(29.8485947058824, -95.4030799411765);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8543503333333, -95.4196043333333);
              yield return new LatLng(29.8108729, -95.513694);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8543503333333, -95.4196043333333);
              yield return new LatLng(29.8398895, -95.402726);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8253427142857, -95.3715113265306);
              yield return new LatLng(29.922370101344, -95.4070732752013);
              yield return new LatLng(29.9176370983607, -95.4058175901639);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8476734950029, -95.3430468129269);
              yield return new LatLng(29.9473950606061, -95.4165926969697);
              yield return new LatLng(29.9657973125, -95.4211071770833);
              yield return new LatLng(29.9317609, -95.4175804);
              yield return new LatLng(29.965834125, -95.41758525);
              yield return new LatLng(29.9535212105263, -95.3933262105263);
              yield return new LatLng(29.96606, -95.402382);
              yield return new LatLng(29.9495112097845, -95.4130029050834);
              yield return new LatLng(29.9657973125, -95.4211071770833);
              yield return new LatLng(29.7713790464343, -95.3352548424656);
              yield return new LatLng(29.7747193333333, -95.3257988787879);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.8074022392637, -95.3207627234906);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.8346038637274, -95.3408903322798);
              yield return new LatLng(29.8476734950029, -95.3430468129269);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8619575, -95.34303);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8650564897959, -95.3349854081633);
              yield return new LatLng(29.8650564897959, -95.3349854081633);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.7916678, -95.2691466);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8553644177724, -95.2936762780588);
              yield return new LatLng(29.7213311875, -95.6184216979167);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.9499005, -95.4122458);
              yield return new LatLng(29.8282642641509, -95.3066322075472);
              yield return new LatLng(29.8203026403685, -95.3182721550531);
              yield return new LatLng(29.8553587959184, -95.2482494285714);
              yield return new LatLng(29.8495297336394, -95.2623028146728);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.857337375, -95.26251575);
              yield return new LatLng(29.8495297336394, -95.2623028146728);
              yield return new LatLng(29.8495297336394, -95.2623028146728);
              yield return new LatLng(29.8771422727273, -95.2949974848485);
              yield return new LatLng(29.8881372941176, -95.3009598823529);
              yield return new LatLng(29.8723630204082, -95.2929517755102);
              yield return new LatLng(29.7640162, -95.2679387674853);
              yield return new LatLng(29.7642128979592, -95.2680797142857);
              yield return new LatLng(29.8145592791129, -95.2521828807807);
              yield return new LatLng(29.874514755102, -95.3379214285714);
              yield return new LatLng(29.7835808, -95.1869253);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.7664279545455, -95.1969044545454);
              yield return new LatLng(29.7786187959184, -95.1866182653061);
              yield return new LatLng(29.7721399791667, -95.2145984375);
          }
     }

     public class December_2017_Robbery_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}