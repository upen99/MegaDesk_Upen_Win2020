namespace MegaDesk_Upen_Win2020
{
    partial class MainMenu
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
            this.btnSearchQuote = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewQuotes = new System.Windows.Forms.Button();
            this.btnAddNewQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchQuote
            // 
            this.btnSearchQuote.Location = new System.Drawing.Point(39, 230);
            this.btnSearchQuote.Name = "btnSearchQuote";
            this.btnSearchQuote.Size = new System.Drawing.Size(226, 69);
            this.btnSearchQuote.TabIndex = 9;
            this.btnSearchQuote.Text = "Search Quotes";
            this.btnSearchQuote.UseVisualStyleBackColor = true;
            this.btnSearchQuote.Click += new System.EventHandler(this.btnSearchQuote_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(39, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 69);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewQuotes
            // 
            this.btnViewQuotes.Location = new System.Drawing.Point(39, 137);
            this.btnViewQuotes.Name = "btnViewQuotes";
            this.btnViewQuotes.Size = new System.Drawing.Size(226, 69);
            this.btnViewQuotes.TabIndex = 7;
            this.btnViewQuotes.Text = "View Quotes";
            this.btnViewQuotes.UseVisualStyleBackColor = true;
            this.btnViewQuotes.Click += new System.EventHandler(this.btnViewQuotes_Click);
            // 
            // btnAddNewQuote
            // 
            this.btnAddNewQuote.Location = new System.Drawing.Point(39, 35);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(226, 69);
            this.btnAddNewQuote.TabIndex = 6;
            this.btnAddNewQuote.Text = "Add New Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = true;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchQuote);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewQuotes);
            this.Controls.Add(this.btnAddNewQuote);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchQuote;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewQuotes;
        private System.Windows.Forms.Button btnAddNewQuote;
    }
}

