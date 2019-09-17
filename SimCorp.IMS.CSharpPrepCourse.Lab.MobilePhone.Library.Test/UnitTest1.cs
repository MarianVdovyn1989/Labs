using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary.CommandLineUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone.Library.Test
{
    [TestClass]
    public class LibraryTest
    {
        public class UnitTestConsoleOutput : IOutput
        {
            public string Text;
            public void Write(string text)
            {
                Text += text;
            }
            public void WriteLine(string text)
            {
                Text += text;
            }
            public string GetText()
            {
                return Text;
            }
        }
        [TestMethod]
        public void PlayMethodIPhoneConsoleTest()
        {
            //Arrange
            UnitTestConsoleOutput console = new UnitTestConsoleOutput();
            var expected = $"Play sound in Mobile:\n{nameof(PlayBackIPhoneHeadset)} sound";
            //Act
            PlayBackIPhoneHeadset ActIPhone = new PlayBackIPhoneHeadset(console);
            ActIPhone.Play();
            //Assert
            Assert.AreEqual(expected, console.GetText());
        }
        [TestMethod]
        public void PlayMethodPhoneSpeakerConsoleTest()
        {
            //Arrange
            UnitTestConsoleOutput console = new UnitTestConsoleOutput();
            var expected = $"Play sound in Mobile:\n{nameof(PlayBackPhoneSpeaker)} sound";
            //Act
            PlayBackPhoneSpeaker ActIPhone = new PlayBackPhoneSpeaker(console);
            ActIPhone.Play();
            //Assert
            Assert.AreEqual(expected, console.GetText());
        }
        [TestMethod]
        public void PlayMethodSamsungHeadsetConsoleTest()
        {
            //Arrange
            UnitTestConsoleOutput console = new UnitTestConsoleOutput();
            var expected = $"Play sound in Mobile:\n{nameof(PlayBackSamsungHeadset)} sound";
            //Act
            PlayBackSamsungHeadset ActIPhone = new PlayBackSamsungHeadset(console);
            ActIPhone.Play();
            //Assert
            Assert.AreEqual(expected, console.GetText());
        }
        [TestMethod]
        public void PlayMethodUnofficialHeadsetConsoleTest()
        {
            //Arrange
            UnitTestConsoleOutput console = new UnitTestConsoleOutput();
            var expected = $"Play sound in Mobile:\n{nameof(PlayBackUnofficialHeadset)} sound";
            //Act
            PlayBackUnofficialHeadset ActIPhone = new PlayBackUnofficialHeadset(console);
            ActIPhone.Play();
            //Assert
            Assert.AreEqual(expected, console.GetText());
        }

    }
}
