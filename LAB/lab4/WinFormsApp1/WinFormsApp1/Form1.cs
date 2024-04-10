using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public Form1()
        {
            InitializeComponent();

            _httpClient = new HttpClient();

            _baseUrl = "https://localhost:7227/";


        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                var responseDateTime = await _httpClient.GetAsync(_baseUrl + "DateTime");
                responseDateTime.EnsureSuccessStatusCode();
                var dateTime = await responseDateTime.Content.ReadAsStringAsync();

                textBox_Date.Text = dateTime;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request failed: {ex.Message}");
            }
        }

        private async void buttonList_Click(object sender, EventArgs e)
        {
            try
            {
                var responseList = await _httpClient.GetAsync(_baseUrl + "List");
                responseList.EnsureSuccessStatusCode();
                var elementsJson = await responseList.Content.ReadAsStringAsync();
                var elementsList = JsonSerializer.Deserialize<List<string>>(elementsJson);

                listBox_List.Items.Clear();
                foreach (var element in elementsList)
                {
                    listBox_List.Items.Add(element);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request failed: {ex.Message}");
            }
        }

        private async void buttonDate_Click(object sender, EventArgs e)
        {
            try
            {
                var responseDateTime = await _httpClient.GetAsync(_baseUrl + "DateTime");
                responseDateTime.EnsureSuccessStatusCode();
                var dateTime = await responseDateTime.Content.ReadAsStringAsync();

                textBox_Date.Text = dateTime;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request failed: {ex.Message}");
            }
        }

        private async void buttonFC_Click(object sender, EventArgs e)
        {
            try
            {
                int celsius = int.Parse(textBoxC.Text);
                var responseCtoF = await _httpClient.GetAsync(_baseUrl + $"CtoF?c={celsius}");
                responseCtoF.EnsureSuccessStatusCode();
                var fahrenheitString = await responseCtoF.Content.ReadAsStringAsync();
                textBoxR.Text = fahrenheitString;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request failed: {ex.Message}");
            }
        }

        private async void buttonCF_Click(object sender, EventArgs e)
        {
            try
            {
                int fahrenheit = int.Parse(textBoxF.Text);
                var responseFtoC = await _httpClient.GetAsync(_baseUrl + $"FtoC?f={fahrenheit}");
                responseFtoC.EnsureSuccessStatusCode();
                var celsiusString = await responseFtoC.Content.ReadAsStringAsync();
                textBoxR.Text = celsiusString;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request failed: {ex.Message}");
            }
        }

        private async void buttonConv_Click(object sender, EventArgs e)
        {
            try
            {
                int ron = int.Parse(textBoxRon.Text);
                var responseCurCon = await _httpClient.GetAsync(_baseUrl + $"RonEur?r={ron}");
                responseCurCon.EnsureSuccessStatusCode();
                var eurString = await responseCurCon.Content.ReadAsStringAsync();
                textBoxEur.Text = eurString;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request failed: {ex.Message}");
            }
        }
    }
}
