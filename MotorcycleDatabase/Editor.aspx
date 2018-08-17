<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editor.aspx.cs" Inherits="MotorcycleDatabase.Editor" %>
<%@Register TagPrefix="ctl" TagName="Menu" Src="~/ctlMenu.ascx" %>
<%@Register TagPrefix="ctl" TagName="Field" Src="~/ctlField.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ctl:Menu ID="ctlMenu" runat="server" />
        <div>
            <h1>Motocycle Record Editor</h1>

            <ctl:Field ID="ctlId" runat="server" Label="ID" ReadOnly="true" />
            <ctl:Field ID="ctlManufacturer" runat="server" Label="Manufacturer" />
            <ctl:Field ID="ctlModel" runat="server" Label="Model" />
            <ctl:Field ID="ctlAlias" runat="server" Label="Alias" />
            <ctl:Field ID="ctlCapacity" runat="server" Label="Capacity" />
            <asp:CheckBox ID="chkLearner" runat="server" Text="LAMS Approved" />
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </div>
    </form>
</body>
</html>
