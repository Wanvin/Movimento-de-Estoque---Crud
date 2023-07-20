using System.Data;
using System.Data.SqlClient;
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

            historico.Select(int.Parse(txb_cod_digitado.Text));

        
            // onde vou chamar a função busca (select)
            //tem que retornar o histórico do equipamento e não o equipamento em sim.
            // where = texto do txb_cod_digitado

        }

        public void dtg_resultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_funcionario_Click(object sender, EventArgs e)
        {

        }
    }
}