using Flurl.Http;
using IoT_PaymentEmulator.Models.Request;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();

            if(String.IsNullOrEmpty(Data.Token))
            {
                this.Close();
            }

            LoadInfoUser();
            LoadInfoEC();
        }

        private async void LoadInfoEC()
        {
            var responseString = await "http://localhost:60436/api/Auth/AuthIOT/".GetStringAsync();
            var success = JsonConvert.DeserializeObject<AuthorizationResponse>(responseString);
        }

        private async void LoadInfoUser()
        {
            var responseString = await "http://localhost:60436/api/Auth/AuthIOT/".GetStringAsync();
            var success = JsonConvert.DeserializeObject<AuthorizationResponse>(responseString);

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
                TotalPriceLabel.Text = (Convert.ToInt32(PriceLabel.Text) * coefScore).ToString();
            }
            else
            {
                TotalPriceLabel.Text = PriceLabel.Text;
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxSelect())
            {

            }
        }

        private bool CheckComboBoxSelect()
        {
            if ((ServiceComboBox.Items.Count == 0) || (UserComboBox.Items.Count == 0) || (ECComboBox.Items.Count == 0))
            {

                if (UserComboBox.Items.Count == 0)
                {
                    MessageBox.Show("Невозможно выполнить оплату, так как не выбран пользователь.");
                }
                else if (ECComboBox.Items.Count == 0)
                {
                    MessageBox.Show("Невозможно выполнить оплату, так как отсутствуют развлекательные центры.");
                }
                else if (ServiceComboBox.Items.Count == 0)
                {
                    MessageBox.Show("Невозможно выполнить оплату, так как в данном развлекательном центре отсутствуют сервисы.");
                }

                return false;
            }

            return true;
        }
    }
}
