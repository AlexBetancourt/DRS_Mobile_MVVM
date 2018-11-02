using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.TextToSpeech;
using Plugin.TextToSpeech.Abstractions;
using DRS_Mobile.Data;
using DRS_Mobile.Models;
namespace DRS_Mobile
{

    public partial class MechDiagram : ContentPage
    {


        public MechDiagram()
        {
            InitializeComponent();

            Mech mech = new Mech();

            mech.Name = "Commando";
            mech.Variant = "COM-2D";
            mech.WalkSpeed = 6;
            mech.RunSpeed = 9;
            mech.JumpSpeed = 0;
            mech.HeatSinks = 10;
            mech.Tonnage = 25;

            //MechLocations locations = new MechLocations();

            LocationArmor Armor = new LocationArmor();
            Armor.HArmor = 6;
            Armor.CTArmor = 8;
            Armor.LTArmor = 6;
            Armor.RTArmor = 6;
            Armor.LAArmor = 6;
            Armor.RAArmor = 6;
            Armor.LLArmor = 8;
            Armor.RLArmor = 8;
            Armor.CTRArmor = 4;
            Armor.LTRArmor = 3;
            Armor.RTRArmor = 3;
            //mech.Armor = Armor;
            LocationInternal internals = new LocationInternal();
            internals.HInternal = 3;
            internals.CTInternal = 8;
            internals.LTInternal = 6;
            internals.RTInternal = 6;
            internals.LAInternal = 4;
            internals.RAInternal = 4;
            internals.LLInternal = 6;
            internals.RLInternal = 6;

            List<LocationSlots> Lista = new List<LocationSlots>();
            for (int j = 0; j < 8; j++)
            {
                switch (j)
                {
                    case 0:
                        for (int i = 0; i < internals.HSlots; i++)
                        {
                            LocationSlots slot = new LocationSlots();

                            slot.LocationID = j + 1;
                            slot.Component = "Cockpit" + (i + 1);
                            slot.Status = false;
                            Lista.Add(slot);
                        }
                        break;
                    case 1:
                        for (int i = 0; i < internals.CTSlots; i++)
                        {
                            LocationSlots slot = new LocationSlots();

                            slot.LocationID = j + 1;
                            slot.Component = "Center Torso" + (i + 1);
                            slot.Status = false;
                            Lista.Add(slot);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < internals.LTSlots; i++)
                        {
                            LocationSlots slot = new LocationSlots();

                            slot.LocationID = j + 1;
                            slot.Component = "Left Torso" + (i + 1);
                            slot.Status = false;
                            Lista.Add(slot);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < internals.RTSlots; i++)
                        {
                            LocationSlots slot = new LocationSlots();

                            slot.LocationID = j + 1;
                            slot.Component = "Right Torso" + (i + 1);
                            slot.Status = false;
                            Lista.Add(slot);
                        }
                        break;
                    case 4:
                        for (int i = 0; i < internals.LASlots; i++)
                        {
                            LocationSlots slot = new LocationSlots();

                            slot.LocationID = j + 1;
                            slot.Component = "Left Arm" + (i + 1);
                            slot.Status = false;
                            Lista.Add(slot);
                        }
                        break;
                    case 5:
                        for (int i = 0; i < internals.RASlots; i++)
                        {
                            LocationSlots slot = new LocationSlots();

                            slot.LocationID = j + 1;
                            slot.Component = "Right Arm" + (i + 1);
                            slot.Status = false;
                            Lista.Add(slot);
                        }
                        break;
                    case 6:
                        for (int i = 0; i < internals.LLSlots; i++)
                        {
                            LocationSlots slot = new LocationSlots();

                            slot.LocationID = j + 1;
                            slot.Component = "Left Leg" + (i + 1);
                            slot.Status = false;
                            Lista.Add(slot);
                        }
                        break;
                    case 7:
                        for (int i = 0; i < internals.RLSlots; i++)
                        {
                            LocationSlots slot = new LocationSlots();

                            slot.LocationID = j + 1;
                            slot.Component = "Right Leg" + (i + 1);
                            slot.Status = false;
                            Lista.Add(slot);
                        }
                        break;
                    default:
                        break;
                }
            }
            //internals.LocationSlotList = Lista;
            //mech.Internals = internals;

            lblMech.Text = mech.Variant + " " + mech.Name;

            stHHP.Maximum = Armor.HArmor;
            stCTHP.Maximum = Armor.CTArmor;
            stLTHP.Maximum = Armor.LTArmor;
            stRTHP.Maximum =Armor.RTArmor;
            stLAHP.Maximum = Armor.LAArmor;
            stRAHP.Maximum = Armor.RAArmor;
            stLLHP.Maximum = Armor.LLArmor;
            stRLHP.Maximum = Armor.RLArmor;

            stIHHP.Maximum =internals.HInternal;
            stICTHP.Maximum = internals.CTInternal;
            stILTHP.Maximum =internals.LTInternal;
            stIRTHP.Maximum = internals.RTInternal;
            stILAHP.Maximum = internals.LAInternal;
            stIRAHP.Maximum = internals.RAInternal;
            stILLHP.Maximum = internals.LLInternal;
            stIRLHP.Maximum = internals.RLInternal;

            lblHHP.Text = stHHP.Maximum.ToString();
            lblCTHP.Text = stCTHP.Maximum.ToString();
            lblLTHP.Text = stLTHP.Maximum.ToString();
            lblRTHP.Text = stRTHP.Maximum.ToString();
            lblLAHP.Text = stLAHP.Maximum.ToString();
            lblRAHP.Text = stRAHP.Maximum.ToString();
            lblLLHP.Text = stLLHP.Maximum.ToString();
            lblRLHP.Text = stRLHP.Maximum.ToString();

            lblIHHP.Text = stHHP.Maximum.ToString();
            lblICTHP.Text = stCTHP.Maximum.ToString();
            lblILTHP.Text = stLTHP.Maximum.ToString();
            lblIRTHP.Text = stRTHP.Maximum.ToString();
            lblILAHP.Text = stLAHP.Maximum.ToString();
            lblIRAHP.Text = stRAHP.Maximum.ToString();
            lblILLHP.Text = stLLHP.Maximum.ToString();
            lblIRLHP.Text = stRLHP.Maximum.ToString();

            stHHP.Value = stHHP.Maximum;
            stCTHP.Value = stCTHP.Maximum;
            stLTHP.Value = stLTHP.Maximum;
            stRTHP.Value = stRTHP.Maximum;
            stLAHP.Value = stLAHP.Maximum;
            stRAHP.Value = stRAHP.Maximum;
            stLLHP.Value = stLLHP.Maximum;
            stRLHP.Value = stRLHP.Maximum;

            stIHHP.Value = stHHP.Maximum;
            stICTHP.Value = stCTHP.Maximum;
            stILTHP.Value = stLTHP.Maximum;
            stIRTHP.Value = stRTHP.Maximum;
            stILAHP.Value = stLAHP.Maximum;
            stIRAHP.Value = stRAHP.Maximum;
            stILLHP.Value = stLLHP.Maximum;
            stIRLHP.Value = stRLHP.Maximum;

            stIHHP.IsVisible =
            stICTHP.IsVisible =
            stILTHP.IsVisible =
            stIRTHP.IsVisible =
            stILAHP.IsVisible =
            stIRAHP.IsVisible =
            stILLHP.IsVisible =
            stIRLHP.IsVisible = false;
            lblIHHP.IsVisible =
            lblICTHP.IsVisible =
            lblILTHP.IsVisible =
            lblIRTHP.IsVisible =
            lblILAHP.IsVisible =
            lblIRAHP.IsVisible =
            lblILLHP.IsVisible =
            lblIRLHP.IsVisible = false;

            Pilot pilot = new Pilot();
            pilot.Name = "Joren Matsuda";
            pilot.Piloting = 4;
            pilot.Gunnery = 3;
            pilot.HP = 6;
            pilot.Injuries = 0;
            pilot.Affiliation = "Draconis Combine";
            pilot.BirthYear =2981;
            //mech.MechPilot = pilot;

            App.MechData.SaveItemAsync(mech);

        }

