﻿namespace QLearningMaze.Ui.Forms
{
    partial class MazeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeMain));
            this.entryPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sarsaRadio = new System.Windows.Forms.RadioButton();
            this.qLearningRadio = new System.Windows.Forms.RadioButton();
            this.rewardsLabelPrimary = new System.Windows.Forms.Label();
            this.runMazeButton = new System.Windows.Forms.Button();
            this.trainMazeButton = new System.Windows.Forms.Button();
            this.rewardsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.trainingEpisodesText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.discountRateText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.learningRateText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startPositionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.goalPositionText = new System.Windows.Forms.TextBox();
            this.columnsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rowsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mazeSpace = new QLearningMaze.Ui.Forms.MazeSpace();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewardsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mazeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runMazeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualityStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewardsLabelSecondary = new System.Windows.Forms.Label();
            this.entryPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.rewardsLabelSecondary);
            this.entryPanel.Controls.Add(this.groupBox1);
            this.entryPanel.Controls.Add(this.rewardsLabelPrimary);
            this.entryPanel.Controls.Add(this.runMazeButton);
            this.entryPanel.Controls.Add(this.trainMazeButton);
            this.entryPanel.Controls.Add(this.rewardsButton);
            this.entryPanel.Controls.Add(this.label7);
            this.entryPanel.Controls.Add(this.trainingEpisodesText);
            this.entryPanel.Controls.Add(this.label6);
            this.entryPanel.Controls.Add(this.discountRateText);
            this.entryPanel.Controls.Add(this.label5);
            this.entryPanel.Controls.Add(this.learningRateText);
            this.entryPanel.Controls.Add(this.label4);
            this.entryPanel.Controls.Add(this.startPositionText);
            this.entryPanel.Controls.Add(this.label3);
            this.entryPanel.Controls.Add(this.goalPositionText);
            this.entryPanel.Controls.Add(this.columnsText);
            this.entryPanel.Controls.Add(this.label2);
            this.entryPanel.Controls.Add(this.rowsText);
            this.entryPanel.Controls.Add(this.label1);
            this.entryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.entryPanel.Location = new System.Drawing.Point(0, 40);
            this.entryPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.entryPanel.Name = "entryPanel";
            this.entryPanel.Size = new System.Drawing.Size(1775, 274);
            this.entryPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sarsaRadio);
            this.groupBox1.Controls.Add(this.qLearningRadio);
            this.groupBox1.Location = new System.Drawing.Point(1275, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 148);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learning Style";
            // 
            // sarsaRadio
            // 
            this.sarsaRadio.AutoSize = true;
            this.sarsaRadio.Location = new System.Drawing.Point(7, 96);
            this.sarsaRadio.Name = "sarsaRadio";
            this.sarsaRadio.Size = new System.Drawing.Size(115, 36);
            this.sarsaRadio.TabIndex = 1;
            this.sarsaRadio.Text = "SARSA";
            this.sarsaRadio.UseVisualStyleBackColor = true;
            // 
            // qLearningRadio
            // 
            this.qLearningRadio.AutoSize = true;
            this.qLearningRadio.Checked = true;
            this.qLearningRadio.Location = new System.Drawing.Point(7, 39);
            this.qLearningRadio.Name = "qLearningRadio";
            this.qLearningRadio.Size = new System.Drawing.Size(165, 36);
            this.qLearningRadio.TabIndex = 0;
            this.qLearningRadio.TabStop = true;
            this.qLearningRadio.Text = "Q-Learning";
            this.qLearningRadio.UseVisualStyleBackColor = true;
            this.qLearningRadio.CheckedChanged += new System.EventHandler(this.qLearningRadio_CheckedChanged);
            // 
            // rewardsLabelPrimary
            // 
            this.rewardsLabelPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rewardsLabelPrimary.Location = new System.Drawing.Point(966, 148);
            this.rewardsLabelPrimary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rewardsLabelPrimary.Name = "rewardsLabelPrimary";
            this.rewardsLabelPrimary.Size = new System.Drawing.Size(678, 41);
            this.rewardsLabelPrimary.TabIndex = 16;
            this.rewardsLabelPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // runMazeButton
            // 
            this.runMazeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.runMazeButton.Location = new System.Drawing.Point(388, 206);
            this.runMazeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.runMazeButton.Name = "runMazeButton";
            this.runMazeButton.Size = new System.Drawing.Size(150, 47);
            this.runMazeButton.TabIndex = 9;
            this.runMazeButton.Text = "Run Maze";
            this.runMazeButton.UseVisualStyleBackColor = true;
            this.runMazeButton.Click += new System.EventHandler(this.runMaze_Click);
            // 
            // trainMazeButton
            // 
            this.trainMazeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trainMazeButton.Location = new System.Drawing.Point(195, 206);
            this.trainMazeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.trainMazeButton.Name = "trainMazeButton";
            this.trainMazeButton.Size = new System.Drawing.Size(150, 47);
            this.trainMazeButton.TabIndex = 8;
            this.trainMazeButton.Text = "Train";
            this.trainMazeButton.UseVisualStyleBackColor = true;
            this.trainMazeButton.Click += new System.EventHandler(this.trainMazeButton_Click);
            // 
            // rewardsButton
            // 
            this.rewardsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rewardsButton.Location = new System.Drawing.Point(13, 206);
            this.rewardsButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rewardsButton.Name = "rewardsButton";
            this.rewardsButton.Size = new System.Drawing.Size(150, 47);
            this.rewardsButton.TabIndex = 7;
            this.rewardsButton.Text = "Objectives";
            this.rewardsButton.UseVisualStyleBackColor = true;
            this.rewardsButton.Click += new System.EventHandler(this.rewardsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(945, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Training Episodes";
            // 
            // trainingEpisodesText
            // 
            this.trainingEpisodesText.Location = new System.Drawing.Point(1148, 70);
            this.trainingEpisodesText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.trainingEpisodesText.Name = "trainingEpisodesText";
            this.trainingEpisodesText.Size = new System.Drawing.Size(97, 39);
            this.trainingEpisodesText.TabIndex = 6;
            this.trainingEpisodesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.trainingEpisodesText.Leave += new System.EventHandler(this.trainingEpisodesText_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Discount Rate";
            // 
            // discountRateText
            // 
            this.discountRateText.Location = new System.Drawing.Point(539, 13);
            this.discountRateText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.discountRateText.Name = "discountRateText";
            this.discountRateText.Size = new System.Drawing.Size(58, 39);
            this.discountRateText.TabIndex = 2;
            this.discountRateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountRateText.Leave += new System.EventHandler(this.discountRateText_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Learning Rate";
            // 
            // learningRateText
            // 
            this.learningRateText.Location = new System.Drawing.Point(539, 70);
            this.learningRateText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.learningRateText.Name = "learningRateText";
            this.learningRateText.Size = new System.Drawing.Size(58, 39);
            this.learningRateText.TabIndex = 3;
            this.learningRateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.learningRateText.Leave += new System.EventHandler(this.learningRateText_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Position";
            // 
            // startPositionText
            // 
            this.startPositionText.Location = new System.Drawing.Point(843, 13);
            this.startPositionText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.startPositionText.Name = "startPositionText";
            this.startPositionText.Size = new System.Drawing.Size(58, 39);
            this.startPositionText.TabIndex = 4;
            this.startPositionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.startPositionText.Leave += new System.EventHandler(this.startPositionText_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Goal Position";
            // 
            // goalPositionText
            // 
            this.goalPositionText.Location = new System.Drawing.Point(843, 70);
            this.goalPositionText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.goalPositionText.Name = "goalPositionText";
            this.goalPositionText.Size = new System.Drawing.Size(58, 39);
            this.goalPositionText.TabIndex = 5;
            this.goalPositionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.goalPositionText.Leave += new System.EventHandler(this.goalPositionText_Leave);
            // 
            // columnsText
            // 
            this.columnsText.Location = new System.Drawing.Point(195, 70);
            this.columnsText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.columnsText.Name = "columnsText";
            this.columnsText.Size = new System.Drawing.Size(58, 39);
            this.columnsText.TabIndex = 1;
            this.columnsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnsText.Leave += new System.EventHandler(this.columnsText_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Columns";
            // 
            // rowsText
            // 
            this.rowsText.Location = new System.Drawing.Point(195, 13);
            this.rowsText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rowsText.Name = "rowsText";
            this.rowsText.Size = new System.Drawing.Size(58, 39);
            this.rowsText.TabIndex = 0;
            this.rowsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rowsText.Leave += new System.EventHandler(this.rowsText_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mazeSpace);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1775, 625);
            this.panel2.TabIndex = 1;
            // 
            // mazeSpace
            // 
            this.mazeSpace.AutoScroll = true;
            this.mazeSpace.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mazeSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mazeSpace.Location = new System.Drawing.Point(0, 0);
            this.mazeSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mazeSpace.Name = "mazeSpace";
            this.mazeSpace.Size = new System.Drawing.Size(1775, 625);
            this.mazeSpace.TabIndex = 0;
            this.mazeSpace.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewStripMenuItem,
            this.mazeStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1775, 40);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem,
            this.openMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileMenuItem.Text = "&File";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(206, 44);
            this.saveMenuItem.Text = "Save";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(206, 44);
            this.openMenuItem.Text = "&Open";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(206, 44);
            this.exitMenuItem.Text = "E&xit";
            // 
            // viewStripMenuItem
            // 
            this.viewStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qualityMenuItem,
            this.rewardsMenuItem,
            this.statesMenuItem});
            this.viewStripMenuItem.Name = "viewStripMenuItem";
            this.viewStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.viewStripMenuItem.Text = "&View";
            // 
            // qualityMenuItem
            // 
            this.qualityMenuItem.Name = "qualityMenuItem";
            this.qualityMenuItem.Size = new System.Drawing.Size(296, 44);
            this.qualityMenuItem.Text = "Quality Table";
            // 
            // rewardsMenuItem
            // 
            this.rewardsMenuItem.Name = "rewardsMenuItem";
            this.rewardsMenuItem.Size = new System.Drawing.Size(296, 44);
            this.rewardsMenuItem.Text = "Rewards Table";
            // 
            // statesMenuItem
            // 
            this.statesMenuItem.Name = "statesMenuItem";
            this.statesMenuItem.Size = new System.Drawing.Size(296, 44);
            this.statesMenuItem.Text = "&State Space";
            // 
            // mazeStripMenuItem
            // 
            this.mazeStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainStripMenuItem,
            this.runMazeStripMenuItem,
            this.qualityStripMenuItem});
            this.mazeStripMenuItem.Name = "mazeStripMenuItem";
            this.mazeStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.mazeStripMenuItem.Text = "&Maze";
            // 
            // trainStripMenuItem
            // 
            this.trainStripMenuItem.Name = "trainStripMenuItem";
            this.trainStripMenuItem.Size = new System.Drawing.Size(294, 44);
            this.trainStripMenuItem.Text = "&Train";
            // 
            // runMazeStripMenuItem
            // 
            this.runMazeStripMenuItem.Name = "runMazeStripMenuItem";
            this.runMazeStripMenuItem.Size = new System.Drawing.Size(294, 44);
            this.runMazeStripMenuItem.Text = "&Run Maze";
            // 
            // qualityStripMenuItem
            // 
            this.qualityStripMenuItem.Name = "qualityStripMenuItem";
            this.qualityStripMenuItem.Size = new System.Drawing.Size(294, 44);
            this.qualityStripMenuItem.Text = "Select &Quality";
            // 
            // rewardsLabelSecondary
            // 
            this.rewardsLabelSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rewardsLabelSecondary.Location = new System.Drawing.Point(966, 209);
            this.rewardsLabelSecondary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rewardsLabelSecondary.Name = "rewardsLabelSecondary";
            this.rewardsLabelSecondary.Size = new System.Drawing.Size(678, 41);
            this.rewardsLabelSecondary.TabIndex = 18;
            this.rewardsLabelSecondary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MazeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 939);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.entryPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MazeMain";
            this.Text = "Maze";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.entryPanel.ResumeLayout(false);
            this.entryPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel entryPanel;
        private System.Windows.Forms.Panel panel2;
        private MazeSpace mazeSpace;
        private System.Windows.Forms.Button runMazeButton;
        private System.Windows.Forms.TextBox columnsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rowsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox trainingEpisodesText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox discountRateText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox learningRateText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startPositionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goalPositionText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button trainMazeButton;
        private System.Windows.Forms.ToolStripMenuItem viewStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualityMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewardsMenuItem;
        private System.Windows.Forms.Label rewardsLabelPrimary;
        private System.Windows.Forms.Button rewardsButton;
        private System.Windows.Forms.ToolStripMenuItem mazeStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runMazeStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualityStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statesMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sarsaRadio;
        private System.Windows.Forms.RadioButton qLearningRadio;
        private System.Windows.Forms.Label rewardsLabelSecondary;
    }
}

