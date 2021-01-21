using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Drawing.Imaging;

namespace English_Improve
{
	public partial class AddPicture : Form
	{
        string path;
        protected Image image;
        protected Thread getImageThread;
		public AddPicture()
		{
			InitializeComponent();
            pbPic.SizeMode = PictureBoxSizeMode.Zoom;
            pbPic.ContextMenuStrip = contextMenuStrip1;
        }
        protected bool validData;

        private void AddPicture_DragEnter(object sender, DragEventArgs e)

        {
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                path = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }
        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }
        private void AddPicture_DragDrop(object sender, DragEventArgs e)

        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                pbPic.Image = image;
            }
        }
        protected void LoadImage()
        {
            image = new Bitmap(path);
        }

        private void pastePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pbPic.Image = Clipboard.GetImage();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            pbPic.Image.Save(@"1.jpg", ImageFormat.Jpeg);
        }
    }
}
