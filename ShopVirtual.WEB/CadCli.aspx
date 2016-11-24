<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CadCli.aspx.cs" Inherits="ShopVirtual.WEB.CadCli" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<br />
	<br />
	<div class="container">
		<div class="row">
			<div class="col-xs-12">
				<!-- para colocar os controles de entrada numa linha (formato horizontal) - classe "form-horizontal" -->
				<!-- mas com controle de tamanho através das colunas (grid) -->
				<form id="FormCli" class="form-horizontal" runat="server">
					<div class="form-group">
						<label for="nome" class="col-xs-2 control-label">Nome Completo:</label>
						<div class="col-xs-8">
							<asp:TextBox ID="nome" class="form-control" runat="server"></asp:TextBox>
						</div>
						<div class="col-xs-2">
							<asp:Button ID="Gravar" runat="server" class="btn btn-default btn-primary" Text="Gravar" />
						</div>
					</div>

					<div class="form-group">
						<span class="col-xs-10 col-xs-offset-2">
							<asp:RequiredFieldValidator CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="É necessário informar o nome" ControlToValidate="nome"></asp:RequiredFieldValidator>
						</span>
					</div>

					<div class="form-group">
						<label for="email" class="col-xs-2 control-label">E-Mail:</label>
						<div class="col-xs-8">
							<asp:TextBox ID="email" class="form-control" runat="server"></asp:TextBox>
						</div>
						<div class="col-xs-2">
							<asp:Button ID="Alterar" runat="server" class="btn btn-default btn-primary" Text="Alterar" />
						</div>
					</div>

					<div class="form-group">
						<span class="col-xs-10 col-xs-offset-2">
							<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="dado informado não é um e-mail válido" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
						</span>
					</div>

					<div class="form-group">
						<label for="senha" class="col-xs-2 control-label">Senha:</label>
						<div class="col-xs-4">
							<asp:TextBox ID="senha" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
						</div>
						<div class="col-xs-offset-4 col-xs-2">
							<asp:Button ID="Localizar" runat="server" class="btn btn-default btn-primary" Text="Localizar" />
						</div>
					</div>

					<div class="form-group">
						<label for="confsenha" class="col-xs-2 control-label">Confirmar Senha:</label>
						<div class="col-xs-4">
							<asp:TextBox ID="confsenha" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
						</div>
						<div class="col-xs-offset-4 col-xs-2">
						</div>
					</div>

					<div class="form-group">
						<span class="col-xs-10 col-xs-offset-2">
							<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="As senhas não conferem" ControlToCompare="confsenha" ControlToValidate="senha"></asp:CompareValidator>
						</span>
					</div>

					<div class="form-group">
						<label for="data" class="col-xs-2 control-label">Data Cadastro:</label>
						<div class="col-xs-4">
							<asp:TextBox ID="data" class="form-control" runat="server" TextMode="SingleLine"></asp:TextBox>
						</div>
						<div class="col-xs-offset-4 col-xs-2">
							<asp:Button ID="Excluir" runat="server" class="btn btn-default btn-primary" Text="Excluir" />
						</div>
					</div>
				</form>
			</div>
		</div>
	</div>
	<br />
	<br />
</asp:Content>

