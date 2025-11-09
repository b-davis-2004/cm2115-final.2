namespace final.v1
{
    public class Area2 : AreaBase
    {
        public override string Name => "Bandit Camp";
        public override string Description => "This is Area 2.";

        public Area2()
        {
            Conflict = new CombatConflict(new Enemy2());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
    //will need to rename according to what the area will be called
}