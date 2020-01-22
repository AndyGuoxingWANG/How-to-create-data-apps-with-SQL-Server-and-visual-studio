namespace ImageUploadVersion2
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label imgPathLabel;
            System.Windows.Forms.Label imgLabel;
            this.myImages = new ImageUploadVersion2.myImages();
            this.udemyImageUploadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.udemyImageUploadsTableAdapter = new ImageUploadVersion2.myImagesTableAdapters.UdemyImageUploadsTableAdapter();
            this.tableAdapterManager = new ImageUploadVersion2.myImagesTableAdapters.TableAdapterManager();
            this.udemyImageUploadsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.udemyImageUploadsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imgPathLabel1 = new System.Windows.Forms.Label();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            imgPathLabel = new System.Windows.Forms.Label();
            imgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udemyImageUploadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udemyImageUploadsBindingNavigator)).BeginInit();
            this.udemyImageUploadsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myImages
            // 
            this.myImages.DataSetName = "myImages";
            this.myImages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // udemyImageUploadsBindingSource
            // 
            this.udemyImageUploadsBindingSource.DataMember = "UdemyImageUploads";
            this.udemyImageUploadsBindingSource.DataSource = this.myImages;
            // 
            // udemyImageUploadsTableAdapter
            // 
            this.udemyImageUploadsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UdemyImageUploadsTableAdapter = this.udemyImageUploadsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ImageUploadVersion2.myImagesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // udemyImageUploadsBindingNavigator
            // 
            this.udemyImageUploadsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.udemyImageUploadsBindingNavigator.BindingSource = this.udemyImageUploadsBindingSource;
            this.udemyImageUploadsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.udemyImageUploadsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.udemyImageUploadsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.udemyImageUploadsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.udemyImageUploadsBindingNavigatorSaveItem});
            this.udemyImageUploadsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.udemyImageUploadsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.udemyImageUploadsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.udemyImageUploadsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.udemyImageUploadsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.udemyImageUploadsBindingNavigator.Name = "udemyImageUploadsBindingNavigator";
            this.udemyImageUploadsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.udemyImageUploadsBindingNavigator.Size = new System.Drawing.Size(911, 31);
            this.udemyImageUploadsBindingNavigator.TabIndex = 0;
            this.udemyImageUploadsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // udemyImageUploadsBindingNavigatorSaveItem
            // 
            this.udemyImageUploadsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.udemyImageUploadsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("udemyImageUploadsBindingNavigatorSaveItem.Image")));
            this.udemyImageUploadsBindingNavigatorSaveItem.Name = "udemyImageUploadsBindingNavigatorSaveItem";
            this.udemyImageUploadsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.udemyImageUploadsBindingNavigatorSaveItem.Text = "Save Data";
            this.udemyImageUploadsBindingNavigatorSaveItem.Click += new System.EventHandler(this.udemyImageUploadsBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.Transparent;
            idLabel.Location = new System.Drawing.Point(268, 75);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(39, 29);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.udemyImageUploadsBindingSource, "id", true));
            this.idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel1.Location = new System.Drawing.Point(418, 77);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(356, 27);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            this.idLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(268, 126);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(84, 29);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.udemyImageUploadsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(418, 130);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(356, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // imgPathLabel
            // 
            imgPathLabel.AutoSize = true;
            imgPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imgPathLabel.ForeColor = System.Drawing.Color.White;
            imgPathLabel.Location = new System.Drawing.Point(268, 188);
            imgPathLabel.Name = "imgPathLabel";
            imgPathLabel.Size = new System.Drawing.Size(113, 29);
            imgPathLabel.TabIndex = 5;
            imgPathLabel.Text = "Img Path:";
            // 
            // imgPathLabel1
            // 
            this.imgPathLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.udemyImageUploadsBindingSource, "ImgPath", true));
            this.imgPathLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgPathLabel1.Location = new System.Drawing.Point(414, 192);
            this.imgPathLabel1.Name = "imgPathLabel1";
            this.imgPathLabel1.Size = new System.Drawing.Size(360, 27);
            this.imgPathLabel1.TabIndex = 6;
            this.imgPathLabel1.Text = "label1";
            this.imgPathLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imgPathLabel1.Click += new System.EventHandler(this.imgPathLabel1_Click);
            // 
            // imgLabel
            // 
            imgLabel.AutoSize = true;
            imgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imgLabel.ForeColor = System.Drawing.Color.White;
            imgLabel.Location = new System.Drawing.Point(268, 294);
            imgLabel.Name = "imgLabel";
            imgLabel.Size = new System.Drawing.Size(59, 29);
            imgLabel.TabIndex = 7;
            imgLabel.Text = "Img:";
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.udemyImageUploadsBindingSource, "Img", true));
            this.imgPictureBox.Location = new System.Drawing.Point(418, 233);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(356, 284);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPictureBox.TabIndex = 8;
            this.imgPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(336, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(911, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(imgPathLabel);
            this.Controls.Add(this.imgPathLabel1);
            this.Controls.Add(imgLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.udemyImageUploadsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udemyImageUploadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udemyImageUploadsBindingNavigator)).EndInit();
            this.udemyImageUploadsBindingNavigator.ResumeLayout(false);
            this.udemyImageUploadsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myImages myImages;
        private System.Windows.Forms.BindingSource udemyImageUploadsBindingSource;
        private myImagesTableAdapters.UdemyImageUploadsTableAdapter udemyImageUploadsTableAdapter;
        private myImagesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator udemyImageUploadsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton udemyImageUploadsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label imgPathLabel1;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.Button button1;
    }
}

