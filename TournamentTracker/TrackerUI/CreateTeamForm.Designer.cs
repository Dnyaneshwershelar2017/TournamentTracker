
namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameTxt = new System.Windows.Forms.TextBox();
            this.teamNameLable = new System.Windows.Forms.Label();
            this.headerLable = new System.Windows.Forms.Label();
            this.selectTeamMemberLable = new System.Windows.Forms.Label();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.mobileLable = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLable = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameTxt
            // 
            this.teamNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameTxt.Location = new System.Drawing.Point(35, 115);
            this.teamNameTxt.Name = "teamNameTxt";
            this.teamNameTxt.Size = new System.Drawing.Size(289, 29);
            this.teamNameTxt.TabIndex = 12;
            // 
            // teamNameLable
            // 
            this.teamNameLable.AutoSize = true;
            this.teamNameLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamNameLable.Location = new System.Drawing.Point(26, 75);
            this.teamNameLable.Name = "teamNameLable";
            this.teamNameLable.Size = new System.Drawing.Size(157, 37);
            this.teamNameLable.TabIndex = 11;
            this.teamNameLable.Text = "Team Name";
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.headerLable.Location = new System.Drawing.Point(26, 27);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(187, 40);
            this.headerLable.TabIndex = 10;
            this.headerLable.Text = "Create Team";
            // 
            // selectTeamMemberLable
            // 
            this.selectTeamMemberLable.AutoSize = true;
            this.selectTeamMemberLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.selectTeamMemberLable.Location = new System.Drawing.Point(26, 174);
            this.selectTeamMemberLable.Name = "selectTeamMemberLable";
            this.selectTeamMemberLable.Size = new System.Drawing.Size(263, 37);
            this.selectTeamMemberLable.TabIndex = 14;
            this.selectTeamMemberLable.Text = "Select Team Member";
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(35, 214);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(289, 33);
            this.selectTeamMemberDropDown.TabIndex = 13;
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addMemberButton.Location = new System.Drawing.Point(101, 288);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(162, 45);
            this.addMemberButton.TabIndex = 15;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.mobileTxt);
            this.addNewMemberGroupBox.Controls.Add(this.mobileLable);
            this.addNewMemberGroupBox.Controls.Add(this.emailTxt);
            this.addNewMemberGroupBox.Controls.Add(this.emailLable);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameTxt);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLable);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameTxt);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLable);
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(35, 377);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(289, 295);
            this.addNewMemberGroupBox.TabIndex = 16;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createMemberButton.Location = new System.Drawing.Point(55, 237);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(189, 39);
            this.createMemberButton.TabIndex = 17;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // mobileTxt
            // 
            this.mobileTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mobileTxt.Location = new System.Drawing.Point(118, 192);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(165, 29);
            this.mobileTxt.TabIndex = 16;
            // 
            // mobileLable
            // 
            this.mobileLable.AutoSize = true;
            this.mobileLable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mobileLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mobileLable.Location = new System.Drawing.Point(12, 192);
            this.mobileLable.Name = "mobileLable";
            this.mobileLable.Size = new System.Drawing.Size(71, 25);
            this.mobileLable.TabIndex = 15;
            this.mobileLable.Text = "Mobile";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxt.Location = new System.Drawing.Point(117, 144);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(165, 29);
            this.emailTxt.TabIndex = 14;
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.emailLable.Location = new System.Drawing.Point(11, 144);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(58, 25);
            this.emailLable.TabIndex = 13;
            this.emailLable.Text = "Email";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTxt.Location = new System.Drawing.Point(118, 97);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(165, 29);
            this.lastNameTxt.TabIndex = 12;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lastNameLable.Location = new System.Drawing.Point(12, 97);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(100, 25);
            this.lastNameLable.TabIndex = 11;
            this.lastNameLable.Text = "Last Name";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTxt.Location = new System.Drawing.Point(118, 45);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(165, 29);
            this.firstNameTxt.TabIndex = 10;
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.firstNameLable.Location = new System.Drawing.Point(12, 45);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(102, 25);
            this.firstNameLable.TabIndex = 9;
            this.firstNameLable.Text = "First Name";
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(614, 322);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(134, 75);
            this.deleteSelectedMemberButton.TabIndex = 20;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 23;
            this.teamMembersListBox.Location = new System.Drawing.Point(364, 113);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(244, 554);
            this.teamMembersListBox.TabIndex = 19;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createTeamButton.Location = new System.Drawing.Point(285, 692);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(162, 45);
            this.createTeamButton.TabIndex = 21;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 749);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberLable);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.teamNameTxt);
            this.Controls.Add(this.teamNameLable);
            this.Controls.Add(this.headerLable);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameTxt;
        private System.Windows.Forms.Label teamNameLable;
        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Label selectTeamMemberLable;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label firstNameLable;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLable;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.Label mobileLable;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button createTeamButton;
    }
}