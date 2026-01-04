static T PrintValue<T>(T value)
{
    Console.WriteLine(value);
    return value;
}


PrintValue<int>(5);
PrintValue<string>("Hello");
PrintValue<double>(3.14);
