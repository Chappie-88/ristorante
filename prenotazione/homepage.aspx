<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="prenotazione.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <div class="container py-5">
    <div class="row">
        <div class="col-lg-10 mx-auto col-12 text-center mb-3">
            <h1 class="mt-0 text-light" id="nostroMenu">Il nostro Menu</h1>
        </div>
        <div class="col-12 mt-4">
            <%--<h3 class="text-center text-light">Antipasti</h3>
            <hr class="accent my-5 bg-light">--%>
            <center><img src="img/antipasti.png" class="img-fluid"/></center>
            <br />
        </div>
        <div class="card-columns">
            <div class="card card-body">
                <span class="float-right font-weight-bold">6 €</span>
                <h6 class="text-truncate">Saganaki Scopelitico</h6>
                <p class="small">Feta fritta con pasta sfoglia con miele e mandorle.</p>
            </div>
            <div class="card card-body">
                <span class="float-right font-weight-bold">6 €</span>
                <h6 class="text-truncate">Spanacotiropita</h6>
                <p class="small">Torta con pastasfoglia, formaggio feta, spinaci.</p>
            </div>
            <div class="card card-body">
                <span class="float-right font-weight-bold">4 €</span>
                <h6 class="text-truncate">Kilokithokeftedes</h6>
                <p class="small">Polpette di zucchine.</p>
            </div>
            <div class="card card-body">
                <span class="float-right font-weight-bold">4 €</span>
                <h6 class="text-truncate">Tirokeftedes</h6>
                <p class="small">Polpette di formaggio.</p>
            </div>
            <div class="card card-body">
                <span class="float-right font-weight-bold">4 €</span>
                <h6 class="text-truncate">Halumi</h6>
                <p class="small">Formaggio di latte di mucca di Cipro.</p>
            </div>
            <div class="card card-body">
                <span class="float-right font-weight-bold">3 €</span>
                <h6 class="text-truncate">Olive greche</h6>
                <p class="small">Olive kalamate.</p>
            </div>
        </div>
        <div class="col-12 mt-4">
            <center><img src="img/piatti.png" class="img-fluid"/></center>
            <br />
            <%--<h3 class="text-center text-light">Piatti</h3>
            <hr class="accent my-5 bg-light">--%>
        </div>
        <div class="card-columns">
            <div class="card card-body">
                <span class="float-right font-weight-bold">12 €</span>
                <h6 class="text-truncate">Gyros Maiale</h6>
                <p class="small">Accompagnato di insalata, patate e pita.</p>
            </div>
            <div class="card card-body">
                <span class="float-right font-weight-bold">12 €</span>
                <h6 class="text-truncate">Gyros Agnello</h6>
                <p class="small">Accompagnato di insalata, patate e pita.</p>
            </div>
            <div class="card card-body">
                <span class="float-right font-weight-bold">10 €</span>
                <h6 class="text-truncate">Moussaka</h6>
                <p class="small">Melanzane, manzo e besciamella al forno.</p>
            </div>
            <div class="card card-body">
                <span class="float-right font-weight-bold">10 €</span>
                <h6 class="text-truncate">Bifteki ripieno con formaggio</h6>
                <p class="small">Carne macinata di manzo e agnello con formaggio.</p>
            </div>
            <div class="card card-body">
               <span class="float-right font-weight-bold">10 €</span>
                <h6 class="text-truncate">Piatto vegetariano</h6>
                <p class="small">Polpette di zucchine, insalata e pita.</p>
            </div>
            <div class="card card-body">
                <span class="float-right font-weight-bold">9 €</span>
                <h6 class="text-truncate">Seftaglia</h6>
                <p class="small">Polpette di maiale speziate.</p>
            </div>
        </div>
        
        <div class="col-12 mt-4">
            <hr class="accent my-5 bg-light">
        </div>
        <div class="col-6 mx-auto">
            <div class="card card-body text-center">
                <h5 class="text-uppercase">Dessert</h5>
                <h6>Dolci della tradizione greca fatti in casa</h6>
                <p class="small">Halva</p>
                <p class="small">Baklavas</p>
                <p class="small">Galactobureco</p>
                <p class="small">Yogurt miele e noci</p>
                <span class="float-right font-weight-bold">4 €</span>
            </div>
        </div>
        
    </div>
</div>
</asp:Content>
