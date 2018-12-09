﻿using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GlmNet;
using BUS;

namespace GUI
{
	public partial class Form1 : Form
	{
        /*static vec4 vec1 = new vec4(1, 2, 3, 4);
        static vec4 vec2 = new vec4(1, 2, 3, 4);
        static vec4 vec3 = new vec4(1, 2, 3, 4);
        static vec4 vec4 = new vec4(1, 2, 3, 4);
        static vec4[] vector = new vec4[4] { vec1, vec2, vec3, vec4 };
        static mat4 matrix1 = new mat4(vector);
        static mat4 matrix2 = new mat4();
        mat4 matrix3 = matrix1;*/

        // camera position
        double rotate_x = -4;
        double rotate_y = 4;
        double rotate_z = -4;

        // Khoi tao doi tuong lop CDrawObject de ve
        CDrawObject drObj = new CDrawObject();
		public Form1()
		{
            this.KeyPreview = true;
			InitializeComponent();
		}

		private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
		{
			OpenGL gl = openGLControl1.OpenGL;
			// Clear vung nho dem
			gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            // Camera rotation
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();
            gl.LookAt(rotate_x, rotate_y, rotate_z, // camera position (-4,4,-4)
                      1, 0, 1, // look at
                      0, 1, 0); // vector up

			// Draw a coloured cube
			drObj.drawColouredCube(gl);

            // Draw pyramid with square bottom
            //drObj.drawPyramidWithSpareBottom(gl);

            // Draw cylinder with triangle bottom
            //drObj.drawCylinderWithTriangleBottom(gl);
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
		{
			OpenGL gl = openGLControl1.OpenGL;
			// Set man hinh OpenGL la den
			gl.ClearColor(0, 0, 0, 0);
		}

		private void openGLControl1_Resized(object sender, EventArgs e)
		{
			OpenGL gl = openGLControl1.OpenGL;

			//set ma tran viewport
			// chiem toan bo cua so cua OpenGL
			gl.Viewport(
				0, 0,
				openGLControl1.Width,
				openGLControl1.Height);

			//set ma tran phep chieu
			gl.MatrixMode(OpenGL.GL_PROJECTION);
			// Nhan voi ma tran don vi
			gl.LoadIdentity();
			// Chieu phoi canh
			gl.Perspective(60,
			openGLControl1.Width / openGLControl1.Height,
				1.0, 20.0);
	
			//set ma tran model view
			/*gl.MatrixMode(OpenGL.GL_MODELVIEW);
			gl.LookAt(
				-4, 4, -4,
				0, 0, 0,
				0, 1, 0);*/

		}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 87)
            {
                rotate_y += 0.2;
            }
            else if (e.KeyValue == 83)
                rotate_y -= 0.2;
            else if (e.KeyValue == 68)
            {
                double tmp_x = rotate_x;
                double tmp_z = rotate_z;
                //rotate_x = Math.Cos(0.1) * tmp_x + Math.Sin(0.1) * tmp_z;
                //rotate_z = Math.Sin(0.1) * (-1) * tmp_x + Math.Cos(0.1) * tmp_z;
                double center_x = 1;
                double center_z = 1;
                rotate_x = Math.Cos(-0.1) * tmp_x + Math.Sin(-0.1) * tmp_z * (-1) - Math.Cos(-0.1) * center_x + Math.Sin(-0.1) * center_z + center_x;
                rotate_z = Math.Sin(-0.1) * tmp_x + Math.Cos(-0.1) * tmp_z - Math.Sin(-0.1) * center_x - Math.Cos(-0.1) * center_z + center_z;
            }
            else if (e.KeyValue == 65)
            {
                double tmp_x = rotate_x;
                double tmp_z = rotate_z;
                double center_x = 1;
                double center_z = 1;
                rotate_x = Math.Cos(0.1) * tmp_x + Math.Sin(0.1) * tmp_z * (-1)- Math.Cos(0.1) * center_x + Math.Sin(0.1) * center_z + center_x;
                rotate_z = Math.Sin(0.1) * tmp_x + Math.Cos(0.1) * tmp_z- Math.Sin(0.1) * center_x - Math.Cos(0.1) * center_z + center_z;
            }

        }
    }
}
