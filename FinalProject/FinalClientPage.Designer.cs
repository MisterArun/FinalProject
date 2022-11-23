namespace FinalProject
{
    partial class FinalClientPage
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
            this.explanationLabel = new System.Windows.Forms.Label();
            this.ticketNumLabel = new System.Windows.Forms.Label();
            this.mainPageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationLabel.Location = new System.Drawing.Point(57, 59);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(228, 18);
            this.explanationLabel.TabIndex = 0;
            this.explanationLabel.Text = "Thank you for your purchase!";
            // 
            // ticketNumLabel
            // 
            this.ticketNumLabel.AutoSize = true;
            this.ticketNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketNumLabel.Location = new System.Drawing.Point(57, 90);
            this.ticketNumLabel.Name = "ticketNumLabel";
            this.ticketNumLabel.Size = new System.Drawing.Size(155, 16);
            this.ticketNumLabel.TabIndex = 1;
            this.ticketNumLabel.Text = "Your ticket number is:";
            // 
            // mainPageButton
            // 
            this.mainPageButton.Location = new System.Drawing.Point(60, 131);
            this.mainPageButton.Name = "mainPageButton";
            this.mainPageButton.Size = new System.Drawing.Size(177, 36);
            this.mainPageButton.TabIndex = 2;
            this.mainPageButton.Text = "Back to Home Page";
            this.mainPageButton.UseVisualStyleBackColor = true;
            // 
            // FinalClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 207);
            this.Controls.Add(this.mainPageButton);
            this.Controls.Add(this.ticketNumLabel);
            this.Controls.Add(this.explanationLabel);
            this.Name = "FinalClientPage";
            this.Text = "FinalClientPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.Label ticketNumLabel;
        private System.Windows.Forms.Button mainPageButton;
    }
}