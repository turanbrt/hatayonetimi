namespace hatayonetimi;

class Program
{
    static void Main(string[] args)
    {
        
        //**Try cacth bloğu
        /* try{

        Console.WriteLine("Bir sayı giriniz.");
        int sayi=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girdiğiniz Sayı:"+sayi);

        }
        catch(Exception ex){
            
            Console.WriteLine("HATA:"+ex.Message);

        }
        finally{
            Console.WriteLine("İşlem tamamlandı.");


        }
        */
        //***Exception Tipleri

        

        try{
           // int a=int.Parse(null);
           // int a=int.Parse("test");
            int a=int.Parse("888888888888");

        }
        catch(ArgumentNullException ex){
            Console.WriteLine("Boş değer girdiniz.");
            Console.WriteLine(ex);
        }
        catch(FormatException ex){
             Console.WriteLine("Yanlış formatda veri girdiniz.");
             Console.WriteLine(ex);
             
        }
        catch(OverflowException ex){
            Console.WriteLine("Çok büyük yada çok küçük bir değer girdiniz.");
            Console.WriteLine(ex);
        }
        finally{


        }


    }
}
