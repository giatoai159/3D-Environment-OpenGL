using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlmNet;
using SharpGL;
using System.Drawing;
using System.Drawing.Imaging;

namespace SharpGL___Practice
{
    class Cube : Object
    {
        public Cube()
        {
            Name = "Cube";
            CreateCubeGeometry();

        }
        private void CreateCubeGeometry()
        {

            // Vertices front of cube (z = 1)
            VertexList.Add(new vec3(-1, 1, 1)); // Top left
            VertexList.Add(new vec3(1, 1, 1)); // Top right
            VertexList.Add(new vec3(1, -1, 1)); // Bottom right
            VertexList.Add(new vec3(-1, -1, 1)); // Bottom left
            // Vertices back of cube (z = -1)
            VertexList.Add(new vec3(-1, 1, -1)); // Top left
            VertexList.Add(new vec3(1, 1, -1)); // Top right
            VertexList.Add(new vec3(1, -1, -1)); // Bottom right
            VertexList.Add(new vec3(-1, -1, -1)); // Bottom left
            // Front face
            FaceList.Add(new int[3] { 0, 1, 2 });
            FaceList.Add(new int[3] { 0, 3, 2 });
            // Back face
            FaceList.Add(new int[3] { 4, 5, 6 });
            FaceList.Add(new int[3] { 4, 7, 6 });
            // Top face
            FaceList.Add(new int[3] { 4, 5, 1 });
            FaceList.Add(new int[3] { 4, 0, 1 });
            // Bottom face
            FaceList.Add(new int[3] { 7, 6, 2 });
            FaceList.Add(new int[3] { 7, 3, 2 });
            // Left face
            FaceList.Add(new int[3] { 4, 0, 7 });
            FaceList.Add(new int[3] { 4, 7, 3 });
            // Right face
            FaceList.Add(new int[3] { 1, 5, 6 });
            FaceList.Add(new int[3] { 1, 2, 6 });
            //~~~~~~~~~~~~~~~~~~~~~~ Texture mapping
            TexCoordList.Add(new vec2(0, 1)); // Top left
            TexCoordList.Add(new vec2(1, 1)); // Top right
            TexCoordList.Add(new vec2(1, 0)); // Bottom right
            TexCoordList.Add(new vec2(0, 0)); // Bottom left
            // Front face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
            // Back face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
            // Top face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
            // Bottom face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
            // Left face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
            // Right face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
        }
    }
}
