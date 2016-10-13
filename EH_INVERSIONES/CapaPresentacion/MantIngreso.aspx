<%@ Page Title="" Language="C#" MasterPageFile="~/Almacen.Master" AutoEventWireup="true" CodeBehind="MantIngreso.aspx.cs" Inherits="CapaPresentacion.MantIngreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR ENTRADA</h1>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Serie</label>
                <asp:TextBox ID="txtserie" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
                   <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Descripción</label>
                 <asp:DropDownList ID="ddldes" runat="server" CssClass="form-control"></asp:DropDownList>
           </div>
                      <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Proveedor</label>
                 <asp:DropDownList ID="ddlproveedor" runat="server" CssClass="form-control"></asp:DropDownList>
           </div>
        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Grabar" OnClick="btngrabar_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvingreso" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="serie" HeaderText="Serie" />
                 <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                 <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                 <asp:BoundField DataField="nombre" HeaderText="Proveedor" />
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>

</asp:Content>
