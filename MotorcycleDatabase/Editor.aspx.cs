using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MotorcycleDatabase
{
    public partial class Editor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack) return;

            var id = Request.QueryString["id"];

            if (string.IsNullOrEmpty(id))
            {
                ctlId.Text = "0";
            }
            else
            {
                var record = MotorcycleManager.SelectOne(id);
                ctlId.Text = record.Id.ToString();
                ctlManufacturer.Text = record.Manufacturer;
                ctlModel.Text = record.Model;
                ctlAlias.Text = record.Alias;
                ctlCapacity.Text = record.Capacity.ToString();
                chkLearner.Checked = record.Learner;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var record = new Motorcycle
            {
                Id = Convert.ToInt64(ctlId.Text),
                Manufacturer = ctlManufacturer.Text,
                Model = ctlModel.Text,
                Alias = ctlAlias.Text,
                Capacity = Convert.ToInt64(ctlCapacity.Text),
                Learner = chkLearner.Checked

            };

            record = MotorcycleManager.Save(record);
            ctlId.Text = record.Id.ToString();
        }
    }
}