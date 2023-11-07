


int ppl = int.Parse(Console.ReadLine());    
int eleveatorSpace  = int.Parse(Console.ReadLine());

int courses = 0;
while (ppl > eleveatorSpace)
{
    courses += ppl / eleveatorSpace;
    ppl = ppl % eleveatorSpace;
    
}
if (ppl > 0)
{
courses += 1;

}

Console.WriteLine(courses);


