using Content.Server.Roles;
using Content.Shared.Roles;

namespace Content.Server.Cult
{
    public sealed class CultistRole : Role
    {
        private AntagPrototype Prototype { get; }

        public CultistRole(Mind.Mind mind, AntagPrototype antagPrototype) : base(mind)
        {
            Prototype = antagPrototype;
            Name = Loc.GetString(antagPrototype.Name);
            Antagonist = antagPrototype.Antagonist;
        }

        public override string Name { get; }
        public override bool Antagonist { get; }
    }
}
