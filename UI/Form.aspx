<%@ Page Title="" Language="C#" MasterPageFile="~/ExamenMaster.Master" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="UI.Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

  </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Container">
        <div class="form-top">
            <h2>Recoleccion Datos</h2>
        </div>
        <div class="form-reg">

           
            <asp:TextBox ID="TbNombre" class="input" type="text" placeholder="Nombre" required="true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbDate" class="input" type="date" placeholder="Fecha" required="true" runat="server"></asp:TextBox>
            <h4>Mediciones Antropométricas</h4>
            <asp:TextBox ID="TbEdad" class="input" type="number" placeholder="Edad" min="1" required="true" runat="server"></asp:TextBox>
            <asp:DropDownList ID="TbGen" class="input" placeholder="Genero" required="true" runat="server" AppendDataBoundItems="true">
                <asp:ListItem Text="Seleccione Genero" Value="" disabled Selected></asp:ListItem>
                <asp:ListItem Value="M">Masculino</asp:ListItem>
                <asp:ListItem Value="F">Femenino</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TbPeso" class="input" type="number" placeholder="Peso (Kg)" min="0.1" required=" true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbTalla" class="input" type="number" placeholder="Estatura(mts)" required=" true" runat="server" min="0" max="3" step="0.01"></asp:TextBox>
            <h4>Pliegues Cutáneos </h4>
            <asp:TextBox ID="TbTriceps" class="input" type="number" min="0" max="80" step="0.1" placeholder="Triceps (mm)" required="true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbBiceps" class="input" type="number" min="0" max="80" step="0.1" placeholder="Biceps (mm)" required="true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbPecho" class="input" type="number" min="0" max="80" step="0.1" placeholder="Pecho (mm)" required="true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbAxila" class="input" type="number" min="0" max="80" step="0.1" placeholder="Axila (mm)" required="true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbSubescapular" class="input" type="number" min="0" max="80" step="0.1" placeholder="Subescapular (mm)" required="true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbSuprailiaco" class="input" type="number" min="0" max="80" step="0.1" placeholder="Suprailiaco (mm)" required="true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbAbdomen" class="input" type="number" min="0" max="80" step="0.1" placeholder="Abdomen (mm)" required="true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbMuslo" class="input" type="number" min="0" max="80" step="0.1" placeholder="Muslo (mm)" required="true" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbPantorrilla" class="input" type="number" min="0" max="80" step="0.1" placeholder="Pantorrilla (mm)" required="true" runat="server"></asp:TextBox>

            <div class="btn-form">
                <asp:Button ID="Submit" runat="server" Text="Guardar" class="btn-submit" OnClick="Submit_Click" />

                <asp:Button ID="Reset" runat="server" Text="Limpiar" class="btn-reset" />

                       </div>
        </div>
    </div>

</asp:Content>
