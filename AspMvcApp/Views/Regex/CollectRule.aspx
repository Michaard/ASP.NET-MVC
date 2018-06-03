<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="CollectedRuleTitle" ContentPlaceHolderID="TitleContent" runat="server">
	Collected Rule - MG ASP MVC
</asp:Content>

<asp:Content ID="CollectedRuleContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Collected Rule</h2>
    <p>
        <%: ViewData["Message"] %>
    </p>
    <p> Create another rule</p>
    <% using (Html.BeginForm("CreateRegex", "Regex", FormMethod.Get))
       { %>
        <p>
            <input type="submit" value="Create" />
        </p>
    <% } %>

</asp:Content>
