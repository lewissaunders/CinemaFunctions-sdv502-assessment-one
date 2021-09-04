using NUnit.Framework;

namespace CinemaFunctions.Test
{
    public class Tests
    {
        [TestFixture]
        public class CinemaFunctionsTest
        {
            [Test]
            public void Adult_Before_5_test1()
            {
                //Arrange
                int quantity = 1; 
                string person = "adult";
                string day = "monday";
                decimal time = 1600;
                decimal expectedResult = 14.50M;
                TicketPriceController test1 = new TicketPriceController();

                //Act
                decimal actualResult = test1.Adult_Before_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Before_5_test2()
            {
                //Arrange
                int quantity = 2;
                string person = "adult";
                string day = "monday";
                decimal time = 1600;
                decimal expectedResult = 29.00M;
                TicketPriceController test2 = new TicketPriceController();

                //Act
                decimal actualResult = test2.Adult_Before_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Before_5_test3()
            {
                //Arrange
                int quantity = 0;
                string person = "adult";
                string day = "monday";
                decimal time = 1600;
                decimal expectedResult = -1;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Adult_Before_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Before_5_test4()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "tuesday";
                decimal time = 1600;
                decimal expectedResult = -1;
                TicketPriceController test4 = new TicketPriceController();

                //Act
                decimal actualResult = test4.Adult_Before_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Before_5_test5()
            {
                //Arrange
                int quantity = 1;
                string person = "student";
                string day = "monday";
                decimal time = 1600;
                decimal expectedResult = -1;
                TicketPriceController test5 = new TicketPriceController();

                //Act
                decimal actualResult = test5.Adult_Before_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Before_5_test6()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "monday";
                decimal time = 1800;
                decimal expectedResult = -1;
                TicketPriceController test6 = new TicketPriceController();

                //Act
                decimal actualResult = test6.Adult_Before_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Before_5_test7()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "tuesday";
                decimal time = 1800;
                decimal expectedResult = -1;
                TicketPriceController test7 = new TicketPriceController();

                //Act
                decimal actualResult = test7.Adult_Before_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_After_5_test1()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "monday";
                decimal time = 1800;
                decimal expectedResult = 17.50M;
                TicketPriceController test1 = new TicketPriceController();

                //Act
                decimal actualResult = test1.Adult_After_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_After_5_test2()
            {
                //Arrange
                int quantity = 2;
                string person = "adult";
                string day = "monday";
                decimal time = 1800;
                decimal expectedResult = 35.00M;
                TicketPriceController test2 = new TicketPriceController();

                //Act
                decimal actualResult = test2.Adult_After_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_After_5_test3()
            {
                //Arrange
                int quantity = 0;
                string person = "adult";
                string day = "monday";
                decimal time = 1800;
                decimal expectedResult = -1;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Adult_After_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_After_5_test4()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "tuesday";
                decimal time = 1800;
                decimal expectedResult = -1;
                TicketPriceController test4 = new TicketPriceController();

                //Act
                decimal actualResult = test4.Adult_After_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_After_5_test5()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "tuesday";
                decimal time = 1600;
                decimal expectedResult = -1;
                TicketPriceController test5 = new TicketPriceController();

                //Act
                decimal actualResult = test5.Adult_After_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_After_5_test6()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "monday";
                decimal time = 1600;
                decimal expectedResult = -1;
                TicketPriceController test6 = new TicketPriceController();

                //Act
                decimal actualResult = test6.Adult_After_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_After_5_test7()
            {
                //Arrange
                int quantity = 1;
                string person = "student";
                string day = "monday";
                decimal time = 1800;
                decimal expectedResult = -1;
                TicketPriceController test7 = new TicketPriceController();

                //Act
                decimal actualResult = test7.Adult_After_5(quantity, person, day, time);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Tuesday_test1()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "tuesday";
                decimal expectedResult = 13.00M;
                TicketPriceController test1 = new TicketPriceController();

                //Act
                decimal actualResult = test1.Adult_Tuesday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Tuesday_test2()
            {
                //Arrange
                int quantity = 2;
                string person = "adult";
                string day = "tuesday";
                decimal expectedResult = 26.00M;
                TicketPriceController test2 = new TicketPriceController();

                //Act
                decimal actualResult = test2.Adult_Tuesday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Tuesday_test3()
            {
                //Arrange
                int quantity = 0;
                string person = "adult";
                string day = "tuesday";
                decimal expectedResult = -1;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Adult_Tuesday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Tuesday_test4()
            {
                //Arrange
                int quantity = 1;
                string person = "student";
                string day = "tuesday";
                decimal expectedResult = -1;
                TicketPriceController test4 = new TicketPriceController();

                //Act
                decimal actualResult = test4.Adult_Tuesday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Adult_Tuesday_test5()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "monday";
                decimal expectedResult = -1;
                TicketPriceController test5 = new TicketPriceController();

                //Act
                decimal actualResult = test5.Adult_Tuesday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Child_Under_16_test1()
            {
                //Arrange
                int quantity = 1;
                string person = "child";
                decimal expectedResult = 12.00M;
                TicketPriceController test1 = new TicketPriceController();

                //Act
                decimal actualResult = test1.Child_Under_16(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Child_Under_16_test2()
            {
                //Arrange
                int quantity = 2;
                string person = "child";
                decimal expectedResult = 24.00M;
                TicketPriceController test2 = new TicketPriceController();

                //Act
                decimal actualResult = test2.Child_Under_16(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Child_Under_16_test3()
            {
                //Arrange
                int quantity = 1;
                string person = "student";
                decimal expectedResult = -1;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Child_Under_16(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Child_Under_16_test4()
            {
                //Arrange
                int quantity = 0;
                string person = "child";
                decimal expectedResult = -1;
                TicketPriceController test4 = new TicketPriceController();

                //Act
                decimal actualResult = test4.Child_Under_16(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Senior_test1()
            {
                //Arrange
                int quantity = 1;
                string person = "senior";
                decimal expectedResult = 12.50M;
                TicketPriceController test1 = new TicketPriceController();

                //Act
                decimal actualResult = test1.Senior(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Senior_test2()
            {
                //Arrange
                int quantity = 2;
                string person = "senior";
                decimal expectedResult = 25.00M;
                TicketPriceController test2 = new TicketPriceController();

                //Act
                decimal actualResult = test2.Senior(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Senior_test3()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                decimal expectedResult = -1;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Senior(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Senior_test4()
            {
                //Arrange
                int quantity = 0;
                string person = "senior";
                decimal expectedResult = -1;
                TicketPriceController test4 = new TicketPriceController();

                //Act
                decimal actualResult = test4.Senior(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Student_test1()
            {
                //Arrange
                int quantity = 1;
                string person = "student";
                decimal expectedResult = 14.00M;
                TicketPriceController test1 = new TicketPriceController();

                //Act
                decimal actualResult = test1.Student(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Student_test2()
            {
                //Arrange
                int quantity = 2;
                string person = "student";
                decimal expectedResult = 28.00M;
                TicketPriceController test2 = new TicketPriceController();

                //Act
                decimal actualResult = test2.Student(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Student_test3()
            {
                //Arrange
                int quantity = 0;
                string person = "student";
                decimal expectedResult = -1;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Student(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Student_test4()
            {
                //Arrange
                int quantity = 1;
                string person = "senior";
                decimal expectedResult = -1;
                TicketPriceController test4 = new TicketPriceController();

                //Act
                decimal actualResult = test4.Student(quantity, person);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Family_Pass_test1()
            {
                //Arrange
                int quantity = 1;
                int quantity_adult = 1;
                int quantity_child = 3;
                decimal expectedResult = 46.00M;
                TicketPriceController test1 = new TicketPriceController();

                //Act
                decimal actualResult = test1.Family_Pass(quantity, quantity_adult, quantity_child);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Family_Pass_test2()
            {
                //Arrange
                int quantity = 1;
                int quantity_adult = 2;
                int quantity_child = 2;
                decimal expectedResult = 46.00M;
                TicketPriceController test2 = new TicketPriceController();

                //Act
                decimal actualResult = test2.Family_Pass(quantity, quantity_adult, quantity_child);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Family_Pass_test3()
            {
                //Arrange
                int quantity = 2;
                int quantity_adult = 2;
                int quantity_child = 6;
                decimal expectedResult = 92.00M;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Family_Pass(quantity, quantity_adult, quantity_child);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Family_Pass_test4()
            {
                //Arrange
                int quantity = 2;
                int quantity_adult = 4;
                int quantity_child = 4;
                decimal expectedResult = 92.00M;
                TicketPriceController test4 = new TicketPriceController();

                //Act
                decimal actualResult = test4.Family_Pass(quantity, quantity_adult, quantity_child);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Family_Pass_test5()
            {
                //Arrange
                int quantity = 2;
                int quantity_adult = 3;
                int quantity_child = 5;
                decimal expectedResult = 92.00M;
                TicketPriceController test5 = new TicketPriceController();

                //Act
                decimal actualResult = test5.Family_Pass(quantity, quantity_adult, quantity_child);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Family_Pass_test6()
            {
                //Arrange
                int quantity = 1;
                int quantity_adult = 3;
                int quantity_child = 1;
                decimal expectedResult = -1;
                TicketPriceController test6 = new TicketPriceController();

                //Act
                decimal actualResult = test6.Family_Pass(quantity, quantity_adult, quantity_child);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Family_Pass_test7()
            {
                //Arrange
                int quantity = 1;
                int quantity_adult = 4;
                int quantity_child = 0;
                decimal expectedResult = -1;
                TicketPriceController test7 = new TicketPriceController();

                //Act
                decimal actualResult = test7.Family_Pass(quantity, quantity_adult, quantity_child);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Family_Pass_test8()
            {
                //Arrange
                int quantity = 1;
                int quantity_adult = 0;
                int quantity_child = 4;
                decimal expectedResult = -1;
                TicketPriceController test8 = new TicketPriceController();

                //Act
                decimal actualResult = test8.Family_Pass(quantity, quantity_adult, quantity_child);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Family_Pass_test9()
            {
                //Arrange
                int quantity = 0;
                int quantity_adult = 2;
                int quantity_child = 2;
                decimal expectedResult = -1;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Family_Pass(quantity, quantity_adult, quantity_child);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Chick_Flick_Thursday_test1()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "thursday";
                decimal expectedResult = 21.50M;
                TicketPriceController test1 = new TicketPriceController();

                //Act
                decimal actualResult = test1.Chick_Flick_Thursday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Chick_Flick_Thursday_test2()
            {
                //Arrange
                int quantity = 2;
                string person = "adult";
                string day = "thursday";
                decimal expectedResult = 43.00M;
                TicketPriceController test2 = new TicketPriceController();

                //Act
                decimal actualResult = test2.Chick_Flick_Thursday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Chick_Flick_Thursday_test3()
            {
                //Arrange
                int quantity = 0;
                string person = "adult";
                string day = "thursday";
                decimal expectedResult = -1;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Chick_Flick_Thursday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Chick_Flick_Thursday_test4()
            {
                //Arrange
                int quantity = 1;
                string person = "adult";
                string day = "wednesday";
                decimal expectedResult = -1;
                TicketPriceController test4 = new TicketPriceController();

                //Act
                decimal actualResult = test4.Chick_Flick_Thursday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Chick_Flick_Thursday_test5()
            {
                //Arrange
                int quantity = 1;
                string person = "student";
                string day = "thursday";
                decimal expectedResult = -1;
                TicketPriceController test5 = new TicketPriceController();

                //Act
                decimal actualResult = test5.Chick_Flick_Thursday(quantity, person, day);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Kids_careers_test1()
            {
                //Arrange
                int quantity = 1;
                string day = "wednesday";
                bool holiday = false;
                decimal expectedResult = 12.00M;
                TicketPriceController test1 = new TicketPriceController();

                //Act
                decimal actualResult = test1.Kids_Careers(quantity, day, holiday);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Kids_careers_test2()
            {
                //Arrange
                int quantity = 2;
                string day = "wednesday";
                bool holiday = false;
                decimal expectedResult = 24.00M;
                TicketPriceController test2 = new TicketPriceController();

                //Act
                decimal actualResult = test2.Kids_Careers(quantity, day, holiday);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Kids_careers_test3()
            {
                //Arrange
                int quantity = 0;
                string day = "wednesday";
                bool holiday = false;
                decimal expectedResult = -1;
                TicketPriceController test3 = new TicketPriceController();

                //Act
                decimal actualResult = test3.Kids_Careers(quantity, day, holiday);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Kids_careers_test4()
            {
                //Arrange
                int quantity = 1;
                string day = "monday";
                bool holiday = false;
                decimal expectedResult = -1;
                TicketPriceController test4 = new TicketPriceController();

                //Act
                decimal actualResult = test4.Kids_Careers(quantity, day, holiday);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Kids_careers_test5()
            {
                //Arrange
                int quantity = 1;
                string day = "monday";
                bool holiday = true;
                decimal expectedResult = -1;
                TicketPriceController test5 = new TicketPriceController();

                //Act
                decimal actualResult = test5.Kids_Careers(quantity, day, holiday);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Kids_careers_test6()
            {
                //Arrange
                int quantity = 1;
                string day = "wednesday";
                bool holiday = true;
                decimal expectedResult = -1;
                TicketPriceController test6 = new TicketPriceController();

                //Act
                decimal actualResult = test6.Kids_Careers(quantity, day, holiday);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
        }   


    }
}