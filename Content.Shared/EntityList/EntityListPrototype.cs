﻿using System.Collections.Immutable;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.List;

namespace Content.Shared.EntityList
{
    [Prototype("entityList")]
    public sealed class EntityListPrototype : IPrototype
    {
        [ViewVariables]
        [IdDataFieldAttribute]
        public string ID { get; } = default!;

        [DataField("entities", customTypeSerializer: typeof(PrototypeIdListSerializer<EntityPrototype>))]
        public ImmutableList<string> EntityIds { get; } = ImmutableList<string>.Empty;

        public IEnumerable<EntityPrototype> Entities(IPrototypeManager? prototypeManager = null)
        {
            prototypeManager ??= IoCManager.Resolve<IPrototypeManager>();

            foreach (var entityId in EntityIds)
            {
                yield return prototypeManager.Index<EntityPrototype>(entityId);
            }
        }
    }
}
