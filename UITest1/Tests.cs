using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
            app.DismissKeyboard();
            app.Screenshot("Second screen.");
            app.DismissKeyboard();
            app.Screenshot("Third screen.");
        }
         [Test]
        public void EnterNames()
        {
            app.Screenshot("First screen.");
            Assert.IsFalse(app.Query("StartGameButton").First().Enabled, "Button should not be enabled");

            app.EnterText("Player1", "James");
            app.DismissKeyboard();
            app.Screenshot("Entered Player 1.");
            Assert.IsFalse(app.Query("StartGameButton").First().Enabled, "Button should not be enabled");

            app.EnterText("Player2", "Heather");
            app.DismissKeyboard();

            app.Screenshot("Entered Player 2.");

            Assert.True(app.Query("StartGameButton").First().Enabled, "Button should be enabled");
        }
    }
}

