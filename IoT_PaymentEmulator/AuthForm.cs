using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using IoT_PaymentEmulator.Models.Request;
using IoT_PaymentEmulator.Models.Response;
using Newtonsoft.Json;

namespace IoT_PaymentEmulator
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var model = new AuthorizationRequest
            {
                Email = EmailTextBox.Text,
                Password = PasswordTextBox.Text
            };

            var IsAuth = await Authorization(model);
            if (IsAuth)
            {
                this.Close();
            }
        }

        private async Task<bool> Authorization(object model)
        {
            try
            {
                var responseString = await (Data.URL + "Auth/AuthIOT/").PostUrlEncodedAsync(model).ReceiveString();

                var success = JsonConvert.DeserializeObject<AuthorizationResponse>(responseString);
                if (success.Success)
                {
                    Data.Token = success.data.Token;
                    return true;
                }

                var error = JsonConvert.DeserializeObject<ErrorMessage>(responseString);
                if (error.ErrorNum == 400)
                {
                    ErrorEmailLabel.Text = error.ErrorMessages;
                    ErrorEmailLabel.Visible = true;
                }
                else
                {
                    ErrorEmailLabel.Visible = false;
                    ErrorPasswordLabel.Text = error.ErrorMessages;
                    ErrorPasswordLabel.Visible = true;
                }

                return false;
            }
            catch { return false; }
        }
    }
}
