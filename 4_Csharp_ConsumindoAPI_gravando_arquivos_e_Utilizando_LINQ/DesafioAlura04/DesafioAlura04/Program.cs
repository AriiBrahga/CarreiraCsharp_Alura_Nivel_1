/*
1 - Criar um programa que permite ao usuário inserir informações de uma pessoa 
    (nome, idade, e e-mail), serializa essas informações em formato JSON e 
    salva em um arquivo.

2 - Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, 
    desserializa essas informações e exibe na tela.

3 - Criar um programa que permite ao usuário inserir informações de várias pessoas, 
    armazena essas informações em uma lista, serializa a lista em formato JSON e 
    salva em um arquivo.

4 - Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, 
    desserializa essas informações em uma lista e exibe na tela.

5 - Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.
*/

using System.IO;
using System.Text.Json;
using DesafioAlura04.Filtros;
using DesafioAlura04.Pessoas;

Pessoa pessoa1 = new() {Nome = "Joao Carlos", Idade = 23, Email = "joaocarlos@gmail.com" };
Pessoa pessoa2 = new(){Nome = "Maria Clara", Idade = 17, Email = "mariaclara@gmail.com"};
ListadePessoas pessoa3 = new ListadePessoas();


//pessoa1.GerarArquivoJson();
//pessoa1.LerArquivoJson();

pessoa3.AdicionarPessoa(pessoa1);
pessoa3.AdicionarPessoa(pessoa2);
pessoa3.GerarArquivoJson();


pessoa3.LerArquivoJson();

LinqFilter.FiltarPessoasPorIdade(pessoa3.Pessoas, 17);