<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Universidades.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Mostrar Datos Ingresados
    </h1>
    <div>
            Mostrar Universidades Ingresadas<br />
            <asp:GridView ID="GridView1" runat="server" Width="398px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server" Width="398px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="ButtonEliminar" runat="server" CssClass="btn btn-success btn-lg" OnClick="ButtonEliminar_Click" Text="Eliminar" />
            <asp:TextBox ID="estmod_txt" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonModificar" runat="server" CssClass="btn btn-success btn-lg" OnClick="ButtonModificar_Click" Text="Modificar" />
        </div>
</asp:Content>
