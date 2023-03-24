﻿using System;
using ProgramacaoWeb_CSharp_Fatec.Classes;
using ProgramacaoWeb_CSharp_Fatec.Heranca;

namespace ProgramacaoPw_CSharp_Fatec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n\n======================\nProduto\n======================");

            
            Console.WriteLine("\n\nCriando um produto por meio da class Produto - Usando construtor\n");

            Produto p1 = new Produto(1, 10.90M, "Cervejinha");
            Console.WriteLine("Descrição: " + p1.getDescricao() + " \t\t Valor: " + p1.getValor() + " \t\t ID: " + p1.getId());

            Console.WriteLine("\n\nMudando algumas infos do produto criado acima com os métodos set da class\n");
            p1.setValor(11.85M);
            p1.setDescricao("Cerveja Skol 1 litrão");
            Console.WriteLine("Descrição: " + p1.getDescricao() + " \t\t Valor: " + p1.getValor() + " \t\t ID: " + p1.getId());




            

            Console.WriteLine("\n\n======================\nEndereço\n======================");

            Console.WriteLine("\n\nUtilizando outra class (Endereco.cs) para criar dois objetos do tipo Endereco");

            
            Endereco endereco = new Endereco(
                "Rua Mario Miziara",
                "91",
                "Sobral",
                "15906304",
                "Taquaritinga",
                "SP"
                );

            Endereco endereco2 = new Endereco(
                "Rua dos bobo",
                "952",
                "Sobral",
                "15906304",
                "Taquaritinga",
                "SP"
                );
           
            Console.WriteLine("\nEndereço Completo (método EnderecoCompleto)");
            Console.WriteLine(endereco.EnderecoCompleto());
            Console.WriteLine(endereco2.EnderecoCompleto());

            Console.WriteLine("\nEndereco curto (método EnderecoCurto)");
            Console.WriteLine(endereco.EnderecoCurto());
            Console.WriteLine(endereco2.EnderecoCurto());



            Console.WriteLine("\n\n======================\nCliente + Endereco\n======================");

            Console.WriteLine("\n\nUtilizando outra class (Cliente.cs) para criar alguns objetos do tipo Cliente e ainda dentro da class Cliente usando a class Endereco.cs\n");

            
            Cliente c1 = new Cliente(1, "Gabriele", "991340444", endereco);
            Cliente c2 = new Cliente(2, "Luis", "991340445", endereco2);
            Cliente c3 = new Cliente(3, "Leandro", "991340446", endereco);
            Cliente c4 = new Cliente(4, "Ana", "991340447", endereco2);
            Cliente c5 = new Cliente(5, "Rayssa", "991340448", endereco);

            
            Console.WriteLine("Chamando o método getEndereco(Cliente) que retorna o objeto Endereco que tem os métodos da class Endereco\n");
            Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());

            c2.getEndereco().setNumero("136");

            Console.WriteLine(c2.getEndereco().getNumero());
            Console.WriteLine(c2.getEndereco().EnderecoCompleto());
            Console.WriteLine(c2.getEndereco().EnderecoCurto());




           

            Console.WriteLine("\n\n======================\nHerança\n======================");

            
            Carro Gol = new Carro();
            Gol.temMotor = true;
            Gol.numeroPortas = 4;
            Gol.numeroAssentos = 5;
            Gol.fabricante = "Vw";
            Gol.arCondicionado = true;
            Gol.cintoSeguranca = true;
            Gol.marcaRadio = "Cochicho";

            Carro Saveiro = new Carro();
            Saveiro.temMotor = true;
            Saveiro.numeroPortas = 2;
            Saveiro.numeroAssentos = 5;
            Saveiro.fabricante = "Vw";
            Saveiro.arCondicionado = true;
            Saveiro.cintoSeguranca = true;
            Saveiro.marcaRadio = "RadioTudor";

            Carro Palio = new Carro();
            Palio.temMotor = true;
            Palio.numeroPortas = 4;
            Palio.numeroAssentos = 5;
            Palio.fabricante = "Fiat";
            Palio.arCondicionado = true;
            Palio.cintoSeguranca = true;
            Palio.marcaRadio = "Estação1000";

            Carro Uno = new Carro();
            Uno.temMotor = true;
            Uno.numeroPortas = 2;
            Uno.numeroAssentos = 5;
            Uno.fabricante = "Fiat";
            Uno.arCondicionado = true;
            Uno.cintoSeguranca = true;
            Uno.marcaRadio = "Cochicho";

            Bike Caloi = new Bike();
            Caloi.temMotor = false;
            Caloi.numeroPortas = 0;
            Caloi.numeroAssentos = 1;

            Bike Speed = new Bike();
            Speed.temMotor = false;
            Speed.numeroPortas = 0;
            Speed.numeroAssentos = 1;

            
            Console.WriteLine("\n\nCriando um método na class Veiculo que a class Carro e Bike herdam e podem usar, neste caso iremos apenas criar um método para mostrar os dados\n");
            Console.WriteLine(Speed.ExibirDados());
            Console.WriteLine(Gol.ExibirDados());




 

            Console.WriteLine("\n\n======================\nList\n======================");

            
            Console.WriteLine("\n\nUsando List e pegando os dados de algum elemento na List");
            List<Carro> listaCarros = new List<Carro>();

            listaCarros.Add(Gol);
            listaCarros.Add(Palio);
            listaCarros.Add(Saveiro);
            listaCarros.Add(Uno);

            Console.WriteLine(listaCarros[0].fabricante);
            listaCarros.Remove(Palio);

            Console.WriteLine("\n\nPercorrendo a List com um FOR:");
            for (int i = 0; i < listaCarros.Count; i++)
            {
                Console.WriteLine(listaCarros[i].ExibirDados());
            }

            // Foreach melhor para list
            Console.WriteLine("\n\nPercorrendo a List com um FOREACH:");
            foreach (var item in listaCarros)
            {
                Console.WriteLine(item.ExibirMarca());
            }



            // ======================
            // Exercícios
            // ======================

            Console.WriteLine("\n\n======================\nExercício 1\n======================");
            // Imprima na tela todos os clientes desse contexto,
            // Dica crie uma lista para eles.
            Console.WriteLine("\n\nCriando uma lista e add nela todos os clientes criados no program.cs e depois exibindo os dados deles");

            List<Cliente> listaClientes = new List<Cliente>();

            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);

            foreach (var item in listaClientes)
            {
                Console.WriteLine(item.ExibeDadosClientes() + item.getEndereco().EnderecoCompleto());
            }




            Console.WriteLine("\n\n======================\nExercício 2\n======================");
            // Crie uma lista com 560 produtos
            // Imprima na tela
            Console.WriteLine("\n\nCriando uma List do tipo Produto e adicionado nela 560 produtos criados com um FOR e depois mostrando os dados usando FOREACH\n");        

            List<Produto> listaProdutos = new List<Produto>();

            for (int i = 1; i <= 560; i++)
            {
                Produto p = new Produto(i, i * 2, "Produto nº " + i);
                listaProdutos.Add(p);
            }

            foreach (var item in listaProdutos)
            {
                Console.WriteLine(item.ExibeDados());
            }




            Console.WriteLine("\n\n======================\nExercício 3\n======================");
            // Crie uma lista que aceite qualquer tipo de veiculo 
            // Imprima na tela
            Console.WriteLine("\n\nCriando uma List que aceita qualquer tipo de veiculo, add os veiculos criados neste contexto nela e depois usando métodos e exibindo os dados de cada item adicionado \n");        


            List<Veiculo> listaVeiculos = new List<Veiculo>();
            
            listaVeiculos.Add(Gol);
            listaVeiculos.Add(Palio);
            listaVeiculos.Add(Saveiro);
            listaVeiculos.Add(Uno);
            listaVeiculos.Add(Speed);
            listaVeiculos.Add(Caloi);

            foreach (var item in listaVeiculos)
            {
                Console.WriteLine(item.ExibirDados());
           
        }
    }
} 