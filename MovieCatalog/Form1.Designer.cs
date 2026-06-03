namespace VideoLibrary
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.radioButtonWantToWatch = new System.Windows.Forms.RadioButton();
            this.radioButtonWatched = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdminMode = new System.Windows.Forms.Button();
            this.listViewMovies = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDirector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelTitle.Location = new System.Drawing.Point(30, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Название фильма";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(30, 45);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelDirector.Location = new System.Drawing.Point(30, 75);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(65, 16);
            this.labelDirector.TabIndex = 2;
            this.labelDirector.Text = "Режиссёр";
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(30, 95);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(200, 20);
            this.textBoxDirector.TabIndex = 3;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelGenre.Location = new System.Drawing.Point(30, 125);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(40, 16);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Жанр";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(30, 145);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGenre.TabIndex = 5;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelYear.Location = new System.Drawing.Point(30, 175);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(85, 16);
            this.labelYear.TabIndex = 6;
            this.labelYear.Text = "Год выпуска";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(30, 195);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 7;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioButtonWatched);
            this.groupBoxStatus.Controls.Add(this.radioButtonWantToWatch);
            this.groupBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBoxStatus.Location = new System.Drawing.Point(30, 225);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(200, 80);
            this.groupBoxStatus.TabIndex = 8;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Статус просмотра";
            // 
            // radioButtonWantToWatch
            // 
            this.radioButtonWantToWatch.AutoSize = true;
            this.radioButtonWantToWatch.Location = new System.Drawing.Point(15, 25);
            this.radioButtonWantToWatch.Name = "radioButtonWantToWatch";
            this.radioButtonWantToWatch.Size = new System.Drawing.Size(120, 20);
            this.radioButtonWantToWatch.TabIndex = 0;
            this.radioButtonWantToWatch.TabStop = true;
            this.radioButtonWantToWatch.Text = "Хочу посмотреть";
            this.radioButtonWantToWatch.UseVisualStyleBackColor = true;
            // 
            // radioButtonWatched
            // 
            this.radioButtonWatched.AutoSize = true;
            this.radioButtonWatched.Location = new System.Drawing.Point(15, 50);
            this.radioButtonWatched.Name = "radioButtonWatched";
            this.radioButtonWatched.Size = new System.Drawing.Size(100, 20);
            this.radioButtonWatched.TabIndex = 1;
            this.radioButtonWatched.TabStop = true;
            this.radioButtonWatched.Text = "Просмотрено";
            this.radioButtonWatched.UseVisualStyleBackColor = true;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelRating.Location = new System.Drawing.Point(30, 315);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(120, 16);
            this.labelRating.TabIndex = 9;
            this.labelRating.Text = "Оценка (1-10)";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(30, 335);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(100, 20);
            this.textBoxRating.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(30, 415);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 30);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdminMode
            // 
            this.btnAdminMode.Location = new System.Drawing.Point(30, 460);
            this.btnAdminMode.Name = "btnAdminMode";
            this.btnAdminMode.Size = new System.Drawing.Size(190, 35);
            this.btnAdminMode.TabIndex = 14;
            this.btnAdminMode.Text = "Войти как админ";
            this.btnAdminMode.UseVisualStyleBackColor = true;
            this.btnAdminMode.Click += new System.EventHandler(this.btnAdminMode_Click);
            // 
            // listViewMovies
            // 
            this.listViewMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colDirector,
            this.colGenre,
            this.colYear,
            this.colStatus,
            this.colRating});
            this.listViewMovies.FullRowSelect = true;
            this.listViewMovies.HideSelection = false;
            this.listViewMovies.Location = new System.Drawing.Point(260, 25);
            this.listViewMovies.MultiSelect = false;
            this.listViewMovies.Name = "listViewMovies";
            this.listViewMovies.Size = new System.Drawing.Size(520, 470);
            this.listViewMovies.TabIndex = 15;
            this.listViewMovies.UseCompatibleStateImageBehavior = false;
            this.listViewMovies.View = System.Windows.Forms.View.Details;
            this.listViewMovies.SelectedIndexChanged += new System.EventHandler(this.listViewMovies_SelectedIndexChanged);
            // 
            // colTitle
            // 
            this.colTitle.Text = "Название";
            this.colTitle.Width = 150;
            // 
            // colDirector
            // 
            this.colDirector.Text = "Режиссёр";
            this.colDirector.Width = 120;
            // 
            // colGenre
            // 
            this.colGenre.Text = "Жанр";
            this.colGenre.Width = 90;
            // 
            // colYear
            // 
            this.colYear.Text = "Год";
            this.colYear.Width = 60;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Статус";
            this.colStatus.Width = 100;
            // 
            // colRating
            // 
            this.colRating.Text = "Оценка";
            this.colRating.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.listViewMovies);
            this.Controls.Add(this.btnAdminMode);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видеотека - Каталог фильмов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton radioButtonWantToWatch;
        private System.Windows.Forms.RadioButton radioButtonWatched;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdminMode;
        private System.Windows.Forms.ListView listViewMovies;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colDirector;
        private System.Windows.Forms.ColumnHeader colGenre;
        private System.Windows.Forms.ColumnHeader colYear;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colRating;
    }
}