using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;

namespace SharpGL___Practice
{
    class Axis
    {
        public void Render(OpenGL gl)
        {
            gl.LineWidth(3.0f);
            gl.Begin(OpenGL.GL_LINES);
            // x axis
            gl.Color(1.0, 0.0, 0.0);
            gl.Vertex(-50.0f, 0.0f, 0.0f);
            gl.Vertex(50.0f, 0.0f, 0.0f);
            // x arrow
            gl.Vertex(6.0f, 0.0f, 0.0f);
            gl.Vertex(5.5f, 0.0f, 0.3f);
            gl.Vertex(6.0f, 0.0f, 0.0f);
            gl.Vertex(5.5f, 0.0f, -0.3f);
            // y axis
            gl.Color(0.0, 1.0, 0.0);
            gl.Vertex(0.0f, -50.0f, 0.0f);
            gl.Vertex(0.0f, 50.0f, 0.0f);
            // y arrow
            gl.Vertex(0.0f, 4.0f, 0.0f);
            gl.Vertex(0.5f, 3.5f, 0.0f);
            gl.Vertex(0.0f, 4.0f, 0.0f);
            gl.Vertex(-0.5f, 3.5f, 0.0f);
            // z axis
            gl.Color(0.0, 0.0, 1.0);
            gl.Vertex(0.0f, 0.0f, -50.0f);
            gl.Vertex(0.0f, 0.0f, 50.0f);
            // z arrow
            gl.Vertex(0.0f, 0.0f, 6.0f);
            gl.Vertex(0.5f, 0.0f, 5.5f);
            gl.Vertex(0.0f, 0.0f, 6.0f);
            gl.Vertex(-0.5f, 0.0f, 5.5f);
            gl.End();
        }
    }
}
