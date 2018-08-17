using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MotorcycleDatabase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvList.DataSource = MotorcycleManager.SelectAll();
            //need this to generate html for gvList
            gvList.DataBind();
        }

        protected void gvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clicking select will mark a row as selected
            //the cell indices are in the same order as the columns
            // 0 = select, 1 = id, 2 = manufacturer. etc..
            var id = gvList.SelectedRow.Cells[1].Text;

            // we can then use that id in a querystring
            Response.Redirect("Editor.aspx?id=" + id);

        }
    }
}