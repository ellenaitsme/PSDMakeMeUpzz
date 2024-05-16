using MakeMeUpzz.Controllers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class UpdateMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MakeupRepository repo = new MakeupRepository();

            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Makeup makeup = repo.getMakeupByID(id);

                NameTB.Text = makeup.MakeupName;
                PriceTB.Text = makeup.MakeupPrice.ToString();
                WeightTB.Text = makeup.MakeupWeight.ToString(); 
                TypeIDTB.Text = makeup.MakeupTypeID.ToString();
                BrandIDTB.Text = makeup.MakeupBrandID.ToString();

            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            MakeupRepository repo = new MakeupRepository();

            int id = Convert.ToInt32(Request.QueryString["id"]);
            String name = NameTB.Text;
            int price = Convert.ToInt32(PriceTB.Text);
            int weight = Convert.ToInt32(WeightTB.Text);
            int typeID = Convert.ToInt32(TypeIDTB.Text);
            int brandID = Convert.ToInt32(BrandIDTB.Text);

            MakeupController controller = new MakeupController();

            Makeup makeup = repo.getMakeupByID(id);

            if (controller.validate(name, price, weight) && TypeIDTB.Text != null && BrandIDTB.Text != null)
            {
                repo.updateMakeup(id, name, price, weight, typeID, brandID);

                Label.Text = "Data Updated Successfully";
                Label.Visible = true;

                NameTB.Text = makeup.MakeupName;
                PriceTB.Text = makeup.MakeupPrice.ToString();
                WeightTB.Text = makeup.MakeupWeight.ToString();
                TypeIDTB.Text = makeup.MakeupTypeID.ToString();
                BrandIDTB.Text = makeup.MakeupBrandID.ToString();
            }
            else
            {
                Label.Text = "Try again!";
                Label.Visible = true;
            }
        }
    }
}