using System;

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

const string openSpan = "<span>";
const string closeSpan = "</span>";

int spanStart = input.IndexOf(openSpan) + openSpan.Length;
int spanEnd = input.IndexOf(closeSpan);

quantity = input.Substring(spanStart, spanEnd - spanStart);
quantity = $"Quantity: {quantity}";

const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";

const string openDiv = "<div>";
const string closeDiv = "</div>";

int divStartPosition = input.IndexOf(openDiv) + openDiv.Length ;
int divEndPosition = input.IndexOf(closeDiv);


output = input
    .Substring(divStartPosition, divEndPosition - divStartPosition)
    .Replace(tradeSymbol, regSymbol);

output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);