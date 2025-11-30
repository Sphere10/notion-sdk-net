using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notion.Client;
using Xunit;

namespace Notion.IntegrationTests
{
    public class DataSourcesClientTests : IntegrationTestBase
    {
        [Fact]
        public async Task CreateDataSource_ShouldReturnSuccess()
        {
            // Arrange
            var request = new CreateDataSourceRequest
            {
                Parent = new DatabaseParentRequest
                {
                    DatabaseId = "" // TODO: Create a test database and set its ID here
                },
                Properties = new Dictionary<string, PropertyConfigurationRequest>
                {
                    {
                        "Name",
                        new TitlePropertyConfigurationRequest {
                            Description = "The name of the data source",
                            Title = new Dictionary<string, object>()
                        }
                    }
                },
                Title = new List<RichTextBaseInput>
                {
                    new RichTextTextInput {  Text =  new Text { Content = "Test Data Source" } }
                }
            };

            // Act
            var response = await Client.DataSources.CreateAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal("Test Data Source", response.Title.OfType<RichTextText>().First().Text.Content);
            Assert.Single(response.Properties);
            Assert.True(response.Properties.ContainsKey("Name"));
            Assert.Equal("The name of the data source", response.Properties["Name"].Description);
        }

        // add tests for update
        [Fact]
        public async Task UpdateDataSource_ShouldReturnSuccess()
        {
            // Arrange
            var createRequest = new CreateDataSourceRequest
            {
                Parent = new DatabaseParentRequest
                {
                    DatabaseId = "29ee2842ccb5802397b8fdf6fed5ac93" // TODO: Create a test database and set its ID here
                },
                Properties = new Dictionary<string, PropertyConfigurationRequest>
                {
                    {
                        "Name",
                        new TitlePropertyConfigurationRequest {
                            Description = "The name of the data source",
                            Title = new Dictionary<string, object>()
                        }
                    },
                    {
                        "Status",
                        new SelectPropertyConfigurationRequest {
                            Description = "The status of the data source",
                            Select = new SelectPropertyConfigurationRequest.SelectOptions
                            {
                                Options = new List<SelectOptionRequest>
                                {
                                    new() { Name = "Open", Color = "green" },
                                    new() { Name = "Closed", Color = "red" }
                                }
                            }
                        }
                    }
                },
                Title = new List<RichTextBaseInput>
                {
                    new RichTextTextInput {  Text =  new Text { Content = "Initial Data Source" } }
                }
            };

            var createResponse = await Client.DataSources.CreateAsync(createRequest);

            var updateRequest = new UpdateDataSourceRequest
            {
                DataSourceId = createResponse.Id,
                Title = new List<RichTextBaseInput>
                {
                    new RichTextTextInput { Text = new Text { Content = "Updated Data Source" } }
                },
                Properties = new Dictionary<string, IUpdatePropertyConfigurationRequest>
                {
                    {
                        "Status",
                        new UpdatePropertyConfigurationRequest<SelectPropertyConfigurationRequest>
                        {
                            Name = "Item Status",
                            PropertyRequest = new SelectPropertyConfigurationRequest
                            {
                                Description = "Updated status of the data source",
                                Select = new SelectPropertyConfigurationRequest.SelectOptions
                                {
                                    Options = new List<SelectOptionRequest>
                                    {
                                        new() { Name = "In Progress", Color = "yellow" },
                                        new() { Name = "Completed", Color = "blue" }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            // Act
            var updateResponse = await Client.DataSources.UpdateAsync(updateRequest);

            // Assert
            Assert.NotNull(updateResponse);
            Assert.Equal("Updated Data Source", updateResponse.Title.OfType<RichTextText>().First().Text.Content);
            Assert.Equal(2, updateResponse.Properties.Count);
            Assert.True(updateResponse.Properties.ContainsKey("Item Status"));
            Assert.True(updateResponse.Properties.ContainsKey("Name"));
        }

        // write test for query
        [Fact]
        public async Task QueryDataSourceAsync_ShouldReturnResults()
        {
            // Arrange
            var databaseId = "29ee2842ccb5802397b8fdf6fed5ac93"; // TODO: Create a test database and set its ID here
            var dataSourceId = await CreateAndGetDatasourceIdAsync(databaseId);
            var queryRequest = new QueryDataSourceRequest
            {
                DataSourceId = dataSourceId,
            };

            // Act
            var queryResponse = await Client.DataSources.QueryAsync(queryRequest);

            // Assert
            Assert.NotNull(queryResponse);
            Assert.NotNull(queryResponse.Results);
        }

        private async Task<string> CreateAndGetDatasourceIdAsync(string databaseId)
        {
            var request = new CreateDataSourceRequest
            {
                Parent = new DatabaseParentRequest
                {
                    DatabaseId = databaseId
                },
                Properties = new Dictionary<string, PropertyConfigurationRequest>
                {
                    {
                        "Name",
                        new TitlePropertyConfigurationRequest {
                            Description = "The name of the data source",
                            Title = new Dictionary<string, object>()
                        }
                    }
                },
                Title = new List<RichTextBaseInput>
                {
                    new RichTextTextInput {  Text =  new Text { Content = "Test Data Source" } }
                }
            };

            var response = await Client.DataSources.CreateAsync(request);
            return response.Id;
        }
    }
}