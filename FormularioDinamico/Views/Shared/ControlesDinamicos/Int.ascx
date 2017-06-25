<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<FormularioDinamico.Models.CampoDinamico>" %>

<%=Html.TextBox(Model.Nome)%>
 
<script type="text/javascript">
    $(document).ready(function () {
        $('#<%=Model.Nome%>').keypress(function (e) {
            if (String.fromCharCode(e.keyCode).match(/[^0-9]/g)) return false;
        });
    });
</script>