using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using SharpGL;
using SharpGL.SceneGraph.Assets;
using GlmNet;

namespace SharpGL___Practice
{
    class Object
    {
        public string Name;
        // Vertex info
        protected List<vec3> VertexList = new List<vec3>();
        protected List<int[]> FaceList = new List<int[]>();
        private mat4 transformationMatrix = new mat4(1.0f);
        // Texture info
        protected List<vec2> TexCoordList = new List<vec2>();
        public Texture texture = new Texture();
        public bool haveTexture = false;
        protected List<int[]> TexFaceList = new List<int[]>();
        // Other
        public bool selected = false;

        public void TextureChanged(OpenGL gl)
        {
            texture.Destroy(gl);
            texture.Create(gl, image);
            haveTexture = true;
        }
        public void Render(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_DEPTH_TEST);
            if(haveTexture)
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            gl.StencilOp(OpenGL.GL_KEEP, OpenGL.GL_KEEP, OpenGL.GL_REPLACE);
            gl.Clear(OpenGL.GL_STENCIL_BUFFER_BIT);

            gl.StencilFunc(OpenGL.GL_ALWAYS, 1, 0xFF);
            gl.StencilMask(0xFF);

            Drawing(gl);

            gl.StencilFunc(OpenGL.GL_NOTEQUAL, 1, 0xFF);
            gl.StencilMask(0x00);
            if (haveTexture)
            gl.Disable(OpenGL.GL_TEXTURE_2D);
            gl.Begin(OpenGL.GL_TRIANGLES);
            if (selected == true)
            {
                vec3 oldScale = new vec3(scale_X, scale_Y, scale_Z);
                Scaling_X = oldScale.x + 0.05f;
                Scaling_Y = oldScale.y + 0.05f;
                Scaling_Z = oldScale.z + 0.05f;
                gl.Color(0.97f, 0.76f, 0.44f, 1.0f);
                for (int i = 0; i < FaceList.Count; i++) // Go through each face
                {
                    int[] face = FaceList[i];

                    for (int j = 0; j < FaceList[i].Length; j++)  // Go through each index
                    {
                        vec3 vertex = new vec3(transformationMatrix * new vec4(VertexList[face[j]].x, VertexList[face[j]].y, VertexList[face[j]].z, 1));
                        gl.Vertex(vertex.x, vertex.y, vertex.z);
                    }
                }
                Scaling_X = oldScale.x;
                Scaling_Y = oldScale.y;
                Scaling_Z = oldScale.z;
            }
            else
            {
                vec3 oldScale = new vec3(scale_X, scale_Y, scale_Z);
                Scaling_X = oldScale.x + 0.01f;
                Scaling_Y = oldScale.y + 0.01f;
                Scaling_Z = oldScale.z + 0.01f;
                gl.Color(0.33f, 0.33f, 0.33f, 1.0f);
                for (int i = 0; i < FaceList.Count; i++) // Go through each face
                {
                    int[] face = FaceList[i];

                    for (int j = 0; j < FaceList[i].Length; j++)  // Go through each index
                    {
                        vec3 vertex = new vec3(transformationMatrix * new vec4(VertexList[face[j]].x, VertexList[face[j]].y, VertexList[face[j]].z, 1));
                        gl.Vertex(vertex.x, vertex.y, vertex.z);
                    }
                }
                Scaling_X = oldScale.x;
                Scaling_Y = oldScale.y;
                Scaling_Z = oldScale.z;
            }
            gl.End();

