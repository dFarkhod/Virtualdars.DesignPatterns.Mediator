﻿using Virtualdars.DesignPatterns.Mediator;

var tgGroup = new TelegramGroupMediator();
var abror = new User(tgGroup, "Abror");
var ahmad = new User(tgGroup, "Ahmad");
var akmal = new User(tgGroup, "Akmal");
var anvar = new User(tgGroup, "Anvar");
var botir = new User(tgGroup, "Botir");
var ibrohim = new User(tgGroup, "Ibrohim");
var kamol = new User(tgGroup, "Kamol");
var tohir = new User(tgGroup, "Tohir");
tgGroup.RegisterUser(anvar);
tgGroup.RegisterUser(abror);
tgGroup.RegisterUser(akmal);
tgGroup.RegisterUser(botir);
tgGroup.RegisterUser(ibrohim);
tgGroup.RegisterUser(kamol);
tgGroup.RegisterUser(ahmad);
tgGroup.RegisterUser(tohir);
abror.Send("Assalomu alaykum!");
Console.WriteLine();
botir.Send("Waalaykum assalom!", abror);
Console.Read();