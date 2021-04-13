<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Universidades.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Mostrar Datos Ingresados
    </h1>
    <div>
            Mostrar Universidades Ingresadas<br />
            <asp:GridView ID="GridView1" runat="server" Width="398px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server" Width="398px">
            </asp:GridView>
            <asp:Button ID="ButtonCargar" runat="server" CssClass="btn btn-success btn-lg" OnClick="ButtonCargar_Click" Text="Cargar Datos" />
        </div>
</asp:Content>
