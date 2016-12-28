namespace SimpsonsTriviaGame
{
    partial class frmSimpsonsTrivia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimpsonsTrivia));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxGameType = new System.Windows.Forms.GroupBox();
            this.radMix = new System.Windows.Forms.RadioButton();
            this.radTrueOrFalse = new System.Windows.Forms.RadioButton();
            this.radSingleAnswer = new System.Windows.Forms.RadioButton();
            this.radMultiChoice = new System.Windows.Forms.RadioButton();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.grpBxNumOfQuestions = new System.Windows.Forms.GroupBox();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radRandom = new System.Windows.Forms.RadioButton();
            this.rad75 = new System.Windows.Forms.RadioButton();
            this.rad25 = new System.Windows.Forms.RadioButton();
            this.rad50 = new System.Windows.Forms.RadioButton();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.grpBxGameType.SuspendLayout();
            this.grpBxNumOfQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.Yellow_Dot;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.Yellow_Dot;
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.Yellow_Dot;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpBxGameType
            // 
            this.grpBxGameType.BackColor = System.Drawing.Color.Transparent;
            this.grpBxGameType.Controls.Add(this.radMix);
            this.grpBxGameType.Controls.Add(this.radTrueOrFalse);
            this.grpBxGameType.Controls.Add(this.radSingleAnswer);
            this.grpBxGameType.Controls.Add(this.radMultiChoice);
            this.grpBxGameType.ForeColor = System.Drawing.Color.White;
            this.grpBxGameType.Location = new System.Drawing.Point(15, 54);
            this.grpBxGameType.Name = "grpBxGameType";
            this.grpBxGameType.Size = new System.Drawing.Size(139, 114);
            this.grpBxGameType.TabIndex = 1;
            this.grpBxGameType.TabStop = false;
            this.grpBxGameType.Text = "Select Game Type";
            // 
            // radMix
            // 
            this.radMix.AutoSize = true;
            this.radMix.Checked = true;
            this.radMix.Location = new System.Drawing.Point(7, 92);
            this.radMix.Name = "radMix";
            this.radMix.Size = new System.Drawing.Size(67, 17);
            this.radMix.TabIndex = 3;
            this.radMix.TabStop = true;
            this.radMix.Text = "Mix of All";
            this.radMix.UseVisualStyleBackColor = true;
            this.radMix.CheckedChanged += new System.EventHandler(this.GameType);
            // 
            // radTrueOrFalse
            // 
            this.radTrueOrFalse.AutoSize = true;
            this.radTrueOrFalse.Location = new System.Drawing.Point(7, 68);
            this.radTrueOrFalse.Name = "radTrueOrFalse";
            this.radTrueOrFalse.Size = new System.Drawing.Size(87, 17);
            this.radTrueOrFalse.TabIndex = 2;
            this.radTrueOrFalse.Text = "True or False";
            this.radTrueOrFalse.UseVisualStyleBackColor = true;
            this.radTrueOrFalse.CheckedChanged += new System.EventHandler(this.GameType);
            // 
            // radSingleAnswer
            // 
            this.radSingleAnswer.AutoSize = true;
            this.radSingleAnswer.Location = new System.Drawing.Point(7, 44);
            this.radSingleAnswer.Name = "radSingleAnswer";
            this.radSingleAnswer.Size = new System.Drawing.Size(92, 17);
            this.radSingleAnswer.TabIndex = 1;
            this.radSingleAnswer.Text = "Single Answer";
            this.radSingleAnswer.UseVisualStyleBackColor = true;
            this.radSingleAnswer.CheckedChanged += new System.EventHandler(this.GameType);
            // 
            // radMultiChoice
            // 
            this.radMultiChoice.AutoSize = true;
            this.radMultiChoice.Location = new System.Drawing.Point(7, 20);
            this.radMultiChoice.Name = "radMultiChoice";
            this.radMultiChoice.Size = new System.Drawing.Size(97, 17);
            this.radMultiChoice.TabIndex = 0;
            this.radMultiChoice.Text = "Multiple Choice";
            this.radMultiChoice.UseVisualStyleBackColor = true;
            this.radMultiChoice.CheckedChanged += new System.EventHandler(this.GameType);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Yellow;
            this.btnNewGame.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.Yellow_Dot;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewGame.Location = new System.Drawing.Point(44, 252);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "Start Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // grpBxNumOfQuestions
            // 
            this.grpBxNumOfQuestions.BackColor = System.Drawing.Color.Transparent;
            this.grpBxNumOfQuestions.Controls.Add(this.radAll);
            this.grpBxNumOfQuestions.Controls.Add(this.radRandom);
            this.grpBxNumOfQuestions.Controls.Add(this.rad75);
            this.grpBxNumOfQuestions.Controls.Add(this.rad25);
            this.grpBxNumOfQuestions.Controls.Add(this.rad50);
            this.grpBxNumOfQuestions.Controls.Add(this.rad10);
            this.grpBxNumOfQuestions.ForeColor = System.Drawing.Color.White;
            this.grpBxNumOfQuestions.Location = new System.Drawing.Point(15, 175);
            this.grpBxNumOfQuestions.Name = "grpBxNumOfQuestions";
            this.grpBxNumOfQuestions.Size = new System.Drawing.Size(139, 71);
            this.grpBxNumOfQuestions.TabIndex = 3;
            this.grpBxNumOfQuestions.TabStop = false;
            this.grpBxNumOfQuestions.Text = "How Many?";
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(93, 44);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(44, 17);
            this.radAll.TabIndex = 5;
            this.radAll.Text = "ALL";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.HowManyQuestions);
            // 
            // radRandom
            // 
            this.radRandom.AutoSize = true;
            this.radRandom.Location = new System.Drawing.Point(93, 20);
            this.radRandom.Name = "radRandom";
            this.radRandom.Size = new System.Drawing.Size(43, 17);
            this.radRandom.TabIndex = 4;
            this.radRandom.Text = "???";
            this.radRandom.UseVisualStyleBackColor = true;
            this.radRandom.CheckedChanged += new System.EventHandler(this.HowManyQuestions);
            // 
            // rad75
            // 
            this.rad75.AutoSize = true;
            this.rad75.Location = new System.Drawing.Point(50, 44);
            this.rad75.Name = "rad75";
            this.rad75.Size = new System.Drawing.Size(45, 17);
            this.rad75.TabIndex = 3;
            this.rad75.Text = "75%";
            this.rad75.UseVisualStyleBackColor = true;
            this.rad75.CheckedChanged += new System.EventHandler(this.HowManyQuestions);
            // 
            // rad25
            // 
            this.rad25.AutoSize = true;
            this.rad25.Location = new System.Drawing.Point(50, 20);
            this.rad25.Name = "rad25";
            this.rad25.Size = new System.Drawing.Size(45, 17);
            this.rad25.TabIndex = 2;
            this.rad25.Text = "25%";
            this.rad25.UseVisualStyleBackColor = true;
            this.rad25.CheckedChanged += new System.EventHandler(this.HowManyQuestions);
            // 
            // rad50
            // 
            this.rad50.AutoSize = true;
            this.rad50.Location = new System.Drawing.Point(7, 44);
            this.rad50.Name = "rad50";
            this.rad50.Size = new System.Drawing.Size(45, 17);
            this.rad50.TabIndex = 1;
            this.rad50.Text = "50%";
            this.rad50.UseVisualStyleBackColor = true;
            this.rad50.CheckedChanged += new System.EventHandler(this.HowManyQuestions);
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Checked = true;
            this.rad10.Location = new System.Drawing.Point(7, 20);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(45, 17);
            this.rad10.TabIndex = 0;
            this.rad10.TabStop = true;
            this.rad10.Text = "10%";
            this.rad10.UseVisualStyleBackColor = true;
            this.rad10.CheckedChanged += new System.EventHandler(this.HowManyQuestions);
            // 
            // frmSimpsonsTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::SimpsonsTriviaGame.Properties.Resources.burns;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 296);
            this.Controls.Add(this.grpBxNumOfQuestions);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.grpBxGameType);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSimpsonsTrivia";
            this.Text = "The Simpsons Trivia Game";
            this.Load += new System.EventHandler(this.frmSimpsonsTrivia_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxGameType.ResumeLayout(false);
            this.grpBxGameType.PerformLayout();
            this.grpBxNumOfQuestions.ResumeLayout(false);
            this.grpBxNumOfQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBxGameType;
        private System.Windows.Forms.RadioButton radMix;
        private System.Windows.Forms.RadioButton radTrueOrFalse;
        private System.Windows.Forms.RadioButton radSingleAnswer;
        private System.Windows.Forms.RadioButton radMultiChoice;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.GroupBox grpBxNumOfQuestions;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radRandom;
        private System.Windows.Forms.RadioButton rad75;
        private System.Windows.Forms.RadioButton rad25;
        private System.Windows.Forms.RadioButton rad50;
        private System.Windows.Forms.RadioButton rad10;
    }
}

