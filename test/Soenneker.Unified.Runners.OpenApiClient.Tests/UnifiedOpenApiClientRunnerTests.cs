using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Unified.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class UnifiedOpenApiClientRunnerTests : FixturedUnitTest
{
    public UnifiedOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
