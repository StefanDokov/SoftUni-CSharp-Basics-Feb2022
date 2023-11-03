int kolko = int.Parse(Console.ReadLine());
int obshto = 0;
int takova = 0;
bool toe = false;
for (int ch = 1; ch <= kolko; ch++)
{
    takova = ch;
    while (ch > 0)
    {
        obshto += ch % 10;
        ch = ch / 10;
    }

    if(obshto == 5 || obshto == 7 || obshto == 11){
       toe = true;
    
     }
    else
    {
        toe = false;
    }
    Console.WriteLine("{0} -> {1}", takova, toe);
    obshto = 0;
    ch = takova;

}
