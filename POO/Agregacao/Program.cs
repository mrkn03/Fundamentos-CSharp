using Agregacao;

Professor prof1 = new Professor("Carlos", "Química");
Professor prof2 = new Professor("Maria", "Inglês");
Professor prof3 = new Professor("Ana", "Literatura");
Professor prof4 = new Professor("Paulo", "Matemátia");

Departamento dep1 = new Departamento("Exatas");
dep1.AdicionaProfessor(prof1);
dep1.AdicionaProfessor(prof4);
dep1.ListarProfessores();

Departamento dep2 = new Departamento("Humanas");
dep2.AdicionaProfessor(prof2);
dep2.AdicionaProfessor(prof3);
dep2.ListarProfessores();


Console.ReadKey();