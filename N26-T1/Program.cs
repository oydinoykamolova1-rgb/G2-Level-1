using N26_T1;
using System.Text.Json;

Studet student1 = new Studet { Id = 1 , FullName = "John Doe"};

string json = JsonSerializer.Serialize(student1);
File.WriteAllText("", json);

