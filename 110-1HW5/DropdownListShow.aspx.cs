using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW5
{
    public partial class DropdownListShow : System.Web.UI.Page
    {
        String[,] sa_Place = new String[2, 3] { { "基隆", "台北", "新北" }, { "苗栗", "台中", "南投" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ListItem o_Li = new ListItem("北區", "北區");
                ddl_Area.Items.Add(o_Li);
                o_Li = new ListItem("中區", "中區");
                ddl_Area.Items.Add(o_Li);

                for (int i = 0; i < 3; i++)
                {
                    if (ddl_Area.SelectedValue == "北區")
                        ddl_Place.Items.Add(sa_Place[0, i]);
                }
            }
        }
        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_Place.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                if (ddl_Area.SelectedValue == "北區")
                {
                    ddl_Place.Items.Add(sa_Place[0, i]);
                }
                else
                {
                    ddl_Place.Items.Add(sa_Place[1, i]);
                }
            }
        }

    }
}