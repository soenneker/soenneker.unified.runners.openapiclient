using Soenneker.Tests.HostedUnit;

namespace Soenneker.Unified.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class UnifiedOpenApiClientRunnerTests : HostedUnitTest
{
    public UnifiedOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
