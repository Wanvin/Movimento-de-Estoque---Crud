﻿namespace ProjetoHistorico2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa));
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
            lbl_data_movimento = new Label();
            lbl_alter_data = new Label();
            lbl_setor = new Label();
            cmb_setor = new ComboBox();
            lbl_devolver = new Label();
            ckb_devolver = new CheckBox();
            ckb_devolvido = new CheckBox();
            lbl_devolvido = new Label();
            btn_efetivar_movimento = new Button();
            lbl_status = new Label();
            txb_status = new TextBox();
            dtp_movimento = new DateTimePicker();
            dtp_alteracao = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtg_resultado).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            resources.ApplyResources(lbl_titulo, "lbl_titulo");
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Click += lbl_titulo_Click;
            // 
            // lbl_instru_pesquisa
            // 
            resources.ApplyResources(lbl_instru_pesquisa, "lbl_instru_pesquisa");
            lbl_instru_pesquisa.Name = "lbl_instru_pesquisa";
            lbl_instru_pesquisa.Click += lbl_instru_pesquisa_Click;
            // 
            // txb_cod_digitado
            // 
            resources.ApplyResources(txb_cod_digitado, "txb_cod_digitado");
            txb_cod_digitado.Name = "txb_cod_digitado";
            txb_cod_digitado.TextChanged += txb_cod_digitado_TextChanged;
            // 
            // dtg_resultado
            // 
            dtg_resultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dtg_resultado, "dtg_resultado");
            dtg_resultado.Name = "dtg_resultado";
            dtg_resultado.RowTemplate.Height = 25;
            dtg_resultado.CellContentClick += dtg_resultado_CellContentClick;
            dtg_resultado.CellDoubleClick += dtg_resultado_CellContentClick;
            dtg_resultado.CellEndEdit += dtg_resultado_CellContentClick;
            // 
            // btn_pesquisar
            // 
            resources.ApplyResources(btn_pesquisar, "btn_pesquisar");
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            btn_pesquisar.MouseCaptureChanged += txb_cod_digitado_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // lbl_equipamento_ide
            // 
            resources.ApplyResources(lbl_equipamento_ide, "lbl_equipamento_ide");
            lbl_equipamento_ide.Name = "lbl_equipamento_ide";
            // 
            // txb_equipamento_ide
            // 
            resources.ApplyResources(txb_equipamento_ide, "txb_equipamento_ide");
            txb_equipamento_ide.Name = "txb_equipamento_ide";
            txb_equipamento_ide.TextChanged += txb_equipamento_ide_TextChanged;
            // 
            // lbl_funcionario
            // 
            resources.ApplyResources(lbl_funcionario, "lbl_funcionario");
            lbl_funcionario.Name = "lbl_funcionario";
            lbl_funcionario.Click += lbl_funcionario_Click;
            // 
            // txb_funcionario
            // 
            resources.ApplyResources(txb_funcionario, "txb_funcionario");
            txb_funcionario.Name = "txb_funcionario";
            txb_funcionario.TextChanged += txb_funcionario_TextChanged;
            // 
            // lbl_data_movimento
            // 
            resources.ApplyResources(lbl_data_movimento, "lbl_data_movimento");
            lbl_data_movimento.Name = "lbl_data_movimento";
            // 
            // lbl_alter_data
            // 
            resources.ApplyResources(lbl_alter_data, "lbl_alter_data");
            lbl_alter_data.Name = "lbl_alter_data";
            // 
            // lbl_setor
            // 
            resources.ApplyResources(lbl_setor, "lbl_setor");
            lbl_setor.Name = "lbl_setor";
            // 
            // cmb_setor
            // 
            cmb_setor.FormattingEnabled = true;
            resources.ApplyResources(cmb_setor, "cmb_setor");
            cmb_setor.Name = "cmb_setor";
            cmb_setor.SelectedIndexChanged += cmb_setor_SelectedIndexChanged;
            // 
            // lbl_devolver
            // 
            resources.ApplyResources(lbl_devolver, "lbl_devolver");
            lbl_devolver.Name = "lbl_devolver";
            // 
            // ckb_devolver
            // 
            resources.ApplyResources(ckb_devolver, "ckb_devolver");
            ckb_devolver.Name = "ckb_devolver";
            ckb_devolver.UseVisualStyleBackColor = true;
            ckb_devolver.CheckedChanged += ckb_devolver_CheckedChanged;
            // 
            // ckb_devolvido
            // 
            resources.ApplyResources(ckb_devolvido, "ckb_devolvido");
            ckb_devolvido.Name = "ckb_devolvido";
            ckb_devolvido.UseVisualStyleBackColor = true;
            ckb_devolvido.CheckedChanged += ckb_devolvido_CheckedChanged;
            // 
            // lbl_devolvido
            // 
            resources.ApplyResources(lbl_devolvido, "lbl_devolvido");
            lbl_devolvido.Name = "lbl_devolvido";
            // 
            // btn_efetivar_movimento
            // 
            resources.ApplyResources(btn_efetivar_movimento, "btn_efetivar_movimento");
            btn_efetivar_movimento.Name = "btn_efetivar_movimento";
            btn_efetivar_movimento.UseVisualStyleBackColor = true;
            btn_efetivar_movimento.Click += btn_efetivar_movimento_Click;
            // 
            // lbl_status
            // 
            resources.ApplyResources(lbl_status, "lbl_status");
            lbl_status.Name = "lbl_status";
            // 
            // txb_status
            // 
            resources.ApplyResources(txb_status, "txb_status");
            txb_status.Name = "txb_status";
            txb_status.TextChanged += txb_status_TextChanged;
            // 
            // dtp_movimento
            // 
            resources.ApplyResources(dtp_movimento, "dtp_movimento");
            dtp_movimento.Name = "dtp_movimento";
            dtp_movimento.ValueChanged += dtp_movimento_ValueChanged;
            // 
            // dtp_alteracao
            // 
            resources.ApplyResources(dtp_alteracao, "dtp_alteracao");
            dtp_alteracao.Name = "dtp_alteracao";
            dtp_alteracao.ValueChanged += dtp_alteracao_ValueChanged;
            // 
            // Programa
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtp_alteracao);
            Controls.Add(dtp_movimento);
            Controls.Add(txb_status);
            Controls.Add(lbl_status);
            Controls.Add(btn_efetivar_movimento);
            Controls.Add(ckb_devolvido);
            Controls.Add(lbl_devolvido);
            Controls.Add(ckb_devolver);
            Controls.Add(lbl_devolver);
            Controls.Add(cmb_setor);
            Controls.Add(lbl_setor);
            Controls.Add(lbl_alter_data);
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
        private Label lbl_data_movimento;
        private Label lbl_alter_data;
        private Label lbl_setor;
        private ComboBox cmb_setor;
        private Label lbl_devolver;
        private CheckBox ckb_devolver;
        private CheckBox ckb_devolvido;
        private Label lbl_devolvido;
        private Button btn_efetivar_movimento;
        private Label lbl_status;
        private TextBox txb_status;
        private DateTimePicker dtp_movimento;
        private DateTimePicker dtp_alteracao;
    }
}