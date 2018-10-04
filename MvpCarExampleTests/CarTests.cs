using System.Diagnostics;
using MvpCarExample.Domain;
using Xunit;

namespace MvpCarExampleTests
{
    public class CarTests
    {
        [Fact]
        public void TurnLeftAndMoveForward_AngleIsInitiallyZeroMovingTenSteps_XIsLessThanYAndXIsNegativeAndYIsPositive()
        {
            //Arrange 
            var car = new Car(0,0);
            car.TurnLeft(10);

            //Act
            for (var i = 0; i < 10; i++)
            {
                car.Forward();
                Debug.WriteLine($"X: {car.Position.X}, Y: {car.Position.Y}");
            }

            //Assert
            var position = car.Position;
            Assert.True(position.X < position.Y);
            Assert.True(position.X < 0);
            Assert.True(position.Y > 0);
        }

        [Fact]
        public void TurnIncrementallyLeftAndMoveForward_AngleIsInitiallyZeroMovingTenSteps_XIsLessThanYAndXIsNegativeAndYIsPositive()
        {
            //Arrange 
            var car = new Car(0, 0, 0);

            //Act
            for (var i = 0; i < 10; i++)
            {
                car.Forward();
                car.TurnLeft(45);
                Debug.WriteLine($"X: {car.Position.X}, Y: {car.Position.Y}");
            }

            //Assert
            var position = car.Position;
            Assert.True(position.X < position.Y);
            Assert.True(position.X < 0);
            Assert.True(position.Y > 0);
        }
    }
}
