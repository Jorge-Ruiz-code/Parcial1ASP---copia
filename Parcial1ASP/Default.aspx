<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Parcial1ASP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <table style="width:100%;">
                <tr>
                    <td style="height: 34px; width: 140px">
                        <asp:DropDownList ID="ddlDepartamento" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td style="height: 34px; width: 150px">
                        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 34px">
                        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" style="margin-left: 192" Text="Guardar" />
                    </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 140px; height: 127px;">
                        <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar Reporte" />
                    </td>
                    <td style="width: 150px; height: 127px;">
                    </td>
                    <td style="height: 127px">
                        <asp:GridView ID="grvReporte" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 140px">
                        <asp:Button ID="btnPromedio" runat="server" Text="Promedio de Lluvias" OnClick="Button3_Click" />
                    </td>
                    <td style="width: 150px" id="lblPromedio">
                        <asp:Label ID="lblPromedio" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                    </td>
                </tr>
            </table>
        </div>
    </div>

</asp:Content>
