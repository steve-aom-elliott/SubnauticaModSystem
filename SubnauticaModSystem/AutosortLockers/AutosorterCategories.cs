﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UnityEngine;

namespace AutosortLockers
{
	[Serializable]
	public enum AutoSorterCategory
	{
		None,
		Food,
		Water,
		PlantsAndSeeds,
		Metals,
		Electronics,
		Batteries,
		NaturalMaterials,
		SyntheticMaterials,
		CrystalMaterials,
		Fish,
		Eggs,
		Tools,
		Equipment,
		MysteriousTablets,
		ScannerRoomUpgrades,
		GeneralUpgrades,
		SeamothUpgrades,
		PrawnSuitUpgrades,
		CyclopsUpgrades,
		Torpedoes,
		AlterraStuff,
	}

	public static class AutosorterCategoryData
	{
		public static List<TechType> Fish = new List<TechType> {
			TechType.Bladderfish,
			TechType.Boomerang,
			TechType.LavaBoomerang,
			TechType.Eyeye,
			TechType.LavaEyeye,
			TechType.GarryFish,
			TechType.HoleFish,
			TechType.Hoopfish,
			TechType.Spinefish,
			TechType.Hoverfish,
			TechType.Oculus,
			TechType.Peeper,
			TechType.Reginald,
			TechType.Spadefish,
		};

		public static List<TechType> AlterraArtifacts = new List<TechType> {
			TechType.LabContainer,
			TechType.LabContainer2,
			TechType.LabContainer3,
			TechType.ArcadeGorgetoy,
			TechType.Cap1,
			TechType.Cap2,
			TechType.LabEquipment1,
			TechType.LabEquipment2,
			TechType.LabEquipment3,
			TechType.LEDLightFragment,
			TechType.StarshipSouvenir,
			TechType.Poster,
			TechType.PosterAurora,
			TechType.PosterExoSuit1,
			TechType.PosterExoSuit2,
			TechType.PosterKitty,
		};

		public static List<TechType> MysteriousTablets = new List<TechType> {
			TechType.PrecursorKey_Blue,
			TechType.PrecursorKey_Orange,
			TechType.PrecursorKey_Purple,
		};

		public static List<TechType> CreatureEggs = new List<TechType> {
			TechType.BonesharkEgg,
			TechType.CrabsnakeEgg,
			TechType.CrabsquidEgg,
			TechType.CrashEgg,
			TechType.CutefishEgg,
			TechType.GasopodEgg,
			TechType.JellyrayEgg,
			TechType.JumperEgg,
			TechType.LavaLizardEgg,
			TechType.MesmerEgg,
			TechType.RabbitrayEgg,
			TechType.ReefbackEgg,
			TechType.SandsharkEgg,
			TechType.ShockerEgg,
			TechType.SpadefishEgg,
			TechType.StalkerEgg,
			TechType.GrandReefsEgg,
			TechType.GrassyPlateausEgg,
			TechType.KelpForestEgg,
			TechType.KooshZoneEgg,
			TechType.LavaZoneEgg,
			TechType.MushroomForestEgg,
			TechType.SafeShallowsEgg,
			TechType.TwistyBridgesEgg,
			TechType.RabbitrayEggUndiscovered,
			TechType.JellyrayEggUndiscovered,
			TechType.StalkerEggUndiscovered,
			TechType.ReefbackEggUndiscovered,
			TechType.JumperEggUndiscovered,
			TechType.BonesharkEggUndiscovered,
			TechType.GasopodEggUndiscovered,
			TechType.MesmerEggUndiscovered,
			TechType.SandsharkEggUndiscovered,
			TechType.ShockerEggUndiscovered,
			TechType.GenericEgg,
			TechType.CrashEgg,
			TechType.CrashEggUndiscovered,
			TechType.CrabsquidEgg,
			TechType.CrabsquidEggUndiscovered,
			TechType.CutefishEgg,
			TechType.CutefishEggUndiscovered,
			TechType.LavaLizardEgg,
			TechType.LavaLizardEggUndiscovered,
			TechType.CrabsnakeEggUndiscovered,
			TechType.SpadefishEggUndiscovered
		};

