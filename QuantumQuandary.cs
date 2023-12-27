using System;
using System.Threading;
using System.ComponentModel.Design;
using System.Text;
using System.Diagnostics.CodeAnalysis;

class Quantum_Quandary
{
    static void Main()
    {
        int Height = 47;
        int Width = 109;
        Console.SetWindowSize(Width, Height);
        Console.SetBufferSize(Width, Height);
        bool PlayMenu = true;
        bool MenuLoop = true;
        int MenuChoices = 0;
        int PlayChoice = 0;

        ConsoleKey keyMenu;
        while (MenuLoop)
        {
        Mylabel:
            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(@"
        ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗████████╗██╗   ██╗███╗   ███╗
       ██╔═══██╗██║   ██║██╔══██╗████╗  ██║╚══██╔══╝██║   ██║████╗ ████║
       ██║   ██║██║   ██║███████║██╔██╗ ██║   ██║   ██║   ██║██╔████╔██║
       ██║▄▄ ██║██║   ██║██╔══██║██║╚██╗██║   ██║   ██║   ██║██║╚██╔╝██║
       ╚██████╔╝╚██████╔╝██║  ██║██║ ╚████║   ██║   ╚██████╔╝██║ ╚═╝ ██║
        ╚══▀▀═╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝     ╚═╝ ");
            Console.WriteLine(@" 
                                       ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗██████╗  █████╗ ██████╗ ██╗   ██╗
                                      ██╔═══██╗██║   ██║██╔══██╗████╗  ██║██╔══██╗██╔══██╗██╔══██╗╚██╗ ██╔╝
                                      ██║   ██║██║   ██║███████║██╔██╗ ██║██║  ██║███████║██████╔╝ ╚████╔╝ 
                                      ██║▄▄ ██║██║   ██║██╔══██║██║╚██╗██║██║  ██║██╔══██║██╔══██╗  ╚██╔╝  
                                      ╚██████╔╝╚██████╔╝██║  ██║██║ ╚████║██████╔╝██║  ██║██║  ██║   ██║   
                                       ╚══▀▀═╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ");
            Console.WriteLine("\n");
            Console.WriteLine("\r\n                         == Press S or Down Arrow and W or Up Arrow to Select ==\n                                      == Press Enter to Proceed == \n");
            switch (MenuChoices)
            {
                case 0: Console.WriteLine(@"
                                            ╔═╗ ╦   ╔═╗ ╦ ╦
                                            ╠═╝ ║   ╠═╣ ╚╦╝
                                            ╩   ╩═╝ ╩ ╩  ╩ 
                                           ┬─┐ ┬ ┬ ┬   ┌─┐ ┌─┐
                                           ├┬┘ │ │ │   ├┤  └─┐
                                           ┴└─ └─┘ ┴─┘ └─┘ └─┘
                                        ┌─┐ ┬─┐ ┌─┐ ┌┬┐ ┬ ┌┬┐ ┌─┐
                                        │   ├┬┘ ├┤   ││ │  │  └─┐
                                        └─┘ ┴└─ └─┘ ─┴┘ ┴  ┴  └─┘                         
                                             ┌─┐ ─┐ ┬ ┬ ┌┬┐
                                             ├┤  ┌┴┬┘ │  │ 
                                             └─┘ ┴ └─ ┴  ┴"); break;
                case 1: Console.WriteLine(@"
                                            ┌─┐ ┬   ┌─┐ ┬ ┬       
                                            ├─┘ │   ├─┤ └┬┘       
                                            ┴   ┴─┘ ┴ ┴  ┴        
                                           ╦═╗ ╦ ╦ ╦   ╔═╗ ╔═╗    
                                           ╠╦╝ ║ ║ ║   ║╣  ╚═╗    
                                           ╩╚═ ╚═╝ ╩═╝ ╚═╝ ╚═╝    
                                        ┌─┐ ┬─┐ ┌─┐ ┌┬┐ ┬ ┌┬┐ ┌─┐
                                        │   ├┬┘ ├┤   ││ │  │  └─┐
                                        └─┘ ┴└─ └─┘ ─┴┘ ┴  ┴  └─┘
                                             ┌─┐ ─┐ ┬ ┬ ┌┬┐        
                                             ├┤  ┌┴┬┘ │  │         
                                             └─┘ ┴ └─ ┴  ┴"); break;
                case 2: Console.WriteLine(@"
                                            ┌─┐ ┬   ┌─┐ ┬ ┬       
                                            ├─┘ │   ├─┤ └┬┘       
                                            ┴   ┴─┘ ┴ ┴  ┴        
                                           ┬─┐ ┬ ┬ ┬   ┌─┐ ┌─┐    
                                           ├┬┘ │ │ │   ├┤  └─┐    
                                           ┴└─ └─┘ ┴─┘ └─┘ └─┘    
                                        ╔═╗ ╦═╗ ╔═╗ ╔╦╗ ╦ ╔╦╗ ╔═╗
                                        ║   ╠╦╝ ║╣   ║║ ║  ║  ╚═╗
                                        ╚═╝ ╩╚═ ╚═╝ ═╩╝ ╩  ╩  ╚═╝
                                             ┌─┐ ─┐ ┬ ┬ ┌┬┐        
                                             ├┤  ┌┴┬┘ │  │         
                                             └─┘ ┴ └─ ┴  ┴"); break;
                case 3: Console.WriteLine(@"
                                            ┌─┐ ┬   ┌─┐ ┬ ┬       
                                            ├─┘ │   ├─┤ └┬┘       
                                            ┴   ┴─┘ ┴ ┴  ┴        
                                           ┬─┐ ┬ ┬ ┬   ┌─┐ ┌─┐    
                                           ├┬┘ │ │ │   ├┤  └─┐    
                                           ┴└─ └─┘ ┴─┘ └─┘ └─┘    
                                        ┌─┐ ┬─┐ ┌─┐ ┌┬┐ ┬ ┌┬┐ ┌─┐
                                        │   ├┬┘ ├┤   ││ │  │  └─┐
                                        └─┘ ┴└─ └─┘ ─┴┘ ┴  ┴  └─┘
                                             ╔═╗ ═╗ ╦ ╦ ╔╦╗        
                                             ║╣  ╔╩╦╝ ║  ║         
                                             ╚═╝ ╩ ╚═ ╩  ╩"); break;
            }
            keyMenu = Console.ReadKey().Key;
            if (keyMenu == ConsoleKey.DownArrow || keyMenu == ConsoleKey.S)
            {
                MenuChoices++;
                if (MenuChoices == 4)
                {
                    MenuChoices--;
                }
            }
            else if (keyMenu == ConsoleKey.UpArrow || keyMenu == ConsoleKey.W)
            {
                MenuChoices--;
                if (MenuChoices == -1)
                {
                    MenuChoices++;
                }
            }
            else if (keyMenu == ConsoleKey.Enter)
            {
                switch (MenuChoices)
                {
                    case 0:
                        Console.Clear();
                        while (PlayMenu)
                        {
                            Console.Clear(); Console.WriteLine("\n\n\n\n\n");
                            Console.WriteLine(@"
                 ██████╗ ██╗      █████╗ ██╗   ██╗    ███╗   ███╗███████╗███╗   ██╗██╗   ██╗
                 ██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝    ████╗ ████║██╔════╝████╗  ██║██║   ██║
                 ██████╔╝██║     ███████║ ╚████╔╝     ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║
                 ██╔═══╝ ██║     ██╔══██║  ╚██╔╝      ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║
                 ██║     ███████╗██║  ██║   ██║       ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝
                 ╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝       ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ");
                            Console.WriteLine("\n\n\n\n\n");
                            switch (PlayChoice)
                            {
                                case 0:
                                    Console.WriteLine(@"
                               ╔═╗ ╦ ╔╗╔ ╔═╗ ╦   ╔═╗   ╔═╗ ╦   ╔═╗ ╦ ╦ ╔═╗ ╦═╗     
                               ╚═╗ ║ ║║║ ║ ╦ ║   ║╣    ╠═╝ ║   ╠═╣ ╚╦╝ ║╣  ╠╦╝     
                               ╚═╝ ╩ ╝╚╝ ╚═╝ ╩═╝ ╚═╝   ╩   ╩═╝ ╩ ╩  ╩  ╚═╝ ╩╚═     

                          ┌─┐ ┬   ┌─┐ ┬ ┬ ┌─┐ ┬─┐  ┬  ┬┌─┐  ┌─┐ ┬   ┌─┐ ┬ ┬ ┌─┐ ┬─┐
                          ├─┘ │   ├─┤ └┬┘ ├┤  ├┬┘  └┐┌┘└─┐  ├─┘ │   ├─┤ └┬┘ ├┤  ├┬┘
                          ┴   ┴─┘ ┴ ┴  ┴  └─┘ ┴└─   └┘ └─┘  ┴   ┴─┘ ┴ ┴  ┴  └─┘ ┴└─

                                          ┬─┐ ┌─┐ ┌┬┐ ┬ ┬ ┬─┐ ┌┐┌               
                                          ├┬┘ ├┤   │  │ │ ├┬┘ │││               
                                          ┴└─ └─┘  ┴  └─┘ ┴└─ ┘└┘"); break;
                                case 1:
                                    Console.WriteLine(@"
                               ┌─┐ ┬ ┌┐┌ ┌─┐ ┬   ┌─┐   ┌─┐ ┬   ┌─┐ ┬ ┬ ┌─┐ ┬─┐     
                               └─┐ │ │││ │ ┬ │   ├┤    ├─┘ │   ├─┤ └┬┘ ├┤  ├┬┘     
                               └─┘ ┴ ┘└┘ └─┘ ┴─┘ └─┘   ┴   ┴─┘ ┴ ┴  ┴  └─┘ ┴└─  

                          ╔═╗ ╦   ╔═╗ ╦ ╦ ╔═╗ ╦═╗  ╦  ╦╔═╗  ╔═╗ ╦   ╔═╗ ╦ ╦ ╔═╗ ╦═╗
                          ╠═╝ ║   ╠═╣ ╚╦╝ ║╣  ╠╦╝  ╚╗╔╝╚═╗  ╠═╝ ║   ╠═╣ ╚╦╝ ║╣  ╠╦╝
                          ╩   ╩═╝ ╩ ╩  ╩  ╚═╝ ╩╚═   ╚╝ ╚═╝  ╩   ╩═╝ ╩ ╩  ╩  ╚═╝ ╩╚═

                                          ┬─┐ ┌─┐ ┌┬┐ ┬ ┬ ┬─┐ ┌┐┌               
                                          ├┬┘ ├┤   │  │ │ ├┬┘ │││               
                                          ┴└─ └─┘  ┴  └─┘ ┴└─ ┘└┘"); break;
                                case 2:
                                    Console.WriteLine(@"
                               ┌─┐ ┬ ┌┐┌ ┌─┐ ┬   ┌─┐   ┌─┐ ┬   ┌─┐ ┬ ┬ ┌─┐ ┬─┐     
                               └─┐ │ │││ │ ┬ │   ├┤    ├─┘ │   ├─┤ └┬┘ ├┤  ├┬┘     
                               └─┘ ┴ ┘└┘ └─┘ ┴─┘ └─┘   ┴   ┴─┘ ┴ ┴  ┴  └─┘ ┴└─  

                          ┌─┐ ┬   ┌─┐ ┬ ┬ ┌─┐ ┬─┐  ┬  ┬┌─┐  ┌─┐ ┬   ┌─┐ ┬ ┬ ┌─┐ ┬─┐
                          ├─┘ │   ├─┤ └┬┘ ├┤  ├┬┘  └┐┌┘└─┐  ├─┘ │   ├─┤ └┬┘ ├┤  ├┬┘
                          ┴   ┴─┘ ┴ ┴  ┴  └─┘ ┴└─   └┘ └─┘  ┴   ┴─┘ ┴ ┴  ┴  └─┘ ┴└─

                                          ╦═╗ ╔═╗ ╔╦╗ ╦ ╦ ╦═╗ ╔╗╔               
                                          ╠╦╝ ║╣   ║  ║ ║ ╠╦╝ ║║║               
                                          ╩╚═ ╚═╝  ╩  ╚═╝ ╩╚═ ╝╚╝"); break;
                            };
                            keyMenu = Console.ReadKey().Key;
                            if (keyMenu == ConsoleKey.DownArrow || keyMenu == ConsoleKey.S)
                            {
                                PlayChoice++;
                                if (PlayChoice == 3)
                                {
                                    PlayChoice--;
                                }
                            }
                            else if (keyMenu == ConsoleKey.UpArrow || keyMenu == ConsoleKey.W)
                            {
                                PlayChoice--;
                                if (PlayChoice == -1)
                                {
                                    PlayChoice++;
                                }
                            }
                            else if (keyMenu == ConsoleKey.Enter)
                            {
                                switch (PlayChoice)
                                {
                                    case 0: Console.Clear(); SinglePlayer(); Console.Clear(); break;
                                    case 1: PlayerVsPlayer(); Console.Clear(); break;
                                    case 2: goto Mylabel;
                                }
                                PlayMenu = false;
                            };
                        }; break;
                    case 1: DisplayHowToPlay(); Console.Clear(); goto Mylabel;
                    case 2: DisplayCredits(); Console.Clear(); goto Mylabel;
                    case 3: Environment.Exit(0); break;
                }
                MenuLoop = false;
            }
        }
    }




    static void PlayerVsPlayer()
    {
        string player1Element = "";
        string player2Element = "";
        int roundNum = 1;
        int playerOneChargeAmount = 2;
        int playerTwoChargeAmount = 2;

    charge:
        Console.Clear();

        while (true)
        {
            playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
            ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
            startAnimation();
            ConsoleKeyInfo choice = Console.ReadKey(true);

            switch (choice.Key)
            {
                case ConsoleKey.Escape:
                    Console.Clear();
                    Escape();
                    goto charge;
                case ConsoleKey.Q:
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerOne();
                    Console.WriteLine("Player 1 decided");
                    player1Element = "Charge";
                    break;
                case ConsoleKey.W:
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerOne();
                    Console.WriteLine("Player 1 decided");
                    player1Element = "Surrender";
                    break;
                case ConsoleKey.E:
                    if (playerOneChargeAmount < 3)
                    {
                        goto charge;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerOne();
                    Console.WriteLine("Player 1 decided");
                    player1Element = "Mirror";
                    break;
                case ConsoleKey.A:
                    if (playerOneChargeAmount < 2)
                    {
                        goto charge;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerOne();
                    Console.WriteLine("Player 1 decided");
                    player1Element = "Gun";
                    break;
                case ConsoleKey.S:
                    if (playerOneChargeAmount < 5)
                    {
                        goto charge;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerOne();
                    Console.WriteLine("Player 1 decided");
                    player1Element = "Kamehameha";
                    break;
                case ConsoleKey.D:
                    if (playerOneChargeAmount < 8)
                    {
                        goto charge;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerOne();
                    player1Element = "Nuclear Bomb";
                    Console.WriteLine("Player 1 decided");
                    break;
                case ConsoleKey.I:
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerTwo();
                    Console.WriteLine("Player 2 decided");
                    player2Element = "Charge";
                    break;
                case ConsoleKey.O:
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerTwo();
                    Console.WriteLine("Player 2 decided");
                    player2Element = "Surrender";
                    break;
                case ConsoleKey.P:
                    if (playerTwoChargeAmount < 3)
                    {
                        goto charge;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerTwo();
                    Console.WriteLine("Player 2 decided");
                    player2Element = "Mirror";
                    break;
                case ConsoleKey.J:
                    if (playerTwoChargeAmount < 2)
                    {
                        goto charge;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerTwo();
                    Console.WriteLine("Player 2 decided");
                    player2Element = "Gun";
                    break;
                case ConsoleKey.K:
                    if (playerTwoChargeAmount < 5)
                    {
                        goto charge;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerTwo();
                    Console.WriteLine("Player 2 decided");
                    player2Element = "Kamehameha";
                    break;
                case ConsoleKey.L:
                    if (playerTwoChargeAmount < 8)
                    {
                        goto charge;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyPlayerTwo();
                    Console.WriteLine("Player 2 decided");
                    player2Element = "Nuclear Bomb";
                    break;
                default:
                    goto charge;
            }
        charge1:
            ConsoleKeyInfo choice1 = Console.ReadKey(true);
            switch (choice1.Key)
            {
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.WriteLine("Are you sure you want to exit to Main Menu?");
                    Console.WriteLine("Y/N");
                    ConsoleKeyInfo Esc1 = Console.ReadKey(true);
                    switch (Esc1.Key)
                    {
                        case ConsoleKey.Y:
                            Console.Clear();
                            Main();
                            break;
                        default:
                            Console.Clear();
                            goto charge;
                    }
                    break;
                case ConsoleKey.H:
                    DisplayHowToPlay();
                    goto charge;
                case ConsoleKey.Q:
                    if ((choice.Key == ConsoleKey.Q) || (choice.Key == ConsoleKey.W) || (choice.Key == ConsoleKey.E) || (choice.Key == ConsoleKey.A) || (choice.Key == ConsoleKey.S) || (choice.Key == ConsoleKey.D))
                    {
                        goto charge1;
                    }
                    else
                    {
                        Console.Clear();
                        playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                        ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                        readyBothPlayers();
                        Console.WriteLine("Player 2 decided");
                        Console.WriteLine("Player 1 decided");
                        player1Element = "Charge";
                        break;
                    }
                case ConsoleKey.W:
                    if ((choice.Key == ConsoleKey.Q) || (choice.Key == ConsoleKey.W) || (choice.Key == ConsoleKey.E) || (choice.Key == ConsoleKey.A) || (choice.Key == ConsoleKey.S) || (choice.Key == ConsoleKey.D))
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 2 decided");
                    Console.WriteLine("Player 1 decided");
                    player1Element = "Surrender";
                    break;
                case ConsoleKey.E:
                    if ((choice.Key == ConsoleKey.Q) || (choice.Key == ConsoleKey.W) || (choice.Key == ConsoleKey.E) || (choice.Key == ConsoleKey.A) || (choice.Key == ConsoleKey.S) || (choice.Key == ConsoleKey.D))
                    {
                        goto charge1;
                    }
                    if (playerOneChargeAmount < 3)
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 2 decided");
                    Console.WriteLine("Player 1 decided");
                    playerOneChargeAmount -= 3;
                    player1Element = "Mirror";
                    break;
                case ConsoleKey.A:
                    if ((choice.Key == ConsoleKey.Q) || (choice.Key == ConsoleKey.W) || (choice.Key == ConsoleKey.E) || (choice.Key == ConsoleKey.A) || (choice.Key == ConsoleKey.S) || (choice.Key == ConsoleKey.D))
                    {
                        goto charge1;
                    }
                    if (playerOneChargeAmount < 2)
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 2 decided");
                    Console.WriteLine("Player 1 decided");
                    playerOneChargeAmount -= 2;
                    player1Element = "Gun";
                    break;
                case ConsoleKey.S:
                    if ((choice.Key == ConsoleKey.Q) || (choice.Key == ConsoleKey.W) || (choice.Key == ConsoleKey.E) || (choice.Key == ConsoleKey.A) || (choice.Key == ConsoleKey.S) || (choice.Key == ConsoleKey.D))
                    {
                        goto charge1;
                    }
                    if (playerOneChargeAmount < 5)
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 2 decided");
                    Console.WriteLine("Player 1 decided");
                    playerOneChargeAmount -= 5;
                    player1Element = "Kamehameha";
                    break;
                case ConsoleKey.D:
                    if ((choice.Key == ConsoleKey.Q) || (choice.Key == ConsoleKey.W) || (choice.Key == ConsoleKey.E) || (choice.Key == ConsoleKey.A) || (choice.Key == ConsoleKey.S) || (choice.Key == ConsoleKey.D))
                    {
                        goto charge1;
                    }
                    if (playerOneChargeAmount < 8)
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 2 decided");
                    Console.WriteLine("Player 1 decided");
                    playerOneChargeAmount -= 8;
                    player1Element = "Nuclear Bomb";
                    break;
                case ConsoleKey.I:
                    if ((choice.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.L))
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 1 decided");
                    Console.WriteLine("Player 2 decided");
                    player2Element = "Charge";
                    break;
                case ConsoleKey.O:
                    if ((choice.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.L))
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 1 decided");
                    Console.WriteLine("Player 2 decided");
                    player2Element = "Surrender";
                    break;
                case ConsoleKey.P:
                    if ((choice.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.L))
                    {
                        goto charge1;
                    }
                    if (playerTwoChargeAmount < 3)
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 1 decided");
                    Console.WriteLine("Player 2 decided");
                    playerTwoChargeAmount -= 3;
                    player2Element = "Mirror";
                    break;
                case ConsoleKey.J:
                    if ((choice.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.L))
                    {
                        goto charge1;
                    }
                    if (playerTwoChargeAmount < 2)
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 1 decided");
                    Console.WriteLine("Player 2 decided");
                    playerTwoChargeAmount -= 2;
                    player2Element = "Gun";
                    break;
                case ConsoleKey.K:
                    if ((choice.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.L))
                    {
                        goto charge1;
                    }
                    if (playerTwoChargeAmount < 5)
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 1 decided");
                    Console.WriteLine("Player 2 decided");
                    playerTwoChargeAmount -= 5;
                    player2Element = "Kamehameha";
                    break;
                case ConsoleKey.L:
                    if ((choice.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.L))
                    {
                        goto charge1;
                    }
                    if (playerTwoChargeAmount < 8)
                    {
                        goto charge1;
                    }
                    Console.Clear();
                    playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
                    ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
                    readyBothPlayers();
                    Console.WriteLine("Player 1 decided");
                    Console.WriteLine("Player 2 decided");
                    playerTwoChargeAmount -= 8;
                    player2Element = "Nuclear Bomb";
                    break;
                default:
                    goto charge1;
            }
            if (choice.Key == ConsoleKey.E) { playerOneChargeAmount -= 3; }
            if (choice.Key == ConsoleKey.A) { playerOneChargeAmount -= 2; }
            if (choice.Key == ConsoleKey.S) { playerOneChargeAmount -= 5; }
            if (choice.Key == ConsoleKey.D) { playerOneChargeAmount -= 8; }
            if (choice.Key == ConsoleKey.P) { playerTwoChargeAmount -= 3; }
            if (choice.Key == ConsoleKey.J) { playerTwoChargeAmount -= 2; }
            if (choice.Key == ConsoleKey.K) { playerTwoChargeAmount -= 5; }
            if (choice.Key == ConsoleKey.L) { playerTwoChargeAmount -= 8; }
            Thread.Sleep(1000);
            Console.Clear();
            playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum);
            ChargeBar(playerOneChargeAmount, playerTwoChargeAmount);
            if ((choice.Key == ConsoleKey.Q && choice1.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.O && choice1.Key == ConsoleKey.Q)) { playerOneCharge(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneCharge1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneCharge2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneCharge3(); } //p1 charge p2 surrender
            if ((choice.Key == ConsoleKey.W && choice1.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.I && choice1.Key == ConsoleKey.W)) { playerTwoCharge(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoCharge1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoCharge2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerTwoCharge3(); } //p1 surrender p2 charge
            if ((choice.Key == ConsoleKey.Q && choice1.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.I && choice1.Key == ConsoleKey.Q)) { bothCharge(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); bothCharge1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); bothCharge2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; bothCharge3(); } //both charge
            if ((choice.Key == ConsoleKey.W && choice1.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.O && choice1.Key == ConsoleKey.W)) { bothSurrender(); Thread.Sleep(500); } //both surrender
            if ((choice.Key == ConsoleKey.A && choice1.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.J && choice1.Key == ConsoleKey.A)) { bothGun(); Thread.Sleep(500); } //both gun
            if ((choice.Key == ConsoleKey.A && choice1.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.O && choice1.Key == ConsoleKey.A)) { playerOneGun(); Thread.Sleep(500); } // p1 gun p2 surrender
            if ((choice.Key == ConsoleKey.J && choice1.Key == ConsoleKey.W) || (choice.Key == ConsoleKey.W && choice1.Key == ConsoleKey.J)) { playerTwoGun(); Thread.Sleep(500); } //p1 surrender p2 gun
            if ((choice.Key == ConsoleKey.A && choice1.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.I && choice1.Key == ConsoleKey.A)) { playerOneKillsWGun(); Thread.Sleep(500); } //p1 gun p2 charge
            if ((choice.Key == ConsoleKey.Q && choice1.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.J && choice1.Key == ConsoleKey.Q)) { playerTwoKillsWGun(); Thread.Sleep(500); } //p1 charge p2 gun
            if ((choice.Key == ConsoleKey.S && choice1.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.O && choice1.Key == ConsoleKey.S)) { playerOneKame(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneKame2(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame3(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame4(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneKame5(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame6(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame7(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneKame8(); } //p1 kame p2 surrender
            if ((choice.Key == ConsoleKey.S && choice1.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.I && choice1.Key == ConsoleKey.S)) { kameCharge(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameCharge1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameCharge2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; kameCharge2(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameCharge3(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameCharge4(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; kameCharge5(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameCharge6(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameCharge7(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; kameCharge8(); } //p1 kame p2 charge
            if ((choice.Key == ConsoleKey.S && choice1.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.P && choice1.Key == ConsoleKey.S)) { playerOneKame(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneKame2(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame3(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameNMirror(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; kameNMirror1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameNMirror2(); } //p1 kame p2 mirror
            if ((choice.Key == ConsoleKey.A && choice1.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.P && choice1.Key == ConsoleKey.A)) { gunNMirror(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); gunNMirror1(); } //p1 gun p2 mirror
            if ((choice.Key == ConsoleKey.D && (choice1.Key == ConsoleKey.I || choice1.Key == ConsoleKey.I || choice1.Key == ConsoleKey.O || choice1.Key == ConsoleKey.J || choice1.Key == ConsoleKey.K || choice1.Key == ConsoleKey.P)) || (choice1.Key == ConsoleKey.D && (choice.Key == ConsoleKey.I || choice.Key == ConsoleKey.I || choice.Key == ConsoleKey.O || choice.Key == ConsoleKey.J || choice.Key == ConsoleKey.K || choice1.Key == ConsoleKey.P))) { playerOneNuke(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneNuke1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneNuke2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneNuke3(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneNuke4(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneNuke5(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneNuke6(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneNuke7(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneNuke8(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneNuke8(); }  //p1 nuke
            if ((choice.Key == ConsoleKey.E && choice1.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.K && choice1.Key == ConsoleKey.E)) { playerTwoKame(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerTwoKame2(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame3(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); mirrorNKame(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; mirrorNKame1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); mirrorNKame2(); } //p1 mirror p2 kame
            if ((choice.Key == ConsoleKey.W && choice1.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.K && choice1.Key == ConsoleKey.W)) { playerTwoKame(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerTwoKame2(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame3(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame4(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerTwoKame5(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame6(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame7(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerTwoKame8(); } //p1 kame p2 surrender
            if ((choice.Key == ConsoleKey.Q && choice1.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.K && choice1.Key == ConsoleKey.Q)) { chargeKame(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); chargeKame1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); chargeKame2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; chargeKame2(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); chargeKame3(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); chargeKame4(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; chargeKame5(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); chargeKame6(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); chargeKame7(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; chargeKame8(); } //p1 charge p2 kame
            if ((choice.Key == ConsoleKey.E && choice1.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.J && choice1.Key == ConsoleKey.E)) { mirrorNGun(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); mirrorNGun1(); } //p1 mirror p2 gun
            if ((choice.Key == ConsoleKey.L && (choice1.Key == ConsoleKey.Q || choice1.Key == ConsoleKey.W || choice1.Key == ConsoleKey.E || choice1.Key == ConsoleKey.A || choice1.Key == ConsoleKey.S || choice1.Key == ConsoleKey.Q)) || (choice1.Key == ConsoleKey.L && (choice.Key == ConsoleKey.Q || choice.Key == ConsoleKey.Q || choice.Key == ConsoleKey.W || choice.Key == ConsoleKey.E || choice.Key == ConsoleKey.A || choice1.Key == ConsoleKey.S))) { playerTwoNuke(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoNuke1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoNuke2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerTwoNuke3(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoNuke4(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoNuke5(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerTwoNuke6(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoNuke7(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneNuke8(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneNuke8(); } //p2 nuke
            if ((choice.Key == ConsoleKey.E && choice1.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.P && choice1.Key == ConsoleKey.E)) { bothMirror(); Thread.Sleep(500); } //both mirror
            if ((choice.Key == ConsoleKey.D && choice1.Key == ConsoleKey.L) || (choice.Key == ConsoleKey.L && choice1.Key == ConsoleKey.D)) { bothNuke(); Thread.Sleep(500); } //both nuke
            if ((choice.Key == ConsoleKey.S && choice1.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.K && choice1.Key == ConsoleKey.S)) { bothKame(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); bothKame1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); bothKame2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); bothKame3(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); bothKame4(); }//both kame
            if ((choice.Key == ConsoleKey.A && choice1.Key == ConsoleKey.K) || (choice.Key == ConsoleKey.K && choice1.Key == ConsoleKey.A)) { gunNKame(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); gunNKame1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); gunNKame2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; gunNKame2(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); gunNKame3(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); gunNKame4(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; gunNKame5(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame6(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerTwoKame7(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerTwoKame8(); } //p1 gun p2 kame
            if ((choice.Key == ConsoleKey.S && choice1.Key == ConsoleKey.J) || (choice.Key == ConsoleKey.J && choice1.Key == ConsoleKey.S)) { kameNGun(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameNGun1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameNGun2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; kameNGun2(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameNGun3(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); kameNGun4(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; kameNGun5(); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame6(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); playerOneKame7(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); ; playerOneKame8(); } //p1 kame p2 gun
            if ((choice.Key == ConsoleKey.Q && choice1.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.P && choice1.Key == ConsoleKey.Q)) { chargeNMirror(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); chargeNMirror1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); chargeNMirror2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); chargeNMirror3(); }//p1 charge p2 mirror
            if ((choice.Key == ConsoleKey.E && choice1.Key == ConsoleKey.O) || (choice.Key == ConsoleKey.O && choice1.Key == ConsoleKey.E)) { mirrorNSurrender(); Thread.Sleep(500); }//p1 mirror p2 surrender
            if ((choice.Key == ConsoleKey.E && choice1.Key == ConsoleKey.I) || (choice.Key == ConsoleKey.I && choice1.Key == ConsoleKey.E)) { mirrorNCharge(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); mirrorNCharge1(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); mirrorNCharge2(); Thread.Sleep(500); Console.Clear(); playerVSplayerGame(playerOneChargeAmount, playerTwoChargeAmount, roundNum); ChargeBar(playerOneChargeAmount, playerTwoChargeAmount); mirrorNCharge3(); }//p1 mirror p2 charge
            if ((choice.Key == ConsoleKey.W && choice1.Key == ConsoleKey.P) || (choice.Key == ConsoleKey.P && choice1.Key == ConsoleKey.W)) surrenderNMirror(); Thread.Sleep(500);//p1 surrender p2 mirror

            Console.WriteLine($"\nPlayer One played {player1Element} and Player Two played {player2Element}");
            Thread.Sleep(500);
            if (choice.Key == ConsoleKey.Q) { playerOneChargeAmount++; }
            if (choice.Key == ConsoleKey.I) { playerTwoChargeAmount++; }
            if (choice1.Key == ConsoleKey.Q) { playerOneChargeAmount++; }
            if (choice1.Key == ConsoleKey.I) { playerTwoChargeAmount++; }

            if ((choice.Key == ConsoleKey.A && choice1.Key == ConsoleKey.I) ||
                (choice1.Key == ConsoleKey.A && choice.Key == ConsoleKey.I) ||
                (choice.Key == ConsoleKey.S && (choice1.Key == ConsoleKey.I || choice1.Key == ConsoleKey.I || choice1.Key == ConsoleKey.J)) ||
                (choice1.Key == ConsoleKey.S && (choice.Key == ConsoleKey.I || choice.Key == ConsoleKey.I || choice.Key == ConsoleKey.J)) ||
                (choice.Key == ConsoleKey.D && (choice1.Key == ConsoleKey.I || choice1.Key == ConsoleKey.I || choice1.Key == ConsoleKey.O || choice1.Key == ConsoleKey.J || choice1.Key == ConsoleKey.K || choice1.Key == ConsoleKey.P)) ||
                (choice1.Key == ConsoleKey.D && (choice.Key == ConsoleKey.I || choice.Key == ConsoleKey.I || choice.Key == ConsoleKey.O || choice.Key == ConsoleKey.J || choice.Key == ConsoleKey.K || choice1.Key == ConsoleKey.P)) ||
                (choice.Key == ConsoleKey.E && (choice1.Key == ConsoleKey.J || choice1.Key == ConsoleKey.K)) ||
                (choice1.Key == ConsoleKey.E && (choice.Key == ConsoleKey.J || choice.Key == ConsoleKey.K)) ||
                (choice1.Key == ConsoleKey.O && (choice.Key == ConsoleKey.S || choice.Key == ConsoleKey.D)) ||
                (choice.Key == ConsoleKey.O && (choice1.Key == ConsoleKey.S || choice1.Key == ConsoleKey.D)) ||
                (choice1.Key == ConsoleKey.P && choice.Key == ConsoleKey.D) ||
                (choice.Key == ConsoleKey.P && choice1.Key == ConsoleKey.D) ||
                (choice1.Key == ConsoleKey.J && (choice.Key == ConsoleKey.E || choice.Key == ConsoleKey.S || choice.Key == ConsoleKey.D)) ||
                (choice.Key == ConsoleKey.J && (choice1.Key == ConsoleKey.E || choice1.Key == ConsoleKey.S || choice1.Key == ConsoleKey.D)) ||
                (choice1.Key == ConsoleKey.K && (choice.Key == ConsoleKey.E || choice.Key == ConsoleKey.D)) ||
                (choice.Key == ConsoleKey.K && (choice1.Key == ConsoleKey.E || choice1.Key == ConsoleKey.D)))
            {
                Console.WriteLine("\nPlayer One Wins");

                Thread.Sleep(1000);
                Console.WriteLine("Play again? [Y/N]");

                ConsoleKeyInfo playAgainChoice = Console.ReadKey(true);

                switch (playAgainChoice.Key)
                {
                    case ConsoleKey.Y:
                        Console.Clear();
                        playerTwoChargeAmount = 2;
                        playerOneChargeAmount = 2;
                        roundNum -= roundNum;
                        goto charge;
                    default:
                        Console.Clear();
                        Main();
                        break;
                }

            }
            else if ((choice1.Key == ConsoleKey.J && choice.Key == ConsoleKey.Q) ||
                     (choice.Key == ConsoleKey.J && choice1.Key == ConsoleKey.Q) ||
                     (choice1.Key == ConsoleKey.K && (choice.Key == ConsoleKey.Q || choice.Key == ConsoleKey.W || choice.Key == ConsoleKey.A)) ||
                     (choice.Key == ConsoleKey.K && (choice1.Key == ConsoleKey.Q || choice1.Key == ConsoleKey.W || choice1.Key == ConsoleKey.A)) ||
                     (choice1.Key == ConsoleKey.L && (choice.Key == ConsoleKey.Q || choice.Key == ConsoleKey.W || choice.Key == ConsoleKey.E || choice.Key == ConsoleKey.A || choice.Key == ConsoleKey.S)) ||
                     (choice.Key == ConsoleKey.L && (choice1.Key == ConsoleKey.Q || choice1.Key == ConsoleKey.W || choice1.Key == ConsoleKey.E || choice1.Key == ConsoleKey.A || choice1.Key == ConsoleKey.S)) ||
                     (choice1.Key == ConsoleKey.P && (choice.Key == ConsoleKey.A || choice.Key == ConsoleKey.S)) ||
                     (choice.Key == ConsoleKey.P && (choice1.Key == ConsoleKey.A || choice1.Key == ConsoleKey.S)) ||
                     (choice1.Key == ConsoleKey.W && (choice.Key == ConsoleKey.K || choice.Key == ConsoleKey.L)) ||
                     (choice.Key == ConsoleKey.W && (choice1.Key == ConsoleKey.K || choice1.Key == ConsoleKey.L)) ||
                     (choice1.Key == ConsoleKey.E && choice.Key == ConsoleKey.L) ||
                     (choice.Key == ConsoleKey.E && choice1.Key == ConsoleKey.L) ||
                     (choice1.Key == ConsoleKey.A && (choice.Key == ConsoleKey.P || choice.Key == ConsoleKey.K || choice.Key == ConsoleKey.L)) ||
                     (choice.Key == ConsoleKey.A && (choice1.Key == ConsoleKey.P || choice1.Key == ConsoleKey.K || choice1.Key == ConsoleKey.L)) ||
                     (choice1.Key == ConsoleKey.S && (choice.Key == ConsoleKey.P || choice.Key == ConsoleKey.L)) ||
                     (choice.Key == ConsoleKey.S && (choice1.Key == ConsoleKey.P || choice1.Key == ConsoleKey.L)))
            {
                Console.WriteLine("\nPlayer Two Wins");

                Thread.Sleep(1000);
                Console.WriteLine("Play again? [Y/N]");

                ConsoleKeyInfo playAgainChoice = Console.ReadKey(true);

                switch (playAgainChoice.Key)
                {
                    case ConsoleKey.Y:
                        Console.Clear();
                        playerTwoChargeAmount = 2;
                        playerOneChargeAmount = 2;
                        roundNum -= roundNum;
                        goto charge;
                    default:
                        Console.Clear();
                        startAnimation();
                        Main();
                        break;
                }
            }

            else
            {
                roundNum++;
                if (playerOneChargeAmount == 0 && playerTwoChargeAmount == 0) { playerOneChargeAmount = 2; playerTwoChargeAmount = 2; }
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
    static void startAnimation()
    { Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                                                        ██            █
    █           ███                                                                        ███           █
    █          █████                                                                      █████          █
    █          █████                                                                      █████          █
    █          █████                                                                      █████          █
    █          ████                                                                        ████          █
    █           █ █                                                                        █ █           █
    █           █ █                                                                        █ █           █
    █           █                                                                            █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█"); }
    static void startAnimation2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █     
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █ 
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █            ██                                                                        ██            █
    █           ███                                                                        ███           █
    █           ███                                                                        ███           █
    █          █████                                                                      █████          █
    █          █████                                                                      █████          █
    █          █████                                                                      █████          █
    █          ████                                                                        ████          █
    █           █ █                                                                        █ █           █
    █           █ █                                                                        █ █           █
    █           █                                                                            █           █
    █                                                                                                    █   
    █                                                                                                    █   
    █                                                                                                    █    
    █                                                                                                    █   
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void startAnimation3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █     
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █ 
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █            ██                                                                        ██            █
    █           ███                                                                        ███           █
    █          █████                                                                      █████          █
    █          █████                                                                      █████          █
    █          █████                                                                      █████          █
    █          ████                                                                        ████          █
    █           ███                                                                        ███           █
    █           █ █                                                                        █ █           █
    █           █ █                                                                        █ █           █
    █           █                                                                            █           █
    █                                                                                                    █   
    █                                                                                                    █   
    █                                                                                                    █    
    █                                                                                                    █   
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void startAnimation4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █     
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █ 
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █            ██                                                                        ██            █
    █           ███                                                                        ███           █
    █           ███                                                                        ███           █
    █          █████                                                                      █████          █
    █          █████                                                                      █████          █
    █          █████                                                                      █████          █
    █          ████                                                                        ████          █
    █           █ █                                                                        █ █           █
    █           █ █                                                                        █ █           █
    █           █                                                                            █           █
    █                                                                                                    █   
    █                                                                                                    █   
    █                                                                                                    █    
    █                                                                                                    █   
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void readyBothPlayers()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                                                        ██            █
    █           ███                                                                        ███           █
    █          █████ █                                                                  █ █████          █
    █         █ █████                                                                    █████ █         █
    █         █ ███                                                                        ███ █         █
    █           ██████                                                                  ██████           █
    █           █    █                                                                  █    █           █
    █          █                                                                              █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void readyPlayerOne()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                      ██            █
    █            ██                                                                        ███           █
    █           ███                                                                       █████          █
    █          █████ █                                                                    █████          █
    █         █ █████                                                                     █████          █
    █         █ ███                                                                        ████          █
    █           ██████                                                                     █ █           █
    █           █    █                                                                     █ █           █
    █          █                                                                             █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void readyPlayerTwo()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                                                                      █
    █           ███                                                                        ██            █
    █          █████                                                                       ███           █
    █          █████                                                                    █ █████          █
    █          █████                                                                     █████ █         █
    █          ████                                                                        ███ █         █
    █           █ █                                                                     ██████           █
    █           █ █                                                                     █    █           █
    █           █                                                                             █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void bothCharge()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █         ┼    ┼                                                                         ┼           █
    █                  ┼                                                                ┼             ┼  █
    █                                                                                                    █
    █    ┼   ┼   ██                                                                ┼       ██    ┼       █
    █           ███      ┼                                                                 ███           █
    █          ████ █                                                                    █ ████          █
    █   ┼     ██████                                                                  ┼   ██████         █
    █         ████        ┼                                                                █████       ┼ █
    █     ┼   █████                                                                       █████   ┼      █
    █         █   █   ┼                                                              ┼    █   █          █
    █        █                                                                                 █         █
    █                                                                                               ┼    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void bothCharge1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █          ┼  ┼                                                                       ┼  ┼  ┼        █
    █            ██ ┼                                                                      ██            █
    █       ┼ ┼ ███                                                                   ┼    ███ ┼         █
    █          ████ █ ┼                                                                  █ ████          █
    █       ┼ ██████                                                                    ┼ ██████         █
    █        ┼████    ┼                                                                    █████ ┼       █
    █         █████ ┼                                                                   ┼ █████ ┼        █
    █         █   █                                                                       █   █          █
    █        █                                                                                 █ ┼       █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void bothCharge2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ░░                                                                        ░░            █
    █           ░░░                                                                        ░░░           █
    █          ░░░░ ░                                                                    ░ ░░░░          █
    █         ░░░░░░                                                                      ░░░░░░         █
    █         ░░░░                                                                         ░░░░░         █
    █         ░░░░░                                                                       ░░░░░          █
    █         ░   ░                                                                       ░   ░          █
    █        ░                                                                                 ░         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void bothCharge3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                                                        ██            █
    █           ███                                                                        ███           █
    █          ████ █                                                                    █ ████          █
    █         ██████                                                                      ██████         █
    █         ████                                                                         █████         █
    █         █████                                                                       █████          █
    █         █   █                                                                       █   █          █
    █        █                                                                                 █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoCharge()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █          █                                                                             ┼           █
    █          █  █                                                                     ┼             ┼  █
    █          █ ██                                                                                      █
    █          ████                                                                ┼       ██    ┼       █
    █          ████                                                                        ███           █
    █          ████                                                                      █ ████          █
    █           ███                                                                   ┼   ██████         █
    █           ███                                                                        █████       ┼ █
    █           █ █                                                                       █████   ┼      █
    █           █ █                                                                  ┼    █   █          █
    █           █                                                                              █         █
    █                                                                                               ┼    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoCharge1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █          █                                                                                         █
    █          █  █                                                                                      █
    █          █ ██                                                                       ┼  ┼  ┼        █
    █          ████                                                                        ██            █
    █          ████                                                                   ┼    ███ ┼         █
    █          ████                                                                      █ ████          █
    █           ███                                                                     ┼ ██████         █
    █           ███                                                                        █████ ┼       █
    █           █ █                                                                     ┼ █████ ┼        █
    █           █ █                                                                       █   █          █
    █           █                                                                              █ ┼       █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoCharge2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █          █                                                                                         █
    █          █  █                                                                                      █
    █          █ ██                                                                                      █
    █          ████                                                                        ░░            █
    █          ████                                                                        ░░░           █
    █           ███                                                                      ░ ░░░░          █
    █           ███                                                                       ░░░░░░         █
    █           ███                                                                        ░░░░░         █
    █           █ █                                                                       ░░░░░          █
    █           █ █                                                                       ░   ░          █
    █           █                                                                              ░         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoCharge3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █          █                                                                                         █
    █          █  █                                                                                      █
    █          █ ██                                                                                      █
    █          ████                                                                        ██            █
    █          ████                                                                        ███           █
    █           ███                                                                      █ ████          █
    █           ███                                                                       ██████         █
    █           ███                                                                        █████         █
    █           █ █                                                                       █████          █
    █           █ █                                                                       █   █          █
    █           █                                                                              █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void chargeNMirror()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████               █ ███                          █
    █         ┼    ┼                                                      █  ███                         █
    █                  ┼                                                  █   ███          ██            █
    █                                                                     █    ███         ███           █
    █    ┼   ┼   ██                                                       █     ██      ███████          █
    █           ███      ┼                                                █     ██         ████          █
    █          ████ █                                                     █     ██        █████          █
    █   ┼     ██████                                                      █     ██         ████          █
    █         ████        ┼                                               ██    ██         ████          █
    █     ┼   █████                                                        ██   ██         █ ██          █
    █         █   █   ┼                                                     ██  ██           ██          █
    █        █                                                               ██ ██            █          █
    █                                                                         ████                       █
    █                                                                          ███                       █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void mirrorNCharge()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████                                  ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ███ ████            ████████                                              █
    █                         ███  █                                                      ┼    ┼         █
    █            ██          ███   █                                                  ┼                  █
    █           ███         ███    █                                                                     █
    █          ███████      ██     █                                                       ██   ┼   ┼    █
    █          ████         ██     █                                                ┼      ███           █
    █          █████        ██     █                                                     █ ████          █
    █          ████         ██     █                                                      ██████     ┼   █
    █          ████         ██    ██                                               ┼        ████         █
    █          ██ █         ██   ██                                                        █████   ┼     █
    █          ██           ██  ██                                                     ┼   █   █         █
    █          █            ██ ██                                                               █        █
    █                       ████                                                                         █
    █                       ███                                                                          █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void chargeNMirror1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████               █ ███                          █
    █                                                                     █  ███                         █
    █                                                                     █   ███          ██            █
    █         ┼   ┼                                                       █    ███         ███           █
    █            ██ ┼                                                     █     ██      ███████          █
    █       ┼ ┼ ███                                                       █     ██         ████          █
    █          ████ █ ┼                                                   █     ██        █████          █
    █       ┼ ██████                                                      █     ██         ████          █
    █        ┼████    ┼                                                   ██    ██         ████          █
    █         █████ ┼                                                      ██   ██         █ ██          █
    █         █   █                                                         ██  ██           ██          █
    █        █                                                               ██ ██            █          █
    █                                                                         ████                       █
    █                                                                          ███                       █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void mirrorNCharge1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████                                  ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ███ ████            ████████                                              █
    █                         ███  █                                                                     █
    █            ██          ███   █                                                                     █
    █           ███         ███    █                                                       ┼   ┼         █
    █          ███████      ██     █                                                     ┼ ██            █
    █          ████         ██     █                                                       ███ ┼ ┼       █
    █          █████        ██     █                                                   ┼ █ ████          █
    █          ████         ██     █                                                      ██████ ┼       █
    █          ████         ██    ██                                                   ┼    ████┼        █
    █          ██ █         ██   ██                                                      ┼ █████         █
    █          ██           ██  ██                                                         █   █         █
    █          █            ██ ██                                                               █        █
    █                       ████                                                                         █
    █                       ███                                                                          █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void chargeNMirror2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████               █ ███                          █
    █                                                                     █  ███                         █
    █                                                                     █   ███          ██            █
    █                                                                     █    ███         ███           █
    █            ░░                                                       █     ██      ███████          █
    █           ░░░                                                       █     ██         ████          █
    █          ░░░░ ░                                                     █     ██        █████          █
    █         ░░░░░░                                                      █     ██         ████          █
    █         ░░░░                                                        ██    ██         ████          █
    █         ░░░░                                                         ██   ██         █ ██          █
    █         ░   ░                                                         ██  ██           ██          █
    █        ░                                                               ██ ██            █          █
    █                                                                         ████                       █
    █                                                                          ███                       █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void mirrorNCharge2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████                                  ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ███ ████            ████████                                              █
    █                         ███  █                                                                     █
    █            ██          ███   █                                                                     █
    █           ███         ███    █                                                                     █
    █          ███████      ██     █                                                       ░░            █
    █          ████         ██     █                                                       ░░░           █
    █          █████        ██     █                                                     ░ ░░░░          █
    █          ████         ██     █                                                      ░░░░░░         █
    █          ████         ██    ██                                                        ░░░░         █
    █          ██ █         ██   ██                                                         ░░░░         █
    █          ██           ██  ██                                                         ░   ░         █
    █          █            ██ ██                                                               ░        █
    █                       ████                                                                         █
    █                       ███                                                                          █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void mirrorNCharge3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████                                  ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ███ ████            ████████                                              █
    █                         ███  █                                                                     █
    █            ██          ███   █                                                                     █
    █           ███         ███    █                                                                     █
    █          ███████      ██     █                                                       ██            █
    █          ████         ██     █                                                       ███           █
    █          █████        ██     █                                                     █ ████          █
    █          ████         ██     █                                                      ██████         █
    █          ████         ██    ██                                                        ████         █
    █          ██ █         ██   ██                                                        █████         █
    █          ██           ██  ██                                                         █   █         █
    █          █            ██ ██                                                               █        █
    █                       ████                                                                         █
    █                       ███                                                                          █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerOneCharge()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █         ┼    ┼                                                                          █          █
    █                  ┼                                                                   █  █          █
    █                                                                                      ██ █          █
    █    ┼   ┼   ██                                                                        ████          █
    █           ███      ┼                                                                 ████          █
    █          ████ █                                                                      ███           █
    █   ┼     ██████                                                                       ███           █
    █         ████        ┼                                                                ███           █
    █     ┼   █████                                                                        █ █           █
    █         █   █   ┼                                                                    █ █           █
    █        █                                                                               █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneCharge1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                         █          █
    █                                                                                      █  █          █
    █         ┼   ┼                                                                        ██ █          █
    █            ██ ┼                                                                      ████          █
    █       ┼ ┼ ███                                                                        ████          █
    █          ████ █ ┼                                                                    ███           █
    █       ┼ ██████                                                                       ███           █
    █        ┼████    ┼                                                                    ███           █
    █         █████ ┼                                                                      █ █           █
    █         █   █                                                                        █ █           █
    █        █                                                                               █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneCharge2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                         █          █
    █                                                                                      █  █          █
    █                                                                                      ██ █          █
    █            ░░                                                                        ████          █
    █           ░░░                                                                        ████          █
    █          ░░░░ ░                                                                      ███           █
    █         ░░░░░░                                                                       ███           █
    █         ░░░░                                                                         ███           █
    █         ░░░░░                                                                        █ █           █
    █         ░   ░                                                                        █ █           █
    █        ░                                                                               █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void chargeNMirror3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████               █ ███                          █
    █                                                                     █  ███                         █
    █                                                                     █   ███          ██            █
    █                                                                     █    ███         ███           █
    █            ██                                                       █     ██      ███████          █
    █           ███                                                       █     ██         ████          █
    █          ████ █                                                     █     ██        █████          █
    █         ██████                                                      █     ██         ████          █
    █         ████                                                        ██    ██         ████          █
    █         █████                                                        ██   ██         █ ██          █
    █         █   █                                                         ██  ██           ██          █
    █        █                                                               ██ ██            █          █
    █                                                                         ████                       █
    █                                                                          ███                       █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerOneCharge3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                         █          █
    █                                                                                      █  █          █
    █                                                                                      ██ █          █
    █            ██                                                                        ████          █
    █           ███                                                                        ████          █
    █          ████ █                                                                      ███           █
    █         ██████                                                                       ███           █
    █         ████                                                                         ███           █
    █         █████                                                                        █ █           █
    █         █   █                                                                        █ █           █
    █        █                                                                               █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void bothSurrender()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █          █                                                                              █          █
    █          █  █                                                                        █  █          █
    █          █ ██                                                                        ██ █          █
    █          ████                                                                        ████          █
    █          ████                                                                        ████          █
    █           ███                                                                        ███           █
    █           ███                                                                        ███           █
    █           ███                                                                        ███           █
    █           █ █                                                                        █ █           █
    █           █ █                                                                        █ █           █
    █           █                                                                            █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void bothGun()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                                                        ██            █
    █           ███  ▄▄▄▄▄                                                          ▄▄▄▄▄  ███           █
    █          ███████                                                                  ███████          █
    █         █ ███                                                                        ███ █         █
    █         █ ███                                                                        ███ █         █
    █           █████                                                                    █████           █
    █          ██    █                                                                  █    ██          █
    █         █                                                                                █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneGun()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                         █          █
    █                                                                                      █  █          █
    █                                                                                      ██ █          █
    █            ██                                                                        ████          █
    █           ███  ▄▄▄▄▄                                                                 ████          █
    █          ███████                                                                     ███           █
    █         █ ███                                                                        ███           █
    █         █ ███                                                                        ███           █
    █           █████                                                                      █ █           █
    █          ██    █                                                                     █ █           █
    █         █                                                                              █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoGun()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █          █                                                                                         █
    █          █  █                                                                                      █
    █          █ ██                                                                                      █
    █          ████                                                                        ██            █
    █          ████                                                                 ▄▄▄▄▄  ███           █
    █           ███                                                                     ███████          █
    █           ███                                                                        ███ █         █
    █           ███                                                                        ███ █         █
    █           █ █                                                                      █████           █
    █           █ █                                                                     █    ██          █
    █           █                                                                              █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoKillsWGun()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                ▒▒                  █
    █     ▒   ▒  ███                                                                ▒▒                   █
    █           ███    ▒                                       ────────            ▒       ██            █
    █──────────██████  ────────────────────────     ─────────             ─────     ▄▄▄▄▄  ███           █
    █          ███ ▒▒█  ▒                                           ──────              ███████          █
    █     ▒  ▒▒ ███   ▒                                                                    ███ █         █
    █       ▒   ████ ▒  ▒                                                                  ███ █         █
    █         ▒ ██  █                                                                    █████           █
    █            ██  █                                                                  █    ██          █
    █              █                                                                           █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneKillsWGun()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                  ▒▒                                                                                █
    █                   ▒▒                                                             ▒  ███            █
    █            ██       ▒         ───────────                                      ▒     ███ ▒▒▒       █
    █           ███  ▄▄▄▄▄   ──────────               ──────────────────────────────   ─███████────▒───  █
    █          ███████                       ────                                      █    ███          █
    █         █ ███                                                                     ▒▒ ███ ▒▒    ▒   █
    █         █ ███                                                                    ▒▒ ████   ▒       █
    █           █████                                                                ▒   █  ██      ▒    █
    █          ██    █                                                                  █  ██   ▒        █
    █         █                                                                           █              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneKame()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                        █           █
    █                                                                                     █  █           █
    █                                                                                     ██ █           █
    █            ██                                                                       ████           █
    █          ████                                                                       ████           █
    █         █ ███                                                                       ███            █
    █           ███                                                                       ███            █
    █         █████                                                                       ███            █
    █           █████                                                                     █ █            █
    █          ██    █                                                                    █ █            █
    █         █                                                                             █            █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoKame()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █           █                                                                                        █
    █           █  █                                                                                     █
    █           █ ██                                                                                     █
    █           ████                                                                       ██            █
    █           ████                                                                       ████          █
    █            ███                                                                       ███ █         █
    █            ███                                                                       ███           █
    █            ███                                                                       █████         █
    █            █ █                                                                     █████           █
    █            █ █                                                                    █    ██          █
    █            █                                                                             █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneKame1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                        █           █
    █                                                                                     █  █           █
    █  ░      ░                                                                           ██ █           █
    █     ░  ░   ██                                                                       ████           █
    █      ░   ████                                                                       ████           █
    █  ░      █ ███                                                                       ███            █
    █      ░    ███                                                                       ███            █
    █         █████                                                                       ███            █
    █ ░   ░     █████                                                                     █ █            █
    █    ░  ░  ██    █                                                                    █ █            █
    █      ░  █                                                                             █            █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void bothKame()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                                                        ██            █
    █          ████                                                                        ████          █
    █         █ ███                                                                        ███ █         █
    █           ███                                                                        ███           █
    █         █████                                                                        █████         █
    █           █████                                                                    █████           █
    █          ██    █                                                                  █    ██          █
    █         █                                                                                █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void bothKame1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                             ░      █
    █  ░      ░                                                                                       ░  █
    █     ░  ░   ██                                                                        ██   ░  ░     █
    █      ░   ████                                                                        ████   ░      █
    █  ░      █ ███                                                                        ███ █      ░  █
    █      ░    ███                                                                        ███    ░      █
    █         █████                                                                        █████         █
    █ ░   ░     █████                                                                    █████     ░   ░ █
    █    ░  ░  ██    █                                                                  █    ██  ░  ░    █
    █      ░  █                                                                                █  ░      █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█


");
    }
    static void bothKame2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █        ░   ██                                                                        ██   ░ ░      █
    █     ░    ████                                                                        ████    ░     █
    █    ░  ░ █ ███                                                                        ███ █ ░  ░    █
    █     ░  ░  ███                                                                        ███  ░  ░     █
    █       ░ █████                                                                        █████ ░       █
    █    ░ ░ ░  █████                                                                    █████  ░   ░    █
    █          ██    █                                                                  █    ██   ░      █
    █         █                                                                                █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void bothKame3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █   ░        ██ ░                                                                    ░ ██        ░   █
    █      ░░  ████░                                                                      ░████  ░░      █
    █       ░ █░███                                                                        ███░█ ░       █
    █         ▒ ███                                                                        ███ ▒         █
    █         █████                                                                        █████         █
    █        ░  █████                                                                    █████  ░        █
    █       ░  ██  ░ █                                                                  █ ░  ██  ░       █
    █     ░   █                                                                                █   ░     █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void bothKame4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████     ░     ░  ░░░▒░▒                                              █
    █                                        ░▒░░░░░░▒░▒░░░ ░    ░                                       █
    █                         ░              ░ ░▒▒▒▒░░░░▒▒▒▒▒░ ░              ░                          █
    █        ██          ░          ░       ░   ░░▒▒▒░░▒▒▒▒░░░▒   ░                ░          ██         █
    █        ███                  ░            ░▒░▒▒▒▒▒▒▒▒▒░              ░                  ███         █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███          █
    █         ██████ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ██████          █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███          █
    █         ███                              ▒░▒▒▒▒▒▒▒▒▒▒▒ ░                              ███          █
    █         █████           ░    ░           ░░░▒▒▒▒▒░▒▒▒▒░  ░ ▒       ░    ░           █████          █
    █         ██   █               ░  ░        ▒░▒▒░░░▒ ░░▒▒  ░                          █   ██          █
    █        █                              ░░   ░░  ░░░░  ░                                   █         █
    █                                         ░    ░░  ▒ ░ ░ ░                                           █
    █                                                   ░ ▒                                              █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█


");
    }
    static void playerTwoKame1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █           █                                                                                        █
    █           █  █                                                                                     █
    █           █ ██                                                                           ░      ░  █
    █           ████                                                                       ██   ░  ░     █
    █           ████                                                                       ████   ░      █
    █            ███                                                                       ███ █      ░  █
    █            ███                                                                       ███    ░      █
    █            ███                                                                       █████         █
    █            █ █                                                                     █████     ░   ░ █
    █            █ █                                                                    █    ██  ░  ░    █
    █            █                                                                             █  ░      █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneKame2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                        █           █
    █                                                                                     █  █           █
    █                                                                                     ██ █           █
    █        ░   ██                                                                       ████           █
    █     ░    ████                                                                       ████           █
    █    ░  ░ █ ███                                                                       ███            █
    █     ░  ░  ███                                                                       ███            █
    █       ░ █████                                                                       ███            █
    █    ░   ░  █████                                                                     █ █            █
    █      ░   ██    █                                                                    █ █            █
    █         █                                                                             █            █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoKame2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █           █                                                                                        █
    █           █  █                                                                                     █
    █           █ ██                                                                                     █
    █           ████                                                                       ██   ░        █
    █           ████                                                                       ████    ░     █
    █            ███                                                                       ███ █ ░  ░    █
    █            ███                                                                       ███  ░  ░     █
    █            ███                                                                       █████ ░       █
    █            █ █                                                                     █████  ░   ░    █
    █            █ █                                                                    █    ██   ░      █
    █            █                                                                             █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneKame3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                        █           █
    █                                                                                     █  █           █
    █                                                                                     ██ █           █
    █   ░        ██ ░                                                                     ████           █
    █      ░░  ████░                                                                      ████           █
    █       ░ █░███                                                                       ███            █
    █         ▒ ███                                                                       ███            █
    █         █████                                                                       ███            █
    █        ░  █████                                                                     █ █            █
    █       ░  ██  ░ █                                                                    █ █            █
    █     ░   █                                                                             █            █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoKame3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █           █                                                                                        █ 
    █           █  █                                                                                     █ 
    █           █ ██                                                                                     █ 
    █           ████                                                                     ░ ██        ░   █ 
    █           ████                                                                      ░████  ░░      █ 
    █            ███                                                                       ███░█ ░       █ 
    █            ███                                                                       ███ ▒         █ 
    █            ███                                                                       █████         █ 
    █            █ █                                                                     █████  ░        █ 
    █            █ █                                                                    █ ░  ██  ░       █ 
    █            █                                                                             █   ░     █ 
    █                                                                                                    █ 
    █                                                                                                    █ 
    █                                                                                                    █ 
    █                                                                                                    █ 
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ ");
    }
    static void playerOneKame4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                        █           █
    █                         ░                              ░░░                          █  █           █
    █        ██          ░                ░    ░     ▒  ░   ░▒▒▒▒▒                        ██ █           █
    █        ███                  ░                      ▒ ░▒░░░▒▒▒                       ████           █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░▒▒▒▒▒▒▒▒▒                      ████           █
    █         ██████ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                     ███            █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░▒░░░▒▒▒▒                      ███            █
    █         ███                                      ▒       ▒▒▒                        ███            █
    █         █████           ░    ░                      ▒  ▒▒░░                         █ █            █
    █         ██   █                          ░  ░                                        █ █            █
    █        █                                                                              █            █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerTwoKame4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █           █                                                                                        █ 
    █           █  █                          ░░░                              ░                         █ 
    █           █ ██                        ▒▒▒▒▒░   ░  ▒     ░    ░                ░          ██        █ 
    █           ████                       ▒▒▒░░░▒░ ▒                      ░                  ███        █ 
    █           ████                      ▒▒▒▒▒▒▒▒▒░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███         █
    █            ███                     ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ██████         █ 
    █            ███                      ▒▒▒▒░░░▒░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███         █
    █            ███                        ▒▒▒       ▒                                      ███         █
    █            █ █                         ░░▒▒  ▒                      ░    ░           █████         █
    █            █ █                                        ░  ░                          █   ██         █
    █            █                                                                              █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneKame5()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █               ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒█
    █                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒░▒▒▒▒▒▒▒▒▒▒▒█
    █        ██      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒░▒▒▒▒▒▒▒▒▒▒▒█
    █        ███     ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ██████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         █████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ██   █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒█
    █        █      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒█
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void playerTwoKame5()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒               █
    █▒▒▒▒▒▒▒▒▒▒▒░▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                █
    █▒▒▒▒▒▒▒▒▒▒▒░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ██        █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     ███        █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██████         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ███         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █████         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █   ██         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void kameNGun()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                            ────────                    ██            █
    █          ████       ─────────────────────     ─────────             ─────     ▄▄▄▄▄  ███           █
    █         █ ███                                                 ──────              ███████          █
    █           ███                                                                        ███ █         █
    █         █████                                                                        ███ █         █
    █           █████                                                                    █████           █
    █          ██    █                                                                  █    ██          █
    █         █                                                                                █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void gunNKame()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                    ────────                                            ██            █
    █           ███  ▄▄▄▄▄     ─────             ─────────     ─────────────────────       ████          █
    █          ███████              ──────                                                 ███ █         █
    █         █ ███                                                                        ███           █
    █         █ ███                                                                        █████         █
    █           █████                                                                    █████           █
    █          ██    █                                                                  █    ██          █
    █         █                                                                                █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void kameNGun1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                ▒▒                  █
    █  ░      ░                                                                     ▒▒                   █
    █     ░  ░   ██                                                                ▒       ██            █
    █      ░   ████                                                                 ▄▄▄▄▄  ███           █
    █  ░      █ ███                                                                     ███████          █
    █      ░    ███                                                                        ███ █         █
    █         █████                                                                        ███ █         █
    █ ░   ░     █████                                                                    █████           █
    █    ░  ░  ██    █                                                                  █    ██          █
    █      ░  █                                                                                █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void gunNKame1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                  ▒▒                                                                                █
    █                   ▒▒                                                                     ░      ░  █
    █            ██       ▒                                                                ██   ░  ░     █
    █           ███  ▄▄▄▄▄                                                                 ████   ░      █
    █          ███████                                                                     ███ █      ░  █
    █         █ ███                                                                        ███    ░      █
    █         █ ███                                                                        █████         █
    █           █████                                                                    █████     ░   ░ █
    █          ██    █                                                                  █    ██  ░  ░    █
    █         █                                                                                █  ░      █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void gunNKame2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                                                        ██   ░        █
    █           ███  ▄▄▄▄▄                                                                 ████    ░     █
    █          ███████                                                                     ███ █ ░  ░    █
    █         █ ███                                                                        ███  ░  ░     █
    █         █ ███                                                                        █████ ░       █
    █           █████                                                                    █████  ░ ░ ░    █
    █          ██    █                                                                  █    ██          █
    █         █                                                                                █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void kameNGun2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █        ░   ██                                                                        ██            █
    █     ░    ████                                                                 ▄▄▄▄▄  ███           █
    █    ░  ░ █ ███                                                                     ███████          █
    █     ░  ░  ███                                                                        ███ █         █
    █       ░ █████                                                                        ███ █         █
    █    ░ ░ ░  █████                                                                    █████           █
    █          ██    █                                                                  █    ██          █
    █         █                                                                                █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█


");
    }
    static void kameNGun3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █   ░        ██ ░                                                                      ██            █
    █      ░░  ████░                                                                ▄▄▄▄▄  ███           █
    █       ░ █░███                                                                     ███████          █
    █         ▒ ███                                                                        ███ █         █
    █         █████                                                                        ███ █         █
    █        ░  █████                                                                    █████           █
    █       ░  ██  ░ █                                                                  █    ██          █
    █     ░   █                                                                                █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█



");
    }
    static void gunNKame3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                                                      ░ ██        ░   █
    █           ███  ▄▄▄▄▄                                                                ░████  ░░      █
    █          ███████                                                                     ███░█ ░       █
    █         █ ███                                                                        ███ ▒         █
    █         █ ███                                                                        █████         █
    █           █████                                                                    █████  ░        █
    █          ██    █                                                                  █ ░  ██  ░       █
    █         █                                                                                █   ░     █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void kameNGun4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                         ░                              ░░░                                         █
    █        ██          ░                ░    ░     ▒  ░   ░▒▒▒▒▒                                       █
    █        ███                  ░                      ▒ ░▒░░░▒▒▒                        ██            █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░▒▒▒▒▒▒▒▒▒                ▄▄▄▄▄  ███           █
    █         ██████ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                   ███████          █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░▒░░░▒▒▒▒                       ███ █         █
    █         ███                                      ▒       ▒▒▒                         ███ █         █
    █         █████           ░    ░                      ▒  ▒▒░░                        █████           █
    █         ██   █                          ░  ░                                      █    ██          █
    █        █                                                                                 █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void gunNKame4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                         ░░░                              ░                         █
    █                                       ▒▒▒▒▒░   ░  ▒     ░    ░                ░          ██        █
    █            ██                        ▒▒▒░░░▒░ ▒                      ░                  ███        █
    █           ███  ▄▄▄▄▄                ▒▒▒▒▒▒▒▒▒░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███         █
    █          ███████                   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ██████         █
    █         █ ███                       ▒▒▒▒░░░▒░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███         █
    █         █ ███                          ░░▒▒  ▒                      ░    ░           █████         █
    █           █████                                       ░  ░                          █   ██         █
    █          ██     █                                                                         █        █
    █         █                                                                                          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void kameNGun5()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █               ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █        ██      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █        ███     ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ██████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒░▒▒▒▒▒▒▒▒▒█
    █         ███    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒░▒▒▒▒▒▒▒▒▒█
    █         █████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ██   █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒█
    █        █      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒█
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void gunNKame5()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒               █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ██        █
    █▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     ███        █
    █▒▒▒▒▒▒▒▒▒▒▒░░░▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██████         █
    █▒▒▒▒▒▒▒▒▒░▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒░▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ███         █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █████         █
    █▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █   ██         █
    █▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneKame6()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █               ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █        ██      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █        ███     ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ██████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒░▒▒▒▒▒▒▒▒▒▒█
    █         █████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ██   █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▒▒▒▒▒▒▒█
    █        █      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░░░░▒▒▒▒▒▒▒▒▒▒█
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█


");
    }
    static void playerTwoKame6()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒               █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                █
    █▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ██        █
    █▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     ███        █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██████         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ███         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █████         █
    █▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █   ██         █
    █▒▒▒▒▒▒▒▒▒▒░░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█


");
    }
    static void playerOneKame7()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █        ██                                                                                          █
    █        ███     ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ██████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒░▒▒▒▒▒▒▒▒▒▒█
    █         █████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ██   █                                                                      ░ ░ ░          █
    █        █                                                                         ░░░░░░░░░         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█


");
    }
    static void playerTwoKame7()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                          ██        █
    █▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     ███        █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██████         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ███         █
    █▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █████         █
    █          ░ ░ ░                                                                      █   ██         █
    █         ░░░░░░░░░                                                                         █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneKame8()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █        ██                                                                                          █
    █        ███                                                                                         █
    █         ███  █                                                                                     █
    █         ██████                                                                                     █
    █         ███  █                                                                                     █
    █         ███                                                                                        █
    █         █████                                                                         ░░           █
    █         ██   █                                                                     ░░░░░░          █
    █        █                                                                         ░░░░░░░░░░░       █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void playerTwoKame8()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                          ██        █
    █                                                                                         ███        █
    █                                                                                     █  ███         █
    █                                                                                     ██████         █
    █                                                                                     █  ███         █
    █                                                                                        ███         █
    █           ░░                                                                         █████         █ 
    █          ░░░░░░                                                                     █   ██         █
    █       ░░░░░░░░░░░                                                                         █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void kameCharge()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █            ██                                                                                      █
    █          ████                                                                       ███            █
    █         █ ███                                                                     █ ████           █
    █           ███                                                                      ██████          █
    █         █████                                                                       █████          █
    █           █████                                                                    █████           █
    █          ██    █                                                                   █   █           █
    █         █                                                                               █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void chargeKame()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █ 
    █                                                                                                    █ 
    █                                                                                                    █ 
    █                                                                                      ██            █ 
    █            ███                                                                       ████          █ 
    █           ████ █                                                                     ███ █         █ 
    █          ██████                                                                      ███           █ 
    █          █████                                                                       █████         █ 
    █           █████                                                                    █████           █ 
    █           █   █                                                                   █    ██          █ 
    █          █                                                                               █         █ 
    █                                                                                                    █ 
    █                                                                                                    █ 
    █                                                                                                    █ 
    █                                                                                                    █ 
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ ");
    }
    static void kameCharge1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                ┼    ┼              █
    █                                                                                         ┼          █
    █  ░      ░                                                                  ┼                       █
    █     ░  ░   ██                                                                               ┼      █
    █      ░   ████                                                                       ███            █
    █  ░      █ ███                                                               ┼     █ ████           █
    █      ░    ███                                                                      ██████          █
    █         █████                                                                       █████          █
    █ ░   ░     █████                                                                 ┼  █████      ┼    █
    █    ░  ░  ██    █                                                           ┼       █   █           █
    █      ░  █                                                                               █          █
    █                                                                                               ┼    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void chargeKame1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █              ┼    ┼                                                                                █
    █          ┼                                                                                         █
    █                       ┼                                                                  ░      ░  █
    █      ┼                                                                               ██   ░  ░     █
    █            ███                                                                       ████   ░      █
    █           ████ █     ┼                                                               ███ █      ░  █
    █          ██████                                                                      ███    ░      █
    █          █████                                                                       █████         █
    █    ┼      █████  ┼                                                                 █████     ░   ░ █
    █           █   █       ┼                                                           █    ██  ░  ░    █
    █          █                                                                               █  ░      █
    █    ┼                                                                                               █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void kameCharge2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                  ┼   ┼             █
    █        ░   ██                                                                           ┼          █
    █     ░    ████                                                                     ┼ ███    ┼       █
    █    ░  ░ █ ███                                                                     █ ████           █
    █     ░  ░  ███                                                                   ┼  ██████ ┼        █
    █       ░ █████                                                                       █████          █
    █    ░ ░ ░  █████                                                                 ┼  █████    ┼      █
    █          ██    █                                                                   █   █           █
    █         █                                                                               █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void chargeKame2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █             ┼   ┼                                                                                  █
    █          ┼                                                                           ██   ░        █
    █       ┼    ███ ┼                                                                     ████    ░     █
    █           ████ █                                                                     ███ █ ░  ░    █
    █        ┼ ██████  ┼                                                                   ███  ░  ░     █
    █          █████                                                                       █████ ░       █
    █      ┼    █████  ┼                                                                 █████  ░ ░ ░    █
    █           █   █                                                                   █    ██          █
    █          █                                                                               █         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void kameCharge3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █   ░        ██ ░                                                                                    █
    █      ░░  ████░                                                                      ▒▒▒            █
    █       ░ █░███                                                                     ▒ ▒▒▒▒           █
    █         ▒ ███                                                                      ▒▒▒▒▒▒          █
    █         █████                                                                       ▒▒▒▒▒          █
    █        ░  █████                                                                    ▒▒▒▒▒           █
    █       ░  ██  ░ █                                                                   ▒   ▒           █
    █     ░   █                                                                               ▒          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void chargeKame3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                    ░ ██        ░   █
    █            ▒▒▒                                                                      ░████  ░░      █
    █           ▒▒▒▒ ▒                                                                     ███░█ ░       █
    █          ▒▒▒▒▒▒                                                                      ███ ▒         █
    █          ▒▒▒▒▒                                                                       █████         █
    █           ▒▒▒▒▒                                                                    █████  ░        █
    █           ▒   ▒                                                                   █ ░  ██  ░       █
    █          ▒                                                                               █   ░     █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void kameCharge4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                         ░                              ░░░                                         █
    █        ██          ░                ░    ░     ▒  ░   ░▒▒▒▒▒                                       █
    █        ███                  ░                      ▒ ░▒░░░▒▒▒                                      █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░▒▒▒▒▒▒▒▒▒                      ███            █
    █         ██████ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                   █ ████           █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░▒░░░▒▒▒▒                     ██████          █
    █         ███                                      ▒       ▒▒▒                        █████          █
    █         █████           ░    ░                      ▒  ▒▒░░                        █████           █
    █         ██   █                          ░  ░                                       █   █           █
    █        █                                                                                █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void chargeKame4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                         ░░░                              ░                         █
    █                                       ▒▒▒▒▒░   ░  ▒     ░    ░                ░          ██        █
    █                                      ▒▒▒░░░▒░ ▒                      ░                  ███        █
    █            ███                      ▒▒▒▒▒▒▒▒▒░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███         █
    █           ████ █                   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ██████         █
    █          ██████                     ▒▒▒▒░░░▒░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███         █
    █          █████                        ▒▒▒       ▒                                      ███         █
    █           █████                        ░░▒▒  ▒                      ░    ░           █████         █
    █           █   █                                       ░  ░                          █   ██         █
    █          █                                                                                █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void kameCharge5()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █               ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █        ██      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █        ███     ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ██████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒█
    █         ███    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒█
    █         █████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ██   █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒░▒▒▒▒▒▒▒▒▒▒▒█
    █        █      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒█
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void chargeKame5()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒               █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ██        █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     ███        █
    █▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██████         █
    █▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ███         █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █████         █
    █▒▒▒▒▒▒▒▒▒▒▒░▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █   ██         █
    █▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void kameCharge6()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █               ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █        ██      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █        ███     ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ██████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ███    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒█
    █         █████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░▒▒▒▒▒▒▒▒▒▒█
    █         ██   █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒░░░▒▒▒▒▒▒▒▒▒▒█
    █        █      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒▒▒▒▒▒▒▒▒▒█
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void chargeKame6()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒               █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ██        █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     ███        █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██████         █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ███         █
    █▒▒▒▒▒▒▒▒▒▒░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █████         █
    █▒▒▒▒▒▒▒▒▒▒░░░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █   ██         █
    █▒▒▒▒▒▒▒▒▒▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void kameCharge7()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █        ██      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █        ███     ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ██████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █         ███  █  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒█
    █         ███    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒█
    █         █████  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒█
    █         ██   █                                                                      ░ ░░░          █
    █        █                                                                         ░░░░ ░ ░          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void chargeKame7()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ██        █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     ███        █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██████         █
    █▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █  ███         █
    █▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ███         █
    █▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █████         █
    █          ░░░ ░                                                                      █   ██         █
    █          ░ ░ ░░░░                                                                         █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void kameCharge8()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █        ██                                                                                          █
    █        ███                                                                                         █
    █         ███  █                                                                                     █
    █         ██████                                                                                     █
    █         ███  █                                                                                     █
    █         ███                                                                                        █
    █         █████                                                                         ░░           █
    █         ██   █                                                                     ░░░░░░          █
    █        █                                                                         ░░░░░░░░░░░       █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void chargeKame8()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                          ██        █
    █                                                                                         ███        █
    █                                                                                     █  ███         █
    █                                                                                     ██████         █
    █                                                                                     █  ███         █
    █                                                                                        ███         █
    █           ░░                                                                         █████         █
    █          ░░░░░░                                                                     █   ██         █
    █       ░░░░░░░░░░░                                                                         █        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void kameNMirror()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████          ████                    ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████              █ ███                           █
    █                                                                    █  ███                          █
    █                         ░                              ░░░         █   ███          ██             █
    █        ██          ░                ░    ░     ▒  ░   ░▒▒▒▒▒       █    ███         ███            █
    █        ███                  ░                      ▒ ░▒░░░▒▒▒      █     ██      ███████           █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░▒▒▒▒▒▒▒▒▒     █     ██         ████           █
    █         ██████ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    █     ██        █████           █
    █         ███  █ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░▒░░░▒▒▒▒     █     ██         ████           █
    █         ███                                      ▒       ▒▒▒       ██    ██         ████           █
    █         █████           ░    ░                      ▒  ▒▒░░         ██   ██         █ ██           █
    █         ██   █                          ░  ░                         ██  ██           ██           █
    █        █                                                              ██ ██            █           █
    █                                                                        ████                        █
    █                                                                         ███                        █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void mirrorNKame()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████                                  ▒▒▒▒▒▒▒ █
    █ ▒▒▒                       ███ ███            ████████                                              █
    █                          ███  █                                                                    █
    █             ██          ███   █         ░░░                              ░                         █
    █            ███         ███    █       ▒▒▒▒▒░   ░  ▒     ░    ░                ░          ██        █
    █           ███████      ██     █      ▒▒▒░░░▒░ ▒                      ░                  ███        █
    █           ████         ██     █     ▒▒▒▒▒▒▒▒▒░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███         █
    █           █████        ██     █    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ██████         █
    █           ████         ██     █     ▒▒▒▒░░░▒░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ █  ███         █
    █           ████         ██    ██       ▒▒▒       ▒                                      ███         █
    █           ██ █         ██   ██         ░░▒▒  ▒                      ░    ░           █████         █
    █           ██           ██  ██                         ░  ░                          █   ██         █
    █           █            ██ ██                                                              █        █
    █                        ████                                                                        █
    █                        ███                                                                         █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void kameNMirror1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████          █████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████              █ ███                           █
    █                                                                    █  ███                          █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ███          ██             █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ███         ███            █
    █▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██      ███████           █
    █▒▒▒▒▒▒▒░▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██         ████           █
    █▒▒▒▒▒▒▒▒░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██        █████           █
    █▒▒▒▒▒▒▒▒▒░░░▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██         ████           █
    █▒▒▒▒▒▒▒░▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██         ████           █
    █▒▒▒▒▒▒▒▒▒░░░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██         █ ██           █
    █▒▒▒▒▒▒▒░▒░░▒░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ██           ██           █
    █        ░░░░░░░░                                                       ██ ██            █           █
    █                                                                         ███                        █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void mirrorNKame1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████                                  ▒▒▒▒▒▒▒ █
    █ ▒▒▒                       ███ ███            ████████                                              █
    █                          ███  █                                                                    █
    █             ██          ███ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █            ███         ███ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
    █           ███████      ██  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒█
    █           ████         ██  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒░▒▒▒▒▒▒▒█
    █           █████        ██  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░▒▒▒▒▒▒▒▒█
    █           ████         ██  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒░░░▒▒▒▒▒▒▒▒▒█
    █           ████         ██  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒░▒▒▒▒▒▒▒█
    █           ██ █         ██  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░░░░░▒▒▒▒▒▒▒▒▒█
    █           ██           ██  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░░▒░▒▒▒▒▒▒▒█
    █           █            ██ ██                                                       ░░░░░░░░        █
    █                        ███                                                                         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void kameNMirror2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████          ████                    ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████              █ ███                           █
    █                                                                    █  ███                          █
    █                                                                    █   ███          ██             █
    █                                                                    █    ███         ███            █
    █                                                                    █     ██      ███████           █
    █                                                                    █     ██         ████           █
    █                                                                    █     ██        █████           █
    █                                                                    █     ██         ████           █
    █                                                                    ██    ██         ████           █
    █                                                                     ██   ██         █ ██           █
    █             ░░░                                                      ██  ██           ██           █
    █          ░░░░░░░                                                      ██ ██            █           █
    █         ░░░░░░░░░░░░                                                   ████                        █
    █                                                                         ███                        █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void mirrorNKame2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████                                  ▒▒▒▒▒▒▒ █
    █ ▒▒▒                       ███ ███            ████████                                              █
    █                          ███  █                                                                    █
    █             ██          ███   █                                                                    █
    █            ███         ███    █                                                                    █
    █           ███████      ██     █                                                                    █
    █           ████         ██     █                                                                    █
    █           █████        ██     █                                                                    █
    █           ████         ██     █                                                                    █
    █           ████         ██    ██                                                                    █
    █           ██ █         ██   ██                                                                     █
    █           ██           ██  ██                                                      ░░░             █
    █           █            ██ ██                                                      ░░░░░░░          █
    █                        ████                                                   ░░░░░░░░░░░░         █
    █                        ███                                                                         █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void gunNMirror()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████               █ ███                          █
    █                                                                     █  ███                         █
    █                                                                     █   ███          ██            █
    █                                                                     █    ███         ███           █
    █            ██                 ───────────                           █     ██      ███████          █
    █           ███  ▄▄▄▄▄   ──────────               ────────────────────█     ██         ████          █
    █          ███████                       ────                         █     ██        █████          █
    █         █ ███                                                       █     ██         ████          █
    █         █ ███                                                       ██    ██         ████          █
    █           █████                                                      ██   ██         █ ██          █
    █          ██    █                                                      ██  ██           ██          █
    █         █                                                              ██ ██            █          █
    █                                                                         ████                       █
    █                                                                          ███                       █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void mirrorNGun()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████                                  ▒▒▒▒▒▒▒ █
    █ ▒▒▒                       ██ ████            ████████                                              █
    █                         ███  █                                                                     █
    █            ██          ███   █                                                                     █
    █           ███         ███    █                                                                     █
    █          ███████      ██     █                           ───────────                 ██            █
    █          ████         ██     █────────────────────               ──────────   ▄▄▄▄▄  ███           █
    █          █████        ██     █                         ────                       ███████          █
    █          ████         ██     █                                                       ███ █         █
    █          ████         ██    ██                                                       ███ █         █
    █          ██ █         ██   ██                                                      █████           █
    █          ██           ██  ██                                                      █    ██          █
    █          █            ██ ██                                                              █         █
    █                       ████                                                                         █
    █                       ███                                                                          █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void gunNMirror1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████               █ ███                          █
    █                                                                     █  ███                         █
    █                                                                     █   ███          ██            █
    █                                                                     █    ███         ███           █
    █     ▒   ▒  ███                                                      █     ██      ███████          █
    █           ███    ▒                                                  █     ██         ████          █
    █──────────██████  ────────────────────────     ─────────             █───  ██        █████          █
    █          ███ ▒▒█  ▒                                                 █     ██         ████          █
    █     ▒  ▒▒ ███   ▒                                                   ██    ██         ████          █
    █       ▒   ████ ▒  ▒                                                  ██   ██         █ ██          █
    █         ▒ ██  █                                                       ██  ██           ██          █
    █            ██  █                                                       ██ ██            █          █
    █              █                                                          ████                       █
    █                                                                          ███                       █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void mirrorNGun1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████                                  ▒▒▒▒▒▒▒ █
    █ ▒▒▒                       ██ ████            ████████                                              █
    █                         ███  █                                                                     █
    █            ██          ███   █                                                                     █
    █           ███         ███    █                                                                     █
    █          ███████      ██     █                                                      ███  ▒   ▒     █
    █          ████         ██     █                                                  ▒    ███           █
    █          █████        ██  ───█             ─────────     ────────────────────────  ██████──────────█
    █          ████         ██     █                                                 ▒  █▒▒ ███          █
    █          ████         ██    ██                                                   ▒   ███ ▒▒  ▒     █
    █          ██ █         ██   ██                                                  ▒  ▒ ████   ▒       █
    █          ██           ██  ██                                                       █  ██ ▒         █
    █          █            ██ ██                                                       █  ██            █
    █                       ████                                                          █              █
    █                       ███                                                                          █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void bothNuke()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █           ███                                  ....                                  ███           █
    █          ████                                                                        ████          █
    █         ██████                                                                      ██████         █
    █           ████                                                                      ████           █
    █           ████                                                                      ████           █
    █           ███                                                                        ███           █
    █           █ █                                                                        █ █           █
    █           █ █                                                                        █ █           █
    █           █                                                                            █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerOneNuke()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █           ███                                                                                      █
    █          ████                                                                        ██            █
    █         ██████                                                                       ███           █
    █           ████                                                                    █ █████          █
    █           ████                                                                     █████ █         █
    █           ███                                                                        ███ █         █
    █           █ █                                                                     ██████           █
    █           █ █                                                                     █    █           █
    █           █                                                                             █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoNuke()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                      ███           █
    █            ██                                                                        ████          █
    █           ███                                                                       ██████         █
    █          █████ █                                                                    ████           █
    █         █ █████                                                                     ████           █
    █         █ ███                                                                        ███           █
    █           ██████                                                                     █ █           █
    █           █    █                                                                     █ █           █
    █          █                                                                             █           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneNuke1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █           │││                                                                                      █
    █          ││││                                                                        ██            █
    █         ││││││                                                                       ███           █
    █           ││││                                                                    █ █████          █
    █           ││││                                                                     █████ █         █
    █           │││                                                                        ███ █         █
    █           │ │                                                                     ██████           █
    █           │ │                                                                     █    █           █
    █           │                                                                             █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoNuke1()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                      │││           █
    █            ██                                                                        ││││          █
    █           ███                                                                       ││││││         █
    █          █████ █                                                                    ││││           █
    █         █ █████                                                                     ││││           █
    █         █ ███                                                                        │││           █
    █           ██████                                                                     │ │           █
    █           █    █                                                                     │ │           █
    █          █                                                                             │           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneNuke2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██ █░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██ █  ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █           ░░░                                                                                      █
    █          ░░░░                                                                        ██            █
    █         ░░░░░░                                                                       ███           █
    █           ░░░░                                                                    █ █████          █
    █           ░░░░                                                                     █████ █         █
    █           ░░░                                                                        ███ █         █
    █           ░ ░                                                                     ██████           █
    █           ░ ░                                                                     █    █           █
    █           ░                                                                             █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoNuke2()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██ █░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██ █  ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                      ░░░           █
    █            ██                                                                        ░░░░          █
    █           ███                                                                       ░░░░░░         █
    █          █████ █                                                                    ░░░░           █
    █         █ █████                                                                     ░░░░           █
    █         █ ███                                                                        ░░░           █
    █           ██████                                                                     ░ ░           █
    █           █    █                                                                     ░ ░           █
    █          █                                                                             ░           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneNuke3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒█▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░█ ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒│             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒│ ││        █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒      │       ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                              █
    █           │ │                                                                                      █
    █        │  │ │                                                                        ?             █
    █        │    │                                                                      ?    ?          █
    █        │ │                                                                           ██            █
    █         │││ │                                                                        ███           █
    █         │ │ │                                                                     █ █████          █
    █         │ │ │                                                                      █████ █         █
    █           │                                                                          ███ █         █
    █             │                                                                     ██████           █
    █           │ │                                                                     █    █           █
    █           │                                                                             █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerTwoNuke3()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██ █░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██ █  ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████              │   │▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████                                 │            █
    █                                                                                      │ │           █
    █             ?                                                                        │ │  │        █
    █          ?    ?                                                                      │    │        █
    █            ██                                                                           │ │        █
    █           ███                                                                        │ │││         █
    █          █████ █                                                                     │ │ │         █
    █         █ █████                                                                      │ │ │         █
    █         █ ███                                                                          │           █
    █           ██████                                                                     │             █
    █           █    █                                                                     │ │           █
    █          █                                                                             │           █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerOneNuke4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒│             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒││││        █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒ │ ││ │       ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒    │   │             ████████            ████████                                ?             █
    █        │ ││ │                                                                     ?      ?         █
    █        │ ││ │                                                                        ?             █
    █         ││  │                                                                     ?     ?          █
    █         ││                                                                           ██            █
    █         │                                                                            ███           █
    █                                                                                   █ █████          █
    █                                                                                    █████ █         █
    █                                                                                      ███ █         █
    █                                                                                   ██████           █
    █                                                                                   █    █           █
    █                                                                                         █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void playerTwoNuke4()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒              ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████        │▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████               ││ │▒▒▒▒▒▒▒ █
    █ ▒▒▒         ?            ████████            ████████                                │ │  │        █
    █         ?      ?                                                                     │ ││ │        █
    █             ?                                                                        │ ││ │        █
    █          ?     ?                                                                     │  ││         █
    █            ██                                                                           ││         █
    █           ███                                                                            │         █
    █          █████ █                                                                                   █
    █         █ █████                                                                                    █
    █         █ ███                                                                                      █
    █           ██████                                                                                   █
    █           █    █                                                                                   █
    █          █                                                                                         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

");
    }
    static void playerOneNuke5()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀████████████████████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░█████▒▒▒████▒▒▒█████░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ███▒▒▒▒██████▒▒▒▒███  ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     ███▒▒▒███▒▒███▒▒▒███░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    ██▒▒▒██▒▒▒▒▒▒██▒▒▒██      ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  ██▒▒██▒▒▒▒▒▒▒▒██▒▒██        ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ░░ █ █   ██ █ ██  ██▒████▒▒▒▒▒▒████▒██   █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒              ███   ██ ████  █████████▒▒██████████ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████████████▒▒▒▒████████        ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████        █████▒▒▒▒▒▒▒▒█████                                        █
    █                                           ████████████████                                         █
    █                                              ██████████                             !!!!           █
    █                                                ██████                                              █
    █                                                                                      ██            █
    █                                                                                      ███           █
    █                                                                                   █ █████          █
    █                                                                                    █████ █         █
    █                                                                                      ███ █         █
    █                                                                                   ██████           █
    █                                                                                   █    █           █
    █                                                                                         █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerTwoNuke5()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀████████████████████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░█████▒▒▒████▒▒▒█████░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ███▒▒▒▒██████▒▒▒▒███  ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     ███▒▒▒███▒▒███▒▒▒███░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    ██▒▒▒██▒▒▒▒▒▒██▒▒▒██      ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  ██▒▒██▒▒▒▒▒▒▒▒██▒▒██        ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ░░ █ █   ██ █ ██  ██▒████▒▒▒▒▒▒████▒██   █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒              ███   ██ ████  █████████▒▒██████████ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████████████▒▒▒▒████████        ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████        █████▒▒▒▒▒▒▒▒█████                                        █
    █                                           ████████████████                                         █
    █           !!!!                               ██████████                                            █
    █                                                ██████                                              █
    █            ██                                                                                      █
    █           ███                                                                                      █
    █          █████ █                                                                                   █
    █         █ █████                                                                                    █
    █         █ ███                                                                                      █
    █           ██████                                                                                   █
    █           █    █                                                                                   █
    █          █                                                                                         █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneNuke6()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██████████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░░░░▒████████████░░░░░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░░▒  ██████████████  ░  ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒   ░░  ████████████████ ░░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒ ░░░ ██████████████████░      ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █░ ████████████████████        ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ░░ █ █   ██ █ ██  ████████████████████   █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒              ███   ██ ████  █████████████████████ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████▒▒▒████▒▒▒██████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ ████████▒▒▒▒██████▒▒▒▒███        ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████       ███▒▒▒███▒▒███▒▒▒███                                       █
    █                                         ██▒▒▒██▒▒▒▒▒▒██▒▒▒██                                       █
    █                                         ██▒▒██▒▒▒▒▒▒▒▒██▒▒██                    !!!!!!!!!!!!       █
    █                                         ██▒████▒▒▒▒▒▒████▒██                    !!!!!!!!!!!!       █
    █                                         █████████▒▒█████████                         ██            █
    █                                         ████████████████████                         ███           █
    █                                         ████████▒▒▒▒████████                      █ █████          █
    █                                          █████▒▒▒▒▒▒▒▒█████                        █████ █         █
    █                                           ████████████████                           ███ █         █
    █                                              ██████████                           ██████           █
    █                                                ██████                             █    █           █
    █                                                                                         █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerTwoNuke6()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██████████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░░░░▒████████████░░░░░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░░▒  ██████████████  ░  ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒   ░░  ████████████████ ░░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒ ░░░ ██████████████████░      ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █░ ████████████████████        ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ░░ █ █   ██ █ ██  ████████████████████   █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒              ███   ██ ████  █████████████████████ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████▒▒▒████▒▒▒██████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ ████████▒▒▒▒██▒▒██▒▒▒▒███        ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████       ███▒▒▒██▒▒▒▒██▒▒▒███                                       █
    █       !!!!!!!!!!!!                      ██▒▒██▒▒▒▒▒▒▒▒██▒▒██                                       █ 
    █       !!!!!!!!!!!!                      ██▒████▒▒▒▒▒▒████▒██                                       █ 
    █            ██                           █████████▒▒█████████                                       █ 
    █           ███                           ████████████████████                                       █ 
    █          █████ █                        ████████▒▒▒▒████████                                       █ 
    █         █ █████                          █████▒▒▒▒▒▒▒▒█████                                        █ 
    █         █ ███                             ████████████████                                         █ 
    █           ██████                             ██████████                                            █ 
    █           █    █                               ██████                                              █ 
    █          █                                                                                         █ 
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerOneNuke7()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██████████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░░░░▒████████████░░░░░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░░▒  ██████████████  ░  ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒   ░░  ████████████████ ░░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒ ░░░ ██████████████████░      ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █░ ████████████████████        ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ░░ █ █   ██ █ ██  ████████████████████   █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒              ███   ██ ████  █████████████████████ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████▒▒▒████▒▒▒██████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ ████████▒▒▒▒██████▒▒▒▒███        ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████       ███▒▒▒███▒▒███▒▒▒███                                       █
    █                                         ██▒▒▒██▒▒▒▒▒▒██▒▒▒██              !!!!!!!!!!!!!!!!!!!!!!!  █
    █                                         ██▒▒██▒▒▒▒▒▒▒▒██▒▒██              !!!!!!!!!!!!!!!!!!!!!!!  █
    █                                         ██▒████▒▒▒▒▒▒████▒██              !!!!!!!!!!!!!!!!!!!!!!!  █
    █                                         █████████▒▒█████████                         ██            █
    █                                         ████████████████████                         ███           █
    █                                         ████████▒▒▒▒████████                      █ █████          █
    █                                          █████▒▒▒▒▒▒▒▒█████                        █████ █         █
    █                                           ████████████████                           ███ █         █
    █                                              ██████████                           ██████           █
    █                                                ██████                             █    █           █
    █                                                                                         █          █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerTwoNuke7()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██████████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░░░░▒████████████░░░░░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░░▒  ██████████████  ░  ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒   ░░  ████████████████ ░░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒ ░░░ ██████████████████░      ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █░ ████████████████████        ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒░░░░      ░░ █ █   ██ █ ██  ████████████████████   █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒              ███   ██ ████  █████████████████████ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████▒▒▒████▒▒▒██████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ ████████▒▒▒▒██████▒▒▒▒███        ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████       ███▒▒▒███▒▒███▒▒▒███                                       █
    █  !!!!!!!!!!!!!!!!!!!!!!!                ██▒▒▒██▒▒▒▒▒▒██▒▒▒██                                       █ 
    █  !!!!!!!!!!!!!!!!!!!!!!!                ██▒▒██▒▒▒▒▒▒▒▒██▒▒██                                       █ 
    █  !!!!!!!!!!!!!!!!!!!!!!!                ██▒████▒▒▒▒▒▒████▒██                                       █ 
    █            ██                           █████████▒▒█████████                                       █ 
    █           ███                           ████████████████████                                       █ 
    █          █████ █                        ████████▒▒▒▒████████                                       █ 
    █         █ █████                          █████▒▒▒▒▒▒▒▒█████                                        █ 
    █         █ ███                             ████████████████                                         █ 
    █           ██████                             ██████████                                            █ 
    █           █    █                               ██████                                              █ 
    █          █                                                                                         █ 
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void playerOneNuke8()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █░▒▒▒░░░░░░░░░░░░░▒░░░▒▒░░░░▒▒▒░░░░░░░░▒▒▒▒▒▒░░░░░▒░░░░░░░░░░░▒░░▒▒▒░░░░░░▒▒░▒░░░░░░░░▒░░▒░░░▒░░░░░░░█
    █░░▒▒▒▒▒▒░▒░░░▒▒▒▒▒░░░░░░░░░░░░░░░▒▒▒░░░░░░░▒▒░░░░░░░▒▒▒░░░░░▒▒▒░░░░▒▒▒▒▒░░░░░░▒░▒▒▒▒▒▒▒░░░▒▒░░░▒▒░░░█
    █░░▒░░▒░▒░░░▒░░░░░░░▒▒░▒▒▒▒░░░▒▒▒░▒▒░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒░░▒░░░░░░▒░░░░░░░░░░▒▒▒▒░░░░░░░▒▒░░░▒░▒░▒░░░█
    █░░▒░▒░▒▒▒▒▒▒▒░▒▒▒▒▒▒▒░░░░░░░░▒░░░░░░▒▒▒▒▒▒░░░░░░▒░░░░░░░▒▒▒░░▒▒░░▒▒░▒▒▒▒▒░░▒░▒░░▒▒▒▒▒░░░░░▒▒▒░▒▒▒░░░█
    █░░▒▒░▒▒░░░░░░▒▒░░░░░▒▒▒▒▒░░▒░▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒░░░░▒▒░░▒▒░░░░░░░░░▒░░░░░░░▒▒░░░▒░░░░░░░░▒▒▒░░▒▒░▒░▒░░█
    █░░▒▒▒░▒░░▒░▒▒░░░▒▒░░░░▒▒░░░▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒░▒░░▒░░░░█
    █░▒░▒░░▒░░░░░░░▒░░▒▒▒▒▒░░▒▒░░░░░▒▒▒░░▒░░░▒░▒▒░░▒▒▒░░░░▒▒▒░░▒░░░░░░▒░▒▒▒▒▒░░░░░░░▒▒▒▒▒░░░░░▒▒░░░▒▒▒░░░█
    █░▒░░▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░▒░░▒░░▒▒░░░▒▒▒░▒░░░▒▒▒▒▒░░▒▒▒░▒░▒▒░▒░░░▒▒▒░░░░▒▒░░░░░░░▒░░░░░▒▒▒▒▒░▒░▒░█
    █░▒░░▒░░░░░░░░░░░▒░░░░░░░▒▒▒▒▒░░░▒▒▒░▒░▒▒░░░░░▒░░▒▒▒▒▒░░░░░░░▒▒░░░░▒░░░░▒░░▒░▒▒▒░░░▒▒▒░▒▒▒░░▒▒░░░░░▒░█
    █░▒▒▒▒▒▒▒░░▒░░▒░░░▒▒▒▒░░▒▒░░░▒▒▒▒▒▒░▒░░░░░░▒░░▒▒▒▒░░░░░▒▒▒▒▒░░▒▒▒▒░░░░░░░▒░░▒▒░▒░░▒▒░▒▒░░▒░░▒▒░▒▒░▒░░█
    █░░░░░░▒▒▒░▒░░░▒▒▒▒░░░░░▒▒░▒░░░░░░▒▒▒▒▒▒▒░░▒░░▒▒▒▒░▒▒░▒▒▒▒▒░▒░░░░░░▒░░░▒░▒▒▒▒▒░▒▒░░░░▒▒░░▒░░░▒░░▒░▒░░█
    █░░░▒░▒▒▒░░▒░▒▒░░░▒░░░▒▒░░░░░▒▒▒▒▒▒▒▒░░░▒▒▒▒░░░▒░░▒▒▒▒▒░▒▒░▒▒▒░▒░▒░▒▒▒▒▒░▒░░░▒░░░▒▒░░▒░░▒▒▒░░▒░░░▒░░░█
    █░░▒▒░░▒▒░░░░░░░░░░░▒▒▒░░░▒▒▒░▒░▒░░░▒▒▒▒▒░░▒▒▒░░░▒░░▒▒▒░░░░▒░▒▒░▒▒░░▒▒▒▒░░░▒░░░▒▒▒▒▒░░░░▒▒░░░▒░▒░▒░░░█
    █░▒░░▒░░░░▒▒░░▒░▒▒▒▒░░░░▒░░░▒▒▒░▒▒░▒▒▒░░▒▒░░▒░░░▒▒░░░░░▒▒▒░░░▒░░▒▒░░▒▒▒▒▒░░░░▒░░▒▒░▒░░░░▒▒░░▒░▒▒▒▒▒░░█
    █░▒░░▒░░░▒░▒▒▒░░░▒░▒░▒░░░▒▒░░░░░░░▒░▒▒▒▒▒░░░░░░░▒▒░░▒▒▒▒░▒▒▒▒▒▒░░░░▒▒░░░▒░▒▒▒▒░░░░░▒▒▒░▒▒░░░▒░░░░░░░░█
    █░░░░▒░░░▒░░▒░░░▒▒▒░░░▒▒▒▒░░░░░▒▒░░▒░░░░░░▒▒▒▒░▒▒░▒▒░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒░░░▒▒░░▒░░▒▒▒▒▒░█
    █░░░▒░░▒░░░░░░▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒░░▒░░░░▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░▒░░▒▒▒▒▒▒░▒░▒░░░░▒░░░░░░▒░░█
    █░░▒░░▒░░░▒▒░▒░░▒░░▒▒░░▒▒▒▒░░░░░▒▒▒▒▒▒▒▒░░░░░░▒▒░░▒░░▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒░▒░░░░▒▒▒▒░░░░░░▒░░▒░▒▒░▒░░▒▒░█
    █░░▒░░░░░░░▒▒░░░░▒▒░░░▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒░░░▒░░░░░▒░▒░▒▒▒░░░░░▒▒░░▒▒▒░░▒░▒░░▒░░█
    █░░░░▒▒░▒░░░▒░░▒░░░░░░▒▒░░░░░░▒░░▒▒░░░░░░░░░▒░░░░░▒░▒▒▒▒░▒▒░░░░▒░▒░░▒▒░░░░▒░░░░░▒▒▒▒▒░░░░▒░░░▒░▒░░▒▒░█
    █░░░▒░░░░░▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒░░▒▒▒▒▒▒▒▒▒░░▒▒▒▒░░▒▒░░░░░░▒▒▒▒▒░░▒▒▒░▒▒░░▒░░░▒▒▒░░░░░▒░░▒░░░░▒▒░░░░░█
    █░░░▒░░░▒▒▒▒▒░▒░░▒▒░░▒▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒░░░░▒▒▒▒░░▒▒▒▒▒▒▒░░░▒░░▒▒▒▒▒▒▒▒░░▒░█
    █░░░░░░░░░░░░░░░░▒▒░░░░░▒▒▒▒▒▒░░░░▒░░░░░░░░░░▒▒▒░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒░░░░░░▒▒░░▒░▒░░█
    █░▒░░▒░░▒▒▒▒░▒▒▒▒▒░░▒▒▒▒░░░░▒▒▒░░░░░▒▒▒▒▒░░░░░░░▒▒▒░▒░▒▒▒▒░▒▒▒▒▒░░▒░░░░░░▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒░▒▒▒░░░░▒░█
    █░░▒▒░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░▒▒▒▒▒▒▒▒░░░░░░░▒▒░░░░▒░░░░░░░░▒░░░░█
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█


");
    }
    static void playerOneNuke9()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █░░░░░░░▒░░░▒░░▒░░░░░░░░▒░▒▒░░░░░░▒▒▒░░▒░░░░░░░░░░░▒░░░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░░░▒▒░░░▒░░░░░░░░░░░░░▒▒▒░█ 
    █░░░▒▒░░░▒▒░░░▒▒▒▒▒▒▒░▒░░░░░░▒▒▒▒▒░░░░▒▒▒░░░░░▒▒▒░░░░░░░▒▒░░░░░░░▒▒▒░░░░░░░░░░░░░░░▒▒▒▒▒░░░▒░▒▒▒▒▒▒░░█ 
    █░░░▒░▒░▒░░░▒▒░░░░░░░▒▒▒▒░░░░░░░░░░▒░░░░░░▒░░▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░▒▒░▒▒▒░░░▒▒▒▒░▒▒░░░░░░░▒░░░▒░▒░░▒░░█
    █░░░▒▒▒░▒▒▒░░░░░▒▒▒▒▒░░▒░▒░░▒▒▒▒▒░▒▒░░▒▒░░▒▒▒░░░░░░░▒░░░░░░▒▒▒▒▒▒░░░░░░▒░░░░░░░░▒▒▒▒▒▒▒░▒▒▒▒▒▒▒░▒░▒░░█
    █░░▒░▒░▒▒░░▒▒▒░░░░░░░░▒░░░▒▒░░░░░░░▒░░░░░░░░░▒▒░░▒▒░░░░▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒░▒░░▒▒▒▒▒░░░░░▒▒░░░░░░▒▒░▒▒░░█
    █░░░░▒░░▒░▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒░░░▒▒░░░░▒▒░░░▒▒░▒░░▒░▒▒▒░░█
    █░░░▒▒▒░░░▒▒░░░░░▒▒▒▒▒░░░░░░░▒▒▒▒▒░▒░░░░░░▒░░▒▒▒░░░░▒▒▒░░▒▒░▒░░░▒░░▒▒▒░░░░░▒▒░░▒▒▒▒▒░░▒░░░░░░░▒░░▒░▒░█
    █░▒░▒░▒▒▒▒▒░░░░░▒░░░░░░░▒▒░░░░▒▒▒░░░▒░▒▒░▒░▒▒▒░░▒▒▒▒▒░░░▒░▒▒▒░░░▒▒░░▒░░▒░▒░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒░░▒░█
    █░▒░░░░░▒▒░░▒▒▒░▒▒▒░░░▒▒▒░▒░░▒░░░░▒░░░░▒▒░░░░░░░▒▒▒▒▒░░▒░░░░░▒▒░▒░▒▒▒░░░▒▒▒▒▒░░░░░░░▒░░░░░░░░░░░▒░░▒░█
    █░░▒░▒▒░▒▒░░▒░░▒▒░▒▒░░▒░▒▒░░▒░░░░░░░▒▒▒▒░░▒▒▒▒▒░░░░░▒▒▒▒░░▒░░░░░░▒░▒▒▒▒▒▒░░░▒▒░░▒▒▒▒░░░▒░░▒░░▒▒▒▒▒▒▒░█
    █░░▒░▒░░▒░░░▒░░▒▒░░░░▒▒░▒▒▒▒▒░▒░░░▒░░░░░░▒░▒▒▒▒▒░▒▒░▒▒▒▒░░▒░░▒▒▒▒▒▒▒░░░░░░▒░▒▒░░░░░▒▒▒▒░░░▒░▒▒▒░░░░░░█
    █░░░▒░░░▒░░▒▒▒░░▒░░▒▒░░░▒░░░▒░▒▒▒▒▒░▒░▒░▒▒▒░▒▒░▒▒▒▒▒░░▒░░░▒▒▒▒░░░▒▒▒▒▒▒▒▒░░░░░▒▒░░░▒░░░▒▒░▒░░▒▒▒░▒░░░█
    █░░░▒░▒░▒░░░▒▒░░░░▒▒▒▒▒░░░▒░░░▒▒▒▒░░▒▒░▒▒░▒░░░░▒▒▒░░▒░░░▒▒▒░░▒▒▒▒▒░░░▒░▒░▒▒▒░░░▒▒▒░░░░░░░░░░░▒▒░░▒▒░░█
    █░░▒▒▒▒▒░▒░░▒▒░░░░▒░▒▒░░▒░░░░▒▒▒▒▒░░▒▒░░▒░░░▒▒▒░░░░░▒▒░░░▒░░▒▒░░▒▒▒░▒▒░▒▒▒░░░▒░░░░▒▒▒▒░▒░░▒▒░░░░▒░░▒░█
    █░░░░░░░░▒░░░▒▒░▒▒▒░░░░░▒▒▒▒░▒░░░▒▒░░░░▒▒▒▒▒▒░▒▒▒▒░░▒▒░░░░░░░▒▒▒▒▒░▒░░░░░░░▒▒░░░▒░▒░▒░░░▒▒▒░▒░░░▒░░▒░█
    █░▒▒▒▒▒░░▒░░▒▒░░░▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒▒░▒▒░▒▒▒▒░░░░░░▒░░▒▒░░░░░▒▒▒▒░░░▒▒▒░░░▒░░▒░░░▒░░░░█
    █░░▒░░░░░░▒░░░░▒░▒░▒▒▒▒▒▒░░▒░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒░░░░▒░░▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒░░░░░░▒░░▒░░░█
    █░▒▒░░▒░▒▒░▒░░▒░░░░░░▒▒▒▒░░░░▒░▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒░░▒░░▒▒░░░░░░▒▒▒▒▒▒▒▒░░░░░▒▒▒▒░░▒▒░░▒░░▒░▒▒░░░▒░░▒░░█
    █░░▒░░▒░▒░░▒▒▒░░▒▒░░░░░▒▒▒░▒░▒░░░░░▒░░░▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒░░░▒▒░░░░▒▒░░░░░░░▒░░█
    █░▒▒░░▒░▒░░░▒░░░░▒▒▒▒▒░░░░░▒░░░░▒▒░░▒░▒░░░░▒▒░▒▒▒▒░▒░░░░░▒░░░░░░░░░▒▒░░▒░░░░░░▒▒░░░░░░▒░░▒░░░▒░▒▒░░░░█
    █░░░░░▒▒░░░░▒░░▒░░░░░▒▒▒░░░▒░░▒▒░▒▒▒░░▒▒▒▒▒░░░░░░▒▒░░▒▒▒▒░░▒▒▒▒▒▒▒▒▒░░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒░░░░░▒░░░█ 
    █░▒░░▒▒▒▒▒▒▒▒░░▒░░░▒▒▒▒▒▒▒░░▒▒▒▒░░░░▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░░░▒▒░░▒▒░░▒░▒▒▒▒▒░░░▒░░░█
    █░░▒░▒░░▒▒░░░░░░▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒░░░░░░▒▒▒░░░░░░░░░░▒░░░░▒▒▒▒▒▒░░░░░▒▒░░░░░░░░░░░░░░░░█
    █░▒░░░░▒▒▒░▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒░░░░░░▒░░▒▒▒▒▒░▒▒▒▒░▒░▒▒▒░░░░░░░▒▒▒▒▒░░░░░▒▒▒░░░░▒▒▒▒░░▒▒▒▒▒░▒▒▒▒░░▒░░▒░█
    █░░░░▒░░░░░░░░▒░░░░▒▒░░░░░░░▒▒▒▒▒▒▒▒░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░▒▒░░█
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void playerOneNuke10()
    {
        Console.WriteLine(@"
    
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █░░▒▒░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░▒▒▒▒▒▒▒▒░░░░░░░▒▒░░░░▒░░░░░░░░▒░░░░█
    █░▒░░▒░░▒▒▒▒░▒▒▒▒▒░░▒▒▒▒░░░░▒▒▒░░░░░▒▒▒▒▒░░░░░░░▒▒▒░▒░▒▒▒▒░▒▒▒▒▒░░▒░░░░░░▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒░▒▒▒░░░░▒░█
    █░░░░░░░░░░░░░░░░▒▒░░░░░▒▒▒▒▒▒░░░░▒░░░░░░░░░░▒▒▒░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒░░░░░░▒▒░░▒░▒░░█
    █░░░▒░░░▒▒▒▒▒░▒░░▒▒░░▒▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒░░░░▒▒▒▒░░▒▒▒▒▒▒▒░░░▒░░▒▒▒▒▒▒▒▒░░▒░█
    █░░░▒░░░░░▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒░░▒▒▒▒▒▒▒▒▒░░▒▒▒▒░░▒▒░░░░░░▒▒▒▒▒░░▒▒▒░▒▒░░▒░░░▒▒▒░░░░░▒░░▒░░░░▒▒░░░░░█
    █░░░░▒▒░▒░░░▒░░▒░░░░░░▒▒░░░░░░▒░░▒▒░░░░░░░░░▒░░░░░▒░▒▒▒▒░▒▒░░░░▒░▒░░▒▒░░░░▒░░░░░▒▒▒▒▒░░░░▒░░░▒░▒░░▒▒░█
    █░░▒░░░░░░░▒▒░░░░▒▒░░░▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░▒░░░▒░░░░░▒░▒░▒▒▒░░░░░▒▒░░▒▒▒░░▒░▒░░▒░░█
    █░░▒░░▒░░░▒▒░▒░░▒░░▒▒░░▒▒▒▒░░░░░▒▒▒▒▒▒▒▒░░░░░░▒▒░░▒░░▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒░▒░░░░▒▒▒▒░░░░░░▒░░▒░▒▒░▒░░▒▒░█
    █░░░▒░░▒░░░░░░▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒░░▒░░░░▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░▒░░▒▒▒▒▒▒░▒░▒░░░░▒░░░░░░▒░░█
    █░░░░▒░░░▒░░▒░░░▒▒▒░░░▒▒▒▒░░░░░▒▒░░▒░░░░░░▒▒▒▒░▒▒░▒▒░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒░░░▒▒░░▒░░▒▒▒▒▒░█
    █░▒░░▒░░░▒░▒▒▒░░░▒░▒░▒░░░▒▒░░░░░░░▒░▒▒▒▒▒░░░░░░░▒▒░░▒▒▒▒░▒▒▒▒▒▒░░░░▒▒░░░▒░▒▒▒▒░░░░░▒▒▒░▒▒░░░▒░░░░░░░░█
    █░▒░░▒░░░░▒▒░░▒░▒▒▒▒░░░░▒░░░▒▒▒░▒▒░▒▒▒░░▒▒░░▒░░░▒▒░░░░░▒▒▒░░░▒░░▒▒░░▒▒▒▒▒░░░░▒░░▒▒░▒░░░░▒▒░░▒░▒▒▒▒▒░░█
    █░░▒▒░░▒▒░░░░░░░░░░░▒▒▒░░░▒▒▒░▒░▒░░░▒▒▒▒▒░░▒▒▒░░░▒░░▒▒▒░░░░▒░▒▒░▒▒░░▒▒▒▒░░░▒░░░▒▒▒▒▒░░░░▒▒░░░▒░▒░▒░░░█
    █░░░▒░▒▒▒░░▒░▒▒░░░▒░░░▒▒░░░░░▒▒▒▒▒▒▒▒░░░▒▒▒▒░░░▒░░▒▒▒▒▒░▒▒░▒▒▒░▒░▒░▒▒▒▒▒░▒░░░▒░░░▒▒░░▒░░▒▒▒░░▒░░░▒░░░█
    █░░░░░░▒▒▒░▒░░░▒▒▒▒░░░░░▒▒░▒░░░░░░▒▒▒▒▒▒▒░░▒░░▒▒▒▒░▒▒░▒▒▒▒▒░▒░░░░░░▒░░░▒░▒▒▒▒▒░▒▒░░░░▒▒░░▒░░░▒░░▒░▒░░█
    █░▒▒▒▒▒▒▒░░▒░░▒░░░▒▒▒▒░░▒▒░░░▒▒▒▒▒▒░▒░░░░░░▒░░▒▒▒▒░░░░░▒▒▒▒▒░░▒▒▒▒░░░░░░░▒░░▒▒░▒░░▒▒░▒▒░░▒░░▒▒░▒▒░▒░░█
    █░▒░░▒░░░░░░░░░░░▒░░░░░░░▒▒▒▒▒░░░▒▒▒░▒░▒▒░░░░░▒░░▒▒▒▒▒░░░░░░░▒▒░░░░▒░░░░▒░░▒░▒▒▒░░░▒▒▒░▒▒▒░░▒▒░░░░░▒░█
    █░▒░░▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░▒░░▒░░▒▒░░░▒▒▒░▒░░░▒▒▒▒▒░░▒▒▒░▒░▒▒░▒░░░▒▒▒░░░░▒▒░░░░░░░▒░░░░░▒▒▒▒▒░▒░▒░█
    █░▒░▒░░▒░░░░░░░▒░░▒▒▒▒▒░░▒▒░░░░░▒▒▒░░▒░░░▒░▒▒░░▒▒▒░░░░▒▒▒░░▒░░░░░░▒░▒▒▒▒▒░░░░░░░▒▒▒▒▒░░░░░▒▒░░░▒▒▒░░░█
    █░░▒▒▒░▒░░▒░▒▒░░░▒▒░░░░▒▒░░░▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒▒▒▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒░▒░░▒░░░░█
    █░░▒▒░▒▒░░░░░░▒▒░░░░░▒▒▒▒▒░░▒░▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒░░░░▒▒░░▒▒░░░░░░░░░▒░░░░░░░▒▒░░░▒░░░░░░░░▒▒▒░░▒▒░▒░▒░░█
    █░░▒░▒░▒▒▒▒▒▒▒░▒▒▒▒▒▒▒░░░░░░░░▒░░░░░░▒▒▒▒▒▒░░░░░░▒░░░░░░░▒▒▒░░▒▒░░▒▒░▒▒▒▒▒░░▒░▒░░▒▒▒▒▒░░░░░▒▒▒░▒▒▒░░░█
    █░░▒░░▒░▒░░░▒░░░░░░░▒▒░▒▒▒▒░░░▒▒▒░▒▒░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒░░▒░░░░░░▒░░░░░░░░░░▒▒▒▒░░░░░░░▒▒░░░▒░▒░▒░░░█
    █░░▒▒▒▒▒▒░▒░░░▒▒▒▒▒░░░░░░░░░░░░░░░▒▒▒░░░░░░░▒▒░░░░░░░▒▒▒░░░░░▒▒▒░░░░▒▒▒▒▒░░░░░░▒░▒▒▒▒▒▒▒░░░▒▒░░░▒▒░░░█
    █░▒▒▒░░░░░░░░░░░░░▒░░░▒▒░░░░▒▒▒░░░░░░░░▒▒▒▒▒▒░░░░░▒░░░░░░░░░░░▒░░▒▒▒░░░░░░▒▒░▒░░░░░░░░▒░░▒░░░▒░░░░░░░█
    ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
    }
    static void bothMirror()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                       ████ ██            ████████               ████                           █
    █                          ███ █                                      █ ███                          █
    █                         ███  █                                      █  ███                         █
    █            ██          ███   █                                      █   ███          ██            █
    █           ███         ███    █                                      █    ███         ███           █
    █          ███████      ██     █                                      █     ██      ███████          █
    █          ████         ██     █                                      █     ██         ████          █
    █          █████        ██     █                                      █     ██        █████          █
    █          ████         ██     █                                      █     ██         ████          █
    █          ████         ██    ██                                      ██    ██         ████          █
    █          ██ █         ██   ██                                        ██   ██         █ ██          █
    █          ██           ██  ██                                          ██  ██           ██          █
    █          █            ██ ██                                            ██ ██            █          █
    █                       ████                                              ████                       █
    █                       ███                                                ███                       █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");
    }
    static void mirrorNSurrender()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████           ████                   ▒▒▒▒▒▒▒ █
    █ ▒▒▒                       ████ ██            ████████                                              █
    █                          ███ █                                                          █          █
    █                         ███  █                                                       █  █          █
    █            ██          ███   █                                                       ██ █          █
    █           ███         ███    █                                                       ████          █
    █          ███████      ██     █                                                       ████          █
    █          ████         ██     █                                                       ███           █
    █          █████        ██     █                                                       ███           █
    █          ████         ██     █                                                       ███           █
    █          ████         ██    ██                                                       █ █           █
    █          ██ █         ██   ██                                                        █ █           █
    █          ██           ██  ██                                                           █           █
    █          █            ██ ██                                                                        █
    █                       ████                                                                         █
    █                       ███                                                                          █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }
    static void surrenderNMirror()
    {
        Console.WriteLine(@"
    █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒░░░▒▒▒▒░░ ░░  ░▒▒▒▒▒▒   ░▒▒▒    ░ ░▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒ ░▒▒▒░░░░░░░ ▒▒▒█░  ░██      ░██   ░▒░░▒▒    ░▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒░▒░░ ▒░░░░░▒▒     █ ██  ░░██   █   ██ ░░▒▒▒ ░░░░░░░▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒░░▒▒▒   ▒▒▒▒    █ ██    ██   █   ██       ░░███ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░ ▒░░░░█      █    █  █ ██    ██   ██ ███         ███░░ ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░░░░░      ░░ █ █   ██ █ ██  █ ██   ████ ███ ███    █ █  ███▒█▒░░▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒▒▒░             ███   ██ ████  ████ █ ████████████ █ █████ █████▒ █    ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ █
    █ ▒▒▒▒▒▒▒▒▒            █  ████ █ ███████ ██████████████████████████████████████         ▒▒▒▒▒▒▒▒▒▒▒▒ █
    █  ▒▒▒▒▒              ██████████████ █████ ████████████████          ████                    ▒▒▒▒▒▒▒ █
    █ ▒▒▒                      ████████            ████████              █ ███                           █
    █           █                                                        █  ███                          █
    █           █  █                                                     █   ███          ██             █
    █           █ ██                                                     █    ███         ███            █
    █           ████                                                     █     ██      ███████           █
    █           ████                                                     █     ██         ████           █
    █            ███                                                     █     ██        █████           █
    █            ███                                                     █     ██         ████           █
    █            ███                                                     ██    ██         ████           █
    █            ███                                                      ██   ██         █ ██           █
    █            █ █                                                       ██  ██           ██           █
    █            █                                                          ██ ██            █           █
    █                                                                        ████                        █
    █                                                                         ███                        █
    █                                                                                                    █
    █                                                                                                    █
    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
    }


    static void DisplayHowToPlay()
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\n");
        Console.WriteLine(@"
                                           ┬─┐ ┬ ┬ ┬   ┌─┐ ┌─┐    
                                           ├┬┘ │ │ │   ├┤  └─┐    
                                           ┴└─ └─┘ ┴─┘ └─┘ └─┘ ");
        Console.WriteLine("\n\n");
        Console.WriteLine(@"The Mechanics of this game works very similar to another game Called ""Rock, Paper, Scissors"".
But instead of having the elements of ""rock, paper, and scissors"", they are replaced by the following:

= Actions =  : = Effect =

Charge       : Increases your Charge amount by 1.
Surrender    : Survive a Gun attack from the Opponent.
Mirror       : Costs 3 charges, reflects Opponent's Gun and Kamehameha.


Gun          : Costs 2 charges, wins you the game if Opponent plays Charge.
Kamehameha   : Costs 5 charges, wins you the game if the Opponent plays Charge, Surrender, or Gun.
Nuclear Bomb : Costs 8 charges, wins you the game if Opponent plays any other element.

");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);
    }

    static void DisplayCredits()
    {
        Console.Clear();
        Console.WriteLine(@"
                                        ┌─┐ ┬─┐ ┌─┐ ┌┬┐ ┬ ┌┬┐ ┌─┐
                                        │   ├┬┘ ├┤   ││ │  │  └─┐
                                        └─┘ ┴└─ └─┘ ─┴┘ ┴  ┴  └─┘
");
        Console.WriteLine(@"

                                         ╔═╗┬─┐┌─┐┌─┐┌┬┐┌─┐┬─┐┌─┐              
                    ┼                    ║  ├┬┘├┤ ├─┤ │ │ │├┬┘└─┐
                                         ╚═╝┴└─└─┘┴ ┴ ┴ └─┘┴└─└─┘             ┼
               ╔============================================================================╗       ┼
               ║                                                                            ║   ██ 
     ┼         ║                  == Quert Alfonso M. Villafuerte ==                        ║  ███ 
               ║  -- Player vs Player, Game Mechanics, Front End Game Creator & Animator -- ║ █████     ┼
               ║                                                                            ║ █████
               ║                       == Riz Ivan G. Verana ==                             ║ █████
               ║                          -- Menu Creator --                                ║ ████
               ║                                                                            ║  █ █
               ║                        == Angelo S. Averion ==                             ║  █ █
               ║               -- Single Player Creator & Menu Design --                    ║  █
               ║                                                                            ║        ┼
               ╚============================================================================╝
       ┼                                                                 ┼
                                       ┼
Press any key to continue...
");
        Console.ReadKey(true);
    }

    static void SinglePlayer()
    {

        bool Game = true;
        int PlayerCharge = 2;
        int OpponentCharge = 2;
        int OpponentChargeR;
        int roundNum = 1;
        string PlayerElement = "";
        string OpponentElement = "";
        Random Opponent = new Random();
        while (Game)
        {
        MyLabel:
            Console.Clear();
            playerVSbotGame(roundNum, PlayerCharge, OpponentCharge);
            ChargeBar(PlayerCharge, OpponentCharge);
            startAnimation();
            Thread.Sleep(500);
        ready:
            Console.Clear();
            playerVSbotGame(roundNum, PlayerCharge, OpponentCharge);
            ChargeBar(PlayerCharge, OpponentCharge);
            readyPlayerTwo();
            ConsoleKey Element = Console.ReadKey(true).Key;
            Console.WriteLine(" ");

            switch (Element)
            {
                case ConsoleKey.Escape:
                    Console.Clear();
                    Escape();
                    goto MyLabel;
                case ConsoleKey.Q:
                    Console.Clear();
                    playerVSbotGame(roundNum, PlayerCharge, OpponentCharge);
                    ChargeBar(PlayerCharge, OpponentCharge);
                    readyBothPlayers();
                    PlayerElement = "Charges";
                    Console.WriteLine("You played Charge");
                    break;
                case ConsoleKey.W:
                    Console.Clear();
                    playerVSbotGame(roundNum, PlayerCharge, OpponentCharge);
                    ChargeBar(PlayerCharge, OpponentCharge);
                    readyBothPlayers();
                    PlayerElement = "Surrender";
                    Console.WriteLine("You played Surrender");
                    break;
                case ConsoleKey.E:
                    if (PlayerCharge == 0 || PlayerCharge == 1 || PlayerCharge == 2)
                    {

                        Console.WriteLine("Not enough Charges");
                        Thread.Sleep(100);
                        Game = true;
                        goto ready;

                    };
                    Console.Clear();
                    playerVSbotGame(roundNum, PlayerCharge, OpponentCharge);
                    ChargeBar(PlayerCharge, OpponentCharge);
                    readyBothPlayers();
                    Console.WriteLine("You played Mirror");
                    PlayerCharge -= 3;
                    PlayerElement = "Mirror";
                    break;
                case ConsoleKey.A:
                    if (PlayerCharge == 0 || PlayerCharge == 1)
                    {
                        Console.WriteLine("Not enough Charges");
                        Thread.Sleep(100);
                        goto ready;
                    };
                    Console.Clear();
                    playerVSbotGame(roundNum, PlayerCharge, OpponentCharge);
                    ChargeBar(PlayerCharge, OpponentCharge);
                    readyBothPlayers();
                    Console.WriteLine("You played Gun");
                    PlayerCharge -= 2;
                    PlayerElement = "Gun";
                    break;
                case ConsoleKey.S:
                    if (PlayerCharge == 0 || PlayerCharge == 1 || PlayerCharge == 2 || PlayerCharge == 3 || PlayerCharge == 4)
                    {
                        Console.WriteLine("Not enough Charges");
                        Thread.Sleep(100);
                        goto ready;
                    };
                    Console.Clear();
                    playerVSbotGame(roundNum, PlayerCharge, OpponentCharge);
                    ChargeBar(PlayerCharge, OpponentCharge);
                    readyBothPlayers();
                    Console.WriteLine("You played Kamehameha");
                    PlayerCharge -= 5;
                    PlayerElement = "Kamehameha";
                    break;
                case ConsoleKey.D:
                    if (PlayerCharge == 0 || PlayerCharge == 1 || PlayerCharge == 2 || PlayerCharge == 3 || PlayerCharge == 4 || PlayerCharge == 5 || PlayerCharge == 6 || PlayerCharge == 7)
                    {
                        Console.WriteLine("Not enough Charges");
                        Thread.Sleep(100);
                        goto ready;
                    };
                    Console.Clear();
                    playerVSbotGame(roundNum, PlayerCharge, OpponentCharge);
                    ChargeBar(PlayerCharge, OpponentCharge);
                    readyBothPlayers();
                    Console.WriteLine("You played Nuclear Bomb");
                    PlayerCharge -= 8;
                    PlayerElement = "Nuclear Bomb";
                    break;
                default:
                    goto ready;
            }
            Thread.Sleep(1000);
            if (OpponentCharge == 0 && PlayerCharge == 0 || OpponentCharge == 1 && PlayerCharge == 1)
            {
                switch (OpponentCharge)
                {
                    case 0:
                        Console.WriteLine("Opponent played Charge");
                        OpponentElement = "Charges";
                        Game = true;
                        break;
                    case 1:
                        Console.WriteLine("Opponent played Charge");
                        OpponentElement = "Charges";
                        Game = true;
                        break;
                }
            }
            else
            {
            TryAgain:
                switch (OpponentCharge)
                {
                    case 0:
                        OpponentChargeR = Opponent.Next(1, 3);
                        switch (OpponentChargeR)
                        {
                            case 1:
                                if (PlayerCharge == 0 && OpponentCharge == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Opponent played Charge");
                                    OpponentElement = "Charges";
                                    Game = true;
                                    break;
                                }
                            case 2:
                                if (PlayerElement == "Surrender" || PlayerCharge < 2)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Surrender");
                                OpponentElement = "Surrender";
                                Game = true;
                                break;
                        }
                        break;
                    case 1:
                        OpponentChargeR = Opponent.Next(1, 3);
                        switch (OpponentChargeR)
                        {
                            case 1:
                                if (PlayerCharge == 1 && OpponentCharge == 1)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Opponent played Charge");
                                    OpponentElement = "Charges";
                                    Game = true;
                                    break;
                                }
                            case 2:
                                if (PlayerCharge == 1 || PlayerCharge == 0)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Surrender");
                                OpponentElement = "Surrender";
                                Game = true;
                                break;
                        }
                        break;
                    case 2:
                        OpponentChargeR = Opponent.Next(1, 4);
                        switch (OpponentChargeR)
                        {
                            case 1:
                                Console.WriteLine("Opponent played Charge");
                                OpponentElement = "Charges";
                                Game = true;
                                break;
                            case 2:
                                if (PlayerCharge == 1 || PlayerCharge == 0)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Surrender");
                                OpponentElement = "Surrender";
                                Game = true;
                                break;
                            case 3:
                                Console.WriteLine("Opponent played Gun");
                                OpponentCharge -= 2;
                                OpponentElement = "Gun";
                                break;
                        }
                        break;
                    case 3:
                        OpponentChargeR = Opponent.Next(1, 5);
                        switch (OpponentChargeR)
                        {
                            case 1:
                                Console.WriteLine("Opponent played Charge");
                                OpponentElement = "Charges";
                                Game = true;
                                break;
                            case 2:
                                if (PlayerCharge == 1 || PlayerCharge == 0)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Surrender");
                                OpponentElement = "Surrender";
                                Game = true;
                                break;
                            case 3:
                                if (PlayerCharge < 2)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Mirror");
                                OpponentCharge -= 3;
                                OpponentElement = "Mirror";
                                break;
                            case 4:
                                Console.WriteLine("Opponent played Gun");
                                OpponentCharge -= 2;
                                OpponentElement = "Gun";
                                break;
                        }
                        break;
                    case 4:
                        OpponentChargeR = Opponent.Next(1, 5);
                        switch (OpponentChargeR)
                        {
                            case 1:
                                Console.WriteLine("Opponent played Charge");
                                OpponentElement = "Charges";
                                Game = true;
                                break;
                            case 2:
                                if (PlayerCharge == 1 || PlayerCharge == 0)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Surrender");
                                OpponentElement = "Surrender";
                                Game = true;
                                break;
                            case 3:
                                if (PlayerCharge < 2)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Mirror");
                                OpponentCharge -= 3;
                                OpponentElement = "Mirror";
                                break;
                            case 4:
                                Console.WriteLine("Opponent played Gun");
                                OpponentCharge -= 2;
                                OpponentElement = "Gun";
                                break;

                        }
                        break;
                    case 5:
                        OpponentChargeR = Opponent.Next(1, 6);
                        switch (OpponentChargeR)
                        {
                            case 1:
                                Console.WriteLine("Opponent played Charge");
                                OpponentElement = "Charges";
                                Game = true;
                                break;
                            case 2:
                                if (PlayerCharge == 1 || PlayerCharge == 0 || PlayerCharge < 3)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Surrender");
                                OpponentElement = "Surrender";
                                Game = true;
                                break;
                            case 3:
                                if (PlayerCharge < 2 || PlayerCharge < 3)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Mirror");
                                OpponentCharge -= 3;
                                OpponentElement = "Mirror";
                                break;
                            case 4:
                                if (PlayerCharge < 3)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Gun");
                                OpponentCharge -= 2;
                                OpponentElement = "Gun";
                                break;
                            case 5:
                                Console.WriteLine("Opponent played Kamehameha");
                                OpponentCharge -= 5;
                                OpponentElement = "Kamehameha";
                                break;
                        }
                        break;
                    case 6:
                        OpponentChargeR = Opponent.Next(1, 6);
                        switch (OpponentChargeR)
                        {
                            case 1:
                                Console.WriteLine("Opponent played Charge");
                                OpponentElement = "Charges";
                                Game = true;
                                break;
                            case 2:
                                if (PlayerCharge == 1 || PlayerCharge == 0)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Surrender");
                                OpponentElement = "Surrender";
                                Game = true;
                                break;
                            case 3:
                                if (PlayerCharge < 2 || PlayerCharge < 3)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Mirror");
                                OpponentCharge -= 3;
                                OpponentElement = "Mirror";
                                break;
                            case 4:
                                Console.WriteLine("Opponent played Kamehameha");
                                OpponentCharge -= 5;
                                OpponentElement = "Kamehameha";
                                break;
                            case 5:
                                Console.WriteLine("Opponent played Kamehameha");
                                OpponentCharge -= 5;
                                OpponentElement = "Kamehameha";
                                break;
                        }
                        break;
                    case 7:
                        OpponentChargeR = Opponent.Next(1, 6);
                        switch (OpponentChargeR)
                        {
                            case 1:
                                Console.WriteLine("Opponent played Charge");
                                OpponentElement = "Charges";
                                Game = true;
                                break;
                            case 2:
                                if (PlayerCharge == 1 || PlayerCharge == 0)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Surrender");
                                OpponentElement = "Surrender";
                                Game = true;
                                break;
                            case 3:
                                if (PlayerCharge < 2)
                                {
                                    goto TryAgain;
                                }
                                Console.WriteLine("Opponent played Mirror");
                                OpponentCharge -= 3;
                                OpponentElement = "Mirror";
                                break;
                            case 4:
                                Console.WriteLine("Opponent played Kamehameha");
                                OpponentCharge -= 5;
                                OpponentElement = "Kamehameha";
                                break;
                            case 5:
                                Console.WriteLine("Opponent played Kamehameha");
                                OpponentCharge -= 5;
                                OpponentElement = "Kamehameha";
                                break;
                        }
                        break;
                    case 8:
                        OpponentCharge -= 8;
                        OpponentElement = "Nuclear Bomb";
                        Console.WriteLine("Opponent played Nuclear Bomb");
                        break;
                }
            }
            Thread.Sleep(500);
            Console.Clear();
            playerVSbotGame(roundNum, PlayerCharge, OpponentCharge);
            ChargeBar(PlayerCharge, OpponentCharge);
            if (PlayerElement == "Charges" && OpponentElement == "Charges") { bothCharge(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); bothCharge1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); bothCharge2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); bothCharge3(); } // charge  charge
            if (PlayerElement == "Surrender" && OpponentElement == "Charges") { playerTwoCharge(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoCharge1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoCharge2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoCharge3(); } //p1 surrender p2 charge
            if (PlayerElement == "Charges" && OpponentElement == "Surrender") { playerOneCharge(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneCharge1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneCharge2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneCharge3(); } // charge  surrender

            if (PlayerElement == "Surrender" && OpponentElement == "Surrender") { bothSurrender(); } //both surrender
            if (PlayerElement == "Gun" && OpponentElement == "Gun") { bothGun(); } //both gun
            if (PlayerElement == "Gun" && OpponentElement == "Surrender") { playerOneGun(); } // p1 gun p2 surrender

            if (PlayerElement == "Surrender" && OpponentElement == "Gun") { playerTwoGun(); } //p1 surrender p2 gun
            if (PlayerElement == "Gun" && OpponentElement == "Charges") { playerOneKillsWGun(); } //p1 gun p2 charge
            if (PlayerElement == "Charges" && OpponentElement == "Gun") { playerTwoKillsWGun(); } //p1 charge p2 gun

            if (PlayerElement == "Kamehameha" && OpponentElement == "Surrender") { playerOneKame(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame3(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame5(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame6(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame8(); } //p1 kame p2 surrender
            if (PlayerElement == "Kamehameha" && OpponentElement == "Charges") { kameCharge(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameCharge1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameCharge2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameCharge3(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameCharge4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameCharge5(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameCharge6(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameCharge7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameCharge8(); } //p1 kame p2 charge
            if (PlayerElement == "Kamehameha" && OpponentElement == "Mirror") { playerOneKame(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame3(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameNMirror(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameNMirror1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameNMirror2(); } //p1 kame p2 mirror

            if (PlayerElement == "Gun" && OpponentElement == "Mirror") { gunNMirror(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); gunNMirror1(); } //p1 gun p2 mirror
            if (PlayerElement == "Nuclear Bomb" && OpponentElement == "Charges") { playerOneNuke(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); ; playerOneNuke3(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke5(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke6(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); Thread.Sleep(500); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); }  //p1 nuke
            if (PlayerElement == "Mirror" && OpponentElement == "Kamehameha") { playerTwoKame(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame3(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); mirrorNKame(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); mirrorNKame1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); mirrorNKame2(); } //p1 mirror p2 kame

            if (PlayerElement == "Surrender" && OpponentElement == "Kamehameha") { playerTwoKame(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame3(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame5(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame6(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame8(); } //p1 kame p2 surrender
            if (PlayerElement == "Charges" && OpponentElement == "Kamehameha") { chargeKame(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeKame1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeKame2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeKame3(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeKame4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeKame5(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeKame6(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeKame7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeKame8(); } //p1 charge p2 kame
            if (PlayerElement == "Mirror" && OpponentElement == "Gun") { mirrorNGun(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); mirrorNGun1(); } //p1 mirror p2 gun

            if (PlayerElement == "Charges" && OpponentElement == "Nuclear Bomb") { playerTwoNuke(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); ; playerTwoNuke3(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke5(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke6(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); Thread.Sleep(500); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); }  //p2 nuke
            if (PlayerElement == "Mirror" && OpponentElement == "Mirror") { bothMirror(); } //both mirror
            if (PlayerElement == "Nuclear Bomb" && OpponentElement == "Nuclear Bomb") { bothNuke(); } //both nuke

            if (PlayerElement == "Kamehameha" && OpponentElement == "Kamehameha") { bothKame(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); bothKame1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); bothKame2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); bothKame3(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); bothKame4(); }//both kame
            if (PlayerElement == "Gun" && OpponentElement == "Kamehameha") { gunNKame(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); gunNKame1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); gunNKame2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); gunNKame3(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); gunNKame4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); gunNKame5(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame6(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoKame8(); }//p1 gun p2 kame
            if (PlayerElement == "Kamehameha" && OpponentElement == "Gun") { kameNGun(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameNGun1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameNGun2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameNGun3(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameNGun4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); kameNGun5(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame6(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneKame8(); }//p1 kame p2 gun

            if (PlayerElement == "Charges" && OpponentElement == "Mirror") { chargeNMirror(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeNMirror1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeNMirror2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); chargeNMirror3(); }//p1 charge p2 mirror
            if (PlayerElement == "Mirror" && OpponentElement == "Surrender") { mirrorNSurrender(); }//p1 mirror p2 surrender
            if (PlayerElement == "Mirror" && OpponentElement == "Charges") { mirrorNCharge(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); mirrorNCharge1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); mirrorNCharge2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); mirrorNCharge3(); }//p1 mirror p2 charge

            if (PlayerElement == "Surrender" && OpponentElement == "Mirror") { surrenderNMirror(); }//p1 surrender p2 mirror
            if (PlayerElement == "Nuclear Bomb" && OpponentElement == "Surrender") { playerOneNuke(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); ; playerOneNuke3(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke5(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke6(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); Thread.Sleep(500); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); }
            if (PlayerElement == "Nuclear Bomb" && OpponentElement == "Mirror") { playerOneNuke(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); ; playerOneNuke3(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke5(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke6(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); Thread.Sleep(500); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); }

            if (PlayerElement == "Nuclear Bomb" && OpponentElement == "Gun") { playerOneNuke(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); ; playerOneNuke3(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke5(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke6(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); Thread.Sleep(500); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); }
            if (PlayerElement == "Nuclear Bomb" && OpponentElement == "Kamehameha") { playerOneNuke(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); ; playerOneNuke3(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke5(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke6(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); Thread.Sleep(500); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); }
            if (PlayerElement == "Surrender" && OpponentElement == "Nuclear Bomb") { playerTwoNuke(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); ; playerTwoNuke3(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke5(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke6(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); Thread.Sleep(500); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); }  //p2 nuke

            if (PlayerElement == "Mirror" && OpponentElement == "Nuclear Bomb") { playerTwoNuke(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); ; playerTwoNuke3(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke5(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke6(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); Thread.Sleep(500); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); }  //p2 nuke
            if (PlayerElement == "Kamehameha" && OpponentElement == "Nuclear Bomb") { playerTwoNuke(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke1(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke2(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); ; playerTwoNuke3(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke4(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke5(); Thread.Sleep(500); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke6(); Console.Clear(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerTwoNuke7(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); Thread.Sleep(500); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke9(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke10(); Thread.Sleep(500); Console.Clear(); playerVSbotGame(roundNum, PlayerCharge, OpponentCharge); ChargeBar(PlayerCharge, OpponentCharge); playerOneNuke8(); }  //p2 nuke

            if (OpponentElement == "Charges") { OpponentCharge++; }
            if (PlayerElement == "Charges") { PlayerCharge++; }

            if (PlayerElement == "Charges" && OpponentElement == "Charges" ||
                 PlayerElement == "Charges" && OpponentElement == "Surrender" ||
                 PlayerElement == "Charges" && OpponentElement == "Mirror" ||
                 PlayerElement == "Surrender" && OpponentElement == "Charges" ||
                 PlayerElement == "Surrender" && OpponentElement == "Surrender" ||
                 PlayerElement == "Surrender" && OpponentElement == "Mirror" ||
                 PlayerElement == "Mirror" && OpponentElement == "Charges" ||
                 PlayerElement == "Mirror" && OpponentElement == "Surrender" ||
                 PlayerElement == "Mirror" && OpponentElement == "Mirror" ||
                 PlayerElement == "Gun" && OpponentElement == "Gun" ||
                PlayerElement == "Surrender" && OpponentElement == "Gun" ||
                PlayerElement == "Gun" && OpponentElement == "Surrender" ||
                PlayerElement == "Kamehameha" && OpponentElement == "Kamehameha")
            {
                Thread.Sleep(500);
                roundNum++;
                if (OpponentCharge == 0 && PlayerCharge == 0)
                {
                    PlayerCharge = 2;
                    OpponentCharge = 2;
                }
            }
            else if (PlayerElement == "Gun" && OpponentElement == "Charges" ||
                    PlayerElement == "Mirror" && OpponentElement == "Gun" ||
                    PlayerElement == "Mirror" && OpponentElement == "Kamehameha" ||
                    PlayerElement == "Kamehameha" && OpponentElement == "Charges" ||
                    PlayerElement == "Kamehameha" && OpponentElement == "Surrender" ||
                    PlayerElement == "Kamehameha" && OpponentElement == "Gun" ||
                    PlayerElement == "Nuclear Bomb" && OpponentElement == "Charges" ||
                    PlayerElement == "Nuclear Bomb" && OpponentElement == "Surrender" ||
                    PlayerElement == "Nuclear Bomb" && OpponentElement == "Mirror" ||
                    PlayerElement == "Nuclear Bomb" && OpponentElement == "Gun" ||
                    PlayerElement == "Nuclear Bomb" && OpponentElement == "Kamehameha")
            {
                Thread.Sleep(500);
                Console.WriteLine("\nGame Over");
                Thread.Sleep(1000);
                Console.WriteLine("You Won!");
                Thread.Sleep(1000);
                Console.Write("\nPlay again? [Y/N]");
                Thread.Sleep(1000);
                ConsoleKeyInfo playAgainChoice2 = Console.ReadKey(true);


                switch (playAgainChoice2.Key)
                {
                    case ConsoleKey.Y:
                        Console.Clear();
                        OpponentCharge = 2;
                        PlayerCharge = 2;
                        roundNum = 1;
                        goto MyLabel;
                    default:
                        Console.Clear();
                        Main();
                        break;
                }
            }
            else
            {
                Thread.Sleep(500);
                Console.WriteLine("\nGame Over");
                Thread.Sleep(1000);
                Console.WriteLine("You Lost");
                Thread.Sleep(1000);
                Console.Write("\nPlay again? [Y/N]");
                ConsoleKeyInfo playAgainChoice2 = Console.ReadKey(true);

                switch (playAgainChoice2.Key)
                {
                    case ConsoleKey.Y:
                        Console.Clear();
                        OpponentCharge = 2;
                        PlayerCharge = 2;
                        roundNum = 1;
                        goto MyLabel;
                    default:
                        Console.Clear();
                        Main();
                        break;
                }
            }
        }
    }
    static void playerVSbotGame(int round, int PlayerCharge, int OpponentCharge)
    {
        Console.WriteLine(" == Press Esc to Pause ==");
        Console.WriteLine($"\n                                              == Round {round} ==");
        Console.WriteLine("\n                                             Player Controls:");
        Console.WriteLine("                                  Charge [Q], Surrender [W], Mirror [E]");
        Console.WriteLine("                                Gun [A], Kamehameha [S], Nuclear Bomb [D]");
        Console.WriteLine($"\n         == Player Charge Amount ==                                  == Opponent Charge Amount == ");
    }
    static void playerVSplayerGame(int player1C, int player2C, int round)
    {
        Console.WriteLine(" == Press Esc to Pause == ");
        Console.WriteLine($"\n                                                == Round {round} ==");
        Console.WriteLine("\n                 Player 1 Controls:                                         Player 2 Controls:");
        Console.WriteLine("       Charge [Q], Surrender [W], Mirror [E]                      Charge [I], Surrender [O], Mirror [P]");
        Console.WriteLine("     Gun [A], Kamehameha [S], Nuclear Bomb [D]                  Gun [J], Kamehameha [K], Nuclear Bomb [L]");
        Console.WriteLine($"\n          == Player 1 Charge Amount ==                                == Player 2 Charge Amount ==");
    }

    static void Escape()
    {
        bool PMenu = true;
        int Pause = 0;
        while (PMenu)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"
  ██████   █████  ██    ██ ███████ ███████ ██████  
  ██   ██ ██   ██ ██    ██ ██      ██      ██   ██ 
  ██████  ███████ ██    ██ ███████ █████   ██   ██ 
  ██      ██   ██ ██    ██      ██ ██      ██   ██ 
  ██      ██   ██  ██████  ███████ ███████ ██████");
            Console.WriteLine("\n\n");
            switch (Pause)
            {
                case 0: Console.WriteLine(@"
   ╔═╗╔═╗╔╗╔╔╦╗╦╔╗╔╦ ╦╔═╗         
   ║  ║ ║║║║ ║ ║║║║║ ║║╣          
   ╚═╝╚═╝╝╚╝ ╩ ╩╝╚╝╚═╝╚═╝

┬ ┬┌─┐┬ ┬  ┌┬┐┌─┐  ┌─┐┬  ┌─┐┬ ┬
├─┤│ ││││   │ │ │  ├─┘│  ├─┤└┬┘
┴ ┴└─┘└┴┘   ┴ └─┘  ┴  ┴─┘┴ ┴ ┴ 

┌┬┐┌─┐┌┐┌┬ ┬                   
│││├┤ ││││ │                   
┴ ┴└─┘┘└┘└─┘"); break;
                case 1: Console.WriteLine(@"
┌─┐┌─┐┌┐┌┌┬┐┬┌┐┌┬ ┬┌─┐         
│  │ ││││ │ │││││ │├┤          
└─┘└─┘┘└┘ ┴ ┴┘└┘└─┘└─┘

   ╦ ╦╔═╗╦ ╦  ╔╦╗╔═╗  ╔═╗╦  ╔═╗╦ ╦
   ╠═╣║ ║║║║   ║ ║ ║  ╠═╝║  ╠═╣╚╦╝
   ╩ ╩╚═╝╚╩╝   ╩ ╚═╝  ╩  ╩═╝╩ ╩ ╩ 

┌┬┐┌─┐┌┐┌┬ ┬                   
│││├┤ ││││ │                   
┴ ┴└─┘┘└┘└─┘                   
"); break;
                case 2: Console.WriteLine(@"
┌─┐┌─┐┌┐┌┌┬┐┬┌┐┌┬ ┬┌─┐         
│  │ ││││ │ │││││ │├┤          
└─┘└─┘┘└┘ ┴ ┴┘└┘└─┘└─┘  

┬ ┬┌─┐┬ ┬  ┌┬┐┌─┐  ┌─┐┬  ┌─┐┬ ┬
├─┤│ ││││   │ │ │  ├─┘│  ├─┤└┬┘
┴ ┴└─┘└┴┘   ┴ └─┘  ┴  ┴─┘┴ ┴ ┴ 

   ╔╦╗╔═╗╔╗╔╦ ╦                   
   ║║║║╣ ║║║║ ║                   
   ╩ ╩╚═╝╝╚╝╚═╝"); break;
            }
            ConsoleKey Select = Console.ReadKey(true).Key;
            if (Select == ConsoleKey.DownArrow || Select == ConsoleKey.S)
            {
                Pause++;
                if (Pause == 3)
                {
                    Pause--;
                }
            }
            else if (Select == ConsoleKey.UpArrow || Select == ConsoleKey.W)
            {
                Pause--;
                if (Pause == -1)
                {
                    Pause++;
                }
            }
            else if (Select == ConsoleKey.Enter)
            {
                switch (Pause)
                {
                    case 0: Console.WriteLine(); break;
                    case 1: DisplayHowToPlay(); break;
                    case 2: Main(); break;
                }
                PMenu = false;
            }
        }
    }
    static void ChargeBar(int p1, int p2)
    {
        if (p1 == 2 && p2 == 2)
        {
            Console.WriteLine("     ███ ███                                                     ███ ███");
            Console.WriteLine("     ███ ███                                                     ███ ███");
        }
        else if (p1 == 2 && p2 == 3)
        {
            Console.WriteLine("     ███ ███                                                     ███ ███ ███");
            Console.WriteLine("     ███ ███                                                     ███ ███ ███");
        }
        else if (p1 == 2 && p2 == 4)
        {
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███");
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███");
        }
        else if (p1 == 2 && p2 == 5)
        {
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███");
        }
        else if (p1 == 2 && p2 == 6)
        {
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 2 && p2 == 7)
        {
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 2 && p2 == 8)
        {
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 2 && p2 == 9)
        {
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 2 && p2 == 10)
        {
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███                                                     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 3 && p2 == 2)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███ ███");
            Console.WriteLine("     ███ ███ ███                                                 ███ ███");
        }
        else if (p1 == 4 && p2 == 2)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███");
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███");
        }
        else if (p1 == 5 && p2 == 2)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███");
        }
        else if (p1 == 6 && p2 == 2)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███");
        }
        else if (p1 == 7 && p2 == 2)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███");
        }
        else if (p1 == 8 && p2 == 2)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███");
        }
        else if (p1 == 9 && p2 == 2)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███");
        }
        else if (p1 == 10 && p2 == 2)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███");
        }
        else if (p1 == 1 && p2 == 1)
        {
            Console.WriteLine("     ███                                                         ███                         ");
            Console.WriteLine("     ███                                                         ███                         ");
        }
        else if (p1 == 2 && p2 == 1)
        {
            Console.WriteLine("     ███ ███                                                     ███                         ");
            Console.WriteLine("     ███ ███                                                     ███                         ");
        }
        else if (p1 == 3 && p2 == 1)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███                         ");
            Console.WriteLine("     ███ ███ ███                                                 ███                         ");
        }
        else if (p1 == 4 && p2 == 1)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███                         ");
            Console.WriteLine("     ███ ███ ███ ███                                             ███                         ");
        }
        else if (p1 == 5 && p2 == 1)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███                         ");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███                         ");
        }
        else if (p1 == 6 && p2 == 1)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███                         ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███                         ");
        }
        else if (p1 == 7 && p2 == 1)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███                         ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███                         ");
        }
        else if (p1 == 8 && p2 == 1)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███                         ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███                         ");
        }
        else if (p1 == 9 && p2 == 1)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███                         ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███                         ");
        }
        else if (p1 == 10 && p2 == 1)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███                         ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███                         ");
        }
        else if (p1 == 1 && p2 == 10)
        {
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 1 && p2 == 9)
        {
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 1 && p2 == 8)
        {
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███ ███ ███ ");
        }
        else if (p1 == 1 && p2 == 7)
        {
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 1 && p2 == 6)
        {
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 1 && p2 == 5)
        {
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███");
            Console.WriteLine("     ███                                                         ███ ███ ███ ███ ███");
        }
        else if (p1 == 1 && p2 == 4)
        {
            Console.WriteLine("     ███                                                         ███ ███ ███ ███");
            Console.WriteLine("     ███                                                         ███ ███ ███ ███");
        }
        else if (p1 == 1 && p2 == 3)
        {
            Console.WriteLine("     ███                                                         ███ ███ ███");
            Console.WriteLine("     ███                                                         ███ ███ ███");
        }
        else if (p1 == 1 && p2 == 2)
        {
            Console.WriteLine("     ███                                                         ███ ███");
            Console.WriteLine("     ███                                                         ███ ███");
        }
        else if (p1 == 3 && p2 == 3)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███");
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███");
        }
        else if (p1 == 4 && p2 == 3)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███");
        }
        else if (p1 == 5 && p2 == 3)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███");
        }
        else if (p1 == 6 && p2 == 3)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███");
        }
        else if (p1 == 7 && p2 == 3)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███");
        }
        else if (p1 == 8 && p2 == 3)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███");
        }
        else if (p1 == 9 && p2 == 3)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███");
        }
        else if (p1 == 10 && p2 == 3)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███");
        }
        else if (p1 == 3 && p2 == 4)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███");
        }
        else if (p1 == 3 && p2 == 5)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███");
        }
        else if (p1 == 3 && p2 == 6)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 3 && p2 == 7)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 3 && p2 == 8)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 3 && p2 == 9)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 3 && p2 == 10)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███                                                 ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }

        else if (p1 == 4 && p2 == 4)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███");
        }
        else if (p1 == 4 && p2 == 5)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███");
        }
        else if (p1 == 4 && p2 == 6)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 4 && p2 == 7)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 4 && p2 == 8)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 4 && p2 == 9)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 4 && p2 == 10)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███                                             ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 5 && p2 == 4)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███");
        }
        else if (p1 == 6 && p2 == 4)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███");
        }
        else if (p1 == 7 && p2 == 4)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███");
        }
        else if (p1 == 8 && p2 == 4)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███");
        }
        else if (p1 == 9 && p2 == 4)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███");
        }
        else if (p1 == 10 && p2 == 4)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███");
        }

        else if (p1 == 5 && p2 == 5)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███");
        }
        else if (p1 == 6 && p2 == 5)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███");
        }
        else if (p1 == 7 && p2 == 5)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███");
        }
        else if (p1 == 8 && p2 == 5)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███");
        }
        else if (p1 == 9 && p2 == 5)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███");
        }
        else if (p1 == 10 && p2 == 5)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███");
        }
        else if (p1 == 5 && p2 == 6)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 5 && p2 == 7)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 5 && p2 == 8)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 5 && p2 == 9)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 5 && p2 == 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }

        else if (p1 == 6 && p2 == 6)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 7 && p2 == 6)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 8 && p2 == 6)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 9 && p2 == 6)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 10 && p2 == 6)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 6 && p2 == 7)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 6 && p2 == 8)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 6 && p2 == 9)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 6 && p2 == 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }

        else if (p1 == 7 && p2 == 7)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 8 && p2 == 7)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 9 && p2 == 7)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 10 && p2 == 7)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 7 && p2 == 8)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 7 && p2 == 9)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 7 && p2 == 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }

        else if (p1 == 8 && p2 == 8)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 9 && p2 == 8)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 10 && p2 == 8)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 8 && p2 == 9)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 8 && p2 == 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }

        else if (p1 == 9 && p2 == 9)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 10 && p2 == 9)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 9 && p2 == 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 10 && p2 == 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 > 10 && p2 > 10)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███████████████████████████████████████");
            Console.WriteLine("     ███████████████████████████████████████                     ███████████████████████████████████████");
        }
        else if (p1 == 10 && p2 > 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███████████████████████████████████████");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ███████████████████████████████████████");
        }
        else if (p1 == 9 && p2 > 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███████████████████████████████████████");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                         ███████████████████████████████████████");
        }
        else if (p1 == 8 && p2 > 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███████████████████████████████████████");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                             ███████████████████████████████████████");
        }
        else if (p1 == 7 && p2 > 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███████████████████████████████████████");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                                 ███████████████████████████████████████");
        }
        else if (p1 == 6 && p2 > 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███████████████████████████████████████");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                                     ███████████████████████████████████████");
        }
        else if (p1 == 5 && p2 > 10)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███████████████████████████████████████");
            Console.WriteLine("     ███ ███ ███ ███ ███                                         ███████████████████████████████████████");
        }
        else if (p1 == 4 && p2 > 10)
        {
            Console.WriteLine("     ███ ███ ███ ███                                             ███████████████████████████████████████");
            Console.WriteLine("     ███ ███ ███ ███                                             ███████████████████████████████████████");
        }
        else if (p1 == 3 && p2 > 10)
        {
            Console.WriteLine("     ███ ███ ███                                                 ███████████████████████████████████████");
            Console.WriteLine("     ███ ███ ███                                                 ███████████████████████████████████████");
        }
        else if (p1 == 2 && p2 > 10)
        {
            Console.WriteLine("     ███ ███                                                     ███████████████████████████████████████");
            Console.WriteLine("     ███ ███                                                     ███████████████████████████████████████");
        }
        else if (p1 == 1 && p2 > 10)
        {
            Console.WriteLine("     ███                                                         ███████████████████████████████████████");
            Console.WriteLine("     ███                                                         ███████████████████████████████████████");
        }
        else if (p1 == 0 && p2 > 10)
        {
            Console.WriteLine("                                                                 ███████████████████████████████████████");
            Console.WriteLine("                                                                 ███████████████████████████████████████");
        }
        else if (p1 > 10 && p2 == 10)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 > 10 && p2 == 9)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 > 10 && p2 == 8)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 > 10 && p2 == 7)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 > 10 && p2 == 6)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███ ███");
        }
        else if (p1 > 10 && p2 == 5)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███ ███");
        }
        else if (p1 > 10 && p2 == 4)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███ ███");
        }
        else if (p1 > 10 && p2 == 3)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███ ███");
        }
        else if (p1 > 10 && p2 == 2)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███ ███");
        }
        else if (p1 > 10 && p2 == 1)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ███");
            Console.WriteLine("     ███████████████████████████████████████                     ███");
        }
        else if (p1 > 10 && p2 == 0)
        {
            Console.WriteLine("     ███████████████████████████████████████                     ");
            Console.WriteLine("     ███████████████████████████████████████                     ");
        }

        else if (p1 == 0 && p2 == 0)
        {
            Console.WriteLine("                          ");
            Console.WriteLine("                          ");
        }
        else if (p1 == 1 && p2 == 0)
        {
            Console.WriteLine("     ███                      ");
            Console.WriteLine("     ███                     ");
        }
        else if (p1 == 2 && p2 == 0)
        {
            Console.WriteLine("     ███ ███                     ");
            Console.WriteLine("     ███ ███                     ");
        }
        else if (p1 == 3 && p2 == 0)
        {
            Console.WriteLine("     ███ ███ ███                     ");
            Console.WriteLine("     ███ ███ ███                     ");
        }
        else if (p1 == 4 && p2 == 0)
        {
            Console.WriteLine("     ███ ███ ███ ███                     ");
            Console.WriteLine("     ███ ███ ███ ███                     ");
        }
        else if (p1 == 5 && p2 == 0)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███                     ");
            Console.WriteLine("     ███ ███ ███ ███ ███                     ");
        }
        else if (p1 == 6 && p2 == 0)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                     ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███                     ");
        }
        else if (p1 == 7 && p2 == 0)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                     ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███                     ");
        }
        else if (p1 == 8 && p2 == 0)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                     ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███                     ");
        }
        else if (p1 == 9 && p2 == 0)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                     ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███                     ");
        }
        else if (p1 == 10 && p2 == 0)
        {
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ");
            Console.WriteLine("     ███ ███ ███ ███ ███ ███ ███ ███ ███ ███                     ");
        }
        else if (p1 == 0 && p2 == 1)
        {
            Console.WriteLine("                                                                 ███");
            Console.WriteLine("                                                                 ███");
        }
        else if (p1 == 0 && p2 == 2)
        {
            Console.WriteLine("                                                                 ███ ███");
            Console.WriteLine("                                                                 ███ ███");
        }
        else if (p1 == 0 && p2 == 3)
        {
            Console.WriteLine("                                                                 ███ ███ ███");
            Console.WriteLine("                                                                 ███ ███ ███");
        }
        else if (p1 == 0 && p2 == 4)
        {
            Console.WriteLine("                                                                 ███ ███ ███ ███");
            Console.WriteLine("                                                                 ███ ███ ███ ███");
        }
        else if (p1 == 0 && p2 == 5)
        {
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███");
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███");
        }
        else if (p1 == 0 && p2 == 6)
        {
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███");
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 0 && p2 == 7)
        {
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 0 && p2 == 8)
        {
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 0 && p2 == 9)
        {
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
        else if (p1 == 0 && p2 == 10)
        {
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
            Console.WriteLine("                                                                 ███ ███ ███ ███ ███ ███ ███ ███ ███ ███");
        }
    }
}

