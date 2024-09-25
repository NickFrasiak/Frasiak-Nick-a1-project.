
//Asking the player their name and remebering it

using System.ComponentModel.Design;

Console.WriteLine("Hello there space traveller! What would you like to be called?");
string playerName = Console.ReadLine();

//Story intro + Player names planet
Console.WriteLine($"{playerName}, You are finnaly aproaching the distant planet you have been travelling to for years. " +
    "Apon arrival your ship is starting to malfuntion, you stick the landing on the undiscovered planet but your ship is wrecked." +
    "You look outside and see the earth like planet. What do you name this planet?");
string planetName = Console.ReadLine();

Console.WriteLine("");
bool hasOxygen = true;

//Players first choice/Player input
Console.WriteLine($"Would you like to explore {planetName} or stay on board and try to fix your ship?");

string playerInput = Console.ReadLine();

//First Path (STAY)
if (playerInput == "stay")
{
    Console.WriteLine("");
    Console.WriteLine("You stay inside to fix your ship! Desperatley looking for tools you cant find any! Do you keep keep looking at the front " +
        "or head to the back of your ship to look there?");

    //Bad ending 1
    Console.WriteLine("");
    playerInput = Console.ReadLine();
    if (playerInput == "front")
    {
        Console.WriteLine($"{playerName},You stay at the front of the ship desperatley looking for tools," +
            $"staying near the malfuntioning gas pipes you no longer can breathe and you collapse... you failed.");
    }
    //Back of the ship option
    else if (playerInput == "back")
    {
        Console.WriteLine("You head to the back of the ship desperatley looking for tools,approaching the very back of the ship you find a tool box!" +
            "There are many tools present, how many do you grab?");

        //Player chooses how many tools they grab using int/parse
        int tools = int.Parse(Console.ReadLine());

        Console.WriteLine($"you grabbed {tools} tools and head back to the front of the ship.");
        Console.WriteLine($"As you approach the front of the ship you use {tools} to attept to fix the ship.");
        if (tools >= 5)
        //good ending 1
        {
            Console.WriteLine($"You succesfully fixed the malfuntioning ship! Earth has recieved an distress signal from {playerName}, and they " +
                "will leave immediately! You did it! You have been saved!");
        }
        else
        //bad ending 2
        {
            Console.WriteLine("The lack of tools and skill cause you to panic and collapse.. you failed");
        }

    }

}

//Second path (EXPLORE)
else if (playerInput == "explore")
    {

        Console.WriteLine($"You leave your broken ship and start to explore this beutiful earth like planet, {planetName} ," +
            "after walking for some time you start to hear some strange noises noises and get the sense you are not alone...");
        Console.WriteLine("");
        Console.WriteLine($"{playerName}, Would you like to head back or keep exploring? After all it could just be your imagination...");


        playerInput = Console.ReadLine();

        if (playerInput == "head back")
        {
            //bad ending 3

            hasOxygen = false;
        if (hasOxygen)
        {
            Console.WriteLine("Your oxygen is running low..");
        }

        Console.WriteLine("You turn around out of fear, your oxygen is starting to deplete you start seeing black and...");
            Console.WriteLine("");
            Console.WriteLine("You failed.");


        }

        else if (playerInput == "keep exploring")
        {
        //(best path imo) 
            Console.WriteLine("You stumble across a cave that smells like home, walking in the noise you have been hearing gets louder..");
            hasOxygen = true;
            Console.WriteLine("You suddenly start beng able to breathe deeply, you feel refreshed");
            Console.WriteLine("");
            Console.WriteLine("You see humanoid like creatures.. they start speaking and somehow you can understand them?");
            Console.WriteLine($"What would you like to name these creatures {playerName}?");
            String alienName = Console.ReadLine();
            Console.WriteLine($"You explain your dire situation to the {alienName} and they offer you help. " +
                "Do you take it?");
            playerInput = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid input please choose head back or keep exploring.");
        }

        if (playerInput == "yes")
        {
           
            //good ending 2
            Console.WriteLine($"These humanoid creatures come back with you to your ship and fix it with advanced tech," +
                "you head home and cant wait to tell everyone at home about your discovery.. congrats you did it!");

        }
        else if (playerInput == "no")
        {
            Console.WriteLine("Your distrust confuses the aliens and they no longer pay attention to you.. " +
                "everything around you turns dark and you get the sense you are falling into a void..");
        }


    }


    else
    {
        Console.WriteLine("you have failed to make a decision and die in a panic, please choose input stay or explore.");
    }


