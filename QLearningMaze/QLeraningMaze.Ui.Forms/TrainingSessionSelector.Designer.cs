﻿namespace QLearningMaze.Ui.Forms
{
    partial class TrainingSessionSelector
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
            this.sesssionList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.useSessionButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sesssionList
            // 
            this.sesssionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sesssionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.sesssionList.FullRowSelect = true;
            this.sesssionList.GridLines = true;
            this.sesssionList.HideSelection = false;
            this.sesssionList.Location = new System.Drawing.Point(12, 12);
            this.sesssionList.MultiSelect = false;
            this.sesssionList.Name = "sesssionList";
            this.sesssionList.Size = new System.Drawing.Size(389, 354);
            this.sesssionList.TabIndex = 0;
            this.sesssionList.UseCompatibleStateImageBehavior = false;
            this.sesssionList.View = System.Windows.Forms.View.Details;
            this.sesssionList.SelectedIndexChanged += new System.EventHandler(this.sesssionList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Episode";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Moves";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Score";
            this.columnHeader3.Width = 100;
            // 
            // useSessionButton
            // 
            this.useSessionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.useSessionButton.Enabled = false;
            this.useSessionButton.Location = new System.Drawing.Point(12, 400);
            this.useSessionButton.Name = "useSessionButton";
            this.useSessionButton.Size = new System.Drawing.Size(150, 46);
            this.useSessionButton.TabIndex = 1;
            this.useSessionButton.Text = "Use";
            this.useSessionButton.UseVisualStyleBackColor = true;
            this.useSessionButton.Click += new System.EventHandler(this.useSessionButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(251, 400);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 46);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // TrainingSessionSelector
            // 
            this.AcceptButton = this.useSessionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(427, 458);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.useSessionButton);
            this.Controls.Add(this.sesssionList);
            this.Name = "TrainingSessionSelector";
            this.Text = "TrainingSessionSelector";
            this.Load += new System.EventHandler(this.TrainingSessionSelector_Load);
            this.Shown += new System.EventHandler(this.TrainingSessionSelector_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView sesssionList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button useSessionButton;
        private System.Windows.Forms.Button cancelButton;
    }
}