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
	public enum AFFINE
	{
		TRANSLATE,
		ROTATE,
		SCALE
	}

	public partial class Form_3D_Scenes : Form
	{
		// ---------------------------------------Ho tro xu ly texture--------------------------------------------------
        bool isTexture = false; // Bien kiem tra xem co su dung texture hay khong
        string textureLink = ""; // Luu path dan toi file anh texture
        
        // Khoi tao doi tuong lop CDrawObject de ve
        CDrawObject drObj = new CDrawObject();
		TypeObject currentType;
		List<String> listObjName = new List<String>(); // Bien chua ten cac doi tuong da ve
		int indexCurrentObj = -1; // Bien giu index cua doi tuong nguoi dung chon
		Color currentColor = Color.White; // Mau dung hien tai
		bool isChangedColor = false; // Su dung de doi mau obj khi da selected
		// ----------------------------------- Ho tro thao tac affine---------------------------------------------
		AFFINE currentAffine; // Thao tac affine hien tai
		bool isAffine = false; // Bien kiem tra xem nguoi dung chon 1 trong cac affine
		Point3D pos = new Point3D(); // Luu thong so de translate hien tai
		Point3D rotation = new Point3D(); // Luu thong so de rotate hien tai
		Point3D scale = new Point3D(); // Luu thong so de salce hien tai

		List<Point3D> listPos = new List<Point3D>(); // Tao danh sach cac vi tri cua position
		List<Point3D> listRota = new List<Point3D>(); // Tao danh sach cac goc quay cho cac doi tuong cua rotate
		List<Point3D> listScale = new List<Point3D>(); // Tao danh sach cac toa do scale cho cac doi tuong cua scale 
		// ------------------------------------Ho tro camera------------------------------------------------------
		// Khoi tao doi tuong Camera
		CameraRotation cam = new CameraRotation();
		bool isChangedCam = false; // Kiem tra xem co thay doi cam hay khong

		// Bien kiem tra co ve khong?
		bool isDrawing = true;

		public Form_3D_Scenes()
		{
			InitializeComponent();
			this.KeyPreview = true;
			//this.AcceptButton = bt_Enter;
		}

		// Draw mesh surface
        public void SystemDraw(OpenGL gl)
        {
            gl.ClearColor(128.0f / 255.0f, 128.0f / 255.0f, 128.0f / 255.0f, 100.0f / 255.0f); // dark gray
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.LineWidth(1.0f);
			int nTiles = 30;

			for (int i = -30; i <= 30; i++)
            {
                gl.Begin(OpenGL.GL_LINES);               
                // Vẽ song song với Oz
                gl.Vertex(i, 0, nTiles);
                gl.Vertex(i, 0,-nTiles);
                // Vẽ song song với Ox
                gl.Vertex(-nTiles, 0,i);
                gl.Vertex(nTiles, 0,i);
                gl.End();
				gl.Flush();
            }
			#region Draw axis
			//float a = 20.0f;
			//float b = a - 1.0f;

			//         gl.LineWidth(4.0f);
			//         // Ve Ox
			//         gl.Color(255.0 / 255.0, 0.0, 0.0);
			//         gl.Begin(OpenGL.GL_LINES);
			//         gl.Vertex(0, 0, 0);
			//         gl.Vertex(a, 0, 0);
			//         gl.End();
			//gl.Flush();
			//         gl.Begin(OpenGL.GL_TRIANGLES);
			//         gl.Vertex(b, 0, 1);
			//         gl.Vertex(b, 0, -1);
			//         gl.Vertex(a, 0, 0);
			//         gl.End();
			//gl.Flush();

			//// Ve Oy
			//gl.Color(0.0f, 255.0 / 255.0, 0.0);
			//         gl.Begin(OpenGL.GL_LINES);
			//         gl.Vertex(0, 0, 0);
			//         gl.Vertex(0, a, 0);
			//         gl.End();
			//gl.Flush();
			//gl.Begin(OpenGL.GL_TRIANGLES);
			//         gl.Vertex(-1, b, 0);
			//         gl.Vertex(1, b, 0);
			//         gl.Vertex(0, a, 0);
			//         gl.End();
			//gl.Flush();
			//// Ve Oz
			//gl.Color(0.0f, 0.0f, 255.0 / 255.0);
			//         gl.Begin(OpenGL.GL_LINES);
			//         gl.Vertex(0, 0, 0);
			//         gl.Vertex(0, 0, a);
			//         gl.End();
			//gl.Flush();
			//gl.Begin(OpenGL.GL_TRIANGLES);
			//         gl.Vertex(1, 0, b);
			//         gl.Vertex(-1, 0, b);
			//         gl.Vertex(0, 0, a);
			//         gl.End();
			//         gl.Flush();

			//gl.LineWidth(1.0f); // Reset lai do day net ve
			#endregion
		}
        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
		{
			if (isDrawing)
			{
				OpenGL gl = openGLControl1.OpenGL;
				// Clear vung nho dem
				gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

				// ===========================Ve he truc va mat phang day====================================
				SystemDraw(gl);

				//=================================CAMERA ROTATION============================================
				// Camera rotation
				gl.MatrixMode(OpenGL.GL_MODELVIEW);
				gl.LoadIdentity();
				/*gl.LookAt(rotate_x, rotate_y, rotate_z, // camera position (-4,4,-4)
						  1, 0, 1, // look at
						  0, 1, 0); // vector up*/
				double x = cam.getX();
				double y = cam.getY();
				double z = cam.getZ();

				double u_x = cam.getU_X();
				double u_y = cam.getU_Y();
				double u_z = cam.getU_Z();

				// goc quay
				double angle = cam.getAngle();

				gl.LookAt(x, y, z,
						  1, 0, 1,
						  u_x, u_y, u_z);

				//============================================================================================

				// Kiem tra khi nguoi dung select 1 doi tuong va co thay doi mau to khong
				if (isChangedColor)
				{
					// Doi mau nguoi chung luc click vao listbox
					drObj.setColorOfOneObj(indexCurrentObj, currentColor);
					isChangedColor = false; // reset lai
				}

				if (isAffine)
				{
					switch (currentAffine)
					{
						case AFFINE.TRANSLATE:
							drObj.updateTranCoor(indexCurrentObj, pos.x, pos.y, pos.z);
							break;
						case AFFINE.ROTATE:
							drObj.updateRotaCoor(indexCurrentObj, rotation.x, rotation.y, rotation.z);
							break;
						case AFFINE.SCALE:
							drObj.updateScaleCoor(indexCurrentObj, scale.x, scale.y, scale.z);
							break;
					}

				}


				// Draw object
				if (angle != 90 && angle != 270)
					drObj.draw(gl, indexCurrentObj);

				// Reset lai isDrawing
				isDrawing = false;
			}
		}

		private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
		{
			OpenGL gl = openGLControl1.OpenGL;
			// Set man hinh OpenGL la dark gray
			gl.ClearColor(128.0f / 255.0f, 128.0f / 255.0f, 128.0f / 255.0f, 100.0f / 255.0f);
			
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

			////set ma tran model view
			//gl.MatrixMode(OpenGL.GL_MODELVIEW);
			//gl.LookAt(
			//	5, 7, 6,
			//	0, 0, 0,
			//	0, 1, 0);

		}

		private void bt_Cube_Click(object sender, EventArgs e)
		{
			currentType = TypeObject.CUBE;
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
			listObjName.Add("Cube " + "(" + count.ToString() + ")"); // Them vao list quan ly
			listPos.Add(new Point3D()); // Them toa position cho obj nay
			listRota.Add(new Point3D()); // Them toa do rotation cho obj nay
			listScale.Add(new Point3D(1, 1, 1)); // Them toa do scale cho obj nay
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
			lstBox_SampleScene.SelectedIndex = count; // In dam obj duoc ve tren listbox
			indexCurrentObj = count; // Luu index cua Obj vua moi ve
			isDrawing = true; // Cap nhat de ve
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
			listObjName.Add("Pyramid " + "(" + count.ToString() + ")"); // Them vao list quan ly
			listPos.Add(new Point3D()); // Them toa position cho obj nay
			listRota.Add(new Point3D()); // Them toa do rotation cho obj nay
			listScale.Add(new Point3D(1, 1, 1)); // Them toa do scale cho obj nay
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
			
			lstBox_SampleScene.SelectedIndex = count; // In dam obj duoc ve tren listbox
			indexCurrentObj = count; // Luu index cua Obj vua moi ve
			isDrawing = true; // Cap nhat de ve
		}

		// Su kien nhan hinh lang tru
		private void bt_Prism_Click(object sender, EventArgs e)
		{
			currentType = TypeObject.TRIANGULAR_PRISM;
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
			listObjName.Add("Prism " + "(" + count.ToString() + ")"); // Them vao list quan ly
			listPos.Add(new Point3D()); // Them toa position cho obj nay
			listRota.Add(new Point3D()); // Them toa do rotation cho obj nay
			listScale.Add(new Point3D(1, 1, 1)); // Them toa do scale cho obj nay
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
			lstBox_SampleScene.SelectedIndex = count; // In dam obj duoc ve tren listbox
			indexCurrentObj = count; // Luu index cua Obj vua moi ve
			isDrawing = true; // Cap nhat de ve
		}

		private void lstBox_SampleScene_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Lay index nguoi dung chon
			indexCurrentObj = lstBox_SampleScene.SelectedIndex;
			isAffine = false;

			// Load cac toa do Position cua obj
			textBox_PosX.Text = listPos[indexCurrentObj].x.ToString();
			textBox_PosY.Text = listPos[indexCurrentObj].y.ToString();
			textBox_PosZ.Text = listPos[indexCurrentObj].z.ToString();

			// Load cac toa do cho Rotation cua obj
			textBox_RotateX.Text = listRota[indexCurrentObj].x.ToString();
			textBox_RotateY.Text = listRota[indexCurrentObj].y.ToString();
			textBox_RotateZ.Text = listRota[indexCurrentObj].z.ToString();

			// Load cac toa do cho Scale cua obj
			textBox_ScaleX.Text = listScale[indexCurrentObj].x.ToString();
			textBox_ScaleY.Text = listScale[indexCurrentObj].y.ToString();
			textBox_ScaleZ.Text = listScale[indexCurrentObj].z.ToString();

			// Cap nhat toa do cua pos
			pos = new Point3D(listPos[indexCurrentObj]);
			// Cap nhat toa do cua rota
			rotation = new Point3D(listRota[indexCurrentObj]);
			// Cap nhat toa doa cua scale
			scale = new Point3D(listScale[indexCurrentObj]);

			// Reset isTexture va textLink
			isTexture = false;
			textureLink = "";

			isDrawing = true; // Cap nhat de ve

			

		}

		private void bt_Palette_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				currentColor = colorDialog1.Color;
				bt_Color.BackColor = currentColor;

				if (indexCurrentObj != -1)
				{
					isChangedColor = true;
					isDrawing = true; // Cap nhat de ve
				}
			}
		}

		private void bt_Color_Click(object sender, EventArgs e)
		{
			currentColor = bt_Color.BackColor;
			if (indexCurrentObj != -1)
			{
				isChangedColor = true;
				isDrawing = true; // Cap nhat de ve
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 87) // press W
			{
				//rotate_y += 0.2;
				cam.upRotate();
			}
			else if (e.KeyValue == 83) // press S
			{
				//rotate_y -= 0.2;
				cam.downRotate();
			}
			else if (e.KeyValue == 68) // press D
			{
				if (cam.getU_Y() == -1)
					cam.rightRotate();
				else
					cam.leftRotate();
			}
			else if (e.KeyValue == 65) // press A
			{
				if (cam.getU_Y() == -1)
					cam.leftRotate();
				else
					cam.rightRotate();
			}
            else if (e.KeyValue == 90) // press Z
            {
                cam.further();
            }
            else if (e.KeyValue == 88 && cam.getDist() >= 1) // press X
            {
                cam.nearer();
            }

			// Cat nhat thong tin cho camera
			textBox_Cam_PosX.Text = cam.getX().ToString();
			textBox_Cam_PosY.Text = cam.getY().ToString();
			textBox_Cam_PosZ.Text = cam.getZ().ToString();

			textBox_VpX.Text = cam.getV_X().ToString();
			textBox_VpY.Text = cam.getV_Y().ToString();
			textBox_VpZ.Text = cam.getV_Z().ToString();

			textBox_View.Text = cam.getAngle().ToString();

			isDrawing = true; // Cap nhat de ve
		}

		private void textBox_PosX_Click(object sender, EventArgs e)
		{
			textBox_PosX.SelectAll();
		}

		private void textBox_PosY_Click(object sender, EventArgs e)
		{
			textBox_PosY.SelectAll();
		}

		private void textBox_PosZ_Click(object sender, EventArgs e)
		{
			textBox_PosZ.SelectAll();
		}

		private void textBox_PosX_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			else
			{
				isAffine = true;
				currentAffine = AFFINE.TRANSLATE;
			}
		}

		private void textBox_PosY_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			else
			{
				isAffine = true;
				currentAffine = AFFINE.TRANSLATE;
			}
		}

		private void textBox_PosZ_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			else
			{
				isAffine = true;
				currentAffine = AFFINE.TRANSLATE;
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Khoi tao mang doi tuong moi
			drObj = new CDrawObject();
			listObjName.Clear(); // Xoa het cac doi tuong cu

			indexCurrentObj = -1; // Bien giu index cua doi tuong nguoi dung chon
			currentColor = Color.White; // Mau dung hien tai
			isChangedColor = false; // Su dung de doi mau obj khi da selected
			isAffine = false; // Bien kiem tra xem nguoi dung chon 1 trong cac affine
			pos = new Point3D();
			rotation = new Point3D();
			scale = new Point3D();

			// Khoi tao doi tuong Camera
			cam = new CameraRotation();

			// Xoa listBox Sample Scene
			lstBox_SampleScene.Items.Clear();

			// Xoa cac bien ho tro affine
			listPos.Clear();
			listRota.Clear();
			listScale.Clear();

			// reset lai isTexture va path
			isTexture = false;
			textureLink = "";

			// reset lai bien isDrawing
			isDrawing = true;

			// Gan tat cac textbox trong Transform ve gia tri mac dinh ban dau
			textBox_PosX.Text = "0";
			textBox_PosY.Text = "0";
			textBox_PosZ.Text = "0";

			textBox_RotateX.Text = "0";
			textBox_RotateY.Text = "0";
			textBox_RotateZ.Text = "0";

			textBox_ScaleX.Text = "1";
			textBox_ScaleY.Text = "1";
			textBox_ScaleZ.Text = "1";


			// Gan tat cac ca textbox cua cam ve gia tri mac dinh ban dau
			textBox_Cam_PosX.Text = "-4";
			textBox_Cam_PosX.Text = "0";
			textBox_Cam_PosX.Text = "-4";

			textBox_VpX.Text = "1";
			textBox_VpX.Text = "0";
			textBox_VpX.Text = "1";

			textBox_View.Text = "0";

		}

		private void bt_Enter_Click(object sender, EventArgs e)
		{
			bool success = true;
			success = float.TryParse(textBox_PosX.Text, out pos.x);
			success = float.TryParse(textBox_PosY.Text, out pos.y);
			success = float.TryParse(textBox_PosZ.Text, out pos.z);
			if (success)
			{
				// Cap nhat toa do pos vao list
				listPos[indexCurrentObj] = new Point3D(pos);
				// Cap nhat la co thuc hien bien doi affine
				isAffine = true;
			}
			success = true;
			success = float.TryParse(textBox_RotateX.Text, out rotation.x);
			success = float.TryParse(textBox_RotateY.Text, out rotation.y);
			success = float.TryParse(textBox_RotateZ.Text, out rotation.z);
			if (success)
			{
				// Cap nhat toa do rotation vao list
				listRota[indexCurrentObj] = new Point3D(rotation);
				// Cap nhat la co thuc hien bien doi affine
				isAffine = true;
			}
			success = true;
			success = float.TryParse(textBox_ScaleX.Text, out scale.x);
			success = float.TryParse(textBox_ScaleY.Text, out scale.y);
			success = float.TryParse(textBox_ScaleZ.Text, out scale.z);
			if (success)
			{
				// Cap nhat toa do rotation vao list
				listScale[indexCurrentObj] = new Point3D(scale);
				// Cap nhat la co thuc hien bien doi affine
				isAffine = true;
			}
			isDrawing = true; // Cap nhat de ve
		}

		private void bt_Stop_Click(object sender, EventArgs e)
		{
			isAffine = false;
		}

        

        private void textBox_RotateX_Click(object sender, EventArgs e)
        {
            textBox_RotateX.SelectAll();
        }

        private void textBox_RotateY_Click(object sender, EventArgs e)
        {
            textBox_RotateY.SelectAll();
        }

        private void textBox_RotateZ_Click(object sender, EventArgs e)
        {
            textBox_RotateZ.SelectAll();
        }

        private void textBox_RotateX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                isAffine = true;
                currentAffine = AFFINE.ROTATE;
            }
        }

        private void textBox_RotateY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                isAffine = true;
                currentAffine = AFFINE.ROTATE;
            }
        }

        private void textBox_RotateZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                isAffine = true;
                currentAffine = AFFINE.ROTATE;
            }
        }

        private void textBox_ScaleX_Click(object sender, EventArgs e)
        {
            textBox_ScaleX.SelectAll();
        }

        private void textBox_ScaleY_Click(object sender, EventArgs e)
        {
            textBox_ScaleY.SelectAll();
        }

        private void textBox_ScaleZ_Click(object sender, EventArgs e)
        {
            textBox_ScaleZ.SelectAll();
        }

        private void textBox_ScaleX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                isAffine = true;
                currentAffine = AFFINE.SCALE;
            }
        }

        private void textBox_ScaleY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                isAffine = true;
                currentAffine = AFFINE.SCALE;
            }
        }

        private void textBox_ScaleZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                isAffine = true;
                currentAffine = AFFINE.SCALE;
            }
        }

        private void TextureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog myTextureLink = new OpenFileDialog();
            if (myTextureLink.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
				isTexture = true;
				textureLink = myTextureLink.FileName;
                textureLink = textureLink.Replace("\\", "\\\\");
				if (indexCurrentObj != -1)
				{
					drObj.setTexture(indexCurrentObj, isTexture, textureLink); // Cap nhat texture cho obj nay
																			   // Reset lai
					isTexture = false;
					textureLink = "";
				}

				isDrawing = true; // Cap nhat de ve
			}
		}

		private void Form_3D_Scenes_KeyDown(object sender, KeyEventArgs e)
		{
			// Xu ly khi nguoi dung nhan Escape
			if (e.KeyCode == Keys.Escape)
				bt_Stop_Click(sender, e);
		}

		private void textBox_PosX_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				bt_Enter_Click(sender, e);
			}
		}

		private void textBox_PosY_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Enter_Click(sender, e);
			}
		}

		private void textBox_PosZ_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Enter_Click(sender, e);
			}
		}

		private void textBox_RotateX_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Enter_Click(sender, e);
			}

		}

		private void textBox_RotateY_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Enter_Click(sender, e);
			}

		}

		private void textBox_RotateZ_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Enter_Click(sender, e);
			}

		}

		private void textBox_ScaleX_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Enter_Click(sender, e);
			}
		}

		private void textBox_ScaleY_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Enter_Click(sender, e);
			}
		}

		private void textBox_ScaleZ_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Enter_Click(sender, e);
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Tat chuong trinh
			Application.Exit();
		}

		private void bt_Cam_Enter_Click(object sender, EventArgs e)
		{
			bool success = true;
			Point3D cam_pos = new Point3D();
			success = float.TryParse(textBox_Cam_PosX.Text, out cam_pos.x);
			success = float.TryParse(textBox_Cam_PosY.Text, out cam_pos.y);
			success = float.TryParse(textBox_Cam_PosZ.Text, out cam_pos.z);

			
			if (success)
			{
				// Cat nhat toa do camera vao bien cam
				cam.setPos(cam_pos.x, cam_pos.y, cam_pos.z);
				// Cap nhat la co thuc hien bien doi tren camera
				isChangedCam = true;
			}

			Point3D view_point = new Point3D();
			success = float.TryParse(textBox_VpX.Text, out view_point.x);
			success = float.TryParse(textBox_VpY.Text, out view_point.y);
			success = float.TryParse(textBox_VpZ.Text, out view_point.z);

			
			if (success)
			{
				// Cat nhat viewpoint vao bien cam
				cam.setPos(view_point.x, view_point.y, view_point.z);
				// Cap nhat la co thuc hien bien doi tren camera
				isChangedCam = true;
			}

			int angle;
			success = int.TryParse(textBox_View.Text, out angle);
			
			if (success)
			{
				// Cat nhat angle vao bien cam
				cam.setAngle(angle);
				// Cap nhat la co thuc hien bien doi tren camera
				isChangedCam = true;
			}

			isDrawing = true; // Cap nhat de ve
		}

		private void textBox_Cam_PosX_Click(object sender, EventArgs e)
		{
			textBox_Cam_PosX.SelectAll();
		}

		private void textBox_Cam_PosY_Click(object sender, EventArgs e)
		{
			textBox_Cam_PosY.SelectAll();
		}

		private void textBox_Cam_PosZ_Click(object sender, EventArgs e)
		{
			textBox_Cam_PosZ.SelectAll();
		}

		private void textBox_VpX_Click(object sender, EventArgs e)
		{
			textBox_VpX.SelectAll();
		}

		private void textBox_VpY_Click(object sender, EventArgs e)
		{
			textBox_VpY.SelectAll();
		}

		private void textBox_VpZ_Click(object sender, EventArgs e)
		{
			textBox_VpZ.SelectAll();
		}

		private void textBox_View_Click(object sender, EventArgs e)
		{
			textBox_View.SelectAll();
		}

		private void textBox_Cam_PosX_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Cam_Enter_Click(sender, e);
			}
		}

		private void textBox_Cam_PosY_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Cam_Enter_Click(sender, e);
			}
		}

		private void textBox_Cam_PosZ_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Cam_Enter_Click(sender, e);
			}
		}

		private void textBox_VpX_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Cam_Enter_Click(sender, e);
			}
		}

		private void textBox_VpY_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Cam_Enter_Click(sender, e);
			}
		}

		private void textBox_VpZ_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Cam_Enter_Click(sender, e);
			}
		}

		private void textBox_View_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Cam_Enter_Click(sender, e);
			}
		}

		private void textBox_Cam_PosX_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			else
			{
				isChangedCam = true; // Cat nhat co thay doi cam
			}
		}

		private void textBox_Cam_PosY_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			else
			{
				isChangedCam = true; // Cat nhat co thay doi cam
			}
		}

		private void textBox_Cam_PosZ_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			else
			{
				isChangedCam = true; // Cat nhat co thay doi cam
			}
		}

		private void textBox_VpX_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '.' && e.KeyChar != '-'
				&& !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				isChangedCam = true; // Cat nhat co thay doi cam
			}
		}

		private void textBox_VpY_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '.' && e.KeyChar != '-'
				&& !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				isChangedCam = true; // Cat nhat co thay doi cam
			}
		}

		private void textBox_VpZ_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '.' && e.KeyChar != '-' 
				&& !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				isChangedCam = true; // Cat nhat co thay doi cam
			}
		}

		private void textBox_View_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			else
			{
				isChangedCam = true; // Cat nhat co thay doi cam
			}
		}
	}
		
	
}
