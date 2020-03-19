<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleQuery.aspx.cs" Inherits="WebAppFSIS.ExercisePages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6">
            <div class="offset-1">
                <asp:Label runat="server" Text="Enter Team ID:"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox id="TeamIDArg" runat="server"></asp:TextBox>&nbsp;&nbsp;
                <asp:Button id="Fetch" runat="server" Text="Fetch" OnClick="Fetch_Click" />
                <br /><br />
                <asp:Label id="MessageLabel" runat="server"></asp:Label>
            </div>
        </div>
        <div class="col-md-6">
            <asp:Label runat="server" Text="Region ID:"></asp:Label>&nbsp;&nbsp;
            <asp:Label id="RegionID" runat="server" ></asp:Label>
            <br />
            <asp:Label runat="server" Text="Description:"></asp:Label>&nbsp;&nbsp;
            <asp:Label id="RegionDescription" runat="server" ></asp:Label>
        </div>
    </div>
</asp:Content>
