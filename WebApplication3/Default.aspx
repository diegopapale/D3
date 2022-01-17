<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <div class="row">
            <div class="form-group col-md-1"></div>
            <div class="form-group col-md-6">
                <h1 style="font-family:'BankGothic Md BT'; text-align:center">Cadastro de Cliente</h1>
                <p class="lead" style="font-family:'BankGothic Md BT'; text-align:center">Seus dados de forma Simples & Segura!</p>
            </div>
            <div class="form-group col-md-5">
                <asp:Image runat="server" ImageUrl="~/cadastro.png" />
            </div>
        </div>
    </div>

</asp:Content>