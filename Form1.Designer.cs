namespace ProjetoHistorico2
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)dtg_resultado).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(318, 264);
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
            dtg_resultado.Location = new Point(12, 288);
            dtg_resultado.Name = "dtg_resultado";
            dtg_resultado.RowTemplate.Height = 25;
            dtg_resultado.Size = new Size(776, 150);
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 81);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_pesquisar);
            Controls.Add(dtg_resultado);
            Controls.Add(txb_cod_digitado);
            Controls.Add(lbl_instru_pesquisa);
            Controls.Add(lbl_titulo);
            Name = "Form1";
            Text = "Form1";
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
    }
}