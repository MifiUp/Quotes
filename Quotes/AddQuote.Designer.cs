
namespace Quotes
{
    partial class AddQuote
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
            this.QuoteTextBox = new System.Windows.Forms.TextBox();
            this.CharacterTextBox = new System.Windows.Forms.TextBox();
            this.MovieTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.CharacterLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuoteTextBox
            // 
            this.QuoteTextBox.Location = new System.Drawing.Point(37, 25);
            this.QuoteTextBox.Name = "QuoteTextBox";
            this.QuoteTextBox.Size = new System.Drawing.Size(458, 20);
            this.QuoteTextBox.TabIndex = 0;
            // 
            // CharacterTextBox
            // 
            this.CharacterTextBox.Location = new System.Drawing.Point(516, 25);
            this.CharacterTextBox.Name = "CharacterTextBox";
            this.CharacterTextBox.Size = new System.Drawing.Size(100, 20);
            this.CharacterTextBox.TabIndex = 1;
            // 
            // MovieTextBox
            // 
            this.MovieTextBox.Location = new System.Drawing.Point(635, 25);
            this.MovieTextBox.Name = "MovieTextBox";
            this.MovieTextBox.Size = new System.Drawing.Size(123, 20);
            this.MovieTextBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(683, 51);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Location = new System.Drawing.Point(34, 9);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(46, 13);
            this.QuoteLabel.TabIndex = 4;
            this.QuoteLabel.Text = "Цитата:";
            // 
            // CharacterLabel
            // 
            this.CharacterLabel.AutoSize = true;
            this.CharacterLabel.Location = new System.Drawing.Point(513, 9);
            this.CharacterLabel.Name = "CharacterLabel";
            this.CharacterLabel.Size = new System.Drawing.Size(62, 13);
            this.CharacterLabel.TabIndex = 5;
            this.CharacterLabel.Text = "Персонаж:";
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(641, 9);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(58, 13);
            this.MovieLabel.TabIndex = 6;
            this.MovieLabel.Text = "Источник:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 81);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.CharacterLabel);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MovieTextBox);
            this.Controls.Add(this.CharacterTextBox);
            this.Controls.Add(this.QuoteTextBox);
            this.Name = "AddQuote";
            this.Text = "Добавить цитату";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuoteTextBox;
        private System.Windows.Forms.TextBox CharacterTextBox;
        private System.Windows.Forms.TextBox MovieTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.Label CharacterLabel;
        private System.Windows.Forms.Label MovieLabel;
    }
}