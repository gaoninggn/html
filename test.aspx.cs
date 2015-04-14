using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Html
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var menu = new Html.Model.Menu();
            menu.buttons = new List<Model.button>();

            var subButtons = new List<Model.subButton> 
            {
                new Model.subButton
                { key = "key_sub_1",
                name = "sub1",
                type = Model.buttonType.click
                },
                new Model.subButton
                { key = "key_sub_2",
                name = "sub2",
                type = Model.buttonType.click
                }
            };

            var button = new Model.button
            {
                key = "key_1",
                name = "企业简介",
                type = Model.buttonType.click,
                subButtons = subButtons
            };
            var button2 = new Model.button
            {
                key = "key_2",
                name = "企业简介2",
                type = Model.buttonType.click
            };
            menu.buttons.Add(button);
            menu.buttons.Add(button2);

            var jsonSetting = new Newtonsoft.Json.JsonSerializerSettings
            {
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore
            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(menu, jsonSetting);

            Response.Write(json);
            Response.End();
        }
    }
}