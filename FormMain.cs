using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PicSplit
{
    public partial class FormMain : Form
    {
        System.Drawing.Image _initImage = null;
        ZoomRate _zoomRate = new ZoomRate();
        Point _picStartPoint = new Point();

        SpliteRectGroup _splitRectGroup = new SpliteRectGroup();
        Point mouseLocation;
        public FormMain()
        {
            InitializeComponent();

            comboBoxFileType.Items.Add("png");
            comboBoxFileType.Items.Add("jpg");
            comboBoxFileType.Items.Add("bmp");
            comboBoxFileType.Items.Add("gif");
            comboBoxFileType.SelectedIndex = 0;

            _picStartPoint.X = int.Parse(textBoxStartX.Text);
            _picStartPoint.Y = int.Parse(textBoxStartY.Text);

            this.pictureBoxSrc.MouseWheel += new MouseEventHandler(PictureBox1_MouseWheel);
        }

        private void PictureBox1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
        }

        private void buttonOpenPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog1 = new OpenFileDialog();
            fileDialog1.InitialDirectory = "d://";
            fileDialog1.Filter = "xls files (*.jpg;*.png)|*.jpg;*.png|All files (*.*)|*.*";
            fileDialog1.FilterIndex = 1;
            fileDialog1.RestoreDirectory = true;
            if (fileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSrcPic.Text = fileDialog1.FileName;

                _initImage = PicManage.GetFromFile(textBoxSrcPic.Text);
                _zoomRate.Reset();
                _zoomRate.SetRate(10);
                _zoomRate.SetSize(_initImage.Width, _initImage.Height);

                ShowPicOnCtrl(_initImage);
                SetSpliteRect(false);
                pictureBoxSrc.Invalidate();

                textBoxOutFileName.Text = Path.GetFileNameWithoutExtension(textBoxSrcPic.Text);
            }
            else
            {
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetSpliteRect(false);
            pictureBoxSrc.Invalidate();
        }

        bool ShowPicOnCtrl(Image img)
        {
            if (pictureBoxSrc.Image != null
                && pictureBoxSrc.Image != _initImage)
            {
                pictureBoxSrc.Image.Dispose();
            }

            pictureBoxSrc.Image = img;
            return true;
        }

        private void buttonSplite_Click(object sender, EventArgs e)
        {
            DateTime t1 = DateTime.Now;
            DoSplite();
            TimeSpan span = DateTime.Now-t1;
            MessageBox.Show(string.Format("切割完毕！耗时:{0}秒{1}毫秒", (int)(span.TotalMilliseconds/1000), ((int)span.TotalMilliseconds)%1000));
            
        }

        void DoSplite()
        {
            if (_initImage == null)
                return;

            try
            {
                Directory.CreateDirectory(textBoxSaveDir.Text);
                string fileName = GetSaveFileName();
                string fileType = comboBoxFileType.Text;

                int i = 0;
                //切割文件
                using (FileStream sFileStream = new FileStream(textBoxSrcPic.Text, FileMode.Open))
                {
                    Image initImage = Image.FromStream(sFileStream, true);

                    int quality = 100; //图片质量
                    Image destImage = null;
                    int outWidth = int.Parse(textBoxOutPicWidth.Text);

                    foreach (Rectangle rect in _splitRectGroup.GetRectsSplit())
                    {
                        i++;
                        
                        //string filePath = Path.Combine(textBoxSaveDir.Text, string.Format("{0}_{1}.{2}", textBoxOutFileName.Text, i, fileType));
                        string filePath = Path.Combine(textBoxSaveDir.Text, string.Format("{0}.{1}", DateTime.Now.ToString("yyyyMMddHHmmss", DateTimeFormatInfo.InvariantInfo), fileType));
                        File.Delete(filePath);

                        bool ret = PicManage.SplitPic(initImage, rect.X, rect.Y, rect.Width, rect.Height,
                            ref destImage, outWidth);

                        if (ret)
                        {
                            //获取系统编码类型数组,包含了jpeg,bmp,png,gif,tiff
                            ImageCodecInfo ici = PicManage.GetCodeInfo(filePath);
                            EncoderParameters ep = new EncoderParameters(1);
                            ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)quality);
                            destImage.Save(filePath, ici, ep);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool SetSpliteRect(bool showMsg)
        {
            try
            {
                int width = int.Parse(textBoxSplitWidth.Text);
                int height = int.Parse(textBoxSplitHeight.Text);

                if (width == 0)
                    width = _initImage.Width;

                int startX = int.Parse(textBoxStartX.Text);
                int startY = int.Parse(textBoxStartY.Text);
                if (showMsg && (startX >= _initImage.Width || startY >= _initImage.Height))
                {
                    MessageBox.Show("切割起始点不能大于图片尺寸！");
                    return false;
                }

                _splitRectGroup.ClearNotUsedRect();
                _splitRectGroup.SetRect(_initImage.Width, _initImage.Height,
                    startX, startY, width, height);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public string GetSaveFileName()
        {
            string ret = Path.GetFileNameWithoutExtension(textBoxSrcPic.Text);
            return ret;
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            if (_initImage == null)
                return;

            int widthNew = 0;
            int heightNew = 0;
            _zoomRate.GetNextZoomOut(ref widthNew, ref heightNew);

            Image newImage = null; ;
            PicManage.ZoomAuto(_initImage, ref newImage, widthNew, heightNew);
            if (newImage != null)
            {
                ShowPicOnCtrl(newImage);
            }
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            if (_initImage == null)
                return;

            int widthNew = 0;
            int heightNew = 0;
            _zoomRate.GetNextZoomIn(ref widthNew, ref heightNew);

            Image newImage = null; ;
            PicManage.ZoomAuto(_initImage, ref newImage, widthNew, heightNew);
            if (newImage != null)
            {
                ShowPicOnCtrl(newImage);
            }
        }

        private void buttonActualSize_Click(object sender, EventArgs e)
        {
            _zoomRate.Reset();
            ShowPicOnCtrl(_initImage);
        }

        bool _showSpliteInfo = false;
        void ShowSpliteInfo()
        {
            _showSpliteInfo = true;
            int newX = _splitRectGroup.GetStartX();
            int newY = _splitRectGroup.GetStartY();
            SetShowStartPoint(newX, newY);

            int width = _splitRectGroup.GetSpliteWidth();
            textBoxSplitWidth.Text = width.ToString();
            _showSpliteInfo = false;
        }

        private void pictureBoxSrc_MouseMove(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;
            textBoxStartX.Text = mouseLocation.X.ToString();
            textBoxStartY.Text = mouseLocation.Y.ToString();
            if (_splitRectGroup.IsAllMove(e.X, e.Y))
            {
                pictureBoxSrc.Cursor = Cursors.Hand;
                if (_pictureBoxSrcMouseDown)
                {
                    _splitRectGroup.SetMoveAllFlag(true);
                    _splitRectGroup.StartPointMoveTo(e.X, e.Y);
                    ShowSpliteInfo();
                    pictureBoxSrc.Invalidate();
                }
                return;
            }
            //只要上一次是移动的标识  就移动
            if (_pictureBoxSrcMouseDown && _splitRectGroup.GetMoveAllFlag())
            {
                _splitRectGroup.SetMoveAllFlag(true);
                _splitRectGroup.StartPointMoveTo(e.X, e.Y);
                ShowSpliteInfo();
                pictureBoxSrc.Invalidate();
                return;
            }

            _splitRectGroup.SetMoveAllFlag(false);

            //水平或垂直分割 
            SpliteMoveIndex index = _splitRectGroup.PointHit(e.X, e.Y, _splitRectGroup._defaultHitSpace);
            textBoxTest.Text = string.Format("dir:{0};index:{1};line:{2};x:y({3}:{4})",
                index.direct, index.rectIndex, index.lineIndex, index.mouseX, index.mouseY);

            if (_pictureBoxSrcMouseDown)
            {
                if (!index.IsIn())
                {
                    index = _splitRectGroup.PointHit(e.X, e.Y, _splitRectGroup._defaultHitSpace * 2 + 30);
                }

                if (index.IsIn())
                {
                    bool move = _splitRectGroup.SetMove(index);
                    if (move)
                    {
                        ShowSpliteInfo();
                        pictureBoxSrc.Invalidate();
                    }
                }
            }

            if (index.IsHorIn())
            {
                pictureBoxSrc.Cursor = Cursors.HSplit;
            }
            else if (index.IsVertIn())
            {
                pictureBoxSrc.Cursor = Cursors.VSplit;
            }
            else
            {
                pictureBoxSrc.Cursor = Cursors.Arrow;
            }
        }

        bool _pictureBoxSrcMouseDown = false;
        SpliteMoveIndex _lastDeleteIndex = null;
        Point _lastRightButton = new Point(0, 0);

        private void ToolStripMenuItemDeleteLine_Click(object sender, EventArgs e)
        {
            _splitRectGroup.DeleteHorSplite(_lastDeleteIndex);
            pictureBoxSrc.Invalidate();
        }

        private void ToolStripMenuItemAddHor_Click(object sender, EventArgs e)
        {
            _splitRectGroup.AddHorLine(_lastRightButton.X, _lastRightButton.Y);
            pictureBoxSrc.Invalidate();
        }

        private void pictureBoxSrc_MouseDown(object sender, MouseEventArgs e)
        {
            //_splitRectGroup.ResetMoveFlag();
            //_pictureBoxSrcMouseDown = true;
            //this.pictureBoxSrc.Focus();
        }

        string _strRectNotUsed = "不参与切割";
        string _strRectUsed = "参与切割";
        private void pictureBoxSrc_MouseUp(object sender, MouseEventArgs e)
        {
            _pictureBoxSrcMouseDown = false;

            if (e.Button == MouseButtons.Right)
            {
                _lastDeleteIndex = _splitRectGroup.PointHit(e.X, e.Y, _splitRectGroup._defaultHitSpace);
                if (_lastDeleteIndex.IsHorIn())
                {
                    contextMenuStripSplit.Show(pictureBoxSrc.PointToScreen(new Point(e.X, e.Y)));
                    contextMenuStripSplit.Items[0].Enabled = true;
                    contextMenuStripSplit.Items[1].Enabled = false;
                    contextMenuStripSplit.Items[2].Enabled = false;
                }
                else if (_splitRectGroup.PointInRect(e.X, e.Y))
                {
                    contextMenuStripSplit.Items[2].Enabled = true;
                    _lastRightButton = new Point(e.X, e.Y);
                    contextMenuStripSplit.Show(pictureBoxSrc.PointToScreen(new Point(e.X, e.Y)));
                    contextMenuStripSplit.Items[0].Enabled = false;
                    contextMenuStripSplit.Items[1].Enabled = true;
                    //此块区域是否不要
                    bool notUsed = _splitRectGroup.IsNotUsed(e.X, e.Y);
                    if (notUsed)
                        contextMenuStripSplit.Items[2].Text = _strRectUsed;
                    else
                        contextMenuStripSplit.Items[2].Text = _strRectNotUsed;
                }
            }
        }

        private void ToolStripMenuItemSplitOption_Click(object sender, EventArgs e)
        {
            if(contextMenuStripSplit.Items[2].Text == _strRectUsed)
            {
                _splitRectGroup.AddRectUsed(_lastRightButton.X, _lastRightButton.Y);
            }
            else
            {
                _splitRectGroup.DelRectUsed(_lastRightButton.X, _lastRightButton.Y);
            }
            pictureBoxSrc.Invalidate();
        }

        private void pictureBoxSrc_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _splitRectGroup.Draw(g);
        }

        public bool SetShowStartPoint(int x, int y)
        {
            int oldx = int.Parse(textBoxStartX.Text);
            int oldy = int.Parse(textBoxStartY.Text);
            if (oldx == x && oldy == y)
                return false;

            textBoxStartX.Text = x.ToString();
            textBoxStartY.Text = y.ToString();
            return true;
        }

        private void textBoxStartX_TextChanged(object sender, EventArgs e)
        {
            //显示信息 不触发动作
            if (_showSpliteInfo)
                return;

            try
            {
                _picStartPoint.X = int.Parse(textBoxStartX.Text);
            }
            catch
            {
                _picStartPoint.X = 0;
            }

            try
            {
                _picStartPoint.Y = int.Parse(textBoxStartY.Text);
            }
            catch
            {
                _picStartPoint.Y = 0;
            }

            _splitRectGroup.StartPointMoveTo(_picStartPoint.X, _picStartPoint.Y);
            pictureBoxSrc.Invalidate();
        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            List<Rectangle> listRect = new List<Rectangle>();

            Rectangle r1 = new Rectangle(1, 2, 3, 4);
            listRect.Add(r1);
            r1.X = 1234;
        }

        private void textBoxSplitWidth_TextChanged(object sender, EventArgs e)
        {
            //显示信息 不触发动作
            if (_showSpliteInfo)
                return;

            SetSpliteRect(true);
            pictureBoxSrc.Invalidate();
        }

        private void textBoxSplitWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int kc = (int)e.KeyChar;
                if ((kc < 48 || kc > 57) && kc != 8)
                    e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        private void buttonSelSaveDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
                textBoxSaveDir.Text = folderDlg.SelectedPath;
        }

        private void splitContainerMain_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point panelPoint = pictureBoxSrc.PointToClient(Control.MousePosition);
                textBoxStartX.Text = panelPoint.X.ToString();
                textBoxStartY.Text = panelPoint.Y.ToString();
            }
        }



        private void pictureBoxSrc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DateTime t1 = DateTime.Now;
            DoSplite();
            TimeSpan span = DateTime.Now - t1;
            MessageBox.Show(string.Format("切割完毕！耗时:{0}秒{1}毫秒", (int)(span.TotalMilliseconds / 1000), ((int)span.TotalMilliseconds) % 1000));
        }

        private void buttonZoomOut_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

     
    }
}
