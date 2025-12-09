/*

    Imagine que você está desenvolvendo um sistema de gerenciamento para uma biblioteca digital. 
    Esse sistema precisa organizar diferentes tipos de mídias, como documentos de texto e imagens, 
    cada um com suas próprias características, mas compartilhando propriedades básicas.

    Sua tarefa é criar uma estrutura que permita catalogar esses itens, 
    garantindo que cada tipo de mídia possa exibir suas informações específicas.

    Crie um programa que:

    1 - Defina uma classe base chamada ItemDigital com um atributo para armazenar o título do item.
    2 - Crie uma classe Pergaminho que herde de ItemDigital, adicionando um atributo para armazenar o conteúdo textual.
    3 - Implemente o método MostrarDetalhes() para exibir o título e o conteúdo no console.
    4 - Instancie um objeto da classe Pergaminho, atribuindo um título e um conteúdo.
    5 - Chame o método MostrarDetalhes()

*/

Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");
pergaminhoAntigo.MostrarDetalhes();