using Xunit;
using JenkinsTest;
namespace JenkinsTest.Tests {

	public class HelloWorldTests {
		[Theory]
		[InlineData("John")]
		[InlineData("隼")]
		[InlineData("We, who came to \n fire")]
		public void ShouldCreateGreeting(string subject) {
			Assert.Equal("Hello, " + subject, HelloWorld.CreateGreeting(subject));
		}
	}
}
