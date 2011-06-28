namespace YPlaylist
{
    partial class AddMusicControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMusicControl));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.artistTBox = new System.Windows.Forms.TextBox();
            this.albumTBox = new System.Windows.Forms.TextBox();
            this.tracklistTBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.addByArtistAndAlbum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lableBox = new System.Windows.Forms.ComboBox();
            this.lableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ginTunesDataSet = new YPlaylist.GinTunesDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.formatBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genLabAddButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lableTableAdapter = new YPlaylist.GinTunesDataSetTableAdapters.LableTableAdapter();
            this.fKLableIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumTableAdapter = new YPlaylist.GinTunesDataSetTableAdapters.AlbumTableAdapter();
            this.fKLableIDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AddByArtist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ginTunesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLableIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLableIDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 60);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 298);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(618, 101);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(104, 53);
            this.HomeButton.TabIndex = 6;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // artistTBox
            // 
            this.artistTBox.Location = new System.Drawing.Point(17, 118);
            this.artistTBox.Name = "artistTBox";
            this.artistTBox.Size = new System.Drawing.Size(196, 20);
            this.artistTBox.TabIndex = 7;
            // 
            // albumTBox
            // 
            this.albumTBox.Location = new System.Drawing.Point(17, 174);
            this.albumTBox.Name = "albumTBox";
            this.albumTBox.Size = new System.Drawing.Size(196, 20);
            this.albumTBox.TabIndex = 8;
            // 
            // tracklistTBox
            // 
            this.tracklistTBox.Location = new System.Drawing.Point(16, 364);
            this.tracklistTBox.Multiline = true;
            this.tracklistTBox.Name = "tracklistTBox";
            this.tracklistTBox.Size = new System.Drawing.Size(436, 101);
            this.tracklistTBox.TabIndex = 9;
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(16, 236);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(197, 21);
            this.genreBox.TabIndex = 10;
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(16, 305);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(197, 21);
            this.yearBox.TabIndex = 11;
            // 
            // addByArtistAndAlbum
            // 
            this.addByArtistAndAlbum.Location = new System.Drawing.Point(381, 471);
            this.addByArtistAndAlbum.Name = "addByArtistAndAlbum";
            this.addByArtistAndAlbum.Size = new System.Drawing.Size(71, 29);
            this.addByArtistAndAlbum.TabIndex = 12;
            this.addByArtistAndAlbum.Text = "Add Album";
            this.addByArtistAndAlbum.UseVisualStyleBackColor = true;
            this.addByArtistAndAlbum.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Artist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Year";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Genre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tracklist";
            // 
            // lableBox
            // 
            this.lableBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lableBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.lableBindingSource, "LableName", true));
            this.lableBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lableBindingSource, "LableName", true));
            this.lableBox.DisplayMember = "LableName";
            this.lableBox.FormattingEnabled = true;
            this.lableBox.Location = new System.Drawing.Point(239, 236);
            this.lableBox.Name = "lableBox";
            this.lableBox.Size = new System.Drawing.Size(194, 21);
            this.lableBox.TabIndex = 25;
            this.lableBox.ValueMember = "LableName";
            this.lableBox.SelectedIndexChanged += new System.EventHandler(this.lableBox_SelectedIndexChanged);
            // 
            // lableBindingSource
            // 
            this.lableBindingSource.DataMember = "Lable";
            this.lableBindingSource.DataSource = this.ginTunesDataSet;
            this.lableBindingSource.CurrentChanged += new System.EventHandler(this.lableBindingSource_CurrentChanged);
            // 
            // ginTunesDataSet
            // 
            this.ginTunesDataSet.DataSetName = "GinTunesDataSet";
            this.ginTunesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(235, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Record Lable";
            // 
            // formatBox
            // 
            this.formatBox.FormattingEnabled = true;
            this.formatBox.Location = new System.Drawing.Point(239, 305);
            this.formatBox.Name = "formatBox";
            this.formatBox.Size = new System.Drawing.Size(194, 21);
            this.formatBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(235, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Format";
            // 
            // genLabAddButton
            // 
            this.genLabAddButton.Location = new System.Drawing.Point(293, 127);
            this.genLabAddButton.Name = "genLabAddButton";
            this.genLabAddButton.Size = new System.Drawing.Size(121, 44);
            this.genLabAddButton.TabIndex = 29;
            this.genLabAddButton.Text = "Add!";
            this.genLabAddButton.UseVisualStyleBackColor = true;
            this.genLabAddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(235, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Add New Labels, Genres etc";
            // 
            // lableTableAdapter
            // 
            this.lableTableAdapter.ClearBeforeFill = true;
            // 
            // fKLableIDBindingSource
            // 
            this.fKLableIDBindingSource.DataMember = "FK_LableID";
            this.fKLableIDBindingSource.DataSource = this.lableBindingSource;
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // fKLableIDBindingSource1
            // 
            this.fKLableIDBindingSource1.DataMember = "FK_LableID";
            this.fKLableIDBindingSource1.DataSource = this.lableBindingSource;
            // 
            // AddByArtist
            // 
            this.AddByArtist.Location = new System.Drawing.Point(276, 471);
            this.AddByArtist.Name = "AddByArtist";
            this.AddByArtist.Size = new System.Drawing.Size(71, 29);
            this.AddByArtist.TabIndex = 31;
            this.AddByArtist.Text = "Add Artist";
            this.AddByArtist.UseVisualStyleBackColor = true;
            this.AddByArtist.Click += new System.EventHandler(this.AddByArtist_Click);
            // 
            // AddMusicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddByArtist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.genLabAddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.formatBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lableBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addByArtistAndAlbum);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.tracklistTBox);
            this.Controls.Add(this.albumTBox);
            this.Controls.Add(this.artistTBox);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AddMusicControl";
            this.Size = new System.Drawing.Size(822, 515);
            this.Load += new System.EventHandler(this.AddMusicControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ginTunesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLableIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLableIDBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.TextBox artistTBox;
        private System.Windows.Forms.TextBox albumTBox;
        private System.Windows.Forms.TextBox tracklistTBox;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Button addByArtistAndAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lableBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox formatBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button genLabAddButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource lableBindingSource;
        private GinTunesDataSet ginTunesDataSet;
        private GinTunesDataSetTableAdapters.LableTableAdapter lableTableAdapter;
        private System.Windows.Forms.BindingSource fKLableIDBindingSource;
        private GinTunesDataSetTableAdapters.AlbumTableAdapter albumTableAdapter;
        private System.Windows.Forms.BindingSource fKLableIDBindingSource1;
        private System.Windows.Forms.Button AddByArtist;
    }
}
