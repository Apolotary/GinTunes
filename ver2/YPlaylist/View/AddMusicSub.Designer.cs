namespace YPlaylist
{
    partial class AddMusicSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMusicSub));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.artistBox = new System.Windows.Forms.ComboBox();
            this.albumBox = new System.Windows.Forms.ComboBox();
            this.addToPlButton = new System.Windows.Forms.Button();
            this.plContentGrid = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remFromPlButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.formatSearch = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Button();
            this.genreSearch = new System.Windows.Forms.Button();
            this.yearSearch = new System.Windows.Forms.Button();
            this.formatBox = new System.Windows.Forms.ComboBox();
            this.labelBox = new System.Windows.Forms.ComboBox();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.loadPLButton = new System.Windows.Forms.Button();
            this.PlBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 298);
            this.pictureBox1.TabIndex = 6;
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
            this.HomeButton.TabIndex = 9;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // artistBox
            // 
            this.artistBox.FormattingEnabled = true;
            this.artistBox.Location = new System.Drawing.Point(253, 33);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(153, 21);
            this.artistBox.TabIndex = 10;
            this.artistBox.SelectedIndexChanged += new System.EventHandler(this.artistBox_SelectedIndexChanged);
            // 
            // albumBox
            // 
            this.albumBox.FormattingEnabled = true;
            this.albumBox.Location = new System.Drawing.Point(436, 33);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(165, 21);
            this.albumBox.TabIndex = 11;
            // 
            // addToPlButton
            // 
            this.addToPlButton.Location = new System.Drawing.Point(384, 464);
            this.addToPlButton.Name = "addToPlButton";
            this.addToPlButton.Size = new System.Drawing.Size(79, 35);
            this.addToPlButton.TabIndex = 14;
            this.addToPlButton.Text = "Add!";
            this.addToPlButton.UseVisualStyleBackColor = true;
            this.addToPlButton.Click += new System.EventHandler(this.addToPlButton_Click);
            // 
            // plContentGrid
            // 
            this.plContentGrid.BackgroundColor = System.Drawing.Color.White;
            this.plContentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plContentGrid.GridColor = System.Drawing.Color.White;
            this.plContentGrid.Location = new System.Drawing.Point(3, 250);
            this.plContentGrid.Name = "plContentGrid";
            this.plContentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plContentGrid.Size = new System.Drawing.Size(497, 208);
            this.plContentGrid.TabIndex = 15;
            this.plContentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plContentGrid_CellContentClick);
            this.plContentGrid.SelectionChanged += new System.EventHandler(this.plContentGrid_SelectionChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(634, 25);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(79, 35);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(253, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(432, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Album";
            // 
            // remFromPlButton
            // 
            this.remFromPlButton.Location = new System.Drawing.Point(290, 464);
            this.remFromPlButton.Name = "remFromPlButton";
            this.remFromPlButton.Size = new System.Drawing.Size(79, 35);
            this.remFromPlButton.TabIndex = 20;
            this.remFromPlButton.Text = "Remove!";
            this.remFromPlButton.UseVisualStyleBackColor = true;
            this.remFromPlButton.Click += new System.EventHandler(this.remFromPlButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "(choose artist to get the list of albums)";
            // 
            // formatSearch
            // 
            this.formatSearch.Location = new System.Drawing.Point(425, 190);
            this.formatSearch.Name = "formatSearch";
            this.formatSearch.Size = new System.Drawing.Size(60, 35);
            this.formatSearch.TabIndex = 47;
            this.formatSearch.Text = "Search!";
            this.formatSearch.UseVisualStyleBackColor = true;
            this.formatSearch.Click += new System.EventHandler(this.formatSearch_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.Location = new System.Drawing.Point(425, 142);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(60, 35);
            this.labelSearch.TabIndex = 46;
            this.labelSearch.Text = "Search!";
            this.labelSearch.UseVisualStyleBackColor = true;
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // genreSearch
            // 
            this.genreSearch.Location = new System.Drawing.Point(165, 190);
            this.genreSearch.Name = "genreSearch";
            this.genreSearch.Size = new System.Drawing.Size(60, 35);
            this.genreSearch.TabIndex = 45;
            this.genreSearch.Text = "Search!";
            this.genreSearch.UseVisualStyleBackColor = true;
            this.genreSearch.Click += new System.EventHandler(this.genreSearch_Click);
            // 
            // yearSearch
            // 
            this.yearSearch.Location = new System.Drawing.Point(165, 142);
            this.yearSearch.Name = "yearSearch";
            this.yearSearch.Size = new System.Drawing.Size(60, 35);
            this.yearSearch.TabIndex = 44;
            this.yearSearch.Text = "Search!";
            this.yearSearch.UseVisualStyleBackColor = true;
            this.yearSearch.Click += new System.EventHandler(this.yearSearch_Click);
            // 
            // formatBox
            // 
            this.formatBox.FormattingEnabled = true;
            this.formatBox.Location = new System.Drawing.Point(254, 198);
            this.formatBox.Name = "formatBox";
            this.formatBox.Size = new System.Drawing.Size(165, 21);
            this.formatBox.TabIndex = 43;
            // 
            // labelBox
            // 
            this.labelBox.FormattingEnabled = true;
            this.labelBox.Location = new System.Drawing.Point(254, 150);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(165, 21);
            this.labelBox.TabIndex = 42;
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(6, 198);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(153, 21);
            this.genreBox.TabIndex = 41;
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(6, 150);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(153, 21);
            this.yearBox.TabIndex = 40;
            // 
            // loadPLButton
            // 
            this.loadPLButton.Location = new System.Drawing.Point(511, 77);
            this.loadPLButton.Name = "loadPLButton";
            this.loadPLButton.Size = new System.Drawing.Size(79, 35);
            this.loadPLButton.TabIndex = 21;
            this.loadPLButton.Text = "Load!";
            this.loadPLButton.UseVisualStyleBackColor = true;
            this.loadPLButton.Click += new System.EventHandler(this.loadPLButton_Click);
            // 
            // PlBox
            // 
            this.PlBox.FormattingEnabled = true;
            this.PlBox.Location = new System.Drawing.Point(251, 85);
            this.PlBox.Name = "PlBox";
            this.PlBox.Size = new System.Drawing.Size(225, 21);
            this.PlBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Playlist";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(251, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "Format";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(251, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Label";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 21);
            this.label8.TabIndex = 48;
            this.label8.Text = "Year";
            // 
            // AddMusicSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.formatSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.genreSearch);
            this.Controls.Add(this.yearSearch);
            this.Controls.Add(this.formatBox);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadPLButton);
            this.Controls.Add(this.remFromPlButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.plContentGrid);
            this.Controls.Add(this.addToPlButton);
            this.Controls.Add(this.PlBox);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AddMusicSub";
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
        private System.Windows.Forms.ComboBox artistBox;
        private System.Windows.Forms.ComboBox albumBox;
        private System.Windows.Forms.Button addToPlButton;
        private System.Windows.Forms.DataGridView plContentGrid;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button remFromPlButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button formatSearch;
        private System.Windows.Forms.Button labelSearch;
        private System.Windows.Forms.Button genreSearch;
        private System.Windows.Forms.Button yearSearch;
        private System.Windows.Forms.ComboBox formatBox;
        private System.Windows.Forms.ComboBox labelBox;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Button loadPLButton;
        private System.Windows.Forms.ComboBox PlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}
