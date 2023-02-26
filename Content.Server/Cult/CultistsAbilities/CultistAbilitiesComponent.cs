using Content.Server.Abilities.Mime;
using Content.Shared.Actions.ActionTypes;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;
using Robust.Shared.Utility;

namespace Content.Server.Cult.CultistsAbilities
{
    /// <summary>
    /// Lets its owner entity use mime powers, like placing invisible walls.
    /// </summary>
    [RegisterComponent]
    public sealed class CultistAbilitiesComponent : Component
    {
        [DataField("cultistCommunicateInstantAction")]
        public InstantAction CultistCommunicateInstantAction = new()
        {
            UseDelay = TimeSpan.FromSeconds(5),
            Icon = new SpriteSpecifier.Texture(new ResourcePath("/Textures/Interface/Actions/coms.png")),
            DisplayName = "cultist-abilities-communicate-action-name",
            Description = "cultist-abilities-communicate-action-description",
            Priority = -1,
            Event = new CultistCommunicateInstantActionEvent(),
        };

        [DataField("cultistBloodSpellsInstantAction")]
        public InstantAction CultistBloodSpellsInstantAction = new()
        {
            UseDelay = TimeSpan.FromSeconds(5),
            Icon = new SpriteSpecifier.Texture(new ResourcePath("/Textures/Interface/Actions/coms.png")),
            DisplayName = "cultist-abilities-blood-spells-action-name",
            Description = "cultist-abilities-blood-spells-action-description",
            Priority = -1,
            Event = new CultistBloodSpellsInstantActionEvent(),
        };
    }
}