            gl.StencilMask(0xFF);
            gl.StencilFunc(OpenGL.GL_ALWAYS, 1, 0xFF);
        }
        private void Drawing(OpenGL gl)
        {
            if (haveTexture) texture.Bind(gl);
            gl.Begin(OpenGL.GL_TRIANGLES);

            if (!haveTexture) gl.Color(color.R, color.G, color.B, color.A);
            else gl.Color(1.0f, 1.0f, 1.0f, 1.0f);
            for (int i = 0; i < FaceList.Count; i++) // Go through each face
            {
                int[] face = FaceList[i];
                int[] texface = TexFaceList[i];
                for (int j = 0; j < FaceList[i].Length; j++)  // Go through each index
                {
                    vec3 vertex = new vec3(transformationMatrix * new vec4(VertexList[face[j]].x, VertexList[face[j]].y, VertexList[face[j]].z, 1));
                    if (haveTexture)
                    {
                        vec2 texcoord = new vec2(TexCoordList[texface[j]].x, TexCoordList[texface[j]].y);
                        gl.TexCoord(texcoord.x, texcoord.y);
                    }
                    gl.Vertex(vertex.x, vertex.y, vertex.z);
                }
            }
            gl.End();
        }
        private void Transformation()
        {
            transformationMatrix = new mat4(1.0f);
            transformationMatrix = glm.translate(transformationMatrix, new vec3(pos_X, pos_Y, pos_Z));
            transformationMatrix = glm.scale(transformationMatrix, new vec3(scale_X, scale_Y, scale_Z));
            transformationMatrix = glm.rotate(transformationMatrix, rot_X, new vec3(1, 0, 0));
            transformationMatrix = glm.rotate(transformationMatrix, rot_Y, new vec3(0, 1, 0));
            transformationMatrix = glm.rotate(transformationMatrix, rot_Z, new vec3(0, 0, 1));
        }

        [Category("Object Properties"),DisplayName("Color"),Description("Color of the object.")]
        public Color color
        { get; set;}
        [Category("Object Properties"), DisplayName("Texture"), Description("Texture of the object.")]
        public Bitmap image
        { get; set; }
        #region Position
        private float pos_X;
        [Category("Position"), DisplayName("X"), Description("The X coordinate of the object.")]
        public float Position_X
        {
            get { return pos_X; }
            set
            {
                pos_X = value;
                Transformation();
            }
        }

        private float pos_Y;
        [Category("Position"), DisplayName("Y"), Description("The Y coordinate of the object.")]
        public float Position_Y
        {
            get { return pos_Y; }
            set
            {
                pos_Y = value;
                Transformation();
            }
        }

        private float pos_Z;
        [Category("Position"), DisplayName("Z"), Description("The Z coordinate of the object.")]
        public float Position_Z
        {
            get { return pos_Z; }
            set
            {
                pos_Z = value;
                Transformation();
            }
        }
        #endregion

        #region Scaling
        private float scale_X = 1;
        [Category("Scaling"), DisplayName("X"), Description("Scale the object by X axis.")]
        public float Scaling_X
        {
            get { return scale_X; }
            set
            {
                scale_X = value;
                Transformation();
            }
        }
        private float scale_Y = 1;
        [Category("Scaling"), DisplayName("Y"), Description("Scale the object by Y axis.")]
        public float Scaling_Y
        {
            get { return scale_Y; }
            set
            {
                scale_Y = value;
                Transformation();
            }
        }
        private float scale_Z = 1;
        [Category("Scaling"), DisplayName("Z"), Description("Scale the object by Z axis.")]
        public float Scaling_Z
        {
            get { return scale_Z; }
            set
            {
                scale_Z = value;
                Transformation();
            }
        }
        #endregion

        #region Rotation
        private float rot_X;
        [Category("Rotation"), DisplayName("X"), Description("Rotate around X axis.")]
        public float Rotation_X
        {
            get { return rot_X; }
            set
            {
                rot_X = value;
                Transformation();
            }
        }
        private float rot_Y;
        [Category("Rotation"), DisplayName("Y"), Description("Rotate around Y axis.")]
        public float Rotation_Y
        {
            get { return rot_Y; }
            set
            {
                rot_Y = value;
                Transformation();
            }
        }
        private float rot_Z;
        [Category("Rotation"), DisplayName("Z"), Description("Rotate around Z axis.")]
        public float Rotation_Z
        {
            get { return rot_Z; }
            set
            {
                rot_Z = value;
                Transformation();
            }
        }
        #endregion

    }
}
