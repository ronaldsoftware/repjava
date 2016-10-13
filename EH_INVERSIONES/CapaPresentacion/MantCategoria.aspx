<%@ Page Title="" Language="C#" MasterPageFile="~/HomeCompras.Master" AutoEventWireup="true" CodeBehind="MantCategoria.aspx.cs" Inherits="CapaPresentacion.MantCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR CATEGORIA</h1>
             <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">CODIGO</label>
                <asp:TextBox ID="txtcod" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">CATEGORIA</label>
                <asp:TextBox ID="txtdes" runat="server" CssClass="form-control"></asp:TextBox>
           </div>

        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Grabar" OnClick="btngrabar_Click" />
       
         <asp:Button ID="btnactu" runat="server" CssClass="btn btn-success"  Text="Actualizar" OnClick="btnactu_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvcategoria" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="codcat" HeaderText="CODIGO" />
                 <asp:BoundField DataField="descripcion" HeaderText="CATEGORIA" />
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>
</asp:Content>
