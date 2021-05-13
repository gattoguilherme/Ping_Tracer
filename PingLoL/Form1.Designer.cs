
namespace PingLoL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtAverage = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.txtHitCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(381, 39);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(180, 23);
            this.txtIp.TabIndex = 0;
            this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(344, 42);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(20, 15);
            this.lblIp.TabIndex = 1;
            this.lblIp.Text = "IP:";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(410, 82);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(109, 44);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(39, 132);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(828, 286);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "";
            // 
            // txtAverage
            // 
            this.txtAverage.AutoSize = true;
            this.txtAverage.Location = new System.Drawing.Point(454, 454);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(16, 15);
            this.txtAverage.TabIndex = 4;
            this.txtAverage.Text = "...";
            // 
            // txtMin
            // 
            this.txtMin.AutoSize = true;
            this.txtMin.Location = new System.Drawing.Point(335, 454);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(16, 15);
            this.txtMin.TabIndex = 5;
            this.txtMin.Text = "...";
            // 
            // txtMax
            // 
            this.txtMax.AutoSize = true;
            this.txtMax.Location = new System.Drawing.Point(567, 454);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(16, 15);
            this.txtMax.TabIndex = 6;
            this.txtMax.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Average";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(240, -85);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TabIndex = 11;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(410, 9);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(109, 15);
            this.lblStats.TabIndex = 12;
            this.lblStats.Text = "Initiating Execution";
            // 
            // txtHitCount
            // 
            this.txtHitCount.Location = new System.Drawing.Point(712, 39);
            this.txtHitCount.Name = "txtHitCount";
            this.txtHitCount.Size = new System.Drawing.Size(40, 23);
            this.txtHitCount.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hit Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHitCount);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.txtIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Ping Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label txtAverage;
        private System.Windows.Forms.Label txtMin;
        private System.Windows.Forms.Label txtMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.TextBox txtHitCount;
        private System.Windows.Forms.Label label5;
    }
}

