<%@ Page Title="" Language="C#" MasterPageFile="~/VentasMaster.Master" AutoEventWireup="true" CodeBehind="FiltroProductos.aspx.cs" Inherits="CapaPresentacion.FiltroProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>CONSULTAR ARTEFACTO</h1>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">NOMBRE</label>
             <asp:DropDownList ID="ddlprod" runat="server" CssClass="form-control"></asp:DropDownList>
                
           </div>
        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Buscar" OnClick="btngrabar_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvfiltro" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                   <asp:BoundField DataField="codproducto" HeaderText="CODIGO" />
                 <asp:BoundField DataField="nombre" HeaderText="PRODUCTO" />
                  <asp:BoundField DataField="precio" HeaderText="PRECIO" />
                  <asp:BoundField DataField="stock" HeaderText="STOCK" />
                 <asp:BoundField DataField="fechaing" HeaderText="FECHA" />
                  <asp:BoundField DataField="marca" HeaderText="MARCA" />
                  <asp:BoundField DataField="descrip" HeaderText="CATEGORIA" />
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>
</asp:Content>
