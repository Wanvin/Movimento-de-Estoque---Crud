using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TarefaTeste;

namespace ProjetoHistorico2
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        public void lbl_titulo_Click(object sender, EventArgs e)
        {


        }

        public void lbl_instru_pesquisa_Click(object sender, EventArgs e)
        {


        }

        public void txb_cod_digitado_TextChanged(object sender, EventArgs e)
        {


        }

        public void btn_pesquisar_Click(object sender, EventArgs e)
        {




            Historico historico = new Historico();
            DataTable resultado = historico.Select(int.Parse(txb_cod_digitado.Text));

            if (resultado != null && resultado.Rows.Count > 0)
            {
                // Faça aqui o que precisa com o DataTable resultado.
                // Por exemplo, pode mostrar as informações em um DataGridView:
                dtg_resultado.DataSource = resultado;

            }
            else
            {
                // Caso não encontre nenhum resultado, mostre uma mensagem de aviso ao usuário.
                MessageBox.Show("Produto sem historico!");
            }

        }



        // onde vou chamar a função busca (select)
        //tem que retornar o histórico do equipamento e não o equipamento em sim.
        // where = texto do txb_cod_digitado



        public void dtg_resultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        public void lbl_funcionario_Click(object sender, EventArgs e)
        {

        }

        public void btn_efetivar_movimento_Click(object sender, EventArgs e)
        {



            Historico historico = new Historico();
            historico.Inserir(new Guid(), Guid.Parse(txb_equipamento_ide.Text), txb_funcionario, dtp_movimento , dtp_alteracao , cmb_setor, txb_status, ckb_devolver, ckb_devolvido);

        }

        public void txb_equipamento_ide_TextChanged(object sender, EventArgs e)
        {



        }



        public void txb_funcionario_TextChanged(object sender, EventArgs e)
        {

        }

        public void cmb_setor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void ckb_devolver_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void ckb_devolvido_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void txb_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_movimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_alteracao_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}