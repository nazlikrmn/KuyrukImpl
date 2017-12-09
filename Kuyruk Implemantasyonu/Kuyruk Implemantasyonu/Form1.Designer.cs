namespace Kuyruk_Implemantasyonu
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
            this.btnCircular = new System.Windows.Forms.Button();
            this.lstMax = new System.Windows.Forms.ListBox();
            this.lstMin = new System.Windows.Forms.ListBox();
            this.lstCircular = new System.Windows.Forms.ListBox();
            this.lstMinEk = new System.Windows.Forms.ListBox();
            this.lstMaxEk = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCircular
            // 
            this.btnCircular.Location = new System.Drawing.Point(1, 2);
            this.btnCircular.Name = "btnCircular";
            this.btnCircular.Size = new System.Drawing.Size(113, 38);
            this.btnCircular.TabIndex = 0;
            this.btnCircular.Text = "Queue";
            this.btnCircular.UseVisualStyleBackColor = true;
            this.btnCircular.Click += new System.EventHandler(this.btnCircular_Click);
            // 
            // lstMax
            // 
            this.lstMax.FormattingEnabled = true;
            this.lstMax.Location = new System.Drawing.Point(817, 2);
            this.lstMax.Name = "lstMax";
            this.lstMax.Size = new System.Drawing.Size(341, 277);
            this.lstMax.TabIndex = 3;
            // 
            // lstMin
            // 
            this.lstMin.FormattingEnabled = true;
            this.lstMin.Location = new System.Drawing.Point(467, 2);
            this.lstMin.Name = "lstMin";
            this.lstMin.Size = new System.Drawing.Size(344, 277);
            this.lstMin.TabIndex = 4;
            // 
            // lstCircular
            // 
            this.lstCircular.FormattingEnabled = true;
            this.lstCircular.Location = new System.Drawing.Point(120, 2);
            this.lstCircular.Name = "lstCircular";
            this.lstCircular.Size = new System.Drawing.Size(341, 277);
            this.lstCircular.TabIndex = 5;
            // 
            // lstMinEk
            // 
            this.lstMinEk.FormattingEnabled = true;
            this.lstMinEk.Location = new System.Drawing.Point(467, 285);
            this.lstMinEk.Name = "lstMinEk";
            this.lstMinEk.Size = new System.Drawing.Size(344, 186);
            this.lstMinEk.TabIndex = 6;
            // 
            // lstMaxEk
            // 
            this.lstMaxEk.FormattingEnabled = true;
            this.lstMaxEk.Location = new System.Drawing.Point(817, 285);
            this.lstMaxEk.Name = "lstMaxEk";
            this.lstMaxEk.Size = new System.Drawing.Size(344, 186);
            this.lstMaxEk.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 478);
            this.Controls.Add(this.lstMaxEk);
            this.Controls.Add(this.lstMinEk);
            this.Controls.Add(this.lstCircular);
            this.Controls.Add(this.lstMin);
            this.Controls.Add(this.lstMax);
            this.Controls.Add(this.btnCircular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCircular;
        private System.Windows.Forms.ListBox lstMax;
        private System.Windows.Forms.ListBox lstMin;
        private System.Windows.Forms.ListBox lstCircular;
        private System.Windows.Forms.ListBox lstMinEk;
        private System.Windows.Forms.ListBox lstMaxEk;
    }
}

