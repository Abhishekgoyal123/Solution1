// See https://aka.ms/new-console-template for more information
using System.Collections;

string str = "the James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny. The character—also known by the code number 007 (pronounced double-O-seven)—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";

int Wrd_count = 0;
int stat = 0;
int SpChar = 0;
int i, j;

for (i = 0; i < str.Length -1; i++)
{
    if (str[i] == ' ')
        Wrd_count++;
    if (Char.IsDigit(str[i]))
    {
        Console.WriteLine($"index: {i} value {str[i]}");
        //if (str[i + 1] == '.')
        //{
         //   stat--;
        //}

    }

    if (str[i] == '.' && str[i+1]== ' ')
    {
        stat++;
    }
}
    Console.WriteLine($"Total word count = {Wrd_count+1}");

    Console.WriteLine($"Total statement count = {stat}");
    Console.WriteLine($"Total Blank space count = {Wrd_count}");




for (j = 0; j < str.Length; j++)
{
    int ascii = Convert.ToInt32(str[j]);
    if ((ascii >= 33 && ascii <= 47) || (ascii >= 58 && ascii <= 64)
                    || (ascii >= 91 && ascii <= 96) || (ascii >= 123 && ascii <= 126))
    {
        SpChar++;
    }
}



    Console.WriteLine($"Total special character = {SpChar}");

char[] ch = str.ToCharArray();
ch[0] = char.ToUpper(ch[0]);
for (int p = 0; p < ch.Length; p++)
{
    if (ch[p] == ' ')
    {
            ch[p+1] = char.ToUpper(ch[p+1]);
    }
}

str = new string(ch);

Console.WriteLine(str);