		public static List<TechType> Food = new List<TechType> {
			TechType.CookedBladderfish,
			TechType.CookedBoomerang,
			TechType.CookedEyeye,
			TechType.CookedGarryFish,
			TechType.CookedHoleFish,
			TechType.CookedHoopfish,
			TechType.CookedHoverfish,
			TechType.CookedLavaBoomerang,
			TechType.CookedLavaEyeye,
			TechType.CookedOculus,
			TechType.CookedPeeper,
			TechType.CookedReginald,
			TechType.CookedSpadefish,
			TechType.CookedSpinefish,
			TechType.CuredBladderfish,
			TechType.CuredBoomerang,
			TechType.CuredEyeye,
			TechType.CuredGarryFish,
			TechType.CuredHoleFish,
			TechType.CuredHoopfish,
			TechType.CuredHoverfish,
			TechType.CuredLavaBoomerang,
			TechType.CuredLavaEyeye,
			TechType.CuredOculus,
			TechType.CuredPeeper,
			TechType.CuredReginald,
			TechType.CuredSpadefish,
			TechType.CuredSpinefish,
			TechType.NutrientBlock,
			TechType.Snack1,
			TechType.Snack2,
			TechType.Snack3,
			TechType.BulboTreePiece,
			TechType.HangingFruit,
			TechType.Melon,
			TechType.PurpleVegetable,
		};

		public static List<TechType> Water = new List<TechType> {
			TechType.BigFilteredWater,
			TechType.Coffee,
			TechType.DisinfectedWater,
			TechType.FilteredWater,
			TechType.StillsuitWater,
		};

		public static List<TechType> ScannerRoomUpgrades = new List<TechType> {
			TechType.MapRoomUpgradeScanRange,
			TechType.MapRoomUpgradeScanSpeed,
			TechType.MapRoomCamera,
		};

		public static List<TechType> CyclopsUpgrades = new List<TechType> {
			TechType.CyclopsDecoyModule,
			TechType.CyclopsFireSuppressionModule,
			TechType.CyclopsHullModule1,
			TechType.CyclopsHullModule2,
			TechType.CyclopsHullModule3,
			TechType.CyclopsSeamothRepairModule,
			TechType.CyclopsShieldModule,
			TechType.CyclopsSonarModule,
			TechType.CyclopsThermalReactorModule,
		};

		public static List<TechType> PrawnSuitUpgrades = new List<TechType> {
			TechType.ExoHullModule1,
			TechType.ExoHullModule2,
			TechType.ExosuitDrillArmModule,
			TechType.ExosuitGrapplingArmModule,
			TechType.ExosuitJetUpgradeModule,
			TechType.ExosuitPropulsionArmModule,
			TechType.ExosuitThermalReactorModule,
			TechType.ExosuitTorpedoArmModule,
		};

		public static List<TechType> SeamothUpgrades = new List<TechType> {
			TechType.SeamothElectricalDefense,
			TechType.SeamothReinforcementModule,
			TechType.SeamothSolarCharge,
			TechType.SeamothSonarModule,
			TechType.SeamothTorpedoModule,
		};

		public static List<TechType> GeneralUpgrades = new List<TechType> {
			TechType.HullReinforcementModule,
			TechType.PowerUpgradeModule,
			TechType.VehicleArmorPlating,
			TechType.VehicleHullModule1,
			TechType.VehicleHullModule2,
			TechType.VehicleHullModule3,
			TechType.VehiclePowerUpgradeModule,
			TechType.VehicleStorageModule,
		};

