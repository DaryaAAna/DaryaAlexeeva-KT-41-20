

namespace DaryaAlexeevaKt4120.Tests
{
    public class GroupTests
    {
        [Fact]
        public void IsValidNumberGroup_KT4120_True()
        {
            var testGroup = new DaryaAlexeevaKT4120.Models.Group
            {
                NumberGroup = "สา-41-20"
            };

            var result = testGroup.IsValidNumberGroup();

            Assert.True(result);

        }
    }
}