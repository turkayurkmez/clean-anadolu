// See https://aka.ms/new-console-template for more information
using Functions;

Console.WriteLine("Hello, World!");
/*
 * Temi fonksiyon kuralları:
 * 1. Birim zamanda sadece bir iş yaparlar (One Job at a time). 
 * 2. Parametre sayısı ne kadar azsa o kadar iyi.
 * 3. Fonksiyon gövdesi ne kadar küçükse o kadar iyi.
 */


string getRandomWordFromList(string[] wordList)
{
    return "ağaç";
}

string convertToPuzzle(string word)
{
    return "****";
}

void showPuzzle(string puzzle)
{
    Console.WriteLine(puzzle);
}

string getLetterFromUser()
{
    return "a";

}

bool puzzleIsIncludesLetter(string puzzle, string letter)
{
    return true;
}

string replaceLetterInPuzzle(string puzzle, string letter)
{
    return "a*a*";
}

string getSuggestedWord()
{
    return "ağaç";
}

bool compareWords(string selected, string suggested)
{
    return true;
}

/*
 *   Adam asmaca oyunu
 *   1. Rastgele kelime listesi içinden bir kelime seç.
 *   2. Seçilen kelimenin harf sayısı kadar * karakteri ekrana yazdır.
 *   3. Ekranda bulmacayı göster.
 *   4. Kullanıcıdan bir harf girmesini iste.
 *   5. Harfin kelimede olup olmadığını kontrol et.
 *   6. Varsa; harfin bulunduğu pozisyonları bul ve * işaretini harfle değiştir.
 *      Yoksa; harf tahmin hakkını 1 azalt.
 *   7. Kelimeyi tahmin etmesini iste.
 *   8. Seçilen kelime ile tahmin edilen kelimeyi karşılaştır. Doğruysa oyunu bitir. Yanlış ise 4. adıma dön.
 */   
var wordList = new string[] { "ağaç", "masa", "kalem", "defter" };
string selectedWord = getRandomWordFromList(wordList);
string puzzle = convertToPuzzle(selectedWord);
showPuzzle(puzzle);
var letter = getLetterFromUser();

if (puzzleIsIncludesLetter(puzzle, letter))
{
    puzzle = replaceLetterInPuzzle(puzzle, letter);
    showPuzzle(puzzle);
}

var suggestedWord = getSuggestedWord();

if (compareWords(selectedWord, suggestedWord))
{
    Console.WriteLine("Tebrikler, doğru tahmin");
}

ReportGenerator reportGenerator = new ReportGenerator("sample.xslx");
reportGenerator.CreateReport(new ReportOptions
{
    Title = "Rapor",
    IsColor = true,
    Graphs = new List<object> { "Grafik1", "Grafik2" },
    Designers = new List<string> { "Ahmet", "Mehmet" },
    DataDetails = new List<object> { "Detay1", "Detay2" }
});

