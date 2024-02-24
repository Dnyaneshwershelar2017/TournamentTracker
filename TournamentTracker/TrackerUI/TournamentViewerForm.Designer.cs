
namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLable = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLable = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyLable = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLable = new System.Windows.Forms.Label();
            this.teamOneScoreTxt = new System.Windows.Forms.TextBox();
            this.teamTwoScoreTxt = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLable = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.vsLable = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.headerLable.Location = new System.Drawing.Point(33, 28);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(193, 40);
            this.headerLable.TabIndex = 0;
            this.headerLable.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tournamentName.Location = new System.Drawing.Point(232, 30);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(110, 37);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLable
            // 
            this.roundLable.AutoSize = true;
            this.roundLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.roundLable.Location = new System.Drawing.Point(33, 95);
            this.roundLable.Name = "roundLable";
            this.roundLable.Size = new System.Drawing.Size(94, 37);
            this.roundLable.TabIndex = 2;
            this.roundLable.Text = "Round";
            this.roundLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundDropDown
            // 
            this.roundDropDown.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(139, 99);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(209, 33);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyLable
            // 
            this.unplayedOnlyLable.AutoSize = true;
            this.unplayedOnlyLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedOnlyLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.unplayedOnlyLable.Location = new System.Drawing.Point(139, 142);
            this.unplayedOnlyLable.Name = "unplayedOnlyLable";
            this.unplayedOnlyLable.Size = new System.Drawing.Size(209, 41);
            this.unplayedOnlyLable.TabIndex = 4;
            this.unplayedOnlyLable.Text = "Unplayed Only";
            this.unplayedOnlyLable.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(33, 189);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(315, 272);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamOneName.Location = new System.Drawing.Point(382, 189);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(165, 37);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLable
            // 
            this.teamOneScoreLable.AutoSize = true;
            this.teamOneScoreLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScoreLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamOneScoreLable.Location = new System.Drawing.Point(382, 244);
            this.teamOneScoreLable.Name = "teamOneScoreLable";
            this.teamOneScoreLable.Size = new System.Drawing.Size(82, 37);
            this.teamOneScoreLable.TabIndex = 7;
            this.teamOneScoreLable.Text = "Score";
            this.teamOneScoreLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // teamOneScoreTxt
            // 
            this.teamOneScoreTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScoreTxt.Location = new System.Drawing.Point(470, 248);
            this.teamOneScoreTxt.Name = "teamOneScoreTxt";
            this.teamOneScoreTxt.Size = new System.Drawing.Size(100, 33);
            this.teamOneScoreTxt.TabIndex = 8;
            // 
            // teamTwoScoreTxt
            // 
            this.teamTwoScoreTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreTxt.Location = new System.Drawing.Point(470, 420);
            this.teamTwoScoreTxt.Name = "teamTwoScoreTxt";
            this.teamTwoScoreTxt.Size = new System.Drawing.Size(100, 33);
            this.teamTwoScoreTxt.TabIndex = 11;
            // 
            // teamTwoScoreLable
            // 
            this.teamTwoScoreLable.AutoSize = true;
            this.teamTwoScoreLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamTwoScoreLable.Location = new System.Drawing.Point(382, 416);
            this.teamTwoScoreLable.Name = "teamTwoScoreLable";
            this.teamTwoScoreLable.Size = new System.Drawing.Size(82, 37);
            this.teamTwoScoreLable.TabIndex = 10;
            this.teamTwoScoreLable.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamTwoName.Location = new System.Drawing.Point(382, 361);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(165, 37);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<team one>";
            // 
            // vsLable
            // 
            this.vsLable.AutoSize = true;
            this.vsLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.vsLable.Location = new System.Drawing.Point(470, 303);
            this.vsLable.Name = "vsLable";
            this.vsLable.Size = new System.Drawing.Size(70, 37);
            this.vsLable.TabIndex = 12;
            this.vsLable.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Location = new System.Drawing.Point(603, 302);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(96, 45);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 518);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLable);
            this.Controls.Add(this.teamTwoScoreTxt);
            this.Controls.Add(this.teamTwoScoreLable);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreTxt);
            this.Controls.Add(this.teamOneScoreLable);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyLable);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLable);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLable);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLable;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyLable;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScoreLable;
        private System.Windows.Forms.TextBox teamOneScoreTxt;
        private System.Windows.Forms.TextBox teamTwoScoreTxt;
        private System.Windows.Forms.Label teamTwoScoreLable;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label vsLable;
        private System.Windows.Forms.Button scoreButton;
    }
}

