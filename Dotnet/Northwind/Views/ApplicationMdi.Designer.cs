using ENV;
using Firefly.Box;
using System;
namespace Northwind.Views
{
    partial class ApplicationMdi
    {
        System.ComponentModel.IContainer components;
        System.Windows.Forms.StatusStrip StatusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel mainStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel userStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel versionStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel activityStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel expandStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel expandTextBoxStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel insertOverrideStatusLabel;
        ApplicationMdiMenu mainMenu;
        System.Windows.Forms.ToolStrip mainMenuToolStrip;
        protected override void Dispose(bool disposing)
        {
            if (disposing&&(components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.activityStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.expandStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.expandTextBoxStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.insertOverrideStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            _optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            this.mainMenu = new Northwind.Views.ApplicationMdiMenu();
            this.mainMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.StatusStrip.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.mainMenuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip.ContextMenuStrip = _optionsContextMenuStrip;
            this.StatusStrip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel,
            this.userStatusLabel,
            this.versionStatusLabel,
            this.activityStatusLabel,
            this.expandStatusLabel,
            this.expandTextBoxStatusLabel,
            this.insertOverrideStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 420);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(600, 20);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 1;
            // 
            // mainStatusLabel
            // 
            this.mainStatusLabel.AutoSize = false;
            this.mainStatusLabel.Name = "mainStatusLabel";
            this.mainStatusLabel.Size = new System.Drawing.Size(255, 15);
            this.mainStatusLabel.Spring = true;
            this.mainStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userStatusLabel
            // 
            this.userStatusLabel.AutoSize = false;
            this.userStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.userStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.userStatusLabel.Name = "userStatusLabel";
            this.userStatusLabel.Size = new System.Drawing.Size(120, 15);
            this.userStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionStatusLabel
            // 
            this.versionStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.versionStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.versionStatusLabel.Name = "versionStatusLabel";
            this.versionStatusLabel.Size = new System.Drawing.Size(120, 15);
            this.versionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activityStatusLabel
            // 
            this.activityStatusLabel.AutoSize = false;
            this.activityStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.activityStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.activityStatusLabel.Name = "activityStatusLabel";
            this.activityStatusLabel.Size = new System.Drawing.Size(60, 15);
            this.activityStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expandStatusLabel
            // 
            this.expandStatusLabel.AutoSize = false;
            this.expandStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.expandStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.expandStatusLabel.Name = "expandStatusLabel";
            this.expandStatusLabel.Size = new System.Drawing.Size(60, 15);
            this.expandStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expandStatusLabel.Click += new System.EventHandler(this.expandStatusLabel_Click);
            // 
            // expandTextBoxStatusLabel
            // 
            this.expandTextBoxStatusLabel.AutoSize = false;
            this.expandTextBoxStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.expandTextBoxStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.expandTextBoxStatusLabel.Name = "expandTextBoxStatusLabel";
            this.expandTextBoxStatusLabel.Size = new System.Drawing.Size(60, 15);
            this.expandTextBoxStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expandTextBoxStatusLabel.Click += new System.EventHandler(this.expandTextBoxStatusLabel_Click);
            // 
            // insertOverrideStatusLabel
            // 
            this.insertOverrideStatusLabel.AutoSize = false;
            this.insertOverrideStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.insertOverrideStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.insertOverrideStatusLabel.Name = "insertOverrideStatusLabel";
            this.insertOverrideStatusLabel.Size = new System.Drawing.Size(30, 15);
            this.insertOverrideStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _optionsContextMenuStrip
            // 
            _optionsContextMenuStrip.Name = "_optionsContextMenuStrip";
            // 
            // mainMenu
            // 
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.mainMenu.Size = new System.Drawing.Size(600, 19);
            // 
            // mainMenuToolStrip
            // 
            this.mainMenuToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainMenuToolStrip.Name = "mainMenuToolStrip";
            // 
            // ApplicationMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.mainMenuToolStrip);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "ApplicationMdi";
            this.Text = "Northwind";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainMenuToolStrip.ResumeLayout(false);
            this.mainMenuToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
