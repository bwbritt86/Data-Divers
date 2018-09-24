<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="HoustonDataVisualizer.SourceCode.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">



<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="icon" type="image/ico" href="../images/mascot.ico" />
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css"/>
    <title>Houston Data Visualizer</title>
</head>



<body>
    <form id="form1" runat="server">


        <div class="container" style="background-color: cornflowerblue">
            <div class="col-md-12">
                <h1 class="text-center" id="toolName">The Houston Data Visualizer
                    <img class="pull-right" src="../Data%20Divers%20Logo.PNG" height="150" width="150" />
                </h1>
                <div id="teamBlock">
                    <h3>Provided by the Data Divers UHCL Team</h3>
                    <small>--Data for Houston, By Houston--</small>
                </div>
            </div>
        </div>

        <div class="col-md-12" id="dropDownBar">
            <div class="container">
                <div class="row">
                    <div class="dropdown col-md-4">
                        <button class="btn btn-secondary dropdown-toggle" type="button" id="yearDropDown" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Select the Year
                        </button>
                        <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                            <a class="dropdown-item" id="y09">2009</a><br />
                            <a class="dropdown-item" id="y10">2010</a><br />
                            <a class="dropdown-item" id="y11">2011</a><br />
                            <a class="dropdown-item" id="y12">2012</a><br />
                            <a class="dropdown-item" id="y13">2013</a><br />
                            <a class="dropdown-item" id="y14">2014</a><br />
                            <a class="dropdown-item" id="y15">2015</a><br />
                            <a class="dropdown-item" id="y16">2016</a><br />
                            <a class="dropdown-item" id="y17">2017</a><br />
                        </div>
                    </div>

                    <div class="dropdown col-md-4">
                        <button class="btn btn-secondary dropdown-toggle" type="button" id="monthDropDown" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Select the Month
                        </button>
                        <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                            <a class="dropdown-item" id="jan">January</a><br />
                            <a class="dropdown-item" id="feb">February</a><br />
                            <a class="dropdown-item" id="mar">March</a><br />
                            <a class="dropdown-item" id="apr">April</a><br />
                            <a class="dropdown-item" id="may">May</a><br />
                            <a class="dropdown-item" id="jun">June</a><br />
                            <a class="dropdown-item" id="jul">July</a><br />
                            <a class="dropdown-item" id="aug">August</a><br />
                            <a class="dropdown-item" id="sep">September</a><br />
                            <a class="dropdown-item" id="oct">October</a><br />
                            <a class="dropdown-item" id="nov">November</a><br />
                            <a class="dropdown-item" id="dec">December</a><br />
                        </div>
                    </div>



                    <div class="dropdown col-md-4">
                        <button class="btn btn-secondary dropdown-toggle" type="button" id="offenseDropDown" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Select the Offense
                        </button>
                        <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                            <a class="dropdown-item" id="agTheft">Aggravated Theft</a><br />
                            <a class="dropdown-item" id="autoTheft">Automobile Theft</a><br />
                            <a class="dropdown-item" id="burg">Burglary</a><br />
                            <a class="dropdown-item" id="murd">Murder</a><br />
                            <a class="dropdown-item" id="rape">Rape</a><br />
                            <a class="dropdown-item" id="robb">Robbery</a><br />
                            <a class="dropdown-item" id="theft">General Theft</a><br />
                        </div>
                    </div>
                </div>
            </div>
        </div>




    </form>
</body>
</html>
