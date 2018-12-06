using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
	public class CDrawObject
	{
		
		public void drawColouredCube(OpenGL gl)
		{
			// Ve hinh lap phuong voi canh a bat ky
			float a = 2.0f;
			gl.Begin(OpenGL.GL_QUADS);

			gl.Color(0.0f, 1.0f, 0.0f);    // Color Blue
			gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Top)
			gl.Vertex(a, 0.0f, 0.0f);    // Top Left Of The Quad (Top)
			gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Top)
			gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Top)

			gl.Color(1.0f, 0.5f, 0.0f);    // Color Orange
			gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Bottom)
			gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Bottom)
			gl.Vertex(a, a, 0.0f);    // Bottom Left Of The Quad (Bottom)
			gl.Vertex(a, 0.0f, 0.0f);    // Bottom Right Of The Quad (Bottom)

			gl.Color(1.0f, 0.0f, 0.0f);    // Color Red    
			gl.Vertex(0.0f, 0.0f, 0.0f);    // Top Right Of The Quad (Front)
			gl.Vertex(0.0f, a, 0.0f);    // Top Left Of The Quad (Front)
			gl.Vertex(0.0f, a, a);    // Bottom Left Of The Quad (Front)
			gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Front)

			gl.Color(1.0f, 1.0f, 0.0f);    // Color Yellow
			gl.Vertex(0.0f, a, a);    // Top Right Of The Quad (Back)
			gl.Vertex(a, a, a);    // Top Left Of The Quad (Back)
			gl.Vertex(a, 0.0f, a);    // Bottom Left Of The Quad (Back)
			gl.Vertex(0.0f, 0.0f, a);    // Bottom Right Of The Quad (Back)

			gl.Color(0.0f, 0.0f, 1.0f);    // Color Blue
			gl.Vertex(a, a, a);    // Top Right Of The Quad (Left)
			gl.Vertex(a, a, 0.0f);    // Top Left Of The Quad (Left)
			gl.Vertex(a, 0.0f, 0.0f);    // Bottom Left Of The Quad (Left)
			gl.Vertex(a, 0.0f, a);    // Bottom Right Of The Quad (Left)

			gl.Color(1.0f, 0.0f, 1.0f);    // Color Violet
			gl.Vertex(0.0f, a, 0.0f);    // Top Right Of The Quad (Right)
			gl.Vertex(a, a, 0.0f);    // Top Left Of The Quad (Right)
			gl.Vertex(a, a, a);    // Bottom Left Of The Quad (Right)
			gl.Vertex(0.0f, a, a);    // Bottom 

			gl.End();
			gl.Flush();
		}

		// Ve hinh chop, day la hinh vuong
		public void drawPyramidWithSpareBottom(OpenGL gl) {
			float a = 2.0f;
			// Ve hinh chop day hinh vuong voi dinh S tuy y va canh day la a
			// Gia su S(10, 6, 4)
			float h = 5;

			// Ve day
			gl.Begin(OpenGL.GL_QUADS);
			gl.Color(0.0f, 1.0f, 0.0f); // Blue
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, a);
			gl.Vertex(0.0f, 0.0f, a);
			gl.End();
			gl.Flush();

			// Ve 4 mat ben
			gl.Begin(OpenGL.GL_TRIANGLES);
			// Ve mat ben trai SAB
			gl.Color(1.0f, 0.5f, 0.0f);    // Color Orange
			gl.Vertex(3.0f, 6.0f, 2.0f);
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(0.0f, 0.0f, a);

			// Ve mat giua SBC
			gl.Color(1.0f, 0.0f, 0.0f);    // Color Red   
			gl.Vertex(3.0f, 6.0f, 2.0f);
			gl.Vertex(0.0f, 0.0f, a);
			gl.Vertex(a, 0.0f, a);

			// Ve mat ben phai SCD
			gl.Color(1.0f, 1.0f, 0.0f);    // Color Yellow
			gl.Vertex(3.0f, 6.0f, 2.0f);
			gl.Vertex(a, 0.0f, a);
			gl.Vertex(a, 0.0f, 0.0f);

			// Ve mat sau SAD
			gl.Color(1.0f, 0.0f, 1.0f);    // Color Violet
			gl.Vertex(3.0f, 6.0f, 2.0f);
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);

			gl.End();
			gl.Flush();
		}

		public void drawCylinderWithTriangleBottom(OpenGL gl) {
			// Ve hinh tru co day la tam giac deu voi canh a tuy y
			
			float a = 2.0f;
			float h = 5.0f;

			gl.Begin(OpenGL.GL_TRIANGLES);
			// Ve day ABC
			gl.Color(0.0f, 1.0f, 0.0f); // Blue
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
			gl.Vertex(a / 2, 0.0f, a);
			gl.End();
			gl.Flush();

			// Ve cac mat ben
			gl.Begin(OpenGL.GL_QUADS);
			// Ve mat ben thu nhat AA'C'C
			gl.Color(1.0f, 0.5f, 0.0f);    // Color Orange
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(0.0f, h, 0.0f);
			gl.Vertex(a / 2, h, a);
			gl.Vertex(a / 2, 0.0f, a);

			// Ve mat ben thu hai CC'B'B
			gl.Color(1.0f, 0.0f, 0.0f);    // Color Red  
			gl.Vertex(a / 2, 0.0f, a);
			gl.Vertex(a / 2, h, a);
			gl.Vertex(a, h, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);

			// Ve mat sau AA'B'B
			gl.Color(1.0f, 1.0f, 0.0f);    // Color Yellow
			gl.Vertex(0.0f, 0.0f, 0.0f);
			gl.Vertex(0.0f, h, 0.0f);
			gl.Vertex(a, h, 0.0f);
			gl.Vertex(a, 0.0f, 0.0f);
		}
	}
}
