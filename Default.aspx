<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Parcial2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width: 86%; height: 234px;">
        <tr>
            <td style="width: 452px; height: 178px">Buscar Un Album:
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            </td>
            <td colspan="2" style="height: 178px">
                <br />
                Albúm:&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                Artista:&nbsp;
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;<asp:GridView ID="GridView1" runat="server" Height="210px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="254px">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Artista:"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Tiempo de duración:"></asp:Label>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Guardar" />
            </td>
        </tr>
        <tr>
            <td style="height: 330px; width: 452px">
                <br />
                Album:
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                Artista del Album:
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                Agregar canción Para Lista de canciónes:<br />
                Nombre de la canción:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                Artista:&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                Tiempo de duración:
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Canción" />
                <br />
                <br />
                Fecha de Publicación:&nbsp;&nbsp;
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Guardar Album" />
                <br />
            </td>
            <td colspan="2" style="height: 330px">Buscar artista:
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Buscar" />
                <br />
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 452px">&nbsp;</td>
            <td style="width: 151px">&nbsp;</td>
            <td style="width: 218px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 452px">&nbsp;</td>
            <td style="width: 151px">&nbsp;</td>
            <td style="width: 218px">&nbsp;</td>
        </tr>
    </table>

</asp:Content>
