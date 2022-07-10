using System;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo, letra, compositor, genero;

            titulo = "La poupée qui fait non";
            letra = "C'est une poupée\n" +
                    "Qui fait \"non, non, non, non\"\n" +
                    "Toute la journée\n" +
                    "Elle fait \"non, non, non, non\"\n\n" +
                    "Elle est\n" +
                    "Elle est tellement jolie\n" +
                    "Que j'en rêve la nuit\n\n" +
                    "C'est une poupée\n" +
                    "Qui fait \"non, non, non, non\"\n" +
                    "Toute la journée\n" +
                    "Elle fait \"non, non, non, non\"\n\n" +
                    "Personne ne lui a jamais appris\n" +
                    "Qu'on pouvait dire oui.\n\n" +
                    "Sans même écouter\n" +
                    "Elle fait \"non, non, non, non\"\n" +
                    "Sans me regarder\n" +
                    "Elle fait \"non, non, non, non\"\n\n" +
                    "Pourtant je donnerais ma vie\n" +
                    "Pour qu'elle dise oui\n\n" +
                    "Pourtant je donnerais ma vie\n" +
                    "Pour qu'elle dise oui\n\n" +
                    "Mais c'est une poupée\n" +
                    "Qui fait \"non, non, non, non\"\n" +
                    "Toute la journée\n" +
                    "Elle fait \"non, non, non, non\"\n\n" +
                    "Personne ne lui a jamais appris\n" +
                    "Qu'on pouvait dire oui.\n\n" +
                    "\"non, non, non, non\"\n" +
                    "\"non, non, non, non\"\n" +
                    "\"non, non, non, non, non, non\"\n";
            compositor = "Frank Gérald";
            genero = "Pop";

            Console.WriteLine($"{titulo}, escrita por {compositor} (gênero {genero})\n");
            Console.WriteLine(letra);
        }
    }
}
