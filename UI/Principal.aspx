<%@ Page Title="" Language="C#" MasterPageFile="~/ExamenMaster.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="UI.Principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="CSS/Estilos.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="menu-bar">
        <ul>
            <li class ="active"><a href = "Principal.aspx"> Principal</a></li>
            <li><a href="Data.aspx">Ver Usuarios</a></li>
            <li><a href="Form.aspx">Datos y Medidas</a></li>
        </ul>
  </div>

</asp:Content>
