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
		TypeObject currentType;
		List<String> listObjName = new List<String>(); // Bien chua ten cac doi tuong da ve
		
		public Form1()
		{
			InitializeComponent();
		}

		private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
		{
			OpenGL gl = openGLControl1.OpenGL;
			// Clear vung nho dem
			gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

			// Draw object
			drObj.draw(gl);

		
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

		private void bt_Cube_Click(object sender, EventArgs e)
		{
			currentType = TypeObject.CUBE;
			drObj.addObj(currentType); // Them object vao list luu tru
			int count = listObjName.Count(); // Lay so phan tu hien tai
			listObjName.Add("Cube " + count.ToString()); // Them vao list quan ly
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
		}

		private void bt_Pyramid_Click(object sender, EventArgs e)
		{
			currentType = TypeObject.SQUARE_PYRAMID;
			drObj.addObj(currentType); // Them object vao list luu tru
			int count = listObjName.Count(); // Lay so phan tu hien tai
			listObjName.Add("Pyramid " + count.ToString()); // Them vao list quan ly
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
		}

		private void bt_Prism_Click(object sender, EventArgs e)
		{
			currentType = TypeObject.TRIANGULAR_PRISM;
			drObj.addObj(currentType); // Them object vao list luu tru
			int count = listObjName.Count(); // Lay so phan tu hien tai
			listObjName.Add("Prism " + count.ToString()); // Them vao list quan ly
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
		}
	}
}
