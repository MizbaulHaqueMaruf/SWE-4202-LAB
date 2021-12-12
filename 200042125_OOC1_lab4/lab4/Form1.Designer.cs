namespace lab4
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
            this.bookIDtxt = new System.Windows.Forms.TextBox();
            this.bookQuantityTxt = new System.Windows.Forms.TextBox();
            this.bookPublisherTxt = new System.Windows.Forms.TextBox();
            this.bookAuthorTxt = new System.Windows.Forms.TextBox();
            this.bookTitleTxt = new System.Windows.Forms.TextBox();
            this.bookGenreTxt = new System.Windows.Forms.TextBox();
            this.bookISBNtxt = new System.Windows.Forms.TextBox();
            this.addStudyBookbutton = new System.Windows.Forms.Button();
            this.addResearchArticleButton = new System.Windows.Forms.Button();
            this.articleDOItxt = new System.Windows.Forms.TextBox();
            this.articlePublishedDateTxt = new System.Windows.Forms.TextBox();
            this.articleTitletxt = new System.Windows.Forms.TextBox();
            this.articleAuthorTxt = new System.Windows.Forms.TextBox();
            this.articlePublisherTxt = new System.Windows.Forms.TextBox();
            this.articleQuantityTxt = new System.Windows.Forms.TextBox();
            this.articleIDtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConOrJournalTxt = new System.Windows.Forms.TextBox();
            this.bookIDinSearchTxt = new System.Windows.Forms.TextBox();
            this.articleIDinSearchTxt = new System.Windows.Forms.TextBox();
            this.bookBorrowButton = new System.Windows.Forms.Button();
            this.articleBorrowButton = new System.Windows.Forms.Button();
            this.showArticleButtton = new System.Windows.Forms.Button();
            this.showBookButton = new System.Windows.Forms.Button();
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.articleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bookIDtxt
            // 
            this.bookIDtxt.Location = new System.Drawing.Point(25, 26);
            this.bookIDtxt.Name = "bookIDtxt";
            this.bookIDtxt.Size = new System.Drawing.Size(191, 22);
            this.bookIDtxt.TabIndex = 0;
            this.bookIDtxt.Text = "Book ID";
            // 
            // bookQuantityTxt
            // 
            this.bookQuantityTxt.Location = new System.Drawing.Point(25, 138);
            this.bookQuantityTxt.Name = "bookQuantityTxt";
            this.bookQuantityTxt.Size = new System.Drawing.Size(191, 22);
            this.bookQuantityTxt.TabIndex = 1;
            this.bookQuantityTxt.Text = "Book Quantity";
            // 
            // bookPublisherTxt
            // 
            this.bookPublisherTxt.Location = new System.Drawing.Point(25, 110);
            this.bookPublisherTxt.Name = "bookPublisherTxt";
            this.bookPublisherTxt.Size = new System.Drawing.Size(191, 22);
            this.bookPublisherTxt.TabIndex = 2;
            this.bookPublisherTxt.Text = "Book Publisher";
            // 
            // bookAuthorTxt
            // 
            this.bookAuthorTxt.Location = new System.Drawing.Point(25, 82);
            this.bookAuthorTxt.Name = "bookAuthorTxt";
            this.bookAuthorTxt.Size = new System.Drawing.Size(191, 22);
            this.bookAuthorTxt.TabIndex = 3;
            this.bookAuthorTxt.Text = "Book Author";
            // 
            // bookTitleTxt
            // 
            this.bookTitleTxt.Location = new System.Drawing.Point(25, 54);
            this.bookTitleTxt.Name = "bookTitleTxt";
            this.bookTitleTxt.Size = new System.Drawing.Size(191, 22);
            this.bookTitleTxt.TabIndex = 4;
            this.bookTitleTxt.Text = "Book Title";
            // 
            // bookGenreTxt
            // 
            this.bookGenreTxt.Location = new System.Drawing.Point(25, 194);
            this.bookGenreTxt.Name = "bookGenreTxt";
            this.bookGenreTxt.Size = new System.Drawing.Size(191, 22);
            this.bookGenreTxt.TabIndex = 5;
            this.bookGenreTxt.Text = "Book Genre";
            // 
            // bookISBNtxt
            // 
            this.bookISBNtxt.Location = new System.Drawing.Point(25, 166);
            this.bookISBNtxt.Name = "bookISBNtxt";
            this.bookISBNtxt.Size = new System.Drawing.Size(191, 22);
            this.bookISBNtxt.TabIndex = 6;
            this.bookISBNtxt.Text = "Book ISBN";
            // 
            // addStudyBookbutton
            // 
            this.addStudyBookbutton.Location = new System.Drawing.Point(25, 223);
            this.addStudyBookbutton.Name = "addStudyBookbutton";
            this.addStudyBookbutton.Size = new System.Drawing.Size(191, 23);
            this.addStudyBookbutton.TabIndex = 7;
            this.addStudyBookbutton.Text = "ADD STUDY BOOK";
            this.addStudyBookbutton.UseVisualStyleBackColor = true;
            this.addStudyBookbutton.Click += new System.EventHandler(this.addStudyBookbutton_Click);
            // 
            // addResearchArticleButton
            // 
            this.addResearchArticleButton.Location = new System.Drawing.Point(22, 525);
            this.addResearchArticleButton.Name = "addResearchArticleButton";
            this.addResearchArticleButton.Size = new System.Drawing.Size(191, 23);
            this.addResearchArticleButton.TabIndex = 15;
            this.addResearchArticleButton.Text = "ADD RESEARCH ARTICLE";
            this.addResearchArticleButton.UseVisualStyleBackColor = true;
            this.addResearchArticleButton.Click += new System.EventHandler(this.addResearchArticleButton_Click);
            // 
            // articleDOItxt
            // 
            this.articleDOItxt.Location = new System.Drawing.Point(22, 441);
            this.articleDOItxt.Name = "articleDOItxt";
            this.articleDOItxt.Size = new System.Drawing.Size(191, 22);
            this.articleDOItxt.TabIndex = 14;
            this.articleDOItxt.Text = "DOI";
            // 
            // articlePublishedDateTxt
            // 
            this.articlePublishedDateTxt.Location = new System.Drawing.Point(22, 469);
            this.articlePublishedDateTxt.Name = "articlePublishedDateTxt";
            this.articlePublishedDateTxt.Size = new System.Drawing.Size(191, 22);
            this.articlePublishedDateTxt.TabIndex = 13;
            this.articlePublishedDateTxt.Text = "Published Date";
            // 
            // articleTitletxt
            // 
            this.articleTitletxt.Location = new System.Drawing.Point(22, 329);
            this.articleTitletxt.Name = "articleTitletxt";
            this.articleTitletxt.Size = new System.Drawing.Size(191, 22);
            this.articleTitletxt.TabIndex = 12;
            this.articleTitletxt.Text = "Article Title";
            // 
            // articleAuthorTxt
            // 
            this.articleAuthorTxt.Location = new System.Drawing.Point(22, 357);
            this.articleAuthorTxt.Name = "articleAuthorTxt";
            this.articleAuthorTxt.Size = new System.Drawing.Size(191, 22);
            this.articleAuthorTxt.TabIndex = 11;
            this.articleAuthorTxt.Text = "Article Author";
            // 
            // articlePublisherTxt
            // 
            this.articlePublisherTxt.Location = new System.Drawing.Point(22, 385);
            this.articlePublisherTxt.Name = "articlePublisherTxt";
            this.articlePublisherTxt.Size = new System.Drawing.Size(191, 22);
            this.articlePublisherTxt.TabIndex = 10;
            this.articlePublisherTxt.Text = "Article Publisher";
            // 
            // articleQuantityTxt
            // 
            this.articleQuantityTxt.Location = new System.Drawing.Point(22, 413);
            this.articleQuantityTxt.Name = "articleQuantityTxt";
            this.articleQuantityTxt.Size = new System.Drawing.Size(191, 22);
            this.articleQuantityTxt.TabIndex = 9;
            this.articleQuantityTxt.Text = "Article Quantity";
            // 
            // articleIDtxt
            // 
            this.articleIDtxt.Location = new System.Drawing.Point(22, 301);
            this.articleIDtxt.Name = "articleIDtxt";
            this.articleIDtxt.Size = new System.Drawing.Size(191, 22);
            this.articleIDtxt.TabIndex = 8;
            this.articleIDtxt.Text = "Article ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "STUDY BOOK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "RESEARCH ARTICLE";
            // 
            // ConOrJournalTxt
            // 
            this.ConOrJournalTxt.Location = new System.Drawing.Point(22, 497);
            this.ConOrJournalTxt.Name = "ConOrJournalTxt";
            this.ConOrJournalTxt.Size = new System.Drawing.Size(191, 22);
            this.ConOrJournalTxt.TabIndex = 18;
            this.ConOrJournalTxt.Text = "Conference/Journal";
            // 
            // bookIDinSearchTxt
            // 
            this.bookIDinSearchTxt.Location = new System.Drawing.Point(311, 34);
            this.bookIDinSearchTxt.Name = "bookIDinSearchTxt";
            this.bookIDinSearchTxt.Size = new System.Drawing.Size(125, 22);
            this.bookIDinSearchTxt.TabIndex = 19;
            this.bookIDinSearchTxt.Text = "Book ID";
            // 
            // articleIDinSearchTxt
            // 
            this.articleIDinSearchTxt.Location = new System.Drawing.Point(311, 166);
            this.articleIDinSearchTxt.Name = "articleIDinSearchTxt";
            this.articleIDinSearchTxt.Size = new System.Drawing.Size(125, 22);
            this.articleIDinSearchTxt.TabIndex = 20;
            this.articleIDinSearchTxt.Text = "Article ID";
            // 
            // bookBorrowButton
            // 
            this.bookBorrowButton.Location = new System.Drawing.Point(311, 62);
            this.bookBorrowButton.Name = "bookBorrowButton";
            this.bookBorrowButton.Size = new System.Drawing.Size(125, 23);
            this.bookBorrowButton.TabIndex = 21;
            this.bookBorrowButton.Text = "BORROW";
            this.bookBorrowButton.UseVisualStyleBackColor = true;
            this.bookBorrowButton.Click += new System.EventHandler(this.bookBorrowButton_Click);
            // 
            // articleBorrowButton
            // 
            this.articleBorrowButton.Location = new System.Drawing.Point(311, 194);
            this.articleBorrowButton.Name = "articleBorrowButton";
            this.articleBorrowButton.Size = new System.Drawing.Size(125, 23);
            this.articleBorrowButton.TabIndex = 22;
            this.articleBorrowButton.Text = "BORROW";
            this.articleBorrowButton.UseVisualStyleBackColor = true;
            this.articleBorrowButton.Click += new System.EventHandler(this.articleBorrowButton_Click);
            // 
            // showArticleButtton
            // 
            this.showArticleButtton.Location = new System.Drawing.Point(311, 413);
            this.showArticleButtton.Name = "showArticleButtton";
            this.showArticleButtton.Size = new System.Drawing.Size(164, 23);
            this.showArticleButtton.TabIndex = 23;
            this.showArticleButtton.Text = "SHOW ARTICLE";
            this.showArticleButtton.UseVisualStyleBackColor = true;
            this.showArticleButtton.Click += new System.EventHandler(this.showArticleButtton_Click);
            // 
            // showBookButton
            // 
            this.showBookButton.Location = new System.Drawing.Point(311, 384);
            this.showBookButton.Name = "showBookButton";
            this.showBookButton.Size = new System.Drawing.Size(164, 23);
            this.showBookButton.TabIndex = 24;
            this.showBookButton.Text = "SHOW BOOK";
            this.showBookButton.UseVisualStyleBackColor = true;
            this.showBookButton.Click += new System.EventHandler(this.showBookButton_Click);
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 16;
            this.bookListBox.Location = new System.Drawing.Point(549, 34);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(508, 212);
            this.bookListBox.TabIndex = 25;
            // 
            // articleListBox
            // 
            this.articleListBox.FormattingEnabled = true;
            this.articleListBox.ItemHeight = 16;
            this.articleListBox.Location = new System.Drawing.Point(549, 307);
            this.articleListBox.Name = "articleListBox";
            this.articleListBox.Size = new System.Drawing.Size(508, 212);
            this.articleListBox.TabIndex = 26;
            this.articleListBox.SelectedIndexChanged += new System.EventHandler(this.articleListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 554);
            this.Controls.Add(this.articleListBox);
            this.Controls.Add(this.bookListBox);
            this.Controls.Add(this.showBookButton);
            this.Controls.Add(this.showArticleButtton);
            this.Controls.Add(this.articleBorrowButton);
            this.Controls.Add(this.bookBorrowButton);
            this.Controls.Add(this.articleIDinSearchTxt);
            this.Controls.Add(this.bookIDinSearchTxt);
            this.Controls.Add(this.ConOrJournalTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addResearchArticleButton);
            this.Controls.Add(this.articleDOItxt);
            this.Controls.Add(this.articlePublishedDateTxt);
            this.Controls.Add(this.articleTitletxt);
            this.Controls.Add(this.articleAuthorTxt);
            this.Controls.Add(this.articlePublisherTxt);
            this.Controls.Add(this.articleQuantityTxt);
            this.Controls.Add(this.articleIDtxt);
            this.Controls.Add(this.addStudyBookbutton);
            this.Controls.Add(this.bookISBNtxt);
            this.Controls.Add(this.bookGenreTxt);
            this.Controls.Add(this.bookTitleTxt);
            this.Controls.Add(this.bookAuthorTxt);
            this.Controls.Add(this.bookPublisherTxt);
            this.Controls.Add(this.bookQuantityTxt);
            this.Controls.Add(this.bookIDtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookIDtxt;
        private System.Windows.Forms.TextBox bookQuantityTxt;
        private System.Windows.Forms.TextBox bookPublisherTxt;
        private System.Windows.Forms.TextBox bookAuthorTxt;
        private System.Windows.Forms.TextBox bookTitleTxt;
        private System.Windows.Forms.TextBox bookGenreTxt;
        private System.Windows.Forms.TextBox bookISBNtxt;
        private System.Windows.Forms.Button addStudyBookbutton;
        private System.Windows.Forms.Button addResearchArticleButton;
        private System.Windows.Forms.TextBox articleDOItxt;
        private System.Windows.Forms.TextBox articlePublishedDateTxt;
        private System.Windows.Forms.TextBox articleTitletxt;
        private System.Windows.Forms.TextBox articleAuthorTxt;
        private System.Windows.Forms.TextBox articlePublisherTxt;
        private System.Windows.Forms.TextBox articleQuantityTxt;
        private System.Windows.Forms.TextBox articleIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConOrJournalTxt;
        private System.Windows.Forms.TextBox bookIDinSearchTxt;
        private System.Windows.Forms.TextBox articleIDinSearchTxt;
        private System.Windows.Forms.Button bookBorrowButton;
        private System.Windows.Forms.Button articleBorrowButton;
        private System.Windows.Forms.Button showArticleButtton;
        private System.Windows.Forms.Button showBookButton;
        private System.Windows.Forms.ListBox bookListBox;
        private System.Windows.Forms.ListBox articleListBox;
    }
}

