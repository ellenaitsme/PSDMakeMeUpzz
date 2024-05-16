using MakeMeUpzz.Controllers;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class InsertMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            MakeupRepository repo = new MakeupRepository();

            String name = NameTB.Text;
            int price = Convert.ToInt32(PriceTB.Text);
            int weight = Convert.ToInt32(WeightTB.Text);
            int typeID = Convert.ToInt32(TypeIDTB.Text);
            int brandID = Convert.ToInt32(BrandIDTB.Text);

            MakeupController controller = new MakeupController();

            if(controller.validate(name, price, weight) && TypeIDTB.Text != null && BrandIDTB.Text != null)
            {
                repo.addMakeup(name, price, weight, typeID, brandID);

                Label.Text = "Data Inserted Successfully";
                Label.Visible = true;
                NameTB.Text = String.Empty;
                PriceTB.Text = String.Empty;
                WeightTB.Text = String.Empty;
                TypeIDTB.Text = String.Empty;
                BrandIDTB.Text = String.Empty;
            }
            else
            {
                Label.Text = "Try again!";
                Label.Visible = true;
            }

            

        }
    }
}