<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OrderTaker.Default" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: lightsteelblue">
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="Label1" runat="server" Text="Commander's Warehouse" meta:resourcekey="Label1Resource1"></asp:Label></h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="CustomerLabel" Text="Customer:" runat="server" meta:resourcekey="CustomerLabelResource1" /></td>
                    <td>
                        <asp:DropDownList ID="CustomerDropDown" runat="server" AutoPostBack="True" meta:resourcekey="customerDropDownResource1">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="RatingLabel" Text="Rating:" runat="server" meta:resourcekey="RatingLabelResource1" />
                    </td>
                    <td>
                        <asp:Label ID="RatingValue" runat="server" meta:resourcekey="RatingValueResource1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="CustomerSinceLabel" Text="Customer Since:" runat="server" meta:resourcekey="CustomerSinceLabelResource1" />
                    </td>
                    <td>
                        <asp:Label ID="CustomerSinceValue" runat="server" meta:resourcekey="CustomerSinceValueResource1" /></td>
                </tr>
            </table>
            <hr />
                        <table>
                <tr>
                    <td>
                        <asp:Label ID="ProductLabel" Text="Product:" runat="server" meta:resourcekey="ProductLabelResource1" /></td>
                    <td>
                        <asp:DropDownList ID="ProductDropDown" runat="server" AutoPostBack="True" meta:resourcekey="ProductDropDownResource1">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="UnitPriceLabel" Text="Unit Price:" runat="server" meta:resourcekey="UnitPriceLabelResource1" />
                    </td>
                    <td>
                        <asp:Label ID="UnitPriceValue" runat="server" meta:resourcekey="UnitPriceValueResource1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="QuantityLabel" Text="Quantity:" runat="server" meta:resourcekey="QuantityLabelResource1"/>
                    </td>
                    <td>
                        <asp:TextBox ID="QuantityValue" runat="server" meta:resourcekey="QuantityValueResource1" /></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
