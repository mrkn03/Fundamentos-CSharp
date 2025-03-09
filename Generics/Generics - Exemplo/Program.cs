using Generics___Exemplo;

ClasseGenerica<int> objInt = new ClasseGenerica<int>();

objInt.Adicionar(10);
objInt.Adicionar(20);
objInt.Adicionar(30);
objInt.Adicionar(40);
objInt.Adicionar(50);

for(int i =0; i<5; i++)
{
    Console.WriteLine(objInt[i]);
}