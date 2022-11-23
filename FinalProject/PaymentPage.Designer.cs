namespace FinalProject
{
    partial class PaymentPage
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.cardnumLabel = new System.Windows.Forms.Label();
            this.expLabel = new System.Windows.Forms.Label();
            this.securityCodeLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.securityCodeTextBox = new System.Windows.Forms.TextBox();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(12, 33);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(351, 18);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Please enter your payment information below!";
            // 
            // cardnumLabel
            // 
            this.cardnumLabel.AutoSize = true;
            this.cardnumLabel.Location = new System.Drawing.Point(12, 88);
            this.cardnumLabel.Name = "cardnumLabel";
            this.cardnumLabel.Size = new System.Drawing.Size(90, 16);
            this.cardnumLabel.TabIndex = 1;
            this.cardnumLabel.Text = "Card Number:";
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(12, 127);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(79, 16);
            this.expLabel.TabIndex = 2;
            this.expLabel.Text = "Expiry Date:";
            // 
            // securityCodeLabel
            // 
            this.securityCodeLabel.AutoSize = true;
            this.securityCodeLabel.Location = new System.Drawing.Point(12, 168);
            this.securityCodeLabel.Name = "securityCodeLabel";
            this.securityCodeLabel.Size = new System.Drawing.Size(94, 16);
            this.securityCodeLabel.TabIndex = 3;
            this.securityCodeLabel.Text = "Security Code:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(16, 215);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(108, 215);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 5;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 6;
            // 
            // securityCodeTextBox
            // 
            this.securityCodeTextBox.Location = new System.Drawing.Point(113, 168);
            this.securityCodeTextBox.Name = "securityCodeTextBox";
            this.securityCodeTextBox.Size = new System.Drawing.Size(78, 22);
            this.securityCodeTextBox.TabIndex = 7;
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.Location = new System.Drawing.Point(97, 127);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(200, 22);
            this.expiryDatePicker.TabIndex = 8;
            this.expiryDatePicker.Value = new System.DateTime(2022, 11, 23, 9, 50, 55, 0);
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 265);
            this.Controls.Add(this.expiryDatePicker);
            this.Controls.Add(this.securityCodeTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.securityCodeLabel);
            this.Controls.Add(this.expLabel);
            this.Controls.Add(this.cardnumLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "PaymentPage";
            this.Text = "PaymentPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label cardnumLabel;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Label securityCodeLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox securityCodeTextBox;
        private System.Windows.Forms.DateTimePicker expiryDatePicker;
    }
}