<%@ Page Title="Telefones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PessoaTelefone.aspx.cs" Inherits="WebApplication3.PessoaTelefone" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <style type="text/css">
        .Hide { display:none; }
    </style>
    
    <div class="container">
        <div class="jumbotron" style=" padding-top:5px; padding-left:25px; padding-right:25px; padding-bottom:5px;">

            <h2> <strong> <%: Title %> </strong></h2>
            <h3><strong>Lista de Telefones</strong></h3>
            
            <br />

            <div class="row">
                <div class="form-group col-md-12">
                    <button type="button" class="btn btn-primary" runat="server" id="btnAdd"
                        onserverclick="btnAdd_ServerClick">
                        <span class="glyphicon glyphicon-plus"></span> Inserir
                    </button>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-12">

                    <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" AutoGenerateColumns="False" GridLines="None"
                    AllowPaging="True" DataKeyNames="id" CssClass="table table-hover table-striped" DataSourceID="ObjectDataSource1"
                    OnRowCommand="GridView1_RowCommand" EmptyDataText="Não há registros cadastrados." AllowSorting="True">

                    <Columns>

                        <asp:BoundField DataField="id"><HeaderStyle CssClass="Hide" />
                        <ItemStyle CssClass="Hide" /></asp:BoundField>
                                               
                        <asp:BoundField DataField="id" HeaderText="ID">
                            <ItemStyle Width="5%" />
                        </asp:BoundField>

                        <asp:BoundField DataField="telefonePessoal" HeaderText="Telefone Pessoal">
                            <ItemStyle Width="40%" />
                        </asp:BoundField>

                         <asp:BoundField DataField="telefoneRecado" HeaderText="Telefone de Recado">
                            <ItemStyle Width="20%" />
                        </asp:BoundField>

                         <asp:BoundField DataField="telefoneResidencial" HeaderText="Telefone Residencial">
                            <ItemStyle Width="20%" />
                        </asp:BoundField>
                                                 

                         <asp:ButtonField CommandName="editRecord" ControlStyle-CssClass="btn btn-info"
                            Text="<i aria-hidden='true' class='glyphicon glyphicon-edit'></i> Alterar" 
                            ButtonType="Link" HeaderText="" >
                            <ControlStyle CssClass="btn btn-info" />
                            <ItemStyle Width="4%"/>
                        </asp:ButtonField>

                        <asp:ButtonField CommandName="deleteRecord" ControlStyle-CssClass="btn btn-danger"
                            Text="<i aria-hidden='true' class='glyphicon glyphicon-remove'></i> Excluir" 
                            ButtonType="Link" HeaderText="">
                            <ControlStyle CssClass="btn btn-danger"/>
                            <ItemStyle Width="5%" />
                        </asp:ButtonField>
                                               

                    </Columns>
                </asp:GridView>

                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Pesquisar" TypeName="WebApplication3.Repository.PessoaTelefoneRepository">
                </asp:ObjectDataSource>

                </div>
            </div>
        </div>
    </div>

</asp:Content>