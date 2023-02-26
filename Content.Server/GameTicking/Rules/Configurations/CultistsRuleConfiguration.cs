using Content.Server.GameTicking.Rules.Configurations;
using Content.Shared.Dataset;
using Content.Shared.Humanoid.Prototypes;
using Content.Shared.Roles;
using Robust.Shared.Audio;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;
using Robust.Shared.Utility;

namespace Content.Server.GameTicking.Rules.Configurations;

public sealed class CultistsRuleConfiguration : GameRuleConfiguration
{
    public override string Id => "Cultists";

    [DataField("minPlayers")]
    public int MinPlayers = 0;

    [DataField("playersPerCultist")]
    public int PlayersPerCultist = 10;

    [DataField("maxCultists")]
    public int MaxCultists = 10;

    [DataField("narsiRisesSound", customTypeSerializer: typeof(SoundSpecifierTypeSerializer))]
    public SoundSpecifier? NarsiRisesSound = new SoundPathSpecifier("/Audio/CultSounds/narsie_rises.ogg");

    [DataField("iAmHereSound", customTypeSerializer: typeof(SoundSpecifierTypeSerializer))]
    public SoundSpecifier? IAmHereSound = new SoundPathSpecifier("/Audio/CultSounds/i_am_here.ogg");
}
