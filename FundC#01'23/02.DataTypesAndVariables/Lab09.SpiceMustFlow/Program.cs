//input
int startYield = int.Parse(Console.ReadLine());

//act
//calculate spice extraction
int dayOperated = 0;
int totalSpiceExtraction = 0;

while (startYield >= 100)
{
    //extract spice and account for worker consum
    totalSpiceExtraction += startYield - 26;

    //decrease yield each day
    startYield -= 10;
    dayOperated++;

}
if (totalSpiceExtraction>=26)
{
        totalSpiceExtraction -= 26;
}
//output
Console.WriteLine(dayOperated);
Console.WriteLine(totalSpiceExtraction);
