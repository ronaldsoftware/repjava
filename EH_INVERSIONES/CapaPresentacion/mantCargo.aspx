<%@ Page Title="" Language="C#" MasterPageFile="~/HomeRH.Master" AutoEventWireup="true" CodeBehind="mantCargo.aspx.cs" Inherits="CapaPresentacion.mantCargo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="wrapper">   
     <div id="page-wrapper">
    <div class="col-lg-6">
        <h1>REGISTRAR CARGO</h1>
           <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Nombre del Cargo</label>
                <asp:TextBox ID="txtnom" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
            <div class="form-group has-success">
                <label class="control-label" for="inputSuccess">Nombre del Area</label>
               <asp:DropDownList ID="ddlarea" runat="server" CssClass="btn btn-success"></asp:DropDownList>
               
           </div>

        </div>
         <br />
         <asp:Button ID="btngrabar" runat="server" CssClass="btn btn-success"  Text="Grabar" OnClick="btngrabar_Click" />
         <br />
         <div class="table-responsive">
         <asp:GridView ID="grvcargo" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="codcargo" HeaderText="CODIGO" />
                 <asp:BoundField DataField="nombre" HeaderText="CARGO" />
                   <asp:BoundField DataField="narea" HeaderText="AREA" />
             </Columns>
             </asp:GridView>
        </div>
         </div>
        
    </div>
</asp:Content>
