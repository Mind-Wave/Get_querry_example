using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnipchenkoHomeWorkGETQuerry
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> parameters = new List<string>();

            if (Request.QueryString.AllKeys.Length == 0)
            {
                ParamsLabel.Text = @"NO PARAGETERS IN GET QUERY:(<br/>For add GET param:<br/>Add after uri <h5>?yourParamete=yourValue<h5/>";
            }
            else
            {
                ParamsLabel.Text = "QUERY PARAMETERS:<br/>";
                foreach (var parameter in Request.QueryString.AllKeys)
                {
                    
                    ParamsLabel.Text += $"{parameter} = {Request.QueryString[parameter]}<br/>";
                }
            }
            
        }
    }
}