Console.WriteLine("Введите элементы массива через запятую");
string str = new string (Console.ReadLine());
string[] array = str.Split(new char[] {','});
int quant = 0;