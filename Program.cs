using Aula13ClassesPOO;



Pessoa Wendell = new Pessoa("Wendell" ,22 , "João martins frança" , "São carlos");
Wendell.mostra();
Pessoa Mirela = new Pessoa("Mirela", 18, "rua vicente laurito", "São carlos");
Mirela.mostra();
Pessoa marcelly = new Pessoa("Marcelly", 25, "Attillio Milanetto", "São carlos");
marcelly.mostra();
List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(Wendell);
pessoas.Add(Mirela);
pessoas.Add(marcelly);

for (int i = 0; i < pessoas.Count; i++)
{
    pessoas[i].mostra();
    // o comando acima mostra cada uma das instancias em ordem junto com a função mostra

}