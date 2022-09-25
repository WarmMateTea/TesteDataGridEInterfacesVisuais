namespace TesteDataGridEInterfacesVisuais
{
    partial class FormJogar
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
            this.components = new System.ComponentModel.Container();
            this.dgvJogador = new System.Windows.Forms.DataGridView();
            this.dgvOponente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTiro = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtMultiplo = new System.Windows.Forms.TextBox();
            this.lblVitoria = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOponente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJogador
            // 
            this.dgvJogador.AllowUserToAddRows = false;
            this.dgvJogador.AllowUserToDeleteRows = false;
            this.dgvJogador.AllowUserToResizeColumns = false;
            this.dgvJogador.AllowUserToResizeRows = false;
            this.dgvJogador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogador.ColumnHeadersVisible = false;
            this.dgvJogador.Location = new System.Drawing.Point(58, 80);
            this.dgvJogador.MultiSelect = false;
            this.dgvJogador.Name = "dgvJogador";
            this.dgvJogador.ReadOnly = true;
            this.dgvJogador.RowHeadersVisible = false;
            this.dgvJogador.RowHeadersWidth = 32;
            this.dgvJogador.RowTemplate.Height = 32;
            this.dgvJogador.Size = new System.Drawing.Size(536, 448);
            this.dgvJogador.TabIndex = 3;
            // 
            // dgvOponente
            // 
            this.dgvOponente.AllowUserToAddRows = false;
            this.dgvOponente.AllowUserToDeleteRows = false;
            this.dgvOponente.AllowUserToResizeColumns = false;
            this.dgvOponente.AllowUserToResizeRows = false;
            this.dgvOponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOponente.ColumnHeadersVisible = false;
            this.dgvOponente.Location = new System.Drawing.Point(905, 80);
            this.dgvOponente.MultiSelect = false;
            this.dgvOponente.Name = "dgvOponente";
            this.dgvOponente.ReadOnly = true;
            this.dgvOponente.RowHeadersVisible = false;
            this.dgvOponente.RowHeadersWidth = 32;
            this.dgvOponente.RowTemplate.Height = 32;
            this.dgvOponente.Size = new System.Drawing.Size(536, 448);
            this.dgvOponente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tabuleiro do Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1119, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabuleiro do Oponente";
            // 
            // btnTiro
            // 
            this.btnTiro.Location = new System.Drawing.Point(706, 438);
            this.btnTiro.Name = "btnTiro";
            this.btnTiro.Size = new System.Drawing.Size(75, 33);
            this.btnTiro.TabIndex = 7;
            this.btnTiro.Text = "Atirar!";
            this.btnTiro.UseVisualStyleBackColor = true;
            this.btnTiro.Click += new System.EventHandler(this.btnTiro_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Insira um múltiplo:";
            // 
            // txtMultiplo
            // 
            this.txtMultiplo.Location = new System.Drawing.Point(718, 397);
            this.txtMultiplo.Name = "txtMultiplo";
            this.txtMultiplo.ShortcutsEnabled = false;
            this.txtMultiplo.Size = new System.Drawing.Size(53, 22);
            this.txtMultiplo.TabIndex = 10;
            this.txtMultiplo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroColuna_KeyPress);
            // 
            // lblVitoria
            // 
            this.lblVitoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVitoria.Location = new System.Drawing.Point(555, 23);
            this.lblVitoria.Name = "lblVitoria";
            this.lblVitoria.Size = new System.Drawing.Size(381, 42);
            this.lblVitoria.TabIndex = 13;
            this.lblVitoria.Text = "Faça sua jogada!";
            this.lblVitoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(716, 98);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(55, 16);
            this.lblTempo.TabIndex = 14;
            this.lblTempo.Text = "00:00:00";
            // 
            // FormJogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 562);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblVitoria);
            this.Controls.Add(this.txtMultiplo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOponente);
            this.Controls.Add(this.dgvJogador);
            this.Name = "FormJogar";
            this.Text = "FormJogar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJogador;
        private System.Windows.Forms.DataGridView dgvOponente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTiro;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMultiplo;
        private System.Windows.Forms.Label lblVitoria;
        private System.Windows.Forms.Label lblTempo;
    }
}