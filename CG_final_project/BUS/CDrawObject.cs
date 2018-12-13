using SharpGL;
using SharpGL.SceneGraph.Assets;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
	// Dinh nghia Enum
	public enum TypeObject
	{
		CUBE,
		SQUARE_PYRAMID,
		TRIANGULAR_PRISM
	}

	public struct Point3D {
		public float x, y, z;
		public Point3D(float _x = 0, float _y = 0, float _z = 0) {
			x = _x;
			y = _y;
			z = _z;
		}
		public Point3D(Point3D src) {
			x = src.x;
			y = src.y;
			z = src.z;
		}
	}

	// Do doi
	public struct STranslationCoor {
		public float trX, trY, trZ;
		public STranslationCoor(float _trX = 0, float _trY = 0, float _trZ = 0) {
			trX = _trX;
			trY = _trY;
			trZ = _trZ;
		}
	}

	// Rotate
	public struct SRotationCoor {
		public float angleX; // Degree of rotation around X-asis
		public float angleY; // Degree of rotation around Y-asis
		public float angleZ; // Degree of rotation around Z-asis
		public SRotationCoor(float _angleX = 0, float _angleY = 0, float _angleZ = 0)
		{
			angleX = _angleX;
			angleY = _angleY;
			angleZ = _angleZ;
		}
	}

	// Scale
	public struct SScaleCoor
	{
		public float sX; // Scale of X-asis
		public float sY; // Scale of Y-asis
		public float sZ; // Scale of Z-asis
		public SScaleCoor(float _sX = 0, float _sY = 0, float _sZ = 0)
		{
			sX = _sX;
			sY = _sY;
			sZ = _sZ;
		}
	}

	// Bass class: Object
	public abstract class CObject
	{
        protected bool isTexture; // Bien kiem tra ve texture
        protected String path; // path den file ve texture
        protected String name;
		protected Color colorUse; // Mau su dung
		protected STranslationCoor trCoor; // Do doi translate
		protected SRotationCoor rotaCoor; // Ho tro quay
		protected SScaleCoor scaleCoor; // Ho tro scale

		public abstract String Name
		{
			get; set;
		}

		public Color ColorUse {
			get { return colorUse; }
			set { colorUse = value; }
		}

		// Ham cap nhat do doi cho obj
		public void updateTranCoor(float _trX, float _trY, float _trZ) {
			trCoor.trX += (_trX - trCoor.trX);
			trCoor.trY += (_trY - trCoor.trY);
			trCoor.trY += (_trZ - trCoor.trZ);
		}

		// Hap cap nhat cho phep quay
		public void updateRotaCoor(float _angleX, float _angleY, float _angleZ) {
			rotaCoor.angleX += (_angleX - rotaCoor.angleX);
			rotaCoor.angleY += (_angleY - rotaCoor.angleY);
			rotaCoor.angleZ += (_angleZ - rotaCoor.angleZ);
		}

		public void updateScaleCoor(float _sX, float _sY, float _sZ) {
			scaleCoor.sX += (_sX - scaleCoor.sX);
			scaleCoor.sY += (_sY - scaleCoor.sY);
			scaleCoor.sZ += (_sZ - scaleCoor.sZ);
		}

		// Ham kiem tra co translate khong?
		public bool isTranslate() {
			if (trCoor.trX != 0 || trCoor.trY != 0 || trCoor.trZ != 0)
				return true;
			return false;
		}

		// Ham kiem tra xem co rotate không?
		public bool isRotate() {
			if (rotaCoor.angleX != 0 || rotaCoor.angleY != 0 || rotaCoor.angleZ != 0)
				return true;
			return false;
		}

		// Ham kiem tra xem co scale khong?
		public bool isScale() {
			if (scaleCoor.sX != 0 || scaleCoor.sY != 0 || scaleCoor.sZ != 0)
				return true;
			return false;
		}

		// Ham ve bien
		public abstract void drawBorder(OpenGL gl, bool isSelected);

		// Ham ve hinh
		public abstract void draw(OpenGL gl, bool isSelected = false);

		public CObject(bool texture = false, string texturePath = "")
		{
            isTexture = texture; // Mac dinh k ve texture
            path = texturePath; // Khong co duong link den file ve texture
            colorUse = Color.White; // Mac dinh la mau trang
			trCoor = new STranslationCoor();
		}

	}

	// Class: Hinh lap phuong
	public class CCube : CObject
	{
		public override String Name
		{
			get { return "Cube"; }
			set { name = value; }
		}

		public override void drawBorder(OpenGL gl, bool isSelected)
		{
			float a = 1.0f;
			if (isSelected)
			{ // Neu selected
			  // Duong vien mau cam dam
				gl.Color(255 / 255.0f, 128 / 255.0, 0);
			}
			else
				gl.Color(224 / 255.0f, 224 / 255.0f, 224 / 255.0f);
			gl.LineWidth(3);
			// Ve bien
			gl.Begin(OpenGL.GL_LINE_LOOP);
			gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Top)
			gl.Vertex(a, 0.0f, 0.0f);    // Top Left Of The Quad (Top)
			gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Top)
			gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Top)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_LOOP);
			gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Bottom)
			gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Bottom)
			gl.Vertex(a, a, 0.0f);    // Bottom Left Of The Quad (Bottom)
			gl.Vertex(a, 0.0f, 0.0f);    // Bottom Right Of The Quad (Bottom)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_LOOP);
			gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Front)
			gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Front)
			gl.Vertex(0.0f, a, a);    // Bottom Left Of The Quad (Front)
			gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Front)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_LOOP);
			gl.Vertex(0.0f, a, a);    // Top Right Of The Quad (Back)
			gl.Vertex(a, a, a);    // Top Left Of The Quad (Back)
			gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Back)
			gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Back)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_LOOP);
			gl.Vertex(a, a, a);    // Top Right Of The Quad (Left)
			gl.Vertex(a, a, 0.0f);    // Top Left Of The Quad (Left)
			gl.Vertex(a, 0.0f, 0.0f);    // Bottom Left Of The Quad (Left)
			gl.Vertex(a, 0.0f, a);    // Bottom Right Of The Quad (Left)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_LOOP);
			gl.Vertex(0.0f, a, 0.0f);    // Top Right Of The Quad (Right)
			gl.Vertex(a, a, 0.0f);    // Top Left Of The Quad (Right)
			gl.Vertex(a, a, a);    // Bottom Left Of The Quad (Right)
			gl.Vertex(0.0f, a, a);    // Bottom 
			gl.End();
			gl.Flush();

			gl.LineWidth(1);
		}

		public override void draw(OpenGL gl, bool isSelected = false)
		{
			if(isTexture == false)
            {
                // Thuc hien kiem tra xem co translate, rotate hay scale khong?
                if (isTranslate())
                {
                    gl.PushMatrix();
                    gl.Translate(trCoor.trX, trCoor.trY, trCoor.trZ);
                }


                // Ve hinh lap phuong voi canh a bat ky
                float a = 1.0f;
                gl.Color(colorUse.R / 255.0, colorUse.G / 255.0, colorUse.B / 255.0);
                gl.Begin(OpenGL.GL_QUADS);
                gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Top)
                gl.Vertex(a, 0.0f, 0.0f);    // Top Left Of The Quad (Top)
                gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Top)
                gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Top)

                gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Bottom)
                gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Bottom)
                gl.Vertex(a, a, 0.0f);    // Bottom Left Of The Quad (Bottom)
                gl.Vertex(a, 0.0f, 0.0f);    // Bottom Right Of The Quad (Bottom)

                gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Front)
                gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Front)
                gl.Vertex(0.0f, a, a);    // Bottom Left Of The Quad (Front)
                gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Front)

                gl.Vertex(0.0f, a, a);    // Top Right Of The Quad (Back)
                gl.Vertex(a, a, a);    // Top Left Of The Quad (Back)
                gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Back)
                gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Back)

                gl.Vertex(a, a, a);    // Top Right Of The Quad (Left)
                gl.Vertex(a, a, 0.0f);    // Top Left Of The Quad (Left)
                gl.Vertex(a, 0.0f, 0.0f);    // Bottom Left Of The Quad (Left)
                gl.Vertex(a, 0.0f, a);    // Bottom Right Of The Quad (Left)

                gl.Vertex(0.0f, a, 0.0f);    // Top Right Of The Quad (Right)
                gl.Vertex(a, a, 0.0f);    // Top Left Of The Quad (Right)
                gl.Vertex(a, a, a);    // Bottom Left Of The Quad (Right)
                gl.Vertex(0.0f, a, a);    // Bottom 

                gl.End();
                gl.Flush();
                // Ve bien
                drawBorder(gl, isSelected);

                if (isTranslate())
                {
                    gl.PopMatrix();
                }
            }
            else
            {
                // Thuc hien kiem tra xem co translate, rotate hay scale khong?
                if (isTranslate())
                {
                    gl.PushMatrix();
                    gl.Translate(trCoor.trX, trCoor.trY, trCoor.trZ);
                }

                // Enable texture
                gl.Enable(OpenGL.GL_TEXTURE_2D);
                // Create texture
                Texture MyTexture = new Texture();
                MyTexture.Create(gl, path);
                MyTexture.Bind(gl);
                // Ve hinh lap phuong voi canh a bat ky
                float a = 1.0f;
                gl.Color(colorUse.R / 255.0, colorUse.G / 255.0, colorUse.B / 255.0);
                gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Top)
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(a, 0.0f, 0.0f);    // Top Left Of The Quad (Top)
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Top)
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Top)

                gl.TexCoord(0.0f, 0.0f); gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Bottom)
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Bottom)
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(a, a, 0.0f);    // Bottom Left Of The Quad (Bottom)
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(a, 0.0f, 0.0f);    // Bottom Right Of The Quad (Bottom)

                gl.TexCoord(0.0f, 0.0f); gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Front)
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Front)
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(0.0f, a, a);    // Bottom Left Of The Quad (Front)
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Front)

                gl.TexCoord(0.0f, 0.0f); gl.Vertex(0.0f, a, a);    // Top Right Of The Quad (Back)
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(a, a, a);    // Top Left Of The Quad (Back)
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Back)
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Back)

                gl.TexCoord(0.0f, 0.0f); gl.Vertex(a, a, a);    // Top Right Of The Quad (Left)
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(a, a, 0.0f);    // Top Left Of The Quad (Left)
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(a, 0.0f, 0.0f);    // Bottom Left Of The Quad (Left)
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(a, 0.0f, a);    // Bottom Right Of The Quad (Left)

                gl.TexCoord(0.0f, 0.0f); gl.Vertex(0.0f, a, 0.0f);    // Top Right Of The Quad (Right)
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(a, a, 0.0f);    // Top Left Of The Quad (Right)
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(a, a, a);    // Bottom Left Of The Quad (Right)
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(0.0f, a, a);    // Bottom 

                gl.End();
                gl.Flush();
                // Ve bien
                drawBorder(gl, isSelected);

                if (isTranslate())
                {
                    gl.PopMatrix();
                }
            }
		}

		public CCube(bool texture = false, string texturePath = "") : base()
		{
            isTexture = texture;
            path = texturePath;
            name = "Cube";
		}
	}

	// Class: Hinh cho co day la hinh vuong
	public class CSquarePyramid : CObject
	{
		public override String Name
		{
			get { return "Square pyramid"; }
			set { name = value; }
		}

		public override void drawBorder(OpenGL gl, bool isSelected)
		{
			float a = 1.0f;
			float h = 1.0f;

			if (isSelected)
			{ // Neu selected
			  // Duong vien mau cam dam
				gl.Color(255 / 255.0f, 128 / 255.0, 0);
			}
			else
				gl.Color(224 / 255.0f, 224/255.0f, 224/255.0f);

			gl.LineWidth(3);
			// Ve bien
			gl.Begin(OpenGL.GL_LINE_LOOP);
			// Ve day ABCD
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, a);
			gl.Vertex(0.0f, 0.0f, a);
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINES);
			// Ve SA
			gl.Vertex(a / 2, h, a / 2);
			gl.Vertex(0.0f, 0.0f, 0.0f);
			// Ve SB
			gl.Vertex(a / 2, h, a / 2);
			gl.Vertex(0.0f, 0.0f, a);
			// Ve SC
			gl.Vertex(a / 2, h, a / 2);
			gl.Vertex(a, 0.0f, a);
			// Ve SD
			gl.Vertex(a / 2, h, a / 2);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.End();
			gl.Flush();

			gl.PointSize(1.0f);

		}


		public override void draw(OpenGL gl, bool isSelected = false)
		{
			if(isTexture == false)
            {
                // Thuc hien kiem tra xem co translate, rotate hay scale khong?
                if (isTranslate())
                {
                    gl.PushMatrix();
                    gl.Translate(trCoor.trX, trCoor.trY, trCoor.trZ);
                }

                float a = 1.0f;
                // Ve hinh chop deu day hinh vuong voi dinh S tuy y va canh day la a
                float h = 1.0f;
                gl.Color(colorUse.R / 255.0, colorUse.G / 255.0, colorUse.B / 255.0);

                // Ve day
                gl.Begin(OpenGL.GL_QUADS);
                // Ve day ABCD
                gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.Vertex(a, 0.0f, 0.0f);
                gl.Vertex(a, 0.0f, a);
                gl.Vertex(0.0f, 0.0f, a);
                gl.End();
                gl.Flush();

                // Ve 4 mat ben
                gl.Begin(OpenGL.GL_TRIANGLES);
                // Ve mat ben trai SAB
                gl.Vertex(a / 2, h, a / 2);
                gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.Vertex(0.0f, 0.0f, a);

                // Ve mat giua SBC
                gl.Vertex(a / 2, h, a / 2);
                gl.Vertex(0.0f, 0.0f, a);
                gl.Vertex(a, 0.0f, a);

                // Ve mat ben phai SCD
                gl.Vertex(a / 2, h, a / 2);
                gl.Vertex(a, 0.0f, a);
                gl.Vertex(a, 0.0f, 0.0f);

                // Ve mat sau SAD
                gl.Vertex(a / 2, h, a / 2);
                gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.Vertex(a, 0.0f, 0.0f);

                gl.End();
                gl.Flush();

                drawBorder(gl, isSelected);

                if (isTranslate())
                    gl.PopMatrix();
            }
            else
            {
                // Thuc hien kiem tra xem co translate, rotate hay scale khong?
                if (isTranslate())
                {
                    gl.PushMatrix();
                    gl.Translate(trCoor.trX, trCoor.trY, trCoor.trZ);
                }
                // Enable texture
                gl.Enable(OpenGL.GL_TEXTURE_2D);
                // Create texture
                Texture MyTexture = new Texture();
                MyTexture.Create(gl, path);
                MyTexture.Bind(gl);
                float a = 1.0f;
                // Ve hinh chop deu day hinh vuong voi dinh S tuy y va canh day la a
                float h = 1.0f;
                gl.Color(colorUse.R / 255.0, colorUse.G / 255.0, colorUse.B / 255.0);

                // Ve day
                gl.Begin(OpenGL.GL_QUADS);
                // Ve day ABCD
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(a, 0.0f, 0.0f);
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(a, 0.0f, a);
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(0.0f, 0.0f, a);
                gl.End();
                gl.Flush();

                // Ve 4 mat ben
                gl.Begin(OpenGL.GL_TRIANGLES);
                // Ve mat ben trai SAB
                gl.TexCoord(0.0f, 0.0f); gl.TexCoord(1.0f, 0.0f); gl.Vertex(a / 2, h, a / 2);
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(0.0f, 0.0f, a);

                // Ve mat giua SBC
                gl.TexCoord(0.0f, 0.0f); gl.TexCoord(1.0f, 0.0f); gl.Vertex(a / 2, h, a / 2);
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(0.0f, 0.0f, a);
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(a, 0.0f, a);

                // Ve mat ben phai SCD
                gl.TexCoord(0.0f, 0.0f); gl.TexCoord(1.0f, 0.0f); gl.Vertex(a / 2, h, a / 2);
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(a, 0.0f, a);
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(a, 0.0f, 0.0f);

                // Ve mat sau SAD
                gl.TexCoord(0.0f, 0.0f); gl.TexCoord(1.0f, 0.0f); gl.Vertex(a / 2, h, a / 2);
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(a, 0.0f, 0.0f);

                gl.End();
                gl.Flush();

                drawBorder(gl, isSelected);

                if (isTranslate())
                    gl.PopMatrix();
            }
		}
		public CSquarePyramid(bool texture = false, string texturePath = "") : base()
		{
            isTexture = texture;
            path = texturePath;
            name = "Square pyramid";
		}
	}

	// Class: Lang tru co day la tam giac deu
	public class CTriangularPrism : CObject
	{
		public override String Name
		{
			get { return "Triangular prism"; }
			set { name = value; }
		}

		public override void drawBorder(OpenGL gl, bool isSelected)
		{
			float a = 1.0f;
			float h = 1.0f;

			if (isSelected)
			{ // Neu selected
			  // Duong vien mau cam dam
				gl.Color(255 / 255.0f, 128 / 255.0, 0);
			}
			else
				gl.Color(224 / 255.0f, 224 / 255.0f, 224 / 255.0f);
			gl.LineWidth(3);

			// Ve bien
			gl.Begin(OpenGL.GL_LINE_LOOP);
			// Ve day ABC
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.Vertex(a / 2, 0.0f, a);
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_LOOP);
			// Ve mat ben thu nhat AA'C'C
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(0.0f, h, 0.0f);
			gl.Vertex(a / 2, h, a);
			gl.Vertex(a / 2, 0.0f, a);
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_LOOP);
			// Ve mat ben thu hai CC'B'B
			gl.Vertex(a / 2, 0.0f, a);
			gl.Vertex(a / 2, h, a);
			gl.Vertex(a, h, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.End();
			gl.Flush();


			gl.Begin(OpenGL.GL_LINE_LOOP);
			// Ve mat sau AA'B'B
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(0.0f, h, 0.0f);
			gl.Vertex(a, h, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.End();
			gl.Flush();


			gl.Begin(OpenGL.GL_LINE_LOOP);
			// Ve day tren A'B'C'
			gl.Vertex(0.0f, h, 0.0f);
			gl.Vertex(a, h, 0.0f);
			gl.Vertex(a / 2, h, a);
			gl.End();
			gl.Flush();
			gl.LineWidth(1);
		}


		// Class CTriangularPrism : CObject
		public override void draw(OpenGL gl, bool isSelected = false)
		{
			if (isTexture == false)
			{
				// Thuc hien kiem tra xem co translate, rotate hay scale khong?
				if (isTranslate())
				{
					gl.PushMatrix();
					gl.Translate(trCoor.trX, trCoor.trY, trCoor.trZ);
				}
				if (isRotate())
				{
					gl.PushMatrix();
					// Tinh tien ve tam O
					gl.Translate(-trCoor.trX, -trCoor.trY, -trCoor.trZ);
					gl.Rotate(rotaCoor.angleX, rotaCoor.angleY, rotaCoor.angleZ); // Thuc hien xoay tai tam 0
					gl.Translate(trCoor.trX, trCoor.trY, trCoor.trZ); // Tinh tien nguoc tro lai
				}
				if (isScale())
				{
					gl.PushMatrix();
					gl.Scale(scaleCoor.sX, scaleCoor.sY, scaleCoor.sZ); // Thuc hien scale
				}

				// Ve hinh tru co day la tam giac deu voi canh a tuy y
				float a = 1.0f;
				float h = 1.0f;

				gl.Color(colorUse.R / 255.0, colorUse.G / 255.0, colorUse.B / 255.0);
				gl.Begin(OpenGL.GL_TRIANGLES);
				// Ve day ABC
				gl.Vertex(0.0f, 0.0f, 0.0f);
				gl.Vertex(a, 0.0f, 0.0f);
				gl.Vertex(a / 2, 0.0f, a);
				gl.End();
				gl.Flush();

				// Ve cac mat ben
				gl.Begin(OpenGL.GL_QUADS);
				// Ve mat ben thu nhat AA'C'C
				gl.Vertex(0.0f, 0.0f, 0.0f);
				gl.Vertex(0.0f, h, 0.0f);
				gl.Vertex(a / 2, h, a);
				gl.Vertex(a / 2, 0.0f, a);

				// Ve mat ben thu hai CC'B'B
				gl.Vertex(a / 2, 0.0f, a);
				gl.Vertex(a / 2, h, a);
				gl.Vertex(a, h, 0.0f);
				gl.Vertex(a, 0.0f, 0.0f);

				// Ve mat sau AA'B'B
				gl.Vertex(0.0f, 0.0f, 0.0f);
				gl.Vertex(0.0f, h, 0.0f);
				gl.Vertex(a, h, 0.0f);
				gl.Vertex(a, 0.0f, 0.0f);
				gl.End();
				gl.Flush();

				// Ve day tren A'B'C'
				gl.Begin(OpenGL.GL_TRIANGLES);
				gl.Vertex(0.0f, h, 0.0f);
				gl.Vertex(a, h, 0.0f);
				gl.Vertex(a / 2, h, a);
				gl.End();
				gl.Flush();

				// Ve bien
				drawBorder(gl, isSelected);

				if (isTranslate())
					gl.PopMatrix();
				if (isRotate())
					gl.PopMatrix();
				if (isScale())
					gl.PopMatrix();
			}
			else
			{
				// Thuc hien kiem tra xem co translate, rotate hay scale khong?
				if (isTranslate())
				{
					gl.PushMatrix();
					gl.Translate(trCoor.trX, trCoor.trY, trCoor.trZ);
				}
				if (isRotate())
				{
					gl.PushMatrix();
					// Tinh tien ve tam O
					gl.Translate(-trCoor.trX, -trCoor.trY, -trCoor.trZ);
					gl.Rotate(rotaCoor.angleX, rotaCoor.angleY, rotaCoor.angleZ); // Thuc hien xoay tai tam 0
					gl.Translate(trCoor.trX, trCoor.trY, trCoor.trZ); // Tinh tien nguoc tro lai
				}
				if (isScale())
				{
					gl.PushMatrix();
					gl.Scale(scaleCoor.sX, scaleCoor.sY, scaleCoor.sZ); // Thuc hien scale
				}
				// Enable texture
				gl.Enable(OpenGL.GL_TEXTURE_2D);
				// Create texture
				Texture MyTexture = new Texture();
				MyTexture.Create(gl, path);
				MyTexture.Bind(gl);
				// Ve hinh tru co day la tam giac deu voi canh a tuy y
				float a = 1.0f;
				float h = 1.0f;

				gl.Color(colorUse.R / 255.0, colorUse.G / 255.0, colorUse.B / 255.0);
				gl.Begin(OpenGL.GL_TRIANGLES);
				// Ve day ABC
				gl.TexCoord(0f, 0f); gl.TexCoord(1f, 0f); gl.Vertex(0.0f, 0.0f, 0.0f);
				gl.TexCoord(1f, 1f); gl.Vertex(a, 0.0f, 0.0f);
				gl.TexCoord(0f, 1f); gl.Vertex(a / 2, 0.0f, a);
				gl.End();
				gl.Flush();

				// Ve cac mat ben
				gl.Begin(OpenGL.GL_QUADS);
				// Ve mat ben thu nhat AA'C'C
				gl.TexCoord(0f, 0f); gl.Vertex(0.0f, 0.0f, 0.0f);
				gl.TexCoord(1f, 0f); gl.Vertex(0.0f, h, 0.0f);
				gl.TexCoord(1f, 1f); gl.Vertex(a / 2, h, a);
				gl.TexCoord(0f, 1f); gl.Vertex(a / 2, 0.0f, a);

				// Ve mat ben thu hai CC'B'B
				gl.TexCoord(0f, 0f); gl.Vertex(a / 2, 0.0f, a);
				gl.TexCoord(1f, 0f); gl.Vertex(a / 2, h, a);
				gl.TexCoord(1f, 1f); gl.Vertex(a, h, 0.0f);
				gl.TexCoord(0f, 1f); gl.Vertex(a, 0.0f, 0.0f);

				// Ve mat sau AA'B'B
				gl.TexCoord(0f, 0f); gl.Vertex(0.0f, 0.0f, 0.0f);
				gl.TexCoord(1f, 0f); gl.Vertex(0.0f, h, 0.0f);
				gl.TexCoord(1f, 1f); gl.Vertex(a, h, 0.0f);
				gl.TexCoord(0f, 1f); gl.Vertex(a, 0.0f, 0.0f);
				gl.End();
				gl.Flush();

				// Ve day tren A'B'C'
				gl.Begin(OpenGL.GL_TRIANGLES);
				gl.TexCoord(0f, 0f); gl.TexCoord(1f, 0f); gl.Vertex(0.0f, h, 0.0f);
				gl.TexCoord(1f, 1f); gl.Vertex(a, h, 0.0f);
				gl.TexCoord(0f, 1f); gl.Vertex(a / 2, h, a);
				gl.End();
				gl.Flush();
				gl.Disable(OpenGL.GL_TEXTURE_2D);
				// Ve bien
				drawBorder(gl, isSelected);

				if (isTranslate())
					gl.PopMatrix();
				if (isRotate())
					gl.PopMatrix();
				if (isScale())
					gl.PopMatrix();
			}
		}

		public CTriangularPrism(bool texture = false, string texturePath = "") : base()
		{
			isTexture = texture;
			path = texturePath;
			name = "Triangular prism";
		}

		public CTriangularPrism() : base()
		{
			name = "Triangular prism";
		}
	}

	public class CListObject
	{
		private List<CObject> lst = new List<CObject>();


		// Them mot CObject vao list
		public void add(CObject src)
		{
			lst.Add(src);
		}

		// Ve cho cac doi tuong trong list
		public void draw(OpenGL gl)
		{
			foreach (var obj in lst)
			{
				obj.draw(gl);
			}
		}

		public void draw(OpenGL gl, int idxSelected) {

			for(int i = 0; i < lst.Count(); i++)
			{
				if (i != idxSelected)
					lst[i].draw(gl);
				else // Neu nguoi dung dang select thi se ve vien dam
					lst[i].draw(gl, true);
			}
		}

		public int getLength() {
			return lst.Count();
		}

		// Ham cap nhat mau cho lst[idx]
		public void setColorOfOneObj(int idx, Color color) {
			lst[idx].ColorUse = color;
		}


		// Ham cap nhat do doi cho lst[idx]
		public void updateTranCoor(int idx, float trX, float trY, float trZ)
		{
			lst[idx].updateTranCoor(trX, trY, trZ);
		}

		// Ham cap nhat cac goc quay cho lstObj[idx]
		public void updateRotaCoor(int idx, float angleX, float angleY, float angleZ)
		{
			lst[idx].updateRotaCoor(angleX, angleY, angleZ);
		}

		// Ham cap nhat cac do scale cho lstObj[idx]
		public void updateScaleCoor(int idx, float sX, float sY, float sZ)
		{
			lst[idx].updateScaleCoor(sX, sY, sZ);
		}
	}

	public class CDrawObject
	{
		private CListObject lstObj = new CListObject();

		public void draw(OpenGL gl)
		{
			lstObj.draw(gl);
		}

		// Ham draw co truyen vao index cua obj duoc chon hien tai
		public void draw(OpenGL gl, int idxSelected) {
			lstObj.draw(gl, idxSelected);
		}

		// Ham them 1 obj vao list
		public void addObj(TypeObject type, Color color, bool texture = false, string texturePath = "")
		{
			CObject obj = null;
			switch (type)
			{
				case TypeObject.CUBE:
					obj = new CCube(texture, texturePath);
					break;
				case TypeObject.SQUARE_PYRAMID:
					obj = new CSquarePyramid(texture, texturePath);
					break;
				case TypeObject.TRIANGULAR_PRISM:
					obj = new CTriangularPrism();
					break;
			}

			obj.ColorUse = color;
			// Them obj nay vao lstObj
			lstObj.add(obj);
		}

		// Ham lay do dai cua lstObj
		public int getLength() {
			return lstObj.getLength();
		}

		// Ham cap nhat mau cho lst[idx]
		public void setColorOfOneObj(int idx, Color color) {
			lstObj.setColorOfOneObj(idx, color);
		}

		// Ham cap nhat do doi cho lstObj[idx]
		public void updateTranCoor(int idx, float trX, float trY, float trZ) {
			lstObj.updateTranCoor(idx, trX, trY, trZ);
		}

		// Ham cap nhat cac goc quay cho lstObj[idx]
		public void updateRotaCoor(int idx, float angleX, float angleY, float angleZ)
		{
			lstObj.updateRotaCoor(idx, angleX, angleY, angleZ);
		}

		// Ham cap nhat cac do scale cho lstObj[idx]
		public void updateScaleCoor(int idx, float sX, float sY, float sZ)
		{
			lstObj.updateScaleCoor(idx, sX, sY, sZ);
		}

	}

	class MatrixManipulation
	{
		private double[,] matrixMult(double[,] mat1, double[,] mat2, int m, int n, int p) // Nhan 2 ma tran
		{
			double[,] retMat = new double[m, p];
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < p; j++)
				{
					retMat[i, j] = mat1[i, 0] * mat2[0, j] + mat1[i, 1] * mat2[1, j] + mat1[i, 2] * mat2[2, j] + mat1[i, 3] * mat2[3, j];
				}
			}
			return retMat;
		}
		public double[] verticeRotate(double[] sPoint, double[] ePoint, double angle, double x, double y, double z) // xoay diem (x, y, z) quanh vecto co diem dau la sPoint, diem cuoi la ePoint
		{ // return a list of new x, y, z
		  // return vertice
			double[] ret = new double[3];
			// create vector from given start point and end point
			double x1 = sPoint[0], y1 = sPoint[1], z1 = sPoint[2];
			double[] vec = new double[3] { ePoint[0] - sPoint[0], ePoint[1] - sPoint[1], ePoint[2] - sPoint[2] };
			double vec_magnitude = Math.Sqrt(Math.Pow(vec[0], 2) + Math.Pow(vec[1], 2) + Math.Pow(vec[2], 2));
			double kx = vec[0] / vec_magnitude, ky = vec[1] / vec_magnitude, kz = vec[2] / vec_magnitude;
			double d = Math.Sqrt(Math.Pow(ky, 2) + Math.Pow(kz, 2));
			double radian = (Math.PI / 180) * angle;

			double[,] rev_tr = new double[4, 4]
			{
				{1, 0, 0, x1},
				{0, 1, 0, y1},
				{0, 0, 1, z1},
				{0, 0, 0, 1}
			};
			double[,] rev_rot_a = new double[4, 4]
			{
				{1, 0, 0, 0},
				{0, kz/d, (-1)*ky/d, 0},
				{0, ky/d, kz/d, 0},
				{0, 0, 0, 1}
			};
			double[,] rev_rot_b = new double[4, 4]
			{
				{d, 0, kx, 0},
				{0, 1, 0, 0},
				{(-1)*kx, 0, d, 0},
				{0, 0, 0, 1}
			};
			double[,] rot = new double[4, 4]
			{
				{Math.Cos(radian), Math.Sin(radian), 0, 0 },
				{(-1)*Math.Sin(radian), Math.Cos(radian), 0, 0 },
				{0, 0, 1, 0 },
				{0, 0, 0, 1}
			};
			double[,] rot_b = new double[4, 4]
			{
				{d, 0, (-1)*kx, 0 },
				{0, 1, 0, 0 },
				{kx, 0, d, 0 },
				{0, 0, 0, 1 }
			};
			double[,] rot_a = new double[4, 4]
			{
				{1, 0, 0, 0 },
				{0, kz/d, ky/d, 0 },
				{0, (-1)*ky/d, kz/d, 0 },
				{0, 0, 0, 1 }
			};
			double[,] tr = new double[4, 4]
			{
				{1, 0, 0, (-1)*x1 },
				{0, 1, 0, (-1)*y1 },
				{0, 0, 1, (-1)*z1 },
				{0, 0, 0, 1 }
			};
			double[,] tmp = new double[4, 4];
			tmp = matrixMult(rev_tr, rev_rot_a, 4, 4, 4);
			tmp = matrixMult(tmp, rev_rot_b, 4, 4, 4);
			tmp = matrixMult(tmp, rot, 4, 4, 4);
			tmp = matrixMult(tmp, rot_b, 4, 4, 4);
			tmp = matrixMult(tmp, rot_a, 4, 4, 4);
			tmp = matrixMult(tmp, tr, 4, 4, 4);

			double[,] verticeVec = new double[4, 1] { { x }, { y }, { z }, { 1 } };
			tmp = matrixMult(tmp, verticeVec, 4, 4, 1);
			ret[0] = tmp[0, 0];
			ret[1] = tmp[1, 0];
			ret[2] = tmp[2, 0];
			return ret;
		}
	}
    //==============================================================CAMERA===============================================================================
    public class CameraRotation
    {
        // camera position
        private double x = -4;
        private double y = 0;
        private double z = -4;
        // view point
        private double v_x = 1;
        private double v_y = 0;
        private double v_z = 1;
        // vector up
        private double u_x = 0;
        private double u_y = 1;
        private double u_z = 0;
        // ePoint of perpendicular vector
        private double p_x = 0;
        private double p_y = 0;
        private double p_z = 2;
        // khoang cach tu hinh chieu cua camera position den viewpoint
        private double dist = Math.Sqrt(Math.Pow(-4 - 1, 2) + Math.Pow(-4 - 1, 2));

        // flag for checking when we need to change y of vector up 
        private int flag1 = 0;
        private int flag2 = 0;

        // angle
        private int angle = 0;

        // Khai bao de su dung ham rotate
        private MatrixManipulation matManip = new MatrixManipulation();

        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public double getZ()
        {
            return z;
        }
        public double getV_X()
        {
            return v_x;
        }
        public double getV_Y()
        {
            return v_y;
        }
        public double getV_Z()
        {
            return v_z;
        }
        public double getU_X()
        {
            return u_x;
        }
        public double getU_Y()
        {
            return u_y;
        }
        public double getU_Z()
        {
            return u_z;
        }
        public double getDist()
        {
            return dist;
        }
        public double getAngle()
        {
            return angle;
        }
        public void nearer() // translate: vector(OA) = (k/(k-0.1)) * vector(OA')
        {
            x = ((dist - 0.2) / dist) * (x - v_x) + v_x;
            y = ((dist - 0.2) / dist) * (y - v_y) + v_y;
            z = ((dist - 0.2) / dist) * (z - v_z) + v_z;
            dist--;
        }
        public void further() // translate: vector(OA) = (k/(k+0.1)) * vector(OA')
        {
            x = ((dist + 0.2) / dist) * (x - v_x) + v_x;
            y = ((dist + 0.2) / dist) * (y - v_y) + v_y;
            z = ((dist + 0.2) / dist) * (z - v_z) + v_z;
            dist++;
        }
        public void leftRotate()
        {
            //int[] newPos = new int[3];
            double[] sPoint = new double[3] { v_x, v_y, v_z };
            double[] ePoint = new double[3] { v_x, 1, v_z };
            double[] p_ePoint = new double[3] { p_x, p_y, p_z };

            double[] newVertice = new double[3];
            double[] p_newVertice = new double[3];

            newVertice = matManip.verticeRotate(sPoint, ePoint, 1, x, y, z);
            p_newVertice = matManip.verticeRotate(sPoint, ePoint, 1, p_x, p_y, p_z);

            x = newVertice[0];
            y = newVertice[1];
            z = newVertice[2];

            p_x = p_newVertice[0];
            p_y = p_newVertice[1];
            p_z = p_newVertice[2];
        }
        public void rightRotate()
        {
            double[] sPoint = new double[3] { v_x, v_y, v_z };
            double[] ePoint = new double[3] { v_x, 1, v_z };
            double[] p_ePoint = new double[3] { p_x, p_y, p_z };

            double[] newVertice = new double[3];
            double[] p_newVertice = new double[3];

            newVertice = matManip.verticeRotate(sPoint, ePoint, -1, x, y, z);
            p_newVertice = matManip.verticeRotate(sPoint, ePoint, -1, p_x, p_y, p_z);

            x = newVertice[0];
            y = newVertice[1];
            z = newVertice[2];

            p_x = p_newVertice[0];
            p_y = p_newVertice[1];
            p_z = p_newVertice[2];
        }
        public void downRotate()
        {
            double[] sPoint = new double[3] { v_x, v_y, v_z };
            double[] ePoint = new double[3] { p_x, p_y, p_z };
            double[] newVertice = new double[3];
            newVertice = matManip.verticeRotate(sPoint, ePoint, -1, x, y, z);//-0.5
            if (angle == 0)
                angle = 360;
            angle -= 1;
            if (angle == 269 || angle == 89)
                u_y *= -1;
            x = newVertice[0];
            y = newVertice[1];
            z = newVertice[2];

        }
        public void upRotate()
        {
            double[] sPoint = new double[3] { v_x, v_y, v_z };
            double[] ePoint = new double[3] { p_x, p_y, p_z };
            double[] newVertice = new double[3];
            newVertice = matManip.verticeRotate(sPoint, ePoint, 1, x, y, z);//0.5
            if (angle == 360)
                angle = 0;
            angle += 1;
            if (angle == 90 || angle == 271)
                u_y *= -1;
            x = newVertice[0];
            y = newVertice[1];
            z = newVertice[2];
        }
    }


}
