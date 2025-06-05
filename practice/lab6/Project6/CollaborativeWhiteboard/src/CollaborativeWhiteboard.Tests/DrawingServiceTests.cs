using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollaborativeWhiteboard.Services;

namespace CollaborativeWhiteboard.Tests
{
    [TestClass]
    public class DrawingServiceTests
    {
        private DrawingService _drawingService;

        [TestInitialize]
        public void Setup()
        {
            _drawingService = new DrawingService();
        }

        [TestMethod]
        public void Test_AddDrawingElement()
        {
            // Arrange
            var element = new DrawingElement { /* Initialize properties */ };

            // Act
            _drawingService.AddDrawingElement(element);

            // Assert
            Assert.IsTrue(_drawingService.DrawingElements.Contains(element));
        }

        [TestMethod]
        public void Test_ClearDrawing()
        {
            // Arrange
            _drawingService.AddDrawingElement(new DrawingElement { /* Initialize properties */ });

            // Act
            _drawingService.ClearDrawing();

            // Assert
            Assert.AreEqual(0, _drawingService.DrawingElements.Count);
        }

        [TestMethod]
        public void Test_SaveDrawing()
        {
            // Arrange
            var element = new DrawingElement { /* Initialize properties */ };
            _drawingService.AddDrawingElement(element);
            string filePath = "testDrawing.png";

            // Act
            var result = _drawingService.SaveDrawing(filePath);

            // Assert
            Assert.IsTrue(result);
            // Additional checks can be added to verify the file exists and is valid
        }
    }
}