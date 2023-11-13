using System;
using System.Runtime.CompilerServices;

namespace Verlag;

public class Buch
{
    public static void Main()
    {

    }
    private string autor;

    public string Autor
    {
        get
        {
            return autor;
        }
        set
        {
            autor = value;
        }
    }

    private string titel;

    public string Titel
    {
        get
        {
            return titel;
        }
        set
        {
            titel = value;
        }
    }

    private int auflage;

    public int Auflage
    {
        get
        {
            return auflage;
        }
        set
        {
            auflage = value;
        }
    }

    public Buch(string autor, string titel, int auflage)
    {
        this.Autor = autor;
        this.Titel = titel;
        this.Auflage = auflage;

        if (auflage < 1)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public Buch(string autor, string titel)
    {
        this.Autor = autor;
        this.Titel = titel;
        this.Auflage = 1;
    }
}
