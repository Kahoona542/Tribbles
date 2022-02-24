string locations; 
bool retry = false;

Console.WriteLine("You are a worker Tribble discussing the grain surplus on Enterprise.");
Console.WriteLine("Tribble leader: 'The humans has been hording the grain surplus, lets hurry and get that grain!'");

Console.WriteLine("Do you want to stay and listen?");

string answer = Console.ReadLine();

if (answer == "yes")
{
    Console.WriteLine("Tribble leader: 'We know the grain on this ship but we don't know where. I have narrowed it down to five rooms, if you could find that grain all tribble kind will be grateful.");
}
else {
    Console.WriteLine("You go back to a meaningless life as a common worker");
    }

Console.WriteLine("Where do you want to go? room 1-5");
locations = Console.ReadLine();
while (retry){
    
     if ( locations == "1")
        {
            Console.WriteLine("This is the Holodeck, no grain here.");
            retry=true;
            }
            else if (locations == "2")
            {
            Console.WriteLine("This is the captain's quarters, no grain here.");
            retry = true;
            }
            else if (locations == "3")
            {
            Console.WriteLine("O..M..G YOU FOUND THE GRAIN!");
            Console.WriteLine("You go back to the Tribble leader to tell him what you found.");
            retry = false;
            }
            else if (locations =="4")
            {
            Console.WriteLine("This is Data's room, no grain here.");
            retry = true;
            }
            else if (locations == "5")
            {
            Console.WriteLine("This is the engine room, no grain here.");
            retry = true;
            }
            else 
            {
                Console.WriteLine("Try again");
                retry = true;
            }
        } 
    

