namespace ProjetoHistorico2
{
    partial class Programa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_titulo = new Label();
            lbl_instru_pesquisa = new Label();
            txb_cod_digitado = new TextBox();
            dtg_resultado = new DataGridView();
            btn_pesquisar = new Button();
            label1 = new Label();
            lbl_equipamento_ide = new Label();
            txb_equipamento_ide = new TextBox();
            lbl_funcionario = new Label();
            txb_funcionario = new TextBox();
            txb_mov_data = new TextBox();
            lbl_data_movimento = new Label();
            txb_alter_data = new TextBox();
            lbl_alter_data = new Label();
            lbl_setor = new Label();
            cmb_setor = new ComboBox();
            lbl_devolver = new Label();
            ckb_devolver = new CheckBox();
            ckb_devolvido = new CheckBox();
            lbl_devolvido = new Label();
            btn_efetivar_movimento = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_resultado).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(316, 233);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(153, 21);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Histórico de Produto";
            lbl_titulo.Click += lbl_titulo_Click;
            // 
            // lbl_instru_pesquisa
            // 
            lbl_instru_pesquisa.AutoSize = true;
            lbl_instru_pesquisa.Location = new Point(12, 41);
            lbl_instru_pesquisa.Name = "lbl_instru_pesquisa";
            lbl_instru_pesquisa.Size = new Size(157, 15);
            lbl_instru_pesquisa.TabIndex = 1;
            lbl_instru_pesquisa.Text = "Digite o código do produto: ";
            lbl_instru_pesquisa.Click += lbl_instru_pesquisa_Click;
            // 
            // txb_cod_digitado
            // 
            txb_cod_digitado.Location = new Point(166, 38);
            txb_cod_digitado.Name = "txb_cod_digitado";
            txb_cod_digitado.Size = new Size(100, 23);
            txb_cod_digitado.TabIndex = 2;
            txb_cod_digitado.TextChanged += txb_cod_digitado_TextChanged;
            // 
            // dtg_resultado
            // 
            dtg_resultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_resultado.Location = new Point(12, 257);
            dtg_resultado.Name = "dtg_resultado";
            dtg_resultado.RowTemplate.Height = 25;
            dtg_resultado.Size = new Size(776, 181);
            dtg_resultado.TabIndex = 3;
            dtg_resultado.CellContentClick += dtg_resultado_CellContentClick;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(272, 38);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(75, 23);
            btn_pesquisar.TabIndex = 4;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            btn_pesquisar.MouseCaptureChanged += txb_cod_digitado_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 84);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // lbl_equipamento_ide
            // 
            lbl_equipamento_ide.AutoSize = true;
            lbl_equipamento_ide.Location = new Point(370, 42);
            lbl_equipamento_ide.Name = "lbl_equipamento_ide";
            lbl_equipamento_ide.Size = new Size(100, 15);
            lbl_equipamento_ide.TabIndex = 6;
            lbl_equipamento_ide.Text = "Equipamento Ide:";
            // 
            // txb_equipamento_ide
            // 
            txb_equipamento_ide.Location = new Point(476, 39);
            txb_equipamento_ide.Name = "txb_equipamento_ide";
            txb_equipamento_ide.Size = new Size(312, 23);
            txb_equipamento_ide.TabIndex = 7;
            // 
            // lbl_funcionario
            // 
            lbl_funcionario.AutoSize = true;
            lbl_funcionario.Location = new Point(229, 84);
            lbl_funcionario.Name = "lbl_funcionario";
            lbl_funcionario.Size = new Size(73, 15);
            lbl_funcionario.TabIndex = 8;
            lbl_funcionario.Text = "Funcionário:";
            lbl_funcionario.Click += lbl_funcionario_Click;
            // 
            // txb_funcionario
            // 
            txb_funcionario.Location = new Point(308, 81);
            txb_funcionario.Name = "txb_funcionario";
            txb_funcionario.Size = new Size(195, 23);
            txb_funcionario.TabIndex = 9;
            // 
            // txb_mov_data
            // 
            txb_mov_data.Location = new Point(117, 78);
            txb_mov_data.Name = "txb_mov_data";
            txb_mov_data.Size = new Size(106, 23);
            txb_mov_data.TabIndex = 11;
            // 
            // lbl_data_movimento
            // 
            lbl_data_movimento.AutoSize = true;
            lbl_data_movimento.Location = new Point(12, 84);
            lbl_data_movimento.Name = "lbl_data_movimento";
            lbl_data_movimento.Size = new Size(99, 15);
            lbl_data_movimento.TabIndex = 10;
            lbl_data_movimento.Text = "Movimento Data:";
            lbl_data_movimento.Click += label2_Click;
            // 
            // txb_alter_data
            // 
            txb_alter_data.Location = new Point(105, 113);
            txb_alter_data.Name = "txb_alter_data";
            txb_alter_data.Size = new Size(106, 23);
            txb_alter_data.TabIndex = 13;
            // 
            // lbl_alter_data
            // 
            lbl_alter_data.AutoSize = true;
            lbl_alter_data.Location = new Point(12, 116);
            lbl_alter_data.Name = "lbl_alter_data";
            lbl_alter_data.Size = new Size(87, 15);
            lbl_alter_data.TabIndex = 12;
            lbl_alter_data.Text = "Data Alteracao:";
            // 
            // lbl_setor
            // 
            lbl_setor.AutoSize = true;
            lbl_setor.Location = new Point(509, 84);
            lbl_setor.Name = "lbl_setor";
            lbl_setor.Size = new Size(37, 15);
            lbl_setor.TabIndex = 14;
            lbl_setor.Text = "Setor:";
            // 
            // cmb_setor
            // 
            cmb_setor.FormattingEnabled = true;
            cmb_setor.Location = new Point(552, 81);
            cmb_setor.Name = "cmb_setor";
            cmb_setor.Size = new Size(236, 23);
            cmb_setor.TabIndex = 15;
            // 
            // lbl_devolver
            // 
            lbl_devolver.AutoSize = true;
            lbl_devolver.Location = new Point(229, 116);
            lbl_devolver.Name = "lbl_devolver";
            lbl_devolver.Size = new Size(56, 15);
            lbl_devolver.TabIndex = 16;
            lbl_devolver.Text = "Devolver:";
            // 
            // ckb_devolver
            // 
            ckb_devolver.AutoSize = true;
            ckb_devolver.Location = new Point(287, 116);
            ckb_devolver.Name = "ckb_devolver";
            ckb_devolver.Size = new Size(15, 14);
            ckb_devolver.TabIndex = 17;
            ckb_devolver.UseVisualStyleBackColor = true;
            // 
            // ckb_devolvido
            // 
            ckb_devolvido.AutoSize = true;
            ckb_devolvido.Location = new Point(385, 116);
            ckb_devolvido.Name = "ckb_devolvido";
            ckb_devolvido.Size = new Size(15, 14);
            ckb_devolvido.TabIndex = 19;
            ckb_devolvido.UseVisualStyleBackColor = true;
            // 
            // lbl_devolvido
            // 
            lbl_devolvido.AutoSize = true;
            lbl_devolvido.Location = new Point(316, 116);
            lbl_devolvido.Name = "lbl_devolvido";
            lbl_devolvido.Size = new Size(63, 15);
            lbl_devolvido.TabIndex = 18;
            lbl_devolvido.Text = "Devolvido:";
            // 
            // btn_efetivar_movimento
            // 
            btn_efetivar_movimento.Location = new Point(417, 112);
            btn_efetivar_movimento.Name = "btn_efetivar_movimento";
            btn_efetivar_movimento.Size = new Size(118, 23);
            btn_efetivar_movimento.TabIndex = 20;
            btn_efetivar_movimento.Text = "Efetuar Movimento";
            btn_efetivar_movimento.UseVisualStyleBackColor = true;
            // 
            // Programa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_efetivar_movimento);
            Controls.Add(ckb_devolvido);
            Controls.Add(lbl_devolvido);
            Controls.Add(ckb_devolver);
            Controls.Add(lbl_devolver);
            Controls.Add(cmb_setor);
            Controls.Add(lbl_setor);
            Controls.Add(txb_alter_data);
            Controls.Add(lbl_alter_data);
            Controls.Add(txb_mov_data);
            Controls.Add(lbl_data_movimento);
            Controls.Add(txb_funcionario);
            Controls.Add(lbl_funcionario);
            Controls.Add(txb_equipamento_ide);
            Controls.Add(lbl_equipamento_ide);
            Controls.Add(label1);
            Controls.Add(btn_pesquisar);
            Controls.Add(dtg_resultado);
            Controls.Add(txb_cod_digitado);
            Controls.Add(lbl_instru_pesquisa);
            Controls.Add(lbl_titulo);
            Name = "Programa";
            Text = "Historico de Movimento";
            ((System.ComponentModel.ISupportInitialize)dtg_resultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_instru_pesquisa;
        private TextBox txb_cod_digitado;
        private DataGridView dtg_resultado;
        private Button btn_pesquisar;
        private Label label1;
        private Label lbl_equipamento_ide;
        private TextBox txb_equipamento_ide;
        private Label lbl_funcionario;
        private TextBox txb_funcionario;
        private TextBox txb_mov_data;
        private Label lbl_data_movimento;
        private TextBox txb_alter_data;
        private Label lbl_alter_data;
        private Label lbl_setor;
        private ComboBox cmb_setor;
        private Label lbl_devolver;
        private CheckBox ckb_devolver;
        private CheckBox ckb_devolvido;
        private Label lbl_devolvido;
        private Button btn_efetivar_movimento;
    }
}