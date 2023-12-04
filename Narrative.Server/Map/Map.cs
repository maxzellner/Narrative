namespace Narrative.Server.Map
{
    public class Map
    {
        Map? map;

        public Map() 
        { 

        }

        public void Load()
        {
            map = MapDataService.LoadMap();
        }

        public void Write()
        {
            MapDataService.WriteMap(this);
        }

        public void Generate(int seed)
        {

        }
    }
}
