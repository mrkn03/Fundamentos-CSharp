Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);

//Criar uma data especifica usa o formato: aaaa, mm, dd
DateTime dataHoje = new DateTime(2024, 02, 01);

Console.WriteLine(dataHoje);

//Definir as horas
DateTime dataHoraHoje = new DateTime(2024, 02, 01, 19, 40, 00);

Console.WriteLine(dataHoraHoje);

//Extrair informacoes da data atual
DateTime hoje = DateTime.Now;

Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

//Adicionando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));

//Obter dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//Data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());