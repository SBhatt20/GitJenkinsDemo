using GitActionDemoNew;
using System;
using Xunit;

namespace GitActionDemoTest
{
    public class UnitTest1
    {
    [Fact]
    public void Test1()
    {
      DemoClass obj = new DemoClass();
      string output = obj.DemoMethod("test");

      Assert.Equal("this is a demo method output-test", output);

    }
  }
}
