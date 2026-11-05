<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true"
    CodeBehind="UrunTakip.aspx.cs" Inherits="TeknikServis.Web.UrunTakip" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <asp:TextBox ID="TxtSerialNo" runat="server" placeholder="Ürün Seri No:" CssClass="form form-control"></asp:TextBox>
        <br />
        <asp:Button ID="BtnSearchProduct" runat="server" Text="Ara"
            OnClick="BtnSearchProduct_Click" CssClass="btn btn-warning" />

    <br />
    <br />

    <table class="table table-bordered" style="margin-top: 15px;">
        <tr>
            <th>Açıklama</th>
            <th>Tarih</th>
        </tr>
        <asp:Repeater ID="RptProductTrackingResult" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Description") %></td>
                    <td><%# (((DateTime)Eval("Date")).ToString("dd.MMM.yyyy")) %></td>
                </tr>
            </ItemTemplate>


        </asp:Repeater>

    </table>

</asp:Content>
