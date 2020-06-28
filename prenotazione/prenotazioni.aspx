<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="prenotazioni.aspx.cs" Inherits="prenotazione.prenotazioni" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <!-- Bootstrap DatePicker -->
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/css/bootstrap-datepicker.css" type="text/css"/>
<script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.js" type="text/javascript"></script>
<link href="datepicker/css/datepicker.css" rel="stylesheet" />

<script type="text/javascript" src="js/datepicker.min.js"></script>
<script type="text/javascript" src="js/locales/it.min.js"></script>
<!-- Bootstrap DatePicker -->
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
                                    <asp:TextBox CssClass="form-control it-date-datepicker" id="TXTdate" type="text" placeholder="dd/MM/yy" title="format : dd/MM/yy" runat="server"></asp:TextBox>
                                 
							
                                    <script type="text/javascript">
                                        $(document).ready(function () {
                                            $('.it-date-datepicker').datepicker({
                                                theme: 'bootstrap',
                                                format: 'dd/MM/yy',
                                            });
                                        });
                                        
                                    </script>
                                </div>
                               
                                <div class="form-group">
                                    <label>Inserisci il numero di persone</label>
                                    <asp:TextBox CssClass="form-control" ID="TXTnPrenotati" runat="server" 
                                        placeholder="Numero di persone"></asp:TextBox>
                                </div>
                                

                                <div class="form-group">
                                     <asp:Button class="btn btn-info btn-block btn-lg" ID="BTMprenota" runat="server" Text="Prenota" OnClick="BTMPrenota_Click" />
                                     <asp:Label ID="LBLprenotazione" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                        </div>                            
                        <div>
                                  
                        </div>
                       
                    </div>
                </div>
            </div> <asp:Table ID="TBLBooking" runat="server"></asp:Table>
        </div>
    </div>
    
</asp:Content>
