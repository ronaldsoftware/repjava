<%@ Page Title="" Language="C#" MasterPageFile="~/HomeCompras.Master" AutoEventWireup="true" CodeBehind="MantPrecio.aspx.cs" Inherits="CapaPresentacion.MantPrecio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR PRECIO</h1>
        <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Proveedor</label>
                <asp:DropDownList ID="ddlprov" runat="server" CssClass="form-control"></asp:DropDownList>
           </div>
                <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Producto</label>
                <asp:DropDownList ID="ddlproducto" runat="server" CssClass="form-control"></asp:DropDownList>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Precio</label>
                <asp:TextBox ID="txtprecio" runat="server" CssClass="form-control"></asp:TextBox>
           </div>

        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Grabar" OnClick="btngrabar_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvprecio" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="proveedor" HeaderText="PROVEEDOR" />
                 <asp:BoundField DataField="producto" HeaderText="PRODUCTO" />
                   <asp:BoundField DataField="precio" HeaderText="PRECIO" />
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>
</asp:Content>