		public static List<TechType> Equipment = new List<TechType> {
			TechType.MapRoomHUDChip,
			TechType.Rebreather,
			TechType.Compass,
			TechType.Fins,
			TechType.HighCapacityTank,
			TechType.PlasteelTank,
			TechType.RadiationGloves,
			TechType.RadiationHelmet,
			TechType.RadiationSuit,
			TechType.ReinforcedDiveSuit,
			TechType.ReinforcedGloves,
			TechType.Stillsuit,
			TechType.SwimChargeFins,
			TechType.Tank,
			TechType.UltraGlideFins,
		};

		public static List<TechType> Tools = new List<TechType> {
			TechType.AirBladder,
			TechType.Beacon,
			TechType.Builder,
			TechType.CyclopsDecoy,
			TechType.DiamondBlade,
			TechType.DiveReel,
			TechType.DoubleTank,
			TechType.FireExtinguisher,
			TechType.Flare,
			TechType.Flashlight,
			TechType.Gravsphere,
			TechType.HeatBlade,
			TechType.Knife,
			TechType.LaserCutter,
			TechType.LEDLight,
			TechType.Pipe,
			TechType.PipeSurfaceFloater,
			TechType.PropulsionCannon,
			TechType.RepulsionCannon,
			TechType.Scanner,
			TechType.Seaglide,
			TechType.SmallStorage,
			TechType.StasisRifle,
			TechType.Welder,
			TechType.LuggageBag,
		};

		public static List<TechType> Torpedoes = new List<TechType> {
			TechType.GasTorpedo,
			TechType.WhirlpoolTorpedo
		};

		public static List<TechType> PlantsAndSeeds = new List<TechType> {
			TechType.AcidMushroomSpore,
			TechType.BluePalmSeed,
			TechType.BulboTreePiece,
			TechType.CreepvinePiece,
			TechType.CreepvineSeedCluster,
			TechType.EyesPlantSeed,
			TechType.FernPalmSeed,
			TechType.GabeSFeatherSeed,
			TechType.HangingFruit,
			TechType.JellyPlantSeed,
			TechType.KooshChunk,
			TechType.Melon,
			TechType.MelonSeed,
			TechType.MembrainTreeSeed,
			TechType.OrangeMushroomSpore,
			TechType.OrangePetalsPlantSeed,
			TechType.PinkFlowerSeed,
			TechType.PinkMushroomSpore,
			TechType.PurpleBrainCoralPiece,
			TechType.PurpleBranchesSeed,
			TechType.PurpleFanSeed,
			TechType.PurpleRattleSpore,
			TechType.PurpleStalkSeed,
			TechType.PurpleTentacleSeed,
			TechType.PurpleVasePlantSeed,
			TechType.PurpleVegetable,
			TechType.RedBasketPlantSeed,
			TechType.RedBushSeed,
			TechType.RedConePlantSeed,
			TechType.RedGreenTentacleSeed,
			TechType.RedRollPlantSeed,
			TechType.SeaCrownSeed,
			TechType.ShellGrassSeed,
			TechType.SmallFanSeed,
			TechType.SmallMelon,
			TechType.SnakeMushroomSpore,
			TechType.SpikePlantSeed,
			TechType.SpottedLeavesPlantSeed,
			TechType.WhiteMushroomSpore,
		};

		public static List<TechType> Metals = new List<TechType> {
			TechType.Copper,
			TechType.Gold,
			TechType.Lead,
			TechType.Lithium,
			TechType.Magnetite,
			TechType.ScrapMetal,
			TechType.Nickel,
			TechType.PlasteelIngot,
			TechType.Silver,
			TechType.Titanium,
			TechType.TitaniumIngot,
		};

		public static List<TechType> NaturalMaterials = new List<TechType> {
			TechType.GasPod,
			TechType.CoralChunk,
			TechType.WhiteMushroom,
			TechType.AcidMushroom,
			TechType.JeweledDiskPiece,
			TechType.BloodOil,
			TechType.CrashPowder,
			TechType.Salt,
			TechType.SeaTreaderPoop,
			TechType.StalkerTooth,
			TechType.JellyPlant,
		};

