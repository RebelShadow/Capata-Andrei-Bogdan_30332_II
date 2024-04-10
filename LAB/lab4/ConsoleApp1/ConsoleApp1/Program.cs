namespace Lab4
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Net.Http.Json;

    class Program
    {
        static async Task Main(string[] args)
        {

            using var httpClient = new HttpClient();


            string baseUrl = "https://localhost:7227/";

            try
            {
                int celsius = 20;
                var responseCtoF = await httpClient.GetAsync(baseUrl + $"CtoF?c={celsius}");
                responseCtoF.EnsureSuccessStatusCode();
                var fahrenheitString = await responseCtoF.Content.ReadAsStringAsync();
                var fahrenheit = double.Parse(fahrenheitString);
                Console.WriteLine($"Converted Celsius to Fahrenheit: {fahrenheit}");

                int fahrenheit1 = 68;
                var responseFtoC = await httpClient.GetAsync(baseUrl + $"FtoC?f={fahrenheit1}");
                responseFtoC.EnsureSuccessStatusCode();
                var celsiusString = await responseFtoC.Content.ReadAsStringAsync();
                var celsius1 = double.Parse(celsiusString);
                Console.WriteLine($"Converted Fahrenheit to Celsius: {celsius1}");

                var responseDateTime = await httpClient.GetAsync(baseUrl + "DateTime");
                responseDateTime.EnsureSuccessStatusCode();
                var dateTime = await responseDateTime.Content.ReadAsStringAsync();
                Console.WriteLine($"Current Date and Time: {dateTime}");

                int ron = 58;
                var responseCurCon = await httpClient.GetAsync(baseUrl + $"RonEur?r={ron}");
                responseCurCon.EnsureSuccessStatusCode();
                var eurString = await responseCurCon.Content.ReadAsStringAsync();
                var eur = double.Parse(eurString);
                Console.WriteLine($"Converted Ron to Eur: {eur}");

                var responseElements = await httpClient.GetAsync(baseUrl + "List");
                responseElements.EnsureSuccessStatusCode();
                var elementsJson = await responseElements.Content.ReadAsStringAsync();
                Console.WriteLine($"List of Elements: {elementsJson}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request failed: {e.Message}");
            }
        }
    }

}