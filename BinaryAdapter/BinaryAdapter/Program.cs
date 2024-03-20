using BinaryAdapter;
using System.Security.AccessControl;

string filePath = "people.bin";

IPersonRepository personRepository = new PersonBinaryRepository(filePath);

//Agregar algunas personas
personRepository.Add(new Person { Name = "Juan", Age = 17, Height = 170 });
personRepository.Add(new Person { Name = "Alvaro", Age = 19, Height = 146.7 });
personRepository.Add(new Person { Name = "Gabriel", Age = 35, Height = 152.5 });

Console.WriteLine($"Datos de personas guardados en {filePath}");
foreach (Person person in personRepository.GetAll())
    Console.WriteLine($"Id: {person.Id}, Nombre: {person.Name}, Edad: {person.Age}, Estatura: {person.Height}");