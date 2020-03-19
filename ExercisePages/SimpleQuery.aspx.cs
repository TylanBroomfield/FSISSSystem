using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FSISSSystem.BLL;
using FSISSSystem.ENTITIES;


namespace WebApp.ExercisePages

{
    public partial class SingleRecordQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TeamIDArg.Text))
            {
                MessageLabel.Text = "Enter a region id value.";
            }
            else
            {
                int regionid = 0;
                if (int.TryParse(RegionIDArg.Text, out regionid))
                {
                    if (regionid > 0)
                    {
                        RegionController sysmgr = new RegionController();
                        Region info = null;
                        info = sysmgr.Regions_FindByID(regionid); //BLL controller method
                        if (info == null)
                        {
                            MessageLabel.Text = "Region ID not found.";
                            RegionID.Text = "";
                            RegionDescription.Text = "";
                        }
                        else
                        {
                            RegionID.Text = info.RegionID.ToString();
                            RegionDescription.Text = info.RegionDescription;
                        }
                    }
                    else
                    {
                        MessageLabel.Text = "Region id must be greater than 0";
                    }

                }
                else
                {
                    MessageLabel.Text = "Region id must be a number.";
                }
            }
        }
    }
}