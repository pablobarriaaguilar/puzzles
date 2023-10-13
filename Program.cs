// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");

static int[] RandomArray(){
Random rnd = new Random();
 int[] array = new int[10];
for(int i = 0; i < array.Length; i++){
    array[i]=rnd.Next(5,26);
}
        return array;
}

int [] array = RandomArray();
int suma = 0;

foreach(int numero in array){
    suma = suma + numero;
}


Console.WriteLine($"el valor maximo es {array.Max()}");

Console.WriteLine($"el valor minimo es {array.Min()}");

Console.WriteLine($"la suma de los valores es {array.Sum()}");


static string TossCoin(){
    Console.WriteLine("¡Tirando una moneda!");
    Random rnd = new Random();
    int valor = rnd.Next(0,2);
    if(valor == 0 ){
        return "Cara";
    } else{
        return "Cruz";
    }
    
}

string resultado = TossCoin();

Console.WriteLine($"la moneda lanzada salio {resultado}");