using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FurnitureStore
{
    public partial class Form1 : Form
    {
        private FurnitureManager furnitureManager;
        public Form1()
        {
            InitializeComponent();

            furnitureManager = new FurnitureManager("Data Source=furniture.db");

            var furniture = furnitureManager.ReadFurniture();
            var furnitureNames = new List<string>();

            foreach (var f in furniture)
            {
                furnitureNames.Add(f.Name);
            }

            selectProductComboBox.DataSource = furnitureNames;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            var furniture = furnitureManager.ReadFurnitureByName(selectProductComboBox.Text);

            nameTextBox.Text = furniture.Name;
            descriptionTextBox.Text = furniture.Description;
            priceTextBox.Text = furniture.Price.ToString();
            heightTextBox.Text = furniture.Height.ToString();
            widthTextBox.Text = furniture.Width.ToString();
            lenghtTextBox.Text = furniture.Length.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts nosaukums.");
                }
                else if (string.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts apraksts.");
                }
                else if (string.IsNullOrEmpty(priceTextBox.Text))
                {
                    MessageBox.Show("Nav norādīta cena.");
                }
                else if (string.IsNullOrEmpty(heightTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts augstums.");
                }
                else if (string.IsNullOrEmpty(widthTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts platums.");
                }
                else if (string.IsNullOrEmpty(lenghtTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts garums.");
                }


                furnitureManager.AddFurniture(nameTextBox.Text, descriptionTextBox.Text,
                Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(heightTextBox.Text),
                    Convert.ToInt32(widthTextBox.Text), Convert.ToInt32(lenghtTextBox.Text));

                List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
                furnitureList.Add(nameTextBox.Text);

                selectProductComboBox.DataSource = null;
                selectProductComboBox.DataSource = furnitureList;

                MessageBox.Show("Ieraksts tika pievienots datubāzei");
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Notikusi SQL kļūda.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notikusi kļūda.");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text) ||
                    string.IsNullOrEmpty(descriptionTextBox.Text) ||
                    string.IsNullOrEmpty(priceTextBox.Text) ||
                    string.IsNullOrEmpty(heightTextBox.Text) ||
                    string.IsNullOrEmpty(widthTextBox.Text) ||
                    string.IsNullOrEmpty(lenghtTextBox.Text))
                {
                    MessageBox.Show("Visi lauki ir jāaizpilda.");
                    return;
                }

                var oldName = selectProductComboBox.Text;
                var newName = nameTextBox.Text;
                var description = descriptionTextBox.Text;
                var price = Convert.ToDouble(priceTextBox.Text);
                var height = Convert.ToInt32(heightTextBox.Text);
                var width = Convert.ToInt32(widthTextBox.Text);
                var length = Convert.ToInt32(lenghtTextBox.Text);

                furnitureManager.UpdateFurnitureByName(oldName, newName, description, price, height, width, length);

                List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
                int index = furnitureList.IndexOf(oldName);
                if (index != -1)
                {
                    furnitureList[index] = newName;
                }

                selectProductComboBox.DataSource = null;
                selectProductComboBox.DataSource = furnitureList;

                MessageBox.Show("Ieraksts tika atjaunināts.");
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Notikusi SQL kļūda: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notikusi kļūda: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            furnitureManager.DeleteFurnitureByName(selectProductComboBox.Text);

            List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
            furnitureList.Remove(selectProductComboBox.Text);

            selectProductComboBox.DataSource = null;
            selectProductComboBox.DataSource = furnitureList;

            MessageBox.Show("Mēbele tika izdzēsta no datubāzes.");
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var furnitureList = furnitureManager.ReadFurniture();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV faili (*.csv)|*.csv";
                saveFileDialog.Title = "Eksportēt mēbeļu datus";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("Name,Description,Price,Height,Width,Length");

                        foreach (var furniture in furnitureList)
                        {
                            writer.WriteLine($"{furniture.Name},{furniture.Description},{furniture.Price},{furniture.Height},{furniture.Width},{furniture.Length}");
                        }
                    }

                    MessageBox.Show("Dati veiksmīgi eksportēti!");
                }
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV faili (*.csv)|*.csv";
                openFileDialog.Title = "Importēt mēbeļu datus";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var reader = new StreamReader(openFileDialog.FileName))
                    {
                        string headerLine = reader.ReadLine();

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            if (values.Length == 6)
                            {
                                try
                                {
                                    string name = values[0];
                                    string description = values[1];
                                    double price = Convert.ToDouble(values[2]);
                                    int height = Convert.ToInt32(values[3]);
                                    int width = Convert.ToInt32(values[4]);
                                    int length = Convert.ToInt32(values[5]);

                                    furnitureManager.AddFurniture(name, description, price, height, width, length);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Kļūda importējot rindu: {line}\n{ex.Message}");
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Nederīgs rindas formāts: {line}");
                            }
                        }
                    }

                    var furniture = furnitureManager.ReadFurniture();
                    selectProductComboBox.DataSource = furniture.Select(f => f.Name).ToList();

                    MessageBox.Show("Dati veiksmīgi importēti!");
                }
            }
        }
    }
}
