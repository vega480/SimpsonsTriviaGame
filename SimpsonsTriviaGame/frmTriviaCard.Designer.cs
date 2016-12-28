namespace SimpsonsTriviaGame
{
    partial class frmTriviaCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriviaCard));
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.grpBxSelections = new System.Windows.Forms.GroupBox();
            this.radOption3F = new System.Windows.Forms.RadioButton();
            this.radOption2 = new System.Windows.Forms.RadioButton();
            this.radOption1T = new System.Windows.Forms.RadioButton();
            this.txtEntryResult = new System.Windows.Forms.TextBox();
            this.lblEntryResult = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.prgBarQuestions = new System.Windows.Forms.ProgressBar();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.grpBxSelections.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.Gold;
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(13, 13);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(259, 101);
            this.txtQuestion.TabIndex = 5;
            this.txtQuestion.TabStop = false;
            // 
            // grpBxSelections
            // 
            this.grpBxSelections.BackColor = System.Drawing.Color.Transparent;
            this.grpBxSelections.Controls.Add(this.radOption3F);
            this.grpBxSelections.Controls.Add(this.radOption2);
            this.grpBxSelections.Controls.Add(this.radOption1T);
            this.grpBxSelections.ForeColor = System.Drawing.Color.Black;
            this.grpBxSelections.Location = new System.Drawing.Point(278, 12);
            this.grpBxSelections.Name = "grpBxSelections";
            this.grpBxSelections.Size = new System.Drawing.Size(259, 93);
            this.grpBxSelections.TabIndex = 1;
            this.grpBxSelections.TabStop = false;
            this.grpBxSelections.Text = "Select Answer:";
            // 
            // radOption3F
            // 
            this.radOption3F.AutoSize = true;
            this.radOption3F.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.Yellow_Dot;
            this.radOption3F.Location = new System.Drawing.Point(7, 68);
            this.radOption3F.Name = "radOption3F";
            this.radOption3F.Size = new System.Drawing.Size(105, 17);
            this.radOption3F.TabIndex = 2;
            this.radOption3F.TabStop = true;
            this.radOption3F.Text = "Option 3 or False";
            this.radOption3F.UseVisualStyleBackColor = true;
            // 
            // radOption2
            // 
            this.radOption2.AutoSize = true;
            this.radOption2.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.Yellow_Dot;
            this.radOption2.Location = new System.Drawing.Point(7, 44);
            this.radOption2.Name = "radOption2";
            this.radOption2.Size = new System.Drawing.Size(65, 17);
            this.radOption2.TabIndex = 1;
            this.radOption2.TabStop = true;
            this.radOption2.Text = "Option 2";
            this.radOption2.UseVisualStyleBackColor = true;
            // 
            // radOption1T
            // 
            this.radOption1T.AutoSize = true;
            this.radOption1T.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.Yellow_Dot;
            this.radOption1T.Location = new System.Drawing.Point(7, 20);
            this.radOption1T.Name = "radOption1T";
            this.radOption1T.Size = new System.Drawing.Size(102, 17);
            this.radOption1T.TabIndex = 0;
            this.radOption1T.TabStop = true;
            this.radOption1T.Text = "Option 1 or True";
            this.radOption1T.UseVisualStyleBackColor = true;
            // 
            // txtEntryResult
            // 
            this.txtEntryResult.Location = new System.Drawing.Point(278, 135);
            this.txtEntryResult.Name = "txtEntryResult";
            this.txtEntryResult.Size = new System.Drawing.Size(259, 20);
            this.txtEntryResult.TabIndex = 4;
            // 
            // lblEntryResult
            // 
            this.lblEntryResult.AutoSize = true;
            this.lblEntryResult.BackColor = System.Drawing.Color.Transparent;
            this.lblEntryResult.Location = new System.Drawing.Point(279, 116);
            this.lblEntryResult.Name = "lblEntryResult";
            this.lblEntryResult.Size = new System.Drawing.Size(95, 13);
            this.lblEntryResult.TabIndex = 3;
            this.lblEntryResult.Text = "Enter your answer:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Yellow;
            this.btnSubmit.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.Yellow_Dot;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(278, 161);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // prgBarQuestions
            // 
            this.prgBarQuestions.ForeColor = System.Drawing.Color.Blue;
            this.prgBarQuestions.Location = new System.Drawing.Point(13, 168);
            this.prgBarQuestions.Name = "prgBarQuestions";
            this.prgBarQuestions.Size = new System.Drawing.Size(259, 10);
            this.prgBarQuestions.TabIndex = 5;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.Transparent;
            this.lblResults.Location = new System.Drawing.Point(359, 166);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(80, 13);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Total Correct: 0";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.BackColor = System.Drawing.Color.Gold;
            this.txtCorrectAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.Location = new System.Drawing.Point(13, 116);
            this.txtCorrectAnswer.Multiline = true;
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.ReadOnly = true;
            this.txtCorrectAnswer.Size = new System.Drawing.Size(259, 46);
            this.txtCorrectAnswer.TabIndex = 9;
            this.txtCorrectAnswer.TabStop = false;
            // 
            // frmTriviaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.Simpsons_on_Couch_Wide;
            this.ClientSize = new System.Drawing.Size(550, 191);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.prgBarQuestions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEntryResult);
            this.Controls.Add(this.txtEntryResult);
            this.Controls.Add(this.grpBxSelections);
            this.Controls.Add(this.txtQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTriviaCard";
            this.Text = "The Simpsons Trivia Question: ";
            this.Load += new System.EventHandler(this.frmTriviaCard_Load);
            this.grpBxSelections.ResumeLayout(false);
            this.grpBxSelections.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox grpBxSelections;
        private System.Windows.Forms.RadioButton radOption3F;
        private System.Windows.Forms.RadioButton radOption2;
        private System.Windows.Forms.RadioButton radOption1T;
        private System.Windows.Forms.TextBox txtEntryResult;
        private System.Windows.Forms.Label lblEntryResult;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ProgressBar prgBarQuestions;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
    }
}