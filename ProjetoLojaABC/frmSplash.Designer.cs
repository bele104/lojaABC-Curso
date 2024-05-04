
namespace ProjetoLojaABC
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pctSplash = new System.Windows.Forms.PictureBox();
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSplash
            // 
            this.pctSplash.Image = ((System.Drawing.Image)(resources.GetObject("pctSplash.Image")));
            this.pctSplash.Location = new System.Drawing.Point(232, 111);
            this.pctSplash.Name = "pctSplash";
            this.pctSplash.Size = new System.Drawing.Size(300, 225);
            this.pctSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSplash.TabIndex = 0;
            this.pctSplash.TabStop = false;
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(232, 393);
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(300, 32);
            this.pgbSplash.TabIndex = 1;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(364, 364);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(36, 20);
            this.lblPorcentagem.TabIndex = 2;
            this.lblPorcentagem.Text = "0 %";
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 1000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.pgbSplash);
            this.Controls.Add(this.pctSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaABC - Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSplash;
        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Button button1;
    }
}