<%@ Page Title="" Language="C#" MasterPageFile="~/HomeLocal.Master" AutoEventWireup="true" CodeBehind="ListaDetaFactura.aspx.cs" Inherits="CapaPresentacion.ListaDetaFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
               <div class="table-responsive">
             <asp:GridView ID="grvfact" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
                 <Columns>
          
                     <asp:BoundField DataField="nrofactura" HeaderText="Nro Factura" />
                     <asp:BoundField DataField="nombre" HeaderText="Producto" />
                     <asp:BoundField DataField="precioVenta" HeaderText="Precio" />
                     <asp:BoundField DataField="cantVenta" HeaderText="Cantidad" />
                     <asp:BoundField DataField="subtotal" HeaderText="Subtotal" />
                     <asp:BoundField DataField="Igv" HeaderText="IGV" />
                     <asp:BoundField DataField="Total" HeaderText="Total" />
                     
                     <asp:BoundField DataField="Cliente" HeaderText="Cliente" />
                     <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                     <asp:BoundField DataField="ruc" HeaderText="Ruc" />
                 </Columns>
       
             </asp:GridView>
        </div>
        </div>
         </div>
        </div>
    
</asp:Content>
