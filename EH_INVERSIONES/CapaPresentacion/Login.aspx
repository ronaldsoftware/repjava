<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
   <link rel="stylesheet" href="css/style.css"/>
       <meta name="viewport" content="width=device-width, initial-scale=1"/>
     
</head>
<body>
    <form id="form1" runat="server">
   <div class="login">
		<div class="login-screen">
			<div class="app-title">
				<h1>Login</h1>
			</div>

			<div class="login-form">
				<div class="control-group">
               <asp:TextBox  ID="txtusu" placeholder="Usuario"  runat="server"></asp:TextBox>
				
				<label class="login-field-icon fui-user" for="login-name"></label>
				</div>

				<div class="control-group">
               <asp:TextBox ID="txtpass" placeholder="Contraseña" runat="server" TextMode="Password"></asp:TextBox>
				
				<label class="login-field-icon fui-lock" for="login-pass"></label>
				</div>
      
                <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                
				  <asp:button cssclass="btn btn-success" id="btnLogin" runat="server" text="Ingresar" OnClick="btnLogin_Click">
                            </asp:button>
                    </div>
				</div>
			</div>
		</div>
	</div>
    </form>
</body>
</html>
