using JanelaBridge;
/*
 Desacoplar uma abstração de sua implementação 
 de forma que ambas possão variar idependentemente.ç
 */
JanelaAbstract janela = new JanelaDialog(new JanelaWindows());
janela.Print();

janela = new JanelaDialog(new JanelaLinux());
janela.Print();