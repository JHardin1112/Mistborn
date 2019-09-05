namespace Mistborn
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
            this.btnBurnStart = new System.Windows.Forms.Button();
            this.btnFlare = new System.Windows.Forms.Button();
            this.lbMetals = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBurnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBurnStart
            // 
            this.btnBurnStart.Location = new System.Drawing.Point(247, 161);
            this.btnBurnStart.Name = "btnBurnStart";
            this.btnBurnStart.Size = new System.Drawing.Size(75, 23);
            this.btnBurnStart.TabIndex = 0;
            this.btnBurnStart.Text = "Start Burn";
            this.btnBurnStart.UseVisualStyleBackColor = true;
            this.btnBurnStart.Click += new System.EventHandler(this.BtnBurnStart_Click);
            // 
            // btnFlare
            // 
            this.btnFlare.Location = new System.Drawing.Point(247, 233);
            this.btnFlare.Name = "btnFlare";
            this.btnFlare.Size = new System.Drawing.Size(75, 23);
            this.btnFlare.TabIndex = 1;
            this.btnFlare.Text = "Flare";
            this.btnFlare.UseVisualStyleBackColor = true;
            // 
            // lbMetals
            // 
            this.lbMetals.FormattingEnabled = true;
            this.lbMetals.Location = new System.Drawing.Point(65, 161);
            this.lbMetals.Name = "lbMetals";
            this.lbMetals.Size = new System.Drawing.Size(120, 95);
            this.lbMetals.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnBurnStop
            // 
            this.btnBurnStop.Location = new System.Drawing.Point(247, 190);
            this.btnBurnStop.Name = "btnBurnStop";
            this.btnBurnStop.Size = new System.Drawing.Size(75, 23);
            this.btnBurnStop.TabIndex = 4;
            this.btnBurnStop.Text = "Stop Burn";
            this.btnBurnStop.UseVisualStyleBackColor = true;
            this.btnBurnStop.Click += new System.EventHandler(this.BtnBurnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBurnStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMetals);
            this.Controls.Add(this.btnFlare);
            this.Controls.Add(this.btnBurnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBurnStart;
        private System.Windows.Forms.Button btnFlare;
        private System.Windows.Forms.ListBox lbMetals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBurnStop;
    }
}

