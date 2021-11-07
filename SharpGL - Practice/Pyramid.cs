using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlmNet;

namespace SharpGL___Practice
{
    class Pyramid : Object
    {
        public Pyramid()
        {
            Name = "Pyramid";
            CreatePyramidGeometry();

        }
        private void CreatePyramidGeometry()
        {
            // Vertex top of cone
            VertexList.Add(new vec3(0, 1, 0)); // Top
            // Vertices bottom of cone y = -1
            VertexList.Add(new vec3(-1, -1, 1)); //  Bottom left
            VertexList.Add(new vec3(1, -1, 1)); // Bottom right
            VertexList.Add(new vec3(1, -1, -1)); // Top right
            VertexList.Add(new vec3(-1, -1, -1)); // Top left
            // Front face
            FaceList.Add(new int[3] { 0, 1, 2 });
            // Back face
            FaceList.Add(new int[3] { 0, 3, 4 });
            // Bottom face
            FaceList.Add(new int[3] { 1, 4, 3 });
            FaceList.Add(new int[3] { 1, 2, 3 });
            // Left face
            FaceList.Add(new int[3] { 0, 4, 1 });
            // Right face
            FaceList.Add(new int[3] { 0, 2, 3 });
            //~~~~~~~~~~~~~~~~~~~~~~ Texture mapping
            TexCoordList.Add(new vec2(0, 1)); // Top left
            TexCoordList.Add(new vec2(1, 1)); // Top right
            TexCoordList.Add(new vec2(1, 0)); // Bottom right
            TexCoordList.Add(new vec2(0, 0)); // Bottom left
            // Front face
            TexFaceList.Add(new int[3] { 2, 1, 0 });
            // Back face
            TexFaceList.Add(new int[3] { 2, 1, 0 });
            // Bottom face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
            // Left face
            TexFaceList.Add(new int[3] { 2, 1, 0 });
            // Right face
            TexFaceList.Add(new int[3] { 2, 1, 0 });
        }
    }
}
