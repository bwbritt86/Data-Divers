using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class May_2016_Rape
     {
         public static IEnumerable<May_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new May_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7468704897959, -95.3727965918367);
              yield return new LatLng(29.738846755102, -95.377859244898);
              yield return new LatLng(29.711806375, -95.3563085);
              yield return new LatLng(29.7082498947368, -95.4019241578947);
              yield return new LatLng(29.7082498947368, -95.4019241578947);
              yield return new LatLng(29.7324766326531, -95.377266755102);
              yield return new LatLng(29.7373910816327, -95.3003276734694);
              yield return new LatLng(29.6926492357709, -95.2681417774264);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.663859856019, -95.2647520708822);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6930211, -95.3704613);
              yield return new LatLng(29.6834729591837, -95.373995755102);
              yield return new LatLng(29.6760257070707, -95.3744760606061);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6452192281879, -95.3759072416107);
              yield return new LatLng(29.623166030303, -95.3672611515152);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7095881836735, -95.4887604285714);
              yield return new LatLng(29.7091976998089, -95.4733714062883);
              yield return new LatLng(29.7010972417825, -95.4823867898904);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.8617474, -95.5442895);
              yield return new LatLng(29.6633387841708, -95.5334986603611);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7280530612245, -95.4982393265306);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7147428, -95.51354356);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.725472, -95.48764);
              yield return new LatLng(29.7151986873591, -95.5199305635968);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7147428, -95.51354356);
              yield return new LatLng(29.7176542857143, -95.5210405510204);
              yield return new LatLng(29.677176, -95.5536635);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7052706326531, -95.6075246530612);
              yield return new LatLng(29.6622151428571, -95.5720633877551);
              yield return new LatLng(29.667201, -95.5638987586207);
              yield return new LatLng(29.7608597346939, -95.3675515918367);
              yield return new LatLng(29.7533984693878, -95.3727276530612);
              yield return new LatLng(29.748035101086, -95.3915733517162);
              yield return new LatLng(29.7567589387755, -95.3777080612245);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.717628755102, -95.5450521836735);
              yield return new LatLng(29.7091863131313, -95.5453897878788);
              yield return new LatLng(29.7702167903226, -95.6043739032258);
              yield return new LatLng(29.7523744214544, -95.6186034248669);
              yield return new LatLng(29.7809406326531, -95.3522979387755);
              yield return new LatLng(29.7704622, -95.4137459);
              yield return new LatLng(29.7989953154362, -95.4375124060403);
              yield return new LatLng(29.8338804, -95.3878504);
              yield return new LatLng(29.8198585779508, -95.5307355086236);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.808422290865, -95.4850248481863);
              yield return new LatLng(29.8523438341934, -95.4088603869212);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.793223, -95.335866);
              yield return new LatLng(29.8022937070707, -95.3155862626263);
              yield return new LatLng(29.8053832424242, -95.3126126666667);
              yield return new LatLng(29.8435112134407, -95.3410650379762);
              yield return new LatLng(29.8497121501261, -95.3467825911523);
              yield return new LatLng(29.827191, -95.337686);
              yield return new LatLng(29.827191, -95.337686);
              yield return new LatLng(29.8367518979592, -95.2951553061225);
              yield return new LatLng(29.861627, -95.292901);
              yield return new LatLng(29.7784024693878, -95.3034939387755);
              yield return new LatLng(29.771588, -95.18252);
              yield return new LatLng(29.7912115, -95.205692);
              yield return new LatLng(29.781324, -95.218698);
              yield return new LatLng(29.781324, -95.218698);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7860346275211, -95.7896414556677);
          }
     }

     public class May_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