		public static List<TechType> Electronics = new List<TechType> {
			TechType.AdvancedWiringKit,
			TechType.ComputerChip,
			TechType.CopperWire,
			TechType.DepletedReactorRod,
			TechType.ReactorRod,
			TechType.WiringKit,
		};

		public static List<TechType> SyntheticMaterials = new List<TechType> {
			TechType.Aerogel,
			TechType.AramidFibers,
			TechType.Benzene,
			TechType.Bleach,
			TechType.EnameledGlass,
			TechType.FiberMesh,
			TechType.Glass,
			TechType.HatchingEnzymes,
			TechType.HydrochloricAcid,
			TechType.Lubricant,
			TechType.Polyaniline,
			TechType.PrecursorIonCrystal,
			TechType.Silicone,
		};

		public static List<TechType> CrystalMaterials = new List<TechType> {
			TechType.AluminumOxide,
			TechType.Diamond,
			TechType.Kyanite,
			TechType.Quartz,
			TechType.Sulphur,
			TechType.UraniniteCrystal,
		};

		public static List<TechType> Batteries = new List<TechType> {
			TechType.Battery,
			TechType.PowerCell,
			TechType.PrecursorIonBattery,
			TechType.PrecursorIonPowerCell,
		};

		public static List<TechType> IndividualItems = new List<TechType> {
			TechType.GasPod,
			TechType.CoralChunk,
			TechType.WhiteMushroom,
			TechType.AcidMushroom,
			TechType.JeweledDiskPiece,
			TechType.AdvancedWiringKit,
			TechType.Aerogel,
			TechType.AluminumOxide,
			TechType.AramidFibers,
			TechType.Benzene,
			TechType.Bleach,
			TechType.BloodOil,
			TechType.ComputerChip,
			TechType.Copper,
			TechType.CopperWire,
			TechType.CrashPowder,
			TechType.DepletedReactorRod,
			TechType.Diamond,
			TechType.EnameledGlass,
			TechType.FiberMesh,
			TechType.FirstAidKit,
			TechType.Glass,
			TechType.Gold,
			TechType.HatchingEnzymes,
			TechType.HydrochloricAcid,
			TechType.JellyPlant,
			TechType.Kyanite,
			TechType.Lead,
			TechType.Lithium,
			TechType.Lubricant,
			TechType.Magnetite,
			TechType.ScrapMetal,
			TechType.Nickel,
			TechType.PlasteelIngot,
			TechType.Polyaniline,
			TechType.PrecursorIonCrystal,
			TechType.Quartz,
			TechType.ReactorRod,
			TechType.Salt,
			TechType.SeaTreaderPoop,
			TechType.Silicone,
			TechType.Silver,
			TechType.StalkerTooth,
			TechType.Sulphur,
			TechType.Titanium,
			TechType.TitaniumIngot,
			TechType.UraniniteCrystal,
			TechType.WiringKit,
			TechType.Battery,
			TechType.PowerCell,
			TechType.PrecursorIonBattery,
			TechType.PrecursorIonPowerCell,
		};
	}

	[Serializable]
	public class AutosorterFilter
	{
		public AutoSorterCategory Category;
		public List<TechType> Types = new List<TechType>();

		public bool IsCategory()
		{
			return Category != AutoSorterCategory.None;
		}

		public string GetString()
		{
			if (IsCategory())
			{
				return System.Text.RegularExpressions.Regex.Replace(Category.ToString(), "[A-Z]", " $0").Trim();
			}
			else
			{
				var textInfo = (new CultureInfo("en-US", false)).TextInfo;
				return textInfo.ToTitleCase(Language.main.Get(Types[0]));
			}
		}

		public bool IsTechTypeAllowed(TechType techType)
		{
			return Types.Contains(techType);
		}

		public bool IsSame(AutosorterFilter other)
		{
			return Category == other.Category && Types.Count > 0 && Types.Count == other.Types.Count && Types[0] == other.Types[0];
		}
	}

	public static class AutosorterList
	{
		private static List<AutosorterFilter> entries;

