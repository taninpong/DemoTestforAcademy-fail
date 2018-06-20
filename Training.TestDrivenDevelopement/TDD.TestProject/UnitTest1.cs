using TDD.ConsoleApp;
using System;
using Xunit;
using System.Linq;

namespace TDD.TestProject
{
    public class UnitTest1
    {
        //[Theory]
        //[InlineData(80, 30, 110)]
        //public void Test1(int num1, int num2, int excepted)
        //{
        //    var resual = Add(num1,num2);
        //    Assert.Equal(excepted, resual);

        //}



        [Fact]
        public void Test()
        {
            Program xxx = new Program();
            var resual = xxx.Grad(80);
            Assert.Equal("C", resual);

        }

        [Theory]
        [InlineData(100,"F")]
        [InlineData(70,"F")]
        [InlineData(50,"F")]
        [InlineData(60,"F")]
        [InlineData(65,"F")]
        [InlineData(75,"F")]
        [InlineData(30,"A")]
        [InlineData(40,"A")]
        public void Test1(int num, string excepted)
        {
            Program xx = new Program();
            var resual = xx.Grad(num);
            Assert.Equal(excepted, resual);
        }

        [Fact]
        public void Testtrue()
        {
            Program xxx = new Program();
            var resual = xxx.check();
            Assert.False(resual);

        }





        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //public void Grad(int score)
        //{
        //    if (score >= 80)
        //    {

        //    }
        //    else if (score >= 70)
        //    {

        //    }
        //}


        //[Fact]
        //public void Test()
        //{
        //    var resual = Add(80, 30);
        //    Assert.Equal(110, resual);
        //}
    }
}
