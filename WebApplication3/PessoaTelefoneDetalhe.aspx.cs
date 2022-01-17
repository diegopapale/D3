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
    public partial class PessoaTelefoneDetalhe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]); // pega a querystring da pagina
                if (id > 0)
                {
                    PessoaTelefoneModel nome = new PessoaTelefoneRepository().PesquisarPorId(new PessoaTelefoneModel()
                    {
                        Id = id
                    });

                    if (nome != null)
                    {
                        txtTelefonePessoal.Text = Convert.ToString(nome.TelefonePessoal);
                    }
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtTelefonePessoal.Text != "" || txtTelefoneRecado.Text != "" || txtTelefoneResidencial.Text!="")
            {
                PessoaTelefoneModel _dados = new PessoaTelefoneModel();

                _dados.TelefonePessoal = txtTelefonePessoal.Text;
                _dados.TelefoneRecado = txtTelefoneRecado.Text;
                _dados.TelefoneResidencial = txtTelefoneResidencial.Text;
                

                int id = Convert.ToInt32(Request.QueryString["id"]); // pega a querystring da pagina

                _dados.Id = id;

                if (id > 0)
                {
                    new PessoaTelefoneRepository().Atualizar(_dados);
                }
                else
                {
                    new PessoaTelefoneRepository().Incluir(_dados);
                }

                Response.Redirect("~/PessoaTelefone.aspx");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PessoaTelefone.aspx");
        }
    }
}