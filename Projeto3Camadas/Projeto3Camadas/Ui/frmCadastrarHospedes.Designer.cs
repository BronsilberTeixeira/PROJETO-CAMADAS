
namespace Projeto3Camadas.Ui
{
    partial class frmCadastroHospedes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(33, 45);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(27, 13);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "CPF";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(129, 45);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(39, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "NOME";
            // 
            // txtQuarto
            // 
            this.txtQuarto.Location = new System.Drawing.Point(376, 60);
            this.txtQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(213, 20);
            this.txtQuarto.TabIndex = 9;
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Location = new System.Drawing.Point(373, 45);
            this.lblQuarto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(53, 13);
            this.lblQuarto.TabIndex = 8;
            this.lblQuarto.Text = "QUARTO";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 60);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 11;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(35, 112);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(163, 26);
            this.btn_Cadastrar.TabIndex = 12;
            this.btn_Cadastrar.Text = "CADASTRAR";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(229, 112);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 26);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(425, 112);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(163, 26);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(35, 159);
            this.dgvMedicamentos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.RowHeadersWidth = 62;
            this.dgvMedicamentos.RowTemplate.Height = 28;
            this.dgvMedicamentos.Size = new System.Drawing.Size(553, 151);
            this.dgvMedicamentos.TabIndex = 15;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(12, 61);
            this.txtCpf.Mask = "999.999.999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 16;
            // 
            // frmCadastroHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 330);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtQuarto);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_id);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadastroHospedes";
            this.Text = "Cadastro de Medicamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.MaskedTextBox txtCpf;
    }
}