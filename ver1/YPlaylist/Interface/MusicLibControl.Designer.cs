namespace YPlaylist
{
    partial class MusicLibControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicLibControl));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.plContentGrid = new System.Windows.Forms.DataGridView();
            this.albumBox = new System.Windows.Forms.ComboBox();
            this.artistBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remTracks = new System.Windows.Forms.Button();
            this.remAlbButton = new System.Windows.Forms.Button();
            this.remArtButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plContentGrid)).BeginInit();
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
            this.HomeButton.TabIndex = 7;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(399, 217);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(79, 35);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // plContentGrid
            // 
            this.plContentGrid.BackgroundColor = System.Drawing.Color.White;
            this.plContentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plContentGrid.GridColor = System.Drawing.Color.White;
            this.plContentGrid.Location = new System.Drawing.Point(18, 258);
            this.plContentGrid.Name = "plContentGrid";
            this.plContentGrid.Size = new System.Drawing.Size(497, 208);
            this.plContentGrid.TabIndex = 19;
            // 
            // albumBox
            // 
            this.albumBox.FormattingEnabled = true;
            this.albumBox.Location = new System.Drawing.Point(201, 225);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(165, 21);
            this.albumBox.TabIndex = 18;
            // 
            // artistBox
            // 
            this.artistBox.FormattingEnabled = true;
            this.artistBox.Location = new System.Drawing.Point(18, 225);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(153, 21);
            this.artistBox.TabIndex = 17;
            this.artistBox.SelectedIndexChanged += new System.EventHandler(this.artistBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(197, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Artist";
            // 
            // remTracks
            // 
            this.remTracks.Location = new System.Drawing.Point(399, 472);
            this.remTracks.Name = "remTracks";
            this.remTracks.Size = new System.Drawing.Size(79, 35);
            this.remTracks.TabIndex = 23;
            this.remTracks.Text = "Tracks";
            this.remTracks.UseVisualStyleBackColor = true;
            this.remTracks.Click += new System.EventHandler(this.remTracks_Click);
            // 
            // remAlbButton
            // 
            this.remAlbButton.Location = new System.Drawing.Point(299, 472);
            this.remAlbButton.Name = "remAlbButton";
            this.remAlbButton.Size = new System.Drawing.Size(79, 35);
            this.remAlbButton.TabIndex = 25;
            this.remAlbButton.Text = "Album";
            this.remAlbButton.UseVisualStyleBackColor = true;
            this.remAlbButton.Click += new System.EventHandler(this.remAlbButton_Click);
            // 
            // remArtButton
            // 
            this.remArtButton.Location = new System.Drawing.Point(201, 472);
            this.remArtButton.Name = "remArtButton";
            this.remArtButton.Size = new System.Drawing.Size(79, 35);
            this.remArtButton.TabIndex = 26;
            this.remArtButton.Text = "Artist";
            this.remArtButton.UseVisualStyleBackColor = true;
            this.remArtButton.Click += new System.EventHandler(this.remArtButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Remove:";
            // 
            // MusicLibControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remArtButton);
            this.Controls.Add(this.remAlbButton);
            this.Controls.Add(this.remTracks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.plContentGrid);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MusicLibControl";
            this.Size = new System.Drawing.Size(822, 515);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plContentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView plContentGrid;
        private System.Windows.Forms.ComboBox albumBox;
        private System.Windows.Forms.ComboBox artistBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button remTracks;
        private System.Windows.Forms.Button remAlbButton;
        private System.Windows.Forms.Button remArtButton;
        private System.Windows.Forms.Label label1;
    }
}
