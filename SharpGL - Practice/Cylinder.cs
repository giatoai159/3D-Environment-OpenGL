using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlmNet;

namespace SharpGL___Practice
{
    class Cylinder : Object
    {
        public Cylinder()
        {
            Name = "Cylinder";
            CreateCylinderGeometry();

        }
        private void CreateCylinderGeometry()
        {
            // Verteces top
            VertexList.Add(new vec3(0, 1, -1)); //  Top
            VertexList.Add(new vec3(-1, 1, 1)); // Bottom right
            VertexList.Add(new vec3(1, 1, 1)); // Bottom left
            // Vertices bottom
            VertexList.Add(new vec3(0, -1, -1)); //  Top
            VertexList.Add(new vec3(-1, -1, 1)); // Bottom right
            VertexList.Add(new vec3(1, -1, 1)); // Bottom left
            // Front face
            FaceList.Add(new int[3] { 1, 2, 5 });
            FaceList.Add(new int[3] { 1, 4, 5 });
            // Right face
            FaceList.Add(new int[3] { 0, 1, 4 });
            FaceList.Add(new int[3] { 0, 3, 4 });
            // Left face
            FaceList.Add(new int[3] { 2, 0, 3 });
            FaceList.Add(new int[3] { 2, 5, 3 });
            // Top face
            FaceList.Add(new int[3] { 0, 1, 2 });
            // Bottom face
            FaceList.Add(new int[3] { 3, 4, 5 });
            //~~~~~~~~~~~~~~~~~~~~~~ Texture mapping
            TexCoordList.Add(new vec2(0, 1)); // Top left
            TexCoordList.Add(new vec2(1, 1)); // Top right
            TexCoordList.Add(new vec2(1, 0)); // Bottom right
            TexCoordList.Add(new vec2(0, 0)); // Bottom left
            // Front face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
            // Right face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
            // Left face
            TexFaceList.Add(new int[3] { 3, 2, 1 });
            TexFaceList.Add(new int[3] { 3, 0, 1 });
            // Top face
            TexFaceList.Add(new int[3] { 0, 1, 2 });
            // Bottom face
            TexFaceList.Add(new int[3] { 3, 0, 2 });
        }
    }
}
