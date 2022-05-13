namespace MegaDeskV1._0_Rush_Lopez
{
    public class Desk
    {
        private int width;
        private int depth;
        private int drawers;
        private string surfaceMaterial;
        private const int minWidth = 24;
        private const int maxWidth = 96;
        private const int minDepth = 12;
        private const int maxDepth = 48;

        public Desk(int width, int depth, int drawers, string surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surfaceMaterial = surfaceMaterial;
        }

        public int getWidth()
        {
            return width;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int getDepth()
        {
            return depth;
        }

        public void setDepth(int depth)
        {
            this.depth = depth;
        }

        public int getDrawers()
        {
            return drawers;
        }

        public void setDrawers(int drawers)
        {
            this.drawers = drawers;
        }

        public string getSurfaceMaterial()
        {
            return surfaceMaterial;
        }

        public void setSurfaceMaterial(string surfaceMaterial)
        {
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
            return width * depth * 1;
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