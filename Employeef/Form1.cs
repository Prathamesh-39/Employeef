using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.Windows;
using static Employeef.resthelper;

namespace Employeef
{
    public partial class Form1 : Form
    {
       
        private static readonly string token = System.Configuration.ConfigurationManager.AppSettings.Get("apikey");
        public Form1()
        {
            InitializeComponent();                    
        }

        private async void btnGetall_Click(object sender, EventArgs e)
        {
            //var response= await resthelper.GetAll();
            var response = await resthelper.Getnamebypage(txtpage.Text);
            txtresponse.Text = resthelper.BeautifyJson(response);
        }

        private async void btnget_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                var response = await resthelper.GetId(txtID.Text);
                txtresponse.Text = resthelper.BeautifyJson(response);
            }
            else
            {
                txtresponse.Text = "Please enter ID";
            }

        }

        private async void btndel_Click(object sender, EventArgs e)
        {
            if (txtdel.Text != "")
            {
                var response = await Delete(txtdel.Text);
                txtresponse.Text = " Delete successful";
            }
            else
            {
                txtresponse.Text = "Please enter ID";
            }


            // txtresponse.Text = resthelper.BeautifyJson(response);
        }
        public static async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                  new MediaTypeWithQualityHeaderValue("application/json"));                  
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 92f08ad240d8a4e6e9d2655edd0d40e8ac55b8bd8f716a797c8023b0c30ac5b0");
               
                using (HttpResponseMessage res = await client.DeleteAsync("https://gorest.co.in/public/v2/users" + "/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show(((int)res.StatusCode).ToString()+" "+res.StatusCode.ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }
            }
            return string.Empty;

        }

        private async void Postbtn_Click(object sender, EventArgs e)
        {
            if (postname.Text != "")
            {
                var response = await resthelper.Post(postname.Text, postemail.Text, postgen.Text, poststa.Text);
                //txtresponse.Text = response;
                txtresponse.Text = resthelper.BeautifyJson(response);
            }
            else
            {
                txtresponse.Text = "Please enter data";
            }
     
        }

        private async void btnput_Click(object sender, EventArgs e)
        {
            var response = await resthelper.Put(txtID.Text,postname.Text, postemail.Text, postgen.Text, poststa.Text);
            //txtresponse.Text = response;
            txtresponse.Text = resthelper.BeautifyJson(response);

        }
        private async void btnGetname_Click(object sender, EventArgs e)
        {

            //var response = await resthelper.Getname(txtGname.Text);
            if (txtGname.Text != "")
            {
                var response = await Getname(txtGname.Text);
                txtresponse.Text = resthelper.BeautifyJson(response);
            }
            else
            {
                txtresponse.Text = "Please enter name";
            }

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void btnexp_Click(object sender, EventArgs e)
        {
            var response = await resthelper.Exportd();
           // txtresponse.Text = resthelper.BeautifyJson(response);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
    
}
