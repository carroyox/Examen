<%@ Page Title="" Language="C#" MasterPageFile="~/ExamenMaster.Master" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="UI.Data" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-responsive card-body">
    <asp:GridView ID="DGPersonas" runat="server" class="table table-bordered table-hover table-striped">
        <HeaderStyle Cssclass="thead-light"></HeaderStyle>
       <AlternatingRowStyle CssClass="GridRow" />
    </asp:GridView>
</div>

</asp:Content>
