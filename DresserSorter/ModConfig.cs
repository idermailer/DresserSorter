namespace DresserSorter
{
    public sealed class ModConfig
    {
        public bool VeryTidySort_ByStats { get; set; } = false;
        public bool SortAdditionalCategories { get; set; } = false;
        public bool Cloth_ColorSortByHue { get; set; } = true;
        public bool Ring_CombinedRingIsPrior { get; set; } = true;
        public bool Object_NotSortResourceByDisplayName { get; set; } = true;
        public bool Furniture_NotCompareFurnitureType { get; set; } = true;
    }
}