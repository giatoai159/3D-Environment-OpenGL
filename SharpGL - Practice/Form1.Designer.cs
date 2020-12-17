namespace SharpGL___Practice
{
    partial class Form1
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
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bt_Color = new System.Windows.Forms.Button();
            this.comboBox_Thickness = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentShapeLabel = new System.Windows.Forms.Label();
            this.objectListBox = new System.Windows.Forms.ListBox();
            this.objectListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.openGLControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openGLControl1.BackColor = System.Drawing.Color.Black;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.FrameRate = 60;
            this.openGLControl1.Location = new System.Drawing.Point(60, 1);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(1262, 858);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl1.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_openGLControl_MouseDown);
            this.openGLControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctrl_openGLControl_MouseMove);
            this.openGLControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ctrl_openGLControl_MouseUp);
            // 
            // bt_Color
            // 
            this.bt_Color.Location = new System.Drawing.Point(-1, 314);
            this.bt_Color.Name = "bt_Color";
            this.bt_Color.Size = new System.Drawing.Size(61, 23);
            this.bt_Color.TabIndex = 1;
            this.bt_Color.Text = "Color";
            this.bt_Color.UseVisualStyleBackColor = true;
            this.bt_Color.Click += new System.EventHandler(this.bt_Color_Clicked);
            // 
            // comboBox_Thickness
            // 
            this.comboBox_Thickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Thickness.FormattingEnabled = true;
            this.comboBox_Thickness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox_Thickness.Location = new System.Drawing.Point(3, 352);
            this.comboBox_Thickness.Name = "comboBox_Thickness";
            this.comboBox_Thickness.Size = new System.Drawing.Size(51, 21);
            this.comboBox_Thickness.TabIndex = 2;
            this.comboBox_Thickness.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Thickness_Selected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thickness";
            // 
            // currentShapeLabel
            // 
            this.currentShapeLabel.AutoSize = true;
            this.currentShapeLabel.Location = new System.Drawing.Point(0, 385);
            this.currentShapeLabel.Name = "currentShapeLabel";
            this.currentShapeLabel.Size = new System.Drawing.Size(54, 13);
            this.currentShapeLabel.TabIndex = 6;
            this.currentShapeLabel.Text = "Tool: Line";
            // 
            // objectListBox
            // 
            this.objectListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListBox.FormattingEnabled = true;
            this.objectListBox.Location = new System.Drawing.Point(1322, 682);
            this.objectListBox.Name = "objectListBox";
            this.objectListBox.Size = new System.Drawing.Size(280, 186);
            this.objectListBox.TabIndex = 14;
            this.objectListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.objectListBox_KeyDown);
            // 
            // objectListLabel
            // 
            this.objectListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListLabel.AutoSize = true;
            this.objectListLabel.Location = new System.Drawing.Point(1431, 666);
            this.objectListLabel.Name = "objectListLabel";
            this.objectListLabel.Size = new System.Drawing.Size(57, 13);
            this.objectListLabel.TabIndex = 15;
            this.objectListLabel.Text = "Object List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 859);
            this.Controls.Add(this.objectListLabel);
            this.Controls.Add(this.objectListBox);
            this.Controls.Add(this.currentShapeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Thickness);
            this.Controls.Add(this.bt_Color);
            this.Controls.Add(this.openGLControl1);
            this.Name = "Form1";
            this.Text = "Simple Drawing Tool";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bt_Color;
        private System.Windows.Forms.ComboBox comboBox_Thickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentShapeLabel;
        private System.Windows.Forms.ListBox objectListBox;
        private System.Windows.Forms.Label objectListLabel;
    }
}

