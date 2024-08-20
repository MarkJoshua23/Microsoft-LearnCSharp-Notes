string message = "What is the value <span>between the tags</span>?";
// good practice to initialize to variable so you can just use .Length to know number of characters
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

//IndexOf() returns -1 if it can't find a match.
