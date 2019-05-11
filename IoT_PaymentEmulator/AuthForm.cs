using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT_PaymentEmulator
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Data data = new Data();

        }

        //private async void postIndicators(string indicator)
        //{
        //    try
        //    {
        //        using (HttpClient client = new HttpClient())
        //        {
        //            await client.PostAsync(
        //                "https://mymedicalfridgeserver.azurewebsites.net/api/Indicators/",
        //                new StringContent(indicator, Encoding.UTF8, "application/json")
        //                );
        //        }
        //    }
        //    catch (Exception ex) { Console.WriteLine(ex.Message); }
        //}
    }
}
