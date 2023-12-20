
namespace Math.Api.Services
{
    public class MathService : IMathService
    {
        public Task<long> AddAsync(long a, long b, CancellationToken cancellationToken = default)
        {
            var res = checked(a + b);
            return Task.FromResult(res);
        }
    }
}
