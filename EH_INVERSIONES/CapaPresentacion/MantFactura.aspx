<%@ Page Title="" Language="C#" MasterPageFile="~/HomeCaja.Master" AutoEventWireup="true" CodeBehind="MantFactura.aspx.cs" Inherits="CapaPresentacion.MantFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR FACTURA</h1>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Empleado</label>
                <asp:TextBox ID="txtemp" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
               <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Codigo Empleado</label>
                <asp:TextBox ID="txtcodemp" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
               <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Cliente</label>
              <asp:DropDownList ID="ddlcliente" runat="server" CssClass="form-control"></asp:DropDownList>
                
           </div>
           <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Guardar" OnClick="btngrabar_Click"/>
        
            <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Nro. Factura</label>
                <asp:TextBox ID="txtnrofact" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
               <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Producto</label>
             <asp:DropDownList ID="ddlprod" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlprod_SelectedIndexChanged"  ></asp:DropDownList>
              
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
                <label class="control-label" for="inputSuccess">Cantidad</label>
                <asp:TextBox ID="txtcant" runat="server" CssClass="form-control"></asp:TextBox>
            
            </div>
       
         
    
           <asp:Button ID="btngrabardeta" runat="server" CssClass="btn btn-success"  Text="Agregar" OnClick="btngrabardeta_Click" />
         <br />
       <div class="form-group has-success">
            <label class="control-label" for="inputSuccess">Importe</label>
                <asp:TextBox ID="txtimporte" runat="server" CssClass="form-control" Width="109px"></asp:TextBox>
           <br />
         <asp:Button ID="btnimp" runat="server" CssClass="btn btn-success"  Text="Importar" OnClick="btnimp_Click" />

        <br />
         </div>
        <asp:Button ID="btnpdf" runat="server" CssClass="btn btn-success"  Text="Ver Factura" OnClick="btnpdf_Click" />
         <asp:Button ID="btnnew" runat="server" CssClass="btn btn-success"  Text="Nueva Factura" OnClick="btnnew_Click"/>
           <div class="table-responsive">
             <asp:GridView ID="grvdetatemp" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
                 <Columns>
          
                     <asp:BoundField DataField="nrofactura" HeaderText="Nro Factura" />
                     <asp:BoundField DataField="precioVenta" HeaderText="Precio" />
                     <asp:BoundField DataField="cantVenta" HeaderText="Cantidad" />
                     <asp:BoundField DataField="subtotal" HeaderText="Subtotal" />
                     <asp:BoundField DataField="Igv" HeaderText="IGV" />
                     <asp:BoundField DataField="Total" HeaderText="Total" />
                 
                 </Columns>
       
             </asp:GridView>
        </div>
         <asp:Label ID="Label1" runat="server" Text="Total a Pagar: " style="font-weight: 700; font-size: x-large"></asp:Label>
         <asp:Label ID="lbltotal" runat="server" Text="" style="font-weight: 700; font-size: x-large"></asp:Label>
                   <br />
               <asp:Label ID="Label2" runat="server" Text="Importe Recibido: " style="font-weight: 700; font-size: x-large"></asp:Label>
           <asp:Label ID="lblimporte" runat="server" Text="" style="font-weight: 700; font-size: x-large"></asp:Label>
        <br />
                <asp:Label ID="Label3" runat="server" Text="Vuelto: " style="font-weight: 700; font-size: x-large"></asp:Label>
        <asp:Label ID="lblvuelto" runat="server" Text="" style="font-size: x-large; font-weight: 700"></asp:Label> 
    </div>
        </div>

         </div>
        
    
</asp:Content>
