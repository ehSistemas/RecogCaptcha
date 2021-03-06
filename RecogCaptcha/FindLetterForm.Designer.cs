﻿namespace RecogCaptcha
{
    partial class FindLetterForm
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
            this.pbCaptcha = new System.Windows.Forms.PictureBox();
            this.btLoadCaptcha = new System.Windows.Forms.Button();
            this.pbLetter = new System.Windows.Forms.PictureBox();
            this.pbMatch = new System.Windows.Forms.PictureBox();
            this.btLetter = new System.Windows.Forms.Button();
            this.btFindMatch = new System.Windows.Forms.Button();
            this.lbPercent = new System.Windows.Forms.Label();
            this.ofdCaptcha = new System.Windows.Forms.OpenFileDialog();
            this.ofdLetter = new System.Windows.Forms.OpenFileDialog();
            this.btAplicarFiltros = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btSalve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaptcha
            // 
            this.pbCaptcha.Location = new System.Drawing.Point(12, 12);
            this.pbCaptcha.Name = "pbCaptcha";
            this.pbCaptcha.Size = new System.Drawing.Size(240, 117);
            this.pbCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaptcha.TabIndex = 0;
            this.pbCaptcha.TabStop = false;
            // 
            // btLoadCaptcha
            // 
            this.btLoadCaptcha.Location = new System.Drawing.Point(12, 135);
            this.btLoadCaptcha.Name = "btLoadCaptcha";
            this.btLoadCaptcha.Size = new System.Drawing.Size(75, 23);
            this.btLoadCaptcha.TabIndex = 1;
            this.btLoadCaptcha.Text = "Carregar";
            this.btLoadCaptcha.UseVisualStyleBackColor = true;
            this.btLoadCaptcha.Click += new System.EventHandler(this.btLoadCaptcha_Click);
            // 
            // pbLetter
            // 
            this.pbLetter.Location = new System.Drawing.Point(396, 12);
            this.pbLetter.Name = "pbLetter";
            this.pbLetter.Size = new System.Drawing.Size(91, 117);
            this.pbLetter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLetter.TabIndex = 2;
            this.pbLetter.TabStop = false;
            // 
            // pbMatch
            // 
            this.pbMatch.Location = new System.Drawing.Point(531, 12);
            this.pbMatch.Name = "pbMatch";
            this.pbMatch.Size = new System.Drawing.Size(91, 117);
            this.pbMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMatch.TabIndex = 3;
            this.pbMatch.TabStop = false;
            // 
            // btLetter
            // 
            this.btLetter.Location = new System.Drawing.Point(401, 135);
            this.btLetter.Name = "btLetter";
            this.btLetter.Size = new System.Drawing.Size(75, 23);
            this.btLetter.TabIndex = 4;
            this.btLetter.Text = "Carregar";
            this.btLetter.UseVisualStyleBackColor = true;
            this.btLetter.Click += new System.EventHandler(this.btLetter_Click);
            // 
            // btFindMatch
            // 
            this.btFindMatch.Location = new System.Drawing.Point(539, 134);
            this.btFindMatch.Name = "btFindMatch";
            this.btFindMatch.Size = new System.Drawing.Size(75, 23);
            this.btFindMatch.TabIndex = 5;
            this.btFindMatch.Text = "Carregar";
            this.btFindMatch.UseVisualStyleBackColor = true;
            this.btFindMatch.Click += new System.EventHandler(this.btFindMatch_Click);
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Location = new System.Drawing.Point(396, 165);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(35, 13);
            this.lbPercent.TabIndex = 6;
            this.lbPercent.Text = "label1";
            // 
            // ofdCaptcha
            // 
            this.ofdCaptcha.FileName = "openFileDialog1";
            // 
            // ofdLetter
            // 
            this.ofdLetter.FileName = "openFileDialog1";
            // 
            // btAplicarFiltros
            // 
            this.btAplicarFiltros.Location = new System.Drawing.Point(177, 135);
            this.btAplicarFiltros.Name = "btAplicarFiltros";
            this.btAplicarFiltros.Size = new System.Drawing.Size(75, 23);
            this.btAplicarFiltros.TabIndex = 8;
            this.btAplicarFiltros.Text = "Aplicar Filtros";
            this.btAplicarFiltros.UseVisualStyleBackColor = true;
            this.btAplicarFiltros.Click += new System.EventHandler(this.btAplicarFiltros_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 175);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Percentual de Diferença";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Imagem";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // btSalve
            // 
            this.btSalve.Location = new System.Drawing.Point(258, 55);
            this.btSalve.Name = "btSalve";
            this.btSalve.Size = new System.Drawing.Size(75, 23);
            this.btSalve.TabIndex = 10;
            this.btSalve.Text = "Salvar";
            this.btSalve.UseVisualStyleBackColor = true;
            this.btSalve.Click += new System.EventHandler(this.btSalve_Click);
            // 
            // FindLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 365);
            this.Controls.Add(this.btSalve);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btAplicarFiltros);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.btFindMatch);
            this.Controls.Add(this.btLetter);
            this.Controls.Add(this.pbMatch);
            this.Controls.Add(this.pbLetter);
            this.Controls.Add(this.btLoadCaptcha);
            this.Controls.Add(this.pbCaptcha);
            this.Name = "FindLetterForm";
            this.Text = "FindLetterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCaptcha;
        private System.Windows.Forms.Button btLoadCaptcha;
        private System.Windows.Forms.PictureBox pbLetter;
        private System.Windows.Forms.PictureBox pbMatch;
        private System.Windows.Forms.Button btLetter;
        private System.Windows.Forms.Button btFindMatch;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.OpenFileDialog ofdCaptcha;
        private System.Windows.Forms.OpenFileDialog ofdLetter;
        private System.Windows.Forms.Button btAplicarFiltros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.Button btSalve;
    }
}