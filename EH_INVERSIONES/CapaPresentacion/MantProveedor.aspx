<%@ Page Title="" Language="C#" MasterPageFile="~/HomeCompras.Master" AutoEventWireup="true" CodeBehind="MantProveedor.aspx.cs" Inherits="CapaPresentacion.MantProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR PROVEEDOR</h1>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Nombre</label>
                <asp:TextBox ID="txtnom" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Ruc</label>
                <asp:TextBox ID="txtruc" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Dirección</label>
                <asp:TextBox ID="txtdir" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Correo</label>
                <asp:TextBox ID="txtcorr" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Telefono</label>
                <asp:TextBox ID="txttel" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Celular</label>
                <asp:TextBox ID="txtcel" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Grabar" OnClick="btngrabar_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvproveedor" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="codprove" HeaderText="CODIGO" />
                 <asp:BoundField DataField="nombre" HeaderText="PROVEEDOR" />
                  <asp:BoundField DataField="ruc" HeaderText="RUC" />
                 <asp:BoundField DataField="direccion" HeaderText="DIRECCION" />
                  <asp:BoundField DataField="correo" HeaderText="CORREO" />
                  <asp:BoundField DataField="telefono" HeaderText="TELEFONO" />
                 <asp:BoundField DataField="celular" HeaderText="CELULAR" />
                 <asp:BoundField DataField="fechareg" HeaderText="FECHA DE REGISTRO" />
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>
</asp:Content>
