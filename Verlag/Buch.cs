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
            if(this.auflage <= 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            auflage = value;
        }
    }

    private string isbn;

    public string ISBN
    {
        get
        {
            return isbn;
        }

        set
        {
            isbn = value;
        }
    }

    public List<char> List_char = new List<char>();

    public Buch(string autor, string titel, int auflage)
    {
        this.autor = autor;
        this.titel = titel;
        this.auflage = auflage;

        if (auflage < 1)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public Buch(string autor, string titel)
    {
        this.autor = autor;
        this.titel = titel;
        this.auflage = 1;
    }

    public Buch(string autor, string titel, int auflage, string isbn)
    {
        this.autor = autor;
        this.titel = titel;
        this.auflage = auflage;
    }
}
