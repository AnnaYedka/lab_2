using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int a = 3;
        int b = 3;
        int c = 3;
        
        Assert.True(task2.IsIsosceles(a, b, c));
    }
}