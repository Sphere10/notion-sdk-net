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
    }
}