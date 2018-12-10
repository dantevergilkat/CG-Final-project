using SharpGL;
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

	// Bass class: Object
	public abstract class CObject
	{
		protected String name;
		protected Color colorUse; // Mau su dung
		public abstract String Name
		{
			get; set;
		}

		public Color ColorUse {
			get { return colorUse; }
			set { colorUse = value; }
		}

		public abstract void drawBorder(OpenGL gl, bool isSelected);

		public abstract void draw(OpenGL gl, bool isSelected = false);

		public CObject()
		{
			colorUse = Color.White; // Mac dinh la mau trang
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
			float a = 2.0f;
			if (isSelected)
			{ // Neu selected
			  // Duong vien mau cam dam
				gl.Color(255 / 255.0f, 128 / 255.0, 0);
			}
			else
				gl.Color(224 / 255.0f, 224 / 255.0f, 224 / 255.0f);
			gl.LineWidth(3);

			// Ve bien
			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Top)
			gl.Vertex(a, 0.0f, 0.0f);    // Top Left Of The Quad (Top)
			gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Top)
			gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Top)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Bottom)
			gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Bottom)
			gl.Vertex(a, a, 0.0f);    // Bottom Left Of The Quad (Bottom)
			gl.Vertex(a, 0.0f, 0.0f);    // Bottom Right Of The Quad (Bottom)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Front)
			gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Front)
			gl.Vertex(0.0f, a, a);    // Bottom Left Of The Quad (Front)
			gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Front)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(0.0f, a, a);    // Top Right Of The Quad (Back)
			gl.Vertex(a, a, a);    // Top Left Of The Quad (Back)
			gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Back)
			gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Back)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(a, a, a);    // Top Right Of The Quad (Left)
			gl.Vertex(a, a, 0.0f);    // Top Left Of The Quad (Left)
			gl.Vertex(a, 0.0f, 0.0f);    // Bottom Left Of The Quad (Left)
			gl.Vertex(a, 0.0f, a);    // Bottom Right Of The Quad (Left)
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_STRIP);
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
			// Ve hinh lap phuong voi canh a bat ky
			float a = 2.0f;
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

			drawBorder(gl, isSelected);
		}

		public CCube() : base()
		{
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
			float a = 2.0f;
			float h = 5.0f;

			if (isSelected)
			{ // Neu selected
			  // Duong vien mau cam dam
				gl.Color(255 / 255.0f, 128 / 255.0, 0);
			}
			else
				gl.Color(224 / 255.0f, 224/255.0f, 224/255.0f);
			gl.LineWidth(3);
			// Ve bien
			gl.Begin(OpenGL.GL_LINE_STRIP);
			// Ve day ABCD
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, a);
			gl.Vertex(0.0f, 0.0f, a);
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(a / 2, h, a / 2);
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(0.0f, 0.0f, a);
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(a / 2, h, a / 2);
			gl.Vertex(0.0f, 0.0f, a);
			gl.Vertex(a, 0.0f, a);
			gl.End();
			gl.Flush();


			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(a / 2, h, a / 2);
			gl.Vertex(a, 0.0f, a);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.End();
			gl.Flush();


			gl.Begin(OpenGL.GL_LINE_STRIP);
			// Ve mat sau SAD
			gl.Vertex(a / 2, h, a / 2);
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.End();
			gl.Flush();

			gl.PointSize(1.0f);

		}


		public override void draw(OpenGL gl, bool isSelected = false)
		{
			float a = 2.0f;
			// Ve hinh chop deu day hinh vuong voi dinh S tuy y va canh day la a
			float h = 5.0f;
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
			gl.Vertex(a/2, h, a/2);
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
		}
		public CSquarePyramid() : base()
		{
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
			float a = 4.0f;
			float h = 5.0f;

			if (isSelected)
			{ // Neu selected
			  // Duong vien mau cam dam
				gl.Color(255 / 255.0f, 128 / 255.0, 0);
			}
			else
				gl.Color(224 / 255.0f, 224 / 255.0f, 224 / 255.0f);
			gl.LineWidth(3);

			// Ve bien
			gl.Begin(OpenGL.GL_LINE_STRIP);
			// Ve day ABC
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.Vertex(a / 2, 0.0f, a);
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_STRIP);
			// Ve mat ben thu nhat AA'C'C
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(0.0f, h, 0.0f);
			gl.Vertex(a / 2, h, a);
			gl.Vertex(a / 2, 0.0f, a);
			gl.End();
			gl.Flush();

			gl.Begin(OpenGL.GL_LINE_STRIP);
			// Ve mat ben thu hai CC'B'B
			gl.Vertex(a / 2, 0.0f, a);
			gl.Vertex(a / 2, h, a);
			gl.Vertex(a, h, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.End();
			gl.Flush();


			gl.Begin(OpenGL.GL_LINE_STRIP);
			// Ve mat sau AA'B'B
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(0.0f, h, 0.0f);
			gl.Vertex(a, h, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.End();
			gl.Flush();


			gl.Begin(OpenGL.GL_LINE_STRIP);
			// Ve day tren A'B'C'
			gl.Vertex(0.0f, h, 0.0f);
			gl.Vertex(a, h, 0.0f);
			gl.Vertex(a / 2, h, a);
			gl.End();
			gl.Flush();
			gl.LineWidth(1);
		}


		public override void draw(OpenGL gl, bool isSelected = false)
		{
			// Ve hinh tru co day la tam giac deu voi canh a tuy y
			float a = 4.0f;
			float h = 5.0f;

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

		public void setColorOfOneObj(int idx, Color color) {
			lst[idx].ColorUse = color;
		}

	}

	public class CDrawObject
	{
		private CListObject lstObj = new CListObject();

		public void draw(OpenGL gl)
		{
			lstObj.draw(gl);
		}

		public void draw(OpenGL gl, int idxSelected) {
			lstObj.draw(gl, idxSelected);
		}

		public void addObj(TypeObject type, Color color)
		{
			CObject obj = null;
			switch (type)
			{
				case TypeObject.CUBE:
					obj = new CCube();
					break;
				case TypeObject.SQUARE_PYRAMID:
					obj = new CSquarePyramid();
					break;
				case TypeObject.TRIANGULAR_PRISM:
					obj = new CTriangularPrism();
					break;
			}

			obj.ColorUse = color;
			// Them obj nay vao lstObj
			lstObj.add(obj);
		}

		public int getLength() {
			return lstObj.getLength();
		}

		public void setColorOfOneObj(int idx, Color color) {
			lstObj.setColorOfOneObj(idx, color);
		}

	}



}
