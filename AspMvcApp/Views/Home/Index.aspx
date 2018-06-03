<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    MG ASP MVC
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome to ASP.NET MVC by Michał Graniczka!</h2>
    <p>
        Generate some <%: Html.ActionLink("regular expressions", "CreateRegex", "Regex") %> to create new password rules.
    </p>
    <%
    if (ViewData["Message"]!=null)
    {
    %>
        <p><font color="green"><%: ViewData["Message"].ToString() %></font></p>
    <%
    }
    %>
    <%
    else if (ViewData["Error"]!=null)
    {
    %>
        <p><font color="red"><%: ViewData["Error"].ToString() %></font></p>
    <%
    }
    %>
    <p>
        <% Html.RenderPartial("XmlFunctionality"); %>
    </p>
</asp:Content>
