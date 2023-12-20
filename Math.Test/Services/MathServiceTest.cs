using Math.Api.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Math.Test.Services
{
    public class MathServiceTest
    {
        private readonly ServiceProvider _provider;
        public MathServiceTest()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IMathService, MathService>();
            _provider = serviceCollection.BuildServiceProvider();
        }

        [Fact]
        public async void ShouldAddTwoNumberCorrectly()
        {
            long a = 10;
            long b = 20;
            var mathService = _provider.GetRequiredService<IMathService>();
            long expectedResult = 30;

            var result = await mathService.AddAsync(a, b);

            Assert.Equal(expectedResult, result);
        }
    }
}