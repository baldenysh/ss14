using Content.Server.Construction.Completions;
using Content.Server.GameTicking.Rules.Components;
using Content.Shared.Throwing;
using System.Linq;
using Content.Server.Administration.Commands;
using Content.Server.CharacterAppearance.Components;
using Content.Server.Chat.Managers;
using Content.Server.Cult.Narsi;
using Content.Server.GameTicking.Rules.Components;
using Content.Server.GameTicking.Rules.Configurations;
using Content.Server.Ghost.Roles.Components;
using Content.Server.Ghost.Roles.Events;
using Content.Server.Humanoid.Systems;
using Content.Server.Mind.Components;
using Content.Server.NPC.Systems;
using Content.Server.Nuke;
using Content.Server.Preferences.Managers;
using Content.Server.RoundEnd;
using Content.Server.Shuttles.Components;
using Content.Server.Shuttles.Systems;
using Content.Server.Spawners.Components;
using Content.Server.Station.Components;
using Content.Server.Station.Systems;
using Content.Server.Traitor;
using Content.Server.Traits.Assorted;
using Content.Shared.CombatMode.Pacification;
using Content.Shared.Dataset;
using Content.Shared.MobState;
using Content.Shared.MobState.Components;
using Content.Shared.Nuke;
using Content.Shared.Preferences;
using Content.Shared.Roles;
using Robust.Server.GameObjects;
using Robust.Server.Maps;
using Robust.Server.Player;
using Robust.Shared.Map;
using Robust.Shared.Player;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;
using Robust.Shared.Utility;

namespace Content.Server.Cult.Narsi;

/// <summary>
/// This is used for tagging a blood God for cult.
/// </summary>
[RegisterComponent]
public sealed class NarsiComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("DeathAuraRadius")]
    public readonly float DeathAuraRadius = 10f;

}
