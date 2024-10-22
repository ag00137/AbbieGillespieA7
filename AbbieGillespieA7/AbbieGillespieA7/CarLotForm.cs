using AbbieGillespieA7.CarObject;
using AbbieGillespieA7.Comparers;
using System.Text;
using System.Text.Json;

namespace AbbieGillespieA7
{
    public partial class CarLotForm : Form
    {
        private List<Car>? carData;

        public CarLotForm()
        {
            InitializeComponent();
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                string jsonData = File.ReadAllText(file);
                carData = JsonSerializer.Deserialize<List<Car>>(jsonData);
                SortByMakeBtn.Enabled = false;
                SortByMakeAndPriceBtn.Enabled = false;
                if (carData != null)
                {                    
                    foreach (Car car in carData)
                    {                        
                        string cd = $"Make: {car.Make}, Model: {car.Model}, Price: {car.Price}, Mileage: {car.Mileage}, Color: {car.Color}";
                        DataDisplayListBox.Items.Add(cd);                        
                    }                    
                    SortByMakeBtn.Enabled = true;
                    SortByMakeAndPriceBtn.Enabled = true;
                }
                else
                {
                    DataDisplayListBox.Items.Add("No Data Loaded.");
                }
            }
        }

        private void SortByMakeBtn_Click(object sender, EventArgs e)
        {
            if (carData != null)
            {
                carData.Sort();
                DataDisplayListBox.Items.Clear();
                foreach (Car car in carData)
                {
                    string cd = $"Make: {car.Make}, Model: {car.Model}, Price: {car.Price}, Mileage: {car.Mileage}, Color: {car.Color}";
                    DataDisplayListBox.Items.Add(cd);
                }
            }
        }

        private void SortByMakeAndPriceBtn_Click(object sender, EventArgs e)
        {
            if (carData != null)
            {
                carData.Sort(new MakeAndPriceComparer());
                DataDisplayListBox.Items.Clear();
                foreach (Car car in carData)
                {
                    string cd = $"Make: {car.Make}, Model: {car.Model}, Price: {car.Price}, Mileage: {car.Mileage}, Color: {car.Color}";
                    DataDisplayListBox.Items.Add(cd);
                }
            }
        }
    }
}
