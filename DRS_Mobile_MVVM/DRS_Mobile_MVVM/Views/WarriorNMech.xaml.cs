using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DRS_Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WarriorNMech : ContentPage
    {
        public WarriorNMech()
        {
            InitializeComponent();
            
            // lvComponents.ItemsSource = mech.mechLocations.Internals.LocationSlotList;

        }
        public int MechID { get; set; }
        public int MechName { get; set; }
        public int MechVariant { get; set; }

        private void sliHits_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtHits.Text = spHits.Value.ToString();
            switch (int.Parse(txtHits.Text))
            {
                case 1:
                    txtCouns.Text = "3";
                    break;
                case 2:
                    txtCouns.Text = "5";
                    break;
                case 3:
                    txtCouns.Text = "7";
                    break;
                case 4:
                    txtCouns.Text = "10";
                    break;
                case 5:
                    txtCouns.Text = "11";
                    break;
                case 6:
                    txtCouns.Text = "Dead";
                    break;
                default:
                    txtCouns.Text = "0";
                    break;
            }
        }

        private void spHeatSinks_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtHeatSinks.Text = spHeatSinks.Value.ToString();
        }

        private void TxtMechName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string MechName = "";

            MechName = txtMechName.Text.Replace(' ', '_');
            imgMech.Source = MechName + ".png";
        }



        private void Button_Pressed(object sender, EventArgs e)
        {
            var tabPage = this.Parent as TabbedPage;
            tabPage.CurrentPage = tabPage.Children[1];
        }
    }
}