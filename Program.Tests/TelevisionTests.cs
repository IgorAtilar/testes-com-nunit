using NUnit.Framework;
using System.Text;

namespace Program.UnitTests.Services
{
    public class TelevisionTest
    {

        [Test]
        public void Change_IsOn_To_True()
        {
            Television television = new Television();

            television.ToggleIsOn();
            var result = television.GetIsOn();

            Assert.IsTrue(result, "Should return true when toggling for the first time");
        }

        [Test]
        public void Change_IsOn_To_False()
        {
            Television television = new Television();

            television.ToggleIsOn();
            television.ToggleIsOn();
            var result = television.GetIsOn();

            Assert.IsFalse(result, "Should return false when toggling two times after setup");
        }


        // Increase Volume

        [Test]
        public void Return_False_And_Not_Change_The_Volume_When_Trying_To_Increase_The_Volume_With_Television_Turned_Off()
        {
            Television television = new Television();

            var firstVolume = television.GetVolume();
            var result = television.IncreaseVolumeByOne();
            var secondVolume = television.GetVolume();

            Assert.IsFalse(result, "Should return false when trying to increase the volume and the television is turned off");
            Assert.AreEqual(firstVolume, secondVolume, "Should not change the volume when trying to increase the volume and the television is turned off");
        }

        [Test]
        public void Return_False_And_Not_Pass_The_Max_Volume_When_Trying_To_Increase_The_Volume_More_Than_The_Max_Volume_With_Television_Turned_On()
        {
            Television television = new Television();

            television.ToggleIsOn();
            var maxVolume = television.GetMaxVolume();

            for (int i = 0; i <= maxVolume; i = i + 1)
            {
                television.IncreaseVolumeByOne();
            }

            var result = television.IncreaseVolumeByOne();
            var volume = television.GetVolume();

            Assert.IsFalse(result, "Should return false when trying to increase the volume more than the max volume with television turned on");
            Assert.AreEqual(maxVolume, volume, "Should not pass the max volume when trying to increase the volume more than the max volume with television turned on");
        }

        [Test]
        public void Return_True_And_Increase_The_Volume_When_Trying_To_Increase_The_Volume_With_Television_Turned_On_And_The_Volume_Is_Lower_Than_The_Max_Volume()
        {
            Television television = new Television();
            var firstVolume = television.GetVolume();
            television.ToggleIsOn();
            var result = television.IncreaseVolumeByOne();
            var secondVolume = television.GetVolume();

            Assert.IsTrue(result, "Should return true when trying to increase the volume and the television is turned on");
            Assert.AreEqual(firstVolume + 1, secondVolume, "Should increase the volume by one when trying to increase the volume when the volume is lower than the max volume and the television is turned on");
        }

        // Decrease Volume

        [Test]
        public void Return_False_And_Not_Change_The_Volume_When_Trying_To_Decrease_The_Volume_With_Television_Turned_Off()
        {
            Television television = new Television();

            var firstVolume = television.GetVolume();
            var result = television.DecreaseVolumeByOne();
            var secondVolume = television.GetVolume();

            Assert.IsFalse(result, "Should return false when trying to decrease the volume and the television is turned off");
            Assert.AreEqual(firstVolume, secondVolume, "Should not change the volume when trying to decrease the volume and the television is turned off");
        }

        [Test]
        public void Return_False_And_Not_Pass_The_Max_Volume_When_Trying_To_Decrease_The_Volume_More_Than_The_Min_Volume_With_Television_Turned_On()
        {
            Television television = new Television();

            television.ToggleIsOn();
            var minVolume = television.GetMinVolume();
            var result = television.DecreaseChannelByOne();
            var volume = television.GetVolume();

            Assert.IsFalse(result, "Should return false when trying to decrease the volume more than the min volume with television turned on");
            Assert.AreEqual(minVolume, volume, "Should not pass the min volume when trying to decrease the volume more than the min volume with television turned on");
        }

        [Test]
        public void Return_True__And_Decrease_The_Volume_When_Trying_To_Decrease_The_Volume_With_Television_Turned_On_And_The_Volume_Is_Higher_Than_The_Min_Volume()
        {
            Television television = new Television();
            var firstVolume = television.GetVolume();
            television.ToggleIsOn();
            television.IncreaseVolumeByOne();
            var result = television.DecreaseVolumeByOne();
            var secondVolume = television.GetVolume();

            Assert.IsTrue(result, "Should return true when trying to decrease the volume and the television is turned on");
            Assert.AreEqual(firstVolume, secondVolume, "Should decrease the volume by one when trying to decrease the volume when the volume is higher than the min volume and the television is turned on");
        }

        // Increase Channel

        [Test]
        public void Return_False_And_Not_Change_The_Channel_When_Trying_To_Increase_The_Channel_With_Television_Turned_Off()
        {
            Television television = new Television();

            var firstChannel = television.GetChannel();
            var result = television.IncreaseChannelByOne();
            var secondChannel = television.GetChannel();

            Assert.IsFalse(result, "Should return false when trying to increase the channel and the television is turned off");
            Assert.AreEqual(firstChannel, secondChannel, "Should not change the channel when trying to increase the channel and the television is turned off");
        }

