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

	public partial class Form1 : Form
	{
		// Khoi tao doi tuong lop CDrawObject de ve
		CDrawObject drObj = new CDrawObject();
		TypeObject currentType;
		List<String> listObjName = new List<String>(); // Bien chua ten cac doi tuong da ve
		int indexCurrentObj = -1; // Bien giu index cua doi tuong nguoi dung chon
		Color currentColor = Color.White; // Mau dung hien tai
		bool isChangedColor = false; // Su dung de doi mau obj khi da selected
		AFFINE currentAffine; // Thao tac affine hien tai
		Point start = new Point(0, 0); // Luu toa do di chuyen cua nguoi dung
		Point end = new Point(0, 0);
		bool isAffine = false; // Bien kiem tra xem nguoi dung chon 1 trong cac affine
		Point3D pos = new Point3D();
		Point3D rotation;
		Point3D scale;

		List<Point3D> listPos = new List<Point3D>(); // Tao danh sach cac vi tri cua position

		// Khoi tao doi tuong Camera
		CameraRotation cam = new CameraRotation();

		public Form1()
		{
			InitializeComponent();
			this.KeyPreview = true;
			this.AcceptButton = bt_Enter;
		}

		private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
		{
			OpenGL gl = openGLControl1.OpenGL;
			// Clear vung nho dem
			gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

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

						break;
					case AFFINE.SCALE:

						break;
				}
				
			}


			// Draw object
			drObj.draw(gl, indexCurrentObj);
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
			drObj.addObj(currentType, currentColor); // Them object vao list luu tru
			int count = listObjName.Count(); // Lay so phan tu hien tai
			listObjName.Add("Cube " + count.ToString()); // Them vao list quan ly
			listPos.Add(new Point3D()); // Them toa position cho obj nay
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
			lstBox_SampleScene.SelectedIndex = count; // In dam obj duoc ve tren listbox
			indexCurrentObj = count; // Luu index cua Obj vua moi ve
		}

		private void bt_Pyramid_Click(object sender, EventArgs e)
		{
			currentType = TypeObject.SQUARE_PYRAMID;
			drObj.addObj(currentType, currentColor); // Them object vao list luu tru
			int count = listObjName.Count(); // Lay so phan tu hien tai
			listObjName.Add("Pyramid " + count.ToString()); // Them vao list quan ly
			listPos.Add(new Point3D()); // Them toa position cho obj nay
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
			listPos.Add(new Point3D()); // Them toa position cho obj nay
			lstBox_SampleScene.Items.Add(listObjName[count]); // Them item va in ra list box
			lstBox_SampleScene.SelectedIndex = count; // In dam obj duoc ve tren listbox
			indexCurrentObj = count; // Luu index cua Obj vua moi ve
		}

		private void lstBox_SampleScene_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Lay index nguoi dung chon
			indexCurrentObj = lstBox_SampleScene.SelectedIndex;
			isAffine = false;

			// Load cac toa do cua obj
			textBox_PosX.Text = listPos[indexCurrentObj].x.ToString();
			textBox_PosY.Text = listPos[indexCurrentObj].y.ToString();
			textBox_PosZ.Text = listPos[indexCurrentObj].z.ToString();

			// Cap nhat toa do cua pos
			pos = new Point3D(listPos[indexCurrentObj]);

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

		private void bt_Move_Click(object sender, EventArgs e)
		{
			currentAffine = AFFINE.TRANSLATE;
			isAffine = true;
		}

		private void bt_Rotate_Click(object sender, EventArgs e)
		{
			currentAffine = AFFINE.ROTATE;
			isAffine = true;
		}

		private void bt_Scale_Click(object sender, EventArgs e)
		{
			currentAffine = AFFINE.SCALE;
			isAffine = true;
		}

		private void openGLControl1_MouseUp(object sender, MouseEventArgs e)
		{
			// Cap nhat toa do cuoi cung khi user buong chuot
			end = new Point(e.X, e.Y);
		}

		private void openGLControl1_MouseMove(object sender, MouseEventArgs e)
		{
			// Cap nhat toa do khi di chuyen
			end = new Point(e.X, e.Y);
		}

		private void openGLControl1_MouseDown(object sender, MouseEventArgs e)
		{
			// Lay toa do click chuot
			start = new Point(e.X, e.Y);
			end = new Point(e.X, e.Y);
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
			start = new Point(0, 0); // Luu toa do di chuyen cua nguoi dung
			end = new Point(0, 0);
			isAffine = false; // Bien kiem tra xem nguoi dung chon 1 trong cac affine
			pos = new Point3D();
			Point3D rotation;
			Point3D scale;

			// Khoi tao doi tuong Camera
			CameraRotation cam = new CameraRotation();

			// Xoa listBox Sample Scene
			lstBox_SampleScene.Items.Clear();


		}

		private void bt_Enter_Click(object sender, EventArgs e)
		{
			bool success = true;
			success = float.TryParse(textBox_PosX.Text, out pos.x);
			success = float.TryParse(textBox_PosY.Text, out pos.y);
			success = float.TryParse(textBox_PosZ.Text, out pos.z);
			if (success)
			{
				// Cap nhat toa do x vao list
				listPos[indexCurrentObj] = new Point3D(pos);
				// Cap nhat la co thuc hien bien doi affine
				isAffine = true;
			}

		}

		private void bt_Stop_Click(object sender, EventArgs e)
		{
			isAffine = false;
		}
	}
}
