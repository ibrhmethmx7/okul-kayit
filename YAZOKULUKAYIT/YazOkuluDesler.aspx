<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="YazOkuluDesler.aspx.cs" Inherits="YAZOKULUKAYIT.YazOkuluDesler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat=server>
        <div>
            <asp:Label ID="LbAd" runat="server" Text="Ogrenci Ad" style="font-weight:700"></asp:Label>
            <br /><asp:TextBox ID="TxtAd" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LbSoyad" runat="server" Text="Ogrenci Soyad" style="font-weight:700"></asp:Label>
            <br /><asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
          <div>
              <asp:Label ID="LbNumara" runat="server" Text="Ogrenci Numara" style="font-weight:700"></asp:Label>
             <br /> <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
        
        <div>
            <asp:Label ID="LbSifre" runat="server" Text="Ogrenci Sifre" style="font-weight:700"></asp:Label>
            <br /><asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LbFotograf" runat="server" Text="Ogrenci Fotograf" style="font-weight:700"></asp:Label>
            <br /><asp:TextBox ID="TxtFotograf" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        
       
        <div>
        <asp:Button ID="BtKaydet" runat="server" CssClass="btn btn-info" Text="Kaydet" OnClick="Button1_Click "/>
            </div>
    </form>
</asp:Content>
