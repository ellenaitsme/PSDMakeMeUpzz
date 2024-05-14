using MakeMeUpzz.Handlers;
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
            
            if (!IsPostBack)
            {
                refreshMakeupGV();
                refreshMakeupTypeGV();
                refreshMakeupBrandGV();
            }
        }

        public void refreshMakeupGV()
        {
            MakeupRepository makeupRepo = new MakeupRepository();
            makeup = makeupRepo.getAllMakeups();
            Makeup.DataSource = makeupRepo;
            Makeup.DataBind();
        }

        public void refreshMakeupTypeGV()
        {
            MakeupTypeRepository typeRepo = new MakeupTypeRepository();
            List<MakeupType> makeupTypes = typeRepo.getAllMakeupTypes();
            MakeupTypes.DataSource = typeRepo;
            MakeupTypes.DataBind();
        }

        public void refreshMakeupBrandGV()
        {
            MakeupBrandRepository brandRepo = new MakeupBrandRepository();
            List<MakeupBrand> makeupBrands = brandRepo.GetMakeupBrands();
            MakeupBrands.DataSource = brandRepo;
            MakeupBrands.DataBind();
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
            MakeupBrandHandler brand = new MakeupBrandHandler();
            GridViewRow row = MakeupBrands.Rows[e.RowIndex];
            String id = row.Cells[0].Text;
            brand.DeleteMakeupBrand(id);

            refreshMakeupBrandGV();
        }

        protected void MakeupTypes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MakeupTypeHandler type = new MakeupTypeHandler();
            GridViewRow row = MakeupTypes.Rows[e.RowIndex];
            String id = row.Cells[0].Text;
            type.DeleteMakeupType(id);

            refreshMakeupTypeGV();
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
            MakeupRepository repo = new MakeupRepository();
            GridViewRow row = Makeup.Rows[e.RowIndex];
            String id = row.Cells[0].Text;
            repo.removeMakeup(id);

            refreshMakeupGV();
        }
    }
}