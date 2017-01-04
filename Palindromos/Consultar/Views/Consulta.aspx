<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Consultar.Views.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <div class="col-lg-2"></div>
            <div class="col-lg-8">
                <div class="panel panel-primary">
                    <div class="panel panel-heading">Bienvenido-Palindromos</div>
                    <div class="panel panel-body">
                        <div class="row">
                            <div class="col-lg-8">
                                <input id="File1" type="file" class="form-control" />
                            </div>
                            <div class ="col-lg-4">
                                <asp:LinkButton runat="server" ID="lnkComprobar" CssClass="btn btn-primary" ><span class="glyphicon glyphicon-search"></span>Consultar</asp:LinkButton>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-lg-2"></div>
                            <div class="col-lg-8 well well-lg">
                                <h4><asp:Label runat="server" ID="LblResultado" Text="Resultados"></asp:Label></h4>
                                <h5><asp:Literal runat="server" ID="Resultados"></asp:Literal></h5>
                            </div>
                            <div class="col-lg-2"></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-2"></div>
        </div>
    </form>
</body>
</html>
