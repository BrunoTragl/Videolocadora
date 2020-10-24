using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Sobrenome = table.Column<string>(type: "VARCHAR(300)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(300)", nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "filme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "VARCHAR(300)", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(1000)", nullable: false),
                    UrlImagem = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Sobrenome = table.Column<string>(type: "VARCHAR(300)", nullable: false),
                    Login = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(300)", nullable: true),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aluguel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorPago = table.Column<decimal>(nullable: false),
                    Multa = table.Column<decimal>(nullable: false),
                    Devolucao = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: false),
                    FilmeId = table.Column<int>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aluguel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aluguel_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aluguel_filme_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aluguel_funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cliente",
                columns: new[] { "Id", "Ativo", "Cadastro", "Email", "Nascimento", "Nome", "Sobrenome", "Telefone" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(5244), "cleiton.feitosa@contoso.xpto.com", new DateTime(1995, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleiton Alves", "Feitosa", "(9) 9384-4592" },
                    { 23, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6470), "jonas.chaves@contoso.xpto.com", new DateTime(1965, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonas Augusto de Barros", "Chaves", "(56) 5803-1059" },
                    { 24, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6477), "carlos.silva@contoso.xpto.com", new DateTime(1949, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos Andrade", "Silva", "(95) 7469-6573" },
                    { 25, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6483), "rosa.lumini@contoso.xpto.com", new DateTime(1963, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luciana Dutra Cavalcanti", "Ricarte", "(73) 8044-5667" },
                    { 26, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6490), "denys.silva@contoso.xpto.com", new DateTime(1994, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denys Vytor de Queiroz da", "Silva", "(48) 2669-8837" },
                    { 27, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6496), "maria.silva@contoso.xpto.com", new DateTime(1960, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maria Auxiliadora da", "Silva", "(93) 9193-4264" },
                    { 28, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6502), "marcello.veloso@contoso.xpto.com", new DateTime(1969, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcello Henryque da Silva Souza", "Veloso", "(80) 1702-4974" },
                    { 29, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6510), "marli.felix@contoso.xpto.com", new DateTime(1975, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marli Rodrigues", "Félix", "(87) 7104-4527" },
                    { 31, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6523), "glaucia.pereira@contoso.xpto.com", new DateTime(1972, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Glaucia Adriana Dantas", "Pereira", "(29) 1916-3860" },
                    { 32, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6530), "joane.carvalho@contoso.xpto.com", new DateTime(1976, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joane Maria da Silva de", "Carvalho", "(88) 2709-4780" },
                    { 33, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6536), "kenia.arruda@contoso.xpto.com", new DateTime(1985, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kênia Stephanie Nunes", "Arruda", "(44) 5250-6795" },
                    { 34, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6543), "lorena.farias@contoso.xpto.com", new DateTime(1971, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorena Alcântara", "Farias", "(48) 2151-1073" },
                    { 35, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6549), "maria.oliveira@contoso.xpto.com", new DateTime(1975, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maria Gisele da Silva", "Oliveira", "(29) 5108-7905" },
                    { 36, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6556), "diogo.souza@contoso.xpto.com", new DateTime(1948, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diogo Fernandes de", "Souza", "(38) 4549-6325" },
                    { 37, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6562), "elivelton.silva@contoso.xpto.com", new DateTime(1955, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elivelton Costa da", "Silva", "(80) 2792-1863" },
                    { 38, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6569), "genildson.oliveira@contoso.xpto.com", new DateTime(1990, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genildson Alvez de", "Oliveira", "(56) 2031-5012" },
                    { 39, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6575), "gerdon.mafra@contoso.xpto.com", new DateTime(1956, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerdon Adler Ribeiro", "Mafra", "(16) 1569-3808" },
                    { 40, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6611), "gilberto.oliveira@contoso.xpto.com", new DateTime(1963, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gilberto", "Oliveira", "(18) 6777-1569" },
                    { 22, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6463), "carolina.souza@contoso.xpto.com", new DateTime(1941, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carolina Caraciolo de", "Souza", "(99) 1833-2841" },
                    { 21, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6456), "fabiana.silva@contoso.xpto.com", new DateTime(1962, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fabiana Flávia", "Silva", "(35) 6062-4668" },
                    { 30, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6516), "milena.souza@contoso.xpto.com", new DateTime(1999, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milena Rolim", "Souza", "(61) 9137-9434" },
                    { 19, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6443), "rita.santos@contoso.xpto.com", new DateTime(1944, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rita de Cássia dos", "Santos", "(54) 3106-3930" },
                    { 20, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6450), "alcione.germino@contoso.xpto.com", new DateTime(1957, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alcione Monteiro Lucas", "Germino", "(85) 4808-7569" },
                    { 2, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6254), "leandro.silva@contoso.xpto.com", new DateTime(1942, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leandro Gomes", "Silva", "(96) 6995-8754" },
                    { 3, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6284), "aline.hashers@contoso.xpto.com", new DateTime(1985, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aline Freitas", "Hashers", "(27) 5311-4504" },
                    { 4, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6293), "ze.braido@contoso.xpto.com", new DateTime(1947, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "José de Arruda", "Braido", "(70) 5417-4983" },
                    { 5, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6301), "armando.severo@contoso.xpto.com", new DateTime(1977, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armando", "Severó", "(40) 4179-9643" },
                    { 6, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6308), "igor.leitosa@contoso.xpto.com", new DateTime(1953, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Igor", "Leitosa", "(74) 6513-2924" },
                    { 8, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6322), "guilherme.arruda@contoso.xpto.com", new DateTime(1966, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guilherme", "Arruda", "(59) 5871-1552" },
                    { 9, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6329), "rosa.lumini@contoso.xpto.com", new DateTime(1971, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosa Alves", "Lumini", "(29) 9578-8488" },
                    { 10, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6336), "david.carvalho@contoso.xpto.com", new DateTime(1995, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Oliveira", "Carvalho", "(61) 4501-4083" },
                    { 7, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6315), "gustavo.trato@contoso.xpto.com", new DateTime(1981, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gustavo", "Trato", "(44) 5122-9631" },
                    { 18, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6437), "alvaro.batista@contoso.xpto.com", new DateTime(1964, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Álvaro Rogério", "Batista", "(94) 3284-2989" },
                    { 12, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6349), "gustavo.santos@contoso.xpto.com", new DateTime(1954, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gustavo Pereira", "Santos", "(71) 5620-1517" },
                    { 13, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6356), "leandro.silva@contoso.xpto.com", new DateTime(1999, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leandro José Paulo", "Silva", "(73) 3181-6309" },
                    { 14, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6362), "maria.santos@contoso.xpto.com", new DateTime(1961, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maria Nainam Silvino Araújo", "Santos", "(93) 8496-5512" },
                    { 15, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6369), "jullieny.oliveira@contoso.xpto.com", new DateTime(1998, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jullieny Melo", "Oliveira", "(81) 8355-4382" },
                    { 16, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6376), "daniel.rocha@contoso.xpto.com", new DateTime(1947, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel dos Santos", "Rocha", "(16) 9903-7845" },
                    { 17, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6382), "itamar.souza@contoso.xpto.com", new DateTime(1977, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Itamar de Carvalho", "Souza", "(59) 3845-5743" },
                    { 11, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(6342), "karine.cortez@contoso.xpto.com", new DateTime(1964, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karine Maria Gonçalves", "Cortez", "(44) 7585-5868" }
                });

            migrationBuilder.InsertData(
                table: "filme",
                columns: new[] { "Id", "Ativo", "Cadastro", "Descricao", "Titulo", "UrlImagem", "Valor" },
                values: new object[,]
                {
                    { 29, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(272), "Em dificuldade financeira, o piloto Han Solo (Alden Ehrenreich) e sua namorada Qi'ra (Emilia Clarke) buscam algum trabalho. Eles conseguem pôr as mãos em uma substância valiosa, mas perigosa, que acaba levando à perseguição do Império e à separação entre os dois. Preocupado, Han usa toda a sua esperteza para se infiltrar num plano arriscado, mas que pode render a oportunidade de voltar à terra natal e reencontrar a sua amada. Caso ele falhe, vai ter que prestar contas ao perigoso Dryden Vos (Paul Bettany). No caminho, o piloto encontra parceiros importantes, como Chewbacca (Joonas Suotamo) e Lando Calrissian (Donald Glover), o proprietário original da Millennium Falcon.", "Han Solo: Uma História Star Wars", "https://vignette.wikia.nocookie.net/starwars/images/a/a9/Solo_A_Star_Wars_Story_Theatrical_Poster.png/revision/latest/top-crop/width/360/height/450?cb=20180409011120", 12.90m },
                    { 28, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(270), "Com o retorno do Imperador Palpatine, todos voltam a temer seu poder. A Resistência toma a frente da batalha, enquanto Rey, treinando para ser uma Jedi, ainda se encontra em conflito com seu passado e futuro.", "Star Wars: A Ascensão Skywalker", "https://vignette.wikia.nocookie.net/starwars/images/c/cf/TROS-ExpandedEdition-Hardcover.jpg/revision/latest/top-crop/width/360/height/450?cb=20200413192610", 12.90m },
                    { 27, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(268), "Um grupo de heróis improváveis chamado Aliança Rebelde se une para realizar um movimento arriscado e rouba os planos da Estrela da Morte, arma responsável por destruir o Império.", "Rogue One: Uma História Star Wars", "https://vignette.wikia.nocookie.net/starwars/images/d/dc/RogueOneJuniorNovel-Hardcover.png/revision/latest/top-crop/width/360/height/450?cb=20161208092628", 10.90m },
                    { 23, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(261), "Em Vingadores: Ultimato, após Thanos eliminar metade das criaturas vivas em Vingadores: Guerra Infinita, os heróis precisam lidar com a dor da perda de amigos e seus entes queridos. Com Tony Stark (Robert Downey Jr.) vagando perdido no espaço sem água nem comida, o Capitão América/Steve Rogers (Chris Evans) e a Viúva Negra/Natasha Romanov (Scarlett Johansson) precisam liderar a resistência contra o titã louco.", "Vingadores: Ultimato", "https://vignette.wikia.nocookie.net/universocinematograficomarvel/images/b/b7/Images.jpg/revision/latest/top-crop/width/360/height/450?cb=20190505233213&path-prefix=pt", 12.90m },
                    { 25, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(264), "Com o desaparecimento de Luke Skywalker, a galáxia se encontra vulnerável para Kylo Ren e a Primeira Ordem. Rey, uma catadora de sucata do deserto, e Finn, um stormtrooper desertor, decidem se unir a Han Solo e Chewbacca numa busca desenfreada para restaurar a paz na galáxia.", "Star Wars: O Despertar da Força", "https://vignette.wikia.nocookie.net/starwars/images/b/b8/TFANewAdventures-Hardcover.jpg/revision/latest/top-crop/width/360/height/450?cb=20170519154150", 12.90m },
                    { 24, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(262), "As forças imperais comandadas por Darth Vader (David Prowse/James Earl Jones) lançam um ataque contra os membros da resistência, que são obrigados a fugir. Enquanto isso, Luke Skywalker (Mark Hamill) tenta encontrar o Mestre Yoda, que poderá ensiná-lo a dominar a 'Força' e torná-lo um cavaleiro Jedi. No entanto, Darth Vader planeja levá-lo para o Lado Negro da 'Força'.", "Star Wars - O Império Contra-ataca", "https://vignette.wikia.nocookie.net/starwars/images/a/a8/TheEmpireStrikesBack_SFI_cover.jpg/revision/latest/top-crop/width/360/height/450?cb=20200303223254", 12.90m },
                    { 30, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(274), "Ao desembarcar na Normandia, no dia 6 de junho de 1944, capitão Miller (Tom Hanks) recebe a missão de comandar um grupo do segundo batalhão para o resgate do soldado James Ryan, caçula de quatro irmãos, dentre os quais três morreram em combate. Por ordens do chefe George C. Marshall, eles precisam procurar o soldado e garantir o seu retorno, com vida, para casa.", "O Resgate do Soldado Ryan", "https://andersonvision.com/wp-content/uploads/2018/03/SPR_4K_3D-e1520299793289.jpg", 7.99m },
                    { 26, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(266), "A jovem Rey começa a mostrar fortes sinais da Força, o que a faz procurar Luke Skywalker, que se vê obrigado a tomar uma decisão que mudará sua vida para sempre. Enquanto isso, a Primeira Ordem é liderada por Kylo Ren e o General Hux para um ataque contra Leia e a Resistência.", "Star Wars: Os Últimos Jedi", "https://vignette.wikia.nocookie.net/starwars/images/2/21/The_Last_Jedi_Studio_Fun.jpg/revision/latest/top-crop/width/360/height/450?cb=20201007114741", 12.90m },
                    { 31, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(275), "Django (Jamie Foxx) é um escravo liberto cujo passado brutal com seus antigos proprietários leva-o ao encontro do caçador de recompensas alemão Dr. King Schultz (Christoph Waltz). Schultz está em busca dos irmãos assassinos Brittle, e somente Django pode levá-lo a eles. O pouco ortodoxo Schultz compra Django com a promessa de libertá-lo quando tiver capturado os irmãos Brittle, vivos ou mortos.", "Django Livre", "https://vignette.wikia.nocookie.net/sony-pictures-entertaiment/images/0/0b/P9287010_v_v8_aa.jpg/revision/latest/top-crop/width/360/height/450?cb=20190124223003", 10.90m },
                    { 40, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(312), "Em um futuro próximo, Thomas Anderson (Keanu Reeves), um jovem programador de computador que mora em um cubículo escuro, é atormentado por estranhos pesadelos nos quais encontra-se conectado por cabos e contra sua vontade, em um imenso sistema de computadores do futuro. Em todas essas ocasiões, acorda gritando no exato momento em que os eletrodos estão para penetrar em seu cérebro. À medida que o sonho se repete, Anderson começa a ter dúvidas sobre a realidade. Por meio do encontro com os misteriosos Morpheus (Laurence Fishburne) e Trinity (Carrie-Anne Moss), Thomas descobre que é, assim como outras pessoas, vítima do Matrix, um sistema inteligente e artificial que manipula a mente das pessoas, criando a ilusão de um mundo real enquanto usa os cérebros e corpos dos indivíduos para produzir energia. Morpheus, entretanto, está convencido de que Thomas é Neo, o aguardado messias capaz de enfrentar o Matrix e conduzir as pessoas de volta à realidade e à liberdade.", "Matrix", "https://imgc.artprintimages.com/img/print/carrie-anne-moss_u-l-pnenjz0.jpg", 12.90m },
                    { 33, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(279), "Nos dias finais do reinado de Marcus Aurelius (Richard Harris), o imperador desperta a ira de seu filho Commodus (Joaquin Phoenix) ao tornar pública sua predileção em deixar o trono para Maximus (Russell Crowe), o comandante do exército romano. Sedento pelo poder, Commodus mata seu pai, assume a coroa e ordena a morte de Maximus, que consegue fugir antes de ser pego e passa a se esconder sob a identidade de um escravo e gladiador do Império Romano.", "Gladiador", "https://vignette.wikia.nocookie.net/samplelist/images/f/fb/Gladiator_%282000_film_poster%29.png/revision/latest/top-crop/width/360/height/450?cb=20200825182720", 9.90m },
                    { 34, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(281), "Em À Procura da Felicidade, Chris Gardner (Will Smith) é um pai de família que enfrenta sérios problemas financeiros. Apesar de todas as tentativas em manter a família unida, Linda (Thandie Newton), sua esposa, decide partir. Chris agora é pai solteiro e precisa cuidar de Christopher (Jaden Smith), seu filho de apenas 5 anos. Ele tenta usar sua habilidade como vendedor para conseguir um emprego melhor, que lhe dê um salário mais digno. Chris consegue uma vaga de estagiário numa importante corretora de ações, mas não recebe salário pelos serviços prestados.", "À Procura da Felicidade", "https://vignette.wikia.nocookie.net/jadensmith/images/8/81/Onesheet.jpg/revision/latest/top-crop/width/360/height/450?cb=20171128103224", 10.00m },
                    { 35, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(283), "Riley é uma garota divertida de 11 anos de idade, que deve enfrentar mudanças importantes em sua vida quando seus pais decidem deixar a sua cidade natal, no estado de Minnesota, para viver em San Francisco. Dentro do cérebro de Riley, convivem várias emoções diferentes, como a Alegria, o Medo, a Raiva, o Nojinho e a Tristeza. A líder deles é Alegria, que se esforça bastante para fazer com que a vida de Riley seja sempre feliz.", "Divertida Mente", "https://vignette.wikia.nocookie.net/vozesportuguesas/images/6/60/Divertida-Mente_%28Inside_Out%29.jpg/revision/latest/top-crop/width/360/height/450?cb=20200819022357&path-prefix=pt", 7.99m },
                    { 36, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(304), "Durante a Segunda Guerra Mundial, o médico do exército Desmond T. Doss (Andrew Garfield) se recusa a pegar em uma arma e matar pessoas, porém, durante a Batalha de Okinawa ele trabalha na ala médica e salva mais de 75 homens, sendo condecorado. O que faz de Doss o primeiro Opositor Consciente da história norte-americana a receber a Medalha de Honra do Congresso.", "Até o Último Homem", "https://vignette.wikia.nocookie.net/doblaje/images/b/b5/Hasta_el_ultimo_hombre_poster_oficial.jpg/revision/latest/top-crop/width/360/height/450?cb=20161214050010&path-prefix=es", 10m },
                    { 37, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(306), "Inglaterra, 1797. As cinco irmãs Bennet - Elizabeth (Keira Knightley), Jane (Rosamund Pike), Lydia (Jena Malone), Mary (Talulah Riley) e Kitty (Carey Mulligan) - foram criadas por uma mãe (Brenda Blethyn) que tinha fixação em lhes encontrar maridos que garantissem seu futuro. Porém Elizabeth deseja ter uma vida mais ampla do que apenas se dedicar ao marido, sendo apoiada pelo pai (Donald Sutherland). Quando o sr. Bingley (Simon Woods), um solteiro rico, passa a morar em uma mansão vizinha, as irmãs logo ficam agitadas. Jane logo parece que conquistará o coração do novo vizinho, enquanto que Elizabeth conhece o bonito e esnobe sr. Darcy (Matthew Macfadyen). Os encontros entre Elizabeth e Darcy passam a ser cada vez mais constantes, apesar deles sempre discutirem.", "Orgulho e Preconceito", "https://i.pinimg.com/474x/ca/7a/cf/ca7acf060eb528325ee8f5da4040d9d6.jpg", 9.99m },
                    { 38, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(308), "Jack (Edward Norton) é um executivo jovem, trabalha como investigador de seguros, mora confortavelmente, mas ele está ficando cada vez mais insatisfeito com sua vida medíocre. Para piorar ele está enfrentando uma terrível crise de insônia, até que encontra uma cura inusitada para o sua falta de sono ao frequentar grupos de auto-ajuda. Nesses encontros ele passa a conviver com pessoas problemáticas como a viciada Marla Singer (Helena Bonham Carter) e a conhecer estranhos como Tyler Durden (Brad Pitt). Misterioso e cheio de ideias, Tyler apresenta para Jack um grupo secreto que se encontra para extravasar suas angústias e tensões através de violentos combates corporais.", "Clube da Luta", "https://i.pinimg.com/originals/9e/a9/9e/9ea99e70bc6639670d1a506a18e83e22.jpg", 9.99m },
                    { 39, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(310), "Após ver a Terra consumindo boa parte de suas reservas naturais, um grupo de astronautas recebe a missão de verificar possíveis planetas para receberem a população mundial, possibilitando a continuação da espécie. Cooper (Matthew McConaughey) é chamado para liderar o grupo e aceita a missão sabendo que pode nunca mais ver os filhos. Ao lado de Brand (Anne Hathaway), Jenkins (Marlon Sanders) e Doyle (Wes Bentley), ele seguirá em busca de uma nova casa. Com o passar dos anos, sua filha Murph (Mackenzie Foy e Jessica Chastain) investirá numa própria jornada para também tentar salvar a população do planeta.", "Interestelar", "https://vignette.wikia.nocookie.net/chrisnolan/images/4/46/Interstellar_poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20160812013355", 12.90m },
                    { 22, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(259), "Em Vingadores: Guerra Infinita, Thanos (Josh Brolin) enfim chega à Terra, disposto a reunir as Joias do Infinito. Para enfrentá-lo, os Vingadores precisam unir forças com os Guardiões da Galáxia, ao mesmo tempo em que lidam com desavenças entre alguns de seus integrantes.", "Vingadores: Guerra Infinita", "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/a/a0/AIWTAB.jpg/revision/latest/top-crop/width/360/height/450?cb=20200326084651", 12.90m },
                    { 32, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(277), "Cinco anos após convencer os habitantes de seu vilarejo que os dragões não devem ser combatidos, Soluço (voz de Jay Baruchel) convive com seu dragão Fúria da Noite, e estes animais integraram pacificamente a rotina dos moradores da ilha de Berk. Entre viagens pelos céus e corridas de dragões, Soluço descobre uma caverna secreta, onde centenas de novos dragões vivem. O local é protegido por Valka (voz de Cate Blanchett), mãe de Soluço, que foi afastada do filho quando ele ainda era um bebê. Juntos, eles precisarão proteger o mundo que conhecem do perigoso Drago Bludvist (Djimon Hounson), que deseja controlar todos os dragões existentes.", "Como Treinar o seu Dragão 2", "https://vignette.wikia.nocookie.net/universalstudios/images/3/36/How_to_train_your_dragon_2_poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20200705012036", 7.99m },
                    { 21, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(257), "Durante a Segunda Guerra Mundial na Itália, o judeu Guido (Roberto Benigni) e seu filho Giosué são levados para um campo de concentração nazista. Afastado da mulher, ele tem que usar sua imaginação para fazer o menino acreditar que estão participando de uma grande brincadeira, com o intuito de protegê-lo do terror e da violência que os cercam.", "A Vida é Bela", "https://images-na.ssl-images-amazon.com/images/I/51hH4OZGnLL._AC_SY450_.jpg", 7.99m },
                    { 1, true, new DateTime(2020, 10, 22, 20, 34, 23, 311, DateTimeKind.Local).AddTicks(9288), "Jovens se aventuram em festas do colegial. Muita diversão e bebedeiras!!! HAHAHAHA", "American Pie 3", "https://vignette.wikia.nocookie.net/doblaje/images/1/1f/AmericanPieCampamento.jpg/revision/latest/top-crop/width/360/height/450?cb=20091001181345&path-prefix=es", 12.90m },
                    { 19, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(253), "1935, no corredor da morte de uma prisão sulista. Paul Edgecomb (Tom Hanks) é o chefe de guarda da prisão, que temJohn Coffey (Michael Clarke Duncan) como um de seus prisioneiros. Aos poucos, desenvolve-se entre eles uma relação incomum, baseada na descoberta de que o prisioneiro possui um dom mágico que é, ao mesmo tempo, misterioso e milagroso.", "À Espera de um Milagre", "https://images-na.ssl-images-amazon.com/images/I/71D6IdIFSxL._AC_SY450_.jpg", 9.40m },
                    { 2, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(198), "O ex-policial Brian comete uma grande traição, juntando-se a um amigo ex-presidiário no transporte de dinheiro sujo para uma importadora-exportadora muito suspeita.", "+ Velozes + Furiosos", "https://vignette.wikia.nocookie.net/velozes-e-furiosos/images/a/aa/Velozes_e_Furiosos_-_Capa.jpg/revision/latest/top-crop/width/360/height/450?cb=20180305235641&path-prefix=pt-br", 12.50m },
                    { 3, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(222), "A bordo do luxuoso transatlântico, Rose (Kate Winslet), uma jovem da alta sociedade, se sente pressionada com a vida que leva. Ao conhecer Jack (Leonardo DiCaprio), um artista pobre e aventureiro, os dois se apaixonam. Mas eles terão que enfrentar um desafio ainda maior que o preconceito social com o destino trágico do navio.", "Titanic", "https://vignette.wikia.nocookie.net/maritime-disaster/images/b/b3/300px-RMS_Titanic_3.jpg/revision/latest/top-crop/width/360/height/450?cb=20170425130744", 6.50m },
                    { 4, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(224), "Don Corleone (Marlon Brando) é chefe de uma das famílias de mafiosos italianos mais respeitadas de Nova York. Quando ele é ferido e afastado de suas funções, o filho Michael (Al Pacino) deve tomar as rédeas da situação para acabar com o responsável e manter a honra do pai intacta. Dirigido por Francis Ford Coppola e vencedor de três Oscars, incluindo o de Melhor Filme.", "O Poderoso Chefão", "https://images-na.ssl-images-amazon.com/images/I/41NrywwjCEL._AC_SY450_.jpg", 7.80m },
                    { 5, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(226), "Num futuro dominado pelas máquinas, os computadores mandam ao passado um androide (Arnold Schwarzenegger) praticamente indestrutível. Sua missão é matar Sarah Connor antes que ela dê à luz o líder da resistência humana na guerra contra a inteligência artificial. Os seres humanos também enviam um agente para proteger a mulher.", "O Exterminador Do Futuro", "https://vignette.wikia.nocookie.net/exterminadordofuturo/images/6/6f/Terminator.jpeg/revision/latest/top-crop/width/360/height/450?cb=20150730214551&path-prefix=pt-br", 10.50m },
                    { 6, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(228), "De volta para o terceiro ano em Hogwarts, Harry Potter (Daniel Radcliffe) encontra a escola sob estado de atenção: os sombrios dementadores cercam as proximidades do castelo em busca de Sirius Black (Gary Oldman), assassino recém-fugido da prisão de Azkaban que está atrás de Harry. Dirigido por Alfonso Cuarón e indicado ao Oscar de Melhor Canção Original e Melhores Efeitos Visuais.", "Harry Potter E O Prisioneiro De Azkaban", "https://vignette.wikia.nocookie.net/vozesportuguesas/images/a/a5/HP3.jpg/revision/latest/top-crop/width/360/height/450?cb=20200928052358&path-prefix=pt", 8.50m },
                    { 7, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(230), "Marty McFly (Michael J. Fox) é um jovem que acidentalmente viaja em uma máquina do tempo construída pelo cientista Doc Brown (Christopher Lloyd). Agora, nos anos 1950, ele vê seus pais que ainda não se apaixonaram. E, para não colocar em risco sua própria existência, ele precisa agir como cupido dos pais. Vencedor do Oscar de Melhor Edição de Som.", "De Volta Para O Futuro", "https://images-na.ssl-images-amazon.com/images/I/916GbiXiQCL._SY450_.jpg", 8.50m },
                    { 8, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(232), "Com o auxílio da engenharia genética criada pelos doutores Alan (Sam Neill), Ellie (Laura Dern) e Ian, um milionário traz à vida dinossauros extintos há milhares de anos, criando um imenso parque em uma remota ilha. Porém, os gigantes pré-históricos começam a ameaçar a vida dos vistitantes. Vencedor de 3 Oscars, incluindo o de Melhores Efeitos Visuais.", "Jurassic Park - O Parque Dos Dinossauros", "https://i.pinimg.com/originals/12/45/97/124597895a3367703ce104584c6dfd19.jpg", 9.99m },
                    { 20, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(255), "Quarenta anos da história dos Estados Unidos, vistos pelos olhos de Forrest Gump (Tom Hanks), um rapaz com QI abaixo da média e boas intenções. Por obra do acaso, ele consegue participar de momentos cruciais, como a Guerra do Vietnã e Watergate, mas continua pensando no seu amor de infância, Jenny Curran.", "Forrest Gump - O Contador de Histórias", "https://vignette.wikia.nocookie.net/figure-skating-13/images/7/7f/Large_pEYI2QILJWMN1ZeEMgMM0jxBVhK.jpg/revision/latest/top-crop/width/360/height/450?cb=20170318095424", 8.20m },
                    { 9, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(234), "Na Terra-Média, o hobbit Frodo (Elijah Woods) recebe de presente de seu tio o Um Anel, um anel mágico e maligno que precisa ser destruído antes que caia nas mãos do mal. Para isso ele terá um caminho árduo pela frente, mas para o cumprimento desta jornada aos poucos ele poderá contar com outros seres que formarão a Sociedade do Anel.", "O Senhor dos Anéis: A Sociedade do Anel", "https://vignette.wikia.nocookie.net/liberproeliis/images/9/9a/Aragorn_Wikia.jpg/revision/latest/top-crop/width/360/height/450?cb=20200616201039&path-prefix=pt-br", 7.60m },
                    { 11, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(238), "Oito anos após a morte de Harvey Dent, a cidade de Gotham City está pacificada e não precisa mais do Batman. A situação faz com que Bruce Wayne (Christian Bale) se torne um homem recluso em sua mansão, convivendo apenas com o mordomo Alfred (Michael Caine). Um dia, em meio a uma festa realizada na Mansão Wayne, uma das garçonetes contratadas (Anne Hathaway) rouba um colar de grande valor sentimental. Curioso em descobrir quem é ela, Bruce retorna à caverna para usar os computadores que tanto lhe serviram. Aos poucos começa a perceber indícios do surgimento de uma nova ameaça a Gotham City, personificada no brutamontes Bane (Tom Hardy). É o suficiente para que volte a ser o Batman.", "Batman: O Cavaleiro das Trevas Ressurge", "https://vignette.wikia.nocookie.net/marvel_dc/images/0/05/The_Dark_Knight_Rises_poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20120123215909", 12.90m },
                    { 12, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(240), "Quando Páris (Orlando Bloom), o príncipe de Troia, se apaixona por Helena (Diane Kruger), rainha de Esparta, o rei Menelau (Brendan Gleeson) inicia uma guerra de anos entre os dois reinos. Para vencer, Esparta conta com Aquiles (Brad Pitt), um guerreiro lendário que comanda um exército próprio. Indicado ao Oscar de Melhor Figurino.", "Tróia", "https://i.pinimg.com/474x/2d/35/6a/2d356a67ffb38bbe93e2959fe45265c4.jpg", 6.70m },
                    { 13, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(242), "Elizabeth Shaw (Noomi Rapace) e Charlie Holloway (Logan Marshall-Green) fazem parte de uma equipe de cientistas que embarca em uma jornada espacial para descobrir a verdade sobre a origem da raça humana. A nave Prometheus também é composta pelo robô David (Michael Fassbender), a diretora Meredith Vickers (Charlize Theron), o capitão Janek (Idris Elba), entre outros. Quando eles chegam ao planeta de destino, eles encontram criaturas poderosas, violentas e revelações estarrecedoras.", "Prometheus", "https://vignette.wikia.nocookie.net/theflophouse/images/1/19/Prometheus-poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20170430003032", 9.99m },
                    { 14, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(244), "Baseado na história real de uma família de turistas durante um Tsunami que atingiu o sudeste asiático. Após a destruição causada pela onda gigante, uma mãe (Naomi Watts) tenta sobreviver com seu filho adolescente e reencontrar seu marido (Ewan McGregor) e seus dois filhos pequenos no meio do caos na Tailândia. Indicado ao Oscar de Melhor Atriz.", "O Impossível", "https://vignette.wikia.nocookie.net/my-little-baby-boy-harry-styles-fanfiction/images/f/fd/The_Impossible.png/revision/latest/top-crop/width/360/height/450?cb=20180923001955", 8.99m },
                    { 15, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(246), "A caminho da Terra, a nave Nostromo recebe um pedido de socorro de um planeta próximo. Ao desembarcar no local, um dos tripulantes é vítima de uma criatura alienígena, dando início a uma série de ataques assassinos dentro da espaçonave. Dirigido por Ridley Scott, o filme ganhou dois Oscars, incluindo o de Melhores Efeitos Visuais.", "Alien, O Oitavo Passageiro", "https://pm1.narvii.com/6960/c67686f08b1b55962883d5575c56aaeb798662aar1-360-450v2_00.jpg", 10.50m },
                    { 16, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(247), "A inusitada história de Oskar Schindler (Liam Neeson), um sujeito oportunista, sedutor, 'armador', simpático, comerciante no mercado negro, mas, acima de tudo, um homem que se relacionava muito bem com o regime nazista, tanto que era membro do próprio Partido Nazista (o que não o impediu de ser preso algumas vezes, mas sempre o libertavam rapidamente, em razão dos seus contatos).", "A Lista de Schindler", "https://vignette.wikia.nocookie.net/figure-skating-13/images/1/1f/MV5BMzMwMTM4MDU2N15BMl5BanBnXkFtZTgwMzQ0MjMxMDE%40._V1_SX640_SY720_.jpg/revision/latest/top-crop/width/360/height/450?cb=20160121092516", 9.99m },
                    { 17, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(249), "Em 1946, Andy Dufresne (Tim Robbins), um jovem e bem sucedido banqueiro, tem a sua vida radicalmente modificada ao ser condenado por um crime que nunca cometeu, o homicídio de sua esposa e do amante dela. Ele é mandado para uma prisão que é o pesadelo de qualquer detento, a Penitenciária Estadual de Shawshank, no Maine.", "Um Sonho de Liberdade", "https://images-na.ssl-images-amazon.com/images/I/8189H-FijZL._AC_SY450_.jpg", 8.99m },
                    { 18, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(251), "Mufasa (voz de James Earl Jones), o Rei Leão, e a rainha Sarabi (voz de Madge Sinclair) apresentam ao reino o herdeiro do trono, Simba (voz de Matthew Broderick). O recém-nascido recebe a bênção do sábio babuíno Rafiki (voz de Robert Guillaume), mas ao crescer é envolvido nas artimanhas de seu tio Scar (voz de Jeremy Irons), o invejoso e maquiavélico irmão de Mufasa, que planeja livrar-se do sobrinho e herdar o trono.", "O Rei Leão", "https://vignette.wikia.nocookie.net/vozesportuguesas/images/2/2e/O_Rei_Le%C3%A3o.jpg/revision/latest/top-crop/width/360/height/450?cb=20200718121256&path-prefix=pt", 10.50m },
                    { 10, true, new DateTime(2020, 10, 22, 20, 34, 23, 312, DateTimeKind.Local).AddTicks(236), "Baseado na biografia de Stephen Hawking (Eddie Redmayne), o filme mostra as importantes descobertas do aclamado astrofísico sobre o tempo. Além de retratar seu relacionamento com a esposa Jane e os desafios que vieram com a descoberta de uma doença degenerativa.", "A Teoria De Tudo", "https://vignette.wikia.nocookie.net/figure-skating-13/images/2/29/Theoryofeverything.jpg/revision/latest/top-crop/width/360/height/450?cb=20181229212809", 10.50m }
                });

            migrationBuilder.InsertData(
                table: "funcionario",
                columns: new[] { "Id", "Ativo", "Cadastro", "Email", "Login", "Nome", "Senha", "Sobrenome" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2020, 10, 22, 20, 34, 23, 309, DateTimeKind.Local).AddTicks(6318), "adm@videolocadora.com.br", "admin", "Administrador", "123456", " " },
                    { 2, true, new DateTime(2020, 10, 22, 20, 34, 23, 310, DateTimeKind.Local).AddTicks(6780), "bruno.tragl@videolocadora.com.br", "brunotragl", "Bruno", "123456", "Tragl" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_aluguel_ClienteId",
                table: "aluguel",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aluguel_FilmeId",
                table: "aluguel",
                column: "FilmeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aluguel_FuncionarioId",
                table: "aluguel",
                column: "FuncionarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aluguel");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "filme");

            migrationBuilder.DropTable(
                name: "funcionario");
        }
    }
}
