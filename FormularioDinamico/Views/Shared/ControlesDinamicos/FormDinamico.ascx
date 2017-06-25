<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IList<FormularioDinamico.Models.CampoDinamico>>" %>

<table>
<%
    foreach (FormularioDinamico.Models.CampoDinamico cd in Model)
    {
        %>
        <tr>
            <td><% Html.RenderPartial("ControlesDinamicos/LabelDinamico", cd);%></td>
            <td><% Html.RenderPartial("ControlesDinamicos/CampoDinamico", cd);%></td>
        </tr>
        <%
    }
%>
</table>
