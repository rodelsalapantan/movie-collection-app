namespace OnlineMovieDownloaderApp.Forms.Admin
{
    partial class AddMovieForm
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

        System.Windows.Forms.Button uploadLandscapeThumbnailBtn;
        System.Windows.Forms.Button uploadPortaitThumbnailBtn;
        System.Windows.Forms.Button uploadMovieBtn;
        System.Windows.Forms.Button saveBtn;
        System.Windows.Forms.Button cancelbtn;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovieForm));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actorTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.landscapeThumbnailTextBox = new System.Windows.Forms.TextBox();
            this.portraitThumbnailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.videoTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            uploadLandscapeThumbnailBtn = new System.Windows.Forms.Button();
            uploadPortaitThumbnailBtn = new System.Windows.Forms.Button();
            uploadMovieBtn = new System.Windows.Forms.Button();
            saveBtn = new System.Windows.Forms.Button();
            cancelbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(234, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 46);
            this.label3.TabIndex = 22;
            this.label3.Text = "Add Movie";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.actorTextBox);
            this.groupBox1.Controls.Add(this.genreTextBox);
            this.groupBox1.Controls.Add(this.authorTextBox);
            this.groupBox1.Controls.Add(this.movieNameTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 247);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETAILS";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(129, 193);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(430, 23);
            this.dateTimePicker.TabIndex = 44;
            this.dateTimePicker.Value = new System.DateTime(2022, 10, 20, 0, 0, 0, 0);
            // 
            // actorTextBox
            // 
            this.actorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actorTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.actorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorTextBox.Location = new System.Drawing.Point(129, 155);
            this.actorTextBox.Name = "actorTextBox";
            this.actorTextBox.Size = new System.Drawing.Size(430, 22);
            this.actorTextBox.TabIndex = 40;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genreTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTextBox.Location = new System.Drawing.Point(129, 117);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(430, 22);
            this.genreTextBox.TabIndex = 38;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(129, 79);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(430, 22);
            this.authorTextBox.TabIndex = 35;
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.movieNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameTextBox.Location = new System.Drawing.Point(129, 41);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(430, 22);
            this.movieNameTextBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Release Date:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Actor:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Movie Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(uploadLandscapeThumbnailBtn);
            this.groupBox2.Controls.Add(uploadPortaitThumbnailBtn);
            this.groupBox2.Controls.Add(uploadMovieBtn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.landscapeThumbnailTextBox);
            this.groupBox2.Controls.Add(this.portraitThumbnailTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.videoTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Fax", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(25, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 215);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILES";
            // 
            // uploadLandscapeThumbnailBtn
            // 
            uploadLandscapeThumbnailBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            uploadLandscapeThumbnailBtn.BackColor = System.Drawing.Color.White;
            uploadLandscapeThumbnailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            uploadLandscapeThumbnailBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            uploadLandscapeThumbnailBtn.FlatAppearance.BorderSize = 10;
            uploadLandscapeThumbnailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            uploadLandscapeThumbnailBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            uploadLandscapeThumbnailBtn.ForeColor = System.Drawing.Color.Black;
            uploadLandscapeThumbnailBtn.Location = new System.Drawing.Point(461, 167);
            uploadLandscapeThumbnailBtn.Name = "uploadLandscapeThumbnailBtn";
            uploadLandscapeThumbnailBtn.Size = new System.Drawing.Size(102, 25);
            uploadLandscapeThumbnailBtn.TabIndex = 43;
            uploadLandscapeThumbnailBtn.Text = "UPLOAD";
            uploadLandscapeThumbnailBtn.UseVisualStyleBackColor = false;
            uploadLandscapeThumbnailBtn.Click += new System.EventHandler(this.uploadLandscapeThumbnailBtn_Click);
            // 
            // uploadPortaitThumbnailBtn
            // 
            uploadPortaitThumbnailBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            uploadPortaitThumbnailBtn.BackColor = System.Drawing.Color.White;
            uploadPortaitThumbnailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            uploadPortaitThumbnailBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            uploadPortaitThumbnailBtn.FlatAppearance.BorderSize = 10;
            uploadPortaitThumbnailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            uploadPortaitThumbnailBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            uploadPortaitThumbnailBtn.ForeColor = System.Drawing.Color.Black;
            uploadPortaitThumbnailBtn.Location = new System.Drawing.Point(461, 107);
            uploadPortaitThumbnailBtn.Name = "uploadPortaitThumbnailBtn";
            uploadPortaitThumbnailBtn.Size = new System.Drawing.Size(102, 25);
            uploadPortaitThumbnailBtn.TabIndex = 43;
            uploadPortaitThumbnailBtn.Text = "UPLOAD";
            uploadPortaitThumbnailBtn.UseVisualStyleBackColor = false;
            uploadPortaitThumbnailBtn.Click += new System.EventHandler(this.uploadPortaitThumbnailBtn_Click);
            // 
            // uploadMovieBtn
            // 
            uploadMovieBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            uploadMovieBtn.BackColor = System.Drawing.Color.White;
            uploadMovieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            uploadMovieBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            uploadMovieBtn.FlatAppearance.BorderSize = 10;
            uploadMovieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            uploadMovieBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            uploadMovieBtn.ForeColor = System.Drawing.Color.Black;
            uploadMovieBtn.Location = new System.Drawing.Point(462, 49);
            uploadMovieBtn.Name = "uploadMovieBtn";
            uploadMovieBtn.Size = new System.Drawing.Size(102, 24);
            uploadMovieBtn.TabIndex = 42;
            uploadMovieBtn.Text = "UPLOAD";
            uploadMovieBtn.UseVisualStyleBackColor = false;
            uploadMovieBtn.Click += new System.EventHandler(this.uploadMovieBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Landscape Thumbnail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Portrait Thumbnail:";
            // 
            // landscapeThumbnailTextBox
            // 
            this.landscapeThumbnailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.landscapeThumbnailTextBox.BackColor = System.Drawing.Color.DimGray;
            this.landscapeThumbnailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.landscapeThumbnailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landscapeThumbnailTextBox.ForeColor = System.Drawing.Color.White;
            this.landscapeThumbnailTextBox.Location = new System.Drawing.Point(27, 170);
            this.landscapeThumbnailTextBox.Name = "landscapeThumbnailTextBox";
            this.landscapeThumbnailTextBox.ReadOnly = true;
            this.landscapeThumbnailTextBox.Size = new System.Drawing.Size(429, 20);
            this.landscapeThumbnailTextBox.TabIndex = 40;
            // 
            // portraitThumbnailTextBox
            // 
            this.portraitThumbnailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portraitThumbnailTextBox.BackColor = System.Drawing.Color.DimGray;
            this.portraitThumbnailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portraitThumbnailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portraitThumbnailTextBox.ForeColor = System.Drawing.Color.White;
            this.portraitThumbnailTextBox.Location = new System.Drawing.Point(27, 110);
            this.portraitThumbnailTextBox.Name = "portraitThumbnailTextBox";
            this.portraitThumbnailTextBox.ReadOnly = true;
            this.portraitThumbnailTextBox.Size = new System.Drawing.Size(429, 20);
            this.portraitThumbnailTextBox.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Video File:";
            // 
            // videoTextBox
            // 
            this.videoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoTextBox.BackColor = System.Drawing.Color.DimGray;
            this.videoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoTextBox.ForeColor = System.Drawing.Color.White;
            this.videoTextBox.Location = new System.Drawing.Point(27, 51);
            this.videoTextBox.Name = "videoTextBox";
            this.videoTextBox.ReadOnly = true;
            this.videoTextBox.Size = new System.Drawing.Size(429, 20);
            this.videoTextBox.TabIndex = 38;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(27, 583);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(327, 19);
            this.progressBar.TabIndex = 40;
            this.progressBar.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(24, 564);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 41;
            this.statusLabel.Text = "Status:";
            this.statusLabel.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // saveBtn
            // 
            saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            saveBtn.BackColor = System.Drawing.Color.Green;
            saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            saveBtn.FlatAppearance.BorderSize = 10;
            saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            saveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            saveBtn.ForeColor = System.Drawing.Color.White;
            saveBtn.Location = new System.Drawing.Point(511, 572);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new System.Drawing.Size(101, 31);
            saveBtn.TabIndex = 26;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelbtn
            // 
            cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cancelbtn.BackColor = System.Drawing.Color.Red;
            cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            cancelbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            cancelbtn.FlatAppearance.BorderSize = 10;
            cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            cancelbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cancelbtn.ForeColor = System.Drawing.Color.White;
            cancelbtn.Location = new System.Drawing.Point(380, 572);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new System.Drawing.Size(104, 31);
            cancelbtn.TabIndex = 42;
            cancelbtn.Text = "CANCEL";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(635, 624);
            this.Controls.Add(cancelbtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Movie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox actorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox portraitThumbnailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox videoTextBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox landscapeThumbnailTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}