namespace NServiceBus.IntegrationTests.Automated
{
    using NUnit.Framework;
    using Support;

    /// <summary>
    /// Base class for all the NSB test that sets up our conventions
    /// </summary>
    public class NServiceBusIntegrationTest
    {
  
        [SetUp]
        public void SetUp()
        {

            Conventions.EndpointNamingConvention= t =>
                {
                    var baseNs = typeof (NServiceBusIntegrationTest).Namespace;
                    var testName = GetType().Name;
                    return t.FullName.Replace(baseNs + ".", "").Replace(testName + "+", "");
                };
        }
    }
}