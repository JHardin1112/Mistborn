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
            this.btnBurn = new System.Windows.Forms.Button();
            this.btnFlare = new System.Windows.Forms.Button();
            this.lbMetals = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBurn
            // 
            this.btnBurn.Location = new System.Drawing.Point(340, 174);
            this.btnBurn.Name = "btnBurn";
            this.btnBurn.Size = new System.Drawing.Size(75, 23);
            this.btnBurn.TabIndex = 0;
            this.btnBurn.Text = "Burn";
            this.btnBurn.UseVisualStyleBackColor = true;
            this.btnBurn.Click += new System.EventHandler(this.BtnBurn_Click);
            // 
            // btnFlare
            // 
            this.btnFlare.Location = new System.Drawing.Point(340, 203);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMetals);
            this.Controls.Add(this.btnFlare);
            this.Controls.Add(this.btnBurn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBurn;
        private System.Windows.Forms.Button btnFlare;
        private System.Windows.Forms.ListBox lbMetals;
        private System.Windows.Forms.Label label1;
    }
}

