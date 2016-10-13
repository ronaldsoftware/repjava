<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdminSis.Master" AutoEventWireup="true" CodeBehind="MantUsuario.aspx.cs" Inherits="CapaPresentacion.MantUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
             <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR USUARIO</h1>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Nombre de Usuario</label><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtnom" ErrorMessage="Ingresar Usuario" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtnom" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
               <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Password</label> <br /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpass" ErrorMessage="Ingresar Password" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="txtpass" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
                   <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Empleado</label>
             <asp:DropDownList ID="ddlempleado" runat="server" CssClass="btn btn-success"></asp:DropDownList>
           </div>
                   <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Permiso</label>
              <asp:DropDownList ID="ddlpermiso" runat="server" CssClass="btn btn-success"></asp:DropDownList>
           </div>

        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Grabar" OnClick="btngrabar_Click"/>
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvusuario" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="Cod_User" HeaderText="CODIGO" />
                 <asp:BoundField DataField="Nom_User" HeaderText="USUARIO" />
                  <asp:BoundField DataField="Pass_User" HeaderText="PASSWORD" />
                 <asp:BoundField DataField="perm" HeaderText="PERMISO" />
                 <asp:BoundField DataField="empleado" HeaderText="EMPLEADO" />
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>
</asp:Content>
