namespace test_program;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;
public class UnitTest
{
    [Fact]
    public void testProgram()
    {
        
        StringWriter output = new StringWriter();
        Console.SetOut(output);

        Console.SetIn(new StringReader("90"));
        Program.run();
       
        Assert.Contains("There are only 100 banknotes", output.ToString());
    }

    [Fact]
    public void testProgram2()
    {
        
        StringWriter output = new StringWriter();
        Console.SetOut(output);

        Console.SetIn(new StringReader("3000000"));
        Program.run();
       
        Assert.Contains("Exceed max withdrawal limit", output.ToString());
    }

    [Fact]
    public void testProgram3()
    {
        
        StringWriter output = new StringWriter();
        Console.SetOut(output);

        Console.SetIn(new StringReader("2500"));
        Program.run();
       
        Assert.Contains("You want to withdraw 2500 Baht.", output.ToString());
        Assert.Contains("Please take your money: 25 of 100 Baht Banknotes.", output.ToString());
    }
}