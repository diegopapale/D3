<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PessoaTelefoneDetalhe.aspx.cs" Inherits="WebApplication3.PessoaTelefoneDetalhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="jumbotron" style=" padding-top:5px; padding-left:25px; padding-right:25px; padding-bottom:5px;">

            <h3>Preencha os campos do Telefone:</h3>

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="txtTelefonePessoal">Tel Pessoal</label>
                    &nbsp;<asp:TextBox ID="txtTelefonePessoal" MaxLength="45" TabIndex="1" CssClass="form-control" runat="server" 
                        placeholder="Digite seu tel pessoal..." />
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="txtTelefoneRecado">Tel Recado</label>
                    &nbsp;<asp:TextBox ID="txtTelefoneRecado" MaxLength="10" TabIndex="2" CssClass="form-control" runat="server" 
                        placeholder="Digite seu tel Recado..." />
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="txtTelefoneResidencial">Tel Recado</label>
                    &nbsp;<asp:TextBox ID="txtTelefoneResidencial" MaxLength="10" TabIndex="2" CssClass="form-control" runat="server" 
                        placeholder="Digite seu tel Residencial..." />
                </div>
            </div>

                     

            <div class="row">
                <div class="form-group col-md-12">

                    <asp:LinkButton id="btnSalvar" runat="server" Visible="true" TabIndex="5"
                            CssClass="btn btn-success" CausesValidation="true" OnClick="btnSalvar_Click">
                        <span class="glyphicon glyphicon-floppy-disk"></span> Salvar
                    </asp:LinkButton>
                    &nbsp;

                    <asp:LinkButton id="btnCancelar" runat="server" Visible="true" TabIndex="6"
                            CssClass="btn btn-danger" CausesValidation="true" OnClick="btnCancelar_Click">
                        <span class="glyphicon glyphicon-remove"></span> Cancelar
                    </asp:LinkButton>
                </div>
            </div>
        </div>
    </div>

</asp:Content>