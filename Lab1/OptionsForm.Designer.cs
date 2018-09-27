namespace Lab1
{
    partial class OptionsForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnVerMirroring = new System.Windows.Forms.Button();
            this.btnHorMirroring = new System.Windows.Forms.Button();
            this.numberQuantize = new System.Windows.Forms.NumericUpDown();
            this.btnQuantize = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberQuantize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(41, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(107, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(41, 51);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(107, 23);
            this.btnGray.TabIndex = 4;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(41, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnVerMirroring
            // 
            this.btnVerMirroring.Location = new System.Drawing.Point(41, 109);
            this.btnVerMirroring.Name = "btnVerMirroring";
            this.btnVerMirroring.Size = new System.Drawing.Size(107, 23);
            this.btnVerMirroring.TabIndex = 6;
            this.btnVerMirroring.Text = "Vertical Mirroring";
            this.btnVerMirroring.UseVisualStyleBackColor = true;
            this.btnVerMirroring.Click += new System.EventHandler(this.btnVerMirroring_Click);
            // 
            // btnHorMirroring
            // 
            this.btnHorMirroring.Location = new System.Drawing.Point(41, 138);
            this.btnHorMirroring.Name = "btnHorMirroring";
            this.btnHorMirroring.Size = new System.Drawing.Size(107, 23);
            this.btnHorMirroring.TabIndex = 7;
            this.btnHorMirroring.Text = "Horizontal Mirroring";
            this.btnHorMirroring.UseVisualStyleBackColor = true;
            this.btnHorMirroring.Click += new System.EventHandler(this.btnHorMirroring_Click);
            // 
            // numberQuantize
            // 
            this.numberQuantize.Location = new System.Drawing.Point(106, 167);
            this.numberQuantize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberQuantize.Name = "numberQuantize";
            this.numberQuantize.Size = new System.Drawing.Size(42, 20);
            this.numberQuantize.TabIndex = 8;
            this.numberQuantize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnQuantize
            // 
            this.btnQuantize.Location = new System.Drawing.Point(41, 167);
            this.btnQuantize.Name = "btnQuantize";
            this.btnQuantize.Size = new System.Drawing.Size(59, 20);
            this.btnQuantize.TabIndex = 9;
            this.btnQuantize.Text = "Quantize";
            this.btnQuantize.UseVisualStyleBackColor = true;
            this.btnQuantize.Click += new System.EventHandler(this.btnQuantize_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.Location = new System.Drawing.Point(41, 194);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(107, 23);
            this.btnHistogram.TabIndex = 10;
            this.btnHistogram.Text = "Histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 273);
            this.Controls.Add(this.btnHistogram);
            this.Controls.Add(this.btnQuantize);
            this.Controls.Add(this.numberQuantize);
            this.Controls.Add(this.btnHorMirroring);
            this.Controls.Add(this.btnVerMirroring);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnOpen);
            this.Name = "OptionsForm";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.numberQuantize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnVerMirroring;
        private System.Windows.Forms.Button btnHorMirroring;
        private System.Windows.Forms.NumericUpDown numberQuantize;
        private System.Windows.Forms.Button btnQuantize;
        private System.Windows.Forms.Button btnHistogram;
    }
}

