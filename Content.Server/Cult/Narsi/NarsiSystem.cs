using Content.Server.Cult.Narsi;
using Content.Server.Database.Migrations.Sqlite;
using Content.Server.Station.Components;
using Content.Server.Station.Systems;
using Robust.Shared.Map;
using Robust.Shared.Utility;

namespace Content.Server.Cult.Narsi
{

}
public sealed class NarsiSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<NarsiComponent, ComponentInit>(OnNarsiComonentInit);
    }

    private void OnNarsiComonentInit(EntityUid uid,  NarsiComponent component, ComponentInit ev)
    {
        RaiseLocalEvent(new NarsiHasBeenSummonedEvent(uid, component, ev));
    }

    public sealed class NarsiHasBeenSummonedEvent : EntityEventArgs
    {
        public readonly EntityUid Uid;
        public readonly NarsiComponent Component;
        public readonly ComponentInit InitEvent;

        public NarsiHasBeenSummonedEvent(EntityUid uid, NarsiComponent component, ComponentInit ev)
        {
            Uid = uid;
            Component = component;
            InitEvent = ev;
        }
    }
}