		public static List<AutosorterFilter> GetEntries()
		{
			if (entries == null)
			{
				InitializeEntries();
			}
			return entries;
		}

		private static List<TechType> GetListForCategory(AutoSorterCategory category)
		{
			switch (category)
			{
				default:
				case AutoSorterCategory.None: return AutosorterCategoryData.IndividualItems;

				case AutoSorterCategory.Food: return AutosorterCategoryData.Food;
				case AutoSorterCategory.Water: return AutosorterCategoryData.Water;
				case AutoSorterCategory.PlantsAndSeeds: return AutosorterCategoryData.PlantsAndSeeds;
				case AutoSorterCategory.Metals: return AutosorterCategoryData.Metals;
				case AutoSorterCategory.NaturalMaterials: return AutosorterCategoryData.NaturalMaterials;
				case AutoSorterCategory.SyntheticMaterials: return AutosorterCategoryData.SyntheticMaterials;
				case AutoSorterCategory.Electronics: return AutosorterCategoryData.Electronics;
				case AutoSorterCategory.CrystalMaterials: return AutosorterCategoryData.CrystalMaterials;
				case AutoSorterCategory.Batteries: return AutosorterCategoryData.Batteries;
				case AutoSorterCategory.Fish: return AutosorterCategoryData.Fish;
				case AutoSorterCategory.Eggs: return AutosorterCategoryData.CreatureEggs;
				case AutoSorterCategory.Tools: return AutosorterCategoryData.Tools;
				case AutoSorterCategory.Equipment: return AutosorterCategoryData.Equipment;
				case AutoSorterCategory.MysteriousTablets: return AutosorterCategoryData.MysteriousTablets;
				case AutoSorterCategory.ScannerRoomUpgrades: return AutosorterCategoryData.ScannerRoomUpgrades;
				case AutoSorterCategory.GeneralUpgrades: return AutosorterCategoryData.GeneralUpgrades;
				case AutoSorterCategory.SeamothUpgrades: return AutosorterCategoryData.SeamothUpgrades;
				case AutoSorterCategory.PrawnSuitUpgrades: return AutosorterCategoryData.PrawnSuitUpgrades;
				case AutoSorterCategory.CyclopsUpgrades: return AutosorterCategoryData.CyclopsUpgrades;
				case AutoSorterCategory.Torpedoes: return AutosorterCategoryData.Torpedoes;
				case AutoSorterCategory.AlterraStuff: return AutosorterCategoryData.AlterraArtifacts;
			}
		}

		private static void InitializeEntries()
		{
			entries = new List<AutosorterFilter>();
			var distinctEntires = new HashSet<TechType>();

			foreach (AutoSorterCategory value in Enum.GetValues(typeof(AutoSorterCategory)))
			{
				if (value == AutoSorterCategory.None)
				{
					foreach (TechType type in AutosorterCategoryData.IndividualItems)
					{
						distinctEntires.Add(type);
						AddEntry(AutoSorterCategory.None, type);
					}
				}
				else
				{
					var items = GetListForCategory(value);
					AddEntry(value, items);

					if (Mod.config.ShowAllItems)
					{
						foreach (TechType type in items)
						{
							if (!distinctEntires.Contains(type))
							{
								distinctEntires.Add(type);
								AddEntry(AutoSorterCategory.None, type);
							}
						}
					}
				}
			}

			entries.Sort((AutosorterFilter a, AutosorterFilter b) => {
				if (a.Category == b.Category)
				{
					return string.Compare(a.GetString(), b.GetString());
				}
				return a.Category.CompareTo(b.Category);
			});
		}

		private static void AddEntry(AutoSorterCategory category, List<TechType> types)
		{
			entries.Add(new AutosorterFilter {
				Category = category,
				Types = types
			});
		}

		private static void AddEntry(AutoSorterCategory category, TechType type)
		{
			entries.Add(new AutosorterFilter {
				Category = category,
				Types = new List<TechType> { type }
			});
		}
	}
}
