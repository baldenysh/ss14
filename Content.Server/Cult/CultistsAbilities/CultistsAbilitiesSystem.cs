using Content.Server.Actions;
using Content.Server.Chat.Managers;
using Content.Server.Mind.Components;
using Content.Server.Popups;
using Content.Shared.Actions;
using Robust.Shared.Timing;

namespace Content.Server.Cult.CultistsAbilities;

public sealed class CultistAbilitiesSystem : EntitySystem
{
    [Dependency] private readonly ActionsSystem _actionSystem = default!;


    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<CultistAbilitiesComponent, ComponentInit>(OnCultistAbilitiesComponentInit);

    }

    private void OnCultistAbilitiesComponentInit(EntityUid uid, CultistAbilitiesComponent component, ComponentInit args)
    {
        if (!TryComp<MindComponent>(uid, out var mindComponent))
            return;
        if (!TryComp<CultistAbilitiesComponent>(uid, out var cultistAbilitiesComponent))
            return;

        _actionSystem.AddAction(uid, component.CultistCommunicateInstantAction, null);
        _actionSystem.AddAction(uid, component.CultistBloodSpellsInstantAction, null);
    }

}

public sealed class CultistCommunicateInstantActionEvent : InstantActionEvent {}

public sealed class CultistBloodSpellsInstantActionEvent : InstantActionEvent {}
