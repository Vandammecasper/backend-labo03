
namespace labo03.GraphQL.Queries;
public class Queries
{
    public async Task<List<Car>> GetCars([Service] ICarService carService)
    {
        return await carService.GetAllCars();
    }
}
