namespace final.v1
{
    public class Area1 : AreaBase
    {
        public override string Name => "Forest";
        public override string Description => "This is Area 1.";

        public Area1()
        {
            Conflict = new CombatConflict(new Enemy1());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
    //will need to rename according to what the area will be called
}