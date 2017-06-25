<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<FormularioDinamico.Models.CampoDinamico>" %>

<%=Html.TextBox(Model.Nome)%>
 
<script type="text/javascript">
    $(document).ready(function () {

        $('#<%=Model.Nome%>').datepicker({
            showOn: "button",
            buttonImage: "Content/images/calendario.png",
            buttonImageOnly: true,
            dateFormat: 'dd-mm-yy',
            changeMonth: true,
            changeYear: true,
            showOtherMonths: true,
            selectOtherMonths: true,
            showButtonPanel: true
        });

    });
</script>