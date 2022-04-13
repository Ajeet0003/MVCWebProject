using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebProject.Models
{
    public class CustomHelper
    {
        public static IHtmlString Image(string src, string alt ,string width="100")
        {
            return new MvcHtmlString(string.Format($"<img src='{src}' alt='{alt}' />"));

        }
        //public static IHtmlString Button(string type = "submit", string id = "btn1",
        //    string name = "btn1", string value = "Submit")
        //{
        //    return new MvcHtmlString(string.Format($"<input type={type} id={id} name={name} value={value}/>"));
        //}
        public static IHtmlString Button(this HtmlHelper helper, string type = "submit", string id = "btn1",
            string name = "btn1", string value = "Submit")
        {
            return new MvcHtmlString(string.Format($"<input type={type} id={id} name={name} value={value}/>"));
        }
    }
}