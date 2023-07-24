using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using TarefaTeste;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoHistorico2
{
    public partial class Programa : Form
    {
        public DataGridViewRow[] RowHeaderMouseDoubleClick { get; private set; }

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

            dtg_resultado.DataSource = null;


            Historico historico = new Historico();
            DataTable resultado = historico.Select(int.Parse(txb_cod_digitado.Text));
            Guid equipamentoide = historico.SelectIde(int.Parse(txb_cod_digitado.Text));
            txb_equipamento_ide.Text = equipamentoide.ToString();

            if (resultado != null && resultado.Rows.Count > 0)
            {
                // Faça aqui o que precisa com o DataTable resultado.
                // Por exemplo, pode mostrar as informações em um DataGridView:
                dtg_resultado.DataSource = resultado;


            }
            else
            {
                // Caso não encontre nenhum resultado, mostre uma mensagem de aviso ao usuário.

                MessageBox.Show("Produto sem historico ou inexistente!");
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


            // Convertendo Date_Time_Picker em DateOnly
            DateTime dataMovimento = dtp_movimento.Value;

            DateTime dataAlteracao = dtp_movimento.Value;


            //Instancia do Historico
            Historico historico = new Historico();


            // Metodo() Pegar Ide
            Guid equipamentoide = historico.SelectIde(int.Parse(txb_cod_digitado.Text));
            txb_equipamento_ide.Text = equipamentoide.ToString();
            int status = 0;


            // Metodo() Insert e o Select Novamente -- após lançar o movimento
            historico.Inserir(Guid.NewGuid(), Guid.Parse(txb_equipamento_ide.Text), txb_funcionario.Text, dataMovimento, dataAlteracao, cmb_setor.Text, status, ckb_devolver.Checked, ckb_devolvido.Checked);
            DataTable resultado = historico.Select(int.Parse(txb_cod_digitado.Text));



            try
            {
                // Re - exebindo a busca após efetivar um movimento
                dtg_resultado.DataSource = resultado;
                MessageBox.Show("Movimento Efetivado!");
            }
            catch (Exception)
            {

                MessageBox.Show("Falha ao efetivar movimento");

            }
            return;




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

        public void dtp_movimento_ValueChanged(object sender, EventArgs e)
        {

        }

        public void dtp_alteracao_ValueChanged(object sender, EventArgs e)
        {

        }

        public void dtg_resultado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int indiceRow = e.RowIndex;


            string msg = String.Format("Row: {0}, Column: {1}",
            dtg_resultado.CurrentRow.Index, indiceRow); 
            //dtg_resultado.CurrentCell.ColumnIndex);
            MessageBox.Show(msg, "Current Cell");



        }

 
    }
}