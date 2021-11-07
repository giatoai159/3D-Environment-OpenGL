using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;

namespace SharpGL___Practice
{
    class Grid
    {
        public void Render(OpenGL gl)
        {
            gl.LineWidth(1);
            gl.Color(0.25f, 0.25f, 0.25f);
            gl.Begin(OpenGL.GL_LINES);
            for (int i = -15; i <= 15; i++)
            {
                gl.Vertex(i, 0, -15);
                gl.Vertex(i, 0, 15);
                gl.Vertex(-15, 0, i);
                gl.Vertex(15, 0, i);
            };
            gl.End();
        }
    }
}
