<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<FormularioDinamico.Models.CampoDinamico>" %>

<div>
 
    <% if (!String.IsNullOrEmpty(Model.Prompt))
        Html.RenderPartial("ControlesDinamicos/" + Model.Tipo.Nome, Model);%>
 
</div>