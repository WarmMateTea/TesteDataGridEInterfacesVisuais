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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTiro = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtMultiplo = new System.Windows.Forms.TextBox();
            this.lblVitoria = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.dgvJogador = new System.Windows.Forms.DataGridView();
            this.dgvOponente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOponente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tabuleiro do Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(839, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabuleiro do Oponente";
            // 
            // btnTiro
            // 
            this.btnTiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnTiro.FlatAppearance.BorderSize = 0;
            this.btnTiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiro.Location = new System.Drawing.Point(535, 356);
            this.btnTiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTiro.Name = "btnTiro";
            this.btnTiro.Size = new System.Drawing.Size(56, 27);
            this.btnTiro.TabIndex = 7;
            this.btnTiro.Text = "Atirar!";
            this.btnTiro.UseVisualStyleBackColor = false;
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
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(520, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Insira um múltiplo:";
            // 
            // txtMultiplo
            // 
            this.txtMultiplo.Location = new System.Drawing.Point(543, 323);
            this.txtMultiplo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMultiplo.Name = "txtMultiplo";
            this.txtMultiplo.ShortcutsEnabled = false;
            this.txtMultiplo.Size = new System.Drawing.Size(41, 20);
            this.txtMultiplo.TabIndex = 10;
            this.txtMultiplo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroColuna_KeyPress);
            // 
            // lblVitoria
            // 
            this.lblVitoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVitoria.Location = new System.Drawing.Point(420, 19);
            this.lblVitoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVitoria.Name = "lblVitoria";
            this.lblVitoria.Size = new System.Drawing.Size(287, 34);
            this.lblVitoria.TabIndex = 13;
            this.lblVitoria.Text = "Faça sua jogada!";
            this.lblVitoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.lblTempo.Location = new System.Drawing.Point(537, 80);
            this.lblTempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(49, 13);
            this.lblTempo.TabIndex = 14;
            this.lblTempo.Text = "00:00:00";
            // 
            // dgvJogador
            // 
            this.dgvJogador.AllowUserToAddRows = false;
            this.dgvJogador.AllowUserToDeleteRows = false;
            this.dgvJogador.AllowUserToResizeColumns = false;
            this.dgvJogador.AllowUserToResizeRows = false;
            this.dgvJogador.ColumnHeadersHeight = 32;
            this.dgvJogador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvJogador.Location = new System.Drawing.Point(50, 65);
            this.dgvJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvJogador.MultiSelect = false;
            this.dgvJogador.Name = "dgvJogador";
            this.dgvJogador.ReadOnly = true;
            this.dgvJogador.RowHeadersWidth = 50;
            this.dgvJogador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJogador.RowTemplate.Height = 32;
            this.dgvJogador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvJogador.Size = new System.Drawing.Size(372, 354);
            this.dgvJogador.TabIndex = 15;
            // 
            // dgvOponente
            // 
            this.dgvOponente.AllowUserToAddRows = false;
            this.dgvOponente.AllowUserToDeleteRows = false;
            this.dgvOponente.AllowUserToResizeColumns = false;
            this.dgvOponente.AllowUserToResizeRows = false;
            this.dgvOponente.ColumnHeadersHeight = 32;
            this.dgvOponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOponente.Location = new System.Drawing.Point(703, 65);
            this.dgvOponente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOponente.MultiSelect = false;
            this.dgvOponente.Name = "dgvOponente";
            this.dgvOponente.ReadOnly = true;
            this.dgvOponente.RowHeadersWidth = 50;
            this.dgvOponente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOponente.RowTemplate.Height = 32;
            this.dgvOponente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOponente.Size = new System.Drawing.Size(372, 354);
            this.dgvOponente.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.panel1.Location = new System.Drawing.Point(443, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 376);
            this.panel1.TabIndex = 17;
            // 
            // FormJogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1138, 457);
            this.Controls.Add(this.dgvOponente);
            this.Controls.Add(this.dgvJogador);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblVitoria);
            this.Controls.Add(this.txtMultiplo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormJogar";
            this.Text = "FormJogar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTiro;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMultiplo;
        private System.Windows.Forms.Label lblVitoria;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.DataGridView dgvJogador;
        private System.Windows.Forms.DataGridView dgvOponente;
        private System.Windows.Forms.Panel panel1;
    }
}