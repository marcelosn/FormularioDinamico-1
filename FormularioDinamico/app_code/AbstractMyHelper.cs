using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace FormularioDinamico.app_code
{
    public class AbstractMyHelper : System.Web.WebPages.HelperPage
    {
        public static new HtmlHelper Html
        {
            get
            {
                return ((System.Web.Mvc.WebViewPage) WebPageContext.Current.Page).Html;
            }
        }

        public static new AjaxHelper Ajax
        {
            get
            {
                return ((System.Web.Mvc.WebViewPage)WebPageContext.Current.Page).Ajax;
            }
        }

        public static new UrlHelper Url
        {
            get
            {
                return ((System.Web.Mvc.WebViewPage)WebPageContext.Current.Page).Url;
            }
        }
    }
}