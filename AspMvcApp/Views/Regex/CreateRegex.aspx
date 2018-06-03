<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AspMvcApp.Models.RegexModel>" %>

<asp:Content ID="regexCreationTitle" ContentPlaceHolderID="TitleContent" runat="server">
	Regex creation - MG ASP MVC
</asp:Content>

<asp:Content ID="regexCreationContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Create a New Regex</h2>
    <p>
        Use the form below to create a new regular expression for new password rules.
    </p>

    <% using (Html.BeginForm())
       { %>
        <%: Html.ValidationSummary(true, "Rule creation was unsuccessful. Please correct the errors and try again.") %>
        <div>
            <fieldset>
                <legend>Password rule Information</legend>
                
                <div class="editor-label">
                    <%: Html.CheckBoxFor(m => m.ChMinLength) %>
                    <%: Html.LabelFor(m => m.MinLength) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.MinLength, new { @Value = 0, @type = "number", @class = "span", @min = 0 })%>
                    <%: Html.ValidationMessageFor(m => m.MinLength) %>
                </div>

                <div class="editor-label">
                    <%: Html.CheckBoxFor(m => m.ChMaxLength) %>
                    <%: Html.LabelFor(m => m.MaxLength) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.MaxLength, new { @Value = 1, @type = "number", @class = "span", @min = 1 })%>
                    <%: Html.ValidationMessageFor(m => m.MaxLength)%>
                </div>

                <div class="editor-label">
                    <%: Html.CheckBoxFor(m => m.ChUpperCase) %>
                    <%: Html.LabelFor(m => m.MinUpperCase) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.MinUpperCase, new { @Value = 0, @type = "number", @class = "span", @min = 0 })%>
                    <%: Html.ValidationMessageFor(m => m.MinUpperCase)%>
                </div>

                <div class="editor-label">
                    <%: Html.CheckBoxFor(m => m.ChLowerCase) %>
                    <%: Html.LabelFor(m => m.MinLowerCase) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.MinLowerCase, new { @Value = 0, @type = "number", @class = "span", @min = 0 })%>
                    <%: Html.ValidationMessageFor(m => m.MinLowerCase)%>
                </div>

                <div class="editor-label">
                    <%: Html.CheckBoxFor(m => m.ChSpecialSigns) %>
                    <%: Html.LabelFor(m => m.MinSpecialSigns) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.MinSpecialSigns, new { @Value = 0, @type = "number", @class = "span", @min = 0 })%>
                    <%: Html.ValidationMessageFor(m => m.MinSpecialSigns)%>
                </div>
                
                <div class="editor-label">
                    <%: Html.CheckBoxFor(m => m.ChDigits) %>
                    <%: Html.LabelFor(m => m.MinDigits) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.MinDigits, new { @Value = 0, @type = "number", @class = "span", @min = 0 })%>
                    <%: Html.ValidationMessageFor(m => m.MinDigits)%>
                </div>
                
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Name) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.Name) %>
                    <%: Html.ValidationMessageFor(m => m.Name) %>
                </div>

                <p>
                    <input type="submit" value="Create" />
                </p>
            </fieldset>
        </div>
    <% } %>

</asp:Content>
