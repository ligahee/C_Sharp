﻿namespace ColoredBall;

public class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;

    public Color(int red, int green, int blue, int alpha = 255)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }

    public int Red
    {
        get { return red; }
        set { red = value; }
    }

    public int Green
    {
        get { return green; }
        set { green = value; }
    }

    public int Blue
    {
        get { return blue; }
        set { blue = value; }
    }

    public int Alpha
    {
        get { return alpha; }
        set { alpha = value; }
    }

    public double GetGrayscaleValue()
    {
        return (red + green + blue) / 3.0;
    }
}