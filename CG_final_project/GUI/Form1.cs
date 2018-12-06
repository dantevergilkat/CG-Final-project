using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
	public partial class Form1 : Form
	{
		// Khoi tao doi tuong lop CDrawObject de ve
		CDrawObject drObj = new CDrawObject();
		public Form1()
		{
			InitializeComponent();
		}

		private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
		{
			OpenGL gl = openGLControl1.OpenGL;
			// Clear vung nho dem
			gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

			// Draw a coloured cube
			//drObj.drawColouredCube(gl);

			// Draw pyramid with square bottom
			//drObj.drawPyramidWithSpareBottom(gl);

			// Draw cylinder with triangle bottom
			drObj.drawCylinderWithTriangleBottom(gl);
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
			gl.MatrixMode(OpenGL.GL_MODELVIEW);
			gl.LookAt(
				5, 7, 6,
				0, 0, 0,
				0, 1, 0);

		}
	}
}
