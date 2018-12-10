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
			this.bt_Scale = new System.Windows.Forms.Button();
			this.imgList_icon_affine = new System.Windows.Forms.ImageList(this.components);
			this.bt_Rotate = new System.Windows.Forms.Button();
			this.bt_Move = new System.Windows.Forms.Button();
			this.bt_Select = new System.Windows.Forms.Button();
			this.bt_Prism = new System.Windows.Forms.Button();
			this.bt_Pyramid = new System.Windows.Forms.Button();
			this.bt_Cube = new System.Windows.Forms.Button();
			this.lstBox_SampleScene = new System.Windows.Forms.ListBox();
			this.lb_SampleScene = new System.Windows.Forms.Label();
			this.imgList_icon_object = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
			this.pnl_Tool_bar.SuspendLayout();
			this.SuspendLayout();
			// 
			// openGLControl1
			// 
			this.openGLControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.openGLControl1.DrawFPS = false;
			this.openGLControl1.Location = new System.Drawing.Point(0, 123);
			this.openGLControl1.Name = "openGLControl1";
			this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
			this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
			this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
			this.openGLControl1.Size = new System.Drawing.Size(815, 374);
			this.openGLControl1.TabIndex = 0;
			this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
			this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
			this.openGLControl1.Resized += new System.EventHandler(this.openGLControl1_Resized);
			// 
			// pnl_Tool_bar
			// 
			this.pnl_Tool_bar.Controls.Add(this.bt_Scale);
			this.pnl_Tool_bar.Controls.Add(this.bt_Rotate);
			this.pnl_Tool_bar.Controls.Add(this.bt_Move);
			this.pnl_Tool_bar.Controls.Add(this.bt_Select);
			this.pnl_Tool_bar.Controls.Add(this.bt_Prism);
			this.pnl_Tool_bar.Controls.Add(this.bt_Pyramid);
			this.pnl_Tool_bar.Controls.Add(this.bt_Cube);
			this.pnl_Tool_bar.Location = new System.Drawing.Point(0, 1);
			this.pnl_Tool_bar.Name = "pnl_Tool_bar";
			this.pnl_Tool_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.pnl_Tool_bar.Size = new System.Drawing.Size(815, 116);
			this.pnl_Tool_bar.TabIndex = 1;
			// 
			// bt_Scale
			// 
			this.bt_Scale.ImageIndex = 3;
			this.bt_Scale.ImageList = this.imgList_icon_affine;
			this.bt_Scale.Location = new System.Drawing.Point(481, 47);
			this.bt_Scale.Name = "bt_Scale";
			this.bt_Scale.Size = new System.Drawing.Size(40, 40);
			this.bt_Scale.TabIndex = 6;
			this.bt_Scale.UseVisualStyleBackColor = true;
			// 
			// imgList_icon_affine
			// 
			this.imgList_icon_affine.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_icon_affine.ImageStream")));
			this.imgList_icon_affine.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList_icon_affine.Images.SetKeyName(0, "select.png");
			this.imgList_icon_affine.Images.SetKeyName(1, "move-option.png");
			this.imgList_icon_affine.Images.SetKeyName(2, "rotate.png");
			this.imgList_icon_affine.Images.SetKeyName(3, "zoom-out.png");
			// 
			// bt_Rotate
			// 
			this.bt_Rotate.ImageIndex = 2;
			this.bt_Rotate.ImageList = this.imgList_icon_affine;
			this.bt_Rotate.Location = new System.Drawing.Point(435, 47);
			this.bt_Rotate.Name = "bt_Rotate";
			this.bt_Rotate.Size = new System.Drawing.Size(40, 40);
			this.bt_Rotate.TabIndex = 5;
			this.bt_Rotate.UseVisualStyleBackColor = true;
			// 
			// bt_Move
			// 
			this.bt_Move.ImageIndex = 1;
			this.bt_Move.ImageList = this.imgList_icon_affine;
			this.bt_Move.Location = new System.Drawing.Point(386, 47);
			this.bt_Move.Name = "bt_Move";
			this.bt_Move.Size = new System.Drawing.Size(40, 40);
			this.bt_Move.TabIndex = 4;
			this.bt_Move.UseVisualStyleBackColor = true;
			// 
			// bt_Select
			// 
			this.bt_Select.ImageIndex = 0;
			this.bt_Select.ImageList = this.imgList_icon_affine;
			this.bt_Select.Location = new System.Drawing.Point(340, 47);
			this.bt_Select.Name = "bt_Select";
			this.bt_Select.Size = new System.Drawing.Size(40, 40);
			this.bt_Select.TabIndex = 3;
			this.bt_Select.UseVisualStyleBackColor = true;
			// 
			// bt_Prism
			// 
			this.bt_Prism.ImageIndex = 2;
			this.bt_Prism.ImageList = this.imgList_icon_object;
			this.bt_Prism.Location = new System.Drawing.Point(216, 12);
			this.bt_Prism.Name = "bt_Prism";
			this.bt_Prism.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_Prism.Size = new System.Drawing.Size(75, 75);
			this.bt_Prism.TabIndex = 2;
			this.bt_Prism.UseVisualStyleBackColor = true;
			this.bt_Prism.Click += new System.EventHandler(this.bt_Prism_Click);
			// 
			// bt_Pyramid
			// 
			this.bt_Pyramid.ImageIndex = 0;
			this.bt_Pyramid.ImageList = this.imgList_icon_object;
			this.bt_Pyramid.Location = new System.Drawing.Point(122, 12);
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
			this.bt_Cube.Location = new System.Drawing.Point(27, 12);
			this.bt_Cube.Name = "bt_Cube";
			this.bt_Cube.Size = new System.Drawing.Size(75, 75);
			this.bt_Cube.TabIndex = 0;
			this.bt_Cube.UseVisualStyleBackColor = true;
			this.bt_Cube.Click += new System.EventHandler(this.bt_Cube_Click);
			// 
			// lstBox_SampleScene
			// 
			this.lstBox_SampleScene.FormattingEnabled = true;
			this.lstBox_SampleScene.Location = new System.Drawing.Point(821, 35);
			this.lstBox_SampleScene.Name = "lstBox_SampleScene";
			this.lstBox_SampleScene.Size = new System.Drawing.Size(166, 212);
			this.lstBox_SampleScene.TabIndex = 3;
			// 
			// lb_SampleScene
			// 
			this.lb_SampleScene.AutoSize = true;
			this.lb_SampleScene.Location = new System.Drawing.Point(822, 13);
			this.lb_SampleScene.Name = "lb_SampleScene";
			this.lb_SampleScene.Size = new System.Drawing.Size(74, 13);
			this.lb_SampleScene.TabIndex = 4;
			this.lb_SampleScene.Text = "Sample scene";
			// 
			// imgList_icon_object
			// 
			this.imgList_icon_object.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_icon_object.ImageStream")));
			this.imgList_icon_object.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList_icon_object.Images.SetKeyName(0, "clipart161515.png");
			this.imgList_icon_object.Images.SetKeyName(1, "clipart166330.png");
			this.imgList_icon_object.Images.SetKeyName(2, "clipart466993.png");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(991, 497);
			this.Controls.Add(this.lb_SampleScene);
			this.Controls.Add(this.lstBox_SampleScene);
			this.Controls.Add(this.pnl_Tool_bar);
			this.Controls.Add(this.openGLControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
			this.pnl_Tool_bar.ResumeLayout(false);
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
		private System.Windows.Forms.Button bt_Select;
		private System.Windows.Forms.ImageList imgList_icon_object;
	}
}

