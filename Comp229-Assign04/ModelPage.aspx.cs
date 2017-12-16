using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;
using Comp229_Assign04.Models;
using System.Net.Mail;

namespace Comp229_Assign04
{
    public partial class ModelPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Home";


            var filePath = Server.MapPath(".") + @"\Data\Assign04.json";
            var jsonString = File.ReadAllText(filePath);
            if (File.Exists(filePath))
            //if (false)
            {
                var collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
                ModelsShow.DataSource = collection;
                ModelsShow.DataBind();
            }
            else
            {
                ModelsShow.DataSource = jsonString;
                ModelsShow.DataBind();
            }
        }
    }
}