namespace Buscando_dados_MySql2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvTelaBusca = new System.Windows.Forms.DataGridView();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.Button();
            this.bntFechar = new System.Windows.Forms.Button();
            this.bntBuscarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelaBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelaBusca
            // 
            this.dgvTelaBusca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTelaBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelaBusca.Location = new System.Drawing.Point(35, 46);
            this.dgvTelaBusca.Name = "dgvTelaBusca";
            this.dgvTelaBusca.RowTemplate.Height = 25;
            this.dgvTelaBusca.Size = new System.Drawing.Size(504, 233);
            this.dgvTelaBusca.TabIndex = 0;
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(35, 17);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(403, 23);
            this.txtCampo.TabIndex = 1;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPesquisar.Location = new System.Drawing.Point(444, 12);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(95, 28);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.UseVisualStyleBackColor = false;
            this.txtPesquisar.Click += new System.EventHandler(this.txtPesquisar_Click);
            // 
            // bntFechar
            // 
            this.bntFechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntFechar.Location = new System.Drawing.Point(35, 293);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(118, 34);
            this.bntFechar.TabIndex = 3;
            this.bntFechar.Text = "Fechar";
            this.bntFechar.UseVisualStyleBackColor = false;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            // 
            // bntBuscarTodos
            // 
            this.bntBuscarTodos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntBuscarTodos.Location = new System.Drawing.Point(433, 293);
            this.bntBuscarTodos.Name = "bntBuscarTodos";
            this.bntBuscarTodos.Size = new System.Drawing.Size(106, 34);
            this.bntBuscarTodos.TabIndex = 4;
            this.bntBuscarTodos.Text = "Buscar Todos";
            this.bntBuscarTodos.UseVisualStyleBackColor = false;
            this.bntBuscarTodos.Click += new System.EventHandler(this.bntBuscarTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 339);
            this.Controls.Add(this.bntBuscarTodos);
            this.Controls.Add(this.bntFechar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCampo);
            this.Controls.Add(this.dgvTelaBusca);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Dados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelaBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelaBusca;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Button txtPesquisar;
        private System.Windows.Forms.Button bntFechar;
        private System.Windows.Forms.Button bntBuscarTodos;
    }
}
