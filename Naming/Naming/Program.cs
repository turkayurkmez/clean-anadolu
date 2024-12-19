// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

var x = 5;
int i = 0;
int ii = -5;

var d = 255; // Bu değişken, müşterinin sisteme kayıt olduğu günden bu yana kaç gün geçtiğini tutar.

//1. Anlamlı değişken isimleri kullanın:
int daysSinceCustomerCreated = 255;
int musterininSistemeKayitOlduguGundenBuYanaGecenGunSayisi = 255;

//bool banuAlkan = false;
//2. Kısaltma kullanmamaya çalışın:
int hp = 100; //Bilgisayar markası
              //Health Point
              //Horse Power
              //Hit Point

int hpComputers = 100;
int healthPoint = 100;

//3. Değişkenin tipine göre uygun bir isimlendirme yapın:
bool isApproved = false;
bool isSelectable = true;

int currentMonth = 5;
double taxRate = 0.20;

//4. Kompleks tiplerde, nesne adı sınıf adını içermelidir:
DataTable customersDataTable = new DataTable();
Random randomNumberGenerator = new Random();

//5. Bir değişken türünün nasıl isimlendirileceğine, ortak karar verilmeli.
var emails = new List<string>();
var emailList = new List<string>();


//bunu yazan yazılımcı kör oldu.
//var o = 0;
//var l = 1;

//if (o==1)
//{
//    o = l;
//}


string password = "Pa$$w0rd";
bool isIncludeLetter = false;
bool isIncludeDigit = false;
bool isIncludeSymbol = false;

bool isPasswordValid = isIncludeLetter && isIncludeDigit && isIncludeSymbol;

if (isPasswordValid)
{

}
int number = 5;
bool isSmallThen10 = number < 10;
bool isLargerOrEqual20 = number >= 20;
bool isModulo3 = number % 3 == 0;

bool isMatchRule = isSmallThen10 && isModulo3;


List<int[]> cellsOnBoard = new List<int[]>();

List<int[]> getFlaggedCells()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var cell in cellsOnBoard)
    {
        //Burada az önce 4 değeri vardı.
        //Bu tarz anlamı belirsiz değerlere "Magic Value" denir.
        if (cell[0] == CellValue.Flagged)
        {
            flaggedCells.Add(cell);
        }
    }

    return flaggedCells;
}

enum CellType
{
    Empty=1,
    Exploded=2,
    Flagged = 4,
    Opened = 8

}

public class  CellValue
{
    public const int Empty = 1;
    public const int Exploded = 2;
    public const int Flagged = 4;
    public const int Opened = 8;


}