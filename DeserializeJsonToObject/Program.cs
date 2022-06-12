

using Newtonsoft.Json;

var exampleJson = @"{
  'Name': 'Marcos Lima',
  'Email': 'lima@gmail.com',
  'Active': true,
  'CreatedDate': '2022-06-12T00:00:00Z',
  'Roles': [
    'Admin',
    'User'
  ]
}";

Person person = JsonConvert.DeserializeObject<Person>(exampleJson);

Console.WriteLine(person.Name);






public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedDate { get; set; }
    public IList<string> Roles { get; set; }
}
