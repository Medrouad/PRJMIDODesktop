using System;

public class Jour
{
    private DateTime jour;

    public Jour(DateTime j)
    {
        jour = j;
    }

    public DateTime Jours
    {
        get { return jour; }
        set { jour = value; }
    }
}

