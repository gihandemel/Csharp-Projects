const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += openSpan.Length;

int length = closingPosition - openingPosition;

quantity = input.Substring(openingPosition, length);

output = input.Remove(0,5);
output = output.Replace("</div>","");
output = output.Replace("trade","reg");


//

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");