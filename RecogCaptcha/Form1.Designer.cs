namespace RecogCaptcha
{
    partial class Form1
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openImageButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.pbImagemOriginal = new System.Windows.Forms.PictureBox();
            this.pbCaracter1 = new System.Windows.Forms.PictureBox();
            this.pbCaracter2 = new System.Windows.Forms.PictureBox();
            this.pbCaracter3 = new System.Windows.Forms.PictureBox();
            this.pbCaracter4 = new System.Windows.Forms.PictureBox();
            this.pbCaracter5 = new System.Windows.Forms.PictureBox();
            this.pbCaracter6 = new System.Windows.Forms.PictureBox();
            this.tbCaracter1 = new System.Windows.Forms.TextBox();
            this.tbCaracter2 = new System.Windows.Forms.TextBox();
            this.tbCaracter3 = new System.Windows.Forms.TextBox();
            this.tbCaracter4 = new System.Windows.Forms.TextBox();
            this.tbCaracter5 = new System.Windows.Forms.TextBox();
            this.tbCaracter6 = new System.Windows.Forms.TextBox();
            this.pbImg1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImg2 = new System.Windows.Forms.PictureBox();
            this.lbPercent = new System.Windows.Forms.Label();
            this.pbLetra = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.pbLetraSemelhante = new System.Windows.Forms.PictureBox();
            this.lbPercentLetra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetraSemelhante)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(12, 12);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(129, 23);
            this.openImageButton.TabIndex = 0;
            this.openImageButton.Text = "Selecionar Imagem";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(288, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(224, 98);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(525, 83);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(154, 17);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Não foi reconhecido";
            // 
            // pbImagemOriginal
            // 
            this.pbImagemOriginal.Location = new System.Drawing.Point(12, 41);
            this.pbImagemOriginal.Name = "pbImagemOriginal";
            this.pbImagemOriginal.Size = new System.Drawing.Size(224, 98);
            this.pbImagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemOriginal.TabIndex = 3;
            this.pbImagemOriginal.TabStop = false;
            // 
            // pbCaracter1
            // 
            this.pbCaracter1.Location = new System.Drawing.Point(12, 180);
            this.pbCaracter1.Name = "pbCaracter1";
            this.pbCaracter1.Size = new System.Drawing.Size(65, 43);
            this.pbCaracter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaracter1.TabIndex = 4;
            this.pbCaracter1.TabStop = false;
            // 
            // pbCaracter2
            // 
            this.pbCaracter2.Location = new System.Drawing.Point(95, 180);
            this.pbCaracter2.Name = "pbCaracter2";
            this.pbCaracter2.Size = new System.Drawing.Size(65, 43);
            this.pbCaracter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaracter2.TabIndex = 5;
            this.pbCaracter2.TabStop = false;
            // 
            // pbCaracter3
            // 
            this.pbCaracter3.Location = new System.Drawing.Point(181, 180);
            this.pbCaracter3.Name = "pbCaracter3";
            this.pbCaracter3.Size = new System.Drawing.Size(65, 43);
            this.pbCaracter3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaracter3.TabIndex = 6;
            this.pbCaracter3.TabStop = false;
            // 
            // pbCaracter4
            // 
            this.pbCaracter4.Location = new System.Drawing.Point(271, 180);
            this.pbCaracter4.Name = "pbCaracter4";
            this.pbCaracter4.Size = new System.Drawing.Size(65, 43);
            this.pbCaracter4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaracter4.TabIndex = 7;
            this.pbCaracter4.TabStop = false;
            // 
            // pbCaracter5
            // 
            this.pbCaracter5.Location = new System.Drawing.Point(362, 180);
            this.pbCaracter5.Name = "pbCaracter5";
            this.pbCaracter5.Size = new System.Drawing.Size(65, 43);
            this.pbCaracter5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaracter5.TabIndex = 8;
            this.pbCaracter5.TabStop = false;
            // 
            // pbCaracter6
            // 
            this.pbCaracter6.Location = new System.Drawing.Point(447, 180);
            this.pbCaracter6.Name = "pbCaracter6";
            this.pbCaracter6.Size = new System.Drawing.Size(65, 43);
            this.pbCaracter6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaracter6.TabIndex = 9;
            this.pbCaracter6.TabStop = false;
            // 
            // tbCaracter1
            // 
            this.tbCaracter1.Location = new System.Drawing.Point(12, 231);
            this.tbCaracter1.Name = "tbCaracter1";
            this.tbCaracter1.Size = new System.Drawing.Size(65, 20);
            this.tbCaracter1.TabIndex = 10;
            // 
            // tbCaracter2
            // 
            this.tbCaracter2.Location = new System.Drawing.Point(95, 231);
            this.tbCaracter2.Name = "tbCaracter2";
            this.tbCaracter2.Size = new System.Drawing.Size(65, 20);
            this.tbCaracter2.TabIndex = 11;
            // 
            // tbCaracter3
            // 
            this.tbCaracter3.Location = new System.Drawing.Point(181, 231);
            this.tbCaracter3.Name = "tbCaracter3";
            this.tbCaracter3.Size = new System.Drawing.Size(65, 20);
            this.tbCaracter3.TabIndex = 12;
            // 
            // tbCaracter4
            // 
            this.tbCaracter4.Location = new System.Drawing.Point(271, 229);
            this.tbCaracter4.Name = "tbCaracter4";
            this.tbCaracter4.Size = new System.Drawing.Size(65, 20);
            this.tbCaracter4.TabIndex = 13;
            // 
            // tbCaracter5
            // 
            this.tbCaracter5.Location = new System.Drawing.Point(362, 231);
            this.tbCaracter5.Name = "tbCaracter5";
            this.tbCaracter5.Size = new System.Drawing.Size(65, 20);
            this.tbCaracter5.TabIndex = 14;
            // 
            // tbCaracter6
            // 
            this.tbCaracter6.Location = new System.Drawing.Point(447, 231);
            this.tbCaracter6.Name = "tbCaracter6";
            this.tbCaracter6.Size = new System.Drawing.Size(65, 20);
            this.tbCaracter6.TabIndex = 15;
            // 
            // pbImg1
            // 
            this.pbImg1.Location = new System.Drawing.Point(115, 281);
            this.pbImg1.Name = "pbImg1";
            this.pbImg1.Size = new System.Drawing.Size(65, 43);
            this.pbImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg1.TabIndex = 16;
            this.pbImg1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "mais parece com";
            // 
            // pbImg2
            // 
            this.pbImg2.Location = new System.Drawing.Point(313, 281);
            this.pbImg2.Name = "pbImg2";
            this.pbImg2.Size = new System.Drawing.Size(65, 43);
            this.pbImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg2.TabIndex = 18;
            this.pbImg2.TabStop = false;
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.Location = new System.Drawing.Point(220, 313);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(47, 17);
            this.lbPercent.TabIndex = 19;
            this.lbPercent.Text = "{0} %";
            // 
            // pbLetra
            // 
            this.pbLetra.Location = new System.Drawing.Point(597, 180);
            this.pbLetra.Name = "pbLetra";
            this.pbLetra.Size = new System.Drawing.Size(65, 43);
            this.pbLetra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLetra.TabIndex = 20;
            this.pbLetra.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sel. Letra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Sel. Semelhante";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbLetraSemelhante
            // 
            this.pbLetraSemelhante.Location = new System.Drawing.Point(597, 274);
            this.pbLetraSemelhante.Name = "pbLetraSemelhante";
            this.pbLetraSemelhante.Size = new System.Drawing.Size(65, 43);
            this.pbLetraSemelhante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLetraSemelhante.TabIndex = 23;
            this.pbLetraSemelhante.TabStop = false;
            // 
            // lbPercentLetra
            // 
            this.lbPercentLetra.AutoSize = true;
            this.lbPercentLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentLetra.Location = new System.Drawing.Point(606, 349);
            this.lbPercentLetra.Name = "lbPercentLetra";
            this.lbPercentLetra.Size = new System.Drawing.Size(47, 17);
            this.lbPercentLetra.TabIndex = 24;
            this.lbPercentLetra.Text = "{0} %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 378);
            this.Controls.Add(this.lbPercentLetra);
            this.Controls.Add(this.pbLetraSemelhante);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbLetra);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.pbImg2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImg1);
            this.Controls.Add(this.tbCaracter6);
            this.Controls.Add(this.tbCaracter5);
            this.Controls.Add(this.tbCaracter4);
            this.Controls.Add(this.tbCaracter3);
            this.Controls.Add(this.tbCaracter2);
            this.Controls.Add(this.tbCaracter1);
            this.Controls.Add(this.pbCaracter6);
            this.Controls.Add(this.pbCaracter5);
            this.Controls.Add(this.pbCaracter4);
            this.Controls.Add(this.pbCaracter3);
            this.Controls.Add(this.pbCaracter2);
            this.Controls.Add(this.pbCaracter1);
            this.Controls.Add(this.pbImagemOriginal);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.openImageButton);
            this.Name = "Form1";
            this.Text = "Recog. Captcha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaracter6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetraSemelhante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox pbImagemOriginal;
        private System.Windows.Forms.PictureBox pbCaracter1;
        private System.Windows.Forms.PictureBox pbCaracter2;
        private System.Windows.Forms.PictureBox pbCaracter3;
        private System.Windows.Forms.PictureBox pbCaracter4;
        private System.Windows.Forms.PictureBox pbCaracter5;
        private System.Windows.Forms.PictureBox pbCaracter6;
        private System.Windows.Forms.TextBox tbCaracter1;
        private System.Windows.Forms.TextBox tbCaracter2;
        private System.Windows.Forms.TextBox tbCaracter3;
        private System.Windows.Forms.TextBox tbCaracter4;
        private System.Windows.Forms.TextBox tbCaracter5;
        private System.Windows.Forms.TextBox tbCaracter6;
        private System.Windows.Forms.PictureBox pbImg1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImg2;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.PictureBox pbLetra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbLetraSemelhante;
        private System.Windows.Forms.Label lbPercentLetra;
    }
}

