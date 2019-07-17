using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using mathletics.Context;

namespace mathletics.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_QuizAdditionTestAnswer_Question()
        {
            //arrange           
            //act
            Question testQuestion = Quizmaster.QuizAddition();            
            string[] numbers = testQuestion.Prompt.Split(' ');
            int value1 = int.Parse(numbers[0]);
            int value2 = int.Parse(numbers[2]);
            int total = value1 + value2;
            //assert
            System.Console.WriteLine(testQuestion.Prompt);
            System.Console.WriteLine(testQuestion.Option1);
            System.Console.WriteLine(testQuestion.Option2);
            System.Console.WriteLine(testQuestion.Option3);
            System.Console.WriteLine(testQuestion.CorrectAnswer);
            System.Console.WriteLine(total);
            switch (testQuestion.CorrectAnswer) {
                case 1:
                    Assert.AreEqual(total.ToString(), testQuestion.Option1); 
                    break;
                case 2:
                    Assert.AreEqual(total.ToString(), testQuestion.Option2); 
                    break;
                case 3:
                    Assert.AreEqual(total.ToString(), testQuestion.Option3); 
                    break;
            }
        }

        [TestMethod]
        public void Test_BuildQuiz_Question()
        {
            //arrange
            //act
            List<Question> testQuiz = Quizmaster.BuildQuiz();
            //assert
            System.Console.WriteLine(testQuiz);
            Assert.AreEqual(8, testQuiz.Count);
        }

        // [TestMethod]
        // public void CreateQuiz_SaveToDataBase_Question()
        // {
        //     //arrange
        //     //act
        //     List<Question> testQuiz = Quizmaster.BuildQuiz();
        //     MathleticsData.CreateQuiz(testQuiz);
        //     //assert
        //     Assert.AreEqual(8, testQuiz.Count);
        // }

    }
}