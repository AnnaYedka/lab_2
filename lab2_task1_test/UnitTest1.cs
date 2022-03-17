using lab2_task1;

using Xunit;

namespace lab2_task1_test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 3;
        int b = 3;
        int c = 3;
        
        Assert.True(task1.IsIsosceles(a, b, c));
    }
    
    [Fact]
    public void Test2()
    {
        int a = 3;
        int b = 3;
        int c = 1;
        
        Assert.True(task1.IsIsosceles(a, b, c));
    }
    
    [Fact]
    public void Test3()
    {
        int a = 3;
        int b = 1;
        int c = 3;
        
        Assert.True(task1.IsIsosceles(a, b, c));
    }
    
    [Fact]
    public void Test4()
    {
        int a = 1;
        int b = 3;
        int c = 3;
        
        Assert.True(task1.IsIsosceles(a, b, c));
    }
    
    [Fact]
    public void Test5()
    {
        int a = 1;
        int b = 2;
        int c = 3;
        
        Assert.False(task1.IsIsosceles(a, b, c));
    }
}