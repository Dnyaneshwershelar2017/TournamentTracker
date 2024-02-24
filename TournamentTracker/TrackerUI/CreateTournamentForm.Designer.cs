
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerLable = new System.Windows.Forms.Label();
            this.tournamentNameLable = new System.Windows.Forms.Label();
            this.EntryFeeLable = new System.Windows.Forms.Label();
            this.tournamentNameTxt = new System.Windows.Forms.TextBox();
            this.entryFeeTxt = new System.Windows.Forms.TextBox();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLable = new System.Windows.Forms.Label();
            this.createNewLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.teamPlayersLable = new System.Windows.Forms.Label();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.prizesLable = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.headerLable.Location = new System.Drawing.Point(46, 36);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(282, 40);
            this.headerLable.TabIndex = 1;
            this.headerLable.Text = "Create Tournament";
            // 
            // tournamentNameLable
            // 
            this.tournamentNameLable.AutoSize = true;
            this.tournamentNameLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tournamentNameLable.Location = new System.Drawing.Point(46, 114);
            this.tournamentNameLable.Name = "tournamentNameLable";
            this.tournamentNameLable.Size = new System.Drawing.Size(236, 37);
            this.tournamentNameLable.TabIndex = 3;
            this.tournamentNameLable.Text = "Tournament Name";
            // 
            // EntryFeeLable
            // 
            this.EntryFeeLable.AutoSize = true;
            this.EntryFeeLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.EntryFeeLable.Location = new System.Drawing.Point(46, 210);
            this.EntryFeeLable.Name = "EntryFeeLable";
            this.EntryFeeLable.Size = new System.Drawing.Size(125, 37);
            this.EntryFeeLable.TabIndex = 4;
            this.EntryFeeLable.Text = "Entry Fee";
            // 
            // tournamentNameTxt
            // 
            this.tournamentNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameTxt.Location = new System.Drawing.Point(55, 154);
            this.tournamentNameTxt.Name = "tournamentNameTxt";
            this.tournamentNameTxt.Size = new System.Drawing.Size(289, 29);
            this.tournamentNameTxt.TabIndex = 9;
            // 
            // entryFeeTxt
            // 
            this.entryFeeTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeTxt.Location = new System.Drawing.Point(177, 218);
            this.entryFeeTxt.Name = "entryFeeTxt";
            this.entryFeeTxt.Size = new System.Drawing.Size(105, 29);
            this.entryFeeTxt.TabIndex = 10;
            this.entryFeeTxt.Text = "0";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(55, 315);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(289, 33);
            this.selectTeamDropDown.TabIndex = 11;
            // 
            // selectTeamLable
            // 
            this.selectTeamLable.AutoSize = true;
            this.selectTeamLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.selectTeamLable.Location = new System.Drawing.Point(46, 275);
            this.selectTeamLable.Name = "selectTeamLable";
            this.selectTeamLable.Size = new System.Drawing.Size(156, 37);
            this.selectTeamLable.TabIndex = 12;
            this.selectTeamLable.Text = "Select Team";
            // 
            // createNewLink
            // 
            this.createNewLink.AutoSize = true;
            this.createNewLink.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewLink.Location = new System.Drawing.Point(245, 287);
            this.createNewLink.Name = "createNewLink";
            this.createNewLink.Size = new System.Drawing.Size(99, 23);
            this.createNewLink.TabIndex = 13;
            this.createNewLink.TabStop = true;
            this.createNewLink.Text = "Create New";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Location = new System.Drawing.Point(148, 374);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(134, 45);
            this.addTeamButton.TabIndex = 14;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Location = new System.Drawing.Point(148, 451);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(134, 45);
            this.createPrizeButton.TabIndex = 15;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // teamPlayersLable
            // 
            this.teamPlayersLable.AutoSize = true;
            this.teamPlayersLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamPlayersLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamPlayersLable.Location = new System.Drawing.Point(388, 114);
            this.teamPlayersLable.Name = "teamPlayersLable";
            this.teamPlayersLable.Size = new System.Drawing.Size(198, 37);
            this.teamPlayersLable.TabIndex = 16;
            this.teamPlayersLable.Text = "Teams / Players";
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 23;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(388, 154);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(271, 140);
            this.tournamentPlayersListBox.TabIndex = 17;
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(665, 192);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(134, 75);
            this.deleteSelectedPlayerButton.TabIndex = 18;
            this.deleteSelectedPlayerButton.Text = "Delete Selected";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(665, 408);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(134, 74);
            this.deleteSelectedPrizeButton.TabIndex = 21;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 23;
            this.prizesListBox.Location = new System.Drawing.Point(388, 374);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(271, 140);
            this.prizesListBox.TabIndex = 20;
            // 
            // prizesLable
            // 
            this.prizesLable.AutoSize = true;
            this.prizesLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.prizesLable.Location = new System.Drawing.Point(388, 334);
            this.prizesLable.Name = "prizesLable";
            this.prizesLable.Size = new System.Drawing.Size(198, 37);
            this.prizesLable.TabIndex = 19;
            this.prizesLable.Text = "Teams / Players";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Location = new System.Drawing.Point(301, 575);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(221, 45);
            this.createTournamentButton.TabIndex = 22;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 642);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.prizesLable);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.teamPlayersLable);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewLink);
            this.Controls.Add(this.selectTeamLable);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.entryFeeTxt);
            this.Controls.Add(this.tournamentNameTxt);
            this.Controls.Add(this.EntryFeeLable);
            this.Controls.Add(this.tournamentNameLable);
            this.Controls.Add(this.headerLable);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournament";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Label tournamentNameLable;
        private System.Windows.Forms.Label EntryFeeLable;
        private System.Windows.Forms.TextBox tournamentNameTxt;
        private System.Windows.Forms.TextBox entryFeeTxt;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLable;
        private System.Windows.Forms.LinkLabel createNewLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label teamPlayersLable;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Button deleteSelectedPlayerButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Label prizesLable;
        private System.Windows.Forms.Button createTournamentButton;
    }
}