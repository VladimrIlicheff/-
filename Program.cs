Console.WriteLine("Введите элементы массива через запятую");
string str = new string (Console.ReadLine());
string[] array = str.Split(new char[] {','});
int quant = 0;
for (int i=0; i<array.Length; i++)
{
    int num = Convert.ToInt32(array[i].Length);
    if (num<=3) 
    {
        Console.Write(array[i]+ "; " );
        quant++; 
    }
}