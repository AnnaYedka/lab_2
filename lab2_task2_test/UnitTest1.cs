using Xunit;

using lab2_task2;

namespace lab2_task2_test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int x = 0;
        int y = 10;
        
        Assert.Equal("in line", task2.InArea(x, y));
    }
    
    [Fact]
    public void Test2()
    {
        int x = 5;
        int y = 0;
        
        Assert.Equal("in line", task2.InArea(x, y));
    }
    
    [Fact]
    public void Test3()
    {
        int x = 5;
        int y = 5;
        
        Assert.Equal("in area", task2.InArea(x, y));
    }
    
    [Fact]
    public void Test4()
    {
        int x = -1;
        int y = -1;
        
        Assert.Equal("out of area", task2.InArea(x, y));
    }
    
    [Fact]
    public void Test5()
    {
        int x = 20;
        int y = 20;
        
        Assert.Equal("out of area", task2.InArea(x, y));
    }
}