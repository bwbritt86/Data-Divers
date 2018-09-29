<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="HoustonDataVisualizer.SourceCode.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!--https://bootswatch.com/yeti/-->


<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="icon" type="image/ico" href="../images/mascot.ico" />
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
    <title>Houston Data Visualizer</title>
    
</head>



<body>
    <form id="form1" runat="server">
        <hr />

        <div id="bannerForBG" class="container" style="background-color: cornflowerblue">
            <div class="col-md-12">
                <h1 class="text-center" id="toolName" style="color:white;text-shadow: 2px 2px black;">The Houston Data Visualizer
                    <img id="dDLogo" class="pull-right" src="../Data%20Divers%20Logo.PNG" height="150" width="150" />
                </h1>
                <div id="teamBlock">
                    <h3 style="color:white;text-shadow: 2px 2px black;">Provided by the Data Divers UHCL Team</h3>
                    <small  style="color:white;text-shadow: 2px 2px black;">--Data for Houston, By Houston--</small><br /><br /><br /><br />
                </div>
            </div>
        </div>

        <div class="col-md-12" id="dropDownBar">
            <div class="container">
                <div class="row">
                    <div class="dropdown col-md-4">
                    </div>

                    <div class="dropdown col-md-4">
                    </div>



                    <div class="dropdown col-md-4">
                    </div>
                </div>
            </div>
        </div>
        <br />
        <br />

        <div class="container">
            <div class="row">
                <div id="meatOfThePage" class="col-md-12">
                    <div class="jumbotron">
                        <h1 class="display-3">Houston Map</h1>
                        <p class="lead">Here you can see the offenses in Houston by selecting from above and clicking submit!</p>
                        <hr class="my-4" />
                        <p>
                        Year:
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>2009</asp:ListItem>
                            <asp:ListItem>2010</asp:ListItem>
                            <asp:ListItem>2011</asp:ListItem>
                            <asp:ListItem>2012</asp:ListItem>
                            <asp:ListItem>2013</asp:ListItem>
                            <asp:ListItem>2014</asp:ListItem>
                            <asp:ListItem>2015</asp:ListItem>
                            <asp:ListItem>2016</asp:ListItem>
                            <asp:ListItem>2017</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Month:
                        <asp:DropDownList ID="DropDownList2" runat="server">
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
                        Offense Type:
                        <asp:DropDownList ID="DropDownList3" runat="server">
                            <asp:ListItem>Aggravated Theft</asp:ListItem>
                            <asp:ListItem>Automobile Theft</asp:ListItem>
                            <asp:ListItem>Burglary</asp:ListItem>
                            <asp:ListItem>Murder</asp:ListItem>
                            <asp:ListItem>Rape</asp:ListItem>
                            <asp:ListItem>Robbery</asp:ListItem>
                            <asp:ListItem>Theft</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Submit" />
                        </p>
                        <p class="lead">
                            &nbsp;</p>
                    </div>
                </div>
            </div>
        </div>


    </form>
</body>
</html>
