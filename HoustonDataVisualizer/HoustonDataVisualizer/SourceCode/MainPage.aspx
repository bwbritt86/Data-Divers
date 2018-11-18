<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="HoustonDataVisualizer.SourceCode.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!--https://bootswatch.com/yeti/-->

<head runat="server">
    <meta name="viewport" content="initial-scale=1.0" />
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="icon" type="image/ico" href="../images/mascot.ico" />
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
    <title>Houston Data Visualizer</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="bannerForBG" class="container" style="background-color: cornflowerblue">
            <div class="col-md-12">
                <h1 class="text-center" id="toolName" style="color: white; text-shadow: 2px 2px black;">The Houston Data Visualizer
                    <img id="dDLogo" class="pull-right" src="../Data%20Divers%20Logo.PNG" height="150" width="150" />
                </h1>
                <div id="teamBlock">
                    <h3 style="color: white; text-shadow: 2px 2px black;">Provided by the Data Divers UHCL Team</h3>
                    <small style="color: white; text-shadow: 2px 2px black;">--Data for Houston, By Houston--</small><br />
                    <br />
                    <br />
                    <br />
                </div>
            </div>
        </div>


        <br />

        <div class="container">
            <div class="row">
                <div id="meatOfThePage" class="col-md-12">
                    <div class="jumbotron">
                        <h2 class="display-3">Houston Map</h2>

                        <label for="addressMap">Address:</label>
                        <asp:textbox runat="server" readOnly="false" class="form-control col-md-1" rows="1" id="addressMap">--Leave blank for general view of map--</asp:textbox>
                        <hr />

                        <p class="lead">Here you can see the offenses in Houston by selecting from the options below and clicking  the 'Submit!' button.</p>
                        <hr class="my-4" />
                        <p>
                  
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Year:</asp:ListItem>
                            <asp:ListItem>2016</asp:ListItem>
                            <asp:ListItem>2017</asp:ListItem>
                        </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem>Month:</asp:ListItem>
                            <asp:ListItem>January</asp:ListItem>
                            <asp:ListItem>February</asp:ListItem>
                            <asp:ListItem>March</asp:ListItem>
                            <asp:ListItem>April</asp:ListItem>
                            <asp:ListItem>May</asp:ListItem>
                            <asp:ListItem>June</asp:ListItem>
                            <asp:ListItem>July</asp:ListItem>
                            <asp:ListItem>August</asp:ListItem>
                            <asp:ListItem>September</asp:ListItem>
                            <asp:ListItem>October</asp:ListItem>
                            <asp:ListItem>November</asp:ListItem>
                            <asp:ListItem>December</asp:ListItem>
                        </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
                        <asp:DropDownList ID="DropDownList3" runat="server">
                            <asp:ListItem>Offense Type:</asp:ListItem>
                            <asp:ListItem>AggravatedAssault</asp:ListItem>
                            <asp:ListItem>AutoTheft</asp:ListItem>
                            <asp:ListItem>Burglary</asp:ListItem>
                            <asp:ListItem>Murder</asp:ListItem>
                            <asp:ListItem>Rape</asp:ListItem>
                            <asp:ListItem>Robbery</asp:ListItem>
                            <asp:ListItem>Theft</asp:ListItem>
                        </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button class="btn btn-success pull-right" ID="Button1" runat="server" Text="Submit!" />
                        </p>
                        <!--<p class="lead">
                            &nbsp;
                        </p>
                        <div id="map"></div>
                        <script>
                            var map;
                            function initMap() {
                                map = new google.maps.Map(document.getElementById('map'), {
                                    center: { lat: 29.7604, lng: -95.3698 },
                                    zoom: 10
                                });
                            }
                            var body = document.body, html = document.documentElement;
                            var height = Math.max(body.scrollHeight, body.offsetHeight, html.clientHeight, html.scrollHeight, html.offsetHeight);
                            document.getElementById('map').style.height = height + 'px';
                        </script>-->
                        
                        <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyA7hJnDLt7rMnypi0vkufSe0paNHRdfwjE&amp;libraries=visualization" type="text/javascript"></script>
                        <div class="map-wrap">
                            <map:GoogleMap ID="GoogleMap1" runat="server" CssClass="map" Latitude="29.7604" Longitude="-95.3698" Zoom="10"
                                Width="100%" Height="600px" FullscreenControl="true">
                            </map:GoogleMap>
                        </div>
                        <map:HeatmapLayer ID="Heatmap1" runat="server" TargetControlID="GoogleMap1">
                        </map:HeatmapLayer>
                        <!--Auto scroll on page submit to the map div-->
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
<!--SOURCES:
https://salesforce.stackexchange.com/questions/83335/google-maps-not-rendering-with-100-height




-->
