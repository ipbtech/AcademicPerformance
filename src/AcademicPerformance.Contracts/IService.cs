namespace AcademicPerformance.Contracts
{
    public interface IService<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T?> GetByIdAsync(int id);
        public Task CreateAsync(T dto);
        public Task UpdateAsync(int id, T dto);
        public Task DeleteAsync(int id);
    }
}
