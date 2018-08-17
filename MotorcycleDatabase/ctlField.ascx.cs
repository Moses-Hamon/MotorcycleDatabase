using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MotorcycleDatabase
{
    public partial class ctlField : System.Web.UI.UserControl
    {
        // public properties added to a user control
        // become changable attributes via markup
        public string Label
        {
            get { return lblLabel.Text; }
            set { lblLabel.Text = value; }
        }

        public string Text
        {
            get { return txtTextBox.Text; }
            set { txtTextBox.Text = value; }
        }

        public bool ReadOnly
        {
            get { return txtTextBox.ReadOnly; }
            set { txtTextBox.ReadOnly = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}