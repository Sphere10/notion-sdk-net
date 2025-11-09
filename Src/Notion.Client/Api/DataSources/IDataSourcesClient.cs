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

        /// <summary>
        /// Creates a new data source.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<CreateDataSourceResponse> CreateAsync(
            CreateDataSourceRequest request,
            CancellationToken cancellationToken = default
        );

        /// <summary>
        /// Updates an existing data source.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<UpdateDataSourceResponse> UpdateAsync(
            UpdateDataSourceRequest request,
            CancellationToken cancellationToken = default
        );

        /// <summary>
        /// Lists the templates for a data source.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ListDataSourceTemplatesResponse> ListDataSourceTemplatesAsync(
            ListDataSourceTemplatesRequest request,
            CancellationToken cancellationToken = default
        );
    }
}
