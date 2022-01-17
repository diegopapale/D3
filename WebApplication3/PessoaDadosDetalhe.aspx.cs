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
    public partial class PessoaDadosDetalhe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]); // pega a querystring da pagina
                if (id > 0)
                {
                    PessoaDadosModel nome = new PessoaDadosRepository().PesquisarPorId(new PessoaDadosModel()
                    {
                        IdDados = id
                    });

                    if (nome != null)
                    {
                        txtNome.Text = nome.Nome;
                    }
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || txtDataNascimento.Text !="")
            {
                PessoaDadosModel _dados = new PessoaDadosModel();
                _dados.Nome = txtNome.Text;

                _dados.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);


                int id = Convert.ToInt32(Request.QueryString["id"]); // pega a querystring da pagina

                _dados.IdDados = id;

                if (id > 0)
                {
                    new PessoaDadosRepository().Atualizar(_dados);
                }
                else
                {
                    new PessoaDadosRepository().Incluir(_dados);
                }

                Response.Redirect("~/PessoaDados.aspx");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PessoaDados.aspx");
        }
    }
}
    
