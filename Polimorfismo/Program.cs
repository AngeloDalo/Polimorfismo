using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            Insegnante insegnante1 = new Insegnante("anna", "neri", "mate");
            Persona insegnante2 = new Insegnante("luca", "rossi", "ita");
            insegnante1.Saluta();
            insegnante2.Saluta();
        }
    }

    class Persona
    {
        public string nome;
        public string cognome;
        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }
        public virtual void Saluta()
        {
            Console.WriteLine($"sono {nome} {cognome}");
        }
    }
    class Insegnante : Persona
    {
        public string materia;
        public Insegnante(string nome, string cognome, string materia) : base(nome, cognome)
        {
            this.materia = materia;
        }
        //NEW se considero Persone saluta come Persone
        //NEW se considero Insegante saluta come Insegnante
        //OVERRIDE sovrascrive il metodo quindi non posso salutare come persona
        public new void Saluta()
        {
            Console.WriteLine("sono un insegnante");
        }
    }

    class Studente : Persona
    {
        public string classe;

        public Studente(string nome, string cognome, string classe) : base(nome, cognome)
        {
            this.classe = classe;
        }
        public override void Saluta()
        {
            //base.Salute() prende il saluta di persona
            Console.WriteLine("ciao sono uno studente");
        }
    }
}






