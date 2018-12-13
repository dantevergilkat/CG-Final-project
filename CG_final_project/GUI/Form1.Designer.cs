namespace GUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.pnl_Tool_bar = new System.Windows.Forms.Panel();
            this.TextureButton = new System.Windows.Forms.Button();
            this.bt_Color = new System.Windows.Forms.Button();
            this.bt_Palette = new System.Windows.Forms.Button();
            this.bt_Scale = new System.Windows.Forms.Button();
            this.imgList_icon_affine = new System.Windows.Forms.ImageList(this.components);
            this.bt_Stop = new System.Windows.Forms.Button();
            this.bt_Prism = new System.Windows.Forms.Button();
            this.imgList_icon_object = new System.Windows.Forms.ImageList(this.components);
            this.bt_Rotate = new System.Windows.Forms.Button();
            this.bt_Pyramid = new System.Windows.Forms.Button();
            this.bt_Cube = new System.Windows.Forms.Button();
            this.bt_Move = new System.Windows.Forms.Button();
            this.lstBox_SampleScene = new System.Windows.Forms.ListBox();
            this.lb_SampleScene = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnl_Transform = new System.Windows.Forms.Panel();
            this.bt_Enter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ScaleZ = new System.Windows.Forms.TextBox();
            this.textBox_ScaleY = new System.Windows.Forms.TextBox();
            this.textBox_ScaleX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_RotateZ = new System.Windows.Forms.TextBox();
            this.textBox_RotateY = new System.Windows.Forms.TextBox();
            this.textBox_RotateX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PosZ = new System.Windows.Forms.TextBox();
            this.textBox_PosY = new System.Windows.Forms.TextBox();
            this.textBox_PosX = new System.Windows.Forms.TextBox();
            this.lb_Scale = new System.Windows.Forms.Label();
            this.lb_Rotation = new System.Windows.Forms.Label();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_Transform = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.pnl_Tool_bar.SuspendLayout();
            this.pnl_Transform.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(0, 183);
            this.openGLControl1.Margin = new System.Windows.Forms.Padding(5);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(1564, 689);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openGLControl1.Resized += new System.EventHandler(this.openGLControl1_Resized);
            this.openGLControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.openGLControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl1_MouseDown);
            this.openGLControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl1_MouseMove);
            this.openGLControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl1_MouseUp);
            // 
            // pnl_Tool_bar
            // 
            this.pnl_Tool_bar.Controls.Add(this.TextureButton);
            this.pnl_Tool_bar.Controls.Add(this.bt_Color);
            this.pnl_Tool_bar.Controls.Add(this.bt_Palette);
            this.pnl_Tool_bar.Controls.Add(this.bt_Scale);
            this.pnl_Tool_bar.Controls.Add(this.bt_Stop);
            this.pnl_Tool_bar.Controls.Add(this.bt_Prism);
            this.pnl_Tool_bar.Controls.Add(this.bt_Rotate);
            this.pnl_Tool_bar.Controls.Add(this.bt_Pyramid);
            this.pnl_Tool_bar.Controls.Add(this.bt_Cube);
            this.pnl_Tool_bar.Controls.Add(this.bt_Move);
            this.pnl_Tool_bar.Location = new System.Drawing.Point(4, 33);
            this.pnl_Tool_bar.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Tool_bar.Name = "pnl_Tool_bar";
            this.pnl_Tool_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnl_Tool_bar.Size = new System.Drawing.Size(993, 143);
            this.pnl_Tool_bar.TabIndex = 1;
            // 
            // TextureButton
            // 
            this.TextureButton.Image = ((System.Drawing.Image)(resources.GetObject("TextureButton.Image")));
            this.TextureButton.Location = new System.Drawing.Point(693, 42);
            this.TextureButton.Name = "TextureButton";
            this.TextureButton.Size = new System.Drawing.Size(53, 49);
            this.TextureButton.TabIndex = 9;
            this.TextureButton.UseVisualStyleBackColor = true;
            this.TextureButton.Click += new System.EventHandler(this.TextureButton_Click);
            // 
            // bt_Color
            // 
            this.bt_Color.BackColor = System.Drawing.Color.White;
            this.bt_Color.Location = new System.Drawing.Point(772, 42);
            this.bt_Color.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Color.Name = "bt_Color";
            this.bt_Color.Size = new System.Drawing.Size(60, 55);
            this.bt_Color.TabIndex = 8;
            this.bt_Color.UseVisualStyleBackColor = false;
            this.bt_Color.Click += new System.EventHandler(this.bt_Color_Click);
            // 
            // bt_Palette
            // 
            this.bt_Palette.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Palette.Image = ((System.Drawing.Image)(resources.GetObject("bt_Palette.Image")));
            this.bt_Palette.Location = new System.Drawing.Point(853, 31);
            this.bt_Palette.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Palette.Name = "bt_Palette";
            this.bt_Palette.Size = new System.Drawing.Size(83, 76);
            this.bt_Palette.TabIndex = 7;
            this.bt_Palette.UseVisualStyleBackColor = true;
            this.bt_Palette.Click += new System.EventHandler(this.bt_Palette_Click);
            // 
            // bt_Scale
            // 
            this.bt_Scale.ImageIndex = 3;
            this.bt_Scale.ImageList = this.imgList_icon_affine;
            this.bt_Scale.Location = new System.Drawing.Point(632, 42);
            this.bt_Scale.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Scale.Name = "bt_Scale";
            this.bt_Scale.Size = new System.Drawing.Size(53, 49);
            this.bt_Scale.TabIndex = 6;
            this.bt_Scale.UseVisualStyleBackColor = true;
            this.bt_Scale.Click += new System.EventHandler(this.bt_Scale_Click);
            // 
            // imgList_icon_affine
            // 
            this.imgList_icon_affine.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_icon_affine.ImageStream")));
            this.imgList_icon_affine.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_icon_affine.Images.SetKeyName(0, "select.png");
            this.imgList_icon_affine.Images.SetKeyName(1, "move-option.png");
            this.imgList_icon_affine.Images.SetKeyName(2, "rotate.png");
            this.imgList_icon_affine.Images.SetKeyName(3, "zoom-out.png");
            this.imgList_icon_affine.Images.SetKeyName(4, "privacy.png");
            // 
            // bt_Stop
            // 
            this.bt_Stop.ImageIndex = 4;
            this.bt_Stop.ImageList = this.imgList_icon_affine;
            this.bt_Stop.Location = new System.Drawing.Point(448, 42);
            this.bt_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(53, 49);
            this.bt_Stop.TabIndex = 3;
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // bt_Prism
            // 
            this.bt_Prism.ImageIndex = 2;
            this.bt_Prism.ImageList = this.imgList_icon_object;
            this.bt_Prism.Location = new System.Drawing.Point(288, 15);
            this.bt_Prism.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Prism.Name = "bt_Prism";
            this.bt_Prism.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Prism.Size = new System.Drawing.Size(100, 92);
            this.bt_Prism.TabIndex = 2;
            this.bt_Prism.UseVisualStyleBackColor = true;
            this.bt_Prism.Click += new System.EventHandler(this.bt_Prism_Click);
            // 
            // imgList_icon_object
            // 
            this.imgList_icon_object.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_icon_object.ImageStream")));
            this.imgList_icon_object.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_icon_object.Images.SetKeyName(0, "clipart161515.png");
            this.imgList_icon_object.Images.SetKeyName(1, "clipart166330.png");
            this.imgList_icon_object.Images.SetKeyName(2, "clipart466993.png");
            // 
            // bt_Rotate
            // 
            this.bt_Rotate.ImageIndex = 2;
            this.bt_Rotate.ImageList = this.imgList_icon_affine;
            this.bt_Rotate.Location = new System.Drawing.Point(571, 42);
            this.bt_Rotate.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Rotate.Name = "bt_Rotate";
            this.bt_Rotate.Size = new System.Drawing.Size(53, 49);
            this.bt_Rotate.TabIndex = 5;
            this.bt_Rotate.UseVisualStyleBackColor = true;
            this.bt_Rotate.Click += new System.EventHandler(this.bt_Rotate_Click);
            // 
            // bt_Pyramid
            // 
            this.bt_Pyramid.ImageIndex = 0;
            this.bt_Pyramid.ImageList = this.imgList_icon_object;
            this.bt_Pyramid.Location = new System.Drawing.Point(163, 15);
            this.bt_Pyramid.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Pyramid.Name = "bt_Pyramid";
            this.bt_Pyramid.Size = new System.Drawing.Size(100, 92);
            this.bt_Pyramid.TabIndex = 1;
            this.bt_Pyramid.UseVisualStyleBackColor = true;
            this.bt_Pyramid.Click += new System.EventHandler(this.bt_Pyramid_Click);
            // 
            // bt_Cube
            // 
            this.bt_Cube.ImageIndex = 1;
            this.bt_Cube.ImageList = this.imgList_icon_object;
            this.bt_Cube.Location = new System.Drawing.Point(36, 15);
            this.bt_Cube.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Cube.Name = "bt_Cube";
            this.bt_Cube.Size = new System.Drawing.Size(100, 92);
            this.bt_Cube.TabIndex = 0;
            this.bt_Cube.UseVisualStyleBackColor = true;
            this.bt_Cube.Click += new System.EventHandler(this.bt_Cube_Click);
            // 
            // bt_Move
            // 
            this.bt_Move.ImageIndex = 1;
            this.bt_Move.ImageList = this.imgList_icon_affine;
            this.bt_Move.Location = new System.Drawing.Point(509, 42);
            this.bt_Move.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Move.Name = "bt_Move";
            this.bt_Move.Size = new System.Drawing.Size(53, 49);
            this.bt_Move.TabIndex = 4;
            this.bt_Move.UseVisualStyleBackColor = true;
            this.bt_Move.Click += new System.EventHandler(this.bt_Move_Click);
            // 
            // lstBox_SampleScene
            // 
            this.lstBox_SampleScene.FormattingEnabled = true;
            this.lstBox_SampleScene.ItemHeight = 16;
            this.lstBox_SampleScene.Location = new System.Drawing.Point(1584, 226);
            this.lstBox_SampleScene.Margin = new System.Windows.Forms.Padding(4);
            this.lstBox_SampleScene.Name = "lstBox_SampleScene";
            this.lstBox_SampleScene.Size = new System.Drawing.Size(220, 260);
            this.lstBox_SampleScene.TabIndex = 3;
            this.lstBox_SampleScene.SelectedIndexChanged += new System.EventHandler(this.lstBox_SampleScene_SelectedIndexChanged);
            // 
            // lb_SampleScene
            // 
            this.lb_SampleScene.AutoSize = true;
            this.lb_SampleScene.Location = new System.Drawing.Point(1585, 199);
            this.lb_SampleScene.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SampleScene.Name = "lb_SampleScene";
            this.lb_SampleScene.Size = new System.Drawing.Size(97, 17);
            this.lb_SampleScene.TabIndex = 4;
            this.lb_SampleScene.Text = "Sample scene";
            // 
            // pnl_Transform
            // 
            this.pnl_Transform.Controls.Add(this.bt_Enter);
            this.pnl_Transform.Controls.Add(this.label7);
            this.pnl_Transform.Controls.Add(this.label8);
            this.pnl_Transform.Controls.Add(this.label9);
            this.pnl_Transform.Controls.Add(this.textBox_ScaleZ);
            this.pnl_Transform.Controls.Add(this.textBox_ScaleY);
            this.pnl_Transform.Controls.Add(this.textBox_ScaleX);
            this.pnl_Transform.Controls.Add(this.label4);
            this.pnl_Transform.Controls.Add(this.label5);
            this.pnl_Transform.Controls.Add(this.label6);
            this.pnl_Transform.Controls.Add(this.textBox_RotateZ);
            this.pnl_Transform.Controls.Add(this.textBox_RotateY);
            this.pnl_Transform.Controls.Add(this.textBox_RotateX);
            this.pnl_Transform.Controls.Add(this.label3);
            this.pnl_Transform.Controls.Add(this.label2);
            this.pnl_Transform.Controls.Add(this.label1);
            this.pnl_Transform.Controls.Add(this.textBox_PosZ);
            this.pnl_Transform.Controls.Add(this.textBox_PosY);
            this.pnl_Transform.Controls.Add(this.textBox_PosX);
            this.pnl_Transform.Controls.Add(this.lb_Scale);
            this.pnl_Transform.Controls.Add(this.lb_Rotation);
            this.pnl_Transform.Controls.Add(this.lb_Position);
            this.pnl_Transform.Controls.Add(this.lb_Transform);
            this.pnl_Transform.Location = new System.Drawing.Point(1005, 37);
            this.pnl_Transform.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Transform.Name = "pnl_Transform";
            this.pnl_Transform.Size = new System.Drawing.Size(579, 123);
            this.pnl_Transform.TabIndex = 5;
            // 
            // bt_Enter
            // 
            this.bt_Enter.Location = new System.Drawing.Point(469, 23);
            this.bt_Enter.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Enter.Name = "bt_Enter";
            this.bt_Enter.Size = new System.Drawing.Size(93, 92);
            this.bt_Enter.TabIndex = 22;
            this.bt_Enter.Text = "Enter";
            this.bt_Enter.UseVisualStyleBackColor = true;
            this.bt_Enter.Click += new System.EventHandler(this.bt_Enter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "X";
            // 
            // textBox_ScaleZ
            // 
            this.textBox_ScaleZ.Location = new System.Drawing.Point(381, 90);
            this.textBox_ScaleZ.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ScaleZ.Name = "textBox_ScaleZ";
            this.textBox_ScaleZ.Size = new System.Drawing.Size(75, 22);
            this.textBox_ScaleZ.TabIndex = 18;
            this.textBox_ScaleZ.Text = "0";
            // 
            // textBox_ScaleY
            // 
            this.textBox_ScaleY.Location = new System.Drawing.Point(255, 90);
            this.textBox_ScaleY.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ScaleY.Name = "textBox_ScaleY";
            this.textBox_ScaleY.Size = new System.Drawing.Size(75, 22);
            this.textBox_ScaleY.TabIndex = 17;
            this.textBox_ScaleY.Text = "0";
            // 
            // textBox_ScaleX
            // 
            this.textBox_ScaleX.Location = new System.Drawing.Point(125, 90);
            this.textBox_ScaleX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ScaleX.Name = "textBox_ScaleX";
            this.textBox_ScaleX.Size = new System.Drawing.Size(75, 22);
            this.textBox_ScaleX.TabIndex = 16;
            this.textBox_ScaleX.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            // 
            // textBox_RotateZ
            // 
            this.textBox_RotateZ.Location = new System.Drawing.Point(381, 58);
            this.textBox_RotateZ.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RotateZ.Name = "textBox_RotateZ";
            this.textBox_RotateZ.Size = new System.Drawing.Size(75, 22);
            this.textBox_RotateZ.TabIndex = 12;
            this.textBox_RotateZ.Text = "0";
            // 
            // textBox_RotateY
            // 
            this.textBox_RotateY.Location = new System.Drawing.Point(255, 58);
            this.textBox_RotateY.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RotateY.Name = "textBox_RotateY";
            this.textBox_RotateY.Size = new System.Drawing.Size(75, 22);
            this.textBox_RotateY.TabIndex = 11;
            this.textBox_RotateY.Text = "0";
            // 
            // textBox_RotateX
            // 
            this.textBox_RotateX.Location = new System.Drawing.Point(125, 58);
            this.textBox_RotateX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RotateX.Name = "textBox_RotateX";
            this.textBox_RotateX.Size = new System.Drawing.Size(75, 22);
            this.textBox_RotateX.TabIndex = 10;
            this.textBox_RotateX.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // textBox_PosZ
            // 
            this.textBox_PosZ.Location = new System.Drawing.Point(381, 23);
            this.textBox_PosZ.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PosZ.Name = "textBox_PosZ";
            this.textBox_PosZ.Size = new System.Drawing.Size(75, 22);
            this.textBox_PosZ.TabIndex = 6;
            this.textBox_PosZ.Text = "0";
            this.textBox_PosZ.Click += new System.EventHandler(this.textBox_PosZ_Click);
            this.textBox_PosZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PosZ_KeyPress);
            // 
            // textBox_PosY
            // 
            this.textBox_PosY.Location = new System.Drawing.Point(255, 23);
            this.textBox_PosY.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PosY.Name = "textBox_PosY";
            this.textBox_PosY.Size = new System.Drawing.Size(75, 22);
            this.textBox_PosY.TabIndex = 5;
            this.textBox_PosY.Text = "0";
            this.textBox_PosY.Click += new System.EventHandler(this.textBox_PosY_Click);
            this.textBox_PosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PosY_KeyPress);
            // 
            // textBox_PosX
            // 
            this.textBox_PosX.Location = new System.Drawing.Point(125, 23);
            this.textBox_PosX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PosX.Name = "textBox_PosX";
            this.textBox_PosX.Size = new System.Drawing.Size(75, 22);
            this.textBox_PosX.TabIndex = 4;
            this.textBox_PosX.Text = "0";
            this.textBox_PosX.Click += new System.EventHandler(this.textBox_PosX_Click);
            this.textBox_PosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PosX_KeyPress);
            // 
            // lb_Scale
            // 
            this.lb_Scale.AutoSize = true;
            this.lb_Scale.Location = new System.Drawing.Point(17, 94);
            this.lb_Scale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Scale.Name = "lb_Scale";
            this.lb_Scale.Size = new System.Drawing.Size(43, 17);
            this.lb_Scale.TabIndex = 3;
            this.lb_Scale.Text = "Scale";
            // 
            // lb_Rotation
            // 
            this.lb_Rotation.AutoSize = true;
            this.lb_Rotation.Location = new System.Drawing.Point(17, 63);
            this.lb_Rotation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Rotation.Name = "lb_Rotation";
            this.lb_Rotation.Size = new System.Drawing.Size(61, 17);
            this.lb_Rotation.TabIndex = 2;
            this.lb_Rotation.Text = "Rotation";
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Location = new System.Drawing.Point(17, 27);
            this.lb_Position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(58, 17);
            this.lb_Position.TabIndex = 1;
            this.lb_Position.Text = "Position";
            // 
            // lb_Transform
            // 
            this.lb_Transform.AutoSize = true;
            this.lb_Transform.Location = new System.Drawing.Point(4, 0);
            this.lb_Transform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Transform.Name = "lb_Transform";
            this.lb_Transform.Size = new System.Drawing.Size(73, 17);
            this.lb_Transform.TabIndex = 0;
            this.lb_Transform.Text = "Transform";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1821, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1821, 868);
            this.Controls.Add(this.pnl_Transform);
            this.Controls.Add(this.lb_SampleScene);
            this.Controls.Add(this.lstBox_SampleScene);
            this.Controls.Add(this.pnl_Tool_bar);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.pnl_Tool_bar.ResumeLayout(false);
            this.pnl_Transform.ResumeLayout(false);
            this.pnl_Transform.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private SharpGL.OpenGLControl openGLControl1;
		private System.Windows.Forms.Panel pnl_Tool_bar;
		private System.Windows.Forms.ListBox lstBox_SampleScene;
		private System.Windows.Forms.Button bt_Pyramid;
		private System.Windows.Forms.Button bt_Cube;
		private System.Windows.Forms.Label lb_SampleScene;
		private System.Windows.Forms.Button bt_Prism;
		private System.Windows.Forms.Button bt_Scale;
		private System.Windows.Forms.ImageList imgList_icon_affine;
		private System.Windows.Forms.Button bt_Rotate;
		private System.Windows.Forms.Button bt_Move;
		private System.Windows.Forms.Button bt_Stop;
		private System.Windows.Forms.ImageList imgList_icon_object;
		private System.Windows.Forms.Button bt_Palette;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button bt_Color;
		private System.Windows.Forms.Panel pnl_Transform;
		private System.Windows.Forms.TextBox textBox_PosZ;
		private System.Windows.Forms.TextBox textBox_PosY;
		private System.Windows.Forms.TextBox textBox_PosX;
		private System.Windows.Forms.Label lb_Scale;
		private System.Windows.Forms.Label lb_Rotation;
		private System.Windows.Forms.Label lb_Position;
		private System.Windows.Forms.Label lb_Transform;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox_ScaleZ;
		private System.Windows.Forms.TextBox textBox_ScaleY;
		private System.Windows.Forms.TextBox textBox_ScaleX;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_RotateZ;
		private System.Windows.Forms.TextBox textBox_RotateY;
		private System.Windows.Forms.TextBox textBox_RotateX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.Button bt_Enter;
        private System.Windows.Forms.Button TextureButton;
    }
}

