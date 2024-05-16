<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Header.Master" AutoEventWireup="true" CodeBehind="ManageMakeupPage.aspx.cs" Inherits="MakeMeUpzz.Views.ManageMakeupPage" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Makeup</h1>

    <asp:GridView ID="Makeup" runat="server" AutoGenerateColumns="False" OnRowEditing="Makeup_RowEditing" OnRowDeleting="Makeup_RowDeleting">
        <Columns>
            <asp:BoundField DataField="MakeupID" HeaderText="Makeup ID" SortExpression="MakeupID" />
            <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupWeight" HeaderText="Makeup Weight" SortExpression="MakeupWeight" />
            <asp:BoundField DataField="MakeupPrice" HeaderText="Makeup Price" SortExpression="MakeupPrice" />
            <asp:BoundField DataField="MakeupTypeID" HeaderText="Makeup Type ID" SortExpression="MakeupTypeID" />
            <asp:BoundField DataField="MakeupBrandID" HeaderText="Makeup Brand ID" SortExpression="MakeupBrandID" />
            <asp:CommandField ButtonType="Button" HeaderText="Update" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
            <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>

    <br />
    <h1>Makeup Types</h1>

    <asp:GridView ID="MakeupTypes" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeupTypes_RowDeleting" OnRowEditing="MakeupTypes_RowEditing">
        <Columns>
            <asp:BoundField DataField="MakeupTypeID" HeaderText="Makeup Type ID" SortExpression="MakeupTypeID" />
            <asp:BoundField DataField="MakeupTypeName" HeaderText="Makeup Type Name" SortExpression="MakeupTypeName" />
            <asp:CommandField ButtonType="Button" HeaderText="Update" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
            <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>

    <br />
    <h1>Makeup Brand</h1>

    <asp:GridView ID="MakeupBrands" runat="server" AutoGenerateColumns="False"  OnRowEditing="MakeupBrands_RowEditing" OnRowDeleting="MakeupBrands_RowDeleting">
        <Columns>
            <asp:BoundField DataField="MakeupBrandID" HeaderText="Makeup Brand ID" SortExpression="MakeupBrandID" />
            <asp:BoundField DataField="MakeupBrandName" HeaderText="Makeup Brand Name" SortExpression="MakeupBrandName" />
            <asp:BoundField DataField="MakeupBrandRating" HeaderText="Makeup Brand Rating" SortExpression="MakeupBrandRating" />
            <asp:CommandField ButtonType="Button" HeaderText="Update" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
            <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>

    <br />

    <asp:Button ID="InsertMakeup" runat="server" Text="Insert Makeup" Onclick="InsertMakeup_Click"/>
    <asp:Button ID="InsertMakeupType" runat="server" Text="Insert Makeup Type" Onclick="InsertMakeupType_Click"/>
    <asp:Button ID="InsertMakeupBrand" runat="server" Text="Insert Makeup Brand" onclick="InsertMakeupBrand_Click"/>
</asp:Content>
