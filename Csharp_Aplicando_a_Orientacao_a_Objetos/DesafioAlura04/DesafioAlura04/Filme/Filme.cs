/*Crie uma classe chamada Filme que tenha:

Propriedades públicas Titulo e ClassificacaoEtaria (int).
Um método chamado PodeAssistir(int idadeUsuario) que retorna true se a idade for maior ou igual à classificação etária, e false caso contrário.
Um método ExibirResultado(int idadeUsuario) que exiba uma mensagem amigável informando se o usuário pode ou não assistir ao filme.
*/
using System.Numerics;

class Filme
{
    public string Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }

    public bool PodeAssistir(int idadeUsuario)
    {
        if (idadeUsuario >= ClassificacaoEtaria)
        {
            Console.WriteLine($"Usuário com {idadeUsuario} anos pode assistir ao filme {Titulo}.");
            return true;
        }
        else
        {
            Console.WriteLine($"Usuário com {idadeUsuario} anos não pode assistir ao filme {Titulo}.");
            return false;
        }
    }
}