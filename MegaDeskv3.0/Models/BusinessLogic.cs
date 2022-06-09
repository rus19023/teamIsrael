using System;

namespace MegaDeskv3._0.Models
{
    public static class BusinessLogic
    {
        public static readonly int[] Drawers = new int[] {0, 1, 2, 3, 4, 5, 6, 7};

        public enum surfaceMaterials
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        public static readonly int[] RushDays = new int[] {0, 3, 5, 7};

        public static readonly int minWidth = 24;
        public static readonly int maxWidth = 96;
        public static readonly int minDepth = 12;
        public static readonly int maxDepth = 48;
        
    }


}


