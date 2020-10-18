namespace ZoomHouse2
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbGap = new System.Windows.Forms.TrackBar();
            this.tbSize = new System.Windows.Forms.TrackBar();
            this.tbY0 = new System.Windows.Forms.TrackBar();
            this.tbX0 = new System.Windows.Forms.TrackBar();
            this.tbD = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbD)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbGap
            // 
            this.tbGap.Location = new System.Drawing.Point(1026, 107);
            this.tbGap.Maximum = 400;
            this.tbGap.Name = "tbGap";
            this.tbGap.Size = new System.Drawing.Size(104, 56);
            this.tbGap.TabIndex = 1;
            this.tbGap.Scroll += new System.EventHandler(this.tbSize_Scroll);
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(1026, 157);
            this.tbSize.Maximum = 600;
            this.tbSize.Minimum = 50;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(104, 56);
            this.tbSize.TabIndex = 2;
            this.tbSize.Value = 50;
            this.tbSize.Scroll += new System.EventHandler(this.tbSize_Scroll);
            // 
            // tbY0
            // 
            this.tbY0.Location = new System.Drawing.Point(1033, 377);
            this.tbY0.Maximum = 400;
            this.tbY0.Name = "tbY0";
            this.tbY0.Size = new System.Drawing.Size(104, 56);
            this.tbY0.TabIndex = 5;
            this.tbY0.Value = 50;
            this.tbY0.Scroll += new System.EventHandler(this.tbD_Scroll);
            // 
            // tbX0
            // 
            this.tbX0.Location = new System.Drawing.Point(1033, 315);
            this.tbX0.Maximum = 400;
            this.tbX0.Name = "tbX0";
            this.tbX0.Size = new System.Drawing.Size(104, 56);
            this.tbX0.TabIndex = 4;
            this.tbX0.Scroll += new System.EventHandler(this.tbD_Scroll);
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(1033, 439);
            this.tbD.Maximum = 100;
            this.tbD.Minimum = 1;
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(104, 56);
            this.tbD.TabIndex = 6;
            this.tbD.Value = 50;
            this.tbD.Scroll += new System.EventHandler(this.tbD_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 756);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbY0);
            this.Controls.Add(this.tbX0);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbGap);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar tbGap;
        private System.Windows.Forms.TrackBar tbSize;
        private System.Windows.Forms.TrackBar tbY0;
        private System.Windows.Forms.TrackBar tbX0;
        private System.Windows.Forms.TrackBar tbD;
    }
}

