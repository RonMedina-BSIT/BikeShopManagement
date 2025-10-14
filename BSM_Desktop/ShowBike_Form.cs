using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSM_Common;
using BSM_DataService;

namespace BSM_Desktop
{
    public partial class ShowBike_Form : Form
    {
        public ShowBike_Form()
        {
            InitializeComponent();
        }

        int IndexRow;

        private void ShowBikeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexRow = e.RowIndex;
            DataGridViewRow row = ShowBikeTable.Rows[IndexRow];
            Typetxtfld.Text = row.Cells[0].Value.ToString();
            Brandtxtfld.Text = row.Cells[1].Value.ToString();
            Pricetxtfld.Text = row.Cells[2].Value.ToString();
            Frametxtfld.Text = row.Cells[3].Value.ToString();
            GroupsetTxtfld.Text = row.Cells[4].Value.ToString();
            Wheeltxtfld.Text = row.Cells[5].Value.ToString();
            //Dito ko po sa yt link ko na tutonan to ma'am ^^^: https://www.youtube.com/watch?v=6y65Qf8GzcI
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            var bikeDataService = new BSM_DataService.BikeDataServiceForDB();

            var result = bikeDataService.GetAllBikes();

            ShowBikeTable.DataSource = result;
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var bikeDataService = new BSM_DataService.BikeDataServiceForDB();

            var newBike = new Bikeparts
            {
                BikeType = Typetxtfld.Text,
                Brand = Brandtxtfld.Text,
                Price = (int)Convert.ToInt64(Pricetxtfld.Text),
                Frameset = Frametxtfld.Text,
                Groupset = GroupsetTxtfld.Text,
                Wheelset = Wheeltxtfld.Text
            };



            bikeDataService.UpdateBike(newBike);
            {
                MessageBox.Show("Bike Updated!");
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            var newBike = new Bikeparts
            {
                BikeType = Typetxtfld.Text,
                Brand = Brandtxtfld.Text,
                Price = (int)Convert.ToInt64(Pricetxtfld.Text),
                Frameset = Frametxtfld.Text,
                Groupset = GroupsetTxtfld.Text,
                Wheelset = Wheeltxtfld.Text
            };

            var bikeDataService = new BSM_DataService.BikeDataServiceForDB();

            bikeDataService.AddBike(newBike);
            {
                MessageBox.Show("Bike added!");
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var newBike = new Bikeparts
            {
                BikeType = Typetxtfld.Text,
                Brand = Brandtxtfld.Text,
                Price = (int)Convert.ToInt64(Pricetxtfld.Text),
                Frameset = Frametxtfld.Text,
                Groupset = GroupsetTxtfld.Text,
                Wheelset = Wheeltxtfld.Text
            };

            var bikeDataService = new BSM_DataService.BikeDataServiceForDB();

            bikeDataService.DeleteBike(newBike);
            {
                MessageBox.Show("Delete Sucessful!");
            }
        }
    }
}
