namespace CompetetionRegistry
{
    public partial class MainWindow
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
            HeadLabel = new Label();
            CompetitorsListBox = new ListBox();
            NametextBox = new TextBox();
            SurnametextBox = new TextBox();
            CategorytextBox = new TextBox();
            Insertbutton = new Button();
            UpdateNametextBox = new TextBox();
            UpdateSurnametextBox = new TextBox();
            UpdateCategorytextBox = new TextBox();
            Updatebutton = new Button();
            Deletebutton = new Button();
            Competitorslabel = new Label();
            NewComplabel = new Label();
            NewNamelabel = new Label();
            NewSurnamelabel = new Label();
            NewCategorylabel = new Label();
            EditCompetitorlabel = new Label();
            EditNamelabel = new Label();
            EditSurnamelabel = new Label();
            EditCategorylabel = new Label();
            SuspendLayout();
            // 
            // HeadLabel
            // 
            HeadLabel.AutoSize = true;
            HeadLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            HeadLabel.Location = new Point(20, 9);
            HeadLabel.Name = "HeadLabel";
            HeadLabel.Size = new Size(319, 32);
            HeadLabel.TabIndex = 0;
            HeadLabel.Text = "Competetition registration";
            // 
            // CompetitorsListBox
            // 
            CompetitorsListBox.FormattingEnabled = true;
            CompetitorsListBox.ItemHeight = 15;
            CompetitorsListBox.Location = new Point(20, 88);
            CompetitorsListBox.Name = "CompetitorsListBox";
            CompetitorsListBox.Size = new Size(278, 349);
            CompetitorsListBox.TabIndex = 1;
            CompetitorsListBox.Click += CompetitorsListBox_Click;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(487, 88);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(138, 23);
            NametextBox.TabIndex = 2;
            // 
            // SurnametextBox
            // 
            SurnametextBox.Location = new Point(487, 117);
            SurnametextBox.Name = "SurnametextBox";
            SurnametextBox.Size = new Size(138, 23);
            SurnametextBox.TabIndex = 3;
            // 
            // CategorytextBox
            // 
            CategorytextBox.Location = new Point(487, 146);
            CategorytextBox.Name = "CategorytextBox";
            CategorytextBox.Size = new Size(138, 23);
            CategorytextBox.TabIndex = 4;
            // 
            // Insertbutton
            // 
            Insertbutton.BackColor = Color.DarkSlateGray;
            Insertbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            Insertbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            Insertbutton.FlatStyle = FlatStyle.Flat;
            Insertbutton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Insertbutton.ForeColor = Color.White;
            Insertbutton.Location = new Point(631, 108);
            Insertbutton.Name = "Insertbutton";
            Insertbutton.Size = new Size(102, 39);
            Insertbutton.TabIndex = 5;
            Insertbutton.Text = "Add New";
            Insertbutton.UseVisualStyleBackColor = false;
            Insertbutton.Click += Insertbutton_Click_1;
            // 
            // UpdateNametextBox
            // 
            UpdateNametextBox.Location = new Point(487, 265);
            UpdateNametextBox.Name = "UpdateNametextBox";
            UpdateNametextBox.Size = new Size(138, 23);
            UpdateNametextBox.TabIndex = 6;
            // 
            // UpdateSurnametextBox
            // 
            UpdateSurnametextBox.Location = new Point(487, 294);
            UpdateSurnametextBox.Name = "UpdateSurnametextBox";
            UpdateSurnametextBox.Size = new Size(137, 23);
            UpdateSurnametextBox.TabIndex = 7;
            // 
            // UpdateCategorytextBox
            // 
            UpdateCategorytextBox.Location = new Point(487, 323);
            UpdateCategorytextBox.Name = "UpdateCategorytextBox";
            UpdateCategorytextBox.Size = new Size(137, 23);
            UpdateCategorytextBox.TabIndex = 8;
            // 
            // Updatebutton
            // 
            Updatebutton.BackColor = Color.DarkSlateGray;
            Updatebutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            Updatebutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            Updatebutton.FlatStyle = FlatStyle.Flat;
            Updatebutton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Updatebutton.ForeColor = Color.White;
            Updatebutton.Location = new Point(631, 265);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(102, 39);
            Updatebutton.TabIndex = 9;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = false;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.DarkSlateGray;
            Deletebutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            Deletebutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            Deletebutton.FlatStyle = FlatStyle.Flat;
            Deletebutton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Deletebutton.ForeColor = Color.White;
            Deletebutton.Location = new Point(631, 309);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(102, 37);
            Deletebutton.TabIndex = 10;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Competitorslabel
            // 
            Competitorslabel.AutoSize = true;
            Competitorslabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Competitorslabel.Location = new Point(20, 64);
            Competitorslabel.Name = "Competitorslabel";
            Competitorslabel.Size = new Size(106, 21);
            Competitorslabel.TabIndex = 11;
            Competitorslabel.Text = "Competitors:";
            // 
            // NewComplabel
            // 
            NewComplabel.AutoSize = true;
            NewComplabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NewComplabel.Location = new Point(344, 64);
            NewComplabel.Name = "NewComplabel";
            NewComplabel.Size = new Size(137, 21);
            NewComplabel.TabIndex = 12;
            NewComplabel.Text = "New Competitor:";
            // 
            // NewNamelabel
            // 
            NewNamelabel.AutoSize = true;
            NewNamelabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NewNamelabel.Location = new Point(344, 88);
            NewNamelabel.Name = "NewNamelabel";
            NewNamelabel.Size = new Size(57, 21);
            NewNamelabel.TabIndex = 13;
            NewNamelabel.Text = "Name:";
            // 
            // NewSurnamelabel
            // 
            NewSurnamelabel.AutoSize = true;
            NewSurnamelabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NewSurnamelabel.Location = new Point(344, 117);
            NewSurnamelabel.Name = "NewSurnamelabel";
            NewSurnamelabel.Size = new Size(78, 21);
            NewSurnamelabel.TabIndex = 14;
            NewSurnamelabel.Text = "Surname:";
            // 
            // NewCategorylabel
            // 
            NewCategorylabel.AutoSize = true;
            NewCategorylabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NewCategorylabel.Location = new Point(344, 146);
            NewCategorylabel.Name = "NewCategorylabel";
            NewCategorylabel.Size = new Size(82, 21);
            NewCategorylabel.TabIndex = 15;
            NewCategorylabel.Text = "Category:";
            // 
            // EditCompetitorlabel
            // 
            EditCompetitorlabel.AutoSize = true;
            EditCompetitorlabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditCompetitorlabel.Location = new Point(344, 236);
            EditCompetitorlabel.Name = "EditCompetitorlabel";
            EditCompetitorlabel.Size = new Size(132, 21);
            EditCompetitorlabel.TabIndex = 17;
            EditCompetitorlabel.Text = "Edit Competitor:";
            // 
            // EditNamelabel
            // 
            EditNamelabel.AutoSize = true;
            EditNamelabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditNamelabel.Location = new Point(344, 267);
            EditNamelabel.Name = "EditNamelabel";
            EditNamelabel.Size = new Size(57, 21);
            EditNamelabel.TabIndex = 18;
            EditNamelabel.Text = "Name:";
            // 
            // EditSurnamelabel
            // 
            EditSurnamelabel.AutoSize = true;
            EditSurnamelabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditSurnamelabel.Location = new Point(344, 296);
            EditSurnamelabel.Name = "EditSurnamelabel";
            EditSurnamelabel.Size = new Size(78, 21);
            EditSurnamelabel.TabIndex = 19;
            EditSurnamelabel.Text = "Surname:";
            // 
            // EditCategorylabel
            // 
            EditCategorylabel.AutoSize = true;
            EditCategorylabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditCategorylabel.Location = new Point(344, 325);
            EditCategorylabel.Name = "EditCategorylabel";
            EditCategorylabel.Size = new Size(82, 21);
            EditCategorylabel.TabIndex = 20;
            EditCategorylabel.Text = "Category:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(EditCategorylabel);
            Controls.Add(EditSurnamelabel);
            Controls.Add(EditNamelabel);
            Controls.Add(EditCompetitorlabel);
            Controls.Add(NewCategorylabel);
            Controls.Add(NewSurnamelabel);
            Controls.Add(NewNamelabel);
            Controls.Add(NewComplabel);
            Controls.Add(Competitorslabel);
            Controls.Add(Deletebutton);
            Controls.Add(Updatebutton);
            Controls.Add(UpdateCategorytextBox);
            Controls.Add(UpdateSurnametextBox);
            Controls.Add(UpdateNametextBox);
            Controls.Add(Insertbutton);
            Controls.Add(CategorytextBox);
            Controls.Add(SurnametextBox);
            Controls.Add(NametextBox);
            Controls.Add(CompetitorsListBox);
            Controls.Add(HeadLabel);
            Name = "MainWindow";
            Text = "Competetition Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label HeadLabel;
        private ListBox CompetitorsListBox;
        private TextBox NametextBox;
        private TextBox SurnametextBox;
        private TextBox CategorytextBox;
        private Button Insertbutton;
        private TextBox UpdateNametextBox;
        private TextBox UpdateSurnametextBox;
        private TextBox UpdateCategorytextBox;
        private Button Updatebutton;
        private Button Deletebutton;
        private Label Competitorslabel;
        private Label NewComplabel;
        private Label NewNamelabel;
        private Label NewSurnamelabel;
        private Label NewCategorylabel;
        private Label EditCompetitorlabel;
        private Label EditNamelabel;
        private Label EditSurnamelabel;
        private Label EditCategorylabel;
    }
}