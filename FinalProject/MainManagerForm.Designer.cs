namespace FinalProject
{
    partial class MainManagerForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.displayMoviesButton = new System.Windows.Forms.Button();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.modifyMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.showtimeButton = new System.Windows.Forms.Button();
            this.screeningButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationLabel.Location = new System.Drawing.Point(35, 81);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(243, 18);
            this.explanationLabel.TabIndex = 8;
            this.explanationLabel.Text = "Select an operation to perform:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Location = new System.Drawing.Point(35, 38);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(100, 23);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(203, 26);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 40);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // displayMoviesButton
            // 
            this.displayMoviesButton.Location = new System.Drawing.Point(38, 173);
            this.displayMoviesButton.Name = "displayMoviesButton";
            this.displayMoviesButton.Size = new System.Drawing.Size(75, 42);
            this.displayMoviesButton.TabIndex = 9;
            this.displayMoviesButton.Text = "Display Movies";
            this.displayMoviesButton.UseVisualStyleBackColor = true;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(119, 173);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(75, 42);
            this.addMovieButton.TabIndex = 10;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(200, 173);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(75, 42);
            this.deleteMovieButton.TabIndex = 11;
            this.deleteMovieButton.Text = "Delete Movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            // 
            // modifyMovie
            // 
            this.modifyMovie.Location = new System.Drawing.Point(281, 173);
            this.modifyMovie.Name = "modifyMovie";
            this.modifyMovie.Size = new System.Drawing.Size(75, 42);
            this.modifyMovie.TabIndex = 12;
            this.modifyMovie.Text = "Modify Movie";
            this.modifyMovie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Movie Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Client/Ticket Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Client Information";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 50);
            this.button2.TabIndex = 17;
            this.button2.Text = "Ticket Information";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Screening Management";
            // 
            // showtimeButton
            // 
            this.showtimeButton.Location = new System.Drawing.Point(46, 290);
            this.showtimeButton.Name = "showtimeButton";
            this.showtimeButton.Size = new System.Drawing.Size(92, 42);
            this.showtimeButton.TabIndex = 19;
            this.showtimeButton.Text = "Showtime";
            this.showtimeButton.UseVisualStyleBackColor = true;
            this.showtimeButton.Click += new System.EventHandler(this.showtimeButton_Click);
            // 
            // screeningButton
            // 
            this.screeningButton.Location = new System.Drawing.Point(203, 290);
            this.screeningButton.Name = "screeningButton";
            this.screeningButton.Size = new System.Drawing.Size(92, 42);
            this.screeningButton.TabIndex = 20;
            this.screeningButton.Text = "Screening";
            this.screeningButton.UseVisualStyleBackColor = true;
            // 
            // MainManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 623);
            this.Controls.Add(this.screeningButton);
            this.Controls.Add(this.showtimeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modifyMovie);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.displayMoviesButton);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logoutButton);
            this.Name = "MainManagerForm";
            this.Text = "MainManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button displayMoviesButton;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.Button modifyMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showtimeButton;
        private System.Windows.Forms.Button screeningButton;
    }
}