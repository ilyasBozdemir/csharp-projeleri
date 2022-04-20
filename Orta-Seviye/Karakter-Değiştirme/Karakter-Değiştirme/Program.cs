/*# Algoritma
Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip
tekrar ekrana yazdıran console uygulamasını yazınız.
Input: Merhaba Hello Algoritma x
Output: aerhabM oellH algoritmA x
*/
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Input : ");
string data = Console.ReadLine();
string[] dataArray = data.Split(" ");
char temp = ' ', temp2 = ' ';
for (int i = 0; i < dataArray.Length; i++)
{
    data = dataArray[i];
    char[] charArray = data.ToArray();
    var lastIndex = charArray.Length -1 ;
    temp = charArray[0];
    temp2 = charArray[lastIndex];
    charArray[lastIndex] = temp;
    charArray[0] = temp2;
    var newData = string.Join("", charArray);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(newData + " ");
    Console.ForegroundColor = ConsoleColor.White;
}