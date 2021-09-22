using Kros.Meetup.Demo.WebAPi.Domains;
using Kros.Generators.Flattening;

namespace Kros.Meetup.Demo.WebAPi.Infrastructure
{
    [Flatten(SourceType = typeof(Document))]
    public partial class DocumentFlat
    {
    }
}
