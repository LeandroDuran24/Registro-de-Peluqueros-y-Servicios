<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro Peluqueros.aspx.cs" Inherits="Registro_de_Peluqueros_y_Servicios.UI.Formularios.Registro_Peluqueros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

     <!--Inclusion de bootstrap-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../Css/StyleSheet1.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <title>Peluqueros</title>
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
                                <li><a href="Menu Principal.aspx"><span class="glyphicon glyphicon-home">Inicio &nbsp</span></a></li>
                                <li class="active"><a href="Registro Peluqueros.aspx"><span class="glyphicon glyphicon-user">Peluqueros &nbsp</span></a></li>
                                <li><a href="Registro Servicios.aspx"><span class="glyphicon glyphicon-user">Servicios &nbsp</span></a></li>
                                <li><a href="../Consultas/Consulta Peluqueros.aspx"><span class="glyphicon glyphicon-search">Consulta Peluqueros &nbsp</span></a></li>
                                <li><a href="../Consultas/Consulta Servicios.aspx"><span class="glyphicon glyphicon-search">Consulta Servicios</span></a></li> 
                                
                                
                            </ul>
                            
                        </div>
                    </nav>
            <h1 class="page-header text-center">Registro Peluqueros <span class="glyphicon glyphicon-scissors"></span></h1>

        </header>

        <div class="container-fluid">
            <div class="col-lg-12 col-md-6  col-sm-8 col-xs-12">

                <!--input del id-->
                <div class="text-center">
                    <div class="label">
                        <label for="id_peluquero">Id Peluquero</label>
                    </div>
                </div>
                <div class="text-center">

                    <asp:TextBox ID="idTextbox" runat="server" Width="205px" Height="33px"></asp:TextBox>&nbsp
                     <asp:Button ID="Buscar" CssClass="btn btn-primary btn-md boton-buscar" runat="server" Text="Buscar" OnClick="Buscar_Click" ValidationGroup="buscar" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ValidationGroup="buscar" ControlToValidate="idTextbox"></asp:RequiredFieldValidator>
                </div>

                <!--input del nombre-->
                <div class="text-center">
                    <div class="label">
                        <label for="Nombres">Nombre</label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:TextBox ID="NombreTextbox" runat="server" Width="300px" Height="33px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ValidationGroup="guardar" ControlToValidate="NombreTextbox"></asp:RequiredFieldValidator>
                </div>

                 <!--input del telefono-->
                <div class="text-center">
                    <div class="label">
                        <label for="Telefono">Telefono</label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:TextBox ID="TelefonoTextBox" runat="server" Width="300px" Height="33px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ValidationGroup="guardar" ControlToValidate="TelefonoTextBox"></asp:RequiredFieldValidator>
                </div>

                 <!--input del sexo-->
                <div class="text-center">
                    <div class="label">
                        <label for="sexo">Sexo</label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:TextBox ID="SexoTextBox" runat="server" Width="300px" Height="33px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ValidationGroup="guardar" ControlToValidate="SexoTextBox"></asp:RequiredFieldValidator>
                </div>

                 <!--input del fecha-->
                <div class="text-center">
                    <div class="label">
                        <label for="sexo">Fecha</label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:TextBox ID="FechaTextBox1" runat="server" Width="300px" Height="33px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ValidationGroup="guardar" ControlToValidate="FechaTextBox1"></asp:RequiredFieldValidator>
                </div>
               
                
                <br />
                <br />
               


                <!--botones del formulario-->

                <div class="text-center">

                    <asp:Button ID="Nuevo" CssClass="btn btn-primary btn-md boton" runat="server" Text="Nuevo" OnClick="Nuevo_Click" />&nbsp&nbsp
                    <asp:Button ID="guardar" CssClass="btn btn-primary btn-md boton" runat="server" Text="Guardar" OnClick="guardar_Click" ValidationGroup="guardar" />&nbsp;&nbsp&nbsp
                    <asp:Button ID="Eliminar" CssClass="btn btn-primary btn-md boton" runat="server" Text="Eliminar" OnClick="Eliminar_Click" />
                </div>

            </div>
        </div>

        <br />
        <br />
        <br />
      
        <footer>
           
                <p class="page-footer"><span class="glyphicon glyphicon-copyright-mark"></span>Leandro Rafael Duran Minaya[Programacion Aplicada II].</p>

            
        </footer>

    </form>
</body>
</html>