        void OnValueChangedH(object sender, ValueChangedEventArgs e)
        {
            //pbHeat.Progress = e.NewValue / stHHP.Maximum;
            lblHHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblHHP, null, lblHHP, "HHHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblHHP.BackgroundColor = Color.LightGray;
                lblHHP.IsVisible = false;
                stHHP.IsVisible = false;
                lblIHHP.IsVisible = true;
                stIHHP.IsVisible = true;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stHHP.Maximum.ToString()) / 3))
            {

                lblHHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stHHP.Maximum.ToString()) / 3) * 2)
            {
                lblHHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblHHP.BackgroundColor = Color.White;
            }
        }

        private void stCTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblCTHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblCTHP, null, lblCTHP, "CTHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblCTHP.BackgroundColor = Color.LightGray;
                lblCTHP.IsVisible = false;
                stCTHP.IsVisible = false;
                lblICTHP.IsVisible = true;
                stICTHP.IsVisible = true;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stCTHP.Maximum.ToString()) / 3))
            {

                lblCTHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stCTHP.Maximum.ToString()) / 3) * 2)
            {
                lblCTHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblCTHP.BackgroundColor = Color.White;
            }
        }

        private void stLTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblLTHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblLTHP, null, lblLTHP, "LTHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblLTHP.BackgroundColor = Color.LightGray;
                lblLTHP.IsVisible = false;
                stLTHP.IsVisible = false;
                lblILTHP.IsVisible = true;
                stILTHP.IsVisible = true;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLTHP.Maximum.ToString()) / 3))
            {

                lblLTHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLTHP.Maximum.ToString()) / 3) * 2)
            {
                lblLTHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblLTHP.BackgroundColor = Color.White;
            }
        }

        private void stRTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblRTHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblRTHP, null, lblRTHP, "RTHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblRTHP.BackgroundColor = Color.LightGray;
                lblRTHP.IsVisible = false;
                stRTHP.IsVisible = false;
                lblIRTHP.IsVisible = true;
                stIRTHP.IsVisible = true;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRTHP.Maximum.ToString()) / 3))
            {

                lblRTHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRTHP.Maximum.ToString()) / 3) * 2)
            {
                lblRTHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblRTHP.BackgroundColor = Color.White;
            }
        }

        private void stLAHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblLAHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblLAHP, null, lblLAHP, "LAHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblLAHP.BackgroundColor = Color.LightGray;
                lblLAHP.IsVisible = false;
                stLAHP.IsVisible = false;
                lblILAHP.IsVisible = true;
                stILAHP.IsVisible = true;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLAHP.Maximum.ToString()) / 3))
            {

                lblLAHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLAHP.Maximum.ToString()) / 3) * 2)
            {
                lblLAHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblLAHP.BackgroundColor = Color.White;
            }
        }

        private void stRAHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblRAHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblRAHP, null, lblRAHP, "RAHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblRAHP.BackgroundColor = Color.LightGray;
                lblRAHP.IsVisible = false;
                stRAHP.IsVisible = false;
                lblIRAHP.IsVisible = true;
                stIRAHP.IsVisible = true;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRAHP.Maximum.ToString()) / 3))
            {

                lblRAHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRAHP.Maximum.ToString()) / 3) * 2)
            {
                lblRAHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblRAHP.BackgroundColor = Color.White;
            }
        }

        private void stLLHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblLLHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblLLHP, null, lblLLHP, "LLHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblLLHP.BackgroundColor = Color.LightGray;
                lblLLHP.IsVisible = false;
                stLLHP.IsVisible = false;
                lblILLHP.IsVisible = true;
                stILLHP.IsVisible = true;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLLHP.Maximum.ToString()) / 3))
            {

                lblLLHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLLHP.Maximum.ToString()) / 3) * 2)
            {
                lblLLHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblLLHP.BackgroundColor = Color.White;
            }
        }

        private void stRLHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblRLHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblRLHP, null, lblRLHP, "RLHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblRLHP.BackgroundColor = Color.LightGray;
                lblRLHP.IsVisible = false;
                stRLHP.IsVisible = false;
                lblIRLHP.IsVisible = true;
                stIRLHP.IsVisible = true;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRLHP.Maximum.ToString()) / 3))
            {

                lblRLHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRLHP.Maximum.ToString()) / 3) * 2)
            {
                lblRLHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblRLHP.BackgroundColor = Color.White;
            }
        }

        private void Button_Clicked(object sender, EventArgs e, object Control, string Location)
        {
            string Ubicacion = "";
            string Ubi = "";
            switch (Location.Substring(0, 3))
            {
                case "HHH":
                    Ubicacion = "Head";

                    break;
                case "CTH":
                    Ubicacion = "Center Torso";
                    break;
                case "LTH":
                    Ubicacion = "Left Torso";
                    break;
                case "RTH":
                    Ubicacion = "Right Torso";
                    break;
                case "LAH":
                    Ubicacion = "Left Arm";
                    break;
                case "RAH":
                    Ubicacion = "Right Arm";
                    break;
                case "LLH":
                    Ubicacion = "Left Leg";
                    break;
                case "RLH":
                    Ubicacion = "Right Leg";
                    break;
                case "IHH":
                    Ubicacion = " Head";
                    Ubi = "H";
                    break;
                case "ICT":
                    Ubicacion = " Center Torso";
                    Ubi = "CT";
                    break;
                case "ILT":
                    Ubicacion = " Left Torso";
                    Ubi = "LT";
                    break;
                case "IRT":
                    Ubicacion = " Right Torso";
                    Ubi = "RT";
                    break;
                case "ILA":
                    Ubicacion = " Left Arm";
                    Ubi = "LA";
                    break;
                case "IRA":
                    Ubicacion = " Right Arm";
                    Ubi = "RA";
                    break;
                case "ILL":
                    Ubicacion = " Left Leg";
                    Ubi = "LL";
                    break;
                case "IRL":
                    Ubicacion = " Right Leg";
                    Ubi = "RL";
                    break;
                default:
                    Ubicacion = "";
                    break;
            }
            var text = (Label)Control;
            if (text.Text == "0" && Ubicacion.Substring(0, 1) != " ")
            {

                string Speech = Ubicacion + " Armor Breached!";
                CrossTextToSpeech.Current.Speak(Speech);
            }
            else if (text.Text == "0" && Ubicacion.Substring(0, 1) == " ")
            {
                text.Text = Ubi + " Destroyed!";
                string Speech = Ubicacion + " Destroyed";
                CrossTextToSpeech.Current.Speak(Speech);
            }
        }

        private void stIHHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //pbHeat.Progress = e.NewValue / stIHHP.Maximum;
            lblIHHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblIHHP, null, lblIHHP, "IHHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblIHHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIHHP.Maximum.ToString()) / 3))
            {
                lblIHHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIHHP.Maximum.ToString()) / 3) * 2)
            {
                lblIHHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblIHHP.BackgroundColor = Color.White;
            }
        }

        private void stICTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblICTHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblICTHP, null, lblICTHP, "ICTHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblICTHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stICTHP.Maximum.ToString()) / 3))
            {
                lblICTHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stICTHP.Maximum.ToString()) / 3) * 2)
            {
                lblICTHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblICTHP.BackgroundColor = Color.White;
            }
        }

        private void stILTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblILTHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblILTHP, null, lblILTHP, "ILTHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblILTHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stILTHP.Maximum.ToString()) / 3))
            {

                lblILTHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stILTHP.Maximum.ToString()) / 3) * 2)
            {
                lblILTHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblILTHP.BackgroundColor = Color.White;
            }
        }

        private void stIRTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblIRTHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblIRTHP, null, lblIRTHP, "IRTHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblIRTHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIRTHP.Maximum.ToString()) / 3))
            {

                lblIRTHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIRTHP.Maximum.ToString()) / 3) * 2)
            {
                lblIRTHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblIRTHP.BackgroundColor = Color.White;
            }
        }

        private void stILAHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblILAHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblILAHP, null, lblILAHP, "ILAHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblILAHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stILAHP.Maximum.ToString()) / 3))
            {

                lblILAHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stILAHP.Maximum.ToString()) / 3) * 2)
            {
                lblILAHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblILAHP.BackgroundColor = Color.White;
            }
        }

        private void stIRAHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblIRAHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblIRAHP, null, lblIRAHP, "IRAHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblIRAHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIRAHP.Maximum.ToString()) / 3))
            {

                lblIRAHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIRAHP.Maximum.ToString()) / 3) * 2)
            {
                lblIRAHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblIRAHP.BackgroundColor = Color.White;
            }
        }

        private void stILLHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblILLHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblILLHP, null, lblILLHP, "ILLHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblILLHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stILLHP.Maximum.ToString()) / 3))
            {

                lblILLHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stILLHP.Maximum.ToString()) / 3) * 2)
            {
                lblILLHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblILLHP.BackgroundColor = Color.White;
            }
        }

        private void stIRLHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblIRLHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblIRLHP, null, lblIRLHP, "IRLHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblIRLHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIRLHP.Maximum.ToString()) / 3))
            {

                lblIRLHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIRLHP.Maximum.ToString()) / 3) * 2)
            {
                lblIRLHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblIRLHP.BackgroundColor = Color.White;
            }
        }

        void CmdWeapons_Clicked(object sender, EventArgs e)
        {
            var WeaponPage = new WeaponsNEquip();
            Navigation.PushAsync(WeaponPage, true);
        }

        void cmdInternals_Clicked(object sender, EventArgs e)
        {
            var InternalsPage = new WarriorNMech();
            Navigation.PushAsync(InternalsPage, true);
        }
    }

}
