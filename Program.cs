using OOPExample1;

OopClass oopclass = new();
oopclass.Name = "Peter";
oopclass.Id = 15;

OopClass oopclass2 = new();
oopclass2.Name = "Jack";
oopclass2.Id = 8;

OopClass palle = new() { Id = 9, Name = "Palle" };

List<OopClass> oopClassList = new();
oopClassList.Add(oopclass);
oopClassList.Add(oopclass2);
oopClassList.Add(new() { Name = "Jan", Id = 2 });
oopClassList.Add(palle);


foreach (var item in oopClassList)
{
    Console.WriteLine($"{item.Id} {item.Name}");
}