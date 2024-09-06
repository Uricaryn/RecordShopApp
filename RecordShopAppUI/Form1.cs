using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RechordShopApp.Concerete;
using RechordShopApp.Enum;
using RecordShopService.DTOs;
using RecordShopService.Services;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly AlbumService albumService;
        private readonly AdminService adminService;
        private readonly ReportService reportService;
        private readonly LoginService loginService;

        public Form1(AlbumService albumService, AdminService adminService, ReportService reportService, LoginService loginService)
        {
            InitializeComponent();
            this.albumService = albumService;
            this.adminService = adminService;
            this.reportService = reportService;
            this.loginService = loginService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupListView();
            IList<AlbumGetDto> list = albumService.GetAll();
            FillComboBox();
            ShowDtoOnListview(listView1, list);

            cmbxCategory.DataSource = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList();
            cmbStatus.DataSource = Enum.GetValues(typeof(Status)).Cast<Status>().ToList();
        }

        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Album Name");
            listView1.Columns.Add("Singer/Group");
            listView1.Columns.Add("Release Date");
            listView1.Columns.Add("Price");
            listView1.Columns.Add("Discount");
            listView1.Columns.Add("Genre");
            listView1.Columns.Add("Status");
        }

        private void FillComboBox()
        {
            cmbxFiltered.Items.AddRange(new string[]
            {
                "All Albums",
                "Discontinued Albums",
                "On Sale Albums",
                "Last 10 Added Albums",
                "Discounted Albums"
            });
            cmbxFiltered.SelectedIndex = 0;
        }

        public void ShowDtoOnListview(ListView listview, IList<AlbumGetDto> dTOs)
        {
            int counter = 0;
            listview.Items.Clear();
            foreach (AlbumGetDto item in dTOs)
            {
                ListViewItem listViewItem = new ListViewItem
                {
                    BackColor = counter % 2 == 0 ? Color.White : Color.LightGray,
                    Text = item.Id.ToString(),
                    Tag = item,
                };

                listViewItem.SubItems.Add(item.AlbumName);
                listViewItem.SubItems.Add(item.Artist);
                listViewItem.SubItems.Add(item.ReleaseDate.ToString("yyyy-MM-dd"));
                listViewItem.SubItems.Add(item.Price.ToString("F2"));
                listViewItem.SubItems.Add(item.DisctountRate.HasValue ? item.DisctountRate.Value.ToString() : "");
                listViewItem.SubItems.Add(item.Genre.ToString());
                listViewItem.SubItems.Add(item.Status.ToString());

                listview.Items.Add(listViewItem);
                counter++;
            }

            // Adjust column widths
            foreach (ColumnHeader column in listview.Columns)
            {
                column.Width = -2; // Auto size to content
            }
        }

        private void ShowDtoOnListviewMinimal(ListView listview, IList<AlbumGetDto> dTOs)
        {
            int counter = 0;
            listview.Items.Clear();
            foreach (AlbumGetDto item in dTOs)
            {
                ListViewItem listViewItem = new ListViewItem
                {
                    BackColor = counter % 2 == 0 ? Color.White : Color.Gainsboro,
                    Text = item.Id.ToString(),
                    Tag = item,
                    Font = new Font("Arial", 10, counter % 2 == 0 ? FontStyle.Bold : FontStyle.Italic)
                };

                listViewItem.SubItems.Add(item.AlbumName);
                listViewItem.SubItems.Add(item.Artist);
                listViewItem.SubItems.Add(item.ReleaseDate.ToString("yyyy-MM-dd"));
                listViewItem.SubItems.Add(item.Price.ToString("F2"));
                listViewItem.SubItems.Add(item.DisctountRate.HasValue ? item.DisctountRate.Value.ToString() : "");
                listViewItem.SubItems.Add(item.Genre.ToString());
                listViewItem.SubItems.Add(item.Status.ToString());

                listview.Items.Add(listViewItem);
                counter++;
            }

            
            foreach (ColumnHeader column in listview.Columns)
            {
                column.Width = -2; 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxAlbumName.Text) ||
                string.IsNullOrWhiteSpace(txtbxSinger.Text) ||
                string.IsNullOrWhiteSpace(txtbxPrice.Text) ||
                string.IsNullOrWhiteSpace(txtbxDiscount.Text) ||
                cmbxCategory.SelectedItem == null ||
                cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AlbumCreateDto newAlbum = new AlbumCreateDto()
                {
                    AlbumName = txtbxAlbumName.Text,
                    Artist = txtbxSinger.Text,
                    Price = decimal.Parse(txtbxPrice.Text),
                    DisctountRate = int.Parse(txtbxDiscount.Text),
                    Genre = (Genre)cmbxCategory.SelectedItem,
                    ReleaseDate = dateTimePicker1.Value,
                    Status = (Status)cmbStatus.SelectedItem
                };

                albumService.Create(newAlbum);

                IList<AlbumGetDto> updatedList = albumService.GetAll();
                ShowDtoOnListview(listView1, updatedList);

                MessageBox.Show("Album added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"Invalid input format: {fe.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                AlbumGetDto selectedAlbum = selectedItem.Tag as AlbumGetDto;

                if (selectedAlbum != null)
                {
                    if (string.IsNullOrWhiteSpace(txtbxAlbumName.Text) ||
                        string.IsNullOrWhiteSpace(txtbxSinger.Text) ||
                        string.IsNullOrWhiteSpace(txtbxPrice.Text) ||
                        string.IsNullOrWhiteSpace(txtbxDiscount.Text) ||
                        cmbxCategory.SelectedItem == null ||
                        cmbStatus.SelectedItem == null)
                    {
                        MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        AlbumGetDto updatedAlbum = new AlbumGetDto()
                        {
                            Id = selectedAlbum.Id,
                            AlbumName = txtbxAlbumName.Text,
                            Artist = txtbxSinger.Text,
                            Price = decimal.Parse(txtbxPrice.Text),
                            DisctountRate = int.Parse(txtbxDiscount.Text),
                            Genre = (Genre)cmbxCategory.SelectedItem,
                            ReleaseDate = dateTimePicker1.Value,
                            Status = (Status)cmbStatus.SelectedItem
                        };

                        albumService.Update(updatedAlbum);

                        IList<AlbumGetDto> updatedList = albumService.GetAll();
                        ShowDtoOnListview(listView1, updatedList);

                        MessageBox.Show("Album updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show($"Invalid input format: {fe.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected album data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No album selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                AlbumGetDto selectedAlbum = selectedItem.Tag as AlbumGetDto;

                if (selectedAlbum != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this album?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            albumService.Delete(selectedAlbum.Id);

                            IList<AlbumGetDto> updatedList = albumService.GetAll();
                            ShowDtoOnListview(listView1, updatedList);

                            MessageBox.Show("Album deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected album data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No album selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxUsername.Text) ||
                string.IsNullOrWhiteSpace(txtbxPassword1.Text) ||
                string.IsNullOrWhiteSpace(txtbxPassword2.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtbxPassword1.Text != txtbxPassword2.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!AdminService.ValidatePassword(txtbxPassword1.Text))
            {
                MessageBox.Show("Password does not meet the criteria.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isRegistered = loginService.RegisterUser(txtbxUsername.Text, txtbxPassword1.Text);

                if (isRegistered)
                {
                    MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User registration failed. User may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                AlbumGetDto selectedAlbum = selectedItem.Tag as AlbumGetDto;

                if (selectedAlbum != null)
                {
                    txtId.Text = selectedAlbum.Id.ToString();
                    txtbxAlbumName.Text = selectedAlbum.AlbumName;
                    txtbxSinger.Text = selectedAlbum.Artist;
                    txtbxPrice.Text = selectedAlbum.Price.ToString();
                    txtbxDiscount.Text = selectedAlbum.DisctountRate.ToString();
                    cmbxCategory.SelectedItem = selectedAlbum.Genre;
                    cmbStatus.SelectedItem = selectedAlbum.Status;
                    dateTimePicker1.Value = selectedAlbum.ReleaseDate;
                }
                else
                {
                    MessageBox.Show("Selected album data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbxFiltered_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<AlbumGetDto> filteredList = new List<AlbumGetDto>();

            switch (cmbxFiltered.SelectedIndex)
            {
                case 0: // All Albums
                    filteredList = reportService.GetAllAlbums();
                    break;
                case 1: // Discontinued Albums
                    filteredList = reportService.GetDiscontinuedAlbums();
                    break;
                case 2: // On Sale Albums
                    filteredList = reportService.GetOnSaleAlbums();
                    break;
                case 3: // Last 10 Added Albums
                    filteredList = reportService.GetRecentAlbums();
                    break;
                case 4: // Discounted Albums
                    filteredList = reportService.GetDiscountedAlbums();
                    break;
            }
            ShowDtoOnListviewMinimal(listView1, filteredList);
        }

        private void chckClear_CheckedChanged(object sender, EventArgs e)
        {
            if (chckClear.Checked)
            {
                ClearFormFields();
                chckClear.Checked = false;
            }
        }

        private void ClearFormFields()
        {
            txtId.Clear();
            txtbxAlbumName.Clear();
            txtbxSinger.Clear();
            txtbxPrice.Clear();
            txtbxDiscount.Clear();
            cmbxCategory.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
           cmbxFiltered.SelectedIndex = 0;
        }
    }
}
