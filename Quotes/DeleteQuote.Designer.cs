
namespace Quotes
{
    partial class DeleteQuote
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
            this.DGVDelete = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDelete
            // 
            this.DGVDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDelete.Location = new System.Drawing.Point(1, 47);
            this.DGVDelete.Name = "DGVDelete";
            this.DGVDelete.Size = new System.Drawing.Size(787, 365);
            this.DGVDelete.TabIndex = 0;
            this.DGVDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCellClick);
            this.DGVDelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDelete_CellContentClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(697, 418);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.Location = new System.Drawing.Point(12, 418);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteAllButton.TabIndex = 2;
            this.DeleteAllButton.Text = "Удалить все";
            this.DeleteAllButton.UseVisualStyleBackColor = true;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // DeleteQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteAllButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DGVDelete);
            this.Name = "DeleteQuote";
            this.Text = "Удаление цитаты";
            this.Load += new System.EventHandler(this.DeleteQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDelete;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DeleteAllButton;
    }
}