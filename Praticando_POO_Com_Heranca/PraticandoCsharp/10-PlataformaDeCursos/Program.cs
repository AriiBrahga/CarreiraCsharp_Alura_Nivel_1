/*
Imagine que você está desenvolvendo um sistema para uma plataforma de cursos online. 
Existem diferentes tipos de cursos, como programação e design, 
e todos devem ser validados e publicados, com mensagens específicas para cada tipo.

Além disso, cada curso tem um instrutor associado, com nome e área de especialidade. 
Seu desafio é criar um sistema usando interface única e composição.

Crie um programa que:

1 - Crie uma interface ICurso, com os métodos:
        ValidarConteudo()
        PublicarCurso()
2 - Crie a classe Instrutor, com os atributos:
        Nome
        Especialidade
3 - Crie duas classes:
        CursoProgramacao e CursoDesign
        Ambas devem implementar ICurso e receber um Instrutor por composição
4 - Em cada classe, implemente os métodos com mensagens personalizadas.

5 - No Program.cs, instancie os cursos e chame os dois métodos:
        ValidarConteudo()
        PublicarCurso()
*/
Instrutor instrutor1 = new Instrutor("Carla", "Front-end");
ICurso curso1 = new CursoProgramacao("C# com POO", instrutor1);

Instrutor instrutor2 = new Instrutor("Felipe", "UI/UX");
ICurso curso2 = new CursoDesign("Design de Interfaces", instrutor2);

curso1.ValidarConteudo();
curso1.PublicarCurso();

curso2.ValidarConteudo();
curso2.PublicarCurso();