using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyChainGeneratorConsole
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // http://www.webgraphviz.com/

            string factory = "Steel Factory 1";
            //string factory = "War Robot Factory";

            Clipboard.SetText(Factory.Factories.Where(x => x.Name == factory).FirstOrDefault().GenerateChain());
        }
    }
}

public class Factory
{
    public static List<Factory> Factories { get; } = new List<Factory>()
    {
        #region Mines

        new Factory()
        {
            Name = "Aluminium Mine",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Aluminium,
            },
        },

        new Factory()
        {
            Name = "Coal Mine",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Coal,
            },
        },

        new Factory()
        {
            Name = "Copper Mine",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Copper,
            },
        },

        new Factory()
        {
            Name = "Ice Mine",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Lead Mine",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Lead,
            },
        },

        new Factory()
        {
            Name = "Noble Metal Mine 1",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
               Goods.Gold, Goods.Platinum,
            },
        },

        new Factory()
        {
            Name = "Noble Metal Mine 2",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Silver, Goods.Platinum,
            },
        },


        new Factory()
        {
            Name = "Noble Metal Mine 3",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Silver, Goods.Gold,
            },
        },

        //new Factory()
        //{
        //    Name = "Noble Metal Mine 4",
        //    Inputs = new List<string>()
        //    {

        //    },
        //    Outputs = new List<string>()
        //    {
        //        Goods.Silver, Goods.Gold,
        //    },
        //},

        //new Factory()
        //{
        //    Name = "Noble Metal Mine 5",
        //    Inputs = new List<string>()
        //    {

        //    },
        //    Outputs = new List<string>()
        //    {
        //        Goods.Silver, Goods.Gold,
        //    },
        //},

        new Factory()
        {
            Name = "Ore Mine",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Ore,
            },
        },

        new Factory()
        {
            Name = "Silicon Mine",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Silicon,
            },
        },

        new Factory()
        {
            Name = "Zinc Mine",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Zinc,
            },
        },

        new Factory()
        {
            Name = "Oil Rig",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.RawOil,
            },
        },

        #endregion

        #region Basic Factories

        new Factory()
        {
            Name = "Water Collector",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Plankton Collector",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Plankton,
            },
        },

        new Factory()
        {
            Name = "Mineral Extractor",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Minerals,
            },
        },

        new Factory()
        {
            Name = "Crystal Farm",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Crystals,
            },
        },

        new Factory()
        {
            Name = "Scrap Metal Trader",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.ScrapMetal,
            },
        },

        new Factory()
        {
            Name = "Gas Collector 1",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Helium, Goods.Hydrogen, Goods.Neon, Goods.Chlorine,
            },
        },

        new Factory()
        {
            Name = "Gas Collector 2",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Helium, Goods.Hydrogen, Goods.Chlorine, Goods.Fluorine,
            },
        },

        new Factory()
        {
            Name = "Gas Collector 3",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Oxygen, Goods.Hydrogen, Goods.Nitrogen,
            },
        },

        new Factory()
        {
            Name = "Gas Collector 4",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.Helium, Goods.Nitrogen, Goods.Neon, Goods.Chlorine, Goods.Fluorine,
            },
        },

        new Factory()
        {
            Name = "Solar Power Plant",
            Inputs = new List<string>()
            {

            },
            Outputs = new List<string>()
            {
                Goods.EnergyCells,
            },
        },

        #endregion

        #region Low Tech Factories

        new Factory()
        {
            Name = "Carbon Extractor 1",
            Inputs = new List<string>()
            {
                Goods.Corn,
            },
            Outputs = new List<string>()
            {
                Goods.Carbon,
            },
        },

        new Factory()
        {
            Name = "Carbon Extractor 2",
            Inputs = new List<string>()
            {
                Goods.Rice,
            },
            Outputs = new List<string>()
            {
                Goods.Carbon,
            },
        },

        new Factory()
        {
            Name = "Carbon Extractor 3",
            Inputs = new List<string>()
            {
                Goods.Wheat,
            },
            Outputs = new List<string>()
            {
                Goods.Carbon,
            },
        },

        new Factory()
        {
            Name = "Carbon Extractor 4",
            Inputs = new List<string>()
            {
                Goods.Potatos,
            },
            Outputs = new List<string>()
            {
                Goods.Carbon,
            },
        },

        new Factory()
        {
            Name = "Rubber Factory",
            Outputs = new List<string>()
            {
                Goods.Rubber,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Oil,
            },
        },

        new Factory()
        {
            Name = "Solar Cell Factory",
            Outputs = new List<string>()
            {
                Goods.SolarCells,
            },
            Inputs = new List<string>()
            {
                Goods.Zinc, Goods.Silicon, Goods.Platinum, Goods.Gold, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Steel Factory 1",
            Outputs = new List<string>()
            {
                Goods.Steel,
            },
            Inputs = new List<string>()
            {
                Goods.Ore, Goods.Coal, Goods.Carbon,
            },
        },

        new Factory()
        {
            Name = "Steel Factory 2",
            Outputs = new List<string>()
            {
                Goods.Steel,
            },
            Inputs = new List<string>()
            {
                Goods.ScrapMetal, Goods.Coal,
            },
        },

        new Factory()
        {
            Name = "Fuel Factory",
            Outputs = new List<string>()
            {
                Goods.Fuel,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Oil, Goods.Nitrogen, Goods.Fluorine,
            },
        },

        new Factory()
        {
            Name = "Fertilizer Factory 1",
            Outputs = new List<string>()
            {
                Goods.Fertilizer,
            },
            Inputs = new List<string>()
            {
                Goods.Chemicals, Goods.Minerals, Goods.EnergyCells, Goods.Solvent,
            },
        },

        new Factory()
        {
            Name = "Fertilizer Factory 2",
            Outputs = new List<string>()
            {
                Goods.Fertilizer,
            },
            Inputs = new List<string>()
            {
                Goods.Plankton, Goods.Minerals, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "High Capacity Lens Factory",
            Outputs = new List<string>()
            {
                Goods.HighCapacityLenses,
            },
            Inputs = new List<string>()
            {
                Goods.Glass, Goods.Carbon, Goods.Plastic, Goods.Diamonds,
            },
        },

        new Factory()
        {
            Name = "Fabric Factory",
            Outputs = new List<string>()
            {
                Goods.Fabric,
            },
            Inputs = new List<string>()
            {
                Goods.Sheeps,
            },
        },

        new Factory()
        {
            Name = "Paper Factory",
            Outputs = new List<string>()
            {
                Goods.Paper,
            },
            Inputs = new List<string>()
            {
                Goods.Wood, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Food Bar Factory",
            Outputs = new List<string>()
            {
                Goods.FoodBars,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Wheat, Goods.Corn, Goods.Rice,
            },
        },

        new Factory()
        {
            Name = "Book Factory",
            Outputs = new List<string>()
            {
                Goods.Books,
            },
            Inputs = new List<string>()
            {
                Goods.Paper, Goods.EnergyCells
            },
        },

        new Factory()
        {
            Name = "Plant Farm",
            Outputs = new List<string>()
            {
                Goods.Plants,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Rice Farm",
            Outputs = new List<string>()
            {
                Goods.Rice,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Potato Farm",
            Outputs = new List<string>()
            {
                Goods.Potatos,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Wheat Farm",
            Outputs = new List<string>()
            {
                Goods.Wheat,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Corn Farm",
            Outputs = new List<string>()
            {
                Goods.Corn,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Wood Farm",
            Outputs = new List<string>()
            {
                Goods.Wood,
            },
            Inputs = new List<string>()
            {
                Goods.Water, Goods.EnergyCells
            },
        },

        new Factory()
        {
            Name = "Fruit Farm",
            Outputs = new List<string>()
            {
                Goods.Fruits,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Tea Farm",
            Outputs = new List<string>()
            {
                Goods.Tea,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Vegetable Farm",
            Outputs = new List<string>()
            {
                Goods.Vegetable,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Fungus Farm",
            Outputs = new List<string>()
            {
                Goods.Fungus,
            },
            Inputs = new List<string>()
            {
                Goods.BioGas, Goods.Water, Goods.Minerals,
            },
        },

        new Factory()
        {
            Name = "Plastic Manafacturer",
            Outputs = new List<string>()
            {
                Goods.Plastic,
            },
            Inputs = new List<string>()
            {
                Goods.Oil, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Glass Manafacturer",
            Outputs = new List<string>()
            {
                Goods.Glass,
            },
            Inputs = new List<string>()
            {
                Goods.Ore, Goods.Crystals,
            },
        },

        new Factory()
        {
            Name = "Jewelry Manafacturer 1",
            Outputs = new List<string>()
            {
                Goods.Jewelry,
            },
            Inputs = new List<string>()
            {
                Goods.Platinum, Goods.Gem,
            },
        },

        new Factory()
        {
            Name = "Jewelry Manafacturer 2",
            Outputs = new List<string>()
            {
                Goods.Jewelry,
            },
            Inputs = new List<string>()
            {
                Goods.Gold, Goods.Diamonds,
            },
        },

        new Factory()
        {
            Name = "Oil Refinery",
            Outputs = new List<string>()
            {
                Goods.Oil,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.RawOil,
            },
        },

        new Factory()
        {
            Name = "Cattle Ranch 1",
            Outputs = new List<string>()
            {
                Goods.Cattle, Goods.BioGas,
            },
            Inputs = new List<string>()
            {
                Goods.Wheat, Goods.Oxygen, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Cattle Ranch 2",
            Outputs = new List<string>()
            {
                Goods.Cattle,
            },
            Inputs = new List<string>()
            {
                Goods.Corn, Goods.Oxygen, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Chemicals Factory",
            Outputs = new List<string>()
            {
                Goods.Chemicals, Goods.Adhesive, Goods.Coolant, Goods.Solvent, Goods.Acid,
            },
            Inputs = new List<string>()
            {
                Goods.Water, Goods.Nitrogen, Goods.Hydrogen, Goods.Oxygen, Goods.BioGas, Goods.Carbon, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Dairy Factory",
            Outputs = new List<string>()
            {
                Goods.Dairy, Goods.Leather,
            },
            Inputs = new List<string>()
            {
                Goods.Cattle,
            },
        },

        new Factory()
        {
            Name = "Distillery",
            Outputs = new List<string>()
            {
                Goods.Liquor,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Wheat, Goods.Water,
            },
        },

        new Factory()
        {
            Name = "Meat Factory",
            Outputs = new List<string>()
            {
                Goods.Meat, Goods.Leather,
            },
            Inputs = new List<string>()
            {
                Goods.Cattle,
            },
        },

        new Factory()
        {
            Name = "Sheep Ranch 1",
            Outputs = new List<string>()
            {
                Goods.Sheeps, Goods.BioGas,
            },
            Inputs = new List<string>()
            {
                Goods.Wheat, Goods.Oxygen, Goods.Water, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Sheep Ranch 2",
            Outputs = new List<string>()
            {
                Goods.Sheeps, Goods.BioGas,
            },
            Inputs = new List<string>()
            {
                Goods.Corn, Goods.Oxygen, Goods.Water, Goods.EnergyCells,
            },
        },

        #endregion

        #region Advanced Tech Factories

        new Factory()
        {
            Name = "Ammunition Factory 1",
            Outputs = new List<string>()
            {
                Goods.AmmunitionS, Goods.AmmunitionM, Goods.AmmunitionL,
            },
            Inputs = new List<string>()
            {
                Goods.Lead, Goods.Aluminium, Goods.Steel, Goods.Adhesive, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Ammunition Factory 2",
            Outputs = new List<string>()
            {
                Goods.Ammunition
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Chemicals, Goods.Paint,
            },
        },

        new Factory()
        {
            Name = "Brewery",
            Outputs = new List<string>()
            {
                Goods.Beer,
            },
            Inputs = new List<string>()
            {
                Goods.Water, Goods.Wheat, Goods.Fungus,
            },
        },

        new Factory()
        {
            Name = "Clothes Factory",
            Outputs = new List<string>()
            {
                Goods.Clothes,
            },
            Inputs = new List<string>()
            {
                Goods.Fabric,
            },
        },

        new Factory()
        {
            Name = "Cocoa Farm",
            Outputs = new List<string>()
            {
                Goods.Cocoa,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Water, Goods.Fertilizer,
            },
        },

        new Factory()
        {
            Name = "Coffee Farm",
            Outputs = new List<string>()
            {
                Goods.Coffee,
            },
            Inputs = new List<string>()
            {
                 Goods.EnergyCells, Goods.Water, Goods.Fertilizer,
            },
        },

        new Factory()
        {
            Name = "Computer Component Factory",
            Outputs = new List<string>()
            {
                Goods.Displays, Goods.TargetingCards, Goods.Processors,
            },
            Inputs = new List<string>()
            {
                Goods.Wire, Goods.Microchips, Goods.SemiConductors, Goods.Copper, Goods.Platinum, Goods.Gold,
            },
        },

        new Factory()
        {
            Name = "Conductor Factory",
            Outputs = new List<string>()
            {
                Goods.Conductors,
            },
            Inputs = new List<string>()
            {
                Goods.Zinc, Goods.Platinum, Goods.Gold, Goods.EnergyCells, Goods.Steel,
            },
        },

        new Factory()
        {
            Name = "Drone Factory",
            Outputs = new List<string>()
            {
                Goods.Drones,
            },
            Inputs = new List<string>()
            {
                Goods.Fuel, Goods.PlasmaCells, Goods.MetalPlates,
            },
        },

        new Factory()
        {
            Name = "Display Factory",
            Outputs = new List<string>()
            {
                Goods.Displays,
            },
            Inputs = new List<string>()
            {
                Goods.Glass, Goods.Microchips, Goods.SemiConductors, Goods.PlasmaCells,
            },
        },

        new Factory()
        {
            Name = "Electro Magnet Factory",
            Outputs = new List<string>()
            {
                Goods.ElectroMagnets,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Copper, Goods.Conductors, Goods.Transformators,
            },
        },

        new Factory()
        {
            Name = "Electromagnetic Charge Factory",
            Outputs = new List<string>()
            {
                Goods.ElectromagneticCharges,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyContainers, Goods.ElectroMagnets, Goods.EnergyTubes, Goods.Transformators,
            },
        },

        new Factory()
        {
            Name = "Energy Container Factory",
            Outputs = new List<string>()
            {
                Goods.EnergyContainers,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Transformators,
            },
        },

        new Factory()
        {
            Name = "Energy Generator Factory",
            Outputs = new List<string>()
            {
                Goods.EnergyGenerators,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Microchips, Goods.Conductors,
            },
        },

        new Factory()
        {
            Name = "Energy Inverter Factory",
            Outputs = new List<string>()
            {
                Goods.EnergyInverters,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyTubes, Goods.Conductors, Goods.Transformators,
            },
        },

        new Factory()
        {
            Name = "Energy Tube Factory",
            Outputs = new List<string>()
            {
                Goods.EnergyTubes,
            },
            Inputs = new List<string>()
            {
                Goods.Plastic, Goods.Steel, Goods.Platinum, Goods.EnergyCells, Goods.Neon,
            },
        },

        new Factory()
        {
            Name = "Explosive Charge Factory",
            Outputs = new List<string>()
            {
                Goods.ExplosiveCharges,
            },
            Inputs = new List<string>()
            {
                Goods.Fluorine, Goods.Steel, Goods.EnergyCells, Goods.Plastic, Goods.Chemicals, Goods.Acid, Goods.Adhesive,
            },
        },

        new Factory()
        {
            Name = "Food Factory",
            Outputs = new List<string>()
            {
                Goods.Food,
            },
            Inputs = new List<string>()
            {
                Goods.Wheat, Goods.Meat, Goods.Vegetable, Goods.Corn,
            },
        },

        new Factory()
        {
            Name = "Fusion Core Factory",
            Outputs = new List<string>()
            {
                Goods.FusionCores,
            },
            Inputs = new List<string>()
            {
                Goods.Hydrogen, Goods.Gold, Goods.PlasmaCells, Goods.Transformators, Goods.EnergyTubes,
            },
        },

        new Factory()
        {
            Name = "Gauss Rail Factory",
            Outputs = new List<string>()
            {
                Goods.GaussRails,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.ElectroMagnets, Goods.EnergyTubes, Goods.HighPressureTubes, Goods.Transformators,
            },
        },

        new Factory()
        {
            Name = "Gun Factory",
            Outputs = new List<string>()
            {
                Goods.Guns,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Ammunition, Goods.Aluminium, Goods.Plastic,
            },
        },

        new Factory()
        {
            Name = "High Pressure Tube Factory",
            Outputs = new List<string>()
            {
                Goods.HighPressureTubes,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Aluminium, Goods.Carbon, Goods.Adhesive, Goods.SteelTubes
            },
        },

        new Factory()
        {
            Name = "Laser Compressor Factory",
            Outputs = new List<string>()
            {
                Goods.LaserCompressors,
            },
            Inputs = new List<string>()
            {
                Goods.PlasmaCells, Goods.Transformators, Goods.EnergyTubes, Goods.Wire,
            },
        },

        new Factory()
        {
            Name = "Laser Head Factory",
            Outputs = new List<string>()
            {
                Goods.LaserHeads,
            },
            Inputs = new List<string>()
            {
                Goods.Glass, Goods.Conductors, Goods.Aluminium, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Laser Modulator Factory",
            Outputs = new List<string>()
            {
                Goods.LaserModulators,
            },
            Inputs = new List<string>()
            {
                Goods.Servos, Goods.EnergyTubes, Goods.Transformators, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Luxury Food Factory",
            Outputs = new List<string>()
            {
                Goods.LuxuryFood,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Wheat, Goods.Fruits, Goods.Spices, Goods.Wine
            },
        },

        new Factory()
        {
            Name = "Nanobot Factory",
            Outputs = new List<string>()
            {
                Goods.Nanobots,
            },
            Inputs = new List<string>()
            {
                Goods.Crystals, Goods.SemiConductors,
            },
        },

        new Factory()
        {
            Name = "Medical Supplies Factory",
            Outputs = new List<string>()
            {
                Goods.MedicalSupplies,
            },
            Inputs = new List<string>()
            {
                Goods.Water, Goods.Chemicals, Goods.Fabric, Goods.Zinc, Goods.Chlorine,
            },
        },

        new Factory()
        {
            Name = "Metal Plate Factory",
            Outputs = new List<string>()
            {
                Goods.MetalPlates,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Silver,
            },
        },

        new Factory()
        {
            Name = "Microchip Factory",
            Outputs = new List<string>()
            {
                Goods.Microchips,
            },
            Inputs = new List<string>()
            {
                Goods.Wire, Goods.SemiConductors, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Rocket Factory",
            Outputs = new List<string>()
            {
                Goods.Rockets,
            },
            Inputs = new List<string>()
            {
                Goods.Warheads, Goods.Fuel, Goods.Steel, Goods.Microchips,
            },
        },

        new Factory()
        {
            Name = "Paint Manufacturer",
            Outputs = new List<string>()
            {
                Goods.Paint,
            },
            Inputs = new List<string>()
            {
                Goods.Oil, Goods.Water, Goods.Chemicals, Goods.Solvent, Goods.Acid,
            },
        },

        new Factory()
        {
            Name = "Plasma Cell Factory",
            Outputs = new List<string>()
            {
                Goods.PlasmaCells,
            },
            Inputs = new List<string>()
            {
                Goods.EnergyCells, Goods.Steel, Goods.BioGas, Goods.Neon, Goods.Helium,
            },
        },

        new Factory()
        {
            Name = "Power Unit Factory",
            Outputs = new List<string>()
            {
                Goods.PowerUnits,
            },
            Inputs = new List<string>()
            {
                Goods.Transformators, Goods.EnergyCells, Goods.PlasmaCells,
            },
        },

        new Factory()
        {
            Name = "Processor Factory",
            Outputs = new List<string>()
            {
                Goods.Processors,
            },
            Inputs = new List<string>()
            {
                Goods.Microchips, Goods.SemiConductors, Goods.Copper, Goods.Platinum, Goods.Gold,
            },
        },

        new Factory()
        {
            Name = "Protein Factory",
            Outputs = new List<string>()
            {
                Goods.Proteins,
            },
            Inputs = new List<string>()
            {
                Goods.Meat, Goods.Dairy,
            },
        },

        new Factory()
        {
            Name = "Semi Conductor Manufacturer",
            Outputs = new List<string>()
            {
                Goods.SemiConductors,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Silicon, Goods.Gold, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Servo Factory",
            Outputs = new List<string>()
            {
                Goods.Servos,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Aluminium, Goods.Conductors, Goods.Plastic,
            },
        },

        new Factory()
        {
            Name = "Solar Panel Factory",
            Outputs = new List<string>()
            {
                Goods.SolarPanels,
            },
            Inputs = new List<string>()
            {
                Goods.SolarCells, Goods.Transformators,
            },
        },

        new Factory()
        {
            Name = "Spices Farm",
            Outputs = new List<string>()
            {
                Goods.Spices,
            },
            Inputs = new List<string>()
            {
                Goods.Water, Goods.Fertilizer, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Steel Tube Factory",
            Outputs = new List<string>()
            {
                Goods.SteelTubes,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Aluminium,
            },
        },

        new Factory()
        {
            Name = "Targeting Card Factory",
            Outputs = new List<string>()
            {
                Goods.TargetingCards,
            },
            Inputs = new List<string>()
            {
                Goods.Microchips, Goods.Copper, Goods.Processors,
            },
        },

        new Factory()
        {
            Name = "Tool Factory",
            Outputs = new List<string>()
            {
                Goods.Tools,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Platinum, Goods.Silicon, Goods.Aluminium, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Transformator Factory",
            Outputs = new List<string>()
            {
                Goods.Transformators,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Plastic, Goods.Silicon, Goods.Silver, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Turbine Factory",
            Outputs = new List<string>()
            {
                Goods.Turbines,
            },
            Inputs = new List<string>()
            {
                Goods.Servos, Goods.Steel, Goods.Coolant, Goods.PowerUnits,
            },
        },

        new Factory()
        {
            Name = "Warhead Factory",
            Outputs = new List<string>()
            {
                Goods.Warheads,
            },
            Inputs = new List<string>()
            {
                Goods.Conductors, Goods.Chemicals, Goods.MetalPlates,
            },
        },

        new Factory()
        {
            Name = "Wine Factory",
            Outputs = new List<string>()
            {
                Goods.Wine,
            },
            Inputs = new List<string>()
            {
                Goods.Fruits, Goods.Fungus,
            },
        },

        new Factory()
        {
            Name = "Wire Manufacturer",
            Outputs = new List<string>()
            {
                Goods.Wire,
            },
            Inputs = new List<string>()
            {
                Goods.Plastic, Goods.Steel, Goods.Gold,
            },
        },

        #endregion

        #region High Tech Factories

        new Factory()
        {
            Name = "Accelerator Factory",
            Outputs = new List<string>()
            {
                Goods.NeutronAccelerators, Goods.ProtonAccelerators, Goods.ElectronAccelerators,
            },
            Inputs = new List<string>()
            {
                Goods.Turbines, Goods.PlasmaCells, Goods.FusionGenerators, Goods.EnergyTubes, Goods.HighPressureTubes, Goods.Conductors, Goods.GaussRails,
            },
        },

        new Factory()
        {
            Name = "Anti-Grav Generator Factory",
            Outputs = new List<string>()
            {
                Goods.AntigravGenerators,
            },
            Inputs = new List<string>()
            {
                Goods.ElectroMagnets, Goods.Servos, Goods.Wire, Goods.AntigravUnits, Goods.EnergyGenerators,
            },
        },

        new Factory()
        {
            Name = "Antigrav Unit Factory",
            Outputs = new List<string>()
            {
                Goods.AntigravUnits,
            },
            Inputs = new List<string>()
            {
                Goods.PowerUnits, Goods.Processors, Goods.EnergyCells,
            },
        },

        new Factory()
        {
            Name = "Body Armor Factory",
            Outputs = new List<string>()
            {
                Goods.BodyArmors,
            },
            Inputs = new List<string>()
            {
                Goods.MetalPlates, Goods.Coolant, Goods.Teleporter, Goods.AntigravUnits, Goods.Carbon, Goods.Nanobots,
            },
        },

        new Factory()
        {
            Name = "Computation Mainframe Factory",
            Outputs = new List<string>()
            {
                Goods.ComputationMainframes,
            },
            Inputs = new List<string>()
            {
                Goods.Processors, Goods.PowerUnits, Goods.Microchips, Goods.Displays, Goods.Wire,
            },
        },

        new Factory()
        {
            Name = "Drill Factory",
            Outputs = new List<string>()
            {
                Goods.Drills,
            },
            Inputs = new List<string>()
            {
                Goods.LaserHeads, Goods.Processors, Goods.Steel, Goods.Diamonds,
            },
        },

        new Factory()
        {
            Name = "Force Generator Factory",
            Outputs = new List<string>()
            {
                Goods.ForceGenerators,
            },
            Inputs = new List<string>()
            {
                Goods.ElectroMagnets, Goods.Steel, Goods.Plastic, Goods.Nanobots, Goods.EnergyGenerators,
            },
        },

        new Factory()
        {
            Name = "Fusion Generator Factory",
            Outputs = new List<string>()
            {
                Goods.FusionGenerators,
            },
            Inputs = new List<string>()
            {
                Goods.FusionCores, Goods.Steel, Goods.PlasmaCells, Goods.PowerUnits,
            },
        },

        new Factory()
        {
            Name = "Mining Robot Factory",
            Outputs = new List<string>()
            {
                Goods.MiningRobots,
            },
            Inputs = new List<string>()
            {
                Goods.PowerUnits, Goods.Processors, Goods.Displays, Goods.Nanobots, Goods.Drills, Goods.Coolant, Goods.Teleporter,
            },
        },

        new Factory()
        {
            Name = "Satellite Factory",
            Outputs = new List<string>()
            {
                Goods.Satellites,
            },
            Inputs = new List<string>()
            {
                Goods.SolarPanels, Goods.Processors, Goods.Displays, Goods.EnergyContainers, Goods.SteelTubes,
            },
        },

        new Factory()
        {
            Name = "Targeting System Factory",
            Outputs = new List<string>()
            {
                Goods.TargetingSystems,
            },
            Inputs = new List<string>()
            {
                Goods.TargetingCards, Goods.Processors, Goods.EnergyCells, Goods.Conductors, Goods.Wire,
            },
        },

        new Factory()
        {
            Name = "Teleporter Factory",
            Outputs = new List<string>()
            {
                Goods.Teleporter,
            },
            Inputs = new List<string>()
            {
                Goods.MetalPlates, Goods.PowerUnits, Goods.AntigravUnits, Goods.PlasmaCells, Goods.Conductors, Goods.Transformators,
            },
        },

        new Factory()
        {
            Name = "Tesla Coil Factory",
            Outputs = new List<string>()
            {
                Goods.MilitaryTeslaCoils, Goods.IndustrialTeslaCoils,
            },
            Inputs = new List<string>()
            {
                Goods.Steel, Goods.Copper, Goods.FusionCores, Goods.Plastic,
            },
        },

        new Factory()
        {
            Name = "Vehicle Factory",
            Outputs = new List<string>()
            {
                Goods.Vehicles,
            },
            Inputs = new List<string>()
            {
                Goods.Rubber, Goods.PowerUnits, Goods.EnergyGenerators, Goods.MetalPlates, Goods.AntigravUnits, Goods.Displays,
            },
        },

        new Factory()
        {
            Name = "War Robot Factory",
            Outputs = new List<string>()
            {
                Goods.WarRobots,
            },
            Inputs = new List<string>()
            {
                Goods.PowerUnits, Goods.Processors, Goods.Displays, Goods.Nanobots, Goods.Guns, Goods.Teleporter, Goods.Coolant,
            },
        },

        #endregion

        #region Consumers

        #endregion

        #region Other

        #endregion
    };

    public string Name { get; set; }
    public List<string> Outputs { get; set; }
    public List<string> Inputs { get; set; }

    public string GenerateChain(bool start = true)
    {
        string chain = string.Empty;

        foreach (var input in Inputs)
        {
            var provider = Factories.Where(x => x.Outputs.Contains(input)).OrderBy(x => x.Inputs.Count).FirstOrDefault();
            string line = $"\"{ provider.Name }\" -> \"{ Name }\" \r\n%";

            if (!chain.Contains(line.Trim()))
            {
                chain += line.Trim();
            }

            if (provider.Inputs.Any())
            {
                chain += provider.GenerateChain(false);
            }
        }

        if (start)
        {
            string finalChain = "digraph G {\r\n";

            foreach (var line in chain.Split('%').Distinct())
            {
                finalChain += line;
            }

            finalChain += "}";

            return finalChain;
        }

        return chain;
    }
}

public static class Goods
{
    public static string Acid { get; } = "Acid";
    public static string AcronDrugs { get; } = "Acron Drugs";
    public static string Adhesive { get; } = "Adhesive";
    public static string Aluminium { get; } = "Aluminium";
    public static string Ammunition { get; } = "Ammunition";
    public static string AmmunitionL { get; } = "Ammunition L";
    public static string AmmunitionM { get; } = "Ammunition M";
    public static string AmmunitionS { get; } = "Ammunition S";
    public static string AntigravGenerators { get; } = "Antigrav Generators";
    public static string AntigravUnits { get; } = "Antigrav Units";
    public static string Beer { get; } = "Beer";
    public static string BioGas { get; } = "Bio Gas";
    public static string BodyArmors { get; } = "Body Armors";
    public static string Books { get; } = "Books";
    public static string Carbon { get; } = "Carbon";
    public static string Cattle { get; } = "Cattle";
    public static string Chemicals { get; } = "Chemicals";
    public static string Chlorine { get; } = "Chlorine";
    public static string Clothes { get; } = "Clothes";
    public static string Coal { get; } = "Coal";
    public static string Cocoa { get; } = "Cocoa";
    public static string Coffee { get; } = "Coffee";
    public static string ComputationMainframes { get; } = "Computation Mainframes";
    public static string Conductors { get; } = "Conductors";
    public static string Coolant { get; } = "Coolant";
    public static string Copper { get; } = "Copper";
    public static string Corn { get; } = "Corn";
    public static string Crystals { get; } = "Crystals";
    public static string Dairy { get; } = "Dairy";
    public static string Diamonds { get; } = "Diamonds";
    public static string Displays { get; } = "Displays";
    public static string Drills { get; } = "Drills";
    public static string Drones { get; } = "Drones";
    public static string ElectroMagnets { get; } = "Electro Magnets";
    public static string ElectromagneticCharges { get; } = "Electromagnetic Charges";
    public static string ElectronAccelerators { get; } = "Electron Accelerators";
    public static string EnergyCells { get; } = "Energy Cells";
    public static string EnergyContainers { get; } = "Energy Containers";
    public static string EnergyGenerators { get; } = "Energy Generators";
    public static string EnergyInverters { get; } = "Energy Inverters";
    public static string EnergyTubes { get; } = "Energy Tubes";
    public static string ExplosiveCharges { get; } = "Explosive Charges";
    public static string Fabric { get; } = "Fabric";
    public static string Fertilizer { get; } = "Fertilizer";
    public static string Fishes { get; } = "Fishes";
    public static string Fluorine { get; } = "Fluorine";
    public static string Food { get; } = "Food";
    public static string FoodBars { get; } = "Food Bars";
    public static string ForceGenerators { get; } = "Force Generators";
    public static string Fruits { get; } = "Fruits";
    public static string Fuel { get; } = "Fuel";
    public static string Fungus { get; } = "Fungus";
    public static string FusionCores { get; } = "Fusion Cores";
    public static string FusionGenerators { get; } = "Fusion Generators";
    public static string GaussRails { get; } = "Gauss Rails";
    public static string Gem { get; } = "Gem";
    public static string Glass { get; } = "Glass";
    public static string Gold { get; } = "Gold";
    public static string Guns { get; } = "Guns";
    public static string Helium { get; } = "Helium";
    public static string HighCapacityLenses { get; } = "High Capacity Lenses";
    public static string HighPressureTubes { get; } = "High Pressure Tubes";
    public static string Hydrogen { get; } = "Hydrogen";
    public static string IndustrialTeslaCoils { get; } = "Industrial Tesla Coils";
    public static string Jewelry { get; } = "Jewelry";
    public static string LaserCompressors { get; } = "Laser Compressors";
    public static string LaserHeads { get; } = "Laser Heads";
    public static string LaserModulators { get; } = "Laser Modulators";
    public static string Lead { get; } = "Lead";
    public static string Leather { get; } = "Leather";
    public static string Liquor { get; } = "Liquor";
    public static string LuxuryFood { get; } = "Luxury Food";
    public static string Meat { get; } = "Meat";
    public static string MedicalSupplies { get; } = "Medical Supplies";
    public static string MetalPlates { get; } = "Metal Plates";
    public static string Microchips { get; } = "Microchips";
    public static string MilitaryTeslaCoils { get; } = "Military Tesla Coils";
    public static string Minerals { get; } = "Minerals";
    public static string MiningRobots { get; } = "Mining Robots";
    public static string MornDrugs { get; } = "Morn Drugs";
    public static string Nanobots { get; } = "Nanobots";
    public static string Neon { get; } = "Neon";
    public static string NeutronAccelerators { get; } = "Neutron Accelerators";
    public static string Nitrogen { get; } = "Nitrogen";
    public static string Oil { get; } = "Oil";
    public static string Ore { get; } = "Ore";
    public static string Oxygen { get; } = "Oxygen";
    public static string Paint { get; } = "Paint";
    public static string Paper { get; } = "Paper";
    public static string Plankton { get; } = "Plankton";
    public static string Plants { get; } = "Plants";
    public static string PlasmaCells { get; } = "Plasma Cells";
    public static string Plastic { get; } = "Plastic";
    public static string Platinum { get; } = "Platinum";
    public static string Potatos { get; } = "Potatos";
    public static string PowerUnits { get; } = "Power Units";
    public static string Processors { get; } = "Processors";
    public static string Proteins { get; } = "Proteins";
    public static string ProtonAccelerators { get; } = "Proton Accelerators";
    public static string RawOil { get; } = "Raw Oil";
    public static string Rice { get; } = "Rice";
    public static string Rockets { get; } = "Rockets";
    public static string Rubber { get; } = "Rubber";
    public static string Satellites { get; } = "Satellites";
    public static string ScrapMetal { get; } = "Scrap Metal";
    public static string SemiConductors { get; } = "Semi Conductors";
    public static string Servos { get; } = "Servos";
    public static string Sheeps { get; } = "Sheeps";
    public static string Silicon { get; } = "Silicon";
    public static string Silver { get; } = "Silver";
    public static string Slaves { get; } = "Slaves";
    public static string SolarCells { get; } = "Solar Cells";
    public static string SolarPanels { get; } = "Solar Panels";
    public static string Solvent { get; } = "Solvent";
    public static string Spices { get; } = "Spices";
    public static string Steel { get; } = "Steel";
    public static string SteelTubes { get; } = "Steel Tubes";
    public static string TargetingCards { get; } = "Targeting Cards";
    public static string TargetingSystems { get; } = "Targeting Systems";
    public static string Tea { get; } = "Tea";
    public static string Teleporter { get; } = "Teleporter";
    public static string Tools { get; } = "Tools";
    public static string ToxicWaste { get; } = "Toxic Waste";
    public static string Transformators { get; } = "Transformators";
    public static string Turbines { get; } = "Turbines";
    public static string Vegetable { get; } = "Vegetable";
    public static string Vehicles { get; } = "Vehicles";
    public static string WarRobots { get; } = "War Robots";
    public static string Warheads { get; } = "Warheads";
    public static string Water { get; } = "Water";
    public static string Wheat { get; } = "Wheat";
    public static string Wine { get; } = "Wine";
    public static string Wire { get; } = "Wire";
    public static string Wood { get; } = "Wood";
    public static string Zinc { get; } = "Zinc";
}