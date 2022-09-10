﻿using System.Text;

public class Television
{
    const int MAX_VOLUME = 100;
    const int MIN_VOLUME = 0;
    const int MAX_CHANNEL = 83;
    const int MIN_CHANNEL = 1;


    private bool isOn;
    private int volume;
    private int channel;

    public Television()
    {
        this.isOn = false;
        this.volume = MIN_VOLUME;
        this.channel = MIN_CHANNEL;
    }

    public bool GetIsOn()
    {
        return this.isOn;
    }

    public int GetVolume()
    {
        return this.volume;
    }

    public int GetChannel()
    {
        return this.channel;
    }

    public void ToggleIsOn()
    {
        this.isOn = !this.isOn;
    }

    public bool IncreaseVolumeByOne()
    {


        bool isLowerThanMaxVolume = this.volume < MAX_VOLUME;

        if (!isLowerThanMaxVolume || !this.isOn) return false;

        this.volume += 1;
        return true;
    }



    public bool DecreaseVolumeByOne()
    {
        bool isHgiherThanMinVolume = this.volume > MIN_VOLUME;

        if (!isHgiherThanMinVolume || !this.isOn) return false;

        this.volume -= 1;
        return true;
    }


    public bool IncreaseChannelByOne()
    {
        bool isLowerThanMaxChannel = this.channel < MAX_CHANNEL;

        if (!isLowerThanMaxChannel || !this.isOn) return false;

        this.channel += 1;
        return true;
    }

    public bool DecreaseChannelByOne()
    {
        bool isHigherThanMinChannel = this.channel > MIN_CHANNEL;

        if (!isHigherThanMinChannel || !this.isOn) return false;

        this.channel -= 1;
        return true;
    }

    private String GetFormattedVolume()
    {
        if (this.volume < 10)
        {
            return "0" + this.volume;
        }

        return this.volume.ToString();
    }

    private String GetFormattedChannel()
    {
        if (this.channel < 10)
        {
            return "0" + this.channel;
        }
        return this.channel.ToString();
    }

    public override string ToString()
    {
        StringBuilder television = new StringBuilder("--------------------------------------------\n");
        television.Append("|          Xulambs Entertainments          |\n");
        television.Append("--------------------------------------------\n");
        television.Append("| Canal: " + GetFormattedChannel() + "                                |\n");
        television.Append("| Volume: " + GetFormattedVolume() + "                               |\n");
        if (this.isOn)
        {
            television.Append("| Ligada                                o  |\n");
        }
        else
        {
            television.Append("| Desligada                             -  |\n");

        }
        television.Append("--------------------------------------------\n");
        television.Append("           |----------------------|         \n");
        television.Append("                |-----------|               \n");
        television.Append("||||||||||||||||||||||||||||||||||||||||||||\n");

        return television.ToString();
    }


}


