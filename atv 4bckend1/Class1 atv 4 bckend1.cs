
using System;
using System.Collections.Generic;
using System.Linq;

namespace AtividadesMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("      ATIVIDADES - 15 EXERCICIOS");
                Console.WriteLine("====================================");
                Console.WriteLine("1 - Escola");
                Console.WriteLine("2 - Academia");
                Console.WriteLine("3 - Cinema");
                Console.WriteLine("4 - Restaurante");
                Console.WriteLine("5 - Hotel");
                Console.WriteLine("6 - Cadastro de alunos");
                Console.WriteLine("7 - Catalogo de produtos");
                Console.WriteLine("8 - Biblioteca");
                Console.WriteLine("9 - Clinica veterinaria");
                Console.WriteLine("10 - Loja de eletronicos");
                Console.WriteLine("11 - Sistema de notas");
                Console.WriteLine("12 - Sistema de estoque");
                Console.WriteLine("13 - Sistema de pedidos");
                Console.WriteLine("14 - Sistema de cursos");
                Console.WriteLine("15 - Cadastro de funcionarios");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opcao: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                    opcao = -1;

                Console.Clear();

                switch (opcao)
                {
                    case 1: Escola(); break;
                    case 2: Academia(); break;
                    case 3: Cinema(); break;
                    case 4: Restaurante(); break;
                    case 5: Hotel(); break;
                    case 6: Alunos(); break;
                    case 7: Produtos(); break;
                    case 8: Biblioteca(); break;
                    case 9: Veterinaria(); break;
                    case 10: Eletronicos(); break;
                    case 11: Notas(); break;
                    case 12: Estoque(); break;
                    case 13: Pedidos(); break;
                    case 14: Cursos(); break;
                    case 15: Funcionarios(); break;
                    case 0: Console.WriteLine("Programa encerrado."); break;
                    default: Console.WriteLine("Opcao invalida."); break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione uma tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 0);
        }

        // EXERCICIO 1 - ESCOLA
        static void Escola()
        {
            Console.WriteLine("ESCOLA SENAI");
            Console.WriteLine("Formacao profissional e ensino de qualidade.");
            Console.WriteLine("Endereco: Rua da Educacao, 100");
            Console.WriteLine("Telefone: (11) 4000-1234");
            Console.WriteLine("\nCURSOS:");
            Console.WriteLine("- Desenvolvimento de Sistemas");
            Console.WriteLine("- Administracao");
            Console.WriteLine("- Logistica");
            Console.WriteLine("- Eletricista");
            Console.WriteLine("\nContato: contato@escola.com.br");
        }

        // EXERCICIO 2 - ACADEMIA
        static void Academia()
        {
            Console.WriteLine("ACADEMIA FITNESS");
            Console.WriteLine("Treine, evolua e alcance seus objetivos.");

            Console.WriteLine("\nMUSCULACAO:");
            Console.WriteLine("- Agachamento");
            Console.WriteLine("- Supino");
            Console.WriteLine("- Remada");
            Console.WriteLine("- Leg press");
            Console.WriteLine("- Rosca direta");

            Console.WriteLine("\nCARDIO:");
            Console.WriteLine("- Esteira");
            Console.WriteLine("- Bicicleta");
            Console.WriteLine("- Eliptico");
            Console.WriteLine("- Pular corda");

            Console.WriteLine("\nPLANOS:");
            Console.WriteLine("Basico: R$ 79,90");
            Console.WriteLine("Plus: R$ 109,90");
            Console.WriteLine("Premium: R$ 149,90");
        }

        // EXERCICIO 3 - CINEMA
        static void Cinema()
        {
            string[,] filmes =
            {
                {"Aventura Espacial", "Aventura", "10 anos", "14:00"},
                {"O Misterio", "Suspense", "12 anos", "16:00"},
                {"Risos em Familia", "Comedia", "Livre", "18:00"},
                {"Herois da Cidade", "Acao", "12 anos", "19:30"},
                {"O Oceano", "Drama", "10 anos", "21:00"}
            };

            Console.WriteLine("FILMES EM CARTAZ\n");

            Console.WriteLine("{0,-22} {1,-12} {2,-12} {3}",
                "Filme", "Genero", "Classificacao", "Horario");

            for (int i = 0; i < filmes.GetLength(0); i++)
            {
                Console.WriteLine("{0,-22} {1,-12} {2,-12} {3}",
                    filmes[i, 0], filmes[i, 1],
                    filmes[i, 2], filmes[i, 3]);
            }

            Console.WriteLine("\nINGRESSOS:");
            Console.WriteLine("Inteira: R$ 30,00");
            Console.WriteLine("Meia-entrada: R$ 15,00");
            Console.WriteLine("Sessao especial: R$ 20,00");
        }

        // EXERCICIO 4 - RESTAURANTE
        static void Restaurante()
        {
            string[,] pratos =
            {
                {"Feijoada", "Feijao e acompanhamentos", "32,00"},
                {"Frango grelhado", "Frango, arroz e salada", "25,00"},
                {"Lasanha", "Lasanha a bolonhesa", "28,00"},
                {"Parmegiana", "Carne com queijo", "34,00"},
                {"Risoto", "Risoto de legumes", "27,00"}
            };

            Console.WriteLine("RESTAURANTE SABOR DA CASA\n");
            Console.WriteLine("CARDAPIO:");

            for (int i = 0; i < pratos.GetLength(0); i++)
            {
                Console.WriteLine("\nPrato: " + pratos[i, 0]);
                Console.WriteLine("Descricao: " + pratos[i, 1]);
                Console.WriteLine("Preco: R$ " + pratos[i, 2]);
            }

            Console.WriteLine("\nBEBIDAS:");
            Console.WriteLine("Agua - R$ 4,00");
            Console.WriteLine("Refrigerante - R$ 6,00");
            Console.WriteLine("Suco natural - R$ 8,00");
            Console.WriteLine("Cafe - R$ 4,00");
            Console.WriteLine("Cha gelado - R$ 6,00");

            Console.WriteLine("\nContato: (11) 3333-2222");
        }

        // EXERCICIO 5 - HOTEL
        static void Hotel()
        {
            Console.WriteLine("HOTEL BOA ESTADIA");

            Console.WriteLine("\nQUARTO STANDARD");
            Console.WriteLine("Capacidade: 2 pessoas");
            Console.WriteLine("Descricao: Quarto confortavel");
            Console.WriteLine("Diaria: R$ 180,00");

            Console.WriteLine("\nQUARTO LUXO");
            Console.WriteLine("Capacidade: 3 pessoas");
            Console.WriteLine("Descricao: Quarto amplo com vista");
            Console.WriteLine("Diaria: R$ 320,00");

            Console.WriteLine("\nSUITE");
            Console.WriteLine("Capacidade: 4 pessoas");
            Console.WriteLine("Descricao: Sala e quarto separados");
            Console.WriteLine("Diaria: R$ 450,00");

            Console.WriteLine("\nSERVICOS:");
            Console.WriteLine("- Cafe da manha");
            Console.WriteLine("- Wi-Fi");
            Console.WriteLine("- Piscina");
            Console.WriteLine("- Estacionamento");
            Console.WriteLine("\nContato: (11) 5555-1212");
        }

        // EXERCICIO 6 - CADASTRO DE ALUNOS
        static void Alunos()
        {
            string[] nomes =
            {
                "Ana", "Bruno", "Carlos", "Daniela",
                "Eduardo", "Fernanda", "Gabriel", "Helena"
            };

            Console.WriteLine("CADASTRO DE ALUNOS\n");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(
                    "ID: " + (i + 1) +
                    " | Nome: " + nomes[i] +
                    " | Idade: " + (15 + i) +
                    " | Curso: Informatica");
            }

            Console.Write("\nDigite um ID para consultar: ");

            if (int.TryParse(Console.ReadLine(), out int id)
                && id >= 1 && id <= nomes.Length)
            {
                Console.WriteLine("Aluno: " + nomes[id - 1]);
                Console.WriteLine("Idade: " + (15 + id - 1));
                Console.WriteLine("Curso: Informatica");
            }
            else
            {
                Console.WriteLine("ID nao encontrado.");
            }
        }

        // EXERCICIO 7 - CATALOGO DE PRODUTOS
        static void Produtos()
        {
            string[] nomes =
            {
                "Mouse", "Teclado", "Monitor", "Notebook",
                "Impressora", "Cabo USB", "Fone", "Webcam",
                "Carregador", "Mousepad"
            };

            Console.WriteLine("CATALOGO DE PRODUTOS\n");

            for (int i = 0; i < nomes.Length; i++)
            {
                int estoque = i % 4 == 0 ? 0 : i + 2;
                decimal preco = (i + 1) * 25m;

                Console.WriteLine(
                    nomes[i] +
                    " | Categoria: Informatica" +
                    " | Estoque: " + estoque +
                    " | Preco: R$ " + preco.ToString("F2") +
                    " | Situacao: " +
                    (estoque == 0 ? "Produto esgotado" : "Disponivel"));
            }

            Console.WriteLine("\nProdutos disponiveis:");
            for (int i = 0; i < nomes.Length; i++)
            {
                int estoque = i % 4 == 0 ? 0 : i + 2;

                if (estoque > 0)
                    Console.WriteLine(nomes[i]);
            }
        }

        // EXERCICIO 8 - BIBLIOTECA
        static void Biblioteca()
        {
            string[] titulos =
            {
                "Dom Casmurro", "O Pequeno Principe",
                "A Ilha Misteriosa", "Memorias Postumas",
                "O Hobbit", "Capitaes da Areia",
                "A Revolucao dos Bichos", "Viagem ao Centro da Terra",
                "O Cortico", "A Moreninha"
            };

            Console.WriteLine("BIBLIOTECA\n");

            for (int i = 0; i < titulos.Length; i++)
            {
                bool disponivel = i % 3 != 0;

                Console.WriteLine(
                    "Titulo: " + titulos[i] +
                    " | Autor: Autor " + (i + 1) +
                    " | Ano: " + (2015 + i) +
                    " | Situacao: " +
                    (disponivel ? "Disponivel para emprestimo" : "Emprestado"));
            }

            Console.WriteLine("\nLIVROS DISPONIVEIS:");
            for (int i = 0; i < titulos.Length; i++)
            {
                if (i % 3 != 0)
                    Console.WriteLine(titulos[i]);
            }
        }

        // EXERCICIO 9 - CLINICA VETERINARIA
        static void Veterinaria()
        {
            string[] nomes =
            {
                "Rex", "Mimi", "Thor", "Luna",
                "Bob", "Nina", "Max", "Mel"
            };

            string[] especies =
            {
                "Cachorro", "Gato", "Cachorro", "Gato",
                "Cachorro", "Gato", "Cachorro", "Gato"
            };

            Console.WriteLine("CLINICA VETERINARIA\n");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(
                    nomes[i] +
                    " | Especie: " + especies[i] +
                    " | Idade: " + (i + 1) +
                    " | Dono: Dono " + (i + 1));
            }

            Console.WriteLine("\n1 - Mostrar cachorros");
            Console.WriteLine("2 - Mostrar gatos");
            Console.Write("Escolha: ");

            string escolha = Console.ReadLine() ?? "";

            for (int i = 0; i < nomes.Length; i++)
            {
                if ((escolha == "1" && especies[i] == "Cachorro") ||
                    (escolha == "2" && especies[i] == "Gato"))
                {
                    Console.WriteLine(nomes[i] + " - " + especies[i]);
                }
            }
        }

        // EXERCICIO 10 - LOJA DE ELETRONICOS
        static void Eletronicos()
        {
            string[] nomes =
            {
                "Notebook", "Celular", "Tablet", "Monitor",
                "Teclado", "Mouse", "Impressora", "Fone",
                "Webcam", "Smartwatch", "Caixa de som", "Carregador"
            };

            Console.WriteLine("LOJA DE ELETRONICOS\n");

            for (int i = 0; i < nomes.Length; i++)
            {
                int estoque = i % 5 == 0 ? 0 : i + 1;
                decimal preco = 100m * (i + 1);
                string categoria = i % 2 == 0 ? "Informatica" : "Acessorios";

                Console.WriteLine(
                    nomes[i] +
                    " | Marca: Marca " + (i + 1) +
                    " | Categoria: " + categoria +
                    " | Preco: R$ " + preco.ToString("F2") +
                    " | Estoque: " + estoque +
                    " | " + (estoque > 0 ? "Disponivel" : "Produto esgotado"));
            }

            Console.WriteLine("\nProdutos com preco inferior a R$ 300:");
            for (int i = 0; i < nomes.Length; i++)
            {
                decimal preco = 100m * (i + 1);

                if (preco < 300m)
                    Console.WriteLine(nomes[i] + " - R$ " + preco.ToString("F2"));
            }
        }

        // EXERCICIO 11 - SISTEMA DE NOTAS
        static void Notas()
        {
            Console.WriteLine("SISTEMA DE NOTAS\n");

            for (int i = 1; i <= 10; i++)
            {
                double n1 = 3 + (i % 7);
                double n2 = 4 + (i % 6);
                double n3 = 2 + (i % 8);
                double media = (n1 + n2 + n3) / 3;

                string situacao;

                if (media >= 6)
                    situacao = "Aprovado";
                else if (media >= 4)
                    situacao = "Recuperacao";
                else
                    situacao = "Reprovado";

                Console.WriteLine(
                    "Aluno " + i +
                    " | Curso: Informatica" +
                    " | Media: " + media.ToString("F2") +
                    " | Situacao: " + situacao);
            }
        }

        // EXERCICIO 12 - SISTEMA DE ESTOQUE
        static void Estoque()
        {
            Console.WriteLine("SISTEMA DE ESTOQUE\n");

            for (int i = 1; i <= 15; i++)
            {
                int quantidade = i % 5 == 0 ? 0 : i % 4;
                int minimo = 2;
                string situacao;

                if (quantidade == 0)
                    situacao = "ESGOTADO";
                else if (quantidade <= minimo)
                    situacao = "ESTOQUE BAIXO";
                else
                    situacao = "ESTOQUE NORMAL";

                Console.WriteLine(
                    "Produto " + i +
                    " | Categoria: Geral" +
                    " | Estoque: " + quantidade +
                    " | Minimo: " + minimo +
                    " | Preco: R$ " + (i * 10).ToString("F2") +
                    " | " + situacao);
            }
        }

        // EXERCICIO 13 - SISTEMA DE PEDIDOS
        static void Pedidos()
        {
            string[] status =
            {
                "Recebido", "Em preparo", "Pronto", "Entregue"
            };

            decimal totalGeral = 0;
            int recebidos = 0;
            int preparo = 0;
            int prontos = 0;
            int entregues = 0;

            Console.WriteLine("SISTEMA DE PEDIDOS\n");

            for (int i = 1; i <= 10; i++)
            {
                int quantidade = i % 3 + 1;
                decimal preco = 12m + i;
                decimal total = quantidade * preco;
                string situacao = status[i % 4];

                totalGeral += total;

                if (situacao == "Recebido") recebidos++;
                if (situacao == "Em preparo") preparo++;
                if (situacao == "Pronto") prontos++;
                if (situacao == "Entregue") entregues++;

                Console.WriteLine(
                    "Pedido " + i +
                    " | Cliente " + i +
                    " | Produto: Lanche " + i +
                    " | Quantidade: " + quantidade +
                    " | Total: R$ " + total.ToString("F2") +
                    " | Status: " + situacao);
            }

            Console.WriteLine("\nRESUMO:");
            Console.WriteLine("Total de pedidos: 10");
            Console.WriteLine("Valor total: R$ " + totalGeral.ToString("F2"));
            Console.WriteLine("Recebidos: " + recebidos);
            Console.WriteLine("Em preparo: " + preparo);
            Console.WriteLine("Prontos: " + prontos);
            Console.WriteLine("Entregues: " + entregues);
        }

        // EXERCICIO 14 - SISTEMA DE CURSOS
        static void Cursos()
        {
            Console.WriteLine("SISTEMA DE CURSOS\n");

            int disponiveis = 0;
            int lotados = 0;
            int online = 0;
            int presenciais = 0;

            for (int i = 1; i <= 10; i++)
            {
                int vagas = i % 4 == 0 ? 0 : 20 - i;
                string modalidade = i % 2 == 0 ? "Online" : "Presencial";

                if (vagas > 0) disponiveis++;
                else lotados++;

                if (modalidade == "Online") online++;
                else presenciais++;

                Console.WriteLine(
                    "Curso " + i +
                    " | Carga horaria: " + (40 * i) + " horas" +
                    " | Modalidade: " + modalidade +
                    " | Vagas: " + vagas +
                    " | Valor: R$ " + (100 * i).ToString("F2") +
                    " | " + (vagas > 0 ? "Inscricoes abertas" : "Turma lotada"));
            }

            Console.WriteLine("\nRESUMO:");
            Console.WriteLine("Total de cursos: 10");
            Console.WriteLine("Cursos disponiveis: " + disponiveis);
            Console.WriteLine("Cursos lotados: " + lotados);
            Console.WriteLine("Cursos online: " + online);
            Console.WriteLine("Cursos presenciais: " + presenciais);
        }

        // EXERCICIO 15 - CADASTRO DE FUNCIONARIOS
        static void Funcionarios()
        {
            Console.WriteLine("CADASTRO DE FUNCIONARIOS\n");

            int ativos = 0;
            int inativos = 0;
            decimal somaSalarios = 0;
            decimal maiorSalario = 0;
            decimal menorSalario = decimal.MaxValue;

            Dictionary<string, int> departamentos =
                new Dictionary<string, int>();

            for (int i = 1; i <= 15; i++)
            {
                string nome = "Funcionario " + i;
                string cargo = i % 2 == 0 ? "Analista" : "Assistente";
                string departamento =
                    i % 3 == 0 ? "Vendas" :
                    i % 3 == 1 ? "TI" : "RH";

                decimal salario = 1800m + i * 350m;
                bool ativo = i % 5 != 0;

                string situacao = ativo
                    ? "Funcionario ativo"
                    : "Funcionario desligado";

                string faixa = salario < 2500m
                    ? "Faixa 1"
                    : salario <= 5000m
                        ? "Faixa 2"
                        : "Faixa 3";

                if (ativo) ativos++;
                else inativos++;

                somaSalarios += salario;

                if (salario > maiorSalario)
                    maiorSalario = salario;

                if (salario < menorSalario)
                    menorSalario = salario;

                if (!departamentos.ContainsKey(departamento))
                    departamentos[departamento] = 0;

                departamentos[departamento]++;

                Console.WriteLine(
                    nome +
                    " | Cargo: " + cargo +
                    " | Departamento: " + departamento +
                    " | Salario: R$ " + salario.ToString("F2") +
                    " | " + situacao +
                    " | " + faixa);
            }

            Console.WriteLine("\nDASHBOARD:");
            Console.WriteLine("Total de funcionarios: 15");
            Console.WriteLine("Funcionarios ativos: " + ativos);
            Console.WriteLine("Funcionarios inativos: " + inativos);

            Console.WriteLine("\nFuncionarios por departamento:");
            foreach (var departamento in departamentos)
            {
                Console.WriteLine(
                    departamento.Key + ": " + departamento.Value);
            }

            Console.WriteLine(
                "\nMedia salarial: R$ " +
                (somaSalarios / 15).ToString("F2"));

            Console.WriteLine(
                "Maior salario: R$ " + maiorSalario.ToString("F2"));

            Console.WriteLine(
                "Menor salario: R$ " + menorSalario.ToString("F2"));
        }
    }
}

