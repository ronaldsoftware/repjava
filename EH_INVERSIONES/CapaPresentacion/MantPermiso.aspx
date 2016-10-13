<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdminSis.Master" AutoEventWireup="true" CodeBehind="MantPermiso.aspx.cs" Inherits="CapaPresentacion.MantPermiso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR PERMISO</h1>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Nombre del Permiso</label>
                <asp:TextBox ID="txtnom" runat="server" CssClass="form-control"></asp:TextBox>
           </div>

        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Grabar" OnClick="btngrabar_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvpermiso" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="codpermi" HeaderText="CODIGO" />
                 <asp:BoundField DataField="nombre" HeaderText="PERMISO" />
                  
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>
</asp:Content>
