using HotelListings.IRepository;
using HotelListings.Models;
using HotelListings.MyDbContext;

namespace HotelListings.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private IGenericRepository<Country>? _countries;
        private IGenericRepository<Hotel>? _hotels;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext ?? throw new ArgumentNullException(nameof(appDbContext));
        }
        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_appDbContext);
        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_appDbContext);

        public void Dispose()
        {
            _appDbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
