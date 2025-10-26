using System.Threading;
using System.Threading.Tasks;

namespace Notion.Client
{
    public interface IDataSourcesClient
    {
        /// <summary>
        /// Retrieves a data source by its ID.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<RetrieveDataSourceResponse> RetrieveAsync(
            RetrieveDataSourceRequest request,
            CancellationToken cancellationToken = default
        );
    }
}
