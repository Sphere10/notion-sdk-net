using System;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.AutoMock;
using Notion.Client;
using Xunit;

namespace Notion.UnitTests;

public class DataSourcesClientTests
{
    private readonly AutoMocker _mocker = new();
    private readonly Mock<IRestClient> _restClient;
    private readonly IDataSourcesClient _dataSourcesClient;
    private readonly CancellationToken _cancellationToken = CancellationToken.None;

    public DataSourcesClientTests()
    {
        _restClient = _mocker.GetMock<IRestClient>();
        _dataSourcesClient = _mocker.CreateInstance<DataSourcesClient>();
    }

    #region RetrieveAsync Tests

    [Fact]
    public async Task RetrieveAsync_ShouldThrowArgumentNullException_WhenRequestIsNull()
    {
        // Arrange
        RetrieveDataSourceRequest request = null;

        // Act & Assert
        await Assert.ThrowsAsync<ArgumentNullException>(() => _dataSourcesClient.RetrieveAsync(request, _cancellationToken));
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData(null)]
    public async Task RetrieveAsync_ShouldThrowArgumentException_WhenDataSourceIdIsInvalid(string dataSourceId)
    {
        // Arrange
        var request = new RetrieveDataSourceRequest
        {
            DataSourceId = dataSourceId
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _dataSourcesClient.RetrieveAsync(request, _cancellationToken));
        Assert.Equal("DataSourceId cannot be null or empty. (Parameter 'DataSourceId')", exception.Message);
    }

    [Fact]
    public async Task RetrieveAsync_ShouldReturnDataSource()
    {
        // Arrange
        var dataSourceId = "test-data-source-id";
        var expectedDataSource = new RetrieveDataSourceResponse
        {
            Id = dataSourceId,
            Title = new RichTextBase[]
            {
                new RichTextText
                {
                    Text = new Text
                    {
                        Content = "Test Data Source"
                    }
                }
            }
        };

        var request = new RetrieveDataSourceRequest
        {
            DataSourceId = dataSourceId
        };

        _restClient
            .Setup(client => client.GetAsync<RetrieveDataSourceResponse>(ApiEndpoints.DataSourcesApiUrls.Retrieve(request), null, null, null, _cancellationToken))
            .ReturnsAsync(expectedDataSource);

        // Act
        var result = await _dataSourcesClient.RetrieveAsync(request, _cancellationToken);

        // Assert
        Assert.Equal(expectedDataSource, result);
    }

    #endregion RetrieveAsync Tests
}