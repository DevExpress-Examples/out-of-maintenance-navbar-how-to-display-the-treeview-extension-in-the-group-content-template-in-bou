<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>

    @Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout})
    @Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout})

</head>
<body>
    <div id="main">
        @RenderBody()
    </div>
</body>
</html>