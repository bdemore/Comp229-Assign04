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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Home";

            var filePath = Server.MapPath(".") + @"\Data\Assign04.json";
            if (File.Exists(filePath))
            //if (false)
            {
                var jsonString = File.ReadAllText(filePath);
                var collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
                ModelsShow.DataSource = collection;
                ModelsShow.DataBind();
            }
            else
            {
                //Hold();
            }
        }
        protected void SendEmail(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
            MailMessage message = new MailMessage();
            try
            {
                // These values are probably set by the client.
                message.Subject = "Testing!";
                message.Body = "This is the body of a sample message";

                // These could be static, or dynamic, depending on situation.
                MailAddress toAddress = new MailAddress("cc-comp229f2016@outlook.com", "You");
                MailAddress fromAddress = new MailAddress("cc-comp229f2016@outlook.com", "Comp229");
                message.From = fromAddress;
                message.To.Add(toAddress);
                smtpClient.Host = "smtp-mail.outlook.com";

                // Note that EnableSsl must be true, and we need to turn of default credentials BEFORE adding the new ones
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "password");

                smtpClient.Send(message);
                //statusLabel.Text = "Email sent.";
            }
            catch (Exception ex)
            {
                //statusLabel.Text = "Coudn't send the message!";
            }
        }

        //public void Hold()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var apiPath = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY_ADJUSTED&symbol=MSFT&apikey=demo";
        //        var jsonString = client.GetStringAsync(apiPath).Result;
        //        var stocks = JsonConvert.DeserializeObject<StockReturn>(jsonString);
        //        var stock = stocks.TimeSeriesDaily.FirstOrDefault(tItem => DateTime.Parse(tItem.Key) < DateTime.Now.AddDays(-1));

        //        // Note how this variable has a value: FirstOrDefault
        //        var _default = stocks.TimeSeriesDaily.FirstOrDefault(tItem => DateTime.Parse(tItem.Key) > DateTime.Now);

        //        // But this variable throws an error: First
        //        var fail = stocks.TimeSeriesDaily.First(tItem => DateTime.Parse(tItem.Key) > DateTime.Now);
        //    }
        //}

        public static void Serialize(string basePath, object value)
        {
            var filePath = @"Data\Assign04.json";

                if (File.Exists(filePath))
            {
                try
                {
                    File.WriteAllText(filePath, JsonConvert.SerializeObject(value, Formatting.Indented));
                }
                catch (Exception ex)
                {
                    //TstatusLabel.Text = "Coudn't send the message!";
                }
            }
        }
    }
}
