//Ortalama Hesaplama
/* Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların
ortalamasını alıp ekrana yazdıran uygulamayı yazınız.
Dikkat Edilmesi Gereken Noktalar :
>Kod tekrarından kaçınılmalı.
>Single Responsibility(Bir Class'ın Tek Bir Sorumluluğu Olmalıdır.) kuralına uygun şekilde,
 uygulama sınıflara ve metotlara bölünmeli.
*/
Console.Write("Fibonacci dizisi uzunluğu girin : ");
int Length = int.Parse(Console.ReadLine());
FibonacciGenerator fibonacciGenerator = new FibonacciGenerator(Length);
fibonacciGenerator.Generator();
Console.ReadLine();




public  class FibonacciGenerator
{
    public int Length { get; set; }
    public FibonacciGenerator() {}
    public FibonacciGenerator(int Length) { this.Length = Length; }
    
    public void Generator()
    {

    }
}