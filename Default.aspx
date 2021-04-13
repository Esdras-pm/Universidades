<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Universidades._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Universidades</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Ingreso de Datos</h2>
            <p>
                Ingrese Universidad:
                <asp:TextBox ID="uni_txt" runat="server"></asp:TextBox>
            </p>
            <h3>Estudiantes</h3>
            <p>
                Ingrese algunos estudiantes:
                <asp:TextBox ID="estudiante_txt" runat="server"></asp:TextBox>
                <asp:Button ID="ALumnoButton" runat="server" CssClass="bg-primary" OnClick="AlumnoButton_Click" Text="Agregar Alumno" />
            </p>
            <p>
                <asp:Button ID="UnisButton" runat="server" CssClass="btn btn-success btn-lg" Text="Agregar Universidad" OnClick="UnisButton_Click"/>               
            </p>
        </div>
    </div>

</asp:Content>
