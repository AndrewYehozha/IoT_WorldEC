using Flurl.Http;
using IoT_PaymentEmulator.Models.Request;
using IoT_PaymentEmulator.Models.Response;
using Newtonsoft.Json;
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
    public partial class Form1 : Form
    {
        private int coefScore = 5;
        private UserResponse userSuccsess = new UserResponse();
        private Entert_CenterResponse ecSuccsess = new Entert_CenterResponse();
        private ServicesResponse servicesSuccsess = new ServicesResponse();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();

            if(String.IsNullOrEmpty(Data.Token))
            {
                this.Close();
            }

            await LoadInfoUser();
            await LoadInfoEC();
        }

        private async Task LoadInfoUser()
        {
            try
            {
                var responseString = await "http://localhost:60436/api/Users/GetUsers/".WithHeader("Authorization", Data.Token).GetStringAsync();
                userSuccsess = JsonConvert.DeserializeObject<UserResponse>(responseString);

                var comboUserSource = new Dictionary<int, string>();

                foreach (var x in userSuccsess.data)
                {
                    comboUserSource.Add(x.Id, x.Email);
                }

                UserComboBox.DataSource = new BindingSource(comboUserSource, null);
                UserComboBox.DisplayMember = "Value";
                UserComboBox.ValueMember = "Key";

                await LoadUserField(comboUserSource.Keys.FirstOrDefault());
            }
            catch { }
        }

        private async Task LoadUserField(int id)
        {
            var user = userSuccsess.data.Where(u => u.Id == id).FirstOrDefault();

            Data.UserId = user.Id;
            NameLabel.Text = user.FirstName;
            SurnameLabel.Text = user.LastName;
            AmountBonusScoreLabel.Text = user.BonusScore.ToString();
            CountryLabel.Text = user.Country;
            CityLabel.Text = user.City;
            BlockedCheckBox.Checked = user.IsBlocked;
        }

        private async Task LoadInfoEC()
        {
            try
            {
                var responseString = await "http://localhost:60436/api/Entertainment_Centers/GetEntertainment_Centers/".WithHeader("Authorization", Data.Token).GetStringAsync();
                ecSuccsess = JsonConvert.DeserializeObject<Entert_CenterResponse>(responseString);

                var comboECSource = new Dictionary<int, string>();

                foreach (var x in ecSuccsess.data)
                {
                    comboECSource.Add(x.Id, x.Name);
                }

                ECComboBox.DataSource = new BindingSource(comboECSource, null);
                ECComboBox.DisplayMember = "Value";
                ECComboBox.ValueMember = "Key";

                await LoadECField(comboECSource.Keys.FirstOrDefault());
                await LoadInfoService(comboECSource.Keys.FirstOrDefault());
            }
            catch { }
        }

        private async Task LoadECField(int id)
        {
            var ec = ecSuccsess.data.Where(u => u.Id == id).FirstOrDefault();

            Data.Entert_CenterId = ec.Id;
            OwnerLabel.Text = ec.Owner;
            AddressLabel.Text = ec.Address;
            PhoneLabel.Text = ec.Phone.ToString();
            EmailLabel.Text = ec.Email;
            ParkingCheckBox.Checked = ec.IsParking;
        }

        private async Task LoadInfoService(int idEC)
        {
            try
            {
                var responseString = await ("http://localhost:60436/api/Services/GetServiceByECenterId/" + idEC).WithHeader("Authorization", Data.Token).GetStringAsync();
                servicesSuccsess = JsonConvert.DeserializeObject<ServicesResponse>(responseString);

                var comboServiceSource = new Dictionary<int, string>();

                foreach (var x in servicesSuccsess.data)
                {
                    comboServiceSource.Add(x.Id, x.Name);
                }

                ServiceComboBox.DisplayMember = "Value";
                ServiceComboBox.ValueMember = "Key";

                if (comboServiceSource.Count > 0)
                {
                    ServiceComboBox.DataSource = new BindingSource(comboServiceSource, null);

                    await LoadServiceField(comboServiceSource.Keys.FirstOrDefault());
                }
                else
                {
                    ServiceComboBox.DataSource = null;

                    await LoadServiceField(-1);
                }
            }
            catch { }
        }

        private async Task LoadServiceField(int id)
        {
            if (id != -1)
            {
                var service = servicesSuccsess.data.Where(u => u.Id == id).FirstOrDefault();

                Data.ServiceId = service.Id;
                Data.Cost = service.Cost;
                PriceLabel.Text = service.Cost.ToString();
                DescriptionTextBox.Text = service.Description;
                TotalPriceLabel.Text = service.Cost.ToString();
            }
            else
            {
                DescriptionTextBox.Text = String.Empty;
                PriceLabel.Text = "0";
                TotalPriceLabel.Text = "0";
            }
        }

        private void CheckBox1_Click(object sender, EventArgs e)
        {
            if (sender is CheckBox)
                ((CheckBox)sender).Checked = !((CheckBox)sender).Checked;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (BonusScoreCheckBox.Checked)
            {
                TotalPriceLabel.Text = (Convert.ToDecimal(PriceLabel.Text) * coefScore).ToString();
            }
            else
            {
                TotalPriceLabel.Text = PriceLabel.Text;
            }
        }

        private async void PayButton_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxSelect())
            {
                var model = new PaymentRequest
                {
                    UserId = Data.UserId,
                    Entert_CenterId = Data.Entert_CenterId,
                    ServiceId = Data.ServiceId,
                    Cost = Data.Cost,
                    IsBonusPayment = BonusScoreCheckBox.Checked
                };

                //await Payment(model);
            }
        }

        //private async Task<bool> Payment(PaymentRequest model)
        //{
        //    try
        //    {
        //        var responseString = await "http://localhost:60436/api/Payments/AddPayment/".PostUrlEncodedAsync(model).ReceiveString();

        //        var success = JsonConvert.DeserializeObject<AuthorizationResponse>(responseString);
        //        if (success.Success)
        //        {
        //            Data.Token = success.data.Token;
        //            return true;
        //        }

        //        var error = JsonConvert.DeserializeObject<ErrorMessage>(responseString);
        //        if (error.ErrorNum == 400)
        //        {
        //            ErrorEmailLabel.Text = error.ErrorMessages;
        //            ErrorEmailLabel.Visible = true;
        //        }
        //        else
        //        {
        //            ErrorEmailLabel.Visible = false;
        //            ErrorPasswordLabel.Text = error.ErrorMessages;
        //            ErrorPasswordLabel.Visible = true;
        //        }

        //        return false;
        //    }
        //    catch { return false; }
        //}

        private bool CheckComboBoxSelect()
        {
            ErrorPayLabel.Visible = false;

            if ((ServiceComboBox.Items.Count == 0) || (UserComboBox.Items.Count == 0) || (ECComboBox.Items.Count == 0) || (!BlockedCheckBox.Checked))
            {
                if (UserComboBox.Items.Count == 0)
                {
                    ErrorPayLabel.Text = "Error: \"Unable to complete payment because users are missing.\"";
                }
                else if (ECComboBox.Items.Count == 0)
                {
                    ErrorPayLabel.Text = "Error: \"Unable to complete payment because entertainment centers are missing.\"";
                }
                else if (ServiceComboBox.Items.Count == 0)
                {
                    ErrorPayLabel.Text = "Error: \"It is impossible to complete the payment because as there are no services in this entertainment center.\"";
                }
                else
                {
                    ErrorPayLabel.Text = "Error: \"Selected user is blocked.\"";
                }

                ErrorPayLabel.Visible = true;

                return false;
            }

            return true;
        }

        private async void UserComboBox_TextUpdate(object sender, EventArgs e)
        {
           await LoadUserField(Convert.ToInt32(((ComboBox)sender).SelectedValue));
        }

        private async void ECComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadECField(Convert.ToInt32(((ComboBox)sender).SelectedValue));
            await LoadInfoService(Convert.ToInt32(((ComboBox)sender).SelectedValue));
        }
    }
}
