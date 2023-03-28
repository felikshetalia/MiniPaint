
namespace MiniPaint_GL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolButton = new System.Windows.Forms.ToolStripButton();
            this.saveLabel = new System.Windows.Forms.ToolStripLabel();
            this.loadToolButton = new System.Windows.Forms.ToolStripButton();
            this.loadLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolsLabel = new System.Windows.Forms.ToolStripLabel();
            this.brushToolButton = new System.Windows.Forms.ToolStripButton();
            this.rectangleButton = new System.Windows.Forms.ToolStripButton();
            this.ellipseButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.ToolThicknessLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolThicknessComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ChosenColour = new System.Windows.Forms.ToolStripLabel();
            this.colorBtn = new System.Windows.Forms.ToolStripButton();
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.coloursPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.languageLabel = new System.Windows.Forms.ToolStripLabel();
            this.btnENG = new System.Windows.Forms.ToolStripButton();
            this.btnPOL = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolButton,
            this.saveLabel,
            this.loadToolButton,
            this.loadLabel,
            this.toolsLabel,
            this.brushToolButton,
            this.rectangleButton,
            this.ellipseButton,
            this.deleteButton,
            this.ToolThicknessLabel,
            this.toolThicknessComboBox,
            this.ChosenColour,
            this.colorBtn,
            this.languageLabel,
            this.btnENG,
            this.btnPOL});
            this.toolStrip.Name = "toolStrip";
            //this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // saveToolButton
            // 
            resources.ApplyResources(this.saveToolButton, "saveToolButton");
            this.saveToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolButton.Name = "saveToolButton";
            this.saveToolButton.Click += new System.EventHandler(this.saveToolButton_Click);
            // 
            // saveLabel
            // 
            resources.ApplyResources(this.saveLabel, "saveLabel");
            this.saveLabel.Name = "saveLabel";
            // 
            // loadToolButton
            // 
            resources.ApplyResources(this.loadToolButton, "loadToolButton");
            this.loadToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadToolButton.Name = "loadToolButton";
            this.loadToolButton.Click += new System.EventHandler(this.loadToolButton_Click);
            // 
            // loadLabel
            // 
            resources.ApplyResources(this.loadLabel, "loadLabel");
            this.loadLabel.Name = "loadLabel";
            // 
            // toolsLabel
            // 
            resources.ApplyResources(this.toolsLabel, "toolsLabel");
            this.toolsLabel.Name = "toolsLabel";
            // 
            // brushToolButton
            // 
            resources.ApplyResources(this.brushToolButton, "brushToolButton");
            this.brushToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushToolButton.Name = "brushToolButton";
            this.brushToolButton.Click += new System.EventHandler(this.brushToolButton_Click);
            // 
            // rectangleButton
            // 
            resources.ApplyResources(this.rectangleButton, "rectangleButton");
            this.rectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // ellipseButton
            // 
            resources.ApplyResources(this.ellipseButton, "ellipseButton");
            this.ellipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ToolThicknessLabel
            // 
            resources.ApplyResources(this.ToolThicknessLabel, "ToolThicknessLabel");
            this.ToolThicknessLabel.Name = "ToolThicknessLabel";
            // 
            // toolThicknessComboBox
            // 
            resources.ApplyResources(this.toolThicknessComboBox, "toolThicknessComboBox");
            this.toolThicknessComboBox.Items.AddRange(new object[] {
            resources.GetString("toolThicknessComboBox.Items"),
            resources.GetString("toolThicknessComboBox.Items1"),
            resources.GetString("toolThicknessComboBox.Items2"),
            resources.GetString("toolThicknessComboBox.Items3"),
            resources.GetString("toolThicknessComboBox.Items4")});
            this.toolThicknessComboBox.Name = "toolThicknessComboBox";
            // 
            // ChosenColour
            // 
            resources.ApplyResources(this.ChosenColour, "ChosenColour");
            this.ChosenColour.Name = "ChosenColour";
            // 
            // colorBtn
            // 
            resources.ApplyResources(this.colorBtn, "colorBtn");
            this.colorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorBtn.Name = "colorBtn";
            // 
            // drawingArea
            // 
            resources.ApplyResources(this.drawingArea, "drawingArea");
            this.drawingArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.TabStop = false;
            this.drawingArea.Click += new System.EventHandler(this.drawingArea_Click);
            this.drawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingArea_Paint);
            this.drawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseDown);
            this.drawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseMove);
            this.drawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseUp);
            this.drawingArea.Resize += new System.EventHandler(this.drawingArea_Resize);
            // 
            // groupBox
            // 
            resources.ApplyResources(this.groupBox, "groupBox");
            this.groupBox.Controls.Add(this.coloursPanel);
            this.groupBox.Name = "groupBox";
            this.groupBox.TabStop = false;
            // 
            // coloursPanel
            // 
            resources.ApplyResources(this.coloursPanel, "coloursPanel");
            this.coloursPanel.Name = "coloursPanel";
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // btnENG
            // 
            resources.ApplyResources(this.btnENG, "btnENG");
            this.btnENG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnENG.Name = "btnENG";
            // 
            // btnPOL
            // 
            resources.ApplyResources(this.btnPOL, "btnPOL");
            this.btnPOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPOL.Name = "btnPOL";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.ToolStrip colourButton;
        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.GroupBox groupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton brushToolButton;
        private System.Windows.Forms.ToolStripLabel toolsLabel;
        private System.Windows.Forms.FlowLayoutPanel coloursPanel;
        private System.Windows.Forms.ToolStripButton saveToolButton;
        private System.Windows.Forms.ToolStripLabel saveLabel;
        private System.Windows.Forms.ToolStripButton loadToolButton;
        private System.Windows.Forms.ToolStripLabel loadLabel;
        private System.Windows.Forms.ToolStripComboBox toolThicknessComboBox;
        private System.Windows.Forms.ToolStripLabel ToolThicknessLabel;
        private System.Windows.Forms.ToolStripButton rectangleButton;
        private System.Windows.Forms.ToolStripButton ellipseButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel ChosenColour;
        private System.Windows.Forms.ToolStripButton colorBtn;
        private System.Windows.Forms.ToolStripLabel languageLabel;
        private System.Windows.Forms.ToolStripButton btnENG;
        private System.Windows.Forms.ToolStripButton btnPOL;
    }
}

