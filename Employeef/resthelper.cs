using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using System.IO;
using CsvHelper;
using System.Configuration;
using System.Windows.Forms;

namespace Employeef
{
   public static class resthelper
    {
       
        private static readonly string baseurl = "https://gorest.co.in/public-api/users";
        private static readonly string token = System.Configuration.ConfigurationManager.AppSettings.Get("apikey");
        public class Employee

        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Gender { get; set; }
            public string status { get; set; }

        }

        public class PagingParameterModel
        {
            const int maxPageSize = 20;

            public int pageNumber { get; set; } = 1;

            public int _pageSize { get; set; } = 10;

            public int pageSize
            {

                get { return _pageSize; }
                set
                {
                    _pageSize = (value > maxPageSize) ? maxPageSize : value;
                }
            }
        }
        public static string BeautifyJson(string jsonstr)
        {
            try
            {
                JToken parseJson = JToken.Parse(jsonstr);
                return parseJson.ToString(Formatting.Indented);
            }
            catch (Exception e)
            {
                Console.WriteLine($"restart:",e.Message);
                return null;
            }

        }
        public static async Task<string> GetAll()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", token);
                    using (HttpResponseMessage res = await client.GetAsync(baseurl))
                    {
                        using (HttpContent content = res.Content)
                        {

                            var responseAsString = await res.Content.ReadAsStringAsync();
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }

                    }
                }
            }
            catch (Exception e)
            {
                return $"Please restart. Reason :"+e.Message;
            }
            return string.Empty;

        }
        public static async Task<string> GetId(string id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", token);
                    using (HttpResponseMessage res = await client.GetAsync(baseurl + "/" + id))
                    {
                        using (HttpContent content = res.Content)
                        {

                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }

                    }
                }

            }
            catch (Exception e)
            {
                return $"Please restart. Reason :" + e.Message;
            }
            return string.Empty;

        }
        public static async Task<string> Exportd()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", token);

                    using (HttpResponseMessage res = await client.GetAsync(baseurl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            //JsonConvert.SerializeObject


                            string data = await content.ReadAsStringAsync();
                            JToken parseJson = JToken.Parse(data);
                            var jstring = parseJson.ToString(Formatting.Indented);
                            //using (var writer = new StringWriter())
                            //using (var csvWriter = new CsvWriter(writer))
                            //{
                            //    csvWriter.WriteRecords(jstring);
                            //    var csvData = writer.ToString();

                            //    // Print the CSV data to the console
                            //    Console.WriteLine(csvData);
                            //}
                            using (var writer = new StreamWriter("data.csv"))
                            {
                                writer.Write(data);
                            }
                            string csvString = File.ReadAllText("data.csv");

                            // Replace any extra commas with a space
                            csvString = csvString.Replace(",", " ");

                            // Replace any quotation marks with a space
                            csvString = csvString.Replace("\"", " ");

                            // Split the string into lines
                            string[] lines = csvString.Split('\n');

                            // Loop through each line and split it into columns
                            foreach (string line in lines)
                            {
                                string[] columns = line.Split(',');

                                // Do something with the columns here...
                            }

                            // Save the fixed CSV string to a new file
                            File.WriteAllText("data.csv", csvString);


                            if (data != null)
                            {
                                Console.WriteLine("exported");
                                return data;

                            }
                        }

                    }
                }
            }
            catch (Exception e)
            {
                return $"Please restart. Reason :" + e.Message;
            }
            return string.Empty;

        }
        public static async Task<string> Getname(string name)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Add("Authorization", token);
                    // client.DefaultRequestHeaders.Add("X-Pagination-Limit", "20");
                    using (HttpResponseMessage res = await client.GetAsync(baseurl + $"?name={name}"))
                    {
                        using (HttpContent content = res.Content)
                        {

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }

                    }
                }
            }
            catch (Exception e)
            {
                return $"Please restart. Reason :" + e.Message;
            }
            return string.Empty;

        }
        public static async Task<string> Getnamebypage(string pageno)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Add("Authorization", token);
                    using (HttpResponseMessage res = await client.GetAsync(baseurl + $"?page=" + pageno + "&per_page=20"))
                    {
                        using (HttpContent content = res.Content)
                        {

                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }

                    }
                }
            }
            catch (Exception e)
            {
                return $"Please restart. Reason :" + e.Message;
            }
            return string.Empty;

        }
        public static async Task<string> Post(string Name,string Email,string Gender,string status)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //client.DefaultRequestHeaders.Add("X-Pagination", JsonConvert.SerializeObject(metadata))
                    client.DefaultRequestHeaders.Add("Authorization", token);

                    var data = new { name = Name, email = Email, gender = Gender, status = status };
                    var res = await client.PostAsync("https://gorest.co.in/public/v2/users", new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));

                    using (HttpContent content = res.Content)
                    {
                        var showtxt = ((int)res.StatusCode).ToString() + " " + res.StatusCode.ToString();
                        string d2 = await content.ReadAsStringAsync();
                        if (d2 != null)
                        {
                            return d2;
                        }
                    }

                }
            }
            catch (Exception e)
            {
                return $"Please restart. Reason :" + e.Message;
            }

            return string.Empty;
        }

        public static async Task<string> Put(string Id,string Name, string Email, string Gender, string status)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", token);

                    var data = new { name = Name, email = Email, gender = Gender, status = status };
                    var res = await client.PutAsync(baseurl + "/" + Id, new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));

                    using (HttpContent content = res.Content)
                    {
                        var showtxt = ((int)res.StatusCode).ToString() + " " + res.StatusCode.ToString();
                        string d2 = await content.ReadAsStringAsync();
                        if (d2 != null)
                        {
                            return d2;
                        }
                    }

                }
            }
            catch(Exception e)
            
            {
                Console.WriteLine($"Exception is here:",e.Message);
            }
            return string.Empty;
        }

    }
}
