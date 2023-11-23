using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage = 1;
        private string isbn;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public int Auflage
        { 
            get { return auflage; }
            set {  
                
                if (auflage < 1)
                {
                    throw new ArgumentOutOfRangeException();
                } else if (auflage > 1)
                {
                    auflage = value;
                }
                }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; 
                
                
            }
        }

        public Buch(string autor, string titel, int auflage = 1)
        {
            this.autor = autor;
            this.titel = titel;
            this.auflage = auflage;
            if(auflage < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public Buch(string autor, string titel)
        {
            this.autor = autor;
            this.titel = titel;
        }




        for (int i = 0; i <= string.length; i++)
			{
				if (string[i] = "-")
				{
                    
				}
			}

}
