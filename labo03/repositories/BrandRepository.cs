namespace labo03.repositories;
public interface IBrandRepository
{
    Task<Brand> AddBrand(Brand newBrand);
    Task<Brand> GetBrand(string id);
    Task<List<Brand>> GetAllBrands();
    Task<Brand> UpdateBrand(Brand brand);
    Task DeleteBrand(string id);
}
public class BrandRepository : IBrandRepository
{
    private readonly IMongoContext _context;
    public BrandRepository(IMongoContext context)
    {
        _context = context;
    }

    public async Task<Brand> AddBrand(Brand newBrand)
    {
        newBrand.CreatedOn = DateTime.Now;
        await _context.BrandsCollection.InsertOneAsync(newBrand);
        return newBrand;
    }
    public async Task<Brand> GetBrand(string id)
    {
        throw new NotImplementedException();
        // return await _context.BrandsCollection.Find(brand => brand.Id == id).FirstOrDefault();
    }
    public async Task<List<Brand>> GetAllBrands()
    {
        return await _context.BrandsCollection.Find(_ => true).ToListAsync();
    }
    public Task<Brand> UpdateBrand(Brand brand)
    {
        throw new NotImplementedException();
        // _brands.ReplaceOne(brand => brand.Id == brand.Id, brand);
        // return brand;
    }
    public Task DeleteBrand(string id)
    {
        throw new NotImplementedException();
        // _brands.DeleteOne(brand => brand.Id == id);
    }
}