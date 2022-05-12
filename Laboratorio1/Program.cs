Console.WriteLine("1 - Trabalhando com tipos-valor fundamentais: byte, int e long");

byte b;
b = byte.MaxValue;
Console.WriteLine("Valor máximo de byte: " + b);
Console.WriteLine($"Valor máximo de byte: {b}");

int i;
i = int.MaxValue;
Console.WriteLine("Valor máximo de int: " + i);

long l;
l = long.MaxValue;
Console.WriteLine("Valor máximo de long: " + l);

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("2 - Trabalhando com Strings");

string strPrimeira = "Alo ";
string strSegunda = "Mundo";
string strTerceira = strPrimeira + strSegunda;
Console.WriteLine(strTerceira);

int cchTamanho = strTerceira.Length;
string strQuarta =  "Tamanho = " + cchTamanho.ToString();
Console.WriteLine(strQuarta);

Console.WriteLine(strTerceira.Substring(0, 5));

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("3 - Trabalhando com objetos do Framework");

DateTime dt = new DateTime(2015, 04, 23);
string strQuinta = dt.ToString();
Console.WriteLine(strQuinta);

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("4 - Exercícios:\n");

Console.WriteLine("1. Exemplos com float, double e decimal");

float H = 43.22f;
float B = 5.44f;
float area = H * B;
Console.WriteLine("Calculando área utilizando float: " + area);

double valor1 = 8.458743687;
double valor2 = 2.094328244;
double valor3 = valor1 + valor2;
Console.WriteLine("Calculando a soma de dois valores double: " + valor3);

decimal dec1 = 759.5m;
decimal dec2 = 344.9m;
decimal dec3 = dec1 + dec2;
Console.WriteLine("Calculando a subtração entre dois decimals: " + dec3);

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("2. Operações da classe String");

//Cria uma string que é capaz de repetir um caractere um determinado número de vezes
string teste = new string('x', 7);
Console.WriteLine(teste);

//Cria uma string a partir de um array de caracteres
char[] caracteres = { 't', 'e', 's', 't', 'e' };
string teste2 = new string(caracteres);
Console.WriteLine(teste2);

//Chamando um método de formatação de strings
DateTime dataHora = new DateTime(2000, 3, 21, 10, 45, 0);
string stringFormatada = String.Format("As {0:t} de uma {0:D}, foi o momento do meu nascimento.", dataHora);
Console.WriteLine(stringFormatada);

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("3. Operações da classe DateTime");

//Atribuindo a data a um valor computado, com por exemplo a data UTC
DateTime dataAgora = DateTime.Now;
Console.WriteLine(dataAgora);
DateTime dataUTC = DateTime.UtcNow;
Console.WriteLine(dataUTC);
DateTime dataHoje = DateTime.Today;
Console.WriteLine(dataHoje);

//Retorna a data utilizada como padrão pela cultura local através do ToString
var dataLocalPadrao = new DateTime(2022, 7, 12, 11, 35, 0);
Console.WriteLine("Data padrão local: " + dataLocalPadrao.ToString());

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("4. Conversão de dados implícita e explícita");

int i2 = 10;
float f = 0; 
f = i2; //conversão implícita, sem perda de dados
Console.WriteLine(f);

f = 0.5f;
i2 = (int) f; //conversão explícita, com perda de dados
Console.WriteLine(i2);

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("5. Conversões");

string strInt = "123456789";
int valorStrInt = Convert.ToInt32(strInt); //convertendo a string para um inteiro de 32 bits
Console.WriteLine(valorStrInt);

Int64 valorInt64 = 987654321;
int valorInt = Convert.ToInt32(valorInt64); //convertendo um inteiro de 64 bits para um de 32 bits
Console.WriteLine(valorInt);

/*
string stringInteiroGrande = "999999999999999999999999999999999999999999999";
int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);
Console.WriteLine("stringInteiroGrande para int de 32 bits: " + valorStringInteiroGrande);
Não funciona, pois a string não cabe em um inteiro de 32 bits
*/

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("6. TryParse");

string stringInteiro = "123456789";
int valorStringInteiro;
bool tentativaConversao = Int32.TryParse(stringInteiro, out valorStringInteiro);
Console.WriteLine("Conversão efetuada: " + tentativaConversao + " | Valor: " + valorStringInteiro);
//Neste caso ele consegue fazer a conversão pois a stringInteiro cabe em um inteiro de 32 bits

string stringInteiroGrande = "999999999999999999999999999999999999999999999";
int valorStringInteiroGrande;
bool tentativaConversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
Console.WriteLine("Conversão efetuada: " + tentativaConversao2 + " | Valor: " + valorStringInteiroGrande);
//Neste caso ele não consegue fazer a conversão pois a stringInteiroGrande não cabe em um inteiro de 32 bits

long valorStringInteiroGrande2;
bool tentativaConversao3 = Int64.TryParse(stringInteiroGrande, out valorStringInteiroGrande2);
Console.WriteLine("Conversão efetuada: " + tentativaConversao2 + " | Valor: " + valorStringInteiroGrande2);
//Tentativa de conversão utilizando long em um inteiro de 64 bits. Também não funciona.

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("7. Comportamento dos arredondamentos");

double valorFracionado = 4.7;
int valorInteiro1 = (int) valorFracionado;
int valorInteiro2 = Convert.ToInt32(valorFracionado);
Console.WriteLine("Conversão explícita: " + valorInteiro1);
Console.WriteLine("Conversão do método Convert: " + valorInteiro2);

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("8. Sintaxe de exibição de valores de variáveis no console");

int x = 10;
double y = 3.4;
Console.WriteLine("{0} {1}", x, y);
//O {0} e o {1} funcionam como place holders para as variáveis no comando Console.WriteLine. Depois,
//... é passado como parâmetro ao método quais as variáveis que irão ocupar estes lugares, no caso,
//... o x e o y