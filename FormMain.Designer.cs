namespace PicSplit
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.buttonText = new System.Windows.Forms.Button();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.buttonActualSize = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSrcPic = new System.Windows.Forms.TextBox();
            this.buttonOpenPic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSelSaveDir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOutPicWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOutFileName = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSplitWidth = new System.Windows.Forms.TextBox();
            this.textBoxSaveDir = new System.Windows.Forms.TextBox();
            this.textBoxStartY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStartX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSplitHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSplite = new System.Windows.Forms.Button();
            this.pictureBoxSrc = new System.Windows.Forms.PictureBox();
            this.contextMenuStripSplit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDeleteLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddHor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSplitOption = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSrc)).BeginInit();
            this.contextMenuStripSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.Panel1.Controls.Add(this.buttonText);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxTest);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonActualSize);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonZoomIn);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonZoomOut);
            this.splitContainerMain.Panel1.Controls.Add(this.label1);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSrcPic);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonOpenPic);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonSplite);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.AutoScroll = true;
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainerMain.Panel2.Controls.Add(this.pictureBoxSrc);
            this.splitContainerMain.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainerMain_Panel2_MouseDown);
            this.splitContainerMain.Size = new System.Drawing.Size(1196, 675);
            this.splitContainerMain.SplitterDistance = 472;
            this.splitContainerMain.SplitterWidth = 8;
            this.splitContainerMain.TabIndex = 0;
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(32, 580);
            this.buttonText.Margin = new System.Windows.Forms.Padding(4);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(137, 32);
            this.buttonText.TabIndex = 15;
            this.buttonText.Text = "测试";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Visible = false;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(29, 534);
            this.textBoxTest.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(243, 25);
            this.textBoxTest.TabIndex = 14;
            this.textBoxTest.Visible = false;
            // 
            // buttonActualSize
            // 
            this.buttonActualSize.Location = new System.Drawing.Point(272, 71);
            this.buttonActualSize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActualSize.Name = "buttonActualSize";
            this.buttonActualSize.Size = new System.Drawing.Size(100, 39);
            this.buttonActualSize.TabIndex = 6;
            this.buttonActualSize.Text = "1：1";
            this.buttonActualSize.UseVisualStyleBackColor = true;
            this.buttonActualSize.Click += new System.EventHandler(this.buttonActualSize_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Location = new System.Drawing.Point(145, 71);
            this.buttonZoomIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(100, 39);
            this.buttonZoomIn.TabIndex = 5;
            this.buttonZoomIn.Text = "缩小";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Location = new System.Drawing.Point(19, 71);
            this.buttonZoomOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(100, 39);
            this.buttonZoomOut.TabIndex = 4;
            this.buttonZoomOut.Text = "放大";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            this.buttonZoomOut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonZoomOut_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "图片文件:";
            // 
            // textBoxSrcPic
            // 
            this.textBoxSrcPic.Location = new System.Drawing.Point(91, 26);
            this.textBoxSrcPic.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSrcPic.Name = "textBoxSrcPic";
            this.textBoxSrcPic.Size = new System.Drawing.Size(231, 25);
            this.textBoxSrcPic.TabIndex = 1;
            // 
            // buttonOpenPic
            // 
            this.buttonOpenPic.Location = new System.Drawing.Point(333, 20);
            this.buttonOpenPic.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenPic.Name = "buttonOpenPic";
            this.buttonOpenPic.Size = new System.Drawing.Size(117, 38);
            this.buttonOpenPic.TabIndex = 0;
            this.buttonOpenPic.Text = "打开文件...";
            this.buttonOpenPic.UseVisualStyleBackColor = true;
            this.buttonOpenPic.Click += new System.EventHandler(this.buttonOpenPic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSelSaveDir);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxOutPicWidth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxOutFileName);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.comboBoxFileType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSplitWidth);
            this.groupBox1.Controls.Add(this.textBoxSaveDir);
            this.groupBox1.Controls.Add(this.textBoxStartY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxStartX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxSplitHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(428, 236);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "切割设置";
            // 
            // buttonSelSaveDir
            // 
            this.buttonSelSaveDir.Location = new System.Drawing.Point(317, 115);
            this.buttonSelSaveDir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelSaveDir.Name = "buttonSelSaveDir";
            this.buttonSelSaveDir.Size = new System.Drawing.Size(92, 29);
            this.buttonSelSaveDir.TabIndex = 23;
            this.buttonSelSaveDir.Text = "选择";
            this.buttonSelSaveDir.UseVisualStyleBackColor = true;
            this.buttonSelSaveDir.Click += new System.EventHandler(this.buttonSelSaveDir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "输出图片宽度";
            // 
            // textBoxOutPicWidth
            // 
            this.textBoxOutPicWidth.Location = new System.Drawing.Point(119, 186);
            this.textBoxOutPicWidth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOutPicWidth.Name = "textBoxOutPicWidth";
            this.textBoxOutPicWidth.Size = new System.Drawing.Size(99, 25);
            this.textBoxOutPicWidth.TabIndex = 22;
            this.textBoxOutPicWidth.Text = "0";
            this.textBoxOutPicWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "输出文件名前缀";
            // 
            // textBoxOutFileName
            // 
            this.textBoxOutFileName.Location = new System.Drawing.Point(237, 186);
            this.textBoxOutFileName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOutFileName.Name = "textBoxOutFileName";
            this.textBoxOutFileName.Size = new System.Drawing.Size(171, 25);
            this.textBoxOutFileName.TabIndex = 20;
            this.textBoxOutFileName.Text = "tb";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(317, 55);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(92, 29);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "重置";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxFileType
            // 
            this.comboBoxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Location = new System.Drawing.Point(11, 186);
            this.comboBoxFileType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.Size = new System.Drawing.Size(88, 23);
            this.comboBoxFileType.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "文件格式:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "宽度";
            // 
            // textBoxSplitWidth
            // 
            this.textBoxSplitWidth.Location = new System.Drawing.Point(11, 55);
            this.textBoxSplitWidth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSplitWidth.Name = "textBoxSplitWidth";
            this.textBoxSplitWidth.Size = new System.Drawing.Size(65, 25);
            this.textBoxSplitWidth.TabIndex = 8;
            this.textBoxSplitWidth.Text = "50";
            this.textBoxSplitWidth.TextChanged += new System.EventHandler(this.textBoxSplitWidth_TextChanged);
            this.textBoxSplitWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // textBoxSaveDir
            // 
            this.textBoxSaveDir.Location = new System.Drawing.Point(11, 118);
            this.textBoxSaveDir.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSaveDir.Name = "textBoxSaveDir";
            this.textBoxSaveDir.Size = new System.Drawing.Size(292, 25);
            this.textBoxSaveDir.TabIndex = 12;
            this.textBoxSaveDir.Text = "e:\\taobao_pic";
            // 
            // textBoxStartY
            // 
            this.textBoxStartY.Location = new System.Drawing.Point(237, 55);
            this.textBoxStartY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartY.Name = "textBoxStartY";
            this.textBoxStartY.Size = new System.Drawing.Size(65, 25);
            this.textBoxStartY.TabIndex = 13;
            this.textBoxStartY.Text = "300";
            this.textBoxStartY.TextChanged += new System.EventHandler(this.textBoxStartX_TextChanged);
            this.textBoxStartY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "存放路径";
            // 
            // textBoxStartX
            // 
            this.textBoxStartX.Location = new System.Drawing.Point(164, 55);
            this.textBoxStartX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartX.Name = "textBoxStartX";
            this.textBoxStartX.Size = new System.Drawing.Size(65, 25);
            this.textBoxStartX.TabIndex = 12;
            this.textBoxStartX.Text = "300";
            this.textBoxStartX.TextChanged += new System.EventHandler(this.textBoxStartX_TextChanged);
            this.textBoxStartX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "切割起点(x:y)";
            // 
            // textBoxSplitHeight
            // 
            this.textBoxSplitHeight.Location = new System.Drawing.Point(84, 55);
            this.textBoxSplitHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSplitHeight.Name = "textBoxSplitHeight";
            this.textBoxSplitHeight.Size = new System.Drawing.Size(65, 25);
            this.textBoxSplitHeight.TabIndex = 10;
            this.textBoxSplitHeight.Text = "50";
            this.textBoxSplitHeight.TextChanged += new System.EventHandler(this.textBoxSplitWidth_TextChanged);
            this.textBoxSplitHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "高度";
            // 
            // buttonSplite
            // 
            this.buttonSplite.Location = new System.Drawing.Point(212, 388);
            this.buttonSplite.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSplite.Name = "buttonSplite";
            this.buttonSplite.Size = new System.Drawing.Size(216, 46);
            this.buttonSplite.TabIndex = 3;
            this.buttonSplite.Text = "切割";
            this.buttonSplite.UseVisualStyleBackColor = true;
            this.buttonSplite.Click += new System.EventHandler(this.buttonSplite_Click);
            // 
            // pictureBoxSrc
            // 
            this.pictureBoxSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxSrc.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxSrc.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSrc.Name = "pictureBoxSrc";
            this.pictureBoxSrc.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSrc.TabIndex = 0;
            this.pictureBoxSrc.TabStop = false;
            this.pictureBoxSrc.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSrc_Paint);
            this.pictureBoxSrc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseDoubleClick);
            this.pictureBoxSrc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseDown);
            this.pictureBoxSrc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseMove);
            this.pictureBoxSrc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseUp);
            // 
            // contextMenuStripSplit
            // 
            this.contextMenuStripSplit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSplit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDeleteLine,
            this.ToolStripMenuItemAddHor,
            this.ToolStripMenuItemSplitOption});
            this.contextMenuStripSplit.Name = "contextMenuStripSplit";
            this.contextMenuStripSplit.Size = new System.Drawing.Size(169, 76);
            // 
            // ToolStripMenuItemDeleteLine
            // 
            this.ToolStripMenuItemDeleteLine.Name = "ToolStripMenuItemDeleteLine";
            this.ToolStripMenuItemDeleteLine.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItemDeleteLine.Text = "删除此水平线";
            this.ToolStripMenuItemDeleteLine.Click += new System.EventHandler(this.ToolStripMenuItemDeleteLine_Click);
            // 
            // ToolStripMenuItemAddHor
            // 
            this.ToolStripMenuItemAddHor.Name = "ToolStripMenuItemAddHor";
            this.ToolStripMenuItemAddHor.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItemAddHor.Text = "增加水平线";
            this.ToolStripMenuItemAddHor.Click += new System.EventHandler(this.ToolStripMenuItemAddHor_Click);
            // 
            // ToolStripMenuItemSplitOption
            // 
            this.ToolStripMenuItemSplitOption.Name = "ToolStripMenuItemSplitOption";
            this.ToolStripMenuItemSplitOption.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItemSplitOption.Text = "不参与切割";
            this.ToolStripMenuItemSplitOption.Click += new System.EventHandler(this.ToolStripMenuItemSplitOption_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 675);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "图片快速分割工具——手动分割";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSrc)).EndInit();
            this.contextMenuStripSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSrcPic;
        private System.Windows.Forms.Button buttonOpenPic;
        private System.Windows.Forms.PictureBox pictureBoxSrc;
        private System.Windows.Forms.Button buttonSplite;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonActualSize;
        private System.Windows.Forms.TextBox textBoxSaveDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSplitHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSplitWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFileType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStartY;
        private System.Windows.Forms.TextBox textBoxStartX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSplit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteLine;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddHor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOutPicWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOutFileName;
        private System.Windows.Forms.Button buttonSelSaveDir;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSplitOption;
    }
}

