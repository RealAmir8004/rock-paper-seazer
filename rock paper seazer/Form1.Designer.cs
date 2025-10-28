namespace RockPaperScissorsGame
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
            this.Rock = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.Location = new System.Drawing.Point(47, 127);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(54, 25);
            this.Rock.TabIndex = 0;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // Paper
            // 
            this.Paper.Location = new System.Drawing.Point(112, 129);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(55, 22);
            this.Paper.TabIndex = 1;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // Scissors
            // 
            this.Scissors.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Scissors.Location = new System.Drawing.Point(185, 127);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(52, 25);
            this.Scissors.TabIndex = 2;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.Location = new System.Drawing.Point(23, 41);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(94, 13);
            this.lblComputerChoice.TabIndex = 3;
            this.lblComputerChoice.Text = "Computer Choice :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(109, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblResult;
    }
}

