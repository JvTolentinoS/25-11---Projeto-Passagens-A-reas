using System;

namespace _25_11___Projeto_Passagens_A_reas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string [5];
            string[] origem = new string [5];
            string[] destino = new string [5];
            string[] data = new string [5];
            
            string resposta;
            string senha;
            int menu;
            int contador = 0;
            Console.WriteLine("Sistema de Passagens Áereas");

            //Login do Usuário
            do{
            Console.WriteLine("---------------------------");
            Console.WriteLine("Insira a senha de login");
            senha = Console.ReadLine();
            if(senha == "123456"){
                break;
            }
            }while (senha != "123456");
            Console.WriteLine("Login efetuado com sucesso!");
            
            //Menu
            MenuInicial();
            
            switch(menu)
            {   
                case 1:
                CadastroProdutos();
                break;

                //Lista
                case 2:
                ListarProduto();
                break;

                case 3:
                break;
                default: Console.WriteLine("O sistema foi suspenso com sucesso.");
                break;
                
        }while (menu != 3); 

        //metodo
        void MenuInicial(){
            Console.WriteLine("[1] - Cadastrar passagens");
            Console.WriteLine("[2] - Listar passagens");
            Console.WriteLine("[3] - Sair");
            menu = int.Parse(Console.ReadLine());
        }
        
        void CadastroProdutos(){
            do{
            if(contador<5){
            Console.WriteLine($"Digite o nome do {contador+1}° Passageiro");
            nome[contador] = Console.ReadLine();
            Console.WriteLine($"Digite a origem do {contador+1}° Passageiro");
            origem[contador] = Console.ReadLine();
            Console.WriteLine($"Digite o destino do {contador+1}° Passageiro");
            destino[contador] = Console.ReadLine();
            Console.WriteLine($"Digite a data de voo do {contador+1}° Passageiro");
            data[contador] = Console.ReadLine();
            contador++;
        }else{
            Console.WriteLine("Limite excedido de passagens");
        }
            Console.WriteLine("Gostaria de cadastrar mais passageiros?");
            resposta = Console.ReadLine();
            if(resposta == "Nao"){MenuInicial();}
        }while (resposta == "Sim");

        switch(menu)
            {   
                case 1:
                CadastroProdutos();
                break;

                //Lista
                case 2:
                ListarProduto();
                break;

                case 3:
                break;
                default: Console.WriteLine("O sistema foi suspenso com sucesso.");
                break;
                
        }while (menu != 3);

        }
    
        void ListarProduto(){
            do{
            for(var i = 0; i < 5; i++)
            {
            Console.WriteLine($"Passageiro {nome[i]} - Origem {origem[i]} - Destino {destino[i]} - Data {data[i]}");
            }
            Console.WriteLine("Voltar para o menu inicial? Sim/Nao?");
            resposta = Console.ReadLine();
            if(resposta == "Sim"){
                MenuInicial();
                }
            }while (resposta == "Nao");

            switch(menu)
            {   
                case 1:
                CadastroProdutos();
                break;

                //Lista
                case 2:
                ListarProduto();
                break;

                case 3:
                break;
                default: Console.WriteLine("O sistema foi suspenso com sucesso.");
                break;
                
        }while (menu != 3); 
        }
}
}
}


