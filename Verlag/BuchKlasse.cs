using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Verlag;

public class Buch
{
    private string autor;
    private string titel;
    private int auflage;

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
  


    public string Autor
    { 
        get
        { return autor; }
        set 
        { autor = value; }
    }

    public string Titel
    { 
        get 
        { return titel; } 
        set 
        { titel = value; } 
    }

    public int Auflage
    {
        get      
        { return auflage; }
        set
        { auflage = value; }
    }

 
}
