namespace GUI
{
	partial class Form_3D_Scenes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_3D_Scenes));
			this.openGLControl1 = new SharpGL.OpenGLControl();
			this.bt_Color = new System.Windows.Forms.Button();
			this.bt_Palette = new System.Windows.Forms.Button();
			this.bt_Stop = new System.Windows.Forms.Button();
			this.imgList_icon_affine = new System.Windows.Forms.ImageList(this.components);
			this.bt_Prism = new System.Windows.Forms.Button();
			this.imgList_icon_object = new System.Windows.Forms.ImageList(this.components);
			this.bt_Pyramid = new System.Windows.Forms.Button();
			this.bt_Cube = new System.Windows.Forms.Button();
			this.lstBox_SampleScene = new System.Windows.Forms.ListBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.bt_Enter = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox_ScaleZ = new System.Windows.Forms.TextBox();
			this.textBox_ScaleY = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_RotateZ = new System.Windows.Forms.TextBox();
			this.textBox_RotateY = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_PosZ = new System.Windows.Forms.TextBox();
			this.textBox_PosY = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox_Objects = new System.Windows.Forms.GroupBox();
			this.groupBox_Color = new System.Windows.Forms.GroupBox();
			this.groupBox_SampleScenes = new System.Windows.Forms.GroupBox();
			this.TextureButton = new System.Windows.Forms.Button();
			this.groupBox_Transform = new System.Windows.Forms.GroupBox();
			this.label_Stop = new System.Windows.Forms.Label();
			this.lb_Position = new System.Windows.Forms.Label();
			this.lb_Rotation = new System.Windows.Forms.Label();
			this.lb_Scale = new System.Windows.Forms.Label();
			this.textBox_PosX = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_ScaleX = new System.Windows.Forms.TextBox();
			this.textBox_RotateX = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox_Texture = new System.Windows.Forms.GroupBox();
			this.groupBox_Camera = new System.Windows.Forms.GroupBox();
			this.textBox_Cam_PosX = new System.Windows.Forms.TextBox();
			this.lb_Cam_Pos = new System.Windows.Forms.Label();
			this.lb_Cam_PosX = new System.Windows.Forms.Label();
			this.lb_Cam_PosY = new System.Windows.Forms.Label();
			this.textBox_Cam_PosY = new System.Windows.Forms.TextBox();
			this.lb_Cam_PosZ = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lb_View = new System.Windows.Forms.Label();
			this.textBox_View = new System.Windows.Forms.TextBox();
			this.lb_VpZ = new System.Windows.Forms.Label();
			this.textBox_VpZ = new System.Windows.Forms.TextBox();
			this.lb_VpY = new System.Windows.Forms.Label();
			this.textBox_VpY = new System.Windows.Forms.TextBox();
			this.lb_VpX = new System.Windows.Forms.Label();
			this.lb_Viewport = new System.Windows.Forms.Label();
			this.textBox_VpX = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.groupBox_Objects.SuspendLayout();
			this.groupBox_Color.SuspendLayout();
			this.groupBox_SampleScenes.SuspendLayout();
			this.groupBox_Transform.SuspendLayout();
			this.groupBox_Texture.SuspendLayout();
			this.groupBox_Camera.SuspendLayout();
			this.SuspendLayout();
			// 
			// openGLControl1
			// 
			this.openGLControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.openGLControl1.DrawFPS = false;
			this.openGLControl1.Location = new System.Drawing.Point(0, 133);
			this.openGLControl1.Margin = new System.Windows.Forms.Padding(4);
			this.openGLControl1.Name = "openGLControl1";
			this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
			this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
			this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
			this.openGLControl1.Size = new System.Drawing.Size(1153, 576);
			this.openGLControl1.TabIndex = 0;
			this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
			this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
			this.openGLControl1.Resized += new System.EventHandler(this.openGLControl1_Resized);
			this.openGLControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			// 
			// bt_Color
			// 
			this.bt_Color.BackColor = System.Drawing.Color.White;
			this.bt_Color.Location = new System.Drawing.Point(27, 30);
			this.bt_Color.Name = "bt_Color";
			this.bt_Color.Size = new System.Drawing.Size(50, 50);
			this.bt_Color.TabIndex = 8;
			this.bt_Color.UseVisualStyleBackColor = false;
			this.bt_Color.Click += new System.EventHandler(this.bt_Color_Click);
			// 
			// bt_Palette
			// 
			this.bt_Palette.ForeColor = System.Drawing.SystemColors.Control;
			this.bt_Palette.Image = ((System.Drawing.Image)(resources.GetObject("bt_Palette.Image")));
			this.bt_Palette.Location = new System.Drawing.Point(102, 18);
			this.bt_Palette.Name = "bt_Palette";
			this.bt_Palette.Size = new System.Drawing.Size(75, 75);
			this.bt_Palette.TabIndex = 7;
			this.bt_Palette.UseVisualStyleBackColor = true;
			this.bt_Palette.Click += new System.EventHandler(this.bt_Palette_Click);
			// 
			// bt_Stop
			// 
			this.bt_Stop.ImageIndex = 4;
			this.bt_Stop.ImageList = this.imgList_icon_affine;
			this.bt_Stop.Location = new System.Drawing.Point(442, 18);
			this.bt_Stop.Name = "bt_Stop";
			this.bt_Stop.Size = new System.Drawing.Size(50, 50);
			this.bt_Stop.TabIndex = 3;
			this.bt_Stop.UseVisualStyleBackColor = true;
			this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
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
			// bt_Prism
			// 
			this.bt_Prism.ImageIndex = 2;
			this.bt_Prism.ImageList = this.imgList_icon_object;
			this.bt_Prism.Location = new System.Drawing.Point(215, 18);
			this.bt_Prism.Name = "bt_Prism";
			this.bt_Prism.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_Prism.Size = new System.Drawing.Size(75, 75);
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
			// bt_Pyramid
			// 
			this.bt_Pyramid.ImageIndex = 0;
			this.bt_Pyramid.ImageList = this.imgList_icon_object;
			this.bt_Pyramid.Location = new System.Drawing.Point(116, 18);
			this.bt_Pyramid.Name = "bt_Pyramid";
			this.bt_Pyramid.Size = new System.Drawing.Size(75, 75);
			this.bt_Pyramid.TabIndex = 1;
			this.bt_Pyramid.UseVisualStyleBackColor = true;
			this.bt_Pyramid.Click += new System.EventHandler(this.bt_Pyramid_Click);
			// 
			// bt_Cube
			// 
			this.bt_Cube.ImageIndex = 1;
			this.bt_Cube.ImageList = this.imgList_icon_object;
			this.bt_Cube.Location = new System.Drawing.Point(18, 18);
			this.bt_Cube.Name = "bt_Cube";
			this.bt_Cube.Size = new System.Drawing.Size(75, 75);
			this.bt_Cube.TabIndex = 0;
			this.bt_Cube.UseVisualStyleBackColor = true;
			this.bt_Cube.Click += new System.EventHandler(this.bt_Cube_Click);
			// 
			// lstBox_SampleScene
			// 
			this.lstBox_SampleScene.FormattingEnabled = true;
			this.lstBox_SampleScene.Location = new System.Drawing.Point(9, 21);
			this.lstBox_SampleScene.Name = "lstBox_SampleScene";
			this.lstBox_SampleScene.Size = new System.Drawing.Size(191, 381);
			this.lstBox_SampleScene.TabIndex = 3;
			this.lstBox_SampleScene.SelectedIndexChanged += new System.EventHandler(this.lstBox_SampleScene_SelectedIndexChanged);
			// 
			// bt_Enter
			// 
			this.bt_Enter.Location = new System.Drawing.Point(365, 18);
			this.bt_Enter.Name = "bt_Enter";
			this.bt_Enter.Size = new System.Drawing.Size(70, 75);
			this.bt_Enter.TabIndex = 22;
			this.bt_Enter.Text = "Enter";
			this.bt_Enter.UseVisualStyleBackColor = true;
			this.bt_Enter.Click += new System.EventHandler(this.bt_Enter_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(279, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(14, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Z";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(184, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(14, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Y";
			// 
			// textBox_ScaleZ
			// 
			this.textBox_ScaleZ.Location = new System.Drawing.Point(299, 72);
			this.textBox_ScaleZ.Name = "textBox_ScaleZ";
			this.textBox_ScaleZ.Size = new System.Drawing.Size(57, 20);
			this.textBox_ScaleZ.TabIndex = 18;
			this.textBox_ScaleZ.Text = "1";
			this.textBox_ScaleZ.Click += new System.EventHandler(this.textBox_ScaleZ_Click);
			this.textBox_ScaleZ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ScaleZ_KeyDown);
			this.textBox_ScaleZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ScaleZ_KeyPress);
			// 
			// textBox_ScaleY
			// 
			this.textBox_ScaleY.Location = new System.Drawing.Point(204, 72);
			this.textBox_ScaleY.Name = "textBox_ScaleY";
			this.textBox_ScaleY.Size = new System.Drawing.Size(57, 20);
			this.textBox_ScaleY.TabIndex = 17;
			this.textBox_ScaleY.Text = "1";
			this.textBox_ScaleY.Click += new System.EventHandler(this.textBox_ScaleY_Click);
			this.textBox_ScaleY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ScaleY_KeyDown);
			this.textBox_ScaleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ScaleY_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(279, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Z";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(184, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(14, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Y";
			// 
			// textBox_RotateZ
			// 
			this.textBox_RotateZ.Location = new System.Drawing.Point(299, 46);
			this.textBox_RotateZ.Name = "textBox_RotateZ";
			this.textBox_RotateZ.Size = new System.Drawing.Size(57, 20);
			this.textBox_RotateZ.TabIndex = 12;
			this.textBox_RotateZ.Text = "0";
			this.textBox_RotateZ.Click += new System.EventHandler(this.textBox_RotateZ_Click);
			this.textBox_RotateZ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_RotateZ_KeyDown);
			this.textBox_RotateZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_RotateZ_KeyPress);
			// 
			// textBox_RotateY
			// 
			this.textBox_RotateY.Location = new System.Drawing.Point(204, 46);
			this.textBox_RotateY.Name = "textBox_RotateY";
			this.textBox_RotateY.Size = new System.Drawing.Size(57, 20);
			this.textBox_RotateY.TabIndex = 11;
			this.textBox_RotateY.Text = "0";
			this.textBox_RotateY.Click += new System.EventHandler(this.textBox_RotateY_Click);
			this.textBox_RotateY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_RotateY_KeyDown);
			this.textBox_RotateY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_RotateY_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(279, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Z";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(184, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Y";
			// 
			// textBox_PosZ
			// 
			this.textBox_PosZ.Location = new System.Drawing.Point(299, 18);
			this.textBox_PosZ.Name = "textBox_PosZ";
			this.textBox_PosZ.Size = new System.Drawing.Size(57, 20);
			this.textBox_PosZ.TabIndex = 6;
			this.textBox_PosZ.Text = "0";
			this.textBox_PosZ.Click += new System.EventHandler(this.textBox_PosZ_Click);
			this.textBox_PosZ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PosZ_KeyDown);
			this.textBox_PosZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PosZ_KeyPress);
			// 
			// textBox_PosY
			// 
			this.textBox_PosY.Location = new System.Drawing.Point(204, 18);
			this.textBox_PosY.Name = "textBox_PosY";
			this.textBox_PosY.Size = new System.Drawing.Size(57, 20);
			this.textBox_PosY.TabIndex = 5;
			this.textBox_PosY.Text = "0";
			this.textBox_PosY.Click += new System.EventHandler(this.textBox_PosY_Click);
			this.textBox_PosY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PosY_KeyDown);
			this.textBox_PosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PosY_KeyPress);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// groupBox_Objects
			// 
			this.groupBox_Objects.Controls.Add(this.bt_Pyramid);
			this.groupBox_Objects.Controls.Add(this.bt_Cube);
			this.groupBox_Objects.Controls.Add(this.bt_Prism);
			this.groupBox_Objects.Location = new System.Drawing.Point(12, 27);
			this.groupBox_Objects.Name = "groupBox_Objects";
			this.groupBox_Objects.Size = new System.Drawing.Size(314, 100);
			this.groupBox_Objects.TabIndex = 8;
			this.groupBox_Objects.TabStop = false;
			this.groupBox_Objects.Text = "Objects";
			// 
			// groupBox_Color
			// 
			this.groupBox_Color.Controls.Add(this.bt_Color);
			this.groupBox_Color.Controls.Add(this.bt_Palette);
			this.groupBox_Color.Location = new System.Drawing.Point(332, 27);
			this.groupBox_Color.Name = "groupBox_Color";
			this.groupBox_Color.Size = new System.Drawing.Size(200, 100);
			this.groupBox_Color.TabIndex = 3;
			this.groupBox_Color.TabStop = false;
			this.groupBox_Color.Text = "Color";
			// 
			// groupBox_SampleScenes
			// 
			this.groupBox_SampleScenes.Controls.Add(this.lstBox_SampleScene);
			this.groupBox_SampleScenes.Location = new System.Drawing.Point(1158, 234);
			this.groupBox_SampleScenes.Name = "groupBox_SampleScenes";
			this.groupBox_SampleScenes.Size = new System.Drawing.Size(208, 415);
			this.groupBox_SampleScenes.TabIndex = 9;
			this.groupBox_SampleScenes.TabStop = false;
			this.groupBox_SampleScenes.Text = "Sample scenes";
			// 
			// TextureButton
			// 
			this.TextureButton.Image = ((System.Drawing.Image)(resources.GetObject("TextureButton.Image")));
			this.TextureButton.Location = new System.Drawing.Point(16, 21);
			this.TextureButton.Margin = new System.Windows.Forms.Padding(2);
			this.TextureButton.Name = "TextureButton";
			this.TextureButton.Size = new System.Drawing.Size(70, 70);
			this.TextureButton.TabIndex = 10;
			this.TextureButton.UseVisualStyleBackColor = true;
			this.TextureButton.Click += new System.EventHandler(this.TextureButton_Click);
			// 
			// groupBox_Transform
			// 
			this.groupBox_Transform.Controls.Add(this.label_Stop);
			this.groupBox_Transform.Controls.Add(this.lb_Position);
			this.groupBox_Transform.Controls.Add(this.bt_Stop);
			this.groupBox_Transform.Controls.Add(this.bt_Enter);
			this.groupBox_Transform.Controls.Add(this.lb_Rotation);
			this.groupBox_Transform.Controls.Add(this.label7);
			this.groupBox_Transform.Controls.Add(this.lb_Scale);
			this.groupBox_Transform.Controls.Add(this.label8);
			this.groupBox_Transform.Controls.Add(this.textBox_PosX);
			this.groupBox_Transform.Controls.Add(this.label9);
			this.groupBox_Transform.Controls.Add(this.textBox_PosY);
			this.groupBox_Transform.Controls.Add(this.textBox_ScaleZ);
			this.groupBox_Transform.Controls.Add(this.textBox_PosZ);
			this.groupBox_Transform.Controls.Add(this.textBox_ScaleY);
			this.groupBox_Transform.Controls.Add(this.label1);
			this.groupBox_Transform.Controls.Add(this.textBox_ScaleX);
			this.groupBox_Transform.Controls.Add(this.label2);
			this.groupBox_Transform.Controls.Add(this.label4);
			this.groupBox_Transform.Controls.Add(this.label3);
			this.groupBox_Transform.Controls.Add(this.label5);
			this.groupBox_Transform.Controls.Add(this.textBox_RotateX);
			this.groupBox_Transform.Controls.Add(this.label6);
			this.groupBox_Transform.Controls.Add(this.textBox_RotateY);
			this.groupBox_Transform.Controls.Add(this.textBox_RotateZ);
			this.groupBox_Transform.Location = new System.Drawing.Point(538, 27);
			this.groupBox_Transform.Name = "groupBox_Transform";
			this.groupBox_Transform.Size = new System.Drawing.Size(504, 100);
			this.groupBox_Transform.TabIndex = 9;
			this.groupBox_Transform.TabStop = false;
			this.groupBox_Transform.Text = "Transform";
			// 
			// label_Stop
			// 
			this.label_Stop.AutoSize = true;
			this.label_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Stop.Location = new System.Drawing.Point(445, 72);
			this.label_Stop.Name = "label_Stop";
			this.label_Stop.Size = new System.Drawing.Size(43, 13);
			this.label_Stop.TabIndex = 23;
			this.label_Stop.Text = "Escape";
			// 
			// lb_Position
			// 
			this.lb_Position.AutoSize = true;
			this.lb_Position.Location = new System.Drawing.Point(26, 21);
			this.lb_Position.Name = "lb_Position";
			this.lb_Position.Size = new System.Drawing.Size(44, 13);
			this.lb_Position.TabIndex = 1;
			this.lb_Position.Text = "Position";
			// 
			// lb_Rotation
			// 
			this.lb_Rotation.AutoSize = true;
			this.lb_Rotation.Location = new System.Drawing.Point(26, 50);
			this.lb_Rotation.Name = "lb_Rotation";
			this.lb_Rotation.Size = new System.Drawing.Size(47, 13);
			this.lb_Rotation.TabIndex = 2;
			this.lb_Rotation.Text = "Rotation";
			// 
			// lb_Scale
			// 
			this.lb_Scale.AutoSize = true;
			this.lb_Scale.Location = new System.Drawing.Point(26, 75);
			this.lb_Scale.Name = "lb_Scale";
			this.lb_Scale.Size = new System.Drawing.Size(34, 13);
			this.lb_Scale.TabIndex = 3;
			this.lb_Scale.Text = "Scale";
			// 
			// textBox_PosX
			// 
			this.textBox_PosX.Location = new System.Drawing.Point(107, 18);
			this.textBox_PosX.Name = "textBox_PosX";
			this.textBox_PosX.Size = new System.Drawing.Size(57, 20);
			this.textBox_PosX.TabIndex = 4;
			this.textBox_PosX.Text = "0";
			this.textBox_PosX.Click += new System.EventHandler(this.textBox_PosX_Click);
			this.textBox_PosX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PosX_KeyDown);
			this.textBox_PosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PosX_KeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(87, 75);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(14, 13);
			this.label9.TabIndex = 19;
			this.label9.Text = "X";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "X";
			// 
			// textBox_ScaleX
			// 
			this.textBox_ScaleX.Location = new System.Drawing.Point(107, 72);
			this.textBox_ScaleX.Name = "textBox_ScaleX";
			this.textBox_ScaleX.Size = new System.Drawing.Size(57, 20);
			this.textBox_ScaleX.TabIndex = 16;
			this.textBox_ScaleX.Text = "1";
			this.textBox_ScaleX.Click += new System.EventHandler(this.textBox_ScaleX_Click);
			this.textBox_ScaleX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ScaleX_KeyDown);
			this.textBox_ScaleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ScaleX_KeyPress);
			// 
			// textBox_RotateX
			// 
			this.textBox_RotateX.Location = new System.Drawing.Point(107, 46);
			this.textBox_RotateX.Name = "textBox_RotateX";
			this.textBox_RotateX.Size = new System.Drawing.Size(57, 20);
			this.textBox_RotateX.TabIndex = 10;
			this.textBox_RotateX.Text = "0";
			this.textBox_RotateX.Click += new System.EventHandler(this.textBox_RotateX_Click);
			this.textBox_RotateX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_RotateX_KeyDown);
			this.textBox_RotateX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_RotateX_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(87, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "X";
			// 
			// groupBox_Texture
			// 
			this.groupBox_Texture.Controls.Add(this.TextureButton);
			this.groupBox_Texture.Location = new System.Drawing.Point(1048, 27);
			this.groupBox_Texture.Name = "groupBox_Texture";
			this.groupBox_Texture.Size = new System.Drawing.Size(105, 100);
			this.groupBox_Texture.TabIndex = 12;
			this.groupBox_Texture.TabStop = false;
			this.groupBox_Texture.Text = "Texture";
			// 
			// groupBox_Camera
			// 
			this.groupBox_Camera.Controls.Add(this.button1);
			this.groupBox_Camera.Controls.Add(this.lb_VpZ);
			this.groupBox_Camera.Controls.Add(this.textBox_VpZ);
			this.groupBox_Camera.Controls.Add(this.lb_VpY);
			this.groupBox_Camera.Controls.Add(this.textBox_VpY);
			this.groupBox_Camera.Controls.Add(this.lb_VpX);
			this.groupBox_Camera.Controls.Add(this.lb_Viewport);
			this.groupBox_Camera.Controls.Add(this.textBox_VpX);
			this.groupBox_Camera.Controls.Add(this.textBox_View);
			this.groupBox_Camera.Controls.Add(this.lb_View);
			this.groupBox_Camera.Controls.Add(this.lb_Cam_PosZ);
			this.groupBox_Camera.Controls.Add(this.textBox1);
			this.groupBox_Camera.Controls.Add(this.lb_Cam_PosY);
			this.groupBox_Camera.Controls.Add(this.textBox_Cam_PosY);
			this.groupBox_Camera.Controls.Add(this.lb_Cam_PosX);
			this.groupBox_Camera.Controls.Add(this.lb_Cam_Pos);
			this.groupBox_Camera.Controls.Add(this.textBox_Cam_PosX);
			this.groupBox_Camera.Location = new System.Drawing.Point(1159, 27);
			this.groupBox_Camera.Name = "groupBox_Camera";
			this.groupBox_Camera.Size = new System.Drawing.Size(207, 201);
			this.groupBox_Camera.TabIndex = 13;
			this.groupBox_Camera.TabStop = false;
			this.groupBox_Camera.Text = "Camera";
			// 
			// textBox_Cam_PosX
			// 
			this.textBox_Cam_PosX.Location = new System.Drawing.Point(25, 44);
			this.textBox_Cam_PosX.Name = "textBox_Cam_PosX";
			this.textBox_Cam_PosX.Size = new System.Drawing.Size(42, 20);
			this.textBox_Cam_PosX.TabIndex = 0;
			// 
			// lb_Cam_Pos
			// 
			this.lb_Cam_Pos.AutoSize = true;
			this.lb_Cam_Pos.Location = new System.Drawing.Point(6, 22);
			this.lb_Cam_Pos.Name = "lb_Cam_Pos";
			this.lb_Cam_Pos.Size = new System.Drawing.Size(44, 13);
			this.lb_Cam_Pos.TabIndex = 1;
			this.lb_Cam_Pos.Text = "Position";
			// 
			// lb_Cam_PosX
			// 
			this.lb_Cam_PosX.AutoSize = true;
			this.lb_Cam_PosX.Location = new System.Drawing.Point(5, 47);
			this.lb_Cam_PosX.Name = "lb_Cam_PosX";
			this.lb_Cam_PosX.Size = new System.Drawing.Size(14, 13);
			this.lb_Cam_PosX.TabIndex = 2;
			this.lb_Cam_PosX.Text = "X";
			// 
			// lb_Cam_PosY
			// 
			this.lb_Cam_PosY.AutoSize = true;
			this.lb_Cam_PosY.Location = new System.Drawing.Point(71, 47);
			this.lb_Cam_PosY.Name = "lb_Cam_PosY";
			this.lb_Cam_PosY.Size = new System.Drawing.Size(14, 13);
			this.lb_Cam_PosY.TabIndex = 4;
			this.lb_Cam_PosY.Text = "Y";
			// 
			// textBox_Cam_PosY
			// 
			this.textBox_Cam_PosY.Location = new System.Drawing.Point(91, 44);
			this.textBox_Cam_PosY.Name = "textBox_Cam_PosY";
			this.textBox_Cam_PosY.Size = new System.Drawing.Size(42, 20);
			this.textBox_Cam_PosY.TabIndex = 3;
			// 
			// lb_Cam_PosZ
			// 
			this.lb_Cam_PosZ.AutoSize = true;
			this.lb_Cam_PosZ.Location = new System.Drawing.Point(137, 47);
			this.lb_Cam_PosZ.Name = "lb_Cam_PosZ";
			this.lb_Cam_PosZ.Size = new System.Drawing.Size(14, 13);
			this.lb_Cam_PosZ.TabIndex = 6;
			this.lb_Cam_PosZ.Text = "Z";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(157, 44);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(42, 20);
			this.textBox1.TabIndex = 5;
			// 
			// lb_View
			// 
			this.lb_View.AutoSize = true;
			this.lb_View.Location = new System.Drawing.Point(5, 129);
			this.lb_View.Name = "lb_View";
			this.lb_View.Size = new System.Drawing.Size(30, 13);
			this.lb_View.TabIndex = 7;
			this.lb_View.Text = "View";
			// 
			// textBox_View
			// 
			this.textBox_View.Location = new System.Drawing.Point(41, 126);
			this.textBox_View.Name = "textBox_View";
			this.textBox_View.Size = new System.Drawing.Size(158, 20);
			this.textBox_View.TabIndex = 8;
			// 
			// lb_VpZ
			// 
			this.lb_VpZ.AutoSize = true;
			this.lb_VpZ.Location = new System.Drawing.Point(137, 97);
			this.lb_VpZ.Name = "lb_VpZ";
			this.lb_VpZ.Size = new System.Drawing.Size(14, 13);
			this.lb_VpZ.TabIndex = 15;
			this.lb_VpZ.Text = "Z";
			// 
			// textBox_VpZ
			// 
			this.textBox_VpZ.Location = new System.Drawing.Point(157, 94);
			this.textBox_VpZ.Name = "textBox_VpZ";
			this.textBox_VpZ.Size = new System.Drawing.Size(42, 20);
			this.textBox_VpZ.TabIndex = 14;
			// 
			// lb_VpY
			// 
			this.lb_VpY.AutoSize = true;
			this.lb_VpY.Location = new System.Drawing.Point(71, 97);
			this.lb_VpY.Name = "lb_VpY";
			this.lb_VpY.Size = new System.Drawing.Size(14, 13);
			this.lb_VpY.TabIndex = 13;
			this.lb_VpY.Text = "Y";
			// 
			// textBox_VpY
			// 
			this.textBox_VpY.Location = new System.Drawing.Point(91, 94);
			this.textBox_VpY.Name = "textBox_VpY";
			this.textBox_VpY.Size = new System.Drawing.Size(42, 20);
			this.textBox_VpY.TabIndex = 12;
			// 
			// lb_VpX
			// 
			this.lb_VpX.AutoSize = true;
			this.lb_VpX.Location = new System.Drawing.Point(5, 97);
			this.lb_VpX.Name = "lb_VpX";
			this.lb_VpX.Size = new System.Drawing.Size(14, 13);
			this.lb_VpX.TabIndex = 11;
			this.lb_VpX.Text = "X";
			// 
			// lb_Viewport
			// 
			this.lb_Viewport.AutoSize = true;
			this.lb_Viewport.Location = new System.Drawing.Point(6, 72);
			this.lb_Viewport.Name = "lb_Viewport";
			this.lb_Viewport.Size = new System.Drawing.Size(48, 13);
			this.lb_Viewport.TabIndex = 10;
			this.lb_Viewport.Text = "Viewport";
			// 
			// textBox_VpX
			// 
			this.textBox_VpX.Location = new System.Drawing.Point(25, 94);
			this.textBox_VpX.Name = "textBox_VpX";
			this.textBox_VpX.Size = new System.Drawing.Size(42, 20);
			this.textBox_VpX.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 161);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 27);
			this.button1.TabIndex = 23;
			this.button1.Text = "Enter";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form_3D_Scenes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1370, 711);
			this.Controls.Add(this.groupBox_Camera);
			this.Controls.Add(this.groupBox_Texture);
			this.Controls.Add(this.groupBox_Transform);
			this.Controls.Add(this.groupBox_SampleScenes);
			this.Controls.Add(this.groupBox_Color);
			this.Controls.Add(this.groupBox_Objects);
			this.Controls.Add(this.openGLControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form_3D_Scenes";
			this.Text = "3D Scenes";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_3D_Scenes_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox_Objects.ResumeLayout(false);
			this.groupBox_Color.ResumeLayout(false);
			this.groupBox_SampleScenes.ResumeLayout(false);
			this.groupBox_Transform.ResumeLayout(false);
			this.groupBox_Transform.PerformLayout();
			this.groupBox_Texture.ResumeLayout(false);
			this.groupBox_Camera.ResumeLayout(false);
			this.groupBox_Camera.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SharpGL.OpenGLControl openGLControl1;
		private System.Windows.Forms.ListBox lstBox_SampleScene;
		private System.Windows.Forms.Button bt_Pyramid;
		private System.Windows.Forms.Button bt_Cube;
		private System.Windows.Forms.Button bt_Prism;
		private System.Windows.Forms.ImageList imgList_icon_affine;
		private System.Windows.Forms.Button bt_Stop;
		private System.Windows.Forms.ImageList imgList_icon_object;
		private System.Windows.Forms.Button bt_Palette;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button bt_Color;
		private System.Windows.Forms.TextBox textBox_PosZ;
		private System.Windows.Forms.TextBox textBox_PosY;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox_ScaleZ;
		private System.Windows.Forms.TextBox textBox_ScaleY;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_RotateZ;
		private System.Windows.Forms.TextBox textBox_RotateY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.Button bt_Enter;
		private System.Windows.Forms.GroupBox groupBox_Objects;
		private System.Windows.Forms.GroupBox groupBox_Color;
		private System.Windows.Forms.GroupBox groupBox_SampleScenes;
        private System.Windows.Forms.Button TextureButton;
		private System.Windows.Forms.GroupBox groupBox_Transform;
		private System.Windows.Forms.Label label_Stop;
		private System.Windows.Forms.Label lb_Position;
		private System.Windows.Forms.Label lb_Rotation;
		private System.Windows.Forms.Label lb_Scale;
		private System.Windows.Forms.TextBox textBox_PosX;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_ScaleX;
		private System.Windows.Forms.TextBox textBox_RotateX;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox_Texture;
		private System.Windows.Forms.GroupBox groupBox_Camera;
		private System.Windows.Forms.Label lb_Cam_Pos;
		private System.Windows.Forms.TextBox textBox_Cam_PosX;
		private System.Windows.Forms.Label lb_Cam_PosZ;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lb_Cam_PosY;
		private System.Windows.Forms.TextBox textBox_Cam_PosY;
		private System.Windows.Forms.Label lb_Cam_PosX;
		private System.Windows.Forms.Label lb_VpZ;
		private System.Windows.Forms.TextBox textBox_VpZ;
		private System.Windows.Forms.Label lb_VpY;
		private System.Windows.Forms.TextBox textBox_VpY;
		private System.Windows.Forms.Label lb_VpX;
		private System.Windows.Forms.Label lb_Viewport;
		private System.Windows.Forms.TextBox textBox_VpX;
		private System.Windows.Forms.TextBox textBox_View;
		private System.Windows.Forms.Label lb_View;
		private System.Windows.Forms.Button button1;
	}
}

