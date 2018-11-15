using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class October_2017_Burglary
     {
         public static IEnumerable<October_2017_Burglary_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new October_2017_Burglary_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7424263541667, -95.3239259375);
              yield return new LatLng(29.7424263541667, -95.3239259375);
              yield return new LatLng(29.7230706734694, -95.4438294693878);
              yield return new LatLng(29.7460256122449, -95.3201361632653);
              yield return new LatLng(29.7286966852461, -95.3293934555233);
              yield return new LatLng(29.7431799795918, -95.335219);
              yield return new LatLng(29.7555825918367, -95.3671954693878);
              yield return new LatLng(29.7387428163265, -95.3236960408163);
              yield return new LatLng(29.7426569708935, -95.3457486695248);
              yield return new LatLng(29.7406051836735, -95.3777541632653);
              yield return new LatLng(29.7331584848485, -95.3653621212121);
              yield return new LatLng(29.726725969697, -95.3642849595959);
              yield return new LatLng(29.7210404785098, -95.3519107634495);
              yield return new LatLng(29.726725969697, -95.3642849595959);
              yield return new LatLng(29.7418355306122, -95.359056122449);
              yield return new LatLng(29.7257288965517, -95.3612781896552);
              yield return new LatLng(29.7257288965517, -95.3612781896552);
              yield return new LatLng(29.7300966352384, -95.365334058868);
              yield return new LatLng(29.7372372040816, -95.3533493469388);
              yield return new LatLng(29.7328198783784, -95.3567026216216);
              yield return new LatLng(29.7278857346939, -95.3625148979592);
              yield return new LatLng(29.8512618763023, -95.3471688200761);
              yield return new LatLng(29.7344306578947, -95.3537991578947);
              yield return new LatLng(29.7323601632653, -95.3660219183674);
              yield return new LatLng(29.721481, -95.3734767373737);
              yield return new LatLng(29.710207, -95.380721);
              yield return new LatLng(29.7239905486204, -95.3689535867699);
              yield return new LatLng(29.7195491641791, -95.352500880597);
              yield return new LatLng(29.7229642323232, -95.3672546868687);
              yield return new LatLng(29.7265036969697, -95.3731142424242);
              yield return new LatLng(29.7131033388305, -95.3604848526956);
              yield return new LatLng(29.7131033388305, -95.3604848526956);
              yield return new LatLng(29.6771749715189, -95.315098226665);
              yield return new LatLng(29.7229002857143, -95.3887467346939);
              yield return new LatLng(29.7132564424437, -95.4111535322034);
              yield return new LatLng(29.7269601428571, -95.3872726122449);
              yield return new LatLng(29.7149740408163, -95.4175141428571);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7387175102041, -95.3044341428571);
              yield return new LatLng(29.9201786642543, -95.4025983931395);
              yield return new LatLng(29.7420568163265, -95.3075196938776);
              yield return new LatLng(29.7136559230769, -95.2985186923077);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.7366614285714, -95.2982012653061);
              yield return new LatLng(29.7331317135678, -95.3161996482412);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.7549829, -95.3352614);
              yield return new LatLng(29.733561, -95.2916055);
              yield return new LatLng(29.7085117878788, -95.2987358787879);
              yield return new LatLng(29.7186284081633, -95.2590932857143);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6690153265306, -95.262524877551);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7055671111111, -95.2436566464646);
              yield return new LatLng(29.6613119204072, -95.2522197571991);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6471667142857, -95.2101699387755);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.64627833308, -95.2255742525633);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.646467, -95.2224875);
              yield return new LatLng(29.6247271643851, -95.2439637653133);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6471233061224, -95.2254164081633);
              yield return new LatLng(29.6499557179487, -95.2230942564102);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6476196046512, -95.2214794418605);
              yield return new LatLng(29.6380816895972, -95.248150945598);
              yield return new LatLng(29.589798969697, -95.2338846363636);
              yield return new LatLng(29.5947808686869, -95.220746969697);
              yield return new LatLng(29.6198098571429, -95.1980159183673);
              yield return new LatLng(29.7208343, -95.2119019);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.5671180250896, -95.1081326779549);
              yield return new LatLng(29.5706854665363, -95.1384142911772);
              yield return new LatLng(29.670022, -95.241951);
              yield return new LatLng(29.6977861029018, -95.3093439499886);
              yield return new LatLng(29.6998534528302, -95.3040841509434);
              yield return new LatLng(29.7688115, -95.2132302);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6745395090346, -95.2858233983958);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6853659558824, -95.2821028529412);
              yield return new LatLng(29.6852546875, -95.29464546875);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6320427870586, -95.3446864007496);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.673639625, -95.29826903125);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6475941020408, -95.2913221020408);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6874053023256, -95.351453);
              yield return new LatLng(29.6868982423264, -95.3470521058941);
              yield return new LatLng(29.7022696972138, -95.3374975547935);
              yield return new LatLng(29.6964826316332, -95.3489977462697);
              yield return new LatLng(29.70296, -95.3398563061224);
              yield return new LatLng(29.6896165740032, -95.3391033892554);
              yield return new LatLng(29.6783752432432, -95.3408551081081);
              yield return new LatLng(29.6632876734694, -95.3632571836735);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.7212147272727, -95.3792025454545);
              yield return new LatLng(29.651732, -95.3656409795918);
              yield return new LatLng(29.662386526219, -95.3517625863524);
              yield return new LatLng(29.6527216027397, -95.3545789315069);
              yield return new LatLng(29.6653931020408, -95.3572270204082);
              yield return new LatLng(29.6899647474747, -95.3648241515152);
              yield return new LatLng(29.6634303673469, -95.3268964897959);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6698980937122, -95.3270044503742);
              yield return new LatLng(29.6619733061224, -95.3268623469388);
              yield return new LatLng(29.661513, -95.325104);
              yield return new LatLng(29.6840405, -95.3296735);
              yield return new LatLng(29.6585018, -95.5903423);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6331533125, -95.3494081875);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.6998534528302, -95.3040841509434);
              yield return new LatLng(29.6445832131991, -95.3146201666364);
              yield return new LatLng(29.7519692483748, -95.4021026047309);
              yield return new LatLng(29.67870475, -95.4780611951254);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6509721428571, -95.4770705238095);
              yield return new LatLng(29.8314418, -95.5263863);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7229072289599, -95.4889334123641);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6765440772964, -95.4322437066983);
              yield return new LatLng(29.6584850801928, -95.4552143816888);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.753442, -95.366406);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.639867, -95.4044383);
              yield return new LatLng(29.609889, -95.343956);
              yield return new LatLng(29.6122279407746, -95.342106048232);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.685, -95.577179);
              yield return new LatLng(29.6122515854219, -95.3482083376241);
              yield return new LatLng(29.6122515854219, -95.3482083376241);
              yield return new LatLng(29.6097617882565, -95.4417708386001);
              yield return new LatLng(29.606104, -95.449994);
              yield return new LatLng(29.6122515854219, -95.3482083376241);
              yield return new LatLng(29.6122515854219, -95.3482083376241);
              yield return new LatLng(29.6122673485201, -95.3522765305522);
              yield return new LatLng(29.5948851041063, -95.460595272574);
              yield return new LatLng(29.6162267248322, -95.4707434228188);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6016025710347, -95.4898259526436);
              yield return new LatLng(29.99693, -95.587699);
              yield return new LatLng(29.5938944637425, -95.4806887766585);
              yield return new LatLng(29.5800079, -95.5178773);
              yield return new LatLng(29.7064560204082, -95.484556877551);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7201254166667, -95.4858726666667);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7163082380952, -95.4879661904762);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.6696287927198, -95.5329880194957);
              yield return new LatLng(29.7841063, -95.575628);
              yield return new LatLng(29.7841063, -95.575628);
              yield return new LatLng(29.7841063, -95.575628);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.6398775153154, -95.4952952282314);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7358458582553, -95.4666498658);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7275692653061, -95.4694857142857);
              yield return new LatLng(29.6763898788832, -95.3335234356999);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7328357857233, -95.4959019983648);
              yield return new LatLng(29.7546230204082, -95.4795150408163);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7427621959286, -95.5014410076435);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7166998, -95.5578608);
              yield return new LatLng(29.7166998, -95.5578608);
              yield return new LatLng(29.7263909813509, -95.5153845604076);
              yield return new LatLng(29.719774, -95.5152425);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7129428823529, -95.5176169411765);
              yield return new LatLng(29.7176542857143, -95.5210405510204);
              yield return new LatLng(29.6742027862851, -95.5715125598617);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6806765179746, -95.5519886083931);
              yield return new LatLng(29.6748763265306, -95.5555579387755);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.6702661469287, -95.5911171435625);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.6890000329953, -95.5945157356845);
              yield return new LatLng(29.7151687755102, -95.574898755102);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.703431, -95.614995);
              yield return new LatLng(29.7034852857143, -95.5990405714286);
              yield return new LatLng(29.703431, -95.614995);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.703431, -95.614995);
              yield return new LatLng(29.6774892702703, -95.6010396756757);
              yield return new LatLng(29.6651785897436, -95.6179441538462);
              yield return new LatLng(29.6751812244898, -95.5879819387755);
              yield return new LatLng(29.676605125, -95.597925625);
              yield return new LatLng(29.6774892702703, -95.6010396756757);
              yield return new LatLng(29.6774892702703, -95.6010396756757);
              yield return new LatLng(29.6861766734694, -95.7970316530612);
              yield return new LatLng(29.6890000329953, -95.5945157356845);
              yield return new LatLng(29.6632698163265, -95.6186399183674);
              yield return new LatLng(29.67414, -95.545926);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.67414, -95.545926);
              yield return new LatLng(29.67414, -95.545926);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.67414, -95.545926);
              yield return new LatLng(29.9718642, -95.7008352);
              yield return new LatLng(29.7556417755102, -95.355171877551);
              yield return new LatLng(29.7539912857143, -95.3579157346939);
              yield return new LatLng(29.7534760612245, -95.3637134897959);
              yield return new LatLng(29.7520665918367, -95.3686781428571);
              yield return new LatLng(29.7513175306122, -95.3692710612245);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.751245755102, -95.3864359387755);
              yield return new LatLng(29.8316264, -95.7543887);
              yield return new LatLng(29.7525945918367, -95.3826068163265);
              yield return new LatLng(29.7395810268456, -95.3883934697987);
              yield return new LatLng(29.7452064081633, -95.3337536530612);
              yield return new LatLng(29.7526015102041, -95.3817193265306);
              yield return new LatLng(29.7521732857143, -95.3769582244898);
              yield return new LatLng(29.7568478163265, -95.3682189591837);
              yield return new LatLng(29.7464733469388, -95.3674949183673);
              yield return new LatLng(29.7552639387755, -95.3656179183673);
              yield return new LatLng(29.7069508367347, -95.4285631632653);
              yield return new LatLng(29.707075755102, -95.2934393673469);
              yield return new LatLng(29.7504140408163, -95.375086122449);
              yield return new LatLng(29.7504140408163, -95.375086122449);
              yield return new LatLng(29.7404931020408, -95.4186617142857);
              yield return new LatLng(29.4741569387755, -95.053858244898);
              yield return new LatLng(29.7265335454545, -95.4050775151515);
              yield return new LatLng(29.7333856570465, -95.4057180393705);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7353466122449, -95.4384295918367);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7145460533232, -95.5473556485833);
              yield return new LatLng(29.70753144, -95.54541096);
              yield return new LatLng(29.7299320039905, -95.5758689081626);
              yield return new LatLng(29.7305870438773, -95.5943704231359);
              yield return new LatLng(29.7279804081633, -95.6203126938776);
              yield return new LatLng(29.74032015, -95.5763157166667);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7689416734694, -95.5570324693877);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7781723866877, -95.5700749900775);
              yield return new LatLng(29.7679143489113, -95.4153370719422);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7736919, -95.7951813);
              yield return new LatLng(29.7701624285714, -95.6072401428572);
              yield return new LatLng(29.7629606938776, -95.6109198979592);
              yield return new LatLng(29.7445894652107, -95.5840243373308);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7356208448157, -95.6407774099153);
              yield return new LatLng(29.7465544, -95.6208123);
              yield return new LatLng(29.7426681485505, -95.62373571472);
              yield return new LatLng(29.7357165918367, -95.6347353673469);
              yield return new LatLng(29.7417845067647, -95.6236030358309);
              yield return new LatLng(29.7356264814815, -95.6394377592593);
              yield return new LatLng(29.7534606530612, -95.625164);
              yield return new LatLng(29.9568563, -95.2646183);
              yield return new LatLng(29.9568563, -95.2646183);
              yield return new LatLng(29.9568563, -95.2646183);
              yield return new LatLng(29.7861910816327, -95.3595203061225);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7431287959184, -95.3757514081633);
              yield return new LatLng(29.7987152121212, -95.3639167878788);
              yield return new LatLng(29.7987152121212, -95.3639167878788);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.8115813, -95.376121);
              yield return new LatLng(29.8042822857143, -95.3635851428571);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.480116, -95.049775);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.7926672653061, -95.3730034285714);
              yield return new LatLng(29.8150102727273, -95.3894122121212);
              yield return new LatLng(29.8064240922139, -95.3671933431967);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6246156, -95.2150761);
              yield return new LatLng(29.6246156, -95.2150761);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7914696122449, -95.4062631020408);
              yield return new LatLng(29.7950257, -95.3771289);
              yield return new LatLng(29.8386523, -95.402823);
              yield return new LatLng(29.6579762653061, -95.2173275510204);
              yield return new LatLng(29.8386523, -95.402823);
              yield return new LatLng(29.797160755102, -95.3955287346939);
              yield return new LatLng(29.7651355, -95.381257);
              yield return new LatLng(29.7704622, -95.4137459);
              yield return new LatLng(29.8386523, -95.402823);
              yield return new LatLng(29.7620149090909, -95.4201836363636);
              yield return new LatLng(29.8134104364234, -95.470553328755);
              yield return new LatLng(29.8140294150943, -95.4522471698113);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8409002801797, -95.4889705105929);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.7555825918367, -95.3671954693878);
              yield return new LatLng(29.8189627407407, -95.3592015555556);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8398963877551, -95.3654192244898);
              yield return new LatLng(29.7897321918785, -95.5345393821417);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8188563959732, -95.5263477718121);
              yield return new LatLng(29.7316734425901, -95.6079469686238);
              yield return new LatLng(29.838955755102, -95.561071244898);
              yield return new LatLng(29.7534606530612, -95.625164);
              yield return new LatLng(29.7955031521739, -95.6856988586957);
              yield return new LatLng(29.7534606530612, -95.625164);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.982078, -95.564517);
              yield return new LatLng(29.7884008399005, -95.5971583475707);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.805539, -95.524427);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8159926756757, -95.5140208783784);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8244741136275, -95.4928524156023);
              yield return new LatLng(29.8261727853362, -95.5255857780887);
              yield return new LatLng(29.7232389, -95.397455812597);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8581271632653, -95.5452768571429);
              yield return new LatLng(29.8573801155779, -95.5294352261307);
              yield return new LatLng(29.8425370608201, -95.506197369344);
              yield return new LatLng(29.8429517171717, -95.5016518080808);
              yield return new LatLng(29.8573318484849, -95.5313286060606);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8545665384615, -95.5452466153846);
              yield return new LatLng(29.9651946834171, -95.5530715979899);
              yield return new LatLng(29.8496542401628, -95.388240055426);
              yield return new LatLng(29.8409623, -95.4598133);
              yield return new LatLng(29.8630581073442, -95.4157986266573);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8679316472733, -95.4730487165671);
              yield return new LatLng(29.8627265612351, -95.4464926246661);
              yield return new LatLng(29.6749167755102, -95.2579334081633);
              yield return new LatLng(29.9227853333333, -95.4367832424242);
              yield return new LatLng(29.950176, -95.4113291428571);
              yield return new LatLng(29.9506993414634, -95.3976742439024);
              yield return new LatLng(29.950750755102, -95.3924097346939);
              yield return new LatLng(29.9507094081633, -95.3963921020408);
              yield return new LatLng(29.9506993414634, -95.3976742439024);
              yield return new LatLng(29.9503665, -95.4049005);
              yield return new LatLng(29.9507094081633, -95.3963921020408);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.7749094081633, -95.3223660612245);
              yield return new LatLng(29.770891, -95.341493);
              yield return new LatLng(29.7686890516805, -95.3272297286584);
              yield return new LatLng(29.7798255672991, -95.3389658970131);
              yield return new LatLng(29.8052338080808, -95.3298213131313);
              yield return new LatLng(29.7814872653061, -95.3318828979592);
              yield return new LatLng(29.8110868780081, -95.3190625522759);
              yield return new LatLng(29.8003949865772, -95.3120282751678);
              yield return new LatLng(29.8052338080808, -95.3298213131313);
              yield return new LatLng(29.8119293631487, -95.3190771146244);
              yield return new LatLng(29.8022963434343, -95.3343956868687);
              yield return new LatLng(29.7971240408163, -95.3322517346939);
              yield return new LatLng(29.7955580606061, -95.3160310909091);
              yield return new LatLng(29.793811, -95.343289);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.806838160804, -95.3114500753769);
              yield return new LatLng(29.7973893253012, -95.3205971686747);
              yield return new LatLng(29.7945877708474, -95.3098423781748);
              yield return new LatLng(29.607654, -95.172573);
              yield return new LatLng(29.798977361809, -95.3188611557789);
              yield return new LatLng(29.8388681720438, -95.3428809131663);
              yield return new LatLng(29.8502716120471, -95.3440534448517);
              yield return new LatLng(29.8405570588235, -95.3515365294118);
              yield return new LatLng(29.8426763265306, -95.3528077755102);
              yield return new LatLng(29.866607, -95.323695);
              yield return new LatLng(29.8650564897959, -95.3349854081633);
              yield return new LatLng(29.9506966259176, -95.3040828942169);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8341663125, -95.3241235625);
              yield return new LatLng(29.7686215, -95.33616);
              yield return new LatLng(29.8172025555556, -95.307726);
              yield return new LatLng(29.8290937142857, -95.3018639591837);
              yield return new LatLng(29.7916114489796, -95.3506576122449);
              yield return new LatLng(29.8172025555556, -95.307726);
              yield return new LatLng(29.8285465046056, -95.3096213797298);
              yield return new LatLng(29.811739, -95.2844);
              yield return new LatLng(29.8126900408163, -95.2784030612245);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8520476, -95.2622695);
              yield return new LatLng(29.8523672978723, -95.2624699574468);
              yield return new LatLng(29.8543733333333, -95.2721798717949);
              yield return new LatLng(29.854973941334, -95.2662207688778);
              yield return new LatLng(29.857440122449, -95.2515101020408);
              yield return new LatLng(29.8528002727273, -95.2685681212121);
              yield return new LatLng(29.8629983737374, -95.3117897171717);
              yield return new LatLng(29.861627, -95.292901);
              yield return new LatLng(29.7409931399015, -95.2592071111489);
              yield return new LatLng(29.7392419602875, -95.2621854498573);
              yield return new LatLng(29.7423324583751, -95.2636253046008);
              yield return new LatLng(29.7765859795918, -95.3019523061225);
              yield return new LatLng(29.7754047755102, -95.2938953673469);
              yield return new LatLng(29.791535, -95.2701286153846);
              yield return new LatLng(29.7765939795918, -95.306056877551);
              yield return new LatLng(29.7765874897959, -95.3050308979592);
              yield return new LatLng(29.7765939795918, -95.306056877551);
              yield return new LatLng(29.7765874897959, -95.3050308979592);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.7916678, -95.2691466);
              yield return new LatLng(29.7972066349655, -95.2346315710054);
              yield return new LatLng(29.7881454978086, -95.1842449733379);
              yield return new LatLng(29.798005298172, -95.2324392920582);
              yield return new LatLng(29.798005298172, -95.2324392920582);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.7762081020408, -95.2182924489796);
              yield return new LatLng(29.7758349166667, -95.2214492916667);
              yield return new LatLng(29.77998184, -95.18664264);
              yield return new LatLng(29.781324, -95.218698);
              yield return new LatLng(29.6283932, -95.079053);
          }
     }

     public class October_2017_Burglary_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}