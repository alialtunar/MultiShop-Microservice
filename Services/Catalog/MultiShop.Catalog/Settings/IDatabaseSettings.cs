namespace MultiShop.Catalog.Settings
{
    public interface IDatabaseSettings
    {
        public String CategoryCollectionName { get; set; } 
        public String ProductCollectionName { get; set; } 
        public String ProductDetailCollectionName { get; set; } 
        public String ProductImageCollectionName { get; set; } 
        public String ConnectionString { get; set; } 
        public String DatabaseName { get; set; } 
                                                           
    }

}

