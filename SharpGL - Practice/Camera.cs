using System;
using System.ComponentModel;
using GlmNet;

namespace SharpGL___Practice
{
    class Camera
    {
        private double _FoV;
        private float _Yaw;
        private float _Pitch;
        private float _camPosX;
        private float _camPosY;
        private float _camPosZ;
        private vec3 _camPosition;
        private vec3 _camDirection;
        private vec3 _camFront;
        private vec3 _camUp;
        private float camSensitivity = 3f;
        private float camSpeed = 0.2f;
        public Camera()
        {
            _camPosX = 5;
            _camPosY = 5;
            _camPosZ = 5;
            _camPosition = new vec3(_camPosX, _camPosY, _camPosZ);
            _camFront = new vec3(0, 0, 0);
            _camUp = new vec3(0, 1, 0);
        }

        #region Getter Setter
        [Category("Camera Position")]
        [Description("WASD to move the camera")]
        [DisplayName("X")]
        public float camPosX
        {
            get { return _camPosX; }
            set { _camPosX = value; _camPosition.x = value; }
        }

        [Category("Camera Position")]
        [Description("WASD to move the camera")]
        [DisplayName("Y")]
        public float camPosY
        {
            get { return _camPosY; }
            set { _camPosY = value; _camPosition.y = value; }
        }

        [Category("Camera Position")]
        [Description("WASD to move the camera")]
        [DisplayName("Z")]
        public float camPosZ
        {
            get { return _camPosZ; }
            set { _camPosZ = value; _camPosition.z = value; }
        }

        [Category("Camera Properties")]
        [Description("Z to Zoom In, X to Zoom Out")]
        public double FoV
        {
            get { return _FoV; }
            set
            {
                if (value < 0) _FoV = 0;
                else if (value > 180) _FoV = 180;
                else _FoV = value; 
            }
        }

        [Category("Camera Properties")]
        [Description("Left or Right arrow key to look Left or Right")]
        public float Yaw
        {
            get { return _Yaw; }
            set
            {
                if (value > 360) _Yaw = 0;
                else if (value < 0) _Yaw = 360;
                else _Yaw = value;
                _camDirection.x = (float)(Math.Cos(glm.radians(Yaw)) * Math.Cos(glm.radians(Pitch)));
                _camDirection.y = (float)Math.Sin(glm.radians(Pitch));
                _camDirection.z = (float)(Math.Sin(glm.radians(Yaw)) * Math.Cos(glm.radians(Pitch)));
                camFront = glm.normalize(_camDirection);
            }
        }
        [Category("Camera Properties")]
        [Description("Up or Down arrow key to look Up or Down")]
        public float Pitch
        {
            get { return _Pitch; }
            set
            {
                if (value > 89.0f) _Pitch = 89.0f;
                else if (value < -89.0f) _Pitch = -89.0f;
                else _Pitch = value;
                _camDirection.x = (float)(Math.Cos(glm.radians(Yaw)) * Math.Cos(glm.radians(Pitch)));
                _camDirection.y = (float)Math.Sin(glm.radians(Pitch));
                _camDirection.z = (float)(Math.Sin(glm.radians(Yaw)) * Math.Cos(glm.radians(Pitch)));
                camFront = glm.normalize(_camDirection);
            }
        }
        [Browsable(false)]
        public vec3 camPosition
        {
            get { return _camPosition; }
            set { _camPosition = value; _camPosX = value.x; _camPosY = value.y; _camPosZ = value.z; }

        }
        [Browsable(false)]
        public vec3 camUp
        {
            get { return _camUp; }
            set { _camUp = value; }
        }
        [Browsable(false)]
        public vec3 camFront
        {
            get { return _camFront; }
            set { _camFront = value; }
        }
        #endregion

        #region Camera Movements
        public void ZoomIn()
        {
            if (FoV <= 0) FoV = 0;
            else FoV -= 2;
        }

        public void ZoomOut()
        {
            if (FoV >= 180) FoV = 180;
            else FoV += 2;
        }
        public void LookUp()
        {
            Pitch += camSensitivity;
        }
        public void LookDown()
        {
            Pitch -= camSensitivity;
        }
        public void LookLeft()
        {
            Yaw -= camSensitivity;
        }
        public void LookRight()
        {
            Yaw += camSensitivity;
        }
        public void GoForward()
        {
            camPosition += camSpeed * camFront;
        }
        public void GoBack()
        {
            camPosition -= camSpeed * camFront;
        }
        public void GoUp()
        {
            _camPosition.y += camSpeed;
            camPosY += camSpeed;
        }
        public void GoDown()
        {
            _camPosition.y -= camSpeed;
            camPosY -= camSpeed;
        }
        public void StrafeLeft()
        {
            camPosition -= camSpeed * glm.normalize(glm.cross(camFront,camUp));
        }
        public void StrafeRight()
        {
            camPosition += camSpeed * glm.normalize(glm.cross(camFront, camUp));
        }
        #endregion
    }
}
