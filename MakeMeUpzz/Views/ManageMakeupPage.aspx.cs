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
    public partial class ManageMakeupPage : System.Web.UI.Page
    {
        public List<Makeup> makeup = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //ntar ganti ke controller 

            MakeupRepository makeupRepo = new MakeupRepository();
            if (!IsPostBack)
            {
                makeup = makeupRepo.getAllMakeups();
                Makeup.DataSource = makeupRepo;
                Makeup.DataBind();
                MakeupTypes.DataSource = makeupRepo;
                MakeupTypes.DataBind();
                MakeupBrands.DataSource = makeupRepo;
                MakeupBrands.DataBind();
            }
        }

        protected void MakeupBrands_Sorting(object sender, GridViewSortEventArgs e)
        {
            MakeupBrands.Sort(MakeupBrands.Columns[2].ToString(), SortDirection.Descending);
        }

        protected void MakeupBrands_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupBrands.Rows[e.NewEditIndex];
            String id = row.Cells[0].Text;
            Response.Redirect("~/Views/UpdateMakeupBrandPage.aspx?id=" + id);
        }

        protected void MakeupBrands_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MakeupRepository makeupRepo = new MakeupRepository();
            GridViewRow row = MakeupBrands.Rows[e.RowIndex];
            String id = row.Cells[0].Text;
            //makeupRepo.RemoveFoodById(id);

            //makeup = foodRepo.GetFoods();
            //FoodGV.DataSource = foods;
            //FoodGV.DataBind();
        }

        protected void MakeupTypes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void MakeupTypes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupTypes.Rows[e.NewEditIndex];
            String id = row.Cells[0].Text;
            Response.Redirect("~/Views/UpdateMakeupTypePage.aspx?id=" + id);
        }

        protected void Makeup_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = Makeup.Rows[e.NewEditIndex];
            String id = row.Cells[0].Text;
            Response.Redirect("~/Views/UpdateMakeupPage.aspx?id=" + id);
        }

        protected void Makeup_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}