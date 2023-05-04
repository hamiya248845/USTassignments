using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

using BMUnitTest;

namespace UnitTestDemo

{

  [TestClass]

  public class BMUnitTest1

  {

    [TestMethod]

    public void Test_AddMethod()

    {

      BasicMath bm = new BasicMath();

      double res = bm.Add(20, 10);

      Assert.AreEqual(30, res);

    }

    [TestMethod]

    public void Test_SubtractMethod()

    {

      BasicMath bm = new BasicMath();

      double res = bm.Subtract(20, 10);

      Assert.AreEqual(10, res);

    }

    [TestMethod]

    public void Test_DivideMethod()

    {

      BasicMath bm = new BasicMath();

      double res = bm.Divide(20 , 10);

      Assert.AreEqual(2, res);

    }

    [TestMethod]

    public void Test_MultiplyMethod()

    {

      BasicMath bm = new BasicMath();

      double res = bm.Multiply(20, 10);

      Assert.AreEqual(200, res);

    }

  }

}


