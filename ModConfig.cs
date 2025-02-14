// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global

namespace ItemExtensions;

internal class ModConfig
{
    public bool EatingAnimations { get; set; } = true;
    public bool FishPond { get; set; } = true;
    public bool MenuActions { get; set; } = true;
    public bool MixedSeeds { get; set; } = true;
    public bool OnBehavior { get; set; } = true;
    public bool Panning { get; set; } = true;
    public bool Resources { get; set; } = true;
    public bool ResourcesMtn { get; set; } = true;
    public bool ResourcesVolcano { get; set; } = true;
    public bool ShopTrades { get; set; } = true;
    public bool TrainDrops { get; set; } = true;
    public bool TerrainFeatures { get; set; } = true;
    public bool QualityChanges { get; set; } = true;
    public bool Treasure { get; set; } = true;
    public int MaxClumpsInQuarry { get; set; } = 10;
    public int MaxClumpsInQiCave { get; set; } = 6;
    public double ChanceForStairs { get; set; } = 0.1;
}