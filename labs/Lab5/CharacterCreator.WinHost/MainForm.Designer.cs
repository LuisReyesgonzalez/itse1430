﻿
namespace CharacterCreator.WinHost
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.miCharacterAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miCharacterEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miCharacterDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCharacter = new System.Windows.Forms.ListBox();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(282, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.miFileExit.Size = new System.Drawing.Size(169, 26);
            this.miFileExit.Text = "E&xit";
            this.miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCharacterAdd,
            this.miCharacterEdit,
            this.toolStripSeparator1,
            this.miCharacterDelete});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem2.Text = "&Character";
            // 
            // miCharacterAdd
            // 
            this.miCharacterAdd.Name = "miCharacterAdd";
            this.miCharacterAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miCharacterAdd.Size = new System.Drawing.Size(175, 26);
            this.miCharacterAdd.Text = "&New";
            this.miCharacterAdd.Click += new System.EventHandler(this.OnCharacterAdd);
            // 
            // miCharacterEdit
            // 
            this.miCharacterEdit.Name = "miCharacterEdit";
            this.miCharacterEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.miCharacterEdit.Size = new System.Drawing.Size(175, 26);
            this.miCharacterEdit.Text = "Edit";
            this.miCharacterEdit.Click += new System.EventHandler(this.OnCharacterEdit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // miCharacterDelete
            // 
            this.miCharacterDelete.Name = "miCharacterDelete";
            this.miCharacterDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.miCharacterDelete.Size = new System.Drawing.Size(175, 26);
            this.miCharacterDelete.Text = "Delete";
            this.miCharacterDelete.Click += new System.EventHandler(this.OnCharacterDelete);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpAbout});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolStripMenuItem3.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem3.Text = "&Help";
            // 
            // miHelpAbout
            // 
            this.miHelpAbout.Name = "miHelpAbout";
            this.miHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miHelpAbout.Size = new System.Drawing.Size(157, 26);
            this.miHelpAbout.Text = "About";
            this.miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // lstCharacter
            // 
            this.lstCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCharacter.FormattingEnabled = true;
            this.lstCharacter.ItemHeight = 20;
            this.lstCharacter.Location = new System.Drawing.Point(0, 28);
            this.lstCharacter.Name = "lstCharacter";
            this.lstCharacter.Size = new System.Drawing.Size(282, 375);
            this.lstCharacter.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 403);
            this.Controls.Add(this.lstCharacter);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miCharacterAdd;
        private System.Windows.Forms.ToolStripMenuItem miCharacterEdit;
        private System.Windows.Forms.ToolStripMenuItem miCharacterDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miHelpAbout;
        private System.Windows.Forms.ListBox lstCharacter;
    }
}

