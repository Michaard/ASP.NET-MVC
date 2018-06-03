<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%
    if (Request.IsAuthenticated)
    {
%>
        <p>
            Provide the name for the xml file you want to download.
        </p>
        <% using (Html.BeginForm("Index", "Home"))
       { %>
        <p>
            <input type="text" name="xmlFileName" />.xml
        </p>
        <p>
            <input type="submit" value="Download" />
        </p>
    <% }
    }
%> 
