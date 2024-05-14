<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Header.Master" AutoEventWireup="true" CodeBehind="ManageMakeupPage.aspx.cs" Inherits="MakeMeUpzz.Views.ManageMakeupPage" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Makeup</h1>

    <asp:GridView ID="Makeup" runat="server" AutoGenerateColumns="False" OnRowEditing="Makeup_RowEditing" OnRowDeleting="Makeup_RowDeleting">
        <Columns>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" />
            <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight" />
            <asp:BoundField DataField="MakeupTypeID" HeaderText="MakeupTypeID" SortExpression="MakeupTypeID" />
            <asp:BoundField DataField="MakeupBrandID" HeaderText="MakeupBrandID" SortExpression="MakeupBrandID" />
            <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice" />
            <asp:CommandField ButtonType="Button" HeaderText="Update" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
            <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>

    <br />
    <h1>Makeup Types</h1>

    <asp:GridView ID="MakeupTypes" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeupTypes_RowDeleting" OnRowEditing="MakeupTypes_RowEditing">
        <Columns>
            <asp:BoundField DataField="MakeupTypeID" HeaderText="MakeupTypeID" SortExpression="MakeupTypeID" />
            <asp:BoundField DataField="MakeupTypes.MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupTypes.MakeupTypeName" />
            <asp:CommandField ButtonType="Button" HeaderText="Update" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
            <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>

    <br />
    <h1>Makeup Brand</h1>

    <asp:GridView ID="MakeupBrands" runat="server" AutoGenerateColumns="False" AllowSorting="true" OnSorting="MakeupBrands_Sorting" OnRowEditing="MakeupBrands_RowEditing" OnRowDeleting="MakeupBrands_RowDeleting">
        <Columns>
            <asp:BoundField DataField="MakeupBrandID" HeaderText="MakeupBrandID" SortExpression="MakeupBrandID" />
            <asp:BoundField DataField="MakeupBrands.MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrands.MakeupBrandName" />
            <asp:BoundField DataField="MakeupBrands.MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="MakeupBrands.MakeupBrandRating" />
            <asp:CommandField ButtonType="Button" HeaderText="Update" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
            <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>

    <asp:Button ID="InsertMakeup" runat="server" Text="Insert Makeup" />
    <asp:Button ID="InsertMakeupType" runat="server" Text="Insert Makeup Type" />
    <asp:Button ID="InsertMakeupBrand" runat="server" Text="Insert Makeup Brand" />
</asp:Content>
