using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VideoLibrary
{
    public partial class Form1 : Form
    {
        private bool isAdminMode = false;

        public Form1()
        {
            InitializeComponent();
            comboBoxGenre.Items.AddRange(new string[] { "Боевик", "Комедия", "Драма", "Фантастика", "Ужасы", "Мелодрама" });

            if (!System.IO.File.Exists("admin_pwd.dat")) PasswordManager.SavePassword("admin123");

            textBoxTitle.TextChanged += TextBoxFields_TextChanged;
            textBoxDirector.TextChanged += TextBoxFields_TextChanged;

            SetInterfaceMode(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromXml();
        }

        private void SetInterfaceMode(bool adminModeActive)
        {
            isAdminMode = adminModeActive;

            textBoxTitle.Enabled = isAdminMode;
            textBoxDirector.Enabled = isAdminMode;
            textBoxYear.Enabled = isAdminMode;
            textBoxRating.Enabled = isAdminMode;
            comboBoxGenre.Enabled = isAdminMode;
            radioButtonWantToWatch.Enabled = isAdminMode;
            radioButtonWatched.Enabled = isAdminMode;

            btnAdd.Enabled = isAdminMode;
            btnRemove.Enabled = isAdminMode;

            ValidateSaveButton();

            btnAdminMode.Text = isAdminMode ? "Выйти из режима админа" : "Войти как админ";

            listViewMovies.Enabled = true;
        }

        private void TextBoxFields_TextChanged(object sender, EventArgs e)
        {
            ValidateSaveButton();
        }

        private void ValidateSaveButton()
        {
            btnSave.Enabled = isAdminMode &&
                             listViewMovies.SelectedItems.Count > 0 &&
                             !string.IsNullOrWhiteSpace(textBoxTitle.Text) &&
                             !string.IsNullOrWhiteSpace(textBoxDirector.Text);
        }

        private void btnAdminMode_Click(object sender, EventArgs e)
        {
            if (!isAdminMode)
            {
                using (PasswordForm pwdForm = new PasswordForm())
                {
                    if (pwdForm.ShowDialog() == DialogResult.OK)
                    {
                        SetInterfaceMode(true);
                    }
                }
            }
            else
            {
                SetInterfaceMode(false);
                ClearFields();
                listViewMovies.SelectedItems.Clear();
            }
        }

        private void listViewMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMovies.SelectedItems.Count == 0)
            {
                ClearFields();
                ValidateSaveButton();
                return;
            }

            ListViewItem selectedItem = listViewMovies.SelectedItems[0];
            Movie movie = (Movie)selectedItem.Tag;

            textBoxTitle.Text = movie.Title;
            textBoxDirector.Text = movie.Director;
            textBoxYear.Text = movie.Year;
            comboBoxGenre.SelectedItem = movie.Genre;
            textBoxRating.Text = movie.Rating;

            if (movie.Status == "Хочу посмотреть") radioButtonWantToWatch.Checked = true;
            else if (movie.Status == "Просмотрено") radioButtonWatched.Checked = true;

            ValidateSaveButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) || string.IsNullOrWhiteSpace(textBoxDirector.Text))
            {
                MessageBox.Show("Заполните Название и Режиссёра!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = radioButtonWantToWatch.Checked ? "Хочу посмотреть" : "Просмотрено";
            string genre = comboBoxGenre.SelectedItem?.ToString() ?? "Не указан";
            string rating = radioButtonWatched.Checked ? textBoxRating.Text : "";

            Movie newMovie = new Movie(textBoxTitle.Text.Trim(), textBoxDirector.Text.Trim(), genre, textBoxYear.Text.Trim(), status, rating);

            ListViewItem item = new ListViewItem(newMovie.Title);
            item.SubItems.Add(newMovie.Director);
            item.SubItems.Add(newMovie.Genre);
            item.SubItems.Add(newMovie.Year);
            item.SubItems.Add(newMovie.Status);
            item.SubItems.Add(newMovie.Rating);
            item.Tag = newMovie;

            listViewMovies.Items.Add(item);

            SaveDataToXml();
            ClearFields();
            listViewMovies.SelectedItems.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listViewMovies.SelectedItems.Count == 0) return;

            ListViewItem item = listViewMovies.SelectedItems[0];
            Movie movie = (Movie)item.Tag;

            movie.Title = textBoxTitle.Text.Trim();
            movie.Director = textBoxDirector.Text.Trim();
            movie.Year = textBoxYear.Text.Trim();
            movie.Genre = comboBoxGenre.SelectedItem?.ToString() ?? "Не указан";
            movie.Status = radioButtonWantToWatch.Checked ? "Хочу посмотреть" : "Просмотрено";
            movie.Rating = radioButtonWatched.Checked ? textBoxRating.Text : "";

            item.Text = movie.Title;
            item.SubItems[1].Text = movie.Director;
            item.SubItems[2].Text = movie.Genre;
            item.SubItems[3].Text = movie.Year;
            item.SubItems[4].Text = movie.Status;
            item.SubItems[5].Text = movie.Rating;

            SaveDataToXml();
            ClearFields();
            listViewMovies.SelectedItems.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listViewMovies.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите фильм для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show("Удалить этот фильм из каталога?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                listViewMovies.Items.Remove(listViewMovies.SelectedItems[0]);
                SaveDataToXml();
                ClearFields();
            }
        }

        private void ClearFields()
        {
            textBoxTitle.TextChanged -= TextBoxFields_TextChanged;
            textBoxDirector.TextChanged -= TextBoxFields_TextChanged;

            textBoxTitle.Clear();
            textBoxDirector.Clear();
            textBoxYear.Clear();
            textBoxRating.Clear();
            comboBoxGenre.SelectedIndex = -1;
            radioButtonWantToWatch.Checked = false;
            radioButtonWatched.Checked = false;

            textBoxTitle.TextChanged += TextBoxFields_TextChanged;
            textBoxDirector.TextChanged += TextBoxFields_TextChanged;
        }

        private void SaveDataToXml()
        {
            List<Movie> list = new List<Movie>();
            foreach (ListViewItem item in listViewMovies.Items)
            {
                if (item.Tag is Movie movie) list.Add(movie);
            }
            XmlManager.SaveMovies(list);
        }

        private void LoadDataFromXml()
        {
            listViewMovies.Items.Clear();
            List<Movie> loaded = XmlManager.LoadMovies();
            foreach (var movie in loaded)
            {
                ListViewItem item = new ListViewItem(movie.Title);
                item.SubItems.Add(movie.Director);
                item.SubItems.Add(movie.Genre);
                item.SubItems.Add(movie.Year);
                item.SubItems.Add(movie.Status);
                item.SubItems.Add(movie.Rating);
                item.Tag = movie;
                listViewMovies.Items.Add(item);
            }
        }
    }
}