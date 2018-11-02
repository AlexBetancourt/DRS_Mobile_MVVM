using SQLite;
using System;
namespace DRS_Mobile.Models
{
    #region MECHS
    [Table(nameof(Mech))]
    public class Mech
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Variant { get; set; }
        public int WalkSpeed { get; set; }
        public int RunSpeed { get; set; }
        public int JumpSpeed { get; set; }
        public int Tonnage { get; set; }
        public int HeatSinks { get; set; }
        public bool Done { get; set; }

        //public MechLocations mechLocations
        //{
        //    get;
        //    set;
        //}


    }
    //public class MechLocations
    //{
    //    public LocationArmor Armor
    //    {
    //        get; set;
    //    }

    //    public LocationInternal Internals
    //    {
    //        get; set;
    //    }
    //}
    [Table(nameof(LocationArmor))]
    public class LocationArmor
    {
        public int ID { get; set; }
        public int HArmor { get; set; }
        public int CTArmor { get; set; }
        public int LTArmor { get; set; }
        public int RTArmor { get; set; }
        public int LAArmor { get; set; }
        public int RAArmor { get; set; }
        public int LLArmor { get; set; }
        public int RLArmor { get; set; }
        public int CTRArmor { get; set; }
        public int LTRArmor { get; set; }
        public int RTRArmor { get; set; }
    }
    [Table(nameof(LocationInternal))]
    public class LocationInternal
    {
        public int ID { get; set; }
        public int HInternal { get; set; }
        public int CTInternal { get; set; }
        public int LTInternal { get; set; }
        public int RTInternal { get; set; }
        public int LAInternal { get; set; }
        public int RAInternal { get; set; }
        public int LLInternal { get; set; }
        public int RLInternal { get; set; }
        public int HSlots = 6;
        public int CTSlots = 12;
        public int LTSlots = 12;
        public int RTSlots = 12;
        public int LASlots = 12;
        public int RASlots = 12;
        public int LLSlots = 6;
        public int RLSlots = 6;
        public int EngineHits { get; set; }
        public int GyroHits { get; set; }
        public int SensorHits { get; set; }
        public int LifeSupportHit { get; set; }

        //public List<LocationSlots> LocationSlotList { get; set; }

        



    }
    [Table(nameof(LocationSlots))]
    public class LocationSlots
    {
        public int MechID { get; set; }
        public int LocationID { get; set; }
        public int SlotID { get; set; }
        public string Component { get; set; }
        public bool Status { get; set; }
    }
    [Table(nameof(MechConfigurations))]
    public class MechConfigurations
    {
        public int Tonnage { get; set; }
        public decimal Standard { get; set; }
        public decimal Endo { get; set; }
        public int H { get; set; }
        public int CT { get; set; }
        public int LT { get; set; }
        public int RT { get; set; }
        public int LA { get; set; }
        public int RA { get; set; }
        public int LL { get; set; }
        public int RL { get; set; }
        public int MaxArmor { get; set; }
    }
    [Table(nameof(AmmoItems))]
    public class AmmoItems
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int QuantityPerTon { get; set; }
        public decimal Weight { get; set; }
        public int Cost { get; set; }
        public int BV { get; set; }
    }
    [Table(nameof(EquipmentComponents))]
    public class EquipmentComponents
    {
        [PrimaryKey, AutoIncrement]
        public int ComponentID { get; set; }
        public string Description { get; set; }
        public int Heat { get; set; }
        public int Damage { get; set; }
        public string Minimum { get; set; }
        public string Short { get; set; }
        public string Medium { get; set; }
        public string Long { get; set; }
        public int Tonnage { get; set; }
        public int CriticalSlots { get; set; }
        public int AmmoID { get; set; }
        public int Cost { get; set; }
        public int BV { get; set; }
        public string EquipmentType { get; set; }
    }
    #endregion

    #region Forces  
    [Table(nameof(MechForces))]
    public class MechForces
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ForceName { get; set; }
        public int WarchestPoints { get; set; }
    }
    [Table(nameof(MissionTypes))]
    public class MissionTypes
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int Objective1 { get; set; }
        public int Objective2 { get; set; }
        public int Objective3 { get; set; }
        public int Bonus1 { get; set; }
        public int Bonus2 { get; set; }
        public int Bonus3 { get; set; }
    }
    [Table(nameof(ForceMissions))]
    public class ForceMissions
    {
        public int ForceID { get; set; }
        public int MissionTypeID { get; set; }
        public int WarchestPointsPaid { get; set; }
        public int WarchestPointsObtained { get; set; }
    }

    [Table(nameof(ForceMechs))]
    public class ForceMechs
    {
        public int MechID { get; set; }
        public int ForceID { get; set; }
    }
    #endregion

    #region Pilots
    [Table(nameof(Pilot))]
    public class Pilot
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set;}
        public string Rank { get; set; }
        public int Gunnery { get; set; }
        public int Piloting { get; set; }
        public int HP { get; set; }
        public int Injuries { get; set; }
        public string Affiliation { get; set; }
        public int BirthYear { get; set; }
        public string History { get; set; }
        public string Quirk { get; set; }

    }


    #endregion
}

