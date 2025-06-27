        string resposta = "s";
        List<string> livros = new List<string>();

        // Cadastro de livros
        while (resposta == "s")
        {
            string livro;

            do
            {
                Console.Write("Digite o nome do livro: ");
                livro = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(livro))
                {
                    Console.WriteLine("Por favor, digite um nome válido.");
                }
            } while (string.IsNullOrWhiteSpace(livro));

            Console.WriteLine("Livro cadastrado: " + livro);

            livros.Add(livro.Trim());

            do
            {
                Console.Write("Quer cadastrar outro livro? (s/n): ");
                resposta = Console.ReadLine().ToLower();
                if (resposta != "s" && resposta != "n")
                {
                    Console.WriteLine("Por favor, responda só com 's' ou 'n'.");
                }
            } while (resposta != "s" && resposta != "n");
        }

        // Mostrar livros cadastrados
        Console.WriteLine("\nLivros cadastrados:");
        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro foi cadastrado.");
        }
        else
        {
            for (int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {livros[i]}");
            }

            // Pergunta se deseja editar
            do
            {
                Console.Write("\nDeseja editar um livro da lista? (s/n): ");
                resposta = Console.ReadLine().ToLower();
                if (resposta != "s" && resposta != "n")
                {
                    Console.WriteLine("Por favor, responda só com 's' ou 'n'.");
                }
            } while (resposta != "s" && resposta != "n");

            if (resposta == "s")
            {
                int indiceEdicao;
                do
                {
                    Console.Write("Digite o número do livro que deseja editar: ");
                } while (!int.TryParse(Console.ReadLine(), out indiceEdicao) ||
                         indiceEdicao < 1 || indiceEdicao > livros.Count);

                Console.Write("Digite o novo nome para o livro: ");
                string novoNome = Console.ReadLine().Trim();

                while (string.IsNullOrWhiteSpace(novoNome))
                {
                    Console.Write("Nome inválido. Digite novamente: ");
                    novoNome = Console.ReadLine().Trim();
                }

                livros[indiceEdicao - 1] = novoNome;
                Console.WriteLine("✅ Livro atualizado com sucesso!");
            }

            // Pergunta se deseja remover
            do
            {
                Console.Write("\nDeseja remover um livro da lista? (s/n): ");
                resposta = Console.ReadLine().ToLower();
                if (resposta != "s" && resposta != "n")
                {
                    Console.WriteLine("Por favor, responda só com 's' ou 'n'.");
                }
            } while (resposta != "s" && resposta != "n");

            if (resposta == "s")
            {
                int indiceRemocao;
                do
                {
                    Console.Write("Digite o número do livro que deseja remover: ");
                } while (!int.TryParse(Console.ReadLine(), out indiceRemocao) ||
                         indiceRemocao < 1 || indiceRemocao > livros.Count);

                Console.WriteLine($"📕 Livro \"{livros[indiceRemocao - 1]}\" removido.");
                livros.RemoveAt(indiceRemocao - 1);
            }

            // Lista final de livros
            Console.WriteLine("\n📚 Lista final de livros:");
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro na lista.");
            }
            else
            {
                for (int i = 0; i < livros.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {livros[i]}");
                }
            }
        }

        Console.WriteLine("\n✅ Programa finalizado. Obrigado por usar o sistema de cadastro de livros!");