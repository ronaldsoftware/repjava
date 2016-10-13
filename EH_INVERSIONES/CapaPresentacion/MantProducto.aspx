<%@ Page Title="" Language="C#" MasterPageFile="~/HomeCompras.Master" AutoEventWireup="true" CodeBehind="MantProducto.aspx.cs" Inherits="CapaPresentacion.MantProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR PRODUCTO</h1>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Producto</label>
                <asp:TextBox ID="txtproduc" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Precio</label>
                <asp:TextBox ID="txtprecio" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Stock</label>
                <asp:TextBox ID="txtstock" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Marca</label>
               <asp:DropDownList ID="ddlmarca" runat="server" CssClass="btn btn-success"></asp:DropDownList>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Categoria</label>
                <asp:DropDownList ID="ddlcateg" runat="server" CssClass="btn btn-success"></asp:DropDownList>
           </div>

        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Grabar" OnClick="btngrabar_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvproducto" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
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
