using System.ComponentModel;

namespace SysBot.Pokemon;

public class FossilSettings
{
    private const string Fossil = nameof(Fossil);
    private const string Counts = nameof(Counts);
    public override string ToString() => "Fossil Bot Settings";

    [Category(Fossil), Description("Species of fossil Pokémon to hunt for.")]
    public FossilSpecies Species { get; set; } = FossilSpecies.Dracozolt;

    /// <summary>
    /// Toggle for injecting fossil pieces.
    /// </summary>
    [Category(Fossil), Description("Toggle for injecting fossil pieces.")]
    public bool InjectWhenEmpty { get; set; }

    [Category(Fossil), Description("When enabled, the bot will only stop when encounter has a Scale of XXXS or XXXL.")]
    public bool MinMaxScaleOnly { get; set; } = false;
}