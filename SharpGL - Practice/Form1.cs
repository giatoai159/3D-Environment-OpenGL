using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SharpGL___Practice
{
    public partial class Form1 : Form
    {
        private Color ColorUserColor = Color.White; // Màu nét vẽ, màu đen là màu mặc định
        private float DrawThickness = 1.0f; // Độ dày nét vẽ 1
        private short Tool = 0; // 0 = Line, 1 = Rectangle, 2 = Circle,...
        private int SelectedObjectIndex = -1;
        //private List<Shape> ShapeList = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl1.OpenGL;
            // Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
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
            gl.Ortho2D(0, openGLControl1.Width, 0, openGLControl1.Height);


        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl1.OpenGL;

            // Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //int len = ShapeList.Count;
            //for (int i = 0; i < len; i++)
            //{
                //ShapeList[i].Draw(gl);
            //}
            gl.Flush();
        }

        private void ctrl_openGLControl_MouseDown(object sender, MouseEventArgs e) // Khi nhấn chuột trong openGLControl
        {

        }

        private void ctrl_openGLControl_MouseMove(object sender, MouseEventArgs e) // Event khi chuột di chuyển
        {

        }

        private void ctrl_openGLControl_MouseUp(object sender, MouseEventArgs e) // Khi chuột thả
        {

        }

        private void bt_Color_Clicked(object sender, EventArgs e) // Bảng chọn màu
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorUserColor = colorDialog1.Color; // Lấy màu đã chọn của color dialog

                //if (SelectedObjectIndex >= 0) // Thay đổi màu cho object đang được chọn
                    //ShapeList[SelectedObjectIndex].ShapeColor = ColorUserColor;
            }
        }

        private void comboBox_Thickness_Selected(object sender, EventArgs e) // Chọn đồ dày trong list dropdown
        {
            DrawThickness = Convert.ToSingle(comboBox_Thickness.SelectedItem.ToString());

            //if (SelectedObjectIndex >= 0) // Thay đổi độ dày nét vẽ cho object đang được chọn
                //ShapeList[SelectedObjectIndex].Thickness = DrawThickness;
        }


        private void objectListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}