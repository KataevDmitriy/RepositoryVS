using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace ClientWebAPI
{
    


    public partial class Form1 : Form
    {
        HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var strQuery = $"https://localhost:5001/SearchNOK?number1={textBox1.Text}&number2={textBox2.Text}";
            var response = client.GetAsync(strQuery).Result;
            var resultStr = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<box>(resultStr);
            label1.Text = "НОК: " + result.number.ToString();
        }
    }
    public class box
    {
        public ulong number { get; set; }
        public ulong result { get; set; }

    }
}
