namespace MegaDeskV1._0_Rush_Lopez
{
    public class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int drawers { get; set; }
        public string surfaceMaterial { get; set; }
        protected const int MIN_WIDTH = 24;
        protected const int MAX_WIDTH = 96;
        protected const int MIN_DEPTH = 12;
        protected const int MAX_DEPTH = 48;

        public Desk(int width, int depth, int drawers, string surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surfaceMaterial = surfaceMaterial;
        }

        public int getMinWidth()
        {
            return MIN_WIDTH;
        }

        public int getMaxWidth()
        {
            return MAX_WIDTH;
        }

        public int getMinDepth()
        {
            return MIN_DEPTH;
        }

        public int getMaxDepth()
        {
            return MAX_DEPTH;
        }

        public int calcSurfaceArea()
        {
            return width * depth;
        }
    }

    enum surfaceMaterials
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}