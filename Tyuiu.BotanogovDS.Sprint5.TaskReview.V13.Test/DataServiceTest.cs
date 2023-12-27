using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BotanogovDS.Sprint5.TaskReview.V13.Lib;

namespace Tyuiu.BotanogovDS.Sprint5.TaskReview.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedExistsFile()
        {
            string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint5.Review\Tyuiu.BotanogovDS.Sprint5.TaskReview.V13\bin\Debug\InPutDataFileTask7V13.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
}
