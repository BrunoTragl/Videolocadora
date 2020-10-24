using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Seed
{
    public static class ModelBuilderExtension
    {
        public static Random _random = new Random();
        public static void SeedData(this ModelBuilder modelBuilder, IVideolocadoraContext _context)
        {
            Funcionario[] funcionarios = new Funcionario[]
            {
                new Funcionario
                {
                    Id = 1,
                    Nome = "Administrador",
                    Sobrenome = " ",
                    Email = "adm@videolocadora.com.br",
                    Login = "admin",
                    Senha = "123456",
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Funcionario
                {
                    Id = 2,
                    Nome = "Bruno",
                    Sobrenome = "Tragl",
                    Email = "bruno.tragl@videolocadora.com.br",
                    Login = "brunotragl",
                    Senha = "123456",
                    Cadastro = DateTime.Now,
                    Ativo = true
                }
            };
            Cliente[] clientes = new Cliente[]
            {
                new Cliente
                {
                    Id = 1,
                    Nome = "Cleiton Alves",
                    Sobrenome = "Feitosa",
                    Email = GetEmailByNome("Cleiton","Feitosa"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 2,
                    Nome = "Leandro Gomes",
                    Sobrenome = "Silva",
                    Email = GetEmailByNome("Leandro","Silva"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 3,
                    Nome = "Aline Freitas",
                    Sobrenome = "Hashers",
                    Email = GetEmailByNome("Aline","Hashers"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 4,
                    Nome = "José de Arruda",
                    Sobrenome = "Braido",
                    Email = GetEmailByNome("Ze","Braido"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 5,
                    Nome = "Armando",
                    Sobrenome = "Severó",
                    Email = GetEmailByNome("Armando","Severo"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 6,
                    Nome = "Igor",
                    Sobrenome = "Leitosa",
                    Email = GetEmailByNome("Igor","Leitosa"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 7,
                    Nome = "Gustavo",
                    Sobrenome = "Trato",
                    Email = GetEmailByNome("Gustavo","Trato"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 8,
                    Nome = "Guilherme",
                    Sobrenome = "Arruda",
                    Email = GetEmailByNome("Guilherme","Arruda"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 9,
                    Nome = "Rosa Alves",
                    Sobrenome = "Lumini",
                    Email = GetEmailByNome("Rosa","Lumini"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 10,
                    Nome = "David Oliveira",
                    Sobrenome = "Carvalho",
                    Email = GetEmailByNome("David","Carvalho"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 11,
                    Nome = "Karine Maria Gonçalves",
                    Sobrenome = "Cortez",
                    Email = GetEmailByNome("Karine","Cortez"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 12,
                    Nome = "Gustavo Pereira",
                    Sobrenome = "Santos",
                    Email = GetEmailByNome("Gustavo","Santos"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 13,
                    Nome = "Leandro José Paulo",
                    Sobrenome = "Silva",
                    Email = GetEmailByNome("Leandro","Silva"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 14,
                    Nome = "Maria Nainam Silvino Araújo",
                    Sobrenome = "Santos",
                    Email = GetEmailByNome("Maria","Santos"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 15,
                    Nome = "Jullieny Melo",
                    Sobrenome = "Oliveira",
                    Email = GetEmailByNome("Jullieny","Oliveira"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 16,
                    Nome = "Daniel dos Santos",
                    Sobrenome = "Rocha",
                    Email = GetEmailByNome("Daniel","Rocha"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 17,
                    Nome = "Itamar de Carvalho",
                    Sobrenome = "Souza",
                    Email = GetEmailByNome("Itamar","Souza"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 18,
                    Nome = "Álvaro Rogério",
                    Sobrenome = "Batista",
                    Email = GetEmailByNome("Alvaro","Batista"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 19,
                    Nome = "Rita de Cássia dos",
                    Sobrenome = "Santos",
                    Email = GetEmailByNome("Rita","Santos"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 20,
                    Nome = "Alcione Monteiro Lucas",
                    Sobrenome = "Germino",
                    Email = GetEmailByNome("Alcione","Germino"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 21,
                    Nome = "Fabiana Flávia",
                    Sobrenome = "Silva",
                    Email = GetEmailByNome("Fabiana","Silva"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 22,
                    Nome = "Carolina Caraciolo de",
                    Sobrenome = "Souza",
                    Email = GetEmailByNome("Carolina","Souza"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 23,
                    Nome = "Jonas Augusto de Barros",
                    Sobrenome = "Chaves",
                    Email = GetEmailByNome("Jonas","Chaves"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 24,
                    Nome = "Carlos Andrade",
                    Sobrenome = "Silva",
                    Email = GetEmailByNome("Carlos","Silva"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 25,
                    Nome = "Luciana Dutra Cavalcanti",
                    Sobrenome = "Ricarte",
                    Email = GetEmailByNome("Rosa","Lumini"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 26,
                    Nome = "Denys Vytor de Queiroz da",
                    Sobrenome = "Silva",
                    Email = GetEmailByNome("Denys","Silva"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 27,
                    Nome = "Maria Auxiliadora da",
                    Sobrenome = "Silva",
                    Email = GetEmailByNome("Maria","Silva"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 28,
                    Nome = "Marcello Henryque da Silva Souza",
                    Sobrenome = "Veloso",
                    Email = GetEmailByNome("Marcello","Veloso"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 29,
                    Nome = "Marli Rodrigues",
                    Sobrenome = "Félix",
                    Email = GetEmailByNome("Marli","Felix"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 30,
                    Nome = "Milena Rolim",
                    Sobrenome = "Souza",
                    Email = GetEmailByNome("Milena","Souza"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 31,
                    Nome = "Glaucia Adriana Dantas",
                    Sobrenome = "Pereira",
                    Email = GetEmailByNome("Glaucia","Pereira"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 32,
                    Nome = "Joane Maria da Silva de",
                    Sobrenome = "Carvalho",
                    Email = GetEmailByNome("Joane","Carvalho"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 33,
                    Nome = "Kênia Stephanie Nunes",
                    Sobrenome = "Arruda",
                    Email = GetEmailByNome("Kenia","Arruda"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 34,
                    Nome = "Lorena Alcântara",
                    Sobrenome = "Farias",
                    Email = GetEmailByNome("Lorena","Farias"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 35,
                    Nome = "Maria Gisele da Silva",
                    Sobrenome = "Oliveira",
                    Email = GetEmailByNome("Maria","Oliveira"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 36,
                    Nome = "Diogo Fernandes de",
                    Sobrenome = "Souza",
                    Email = GetEmailByNome("Diogo","Souza"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 37,
                    Nome = "Elivelton Costa da",
                    Sobrenome = "Silva",
                    Email = GetEmailByNome("Elivelton","Silva"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 38,
                    Nome = "Genildson Alvez de",
                    Sobrenome = "Oliveira",
                    Email = GetEmailByNome("Genildson","Oliveira"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 39,
                    Nome = "Gerdon Adler Ribeiro",
                    Sobrenome = "Mafra",
                    Email = GetEmailByNome("Gerdon","Mafra"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Cliente
                {
                    Id = 40,
                    Nome = "Gilberto",
                    Sobrenome = "Oliveira",
                    Email = GetEmailByNome("Gilberto","Oliveira"),
                    Nascimento = GetRandomNascimento(),
                    Telefone = GetRandomFone(),
                    Cadastro = DateTime.Now,
                    Ativo = true
                }
            };
            Filme[] filmes = new Filme[] {
                new Filme
                {
                    Id = 1,
                    Titulo = "American Pie 3",
                    Descricao = "Jovens se aventuram em festas do colegial. Muita diversão e bebedeiras!!! HAHAHAHA",
                    UrlImagem = "https://vignette.wikia.nocookie.net/doblaje/images/1/1f/AmericanPieCampamento.jpg/revision/latest/top-crop/width/360/height/450?cb=20091001181345&path-prefix=es",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 2,
                    Titulo = "+ Velozes + Furiosos",
                    Descricao = "O ex-policial Brian comete uma grande traição, juntando-se a um amigo ex-presidiário no transporte de dinheiro sujo para uma importadora-exportadora muito suspeita.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/velozes-e-furiosos/images/a/aa/Velozes_e_Furiosos_-_Capa.jpg/revision/latest/top-crop/width/360/height/450?cb=20180305235641&path-prefix=pt-br",
                    Valor = 12.50M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 3,
                    Titulo = "Titanic",
                    Descricao = "A bordo do luxuoso transatlântico, Rose (Kate Winslet), uma jovem da alta sociedade, se sente pressionada com a vida que leva. Ao conhecer Jack (Leonardo DiCaprio), um artista pobre e aventureiro, os dois se apaixonam. Mas eles terão que enfrentar um desafio ainda maior que o preconceito social com o destino trágico do navio.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/maritime-disaster/images/b/b3/300px-RMS_Titanic_3.jpg/revision/latest/top-crop/width/360/height/450?cb=20170425130744",
                    Valor = 6.50M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 4,
                    Titulo = "O Poderoso Chefão",
                    Descricao = "Don Corleone (Marlon Brando) é chefe de uma das famílias de mafiosos italianos mais respeitadas de Nova York. Quando ele é ferido e afastado de suas funções, o filho Michael (Al Pacino) deve tomar as rédeas da situação para acabar com o responsável e manter a honra do pai intacta. Dirigido por Francis Ford Coppola e vencedor de três Oscars, incluindo o de Melhor Filme.",
                    UrlImagem = "https://images-na.ssl-images-amazon.com/images/I/41NrywwjCEL._AC_SY450_.jpg",
                    Valor = 7.80M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 5,
                    Titulo = "O Exterminador Do Futuro",
                    Descricao = "Num futuro dominado pelas máquinas, os computadores mandam ao passado um androide (Arnold Schwarzenegger) praticamente indestrutível. Sua missão é matar Sarah Connor antes que ela dê à luz o líder da resistência humana na guerra contra a inteligência artificial. Os seres humanos também enviam um agente para proteger a mulher.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/exterminadordofuturo/images/6/6f/Terminator.jpeg/revision/latest/top-crop/width/360/height/450?cb=20150730214551&path-prefix=pt-br",
                    Valor = 10.50M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 6,
                    Titulo = "Harry Potter E O Prisioneiro De Azkaban",
                    Descricao = "De volta para o terceiro ano em Hogwarts, Harry Potter (Daniel Radcliffe) encontra a escola sob estado de atenção: os sombrios dementadores cercam as proximidades do castelo em busca de Sirius Black (Gary Oldman), assassino recém-fugido da prisão de Azkaban que está atrás de Harry. Dirigido por Alfonso Cuarón e indicado ao Oscar de Melhor Canção Original e Melhores Efeitos Visuais.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/vozesportuguesas/images/a/a5/HP3.jpg/revision/latest/top-crop/width/360/height/450?cb=20200928052358&path-prefix=pt",
                    Valor = 8.50M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 7,
                    Titulo = "De Volta Para O Futuro",
                    Descricao = "Marty McFly (Michael J. Fox) é um jovem que acidentalmente viaja em uma máquina do tempo construída pelo cientista Doc Brown (Christopher Lloyd). Agora, nos anos 1950, ele vê seus pais que ainda não se apaixonaram. E, para não colocar em risco sua própria existência, ele precisa agir como cupido dos pais. Vencedor do Oscar de Melhor Edição de Som.",
                    UrlImagem = "https://images-na.ssl-images-amazon.com/images/I/916GbiXiQCL._SY450_.jpg",
                    Valor = 8.50M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 8,
                    Titulo = "Jurassic Park - O Parque Dos Dinossauros",
                    Descricao = "Com o auxílio da engenharia genética criada pelos doutores Alan (Sam Neill), Ellie (Laura Dern) e Ian, um milionário traz à vida dinossauros extintos há milhares de anos, criando um imenso parque em uma remota ilha. Porém, os gigantes pré-históricos começam a ameaçar a vida dos vistitantes. Vencedor de 3 Oscars, incluindo o de Melhores Efeitos Visuais.",
                    UrlImagem = "https://i.pinimg.com/originals/12/45/97/124597895a3367703ce104584c6dfd19.jpg",
                    Valor = 9.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 9,
                    Titulo = "O Senhor dos Anéis: A Sociedade do Anel",
                    Descricao = "Na Terra-Média, o hobbit Frodo (Elijah Woods) recebe de presente de seu tio o Um Anel, um anel mágico e maligno que precisa ser destruído antes que caia nas mãos do mal. Para isso ele terá um caminho árduo pela frente, mas para o cumprimento desta jornada aos poucos ele poderá contar com outros seres que formarão a Sociedade do Anel.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/liberproeliis/images/9/9a/Aragorn_Wikia.jpg/revision/latest/top-crop/width/360/height/450?cb=20200616201039&path-prefix=pt-br",
                    Valor = 7.60M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 10,
                    Titulo = "A Teoria De Tudo",
                    Descricao = "Baseado na biografia de Stephen Hawking (Eddie Redmayne), o filme mostra as importantes descobertas do aclamado astrofísico sobre o tempo. Além de retratar seu relacionamento com a esposa Jane e os desafios que vieram com a descoberta de uma doença degenerativa.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/figure-skating-13/images/2/29/Theoryofeverything.jpg/revision/latest/top-crop/width/360/height/450?cb=20181229212809",
                    Valor = 10.50M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 11,
                    Titulo = "Batman: O Cavaleiro das Trevas Ressurge",
                    Descricao = "Oito anos após a morte de Harvey Dent, a cidade de Gotham City está pacificada e não precisa mais do Batman. A situação faz com que Bruce Wayne (Christian Bale) se torne um homem recluso em sua mansão, convivendo apenas com o mordomo Alfred (Michael Caine). Um dia, em meio a uma festa realizada na Mansão Wayne, uma das garçonetes contratadas (Anne Hathaway) rouba um colar de grande valor sentimental. Curioso em descobrir quem é ela, Bruce retorna à caverna para usar os computadores que tanto lhe serviram. Aos poucos começa a perceber indícios do surgimento de uma nova ameaça a Gotham City, personificada no brutamontes Bane (Tom Hardy). É o suficiente para que volte a ser o Batman.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/marvel_dc/images/0/05/The_Dark_Knight_Rises_poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20120123215909",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 12,
                    Titulo = "Tróia",
                    Descricao = "Quando Páris (Orlando Bloom), o príncipe de Troia, se apaixona por Helena (Diane Kruger), rainha de Esparta, o rei Menelau (Brendan Gleeson) inicia uma guerra de anos entre os dois reinos. Para vencer, Esparta conta com Aquiles (Brad Pitt), um guerreiro lendário que comanda um exército próprio. Indicado ao Oscar de Melhor Figurino.",
                    UrlImagem = "https://i.pinimg.com/474x/2d/35/6a/2d356a67ffb38bbe93e2959fe45265c4.jpg",
                    Valor = 6.70M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 13,
                    Titulo = "Prometheus",
                    Descricao = "Elizabeth Shaw (Noomi Rapace) e Charlie Holloway (Logan Marshall-Green) fazem parte de uma equipe de cientistas que embarca em uma jornada espacial para descobrir a verdade sobre a origem da raça humana. A nave Prometheus também é composta pelo robô David (Michael Fassbender), a diretora Meredith Vickers (Charlize Theron), o capitão Janek (Idris Elba), entre outros. Quando eles chegam ao planeta de destino, eles encontram criaturas poderosas, violentas e revelações estarrecedoras.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/theflophouse/images/1/19/Prometheus-poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20170430003032",
                    Valor = 9.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 14,
                    Titulo = "O Impossível",
                    Descricao = "Baseado na história real de uma família de turistas durante um Tsunami que atingiu o sudeste asiático. Após a destruição causada pela onda gigante, uma mãe (Naomi Watts) tenta sobreviver com seu filho adolescente e reencontrar seu marido (Ewan McGregor) e seus dois filhos pequenos no meio do caos na Tailândia. Indicado ao Oscar de Melhor Atriz.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/my-little-baby-boy-harry-styles-fanfiction/images/f/fd/The_Impossible.png/revision/latest/top-crop/width/360/height/450?cb=20180923001955",
                    Valor = 8.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 15,
                    Titulo = "Alien, O Oitavo Passageiro",
                    Descricao = "A caminho da Terra, a nave Nostromo recebe um pedido de socorro de um planeta próximo. Ao desembarcar no local, um dos tripulantes é vítima de uma criatura alienígena, dando início a uma série de ataques assassinos dentro da espaçonave. Dirigido por Ridley Scott, o filme ganhou dois Oscars, incluindo o de Melhores Efeitos Visuais.",
                    UrlImagem = "https://pm1.narvii.com/6960/c67686f08b1b55962883d5575c56aaeb798662aar1-360-450v2_00.jpg",
                    Valor = 10.50M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 16,
                    Titulo = "A Lista de Schindler",
                    Descricao = "A inusitada história de Oskar Schindler (Liam Neeson), um sujeito oportunista, sedutor, 'armador', simpático, comerciante no mercado negro, mas, acima de tudo, um homem que se relacionava muito bem com o regime nazista, tanto que era membro do próprio Partido Nazista (o que não o impediu de ser preso algumas vezes, mas sempre o libertavam rapidamente, em razão dos seus contatos).",
                    UrlImagem = "https://vignette.wikia.nocookie.net/figure-skating-13/images/1/1f/MV5BMzMwMTM4MDU2N15BMl5BanBnXkFtZTgwMzQ0MjMxMDE%40._V1_SX640_SY720_.jpg/revision/latest/top-crop/width/360/height/450?cb=20160121092516",
                    Valor = 9.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 17,
                    Titulo = "Um Sonho de Liberdade",
                    Descricao = "Em 1946, Andy Dufresne (Tim Robbins), um jovem e bem sucedido banqueiro, tem a sua vida radicalmente modificada ao ser condenado por um crime que nunca cometeu, o homicídio de sua esposa e do amante dela. Ele é mandado para uma prisão que é o pesadelo de qualquer detento, a Penitenciária Estadual de Shawshank, no Maine.",
                    UrlImagem = "https://images-na.ssl-images-amazon.com/images/I/8189H-FijZL._AC_SY450_.jpg",
                    Valor = 8.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 18,
                    Titulo = "O Rei Leão",
                    Descricao = "Mufasa (voz de James Earl Jones), o Rei Leão, e a rainha Sarabi (voz de Madge Sinclair) apresentam ao reino o herdeiro do trono, Simba (voz de Matthew Broderick). O recém-nascido recebe a bênção do sábio babuíno Rafiki (voz de Robert Guillaume), mas ao crescer é envolvido nas artimanhas de seu tio Scar (voz de Jeremy Irons), o invejoso e maquiavélico irmão de Mufasa, que planeja livrar-se do sobrinho e herdar o trono.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/vozesportuguesas/images/2/2e/O_Rei_Le%C3%A3o.jpg/revision/latest/top-crop/width/360/height/450?cb=20200718121256&path-prefix=pt",
                    Valor = 10.50M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 19,
                    Titulo = "À Espera de um Milagre",
                    Descricao = "1935, no corredor da morte de uma prisão sulista. Paul Edgecomb (Tom Hanks) é o chefe de guarda da prisão, que temJohn Coffey (Michael Clarke Duncan) como um de seus prisioneiros. Aos poucos, desenvolve-se entre eles uma relação incomum, baseada na descoberta de que o prisioneiro possui um dom mágico que é, ao mesmo tempo, misterioso e milagroso.",
                    UrlImagem = "https://images-na.ssl-images-amazon.com/images/I/71D6IdIFSxL._AC_SY450_.jpg",
                    Valor = 9.40M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 20,
                    Titulo = "Forrest Gump - O Contador de Histórias",
                    Descricao = "Quarenta anos da história dos Estados Unidos, vistos pelos olhos de Forrest Gump (Tom Hanks), um rapaz com QI abaixo da média e boas intenções. Por obra do acaso, ele consegue participar de momentos cruciais, como a Guerra do Vietnã e Watergate, mas continua pensando no seu amor de infância, Jenny Curran.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/figure-skating-13/images/7/7f/Large_pEYI2QILJWMN1ZeEMgMM0jxBVhK.jpg/revision/latest/top-crop/width/360/height/450?cb=20170318095424",
                    Valor = 8.20M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 21,
                    Titulo = "A Vida é Bela",
                    Descricao = "Durante a Segunda Guerra Mundial na Itália, o judeu Guido (Roberto Benigni) e seu filho Giosué são levados para um campo de concentração nazista. Afastado da mulher, ele tem que usar sua imaginação para fazer o menino acreditar que estão participando de uma grande brincadeira, com o intuito de protegê-lo do terror e da violência que os cercam.",
                    UrlImagem = "https://images-na.ssl-images-amazon.com/images/I/51hH4OZGnLL._AC_SY450_.jpg",
                    Valor = 7.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 22,
                    Titulo = "Vingadores: Guerra Infinita",
                    Descricao = "Em Vingadores: Guerra Infinita, Thanos (Josh Brolin) enfim chega à Terra, disposto a reunir as Joias do Infinito. Para enfrentá-lo, os Vingadores precisam unir forças com os Guardiões da Galáxia, ao mesmo tempo em que lidam com desavenças entre alguns de seus integrantes.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/a/a0/AIWTAB.jpg/revision/latest/top-crop/width/360/height/450?cb=20200326084651",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 23,
                    Titulo = "Vingadores: Ultimato",
                    Descricao = "Em Vingadores: Ultimato, após Thanos eliminar metade das criaturas vivas em Vingadores: Guerra Infinita, os heróis precisam lidar com a dor da perda de amigos e seus entes queridos. Com Tony Stark (Robert Downey Jr.) vagando perdido no espaço sem água nem comida, o Capitão América/Steve Rogers (Chris Evans) e a Viúva Negra/Natasha Romanov (Scarlett Johansson) precisam liderar a resistência contra o titã louco.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/universocinematograficomarvel/images/b/b7/Images.jpg/revision/latest/top-crop/width/360/height/450?cb=20190505233213&path-prefix=pt",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 24,
                    Titulo = "Star Wars - O Império Contra-ataca",
                    Descricao = "As forças imperais comandadas por Darth Vader (David Prowse/James Earl Jones) lançam um ataque contra os membros da resistência, que são obrigados a fugir. Enquanto isso, Luke Skywalker (Mark Hamill) tenta encontrar o Mestre Yoda, que poderá ensiná-lo a dominar a 'Força' e torná-lo um cavaleiro Jedi. No entanto, Darth Vader planeja levá-lo para o Lado Negro da 'Força'.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/starwars/images/a/a8/TheEmpireStrikesBack_SFI_cover.jpg/revision/latest/top-crop/width/360/height/450?cb=20200303223254",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 25,
                    Titulo = "Star Wars: O Despertar da Força",
                    Descricao = "Com o desaparecimento de Luke Skywalker, a galáxia se encontra vulnerável para Kylo Ren e a Primeira Ordem. Rey, uma catadora de sucata do deserto, e Finn, um stormtrooper desertor, decidem se unir a Han Solo e Chewbacca numa busca desenfreada para restaurar a paz na galáxia.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/starwars/images/b/b8/TFANewAdventures-Hardcover.jpg/revision/latest/top-crop/width/360/height/450?cb=20170519154150",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 26,
                    Titulo = "Star Wars: Os Últimos Jedi",
                    Descricao = "A jovem Rey começa a mostrar fortes sinais da Força, o que a faz procurar Luke Skywalker, que se vê obrigado a tomar uma decisão que mudará sua vida para sempre. Enquanto isso, a Primeira Ordem é liderada por Kylo Ren e o General Hux para um ataque contra Leia e a Resistência.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/starwars/images/2/21/The_Last_Jedi_Studio_Fun.jpg/revision/latest/top-crop/width/360/height/450?cb=20201007114741",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 27,
                    Titulo = "Rogue One: Uma História Star Wars",
                    Descricao = "Um grupo de heróis improváveis chamado Aliança Rebelde se une para realizar um movimento arriscado e rouba os planos da Estrela da Morte, arma responsável por destruir o Império.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/starwars/images/d/dc/RogueOneJuniorNovel-Hardcover.png/revision/latest/top-crop/width/360/height/450?cb=20161208092628",
                    Valor = 10.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 28,
                    Titulo = "Star Wars: A Ascensão Skywalker",
                    Descricao = "Com o retorno do Imperador Palpatine, todos voltam a temer seu poder. A Resistência toma a frente da batalha, enquanto Rey, treinando para ser uma Jedi, ainda se encontra em conflito com seu passado e futuro.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/starwars/images/c/cf/TROS-ExpandedEdition-Hardcover.jpg/revision/latest/top-crop/width/360/height/450?cb=20200413192610",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 29,
                    Titulo = "Han Solo: Uma História Star Wars",
                    Descricao = "Em dificuldade financeira, o piloto Han Solo (Alden Ehrenreich) e sua namorada Qi'ra (Emilia Clarke) buscam algum trabalho. Eles conseguem pôr as mãos em uma substância valiosa, mas perigosa, que acaba levando à perseguição do Império e à separação entre os dois. Preocupado, Han usa toda a sua esperteza para se infiltrar num plano arriscado, mas que pode render a oportunidade de voltar à terra natal e reencontrar a sua amada. Caso ele falhe, vai ter que prestar contas ao perigoso Dryden Vos (Paul Bettany). No caminho, o piloto encontra parceiros importantes, como Chewbacca (Joonas Suotamo) e Lando Calrissian (Donald Glover), o proprietário original da Millennium Falcon.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/starwars/images/a/a9/Solo_A_Star_Wars_Story_Theatrical_Poster.png/revision/latest/top-crop/width/360/height/450?cb=20180409011120",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 30,
                    Titulo = "O Resgate do Soldado Ryan",
                    Descricao = "Ao desembarcar na Normandia, no dia 6 de junho de 1944, capitão Miller (Tom Hanks) recebe a missão de comandar um grupo do segundo batalhão para o resgate do soldado James Ryan, caçula de quatro irmãos, dentre os quais três morreram em combate. Por ordens do chefe George C. Marshall, eles precisam procurar o soldado e garantir o seu retorno, com vida, para casa.",
                    UrlImagem = "https://andersonvision.com/wp-content/uploads/2018/03/SPR_4K_3D-e1520299793289.jpg",
                    Valor = 7.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 31,
                    Titulo = "Django Livre",
                    Descricao = "Django (Jamie Foxx) é um escravo liberto cujo passado brutal com seus antigos proprietários leva-o ao encontro do caçador de recompensas alemão Dr. King Schultz (Christoph Waltz). Schultz está em busca dos irmãos assassinos Brittle, e somente Django pode levá-lo a eles. O pouco ortodoxo Schultz compra Django com a promessa de libertá-lo quando tiver capturado os irmãos Brittle, vivos ou mortos.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/sony-pictures-entertaiment/images/0/0b/P9287010_v_v8_aa.jpg/revision/latest/top-crop/width/360/height/450?cb=20190124223003",
                    Valor = 10.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 32,
                    Titulo = "Como Treinar o seu Dragão 2",
                    Descricao = "Cinco anos após convencer os habitantes de seu vilarejo que os dragões não devem ser combatidos, Soluço (voz de Jay Baruchel) convive com seu dragão Fúria da Noite, e estes animais integraram pacificamente a rotina dos moradores da ilha de Berk. Entre viagens pelos céus e corridas de dragões, Soluço descobre uma caverna secreta, onde centenas de novos dragões vivem. O local é protegido por Valka (voz de Cate Blanchett), mãe de Soluço, que foi afastada do filho quando ele ainda era um bebê. Juntos, eles precisarão proteger o mundo que conhecem do perigoso Drago Bludvist (Djimon Hounson), que deseja controlar todos os dragões existentes.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/universalstudios/images/3/36/How_to_train_your_dragon_2_poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20200705012036",
                    Valor = 7.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 33,
                    Titulo = "Gladiador",
                    Descricao = "Nos dias finais do reinado de Marcus Aurelius (Richard Harris), o imperador desperta a ira de seu filho Commodus (Joaquin Phoenix) ao tornar pública sua predileção em deixar o trono para Maximus (Russell Crowe), o comandante do exército romano. Sedento pelo poder, Commodus mata seu pai, assume a coroa e ordena a morte de Maximus, que consegue fugir antes de ser pego e passa a se esconder sob a identidade de um escravo e gladiador do Império Romano.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/samplelist/images/f/fb/Gladiator_%282000_film_poster%29.png/revision/latest/top-crop/width/360/height/450?cb=20200825182720",
                    Valor = 9.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 34,
                    Titulo = "À Procura da Felicidade",
                    Descricao = "Em À Procura da Felicidade, Chris Gardner (Will Smith) é um pai de família que enfrenta sérios problemas financeiros. Apesar de todas as tentativas em manter a família unida, Linda (Thandie Newton), sua esposa, decide partir. Chris agora é pai solteiro e precisa cuidar de Christopher (Jaden Smith), seu filho de apenas 5 anos. Ele tenta usar sua habilidade como vendedor para conseguir um emprego melhor, que lhe dê um salário mais digno. Chris consegue uma vaga de estagiário numa importante corretora de ações, mas não recebe salário pelos serviços prestados.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/jadensmith/images/8/81/Onesheet.jpg/revision/latest/top-crop/width/360/height/450?cb=20171128103224",
                    Valor = 10.00M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 35,
                    Titulo = "Divertida Mente",
                    Descricao = "Riley é uma garota divertida de 11 anos de idade, que deve enfrentar mudanças importantes em sua vida quando seus pais decidem deixar a sua cidade natal, no estado de Minnesota, para viver em San Francisco. Dentro do cérebro de Riley, convivem várias emoções diferentes, como a Alegria, o Medo, a Raiva, o Nojinho e a Tristeza. A líder deles é Alegria, que se esforça bastante para fazer com que a vida de Riley seja sempre feliz.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/vozesportuguesas/images/6/60/Divertida-Mente_%28Inside_Out%29.jpg/revision/latest/top-crop/width/360/height/450?cb=20200819022357&path-prefix=pt",
                    Valor = 7.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 36,
                    Titulo = "Até o Último Homem",
                    Descricao = "Durante a Segunda Guerra Mundial, o médico do exército Desmond T. Doss (Andrew Garfield) se recusa a pegar em uma arma e matar pessoas, porém, durante a Batalha de Okinawa ele trabalha na ala médica e salva mais de 75 homens, sendo condecorado. O que faz de Doss o primeiro Opositor Consciente da história norte-americana a receber a Medalha de Honra do Congresso.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/doblaje/images/b/b5/Hasta_el_ultimo_hombre_poster_oficial.jpg/revision/latest/top-crop/width/360/height/450?cb=20161214050010&path-prefix=es",
                    Valor = 10,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 37,
                    Titulo = "Orgulho e Preconceito",
                    Descricao = "Inglaterra, 1797. As cinco irmãs Bennet - Elizabeth (Keira Knightley), Jane (Rosamund Pike), Lydia (Jena Malone), Mary (Talulah Riley) e Kitty (Carey Mulligan) - foram criadas por uma mãe (Brenda Blethyn) que tinha fixação em lhes encontrar maridos que garantissem seu futuro. Porém Elizabeth deseja ter uma vida mais ampla do que apenas se dedicar ao marido, sendo apoiada pelo pai (Donald Sutherland). Quando o sr. Bingley (Simon Woods), um solteiro rico, passa a morar em uma mansão vizinha, as irmãs logo ficam agitadas. Jane logo parece que conquistará o coração do novo vizinho, enquanto que Elizabeth conhece o bonito e esnobe sr. Darcy (Matthew Macfadyen). Os encontros entre Elizabeth e Darcy passam a ser cada vez mais constantes, apesar deles sempre discutirem.",
                    UrlImagem = "https://i.pinimg.com/474x/ca/7a/cf/ca7acf060eb528325ee8f5da4040d9d6.jpg",
                    Valor = 9.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 38,
                    Titulo = "Clube da Luta",
                    Descricao = "Jack (Edward Norton) é um executivo jovem, trabalha como investigador de seguros, mora confortavelmente, mas ele está ficando cada vez mais insatisfeito com sua vida medíocre. Para piorar ele está enfrentando uma terrível crise de insônia, até que encontra uma cura inusitada para o sua falta de sono ao frequentar grupos de auto-ajuda. Nesses encontros ele passa a conviver com pessoas problemáticas como a viciada Marla Singer (Helena Bonham Carter) e a conhecer estranhos como Tyler Durden (Brad Pitt). Misterioso e cheio de ideias, Tyler apresenta para Jack um grupo secreto que se encontra para extravasar suas angústias e tensões através de violentos combates corporais.",
                    UrlImagem = "https://i.pinimg.com/originals/9e/a9/9e/9ea99e70bc6639670d1a506a18e83e22.jpg",
                    Valor = 9.99M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 39,
                    Titulo = "Interestelar",
                    Descricao = "Após ver a Terra consumindo boa parte de suas reservas naturais, um grupo de astronautas recebe a missão de verificar possíveis planetas para receberem a população mundial, possibilitando a continuação da espécie. Cooper (Matthew McConaughey) é chamado para liderar o grupo e aceita a missão sabendo que pode nunca mais ver os filhos. Ao lado de Brand (Anne Hathaway), Jenkins (Marlon Sanders) e Doyle (Wes Bentley), ele seguirá em busca de uma nova casa. Com o passar dos anos, sua filha Murph (Mackenzie Foy e Jessica Chastain) investirá numa própria jornada para também tentar salvar a população do planeta.",
                    UrlImagem = "https://vignette.wikia.nocookie.net/chrisnolan/images/4/46/Interstellar_poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20160812013355",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                },
                new Filme
                {
                    Id = 40,
                    Titulo = "Matrix",
                    Descricao = "Em um futuro próximo, Thomas Anderson (Keanu Reeves), um jovem programador de computador que mora em um cubículo escuro, é atormentado por estranhos pesadelos nos quais encontra-se conectado por cabos e contra sua vontade, em um imenso sistema de computadores do futuro. Em todas essas ocasiões, acorda gritando no exato momento em que os eletrodos estão para penetrar em seu cérebro. À medida que o sonho se repete, Anderson começa a ter dúvidas sobre a realidade. Por meio do encontro com os misteriosos Morpheus (Laurence Fishburne) e Trinity (Carrie-Anne Moss), Thomas descobre que é, assim como outras pessoas, vítima do Matrix, um sistema inteligente e artificial que manipula a mente das pessoas, criando a ilusão de um mundo real enquanto usa os cérebros e corpos dos indivíduos para produzir energia. Morpheus, entretanto, está convencido de que Thomas é Neo, o aguardado messias capaz de enfrentar o Matrix e conduzir as pessoas de volta à realidade e à liberdade.",
                    UrlImagem = "https://imgc.artprintimages.com/img/print/carrie-anne-moss_u-l-pnenjz0.jpg",
                    Valor = 12.90M,
                    Cadastro = DateTime.Now,
                    Ativo = true
                }
            };
            //Aluguel[] alugueis = new Aluguel[] {
            //    new Aluguel
            //    {
            //        Id = 1,
            //        Funcionario = funcionarios[0],
            //        FuncionarioId = funcionarios[0].Id,
            //        Cliente = clientes[3],
            //        ClienteId = clientes[3].Id,
            //        Filme = filmes[5],
            //        FilmeId = filmes[5].Id,
            //        ValorPago = 0,
            //        Cadastro = DateTime.Now,
            //        Ativo = true
            //    },
            //    new Aluguel
            //    {
            //        Id = 2,
            //        Funcionario = funcionarios[0],
            //        FuncionarioId = funcionarios[0].Id,
            //        Cliente = clientes[5],
            //        ClienteId = clientes[5].Id,
            //        Filme = filmes[10],
            //        FilmeId = filmes[10].Id,
            //        ValorPago = 0,
            //        Cadastro = new DateTime(2020,8,26),
            //        Ativo = true
            //    },
            //    new Aluguel
            //    {
            //        Id = 3,
            //        Funcionario = funcionarios[1],
            //        FuncionarioId = funcionarios[1].Id,
            //        Cliente = clientes[7],
            //        ClienteId = clientes[7].Id,
            //        Filme = filmes[15],
            //        FilmeId = filmes[15].Id,
            //        ValorPago = 0,
            //        Cadastro = new DateTime(2020,7,20),
            //        Ativo = true
            //    },
            //    new Aluguel
            //    {
            //        Id = 4,
            //        Funcionario = funcionarios[1],
            //        FuncionarioId = funcionarios[1].Id,
            //        Cliente = clientes[22],
            //        ClienteId = clientes[22].Id,
            //        Filme = filmes[6],
            //        FilmeId = filmes[6].Id,
            //        ValorPago = 0,
            //        Cadastro = new DateTime(2020,10,21),
            //        Ativo = true
            //    },
            //    new Aluguel
            //    {
            //        Id = 5,
            //        Funcionario = funcionarios[1],
            //        FuncionarioId = funcionarios[1].Id,
            //        Cliente = clientes[33],
            //        ClienteId = clientes[33].Id,
            //        Filme = filmes[38],
            //        FilmeId = filmes[38].Id,
            //        ValorPago = 0,
            //        Cadastro = new DateTime(2020,10,20),
            //        Ativo = true
            //    }
            //};

            modelBuilder.Entity<Funcionario>().HasData(funcionarios);
            modelBuilder.Entity<Cliente>().HasData(clientes);
            modelBuilder.Entity<Filme>().HasData(filmes);
            //modelBuilder.Entity<Aluguel>().HasData(alugueis);
        }

        private static string GetRandomFone() => $"({_random.Next(9, 100)}) {_random.Next(999, 9999)}-{_random.Next(999, 9999)}";
        
        private static DateTime GetRandomNascimento() => new DateTime(_random.Next(1940, 2001), _random.Next(1, 12), _random.Next(1, 28));

        private static string GetEmailByNome(string nome, string sobrenome) => $"{nome.ToLower()}.{sobrenome.ToLower()}@contoso.xpto.com";
    }
}
