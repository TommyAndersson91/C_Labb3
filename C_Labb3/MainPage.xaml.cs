using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace C_Labb3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

  
        public void Calc(object sender, EventArgs e)
        {
            totalAmount.Text = amountEnter.Text;
            double.TryParse(totalAmount.Text, out double totalAmountDouble);
            String vat = ((Button)sender).Text;
            var vatFix = vat.Remove(vat.Length - 1);
            double.TryParse(vatFix, out double vatAmount);
            double amountWoVat = totalAmountDouble / (1 + (vatAmount / 100));
            double withoutVAT = totalAmountDouble - amountWoVat;

            
            vatPercentage.Text = vat;
            amountWithoutVAT.Text = amountWoVat.ToString();
            vatSum.Text = withoutVAT.ToString();

        }
    }
}
