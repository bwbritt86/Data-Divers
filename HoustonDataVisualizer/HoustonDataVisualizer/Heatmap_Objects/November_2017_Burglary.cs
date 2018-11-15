using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class November_2017_Burglary
     {
         public static IEnumerable<November_2017_Burglary_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new November_2017_Burglary_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7571794081633, -95.3422107142857);
              yield return new LatLng(29.7582376160207, -95.3468680089933);
              yield return new LatLng(29.7545725918367, -95.3335156122449);
              yield return new LatLng(29.7478929591837, -95.3415907755102);
              yield return new LatLng(29.7248576458333, -95.3239702777778);
              yield return new LatLng(29.7366515102041, -95.3368263877551);
              yield return new LatLng(29.7517806938775, -95.3506758367347);
              yield return new LatLng(29.7426569708935, -95.3457486695248);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7468704897959, -95.3727965918367);
              yield return new LatLng(29.850873, -95.557408);
              yield return new LatLng(29.7305358979592, -95.3464504693878);
              yield return new LatLng(29.7314430469799, -95.3706316711409);
              yield return new LatLng(29.7282272592593, -95.3575764814815);
              yield return new LatLng(29.7378785714286, -95.3540210816327);
              yield return new LatLng(29.716557228695, -95.3559227517065);
              yield return new LatLng(29.7197504285714, -95.3709879387755);
              yield return new LatLng(29.7217544848485, -95.3667994242424);
              yield return new LatLng(29.7035314137931, -95.3641683448276);
              yield return new LatLng(29.7156792352941, -95.3563826470588);
              yield return new LatLng(29.7199198181818, -95.3531695858586);
              yield return new LatLng(29.7586088569613, -95.4851862249923);
              yield return new LatLng(29.7216063877551, -95.3674854489796);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.9657072, -95.5531865);
              yield return new LatLng(29.7032058838303, -95.3930670113819);
              yield return new LatLng(29.7234906510067, -95.3806778255034);
              yield return new LatLng(29.6543763365499, -95.5436609882391);
              yield return new LatLng(29.7024397777778, -95.3946868888889);
              yield return new LatLng(29.7024397777778, -95.3946868888889);
              yield return new LatLng(29.7240070816327, -95.3815258163265);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.720257, -95.409824);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.6769638069148, -95.3400758342018);
              yield return new LatLng(29.717304100223, -95.2917721837321);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.730781122449, -95.2972407959184);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.7401774897959, -95.3015943061225);
              yield return new LatLng(29.7110787575758, -95.2780250606061);
              yield return new LatLng(29.7110787575758, -95.2780250606061);
              yield return new LatLng(29.7285985319821, -95.2980821998566);
              yield return new LatLng(29.6830443265306, -95.2548051632653);
              yield return new LatLng(29.6809827755102, -95.2575608571429);
              yield return new LatLng(29.7014603956968, -95.2730859434224);
              yield return new LatLng(29.6925782825632, -95.2732344552802);
              yield return new LatLng(29.668193, -95.255756);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6788040101945, -95.2500393734302);
              yield return new LatLng(29.6385264452097, -95.2375187219649);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6486686666667, -95.2418577575758);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.6432255410244, -95.2197365656326);
              yield return new LatLng(29.6363908571429, -95.227967244898);
              yield return new LatLng(29.6466000526316, -95.2241804736842);
              yield return new LatLng(29.6511890730137, -95.2275593346865);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.642145269568, -95.2415463606227);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.6023906432989, -95.2481139661855);
              yield return new LatLng(29.6264292244898, -95.2057833469388);
              yield return new LatLng(29.6422458927274, -95.2003176689581);
              yield return new LatLng(29.5666873102178, -95.1431980524022);
              yield return new LatLng(29.6866541, -95.2567664);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6815026551724, -95.3044503103448);
              yield return new LatLng(29.7081616398415, -95.3209636251301);
              yield return new LatLng(29.6861749795918, -95.3017728367347);
              yield return new LatLng(29.6545874077079, -95.2257391531406);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6692071020408, -95.2645540408163);
              yield return new LatLng(29.6692071020408, -95.2645540408163);
              yield return new LatLng(29.6692071020408, -95.2645540408163);
              yield return new LatLng(29.662404793543, -95.297956968894);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6630631515152, -95.274115);
              yield return new LatLng(29.6620120799246, -95.3154101094391);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6417095918367, -95.2376437346939);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.90155, -95.3043112);
              yield return new LatLng(29.70296, -95.3398563061224);
              yield return new LatLng(29.7054881179887, -95.337338513927);
              yield return new LatLng(29.693798, -95.3753406666667);
              yield return new LatLng(29.7016964273287, -95.3377249901062);
              yield return new LatLng(29.6870514516129, -95.3544253548387);
              yield return new LatLng(29.7018378472222, -95.3490594444444);
              yield return new LatLng(29.6987764137931, -95.3655902068966);
              yield return new LatLng(29.768562, -95.701816);
              yield return new LatLng(29.6905234089495, -95.3454339424481);
              yield return new LatLng(29.7067537364602, -95.3364849525605);
              yield return new LatLng(29.7020104285714, -95.3426204693878);
              yield return new LatLng(29.6997586626597, -95.3418488565445);
              yield return new LatLng(29.6616278291716, -95.351473924759);
              yield return new LatLng(29.6541593939394, -95.3668622121212);
              yield return new LatLng(29.7595980204082, -95.3665563061224);
              yield return new LatLng(29.662386526219, -95.3517625863524);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6570062857143, -95.3374864081633);
              yield return new LatLng(29.6626897959184, -95.326881877551);
              yield return new LatLng(29.6657225959596, -95.3261327676768);
              yield return new LatLng(29.670017, -95.323727);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.682525, -95.380777);
              yield return new LatLng(29.6382993862806, -95.3550403057744);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6987750493894, -95.3481093612396);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6515675932936, -95.3800657347425);
              yield return new LatLng(29.6692636938776, -95.4971496326531);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.6825803491622, -95.5019085091206);
              yield return new LatLng(29.6633801111111, -95.4553982020202);
              yield return new LatLng(29.6874105682699, -95.2403122161806);
              yield return new LatLng(29.6691536896552, -95.3475393448276);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6679563887739, -95.441156709744);
              yield return new LatLng(29.6843609166667, -95.4379058055555);
              yield return new LatLng(29.6572376122449, -95.462274);
              yield return new LatLng(29.6831286308725, -95.4289331342282);
              yield return new LatLng(29.6715972825934, -95.4521905035636);
              yield return new LatLng(29.6759669130435, -95.4460050434783);
              yield return new LatLng(29.66756998747, -95.4585220417324);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7199089, -95.3186112);
              yield return new LatLng(29.6261417401806, -95.4360338501166);
              yield return new LatLng(29.753442, -95.366406);
              yield return new LatLng(29.6621636697741, -95.4247000114149);
              yield return new LatLng(29.6122358223237, -95.3441401446961);
              yield return new LatLng(29.612259466971, -95.3502424340882);
              yield return new LatLng(29.6260157777778, -95.3495009444444);
              yield return new LatLng(29.633581244898, -95.4400118367347);
              yield return new LatLng(29.6162381748038, -95.443849719464);
              yield return new LatLng(29.6237237134349, -95.4768723357211);
              yield return new LatLng(29.6303391673495, -95.4295265066505);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.5897945714286, -95.4772715918367);
              yield return new LatLng(29.609102, -95.488907);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.707184, -95.4930684081633);
              yield return new LatLng(29.7096309591837, -95.4930376734694);
              yield return new LatLng(29.7100165714286, -95.4836343061224);
              yield return new LatLng(29.7099596530612, -95.4877962857143);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.6923847312957, -95.4907491939619);
              yield return new LatLng(29.6945505716031, -95.5447221266813);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.6398775153154, -95.4952952282314);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6664835909091, -95.5068262727273);
              yield return new LatLng(29.6372205913804, -95.4797161172271);
              yield return new LatLng(29.5917053942399, -95.4610219374406);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6654119387755, -95.5203619387755);
              yield return new LatLng(29.6499357142857, -95.5339048571429);
              yield return new LatLng(29.7856323, -95.7949143);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.742196, -95.470733);
              yield return new LatLng(29.7423368657718, -95.4641286912752);
              yield return new LatLng(29.8674587834849, -95.6641043442199);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7300445714286, -95.4712875714286);
              yield return new LatLng(29.6749249556197, -95.4705100359318);
              yield return new LatLng(29.743971959596, -95.4669190606061);
              yield return new LatLng(29.7477008455882, -95.4672113529412);
              yield return new LatLng(29.654198, -95.208645);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7387761136364, -95.4823915681818);
              yield return new LatLng(29.7458953272866, -95.4824884925227);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7283519567984, -95.490929109543);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7635834006181, -95.4787056697866);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7748775918367, -95.3546912653061);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.740568952381, -95.5315747142857);
              yield return new LatLng(29.7348323258184, -95.5206664813064);
              yield return new LatLng(29.7362698016622, -95.5348421994102);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7114354285714, -95.5514411428571);
              yield return new LatLng(29.7166998, -95.5578608);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.720207, -95.4781253434343);
              yield return new LatLng(29.719774, -95.5152425);
              yield return new LatLng(29.6748624081633, -95.5825100408163);
              yield return new LatLng(29.6819350992162, -95.4697514271995);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.679273, -95.5528135);
              yield return new LatLng(29.6773787236322, -95.557182292604);
              yield return new LatLng(29.7004662244898, -95.5529657959184);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.6823845, -95.5744802727273);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.679273, -95.5528135);
              yield return new LatLng(29.679273, -95.5528135);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.690332, -95.596011);
              yield return new LatLng(29.7936479023801, -95.7362405817962);
              yield return new LatLng(29.6977325162862, -95.6144962137379);
              yield return new LatLng(29.7032353469388, -95.5960565510204);
              yield return new LatLng(29.7034852857143, -95.5990405714286);
              yield return new LatLng(29.7034852857143, -95.5990405714286);
              yield return new LatLng(29.7033987096774, -95.6051268387097);
              yield return new LatLng(29.6889832030285, -95.5973071906947);
              yield return new LatLng(29.6889799327404, -95.5992793604477);
              yield return new LatLng(29.6774892702703, -95.6010396756757);
              yield return new LatLng(29.675098890411, -95.5865231369863);
              yield return new LatLng(29.675098890411, -95.5865231369863);
              yield return new LatLng(29.7409888140704, -95.5313891256281);
              yield return new LatLng(29.6748624081633, -95.5825100408163);
              yield return new LatLng(29.674648877551, -95.558803);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7578600408163, -95.3699452653061);
              yield return new LatLng(29.7513880624861, -95.3730432071743);
              yield return new LatLng(29.746678027027, -95.382937);
              yield return new LatLng(29.7563690816327, -95.3764716530612);
              yield return new LatLng(29.7490659795918, -95.3718151836735);
              yield return new LatLng(29.7544659591837, -95.375531244898);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7420500816327, -95.4162989591837);
              yield return new LatLng(29.74404, -95.36347);
              yield return new LatLng(29.7317065360055, -95.403903793902);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.867723, -95.682666);
              yield return new LatLng(29.7337422424242, -95.37286);
              yield return new LatLng(29.7323577474747, -95.4257303939394);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7314351586017, -95.4420094859246);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7095989393939, -95.5453973636364);
              yield return new LatLng(29.7096375555556, -95.5514230555556);
              yield return new LatLng(29.7096375555556, -95.5514230555556);
              yield return new LatLng(29.6981726363636, -95.5786790808081);
              yield return new LatLng(29.734864608771, -95.8353086552248);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7231712724981, -95.5508922238388);
              yield return new LatLng(29.7328670125864, -95.5458306290917);
              yield return new LatLng(29.7342176494759, -95.5434038457369);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7299320039905, -95.5758689081626);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.74032015, -95.5763157166667);
              yield return new LatLng(29.74032015, -95.5763157166667);
              yield return new LatLng(29.9197172021061, -95.4345835508026);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7670070538475, -95.5576182329338);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7670070538475, -95.5576182329338);
              yield return new LatLng(29.7704375, -95.591008);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7758969027778, -95.5681935138889);
              yield return new LatLng(29.6934025, -95.488681);
              yield return new LatLng(29.7704375, -95.591008);
              yield return new LatLng(29.7702167903226, -95.6043739032258);
              yield return new LatLng(29.778655, -95.619269);
              yield return new LatLng(29.7726960625, -95.610035);
              yield return new LatLng(29.716955, -95.6156455);
              yield return new LatLng(29.7448966734694, -95.6143539591837);
              yield return new LatLng(29.7560415102041, -95.6251846326531);
              yield return new LatLng(29.9569443, -95.3602904);
              yield return new LatLng(29.7876873265306, -95.3511527959184);
              yield return new LatLng(29.7782976617647, -95.3550575882353);
              yield return new LatLng(29.776740755102, -95.3554049591837);
              yield return new LatLng(29.7760603, -95.29134);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7479256658483, -95.4187270524921);
              yield return new LatLng(29.7862998, -95.6024288);
              yield return new LatLng(29.8030811020408, -95.3852635102041);
              yield return new LatLng(29.0762975, -98.0787755);
              yield return new LatLng(29.812826, -95.3700926341463);
              yield return new LatLng(29.6246156, -95.2150761);
              yield return new LatLng(29.7866253877551, -95.3722109795918);
              yield return new LatLng(29.6246156, -95.2150761);
              yield return new LatLng(29.6246156, -95.2150761);
              yield return new LatLng(29.6579762653061, -95.2173275510204);
              yield return new LatLng(29.7950257, -95.3771289);
              yield return new LatLng(29.7853680612245, -95.3800002244898);
              yield return new LatLng(29.8386523, -95.402823);
              yield return new LatLng(29.6246156, -95.2150761);
              yield return new LatLng(29.788924110798, -95.3722302944684);
              yield return new LatLng(29.8025451818182, -95.3945269393939);
              yield return new LatLng(29.7860186595745, -95.3722006808511);
              yield return new LatLng(29.7647492902612, -95.3918393689879);
              yield return new LatLng(29.7764878571429, -95.3741866326531);
              yield return new LatLng(29.7646415510204, -95.3799369591837);
              yield return new LatLng(29.7753909779065, -95.416898794165);
              yield return new LatLng(29.7809002727273, -95.3718365757576);
              yield return new LatLng(29.7704622, -95.4137459);
              yield return new LatLng(29.7720079, -95.5590776);
              yield return new LatLng(29.7710859183673, -95.4148618367347);
              yield return new LatLng(29.7669748163265, -95.3973277142857);
              yield return new LatLng(29.7720079, -95.5590776);
              yield return new LatLng(29.8232264728521, -95.4618204572022);
              yield return new LatLng(29.813688, -95.4657972653061);
              yield return new LatLng(29.8144223557047, -95.4593580872483);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8232782063492, -95.4594408412698);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8090739795918, -95.4590284897959);
              yield return new LatLng(29.847443, -95.506253);
              yield return new LatLng(29.8500148367347, -95.4889734081633);
              yield return new LatLng(29.8500148367347, -95.4889734081633);
              yield return new LatLng(29.849159, -95.344179);
              yield return new LatLng(29.8090739795918, -95.4590284897959);
              yield return new LatLng(29.8500148367347, -95.4889734081633);
              yield return new LatLng(29.8391319834711, -95.4929037355372);
              yield return new LatLng(29.8500148367347, -95.4889734081633);
              yield return new LatLng(29.8144223557047, -95.4593580872483);
              yield return new LatLng(29.8205054744526, -95.4391011240876);
              yield return new LatLng(29.8355226912752, -95.413506557047);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.8337888787879, -95.364749);
              yield return new LatLng(29.8283766363636, -95.3985314772727);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.8463149782577, -95.364270913621);
              yield return new LatLng(29.8180495025126, -95.3676984874372);
              yield return new LatLng(29.7890855778125, -95.5424412723044);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.8072187878788, -95.5299168181818);
              yield return new LatLng(29.8337888688813, -95.5533669444339);
              yield return new LatLng(29.8122296950384, -95.5302739813613);
              yield return new LatLng(29.8347179113924, -95.5698816898734);
              yield return new LatLng(29.844062, -95.5525745);
              yield return new LatLng(29.7965438131868, -95.5746595714286);
              yield return new LatLng(29.7896874444444, -95.569912);
              yield return new LatLng(29.7106817878788, -95.5163259393939);
              yield return new LatLng(29.7973879642857, -95.4680425);
              yield return new LatLng(29.7973879642857, -95.4680425);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8110242272727, -95.4998665454546);
              yield return new LatLng(29.7951623673469, -95.4850140816327);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8218590674987, -95.5249676573458);
              yield return new LatLng(29.8097129090909, -95.5240751818182);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8681169, -95.5069734);
              yield return new LatLng(29.8633944190671, -95.5156402292673);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8158994793611, -95.5607124312338);
              yield return new LatLng(29.8843385945946, -95.3699298378378);
              yield return new LatLng(29.6891217606161, -95.2965052607335);
              yield return new LatLng(29.8549966986301, -95.3930829657534);
              yield return new LatLng(29.8423704706888, -95.4300028520061);
              yield return new LatLng(29.8457143682549, -95.3730964639952);
              yield return new LatLng(29.8487053636364, -95.4180788787879);
              yield return new LatLng(29.8598733316583, -95.4541850753769);
              yield return new LatLng(29.8423704706888, -95.4300028520061);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8640054476652, -95.4734467215761);
              yield return new LatLng(29.8706035549092, -95.4646848644766);
              yield return new LatLng(29.8614693316583, -95.473508758794);
              yield return new LatLng(29.8699896122449, -95.4160956122449);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.938146, -95.4037715);
              yield return new LatLng(29.938146, -95.4037715);
              yield return new LatLng(29.9270325714286, -95.4094020816326);
              yield return new LatLng(29.7274284137931, -95.3549580344828);
              yield return new LatLng(29.950750755102, -95.3924097346939);
              yield return new LatLng(29.9452260564926, -95.3876247846255);
              yield return new LatLng(29.7333332222222, -95.3147429444444);
              yield return new LatLng(29.9452260564926, -95.3876247846255);
              yield return new LatLng(29.950403, -95.41026);
              yield return new LatLng(29.950176, -95.4113291428571);
              yield return new LatLng(29.9506993414634, -95.3976742439024);
              yield return new LatLng(29.950750755102, -95.3924097346939);
              yield return new LatLng(29.7708225454545, -95.3299849393939);
              yield return new LatLng(29.7784254489796, -95.3323224081633);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.8315842848386, -95.4505638441614);
              yield return new LatLng(29.7933197085427, -95.3170341055276);
              yield return new LatLng(29.816902212766, -95.3341522978723);
              yield return new LatLng(29.796103, -95.3282270408163);
              yield return new LatLng(29.8143776969697, -95.3309650606061);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.8040703469388, -95.3137777755102);
              yield return new LatLng(29.8173946767677, -95.3259306666667);
              yield return new LatLng(29.7959111395349, -95.3373506976744);
              yield return new LatLng(29.7921808484849, -95.3277542424242);
              yield return new LatLng(29.7918314489796, -95.317999122449);
              yield return new LatLng(29.8006626774194, -95.3296699032258);
              yield return new LatLng(29.7890711632653, -95.329909877551);
              yield return new LatLng(29.8135978666667, -95.3184568);
              yield return new LatLng(29.7891534375, -95.3170208125);
              yield return new LatLng(29.8135978666667, -95.3184568);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.7819514285714, -95.3322196122449);
              yield return new LatLng(29.7939223877551, -95.3085411020408);
              yield return new LatLng(29.8471077303371, -95.3498994269663);
              yield return new LatLng(29.8249601543624, -95.3442146644295);
              yield return new LatLng(29.8315363265306, -95.3427704081633);
              yield return new LatLng(29.8543772653061, -95.3295388367347);
              yield return new LatLng(29.8543772653061, -95.3295388367347);
              yield return new LatLng(29.7133852541773, -95.4929901752125);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8281144785366, -95.3188978100394);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8516755641026, -95.3112993461538);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8171952222222, -95.309424);
              yield return new LatLng(29.8323562236604, -95.304923892994);
              yield return new LatLng(29.8316472348993, -95.314093442953);
              yield return new LatLng(29.8258579795918, -95.2796965510204);
              yield return new LatLng(29.8200345744681, -95.2809871914894);
              yield return new LatLng(29.820815361809, -95.2762223165829);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.8162022727273, -95.2799990909091);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.8028735102041, -95.2870417551021);
              yield return new LatLng(29.8394945555556, -95.262322969697);
              yield return new LatLng(29.8033245227273, -95.2856179545455);
              yield return new LatLng(29.8495297336394, -95.2623028146728);
              yield return new LatLng(29.8445088493379, -95.2623981519002);
              yield return new LatLng(29.8532559795918, -95.2507680408163);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.8516961428571, -95.2698448571429);
              yield return new LatLng(29.8835609090909, -95.303501030303);
              yield return new LatLng(29.8732974, -95.2945552);
              yield return new LatLng(29.763807877551, -95.2660446530612);
              yield return new LatLng(29.7703493888889, -95.2756680454545);
              yield return new LatLng(29.7634894285714, -95.2680602653061);
              yield return new LatLng(29.826745125, -95.501503375);
              yield return new LatLng(29.7765860204082, -95.3029759183674);
              yield return new LatLng(29.771959877551, -95.3083489387755);
              yield return new LatLng(29.7756080612245, -95.302109);
              yield return new LatLng(29.7765905102041, -95.3130115510204);
              yield return new LatLng(29.7765905102041, -95.3130115510204);
              yield return new LatLng(29.7765905102041, -95.3130115510204);
              yield return new LatLng(29.7733774285714, -95.307314122449);
              yield return new LatLng(29.766954, -95.283797);
              yield return new LatLng(29.7730556373007, -95.1909875773153);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.7762081020408, -95.2182924489796);
              yield return new LatLng(29.8041142, -95.0215952);
              yield return new LatLng(29.7862566326531, -95.1891440816326);
              yield return new LatLng(29.7762081020408, -95.2182924489796);
              yield return new LatLng(29.7835808, -95.1869253);
              yield return new LatLng(29.7720608367347, -95.2182767959184);
              yield return new LatLng(29.7845607368421, -95.1856023684211);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7291373, -95.6375669);
          }
     }

     public class November_2017_Burglary_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}