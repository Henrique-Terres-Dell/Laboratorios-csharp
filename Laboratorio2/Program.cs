Console.WriteLine("1 - Alocar, inicializar e acessar dados em um array de tamanho fixo");

int[] array = new int[5] {10, 20, 30, 40, 50};
int indice = 0;
foreach(int numero in array) {
    Console.WriteLine("Indice = " + indice + " | Valor = " + numero);
    indice++;
}

/*
int i;
for(i = 0; i < 5; i++) {
    Console.WriteLine("Indice = " + i + " | Valor = " + array[i]);
}
*/

Console.WriteLine();

//-------------------------------------------------------------------------------

string[] str = new string[3];
str[0] = "Um";
str[1] = "Dois";
str[2] = "Três";
int indice2 = 0;
foreach(string numero in str) {
    Console.WriteLine("Indice = " + indice2 + " | Valor = " + numero);
    indice2++;
}

/*
int iStr;
for(iStr = 0; iStr < 3; iStr++) {
    Console.WriteLine("Indice = " + iStr + " | Valor = " + str[iStr]);
}
*/

Console.WriteLine();

//-------------------------------------------------------------------------------

DateTime[] dt = new DateTime[2];
dt[0] = new DateTime(2002, 5, 1);
dt[1] = new DateTime(2002, 6, 1);
int indice3 = 0;
foreach(DateTime data in dt) {
    Console.WriteLine("Indice = " + indice3 + " | Data = " + data.ToShortDateString());
    indice3++;
}

/*
int iDate;
for(iDate = 0; iDate < 2; iDate++) {
    Console.WriteLine("Indice = " + iDate + " | Data = " + dt[iDate].ToShortDateString());
}
*/

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("2 - Exercícios:\n");

Console.WriteLine("1. Preenchendo e copiando arrays");

int[] array1 = new int[100];
int[] array2 = new int[100];

for(int i = 0; i < array1.Length; i++) {
    array1[i] = i;
}
Console.Write("Array 1 = { ");
foreach(int numero in array1) {
    Console.Write(numero + " ");
}
Console.WriteLine("}\n");

for(int i = 0; i < array2.Length; i++) {
    array2[i] = array1[i];
}
Console.Write("Array2 (Cópia) = { ");
foreach(int numero in array2) {
    Console.Write(numero + " ");
}
Console.WriteLine("}\n");

//-------------------------------------------------------------------------------

Console.WriteLine("2. ");