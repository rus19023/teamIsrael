namespace MegaDeskV1._0_Rush_Lopez
{
    public class Desk
    {
        protected int width { get; set; }
        protected int depth { get; set; }
        protected int drawers { get; set; }
        protected string surfaceMaterial { get; set; }
        protected const int minWidth = 24;
        protected const int maxWidth = 96;
        protected const int minDepth = 12;
        protected const int maxDepth = 48;

        public Desk(int width, int depth, int drawers, string surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surfaceMaterial = surfaceMaterial;
        }

        public int getMinWidth()
        {
            return minWidth;
        }

        public int getMaxWidth()
        {
            return maxWidth;
        }

        public int getMinDepth()
        {
            return minDepth;
        }

        public int getMaxDepth()
        {
            return maxDepth;
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