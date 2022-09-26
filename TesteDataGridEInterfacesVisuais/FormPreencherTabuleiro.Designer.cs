namespace TesteDataGridEInterfacesVisuais
{
    partial class FormPreencherTabuleiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreencherTabuleiro));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDestroier = new System.Windows.Forms.Button();
            this.btnEncouracado = new System.Windows.Forms.Button();
            this.btnCruzador = new System.Windows.Forms.Button();
            this.btnPortaAvioes = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbtnSelecionar = new System.Windows.Forms.RadioButton();
            this.rbtnAnonimo = new System.Windows.Forms.RadioButton();
            this.cboxSelecionarUsuario = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeight = 32;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Location = new System.Drawing.Point(20, 22);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 50;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 32;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(372, 354);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            this.dgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(441, 308);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 37);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Limpar Tabuleiro";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "selected.bmp");
            // 
            // btnDestroier
            // 
            this.btnDestroier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnDestroier.FlatAppearance.BorderSize = 0;
            this.btnDestroier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestroier.Location = new System.Drawing.Point(441, 22);
            this.btnDestroier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDestroier.Name = "btnDestroier";
            this.btnDestroier.Size = new System.Drawing.Size(88, 39);
            this.btnDestroier.TabIndex = 4;
            this.btnDestroier.Text = "Destróier";
            this.btnDestroier.UseVisualStyleBackColor = false;
            this.btnDestroier.Click += new System.EventHandler(this.btnDestroier_Click);
            // 
            // btnEncouracado
            // 
            this.btnEncouracado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnEncouracado.FlatAppearance.BorderSize = 0;
            this.btnEncouracado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncouracado.Location = new System.Drawing.Point(441, 66);
            this.btnEncouracado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEncouracado.Name = "btnEncouracado";
            this.btnEncouracado.Size = new System.Drawing.Size(88, 39);
            this.btnEncouracado.TabIndex = 5;
            this.btnEncouracado.Text = "Encouraçado";
            this.btnEncouracado.UseVisualStyleBackColor = false;
            this.btnEncouracado.Click += new System.EventHandler(this.btnEncouracado_Click);
            // 
            // btnCruzador
            // 
            this.btnCruzador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnCruzador.FlatAppearance.BorderSize = 0;
            this.btnCruzador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCruzador.Location = new System.Drawing.Point(441, 110);
            this.btnCruzador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCruzador.Name = "btnCruzador";
            this.btnCruzador.Size = new System.Drawing.Size(88, 39);
            this.btnCruzador.TabIndex = 6;
            this.btnCruzador.Text = "Cruzador";
            this.btnCruzador.UseVisualStyleBackColor = false;
            this.btnCruzador.Click += new System.EventHandler(this.btnCruzador_Click);
            // 
            // btnPortaAvioes
            // 
            this.btnPortaAvioes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnPortaAvioes.FlatAppearance.BorderSize = 0;
            this.btnPortaAvioes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortaAvioes.Location = new System.Drawing.Point(441, 154);
            this.btnPortaAvioes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPortaAvioes.Name = "btnPortaAvioes";
            this.btnPortaAvioes.Size = new System.Drawing.Size(88, 39);
            this.btnPortaAvioes.TabIndex = 7;
            this.btnPortaAvioes.Text = "Porta-aviões";
            this.btnPortaAvioes.UseVisualStyleBackColor = false;
            this.btnPortaAvioes.Click += new System.EventHandler(this.btnPortaAvioes_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(441, 349);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 37);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Jogar!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbtnSelecionar
            // 
            this.rbtnSelecionar.AutoSize = true;
            this.rbtnSelecionar.Location = new System.Drawing.Point(562, 22);
            this.rbtnSelecionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnSelecionar.Name = "rbtnSelecionar";
            this.rbtnSelecionar.Size = new System.Drawing.Size(114, 17);
            this.rbtnSelecionar.TabIndex = 10;
            this.rbtnSelecionar.Text = "Selecionar Usuário";
            this.rbtnSelecionar.UseVisualStyleBackColor = true;
            this.rbtnSelecionar.CheckedChanged += new System.EventHandler(this.rbtnSelecaoUsuario_CheckedChanged);
            // 
            // rbtnAnonimo
            // 
            this.rbtnAnonimo.AutoSize = true;
            this.rbtnAnonimo.Checked = true;
            this.rbtnAnonimo.Location = new System.Drawing.Point(676, 22);
            this.rbtnAnonimo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnAnonimo.Name = "rbtnAnonimo";
            this.rbtnAnonimo.Size = new System.Drawing.Size(105, 17);
            this.rbtnAnonimo.TabIndex = 11;
            this.rbtnAnonimo.TabStop = true;
            this.rbtnAnonimo.Text = "Usuário Anônimo";
            this.rbtnAnonimo.UseVisualStyleBackColor = true;
            this.rbtnAnonimo.CheckedChanged += new System.EventHandler(this.rbtnSelecaoUsuario_CheckedChanged);
            // 
            // cboxSelecionarUsuario
            // 
            this.cboxSelecionarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.cboxSelecionarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSelecionarUsuario.Enabled = false;
            this.cboxSelecionarUsuario.FormattingEnabled = true;
            this.cboxSelecionarUsuario.Location = new System.Drawing.Point(562, 51);
            this.cboxSelecionarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxSelecionarUsuario.Name = "cboxSelecionarUsuario";
            this.cboxSelecionarUsuario.Size = new System.Drawing.Size(213, 21);
            this.cboxSelecionarUsuario.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 400);
            this.panel1.TabIndex = 13;
            // 
            // FormPreencherTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.cboxSelecionarUsuario);
            this.Controls.Add(this.rbtnAnonimo);
            this.Controls.Add(this.rbtnSelecionar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPortaAvioes);
            this.Controls.Add(this.btnCruzador);
            this.Controls.Add(this.btnEncouracado);
            this.Controls.Add(this.btnDestroier);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPreencherTabuleiro";
            this.Text = "Batalha Naval";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDestroier;
        private System.Windows.Forms.Button btnEncouracado;
        private System.Windows.Forms.Button btnCruzador;
        private System.Windows.Forms.Button btnPortaAvioes;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbtnSelecionar;
        private System.Windows.Forms.RadioButton rbtnAnonimo;
        private System.Windows.Forms.ComboBox cboxSelecionarUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}

