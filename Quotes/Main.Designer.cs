
namespace Quotes
{
    partial class QuotesBook
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.CharacterLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.GetQuoteButton = new System.Windows.Forms.Button();
            this.DGVQuotes = new System.Windows.Forms.DataGridView();
            this.DeleteQuoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Location = new System.Drawing.Point(688, 76);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(100, 35);
            this.AddQuoteButton.TabIndex = 0;
            this.AddQuoteButton.Text = "Добавить цитату";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.Location = new System.Drawing.Point(12, 47);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(452, 99);
            this.QuoteLabel.TabIndex = 1;
            this.QuoteLabel.Text = "Цитата";
            this.QuoteLabel.Visible = false;
            this.QuoteLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CharacterLabel
            // 
            this.CharacterLabel.Location = new System.Drawing.Point(489, 63);
            this.CharacterLabel.Name = "CharacterLabel";
            this.CharacterLabel.Size = new System.Drawing.Size(193, 40);
            this.CharacterLabel.TabIndex = 2;
            this.CharacterLabel.Text = "Персонаж";
            this.CharacterLabel.Visible = false;
            // 
            // SourceLabel
            // 
            this.SourceLabel.Location = new System.Drawing.Point(489, 125);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(169, 59);
            this.SourceLabel.TabIndex = 3;
            this.SourceLabel.Text = "Источник";
            this.SourceLabel.Visible = false;
            // 
            // GetQuoteButton
            // 
            this.GetQuoteButton.Location = new System.Drawing.Point(688, 24);
            this.GetQuoteButton.Name = "GetQuoteButton";
            this.GetQuoteButton.Size = new System.Drawing.Size(100, 46);
            this.GetQuoteButton.TabIndex = 4;
            this.GetQuoteButton.Text = "Получить цитату!";
            this.GetQuoteButton.UseVisualStyleBackColor = true;
            this.GetQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Click);
            // 
            // DGVQuotes
            // 
            this.DGVQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVQuotes.Location = new System.Drawing.Point(140, 206);
            this.DGVQuotes.Name = "DGVQuotes";
            this.DGVQuotes.Size = new System.Drawing.Size(373, 37);
            this.DGVQuotes.TabIndex = 5;
            this.DGVQuotes.Visible = false;
            // 
            // DeleteQuoteButton
            // 
            this.DeleteQuoteButton.Location = new System.Drawing.Point(688, 117);
            this.DeleteQuoteButton.Name = "DeleteQuoteButton";
            this.DeleteQuoteButton.Size = new System.Drawing.Size(100, 35);
            this.DeleteQuoteButton.TabIndex = 6;
            this.DeleteQuoteButton.Text = "Удалить цитату";
            this.DeleteQuoteButton.UseVisualStyleBackColor = true;
            this.DeleteQuoteButton.Click += new System.EventHandler(this.DeleteQuoteButton_Click);
            // 
            // QuotesBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.DeleteQuoteButton);
            this.Controls.Add(this.DGVQuotes);
            this.Controls.Add(this.GetQuoteButton);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.CharacterLabel);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.AddQuoteButton);
            this.Name = "QuotesBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книга цитат";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.Label CharacterLabel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Button GetQuoteButton;
        private System.Windows.Forms.DataGridView DGVQuotes;
        private System.Windows.Forms.Button DeleteQuoteButton;
    }
}

