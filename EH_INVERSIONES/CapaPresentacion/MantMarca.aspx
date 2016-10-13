<%@ Page Title="" Language="C#" MasterPageFile="~/HomeCompras.Master" AutoEventWireup="true" CodeBehind="MantMarca.aspx.cs" Inherits="CapaPresentacion.MantMarca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR MARCA</h1>
             <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">CODIGO</label>
                <asp:TextBox ID="txtcod" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">MARCA</label>
                <asp:TextBox ID="txtnombre" runat="server" CssClass="form-control"></asp:TextBox>
           </div>

        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Grabar" OnClick="btngrabar_Click" />
       
         <asp:Button ID="btnactu" runat="server" CssClass="btn btn-success"  Text="Actualizar" OnClick="btnactu_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvmarca" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="codmarca" HeaderText="CODIGO" />
                 <asp:BoundField DataField="nombre" HeaderText="MARCA" />
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>
</asp:Content>
