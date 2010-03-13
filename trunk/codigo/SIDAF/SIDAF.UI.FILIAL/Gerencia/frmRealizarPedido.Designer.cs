namespace SIDAF.UI.FILIAL.Gerencia
{
    partial class frmRealizarPedido
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
            this.groupBoxPedido = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEsp = new System.Windows.Forms.GroupBox();
            this.btnNovaEsp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.especificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspecificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxPedido.SuspendLayout();
            this.groupBoxEsp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPedido
            // 
            this.groupBoxPedido.Controls.Add(this.cbUF);
            this.groupBoxPedido.Controls.Add(this.label1);
            this.groupBoxPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPedido.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPedido.Name = "groupBoxPedido";
            this.groupBoxPedido.Size = new System.Drawing.Size(373, 77);
            this.groupBoxPedido.TabIndex = 0;
            this.groupBoxPedido.TabStop = false;
            this.groupBoxPedido.Text = "Dados do Pedido ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filial";
            // 
            // groupBoxEsp
            // 
            this.groupBoxEsp.Controls.Add(this.btnNovaEsp);
            this.groupBoxEsp.Controls.Add(this.groupBox1);
            this.groupBoxEsp.Controls.Add(this.dataGridView1);
            this.groupBoxEsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEsp.Location = new System.Drawing.Point(0, 77);
            this.groupBoxEsp.Name = "groupBoxEsp";
            this.groupBoxEsp.Size = new System.Drawing.Size(373, 306);
            this.groupBoxEsp.TabIndex = 1;
            this.groupBoxEsp.TabStop = false;
            this.groupBoxEsp.Text = "Especificações";
            // 
            // btnNovaEsp
            // 
            this.btnNovaEsp.Location = new System.Drawing.Point(284, 225);
            this.btnNovaEsp.Name = "btnNovaEsp";
            this.btnNovaEsp.Size = new System.Drawing.Size(75, 23);
            this.btnNovaEsp.TabIndex = 2;
            this.btnNovaEsp.Text = "Novo";
            this.btnNovaEsp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(190, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(281, 16);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(15, 32);
            this.cbUF.Name = "comboBox1";
            this.cbUF.Size = new System.Drawing.Size(344, 21);
            this.cbUF.TabIndex = 1;
            // 
            // especificacao
            // 
            this.especificacao.HeaderText = "Especificação";
            this.especificacao.Name = "especificacao";
            this.especificacao.ReadOnly = true;
            // 
            // idEspecificacao
            // 
            this.idEspecificacao.HeaderText = "Id";
            this.idEspecificacao.Name = "idEspecificacao";
            this.idEspecificacao.ReadOnly = true;
            this.idEspecificacao.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEspecificacao,
            this.especificacao});
            this.dataGridView1.Location = new System.Drawing.Point(15, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmRealizarPedido
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(373, 383);
            this.Controls.Add(this.groupBoxEsp);
            this.Controls.Add(this.groupBoxPedido);
            this.Name = "frmRealizarPedido";
            this.Text = "Realizar Pedido";
            this.groupBoxPedido.ResumeLayout(false);
            this.groupBoxPedido.PerformLayout();
            this.groupBoxEsp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEsp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnNovaEsp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn especificacao;
    }
}