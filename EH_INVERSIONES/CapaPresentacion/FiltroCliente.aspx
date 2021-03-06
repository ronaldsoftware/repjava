﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HomeCaja.Master" AutoEventWireup="true" CodeBehind="FiltroCliente.aspx.cs" Inherits="CapaPresentacion.FiltroCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>BUSCAR CLIENTE</h1>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">DNI</label>
                <asp:TextBox ID="txtdni" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Buscar" OnClick="btngrabar_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvcliente" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="codclient" HeaderText="CODIGO" />
                 <asp:BoundField DataField="nombre" HeaderText="NOMBRE" />
                  <asp:BoundField DataField="apellido" HeaderText="APELLIDO" />
                 <asp:BoundField DataField="dni" HeaderText="DNI" />
                  <asp:BoundField DataField="telefono" HeaderText="TELEFONO" />
                  <asp:BoundField DataField="celular" HeaderText="CELULAR" />
                 <asp:BoundField DataField="direccion" HeaderText="DIRECCIÓN" />
                  <asp:BoundField DataField="correo" HeaderText="CORREO" />
                 <asp:BoundField DataField="fechareg" HeaderText="FECHA DE REGISTRO" />
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>
</asp:Content>
