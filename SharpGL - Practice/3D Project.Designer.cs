namespace SharpGL___Practice
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.objectListBox = new System.Windows.Forms.ListBox();
            this.groupBoxScene = new System.Windows.Forms.GroupBox();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.buttonCylinder = new System.Windows.Forms.Button();
            this.buttonPyramid = new System.Windows.Forms.Button();
            this.buttonCube = new System.Windows.Forms.Button();
            this.checkedListRenderDesign = new System.Windows.Forms.CheckedListBox();
            this.buttonClearTexture = new System.Windows.Forms.Button();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.propertyGridObject = new System.Windows.Forms.PropertyGrid();
            this.propertyGridCamera = new System.Windows.Forms.PropertyGrid();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuDeselect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.groupBoxScene.SuspendLayout();
            this.groupBoxTools.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openGLControl1.BackColor = System.Drawing.Color.Black;
            this.openGLControl1.DrawFPS = true;
            this.openGLControl1.FrameRate = 60;
            this.openGLControl1.Location = new System.Drawing.Point(3, 16);
            this.openGLControl1.MinimumSize = new System.Drawing.Size(200, 200);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(1244, 840);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl1.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_openGLControl_MouseDown);
            this.openGLControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctrl_openGLControl_MouseMove);
            this.openGLControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ctrl_openGLControl_MouseUp);
            this.openGLControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.openGLControl1_PreviewKeyDown);
            // 
            // objectListBox
            // 
            this.objectListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objectListBox.FormattingEnabled = true;
            this.objectListBox.ItemHeight = 16;
            this.objectListBox.Location = new System.Drawing.Point(0, 683);
            this.objectListBox.Name = "objectListBox";
            this.objectListBox.Size = new System.Drawing.Size(216, 176);
            this.objectListBox.TabIndex = 14;
            this.objectListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.objectListBox_DrawItem);
            this.objectListBox.SelectedIndexChanged += new System.EventHandler(this.objectListBox_SelectedIndexChanged);
            this.objectListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.objectListBox_KeyDown);
            this.objectListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.objectListBox_MouseDown);
            // 
            // groupBoxScene
            // 
            this.groupBoxScene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxScene.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxScene.Controls.Add(this.openGLControl1);
            this.groupBoxScene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxScene.Location = new System.Drawing.Point(130, 0);
            this.groupBoxScene.Name = "groupBoxScene";
            this.groupBoxScene.Size = new System.Drawing.Size(1250, 859);
            this.groupBoxScene.TabIndex = 16;
            this.groupBoxScene.TabStop = false;
            this.groupBoxScene.Text = "Scene";
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxTools.Controls.Add(this.buttonCylinder);
            this.groupBoxTools.Controls.Add(this.buttonPyramid);
            this.groupBoxTools.Controls.Add(this.buttonCube);
            this.groupBoxTools.Controls.Add(this.checkedListRenderDesign);
            this.groupBoxTools.Controls.Add(this.buttonClearTexture);
            this.groupBoxTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTools.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxTools.Size = new System.Drawing.Size(124, 859);
            this.groupBoxTools.TabIndex = 17;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Tools";
            // 
            // buttonCylinder
            // 
            this.buttonCylinder.Location = new System.Drawing.Point(12, 93);
            this.buttonCylinder.Name = "buttonCylinder";
            this.buttonCylinder.Size = new System.Drawing.Size(98, 30);
            this.buttonCylinder.TabIndex = 12;
            this.buttonCylinder.Text = "Cylinder";
            this.buttonCylinder.UseVisualStyleBackColor = true;
            this.buttonCylinder.Click += new System.EventHandler(this.buttonCylinder_Click);
            // 
            // buttonPyramid
            // 
            this.buttonPyramid.Location = new System.Drawing.Point(12, 57);
            this.buttonPyramid.Name = "buttonPyramid";
            this.buttonPyramid.Size = new System.Drawing.Size(98, 30);
            this.buttonPyramid.TabIndex = 11;
            this.buttonPyramid.Text = "Pyramid";
            this.buttonPyramid.UseVisualStyleBackColor = true;
            this.buttonPyramid.Click += new System.EventHandler(this.buttonPyramid_Click);
            // 
            // buttonCube
            // 
            this.buttonCube.Location = new System.Drawing.Point(12, 21);
            this.buttonCube.Name = "buttonCube";
            this.buttonCube.Size = new System.Drawing.Size(98, 30);
            this.buttonCube.TabIndex = 10;
            this.buttonCube.Text = "Cube";
            this.buttonCube.UseVisualStyleBackColor = true;
            this.buttonCube.Click += new System.EventHandler(this.buttonCube_Click);
            // 
            // checkedListRenderDesign
            // 
            this.checkedListRenderDesign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListRenderDesign.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListRenderDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListRenderDesign.CheckOnClick = true;
            this.checkedListRenderDesign.FormattingEnabled = true;
            this.checkedListRenderDesign.Items.AddRange(new object[] {
            "Render Axis",
            "Render Grid"});
            this.checkedListRenderDesign.Location = new System.Drawing.Point(4, 748);
            this.checkedListRenderDesign.Name = "checkedListRenderDesign";
            this.checkedListRenderDesign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListRenderDesign.Size = new System.Drawing.Size(120, 34);
            this.checkedListRenderDesign.TabIndex = 9;
            this.checkedListRenderDesign.SelectedIndexChanged += new System.EventHandler(this.checkedListRenderDesign_SelectedIndexChanged);
            // 
            // buttonClearTexture
            // 
            this.buttonClearTexture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearTexture.Location = new System.Drawing.Point(12, 805);
            this.buttonClearTexture.Name = "buttonClearTexture";
            this.buttonClearTexture.Size = new System.Drawing.Size(98, 30);
            this.buttonClearTexture.TabIndex = 8;
            this.buttonClearTexture.Text = "Clear Texture";
            this.buttonClearTexture.UseVisualStyleBackColor = true;
            this.buttonClearTexture.Click += new System.EventHandler(this.buttonClearTexture_Click);
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxControl.Controls.Add(this.propertyGridObject);
            this.groupBoxControl.Controls.Add(this.propertyGridCamera);
            this.groupBoxControl.Controls.Add(this.objectListBox);
            this.groupBoxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxControl.Location = new System.Drawing.Point(1386, 0);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(216, 859);
            this.groupBoxControl.TabIndex = 18;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Controllers";
            // 
            // propertyGridObject
            // 
            this.propertyGridObject.Location = new System.Drawing.Point(0, 16);
            this.propertyGridObject.Name = "propertyGridObject";
            this.propertyGridObject.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGridObject.Size = new System.Drawing.Size(216, 444);
            this.propertyGridObject.TabIndex = 16;
            this.propertyGridObject.ToolbarVisible = false;
            this.propertyGridObject.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridObject_PropertyValueChanged);
            // 
            // propertyGridCamera
            // 
            this.propertyGridCamera.Location = new System.Drawing.Point(0, 466);
            this.propertyGridCamera.Name = "propertyGridCamera";
            this.propertyGridCamera.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGridCamera.Size = new System.Drawing.Size(216, 211);
            this.propertyGridCamera.TabIndex = 15;
            this.propertyGridCamera.ToolbarVisible = false;
            this.propertyGridCamera.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridCamera_PropertyValueChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDeselect,
            this.toolStripMenuDelete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(119, 48);
            // 
            // toolStripMenuDeselect
            // 
            this.toolStripMenuDeselect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuDeselect.Enabled = false;
            this.toolStripMenuDeselect.Name = "toolStripMenuDeselect";
            this.toolStripMenuDeselect.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuDeselect.Text = "Deselect";
            this.toolStripMenuDeselect.Click += new System.EventHandler(this.toolStripMenuDeselect_Click);
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Enabled = false;
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            this.toolStripMenuDelete.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuDelete.Text = "Delete";
            this.toolStripMenuDelete.Click += new System.EventHandler(this.toolStripMenuDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1602, 859);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.groupBoxScene);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.Text = "3D Project";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.groupBoxScene.ResumeLayout(false);
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxControl.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.ListBox objectListBox;
        private System.Windows.Forms.GroupBox groupBoxScene;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.PropertyGrid propertyGridCamera;
        private System.Windows.Forms.Button buttonClearTexture;
        private System.Windows.Forms.CheckedListBox checkedListRenderDesign;
        private System.Windows.Forms.Button buttonCube;
        private System.Windows.Forms.PropertyGrid propertyGridObject;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeselect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.Button buttonPyramid;
        private System.Windows.Forms.Button buttonCylinder;
    }
}

