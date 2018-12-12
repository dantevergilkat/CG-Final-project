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
		int indexCurrentObj = -1; // Bien giu index cua doi tuong nguoi dung chon
		Color currentColor = Color.White; // Mau dung hien tai
		bool isChangedColor = false; // Su dung de doi mau obj khi da selected
        bool isTexture = false; // Bien kiem tra xem co su dung texture hay khong
        string textureLink = ""; // Luu path dan toi file anh texture
        public Form1()
		{
			InitializeComponent();
		}
        public void SystemDraw(OpenGL gl)
        {
            gl.ClearColor(0, 0, 0, 0);
            gl.Enable(OpenGL.GL_SMOOTH_LINE_WIDTH_GRANULARITY);
            gl.LineWidth(4);
            // Ve Ox
            gl.Color(102 / 255.0, 255 / 255.0, 51 / 255.0);
            gl.Begin(OpenGL.GL_LINES);          
            gl.Vertex(0, 0, 0);
            gl.Vertex(10, 0, 0);         
            gl.End();
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Vertex(9, 0, 2);
            gl.Vertex(9, 0, -2);
            gl.Vertex(10, 0, 0);
            gl.End();

            // Ve Oy
            gl.Color(51 / 255.0, 153 / 255.0, 51 / 255.0);
            gl.Begin(OpenGL.GL_LINES);            
            gl.Vertex(0, 0, 0);
            gl.Vertex(0, 10, 0);
            gl.End();
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Vertex(-2, 9, 0);
            gl.Vertex(2, 9, 0);
            gl.Vertex(0, 10, 0);
            gl.End();

            // Ve Oz
            gl.Color(242 / 255.0, 236 / 255.0, 255 / 255.0);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(0, 0, 0);
            gl.Vertex(0, 0, 10);
            gl.End();
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Vertex(2, 0, 9);
            gl.Vertex(-2, 0, 9);
            gl.Vertex(0, 0, 10);
            gl.End();
            gl.Flush();
        }
        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
		{
			OpenGL gl = openGLControl1.OpenGL;
			// Clear vung nho dem
			gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            SystemDraw(gl);

            // Kiem tra khi nguoi dung select 1 doi tuong va co thay doi mau to khong
            if (isChangedColor)
			{
				// Doi mau nguoi chung luc click vao listbox
				drObj.setColorOfOneObj(indexCurrentObj, currentColor);
				isChangedColor = false; // reset lai
			}
            // Draw object
            drObj.draw(gl, indexCurrentObj,ref isTexture,ref textureLink);
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
			gl.Perspective(160,
			openGLControl1.Width / openGLControl1.Height,
				1.0, 20.0);
	
			//set ma tran model view
			gl.MatrixMode(OpenGL.GL_MODELVIEW);
			gl.LookAt(
				1, 2, 3,
				0, 0, 0,
				0, 1, 0);

		}

		private void bt_Cube_Click(object sender, EventArgs e)
		{
			currentType = TypeObject.CUBE;
            if (isTexture == true)
            {
                drObj.addObj(currentType, currentColor,isTexture,textureLink); // Them object vao list luu tru
                isTexture = false;
                textureLink = "";
            }
            else
            {
                drObj.addObj(currentType, currentColor); // Them object vao list luu tru
            }
			int count = listObjName.Count(); // Lay so phan tu hien tai
			listObjName.Add("Cube " + count.ToString()); // Them vao list quan ly
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
			lstBox_SampleScene.SelectedIndex = count; // In dam obj duoc ve tren listbox
			indexCurrentObj = count; // Luu index cua Obj vua moi ve
		}

		private void bt_Pyramid_Click(object sender, EventArgs e)
		{
			currentType = TypeObject.SQUARE_PYRAMID;
            if (isTexture == true)
            {
                drObj.addObj(currentType, currentColor, isTexture, textureLink); // Them object vao list luu tru
                isTexture = false;
                textureLink = "";
            }
            else
            {
                drObj.addObj(currentType, currentColor); // Them object vao list luu tru
            }
            int count = listObjName.Count(); // Lay so phan tu hien tai
			listObjName.Add("Pyramid " + count.ToString()); // Them vao list quan ly
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
			lstBox_SampleScene.SelectedIndex = count; // In dam obj duoc ve tren listbox
			indexCurrentObj = count; // Luu index cua Obj vua moi ve
		}

		private void bt_Prism_Click(object sender, EventArgs e)
		{
			currentType = TypeObject.TRIANGULAR_PRISM;
            drObj.addObj(currentType, currentColor); // Them object vao list luu tru      
            int count = listObjName.Count(); // Lay so phan tu hien tai
			listObjName.Add("Prism " + count.ToString()); // Them vao list quan ly
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
			lstBox_SampleScene.SelectedIndex = count; // In dam obj duoc ve tren listbox
			indexCurrentObj = count; // Luu index cua Obj vua moi ve
		}

		private void lstBox_SampleScene_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Lay index nguoi dung chon
			indexCurrentObj = lstBox_SampleScene.SelectedIndex;
		}

		private void bt_Palette_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK) {
				currentColor = colorDialog1.Color;
				bt_Color.BackColor = currentColor;

				if (indexCurrentObj != -1) {
					isChangedColor = true;
				}
			}
		}

		private void bt_Color_Click(object sender, EventArgs e)
		{
			currentColor = bt_Color.BackColor;
			if (indexCurrentObj != -1)
			{
				isChangedColor = true;
			}
		}

        private void TextureButton_Click(object sender, EventArgs e)
        {
            isTexture = true;
            OpenFileDialog myTextureLink = new OpenFileDialog();
            if(myTextureLink.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textureLink = myTextureLink.FileName;
                textureLink = textureLink.Replace("\\","\\\\");
                MessageBox.Show(textureLink);
            }
        }
    }
}
