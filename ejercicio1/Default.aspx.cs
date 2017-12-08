using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Muestra la fecha actual del servidor
        Label2.Text = "La fecha de hoy es:";
        Label3.Text = DateTime.Today.ToString("d");
    }
}