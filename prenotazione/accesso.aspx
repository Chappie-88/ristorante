<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="accesso.aspx.cs" Inherits="prenotazione.accedi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class ="row">
                            <div class="col">
                               <center>
                                   <h3>Accedi per vedere prenotazioni</h3>
                               </center> 
                            </div>
                        </div>

                        <div class ="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class ="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>Email</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" 
                                        placeholder="Email"></asp:TextBox>
                                </div>
                          
                       
                                <div class="form-group">
                                    <label>Password</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" 
                                        placeholder="Password" TextMode="Password"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text="Accedi" />
                                </div>

                                <div class="form-group">
                                    <a href="registrazione.aspx"><input class="btn btn-info btn-block btn-lg" id="Button2" type="button" value="Registrati" /></a>
                                </div>
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
