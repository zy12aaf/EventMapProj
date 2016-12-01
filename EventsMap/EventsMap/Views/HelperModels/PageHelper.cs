using System.Text;
using System.Web;
using System.Web.Mvc;
using Domain;
using Domain.HelperModel;

namespace EventsMap.Views.HelperModels
{
    public static class PageHelper
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html,
                                             PagingInformation pagingInfo) {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.GetTotalPages(); i++) {
                TagBuilder tag = new TagBuilder("input");
                tag.MergeAttribute("type", "submit");
                tag.MergeAttribute("value", i.ToString());
                tag.MergeAttribute("name", "pageNumber");
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage) {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }

    }
}