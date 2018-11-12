<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Megatron2000.aspx.cs" Inherits="HoustonDataVisualizer.SourceCode.TSETINHGLLTHETHINGS" %>

<!DOCTYPE html>
<html>
<head>
    <title>Simple Map</title>
    <meta name="viewport" content="initial-scale=1.0">
    <meta charset="utf-8">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <style>
        body {
            background-color: #b5dfe6;
        }

        #biggestTitle {
            color: white;
            text-shadow: 2px 2px #ff0000;
        }

        #bannerForBG {
            background-image: url("../Images/BackgroundBanner.jpg")
        }

        #dDLogo {
            border-radius: 8px;
        }
        /* Always set the map height explicitly to define the size of the div
       * element that contains the map. */
        #map {
            margin: auto;
            height: 70%;
            width: 70%;
            padding: 5%;
        }
        /* Optional: Makes the sample page fill the window. */
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <img id="theRealMAp" class="pull-center" src="../images/RuneScape_Worldmap.png"/>
    </form>
</body>
</html>
