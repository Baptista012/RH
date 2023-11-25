
namespace RHSolutions
{
    partial class Form2
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
            this.FuncionalL = new System.Windows.Forms.TextBox();
            this.LoginBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.MaskedTextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.TxtFuncional = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FuncionalL
            // 
            this.FuncionalL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FuncionalL.Location = new System.Drawing.Point(787, 436);
            this.FuncionalL.Name = "FuncionalL";
            this.FuncionalL.Size = new System.Drawing.Size(0, 20);
            this.FuncionalL.TabIndex = 0;
            this.FuncionalL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginBT
            // 
            this.LoginBT.BackColor = System.Drawing.Color.Black;
            this.LoginBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBT.ForeColor = System.Drawing.Color.White;
            this.LoginBT.Location = new System.Drawing.Point(48, 254);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(288, 52);
            this.LoginBT.TabIndex = 5;
            this.LoginBT.Text = "Entrar";
            this.LoginBT.UseVisualStyleBackColor = false;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(45, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Funcional";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(45, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(48, 218);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(293, 20);
            this.TxtSenha.TabIndex = 14;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Lucida Fax", 48F, System.Drawing.FontStyle.Bold);
            this.labelLogin.Location = new System.Drawing.Point(78, 25);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(221, 74);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "Login";
            // 
            // TxtFuncional
            // 
            this.TxtFuncional.Location = new System.Drawing.Point(48, 152);
            this.TxtFuncional.Name = "TxtFuncional";
            this.TxtFuncional.Size = new System.Drawing.Size(294, 20);
            this.TxtFuncional.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.TxtFuncional);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.FuncionalL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FuncionalL;
        private System.Windows.Forms.Button LoginBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtSenha;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox TxtFuncional;
    }
}