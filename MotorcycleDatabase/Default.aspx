<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MotorcycleDatabase.Default" %>
<%@Register TagPrefix="ctl" TagName="Menu" Src="~/ctlMenu.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>



</head>
<body>
    <form id="form1" runat="server">
        <ctl:Menu ID="ctlMenu" runat="server" /><br />
        <div>
            <asp:GridView ID="gvList" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvList_SelectedIndexChanged">
                <EmptyDataTemplate>
                    <h1>No data to display</h1>
                </EmptyDataTemplate>
                <Columns>
                    <asp:CommandField ShowSelectButton="true" />
                    <asp:BoundField HeaderText="ID" DataField="Id" />
                    <asp:BoundField HeaderText="Manufacturer" DataField="Manufacturer" />
                    <asp:BoundField HeaderText="Model" DataField="Model" />
                    <asp:BoundField HeaderText="Alias/Nickname" DataField="Alias"/>
                    <asp:BoundField HeaderText="Engine Size/Capacity" DataField="Capacity" />
                    <asp:BoundField HeaderText="LAMS Approved" DataField="Learner" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
