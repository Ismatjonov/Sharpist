var tom = new Person("Tom");
 
Console.WriteLine(tom.Name);

var buffer = new Buffer();
 
// некоторые действия с индексатором
for(var i=0; i < Buffer.COUNT; ++i){
    buffer[i] = i * i;
}
 
for(var i=0; i < Buffer.COUNT; ++i){
    Console.WriteLine(buffer[i]);
}


// объявление класса
partial class Person{
    public partial string Name { get; set; }  // объявление частичного свойства
}
 
// реализация класса
partial class Person{
    private string name; // поле для хранения значения свойства
 
    public Person(string name) => this.name = name;
 
    public partial string Name    // реализация частичного свойства
    {
        get => name;
        set => name = value;
    }
}

// объявление класса
partial class Buffer{
    public partial int this[int index]  { get; set; }  // объявление свойства-индексатора
}
 
// реализация класса
partial class Buffer{
    public const int COUNT = 6;
    private int[] data = new int[COUNT];
    public partial int this[int index]    // реализация свойства-индексатора
    {
        get => data[index];
        set => data[index] = value;
    }
}