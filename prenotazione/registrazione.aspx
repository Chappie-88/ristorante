<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registrazione.aspx.cs" Inherits="prenotazione.registrazione" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container"> <%--effetturare verifica: controllare che tutti i campi siano compilati--%>
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class ="row">
                            <div class="col">
                               <center>
                                   <h3>Registrazione utente</h3>
                               </center> 
                            </div>
                        </div>

                        <div class ="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class ="row">
                            <div class="col-md-6">
                              <label>Nome</label>
                                    <asp:TextBox CssClass="form-control" ID="TXTname" runat="server" 
                                        placeholder="Nome"></asp:TextBox>
                            </div>
                        
                            <div class="col-md-6">
                               <label>Cognome</label>
                                    <asp:TextBox CssClass="form-control" ID="TXTsurname" runat="server" 
                                        placeholder="Cognome"></asp:TextBox> 
                            </div>
                        </div>
                        
                        <div class ="row">
                            <div class="col-md-6">
                              <label>Telefono</label>
                                    <asp:TextBox CssClass="form-control" ID="TXTtel" runat="server" 
                                        placeholder="Telefono" TextMode="Phone"></asp:TextBox>
                            </div>
                        
                            <div class="col-md-6">
                               <label>Email</label>
                                    <asp:TextBox CssClass="form-control" ID="TXTmail" runat="server" 
                                        placeholder="Email" TextMode="Email"></asp:TextBox> 
                            </div>
                        </div>

                        <div class ="row">
                            <div class="col">
                                
                                <div class="form-group">
                                    <center>
                                    <label>Password</label>
                                    <asp:TextBox CssClass="form-control" ID="TXTpass" runat="server" 
                                        placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </center>
                                </div>
                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Registrati" OnClick="Button1_Click" />
                                    <asp:Label ID="LBLerrMail" runat="server" Text=""></asp:Label></div>

                                
                            </div>
                        </div>                            
                        <div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
