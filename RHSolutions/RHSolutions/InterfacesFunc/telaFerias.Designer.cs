
namespace RHSolutions.Interfaces
{
    partial class telaFerias
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
            this.label1 = new System.Windows.Forms.Label();
            this.buscarCPF = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PesquisarBt = new System.Windows.Forms.Button();
            this.GridFerias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridFerias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o Cpf do funcionário :";
            // 
            // buscarCPF
            // 
            this.buscarCPF.Location = new System.Drawing.Point(184, 98);
            this.buscarCPF.Mask = "000.000.000-00";
            this.buscarCPF.Name = "buscarCPF";
            this.buscarCPF.Size = new System.Drawing.Size(206, 20);
            this.buscarCPF.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(31, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "< Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PesquisarBt
            // 
            this.PesquisarBt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PesquisarBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PesquisarBt.Location = new System.Drawing.Point(419, 94);
            this.PesquisarBt.Name = "PesquisarBt";
            this.PesquisarBt.Size = new System.Drawing.Size(152, 27);
            this.PesquisarBt.TabIndex = 13;
            this.PesquisarBt.Text = "Pesquisar";
            this.PesquisarBt.UseVisualStyleBackColor = false;
            this.PesquisarBt.Click += new System.EventHandler(this.PesquisarBt_Click);
            // 
            // GridFerias
            // 
            this.GridFerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFerias.Location = new System.Drawing.Point(52, 153);
            this.GridFerias.Name = "GridFerias";
            this.GridFerias.Size = new System.Drawing.Size(954, 370);
            this.GridFerias.TabIndex = 14;
            // 
            // telaFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.GridFerias);
            this.Controls.Add(this.PesquisarBt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buscarCPF);
            this.Controls.Add(this.label1);
            this.Name = "telaFerias";
            this.Text = "telaFerias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaFerias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridFerias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox buscarCPF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PesquisarBt;
        private System.Windows.Forms.DataGridView GridFerias;
    }
}