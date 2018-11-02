using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using DRS_Mobile.Models;

namespace DRS_Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanceComposition : ContentPage
    {
        public LanceComposition()
        {
            InitializeComponent();

            //string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MechDB.db3");

            //var bd = new SQLiteConnection(dbPath);
            //var MechList = bd.Table<Mech>();


            //lstLanceMechs.ItemsSource = MechList;


        }

        private void lstLanceMechs_BindingContextChanged(object sender, EventArgs e)
        {


        }

        private void cmdSelect_Pressed(object sender, EventArgs e)
        {
            var tabPage = this.Parent as TabbedPage;
            tabPage.CurrentPage = tabPage.Children[1];
            tabPage.CurrentPage.Focus();
            
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MechDB.db3");

            var bd = new SQLiteConnection(dbPath);
            bd.DeleteAll<Mech>();
        }

        private void ContentPage_Disappearing(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MechDB.db3");

            var bd = new SQLiteConnection(dbPath);
            Mech mech = new Mech();
            mech.Name = "Hunchback";
            mech.Variant = "HBK-4G";

            bd.Insert(mech);
           var MechList =  bd.Table<Mech>();

            lstLanceMechs.ItemsSource = MechList;
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MechDB.db3");

            var bd = new SQLiteConnection(dbPath);
            var MechList = bd.Table<Mech>();

            lstLanceMechs.ItemsSource = MechList;
        }
    }
}