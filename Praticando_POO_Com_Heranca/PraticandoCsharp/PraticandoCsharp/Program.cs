/*
    Você está desenvolvendo um sistema para um clube, onde a experiência do cliente é prioridade. 
    Os membros comuns têm acesso básico, mas os clientes VIP possuem benefícios exclusivos, 
    como níveis de fidelidade e identificadores personalizados. Seu desafio é criar uma estrutura que diferencie esses perfis.

    Crie um programa que:

    (X) 1 - Defina uma classe Pessoa com os atributos Nome e Idade. 
    (X) 2 - Crie uma classe ClienteVIP que herde de Pessoa, adicionando:
    (X) 3 - Um atributo nível de fidelidade (ex: Ouro, Diamante).
    (X) 4 - Um atributo código VIP (ex: VIP123A).
    (X) 5 - Instancie dois clientes VIP com dados fictícios.
    (X) 6 - Exiba no console uma mensagem formatada para cada cliente, incluindo:
    (X) 7 - Uma saudação personalizada (ex: "Bem-vindo, cliente VIP: [Nome]").
    (X) 8 - Idade, nível de fidelidade e código VIP em linhas separadas.
*/
ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");

cliente1.Cliente();
cliente2.Cliente();