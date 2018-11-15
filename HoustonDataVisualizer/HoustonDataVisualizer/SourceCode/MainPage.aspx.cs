using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoogleMaps.Samples.Data.Sources;
using System.Reflection;

namespace HoustonDataVisualizer.SourceCode
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //Use if-else statement to select heatmap object based on DropDownList selections
                
                //2016 
                if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(January_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(January_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(January_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(January_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(January_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(January_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(January_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(February_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(February_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(February_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(February_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(February_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(February_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(February_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(March_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(March_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(March_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(March_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(March_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(March_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(March_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(April_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(April_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(April_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(April_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(April_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(April_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(April_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(May_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(May_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(May_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(May_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(May_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(May_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(May_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(June_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(June_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(June_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(June_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(June_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(June_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(June_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(July_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(July_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(July_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(July_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(July_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(July_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(July_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(August_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(August_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(August_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(August_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(August_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(August_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(August_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(September_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(September_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(September_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(September_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(September_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(September_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(September_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(October_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(October_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(October_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(October_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(October_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(October_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(October_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(November_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(November_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(November_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(November_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(November_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(November_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(November_2016_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(December_2016_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(December_2016_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(December_2016_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(December_2016_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(December_2016_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(December_2016_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2016" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(December_2016_Rape.GetRawData());

                //2017
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(January_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(January_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(January_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(January_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(January_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(January_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "January" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(January_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(February_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(February_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(February_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(February_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(February_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(February_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "February" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(February_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(March_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(March_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(March_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(March_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(March_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(March_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "March" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(March_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(April_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(April_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(April_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(April_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(April_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(April_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "April" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(April_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(May_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(May_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(May_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(May_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(May_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(May_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "May" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(May_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(June_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(June_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(June_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(June_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(June_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(June_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "June" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(June_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(July_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(July_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(July_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(July_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(July_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(July_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "July" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(July_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(August_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(August_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(August_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(August_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(August_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(August_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "August" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(August_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(September_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(September_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(September_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(September_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(September_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(September_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "September" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(September_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(October_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(October_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(October_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(October_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(October_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(October_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "October" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(October_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(November_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(November_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(November_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(November_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(November_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(November_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "November" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(November_2017_Rape.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Theft")
                    Heatmap1.AddRange(December_2017_Theft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Burglary")
                    Heatmap1.AddRange(December_2017_Burglary.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "AggravatedAssault")
                    Heatmap1.AddRange(December_2017_AggravatedAssault.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Robbery")
                    Heatmap1.AddRange(December_2017_Robbery.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "AutoTheft")
                    Heatmap1.AddRange(December_2017_AutoTheft.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Murder")
                    Heatmap1.AddRange(December_2017_Murder.GetRawData());
                else if (DropDownList1.Text.ToString() == "2017" && DropDownList2.Text.ToString() == "December" && DropDownList3.Text.ToString() == "Rape")
                    Heatmap1.AddRange(December_2017_Rape.GetRawData());
            }

        }
    }
}