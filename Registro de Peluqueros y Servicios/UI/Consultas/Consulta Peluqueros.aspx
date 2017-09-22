<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta Peluqueros.aspx.cs" Inherits="Tarea_4.UI.Consultas.Consulta_Peluqueros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!--Inclusion de bootstrap-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../Css/StyleSheet1.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <title>Consulta Peluqueros</title>
</head>
<body>
    <form id="form1" runat="server">

        <header>

            <nav class=" navbar navbar-default">
                <div class="container-fluid">
                    <div class="navbar-header">
                        <a class="navbar-brand" href="#">BarberShop</a>&nbsp
                    </div>
                    <ul class="nav navbar-nav">
                        <li><a href="../Formularios/MenuForm.aspx"><span class="glyphicon glyphicon-home">Inicio &nbsp</span></a></li>
                        <li><a href="../Registros/Registro Peluqueros.aspx"><span class="glyphicon glyphicon-user">Peluqueros &nbsp</span></a></li>
                        <li><a href="../Registros/Registro Servicios.aspx"<span class="glyphicon glyphicon-user">Servicios &nbsp</span></a></li>
                        <li class="active"><a href="../Consultas/Consulta Peluqueros.aspx"><span class="glyphicon glyphicon-search">Consulta Peluqueros &nbsp</span></a></li>
                        <li><a href="../Consultas/Consulta Servicios.aspx"><span class="glyphicon glyphicon-search">Consulta Servicios</span></a></li>

                    </ul>

                </div>
            </nav>
            <h1 class="page-header text-center">Consulta Peluqueros <span class="glyphicon glyphicon-scissors"></span></h1>


        </header>

        <div class="container-fluid">
            <div class="col-lg-12 col-md-6  col-sm-8 col-xs-12">

                <!--comboBox-->
                <div class="text-center">
                    <label for="Busqueda:">Busqueda</label>

                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="110px" Height="22px">
                        <asp:ListItem>Id</asp:ListItem>
                        <asp:ListItem>Nombre</asp:ListItem>
                        <asp:ListItem>Fecha</asp:ListItem>
                        <asp:ListItem>Todos</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp


                    <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox>
                    &nbsp
                      
                    <asp:Button ID="ButtonBuscar" CssClass="boton-buscar" runat="server" Text="Filtrar" OnClick="ButtonBuscar_Click" /> &nbsp
                      
                </div>

                <!--fecha-->
                <div class="text-center">
                    <p>
                        <label for="Desde:">Desde </label>
                        &nbsp;<asp:TextBox ID="desdeFecha" runat="server" Width="120px"></asp:TextBox>
                        <label for="hasta">Hasta</label>
                        <asp:TextBox ID="hastaFecha" runat="server" Width="120px"></asp:TextBox>
                       

                        <a id="Reporte" href="../Reportes/Reporte Peluqueros.aspx" class="boton-buscar" >Imprimir</a>
                       

                    </p>

                </div>

            </div>
        </div>



        <br />
        <br />
        <br />
        <div class="text-center">
            <asp:GridView ID="GridView1" CssClass="text-center" runat="server" CaptionAlign="Bottom" HorizontalAlign="Center">
                <HeaderStyle BackColor="#0066FF" BorderColor="Black" BorderStyle="Double" />
                <PagerStyle BackColor="White" BorderColor="White" BorderStyle="Double" />
                <RowStyle BackColor="White" BorderColor="Black" BorderStyle="Double" Font-Italic="True" ForeColor="Black" />
            </asp:GridView>
        </div>


        <br />
        <br />
        <br />
        <br />
        <footer>

            <p class="page-footer"><span class="glyphicon glyphicon-copyright-mark"></span>Leandro Rafael Duran Minaya[Programacion Aplicada II].amacion Aplicada II].</p>

        </footer>



    </form>
</body>
</html>
