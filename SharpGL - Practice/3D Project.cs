using SharpGL;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Lighting;
using SharpGL.SceneGraph;

using System;
using System.Collections.Generic;
using System.Drawing;
using GlmNet;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace SharpGL___Practice
{
    public partial class MainForm : Form
    {
        private Color ColorUserColor = Color.WhiteSmoke; // Màu mặc định
        private List<Object> objectList = new List<Object>();
        private Axis axis = new Axis();
        private Grid grid = new Grid();
        private bool RenderAxis = false;
        private bool RenderGrid = false;


        //private List<Shape> ShapeList = new List<Shape>();
        public MainForm()
        {
            InitializeComponent();
            propertyGridCamera.SelectedObject = camera;
            objectListBox.DrawMode = DrawMode.OwnerDrawFixed;
            OpenGL gl = openGLControl1.OpenGL;
            gl.Enable(OpenGL.GL_STENCIL_TEST);

        }
        #region OpenGL
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl1.OpenGL;
            // Set the clear color.
            gl.ClearColor(0.63f, 0.63f, 0.63f, 1);
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Load the identity.
            gl.LoadIdentity();
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl1.OpenGL;
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Load the identity.
            gl.LoadIdentity();
            // Create a perspective transformation.
            gl.Viewport(0, 0, openGLControl1.Width, openGLControl1.Height);
            camera.FoV = 60;
            gl.Perspective(camera.FoV, (double)Width / (double)Height, 0.01, 100.0);
            camera.Pitch = -35;
            camera.Yaw = 225;
            vec3 camPos = camera.camPosition;
            vec3 camFront = camera.camFront;
            vec3 camUp = camera.camUp;
            gl.LookAt(camPos.x, camPos.y, camPos.z, camPos.x + camFront.x, camPos.y + camFront.y, camPos.z + camFront.z, camUp.x, camUp.y, camUp.z);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl1.OpenGL;

            // Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            
            if (RenderAxis == true)
                axis.Render(gl);
            if (RenderGrid == true)
                grid.Render(gl);
            int len = objectList.Count;
            for (int i = 0; i < len; i++)
                objectList[i].Render(gl);
            
            gl.Flush();
        }
        #endregion

        #region Event mouse click (not used)
        private void ctrl_openGLControl_MouseDown(object sender, MouseEventArgs e) // Khi nhấn chuột trong openGLControl
        {

        }

        private void ctrl_openGLControl_MouseMove(object sender, MouseEventArgs e) // Event khi chuột di chuyển
        {

        }

        private void ctrl_openGLControl_MouseUp(object sender, MouseEventArgs e) // Khi chuột thả
        {

        }
        #endregion

        #region Camera Controls
        Camera camera = new Camera();
        private void openGLControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            switch (e.KeyCode)
            {
                case Keys.Z: camera.ZoomIn(); break;
                case Keys.X: camera.ZoomOut(); break;

                case Keys.Up: camera.LookUp();  break;
                case Keys.Down: camera.LookDown();  break;
                case Keys.Left: camera.LookLeft();  break;
                case Keys.Right: camera.LookRight();  break;

                case Keys.W: camera.GoForward(); break;
                case Keys.S: camera.GoBack(); break;
                case Keys.A: camera.StrafeLeft(); break;
                case Keys.D: camera.StrafeRight(); break;
                case Keys.Space: camera.GoUp(); break;
                case Keys.ControlKey: camera.GoDown(); break;
            }
            propertyGridCamera.Refresh();
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(camera.FoV, (double)Width / (double)Height, 0.01, 100.0);
            vec3 camPos = camera.camPosition;
            vec3 camFront = camera.camFront;
            vec3 camUp = camera.camUp;
            gl.LookAt(camPos.x, camPos.y, camPos.z, camPos.x + camFront.x, camPos.y + camFront.y, camPos.z + camFront.z, camUp.x, camUp.y, camUp.z);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        private void propertyGridCamera_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            if (e.ChangedItem.Label == "X") camera.camPosX = Convert.ToSingle(e.ChangedItem.Value.ToString());
            if (e.ChangedItem.Label == "Y") camera.camPosY = Convert.ToSingle(e.ChangedItem.Value.ToString());
            if (e.ChangedItem.Label == "Z") camera.camPosZ = Convert.ToSingle(e.ChangedItem.Value.ToString());
            if (e.ChangedItem.Label == "FoV") camera.FoV = Convert.ToDouble(e.ChangedItem.Value.ToString());
            if (e.ChangedItem.Label == "Pitch") camera.Pitch = Convert.ToSingle(e.ChangedItem.Value.ToString());
            if (e.ChangedItem.Label == "Yaw") camera.Yaw = Convert.ToSingle(e.ChangedItem.Value.ToString());
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(camera.FoV, (double)Width / (double)Height, 0.01, 100.0);
            vec3 camPos = camera.camPosition;
            vec3 camFront = camera.camFront;
            vec3 camUp = camera.camUp;
            gl.LookAt(camPos.x, camPos.y, camPos.z, camPos.x + camFront.x, camPos.y + camFront.y, camPos.z + camFront.z, camUp.x, camUp.y, camUp.z);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            
        }
        #endregion

        #region Design Primitives
        private void checkedListRenderDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> checkedIndex = new List<int>();
            for (int i = 0; i < checkedListRenderDesign.CheckedIndices.Count; i++)
                checkedIndex.Add(checkedListRenderDesign.CheckedIndices[i]);
            if (checkedIndex.Contains(0) == true)
                RenderAxis = true;
            else RenderAxis = false;
            if (checkedIndex.Contains(1) == true)
                RenderGrid = true;
            else RenderGrid = false;
        }
        #endregion
        #region Shape Buttons
        private void buttonCube_Click(object sender, EventArgs e)
        {
            Cube cube = new Cube();
            cube.color = ColorUserColor;
            objectList.Add(cube);
            cube.Name = "Cube " + (objectList.Count - 1);
            objectListBox.Items.Add(cube.Name);
            objectListBox.SetSelected(objectListBox.Items.Count - 1, true);
            propertyGridObject.SelectedObject = cube;
        }
        private void buttonPyramid_Click(object sender, EventArgs e)
        {
            Pyramid pyramid = new Pyramid();
            pyramid.color = ColorUserColor;
            objectList.Add(pyramid);
            pyramid.Name = "Pyramid " + (objectList.Count - 1);
            objectListBox.Items.Add(pyramid.Name);
            objectListBox.SetSelected(objectListBox.Items.Count - 1, true);
            propertyGridObject.SelectedObject = pyramid;
        }
        private void buttonCylinder_Click(object sender, EventArgs e)
        {
            Cylinder cylinder = new Cylinder();
            cylinder.color = ColorUserColor;
            objectList.Add(cylinder);
            cylinder.Name = "Cylinder " + (objectList.Count - 1);
            objectListBox.Items.Add(cylinder.Name);
            objectListBox.SetSelected(objectListBox.Items.Count - 1, true);
            propertyGridObject.SelectedObject = cylinder;
        }
        #endregion

        #region Object List Box
        private void objectListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // draw the background
            e.DrawBackground();

            // get the font
            Font font = new Font(e.Font, (e.State & DrawItemState.Selected) == DrawItemState.Selected ? FontStyle.Bold : FontStyle.Regular);

            // draw the text
            if (objectListBox.Items.Count > 0)
            {
                e.Graphics.DrawString(objectListBox.Items[e.Index].ToString(), font, new SolidBrush(objectListBox.ForeColor), e.Bounds);
            }
            e.DrawFocusRectangle();
        }
        private void objectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectedObjectIndex = objectListBox.SelectedIndex;
            if (objectListBox.SelectedIndex >= 0)
            {
                propertyGridObject.SelectedObject = objectList[objectListBox.SelectedIndex];
                objectList[objectListBox.SelectedIndex].selected = true;
            }
            for (int i = 0; i < objectList.Count; i++)
                if (i != objectListBox.SelectedIndex)
                    objectList[i].selected = false;
        }

        private void objectListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                objectList.RemoveAt(objectListBox.SelectedIndex);
                objectListBox.Items.RemoveAt(objectListBox.SelectedIndex);
                propertyGridObject.SelectedObject = -1;
            }
            if (e.Modifiers == Keys.Control && e.KeyCode==Keys.D)
            {
                objectListBox.SetSelected(objectListBox.SelectedIndex, false);
                propertyGridObject.SelectedObject = -1;
            }
        }
        private void objectListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(objectListBox, e.Location);
                if (objectListBox.SelectedIndex >= 0)
                {
                    toolStripMenuDeselect.Enabled = true;
                    toolStripMenuDelete.Enabled = true;
                }
                else
                {
                    toolStripMenuDeselect.Enabled = false;
                    toolStripMenuDelete.Enabled = false;
                }
            }
        }

        private void toolStripMenuDeselect_Click(object sender, EventArgs e)
        {
            objectListBox.SetSelected(objectListBox.SelectedIndex, false);
            propertyGridObject.SelectedObject = -1;
        }

        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            objectList.RemoveAt(objectListBox.SelectedIndex);
            objectListBox.Items.RemoveAt(objectListBox.SelectedIndex);
            propertyGridObject.SelectedObject = -1;
        }
        #endregion

        private void propertyGridObject_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            if (e.ChangedItem.Label == "Texture") objectList[objectListBox.SelectedIndex].TextureChanged(gl);
        }

        private void buttonClearTexture_Click(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            objectList[objectListBox.SelectedIndex].haveTexture = false;
            objectList[objectListBox.SelectedIndex].image = null;
            objectList[objectListBox.SelectedIndex].texture.Destroy(gl);

        }
    }
}