using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaVC.Classes;
using System.Data;

namespace SistemaVC
{
    public partial class ListProveedor : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    CargarGrilla();
                }
                catch (Exception ex)
                {

                    messageBox.ShowMessage(ex.Message);
                }

            }
        }
        private void CargarGrilla()
        {
            DataSet ds = ListProveedor.GetProveedor();
            gridProveedor.DataSource = ds.Tables[0];
            gridProveedor.DataBind();
        }

        protected void gridProveedor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarProveedor")
                {
                    string sProveedorId = e.CommandArgument.ToString();
                    Response.Redirect("EditPRoveedor.aspx?Id=" + sProveedorId);
                }
                else if (e.CommandName == "EliminarProveedor")
                {
                    Proveedor proveedor = new Proveedor();
                    proveedor.P_Id = Convert.ToInt32(e.CommandArgument.ToString());
                    ListProveedor.DeleteProveedor(proveedor);
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                messageBox.ShowMessage(ex.Message + ex.StackTrace);
            }

        }
    }
}