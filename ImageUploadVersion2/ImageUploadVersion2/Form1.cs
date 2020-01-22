using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUploadVersion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void udemyImageUploadsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.udemyImageUploadsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myImages);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myImages.UdemyImageUploads' table. You can move, or remove it, as needed.
            this.udemyImageUploadsTableAdapter.Fill(this.myImages.UdemyImageUploads);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFd = new OpenFileDialog();
            openFd.Filter = "Images Only. | *.jpg; *.jpeg; *.png; *.gif;";
            DialogResult dr = openFd.ShowDialog();
            imgPictureBox.Image = Image.FromFile(openFd.FileName);
            imgPathLabel1.Text = openFd.FileName;
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void imgPathLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
