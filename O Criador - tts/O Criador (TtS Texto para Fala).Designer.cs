namespace O_Criador___tts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textConverter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.comboVozes = new System.Windows.Forms.ComboBox();
            this.btnLocPasta = new System.Windows.Forms.Button();
            this.localTexto = new System.Windows.Forms.TextBox();
            this.pastaProcurar = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o texto a ser convertido";
            // 
            // textConverter
            // 
            this.textConverter.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConverter.Location = new System.Drawing.Point(59, 59);
            this.textConverter.MaxLength = 10000;
            this.textConverter.Multiline = true;
            this.textConverter.Name = "textConverter";
            this.textConverter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textConverter.Size = new System.Drawing.Size(704, 404);
            this.textConverter.TabIndex = 1;
            this.textConverter.TextChanged += new System.EventHandler(this.textConverter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escolha a voz";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(629, 506);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(134, 51);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar Áudio";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // comboVozes
            // 
            this.comboVozes.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVozes.FormattingEnabled = true;
            this.comboVozes.Items.AddRange(new object[] {
            "Antonio (BR)",
            "Francisca (BR)",
            "Alex (Peru)",
            "Camila (Peru)",
            "Gonzalo (Colombia)",
            "Salome (Colombia)",
            "Brandon (US)",
            "Ashley (US)"});
            this.comboVozes.Location = new System.Drawing.Point(58, 517);
            this.comboVozes.Name = "comboVozes";
            this.comboVozes.Size = new System.Drawing.Size(121, 26);
            this.comboVozes.TabIndex = 6;
            this.comboVozes.SelectedIndexChanged += new System.EventHandler(this.comboVozes_SelectedIndexChanged);
            // 
            // btnLocPasta
            // 
            this.btnLocPasta.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocPasta.Location = new System.Drawing.Point(198, 479);
            this.btnLocPasta.Name = "btnLocPasta";
            this.btnLocPasta.Size = new System.Drawing.Size(94, 31);
            this.btnLocPasta.TabIndex = 7;
            this.btnLocPasta.Text = "Salvar em:";
            this.btnLocPasta.UseVisualStyleBackColor = true;
            this.btnLocPasta.Click += new System.EventHandler(this.btnLocPasta_Click);
            // 
            // localTexto
            // 
            this.localTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localTexto.Location = new System.Drawing.Point(308, 483);
            this.localTexto.Name = "localTexto";
            this.localTexto.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.localTexto.Size = new System.Drawing.Size(293, 22);
            this.localTexto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome do arquivo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textFileName
            // 
            this.textFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFileName.Location = new System.Drawing.Point(348, 522);
            this.textFileName.Name = "textFileName";
            this.textFileName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textFileName.Size = new System.Drawing.Size(253, 22);
            this.textFileName.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 567);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localTexto);
            this.Controls.Add(this.btnLocPasta);
            this.Controls.Add(this.comboVozes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textConverter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "O Criador (TtS Texto para Fala) Jonatha Teixeira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textConverter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox comboVozes;
        private System.Windows.Forms.Button btnLocPasta;
        private System.Windows.Forms.TextBox localTexto;
        private System.Windows.Forms.FolderBrowserDialog pastaProcurar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFileName;
    }
}

