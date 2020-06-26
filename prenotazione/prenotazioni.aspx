<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="prenotazioni.aspx.cs" Inherits="prenotazione.prenotazioni" %>
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
                                   <h3>Nuova prenotazione</h3>
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
                                    <label>Seleziona un giorno</label>
                                    <input class="form-control" id="date" type="text" placeholder="dd/MM/yy" title="format : dd/MM/yy"/>

                                </div>
                          
                       
                                <div class="form-group">
                                    <label>Inserisci il numero di persone</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" 
                                        placeholder="Numero di persone"></asp:TextBox>
                                </div>
                                

                                <div class="form-group">
                                    <a href="#"><input class="btn btn-info btn-block btn-lg" id="Button2" type="button" value="Prenota" /></a>
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
