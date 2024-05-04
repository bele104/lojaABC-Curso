
namespace ProjetoLojaABC
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResp = new System.Windows.Forms.Label();
            this.gpbOp = new System.Windows.Forms.GroupBox();
            this.rdbAd = new System.Windows.Forms.RadioButton();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbMult = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.gpbOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVal2
            // 
            this.txtVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal2.Location = new System.Drawing.Point(128, 95);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 26);
            this.txtVal2.TabIndex = 12;
            // 
            // txtVal1
            // 
            this.txtVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal1.Location = new System.Drawing.Point(128, 34);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 26);
            this.txtVal1.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(541, 343);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 103);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "&Voltar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(541, 227);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 103);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Image = ((System.Drawing.Image)(resources.GetObject("btnCalc.Image")));
            this.btnCalc.Location = new System.Drawing.Point(541, 113);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(112, 103);
            this.btnCalc.TabIndex = 16;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // lblResp
            // 
            this.lblResp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(491, 37);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(162, 41);
            this.lblResp.TabIndex = 18;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpbOp
            // 
            this.gpbOp.Controls.Add(this.rdbAd);
            this.gpbOp.Controls.Add(this.rdbDiv);
            this.gpbOp.Controls.Add(this.rdbSub);
            this.gpbOp.Controls.Add(this.rdbMult);
            this.gpbOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOp.Location = new System.Drawing.Point(128, 163);
            this.gpbOp.Name = "gpbOp";
            this.gpbOp.Size = new System.Drawing.Size(303, 238);
            this.gpbOp.TabIndex = 14;
            this.gpbOp.TabStop = false;
            this.gpbOp.Text = "Operador";
            // 
            // rdbAd
            // 
            this.rdbAd.AutoSize = true;
            this.rdbAd.Location = new System.Drawing.Point(79, 38);
            this.rdbAd.Name = "rdbAd";
            this.rdbAd.Size = new System.Drawing.Size(99, 24);
            this.rdbAd.TabIndex = 3;
            this.rdbAd.TabStop = true;
            this.rdbAd.Text = "Adição (+)";
            this.rdbAd.UseVisualStyleBackColor = true;
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Location = new System.Drawing.Point(82, 165);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(96, 24);
            this.rdbDiv.TabIndex = 6;
            this.rdbDiv.TabStop = true;
            this.rdbDiv.Text = "Divisão (/)";
            this.rdbDiv.UseVisualStyleBackColor = true;
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(79, 79);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(120, 24);
            this.rdbSub.TabIndex = 4;
            this.rdbSub.TabStop = true;
            this.rdbSub.Text = "Subtração (-)";
            this.rdbSub.UseVisualStyleBackColor = true;
            // 
            // rdbMult
            // 
            this.rdbMult.AutoSize = true;
            this.rdbMult.Location = new System.Drawing.Point(80, 121);
            this.rdbMult.Name = "rdbMult";
            this.rdbMult.Size = new System.Drawing.Size(138, 24);
            this.rdbMult.TabIndex = 5;
            this.rdbMult.TabStop = true;
            this.rdbMult.Text = "Multiplicação (*)";
            this.rdbMult.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(488, 17);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(82, 20);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "Resultado";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal2.Location = new System.Drawing.Point(43, 98);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(78, 20);
            this.lblVal2.TabIndex = 13;
            this.lblVal2.Text = "Variável 2";
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal1.Location = new System.Drawing.Point(43, 40);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(78, 20);
            this.lblVal1.TabIndex = 11;
            this.lblVal1.Text = "Variável 1";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 482);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.gpbOp);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblVal2);
            this.Controls.Add(this.lblVal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.gpbOp.ResumeLayout(false);
            this.gpbOp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.GroupBox gpbOp;
        private System.Windows.Forms.RadioButton rdbAd;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbMult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblVal1;
    }
}