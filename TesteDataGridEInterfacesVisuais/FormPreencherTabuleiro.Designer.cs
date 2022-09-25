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
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Location = new System.Drawing.Point(86, 80);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 32;
            this.dgv.RowTemplate.Height = 32;
            this.dgv.Size = new System.Drawing.Size(536, 448);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            this.dgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(712, 432);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Limpar Tabuleiro";
            this.btnReset.UseVisualStyleBackColor = true;
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
            this.btnDestroier.Location = new System.Drawing.Point(712, 80);
            this.btnDestroier.Name = "btnDestroier";
            this.btnDestroier.Size = new System.Drawing.Size(117, 48);
            this.btnDestroier.TabIndex = 4;
            this.btnDestroier.Text = "Destróier";
            this.btnDestroier.UseVisualStyleBackColor = true;
            this.btnDestroier.Click += new System.EventHandler(this.btnDestroier_Click);
            // 
            // btnEncouracado
            // 
            this.btnEncouracado.Location = new System.Drawing.Point(712, 134);
            this.btnEncouracado.Name = "btnEncouracado";
            this.btnEncouracado.Size = new System.Drawing.Size(117, 48);
            this.btnEncouracado.TabIndex = 5;
            this.btnEncouracado.Text = "Encouraçado";
            this.btnEncouracado.UseVisualStyleBackColor = true;
            this.btnEncouracado.Click += new System.EventHandler(this.btnEncouracado_Click);
            // 
            // btnCruzador
            // 
            this.btnCruzador.Location = new System.Drawing.Point(712, 188);
            this.btnCruzador.Name = "btnCruzador";
            this.btnCruzador.Size = new System.Drawing.Size(117, 48);
            this.btnCruzador.TabIndex = 6;
            this.btnCruzador.Text = "Cruzador";
            this.btnCruzador.UseVisualStyleBackColor = true;
            this.btnCruzador.Click += new System.EventHandler(this.btnCruzador_Click);
            // 
            // btnPortaAvioes
            // 
            this.btnPortaAvioes.Location = new System.Drawing.Point(712, 242);
            this.btnPortaAvioes.Name = "btnPortaAvioes";
            this.btnPortaAvioes.Size = new System.Drawing.Size(117, 48);
            this.btnPortaAvioes.TabIndex = 7;
            this.btnPortaAvioes.Text = "Porta-aviões";
            this.btnPortaAvioes.UseVisualStyleBackColor = true;
            this.btnPortaAvioes.Click += new System.EventHandler(this.btnPortaAvioes_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(712, 483);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 45);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Jogar!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbtnSelecionar
            // 
            this.rbtnSelecionar.AutoSize = true;
            this.rbtnSelecionar.Location = new System.Drawing.Point(873, 80);
            this.rbtnSelecionar.Name = "rbtnSelecionar";
            this.rbtnSelecionar.Size = new System.Drawing.Size(143, 20);
            this.rbtnSelecionar.TabIndex = 10;
            this.rbtnSelecionar.Text = "Selecionar Usuário";
            this.rbtnSelecionar.UseVisualStyleBackColor = true;
            this.rbtnSelecionar.CheckedChanged += new System.EventHandler(this.rbtnSelecaoUsuario_CheckedChanged);
            // 
            // rbtnAnonimo
            // 
            this.rbtnAnonimo.AutoSize = true;
            this.rbtnAnonimo.Checked = true;
            this.rbtnAnonimo.Location = new System.Drawing.Point(1025, 80);
            this.rbtnAnonimo.Name = "rbtnAnonimo";
            this.rbtnAnonimo.Size = new System.Drawing.Size(131, 20);
            this.rbtnAnonimo.TabIndex = 11;
            this.rbtnAnonimo.TabStop = true;
            this.rbtnAnonimo.Text = "Usuário Anônimo";
            this.rbtnAnonimo.UseVisualStyleBackColor = true;
            this.rbtnAnonimo.CheckedChanged += new System.EventHandler(this.rbtnSelecaoUsuario_CheckedChanged);
            // 
            // cboxSelecionarUsuario
            // 
            this.cboxSelecionarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSelecionarUsuario.Enabled = false;
            this.cboxSelecionarUsuario.FormattingEnabled = true;
            this.cboxSelecionarUsuario.Location = new System.Drawing.Point(873, 116);
            this.cboxSelecionarUsuario.Name = "cboxSelecionarUsuario";
            this.cboxSelecionarUsuario.Size = new System.Drawing.Size(283, 24);
            this.cboxSelecionarUsuario.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TesteDataGridEInterfacesVisuais.Properties.Resources.selected;
            this.pictureBox1.Location = new System.Drawing.Point(228, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormPreencherTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 624);
            this.Controls.Add(this.cboxSelecionarUsuario);
            this.Controls.Add(this.rbtnAnonimo);
            this.Controls.Add(this.rbtnSelecionar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPortaAvioes);
            this.Controls.Add(this.btnCruzador);
            this.Controls.Add(this.btnEncouracado);
            this.Controls.Add(this.btnDestroier);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.KeyPreview = true;
            this.Name = "FormPreencherTabuleiro";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDestroier;
        private System.Windows.Forms.Button btnEncouracado;
        private System.Windows.Forms.Button btnCruzador;
        private System.Windows.Forms.Button btnPortaAvioes;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbtnSelecionar;
        private System.Windows.Forms.RadioButton rbtnAnonimo;
        private System.Windows.Forms.ComboBox cboxSelecionarUsuario;
    }
}