        [Test]
        public void Return_False_And_Not_Pass_The_Max_Channel_When_Trying_To_Increase_The_Channel_More_Than_The_Max_Channel_With_Television_Turned_On()
        {
            Television television = new Television();

            television.ToggleIsOn();
            var maxChannel = television.GetMaxChannel();

            for (int i = 0; i <= maxChannel; i = i + 1)
            {
                television.IncreaseChannelByOne();
            }

            var result = television.IncreaseChannelByOne();
            var channel = television.GetChannel();

            Assert.IsFalse(result, "Should return false when trying to increase the channel more than the max channel with television turned on");
            Assert.AreEqual(maxChannel, channel, "Should not pass the max channel when trying to increase the channel more than the max channel with television turned on");
        }

        [Test]
        public void Return_True_And_Increase_The_Channel_When_Trying_To_Increase_The_Channel_With_Television_Turned_On_And_The_Channel_Is_Lower_Than_The_Max_Channel()
        {
            Television television = new Television();
            var firstChannel = television.GetChannel();
            television.ToggleIsOn();
            var result = television.IncreaseChannelByOne();
            var secondChannel = television.GetChannel();

            Assert.IsTrue(result, "Should return true when trying to increase the channel and the television is turned on");
            Assert.AreEqual(firstChannel + 1, secondChannel, "Should increase the channel by one when trying to increase the volume when the channel is lower than the max channel and the television is turned on");
        }

        // Decrease Channel

        [Test]
        public void Return_False_And_Not_Change_The_Channel_When_Trying_To_Decrease_The_Channel_With_Television_Turned_Off()
        {
            Television television = new Television();

            var firstChannel = television.GetChannel();
            var result = television.DecreaseChannelByOne();
            var secondChannel = television.GetChannel();

            Assert.IsFalse(result, "Should return false when trying to decrease the channel and the television is turned off");
            Assert.AreEqual(firstChannel, secondChannel, "Should not change the channel when trying to decrease the channel and the television is turned off");
        }

        [Test]
        public void Return_False_And_Not_Pass_The_Min_Channel_When_Trying_To_Decrease_The_Channel_More_Than_The_Min_Channel_With_Television_Turned_On()
        {
            Television television = new Television();

            television.ToggleIsOn();
            var minChannel = television.GetMinChannel();
            var result = television.DecreaseChannelByOne();
            var channel = television.GetChannel();

            Assert.IsFalse(result, "Should return false when trying to decrease the channel more than the min channel with television turned on");
            Assert.AreEqual(minChannel, channel, "Should not decrease the channel more than the min channel with television turned on");
        }

        [Test]
        public void Return_True_And_Decrease_The_Channel_When_Trying_To_Decrease_The_Channel_With_Television_Turned_On_And_The_Channel_Is_Higher_Than_The_Min_Channel()
        {
            Television television = new Television();
            var firstChannel = television.GetChannel();
            television.ToggleIsOn();
            television.IncreaseChannelByOne();
            var result = television.DecreaseChannelByOne();
            var secondChannel = television.GetChannel();

            Assert.IsTrue(result, "Should return true when trying to decrease the channel and the television is turned on");
            Assert.AreEqual(firstChannel, secondChannel, "Should decrease the channel by one when trying to decrease the channel when the channel is higher than the min channel and the television is turned on");
        }


        [Test]
        public void Return_The_Television_String_With_The_Off_State()
        {
            Television television = new Television();
            StringBuilder televisionStringBuilder = new StringBuilder("--------------------------------------------\n");
            televisionStringBuilder.Append("|           Tuturu Entertainments          |\n");
            televisionStringBuilder.Append("--------------------------------------------\n");
            televisionStringBuilder.Append("| Canal: 01                                |\n");
            televisionStringBuilder.Append("| Volume: 00                               |\n");
            televisionStringBuilder.Append("| Desligada                             -  |\n");
            televisionStringBuilder.Append("--------------------------------------------\n");
            televisionStringBuilder.Append("           |----------------------|         \n");
            televisionStringBuilder.Append("                |-----------|               \n");
            televisionStringBuilder.Append("||||||||||||||||||||||||||||||||||||||||||||\n");
            string televisionString = televisionStringBuilder.ToString();
            Assert.AreEqual(television.ToString(), televisionString, "Should return the correct television string when the television is turned off");
        }


        [Test]
        public void Return_The_Television_String_With_The_On_State()
        {
            Television television = new Television();
            television.ToggleIsOn();
            StringBuilder televisionStringBuilder = new StringBuilder("--------------------------------------------\n");
            televisionStringBuilder.Append("|           Tuturu Entertainments          |\n");
            televisionStringBuilder.Append("--------------------------------------------\n");
            televisionStringBuilder.Append("| Canal: 01                                |\n");
            televisionStringBuilder.Append("| Volume: 00                               |\n");
            televisionStringBuilder.Append("| Ligada                                o  |\n");
            televisionStringBuilder.Append("--------------------------------------------\n");
            televisionStringBuilder.Append("           |----------------------|         \n");
            televisionStringBuilder.Append("                |-----------|               \n");
            televisionStringBuilder.Append("||||||||||||||||||||||||||||||||||||||||||||\n");
            string televisionString = televisionStringBuilder.ToString();
            Assert.AreEqual(television.ToString(), televisionString, "Should return the correct television string when the television is turned on");
        }



    }
}