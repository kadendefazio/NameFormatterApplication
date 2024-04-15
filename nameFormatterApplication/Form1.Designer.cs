namespace nameFormatterApplication
{
    partial class nameFormatterApplication
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
            components = new System.ComponentModel.Container();
            userFirstNameLabel = new Label();
            userLastNameLabel = new Label();
            userMiddleNameLabel = new Label();
            userPreferredTitleLabel = new Label();
            userFirstNameTextBox = new TextBox();
            userMiddleNameTextBox = new TextBox();
            userLastNameTextBox = new TextBox();
            userPreferredTitleTextBox = new TextBox();
            userInfoAllTogetherButton = new Button();
            exitButton = new Button();
            imageList1 = new ImageList(components);
            formattedNamesLabel = new Label();
            SuspendLayout();
            // 
            // userFirstNameLabel
            // 
            userFirstNameLabel.AutoSize = true;
            userFirstNameLabel.Location = new Point(12, 48);
            userFirstNameLabel.Name = "userFirstNameLabel";
            userFirstNameLabel.Size = new Size(156, 15);
            userFirstNameLabel.TabIndex = 0;
            userFirstNameLabel.Text = "Please enter your first name:";
            // 
            // userLastNameLabel
            // 
            userLastNameLabel.AutoSize = true;
            userLastNameLabel.Location = new Point(12, 153);
            userLastNameLabel.Name = "userLastNameLabel";
            userLastNameLabel.Size = new Size(154, 15);
            userLastNameLabel.TabIndex = 1;
            userLastNameLabel.Text = "Please enter your last name:";
            // 
            // userMiddleNameLabel
            // 
            userMiddleNameLabel.AutoSize = true;
            userMiddleNameLabel.Location = new Point(12, 102);
            userMiddleNameLabel.Name = "userMiddleNameLabel";
            userMiddleNameLabel.Size = new Size(173, 15);
            userMiddleNameLabel.TabIndex = 2;
            userMiddleNameLabel.Text = "Please enter your middle name:";
            // 
            // userPreferredTitleLabel
            // 
            userPreferredTitleLabel.AutoSize = true;
            userPreferredTitleLabel.Location = new Point(14, 216);
            userPreferredTitleLabel.Name = "userPreferredTitleLabel";
            userPreferredTitleLabel.Size = new Size(174, 15);
            userPreferredTitleLabel.TabIndex = 3;
            userPreferredTitleLabel.Text = "Please enter your preferred title:";
            // 
            // userFirstNameTextBox
            // 
            userFirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            userFirstNameTextBox.Location = new Point(174, 40);
            userFirstNameTextBox.Name = "userFirstNameTextBox";
            userFirstNameTextBox.Size = new Size(169, 23);
            userFirstNameTextBox.TabIndex = 5;
            userFirstNameTextBox.TextChanged += userFirstNameTextBox_TextChanged;
            // 
            // userMiddleNameTextBox
            // 
            userMiddleNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            userMiddleNameTextBox.Location = new Point(183, 94);
            userMiddleNameTextBox.Name = "userMiddleNameTextBox";
            userMiddleNameTextBox.Size = new Size(169, 23);
            userMiddleNameTextBox.TabIndex = 6;
            // 
            // userLastNameTextBox
            // 
            userLastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            userLastNameTextBox.Location = new Point(172, 145);
            userLastNameTextBox.Name = "userLastNameTextBox";
            userLastNameTextBox.Size = new Size(169, 23);
            userLastNameTextBox.TabIndex = 7;
            // 
            // userPreferredTitleTextBox
            // 
            userPreferredTitleTextBox.BorderStyle = BorderStyle.FixedSingle;
            userPreferredTitleTextBox.Location = new Point(194, 208);
            userPreferredTitleTextBox.Name = "userPreferredTitleTextBox";
            userPreferredTitleTextBox.Size = new Size(169, 23);
            userPreferredTitleTextBox.TabIndex = 8;
            // 
            // userInfoAllTogetherButton
            // 
            userInfoAllTogetherButton.Location = new Point(126, 467);
            userInfoAllTogetherButton.Name = "userInfoAllTogetherButton";
            userInfoAllTogetherButton.Size = new Size(103, 58);
            userInfoAllTogetherButton.TabIndex = 9;
            userInfoAllTogetherButton.Text = "Click to put your information all together";
            userInfoAllTogetherButton.UseVisualStyleBackColor = true;
            userInfoAllTogetherButton.Click += userInfoAllTogetherButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(266, 467);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 58);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // formattedNamesLabel
            // 
            formattedNamesLabel.BackColor = SystemColors.ControlLightLight;
            formattedNamesLabel.BorderStyle = BorderStyle.FixedSingle;
            formattedNamesLabel.Location = new Point(30, 261);
            formattedNamesLabel.Name = "formattedNamesLabel";
            formattedNamesLabel.Size = new Size(464, 185);
            formattedNamesLabel.TabIndex = 11;
            formattedNamesLabel.TextAlign = ContentAlignment.TopCenter;
            formattedNamesLabel.Click += formattedNamesLabel_Click;
            // 
            // nameFormatterApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 537);
            Controls.Add(formattedNamesLabel);
            Controls.Add(exitButton);
            Controls.Add(userInfoAllTogetherButton);
            Controls.Add(userPreferredTitleTextBox);
            Controls.Add(userLastNameTextBox);
            Controls.Add(userMiddleNameTextBox);
            Controls.Add(userFirstNameTextBox);
            Controls.Add(userPreferredTitleLabel);
            Controls.Add(userMiddleNameLabel);
            Controls.Add(userLastNameLabel);
            Controls.Add(userFirstNameLabel);
            Name = "nameFormatterApplication";
            Text = "Name Formatter Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userFirstNameLabel;
        private Label userLastNameLabel;
        private Label userMiddleNameLabel;
        private Label userPreferredTitleLabel;
        private TextBox userFirstNameTextBox;
        private TextBox userMiddleNameTextBox;
        private TextBox userLastNameTextBox;
        private TextBox userPreferredTitleTextBox;
        private Button userInfoAllTogetherButton;
        private Button exitButton;
        private ImageList imageList1;
        private Label formattedNamesLabel;
    }
}
