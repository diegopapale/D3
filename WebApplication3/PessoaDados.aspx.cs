using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Model;
using WebApplication3.Repository;

namespace WebApplication3
{
    public partial class PessoaDados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editRecord")
            {
                // Pega o indice da linha
                int index = Convert.ToInt32(e.CommandArgument);

                // Pega as propriedades do campo
                GridViewRow selectedRow = GridView1.Rows[index];
                TableCell campoID = selectedRow.Cells[0];

                // Acessa o valor do campo
                string valorID = campoID.Text;

                Response.Redirect("~/PessoaDadosDetalhe.aspx?id=" + valorID);
                GridView1.DataBind();
            }
            else if (e.CommandName == "deleteRecord")
            {
                // Pega o indice da linha
                int index = Convert.ToInt32(e.CommandArgument);

                // Pega as propriedades do campo
                GridViewRow selectedRow = GridView1.Rows[index];
                TableCell campoID = selectedRow.Cells[0];

                // Acessa o valor do campo
                string valorID = campoID.Text;

                int id = Convert.ToInt32(valorID);

                new PessoaDadosRepository().Delete(new PessoaDadosModel()
                {
                    IdDados = id
                });

                GridView1.DataBind();
            }
        }

        protected void btnAdd_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("~/PessoaDadosDetalhe.aspx");
        }
    }
}
