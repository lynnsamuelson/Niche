<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NicheTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="NicheForm">
        <button OnClick="FindPatient">Find Patient Data</button>
        <input placeholder="Patient ID" />
        <input placeholder="First Name" />
        <input placeholder="Last Name" />

    </div>

   

    

</asp:Content>
