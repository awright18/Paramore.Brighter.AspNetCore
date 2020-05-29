#if NETSTANDARD2_0
using Polly.Registry;
#endif
namespace Paramore.Brighter.AspNetCore
{   
    public sealed class BrighterOptions
    {
        /// <summary>
        /// Configures the request context factory. Defaults to <see cref="InMemoryRequestContextFactory"/>.
        /// </summary>
        public IAmARequestContextFactory RequestContextFactory { get; set; } = new InMemoryRequestContextFactory();

        /// <summary>
        /// Configures the policy registry. Set to null to use Brighter's default policy.
        /// </summary>
#if NETSTANDARD2_0
        public PolicyRegistry PolicyRegistry { get; set; }
#else
        public IAmAPolicyRegistry PolicyRegistry { get; set; }
#endif
        /// <summary>
        /// Configures task queues. Set to null to not use task queues.
        /// </summary>
        public MessagingConfiguration MessagingConfiguration { get; set; }
    }
}