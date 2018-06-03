using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMvcApp.Models
{
    public class Excitement
    {
        public string Treatment { get; set; }
        public string Sniff { get; set; }
        public string Constraint { get; set; }
        public string Trouble { get; set; }
        public string Mail { get; set; }
        public string Juice { get; set; }
        public string InnerText { get; set; }

        public Excitement(string treatment, string sniff, string constraint, string trouble, string mail, string juice, string innerText)
        {
            this.Treatment = treatment;
            this.Sniff = sniff;
            this.Constraint = constraint;
            this.Trouble = trouble;
            this.Mail = mail;
            this.Juice = juice;
            this.InnerText = innerText;
        }
    }

    public class Flower
    {
        public string Submit { get; set; }
        public string Opposite { get; set; }
        public string Wilderness { get; set; }
        public string Transport { get; set; }
        public string Circumstance { get; set; }
        public string InnerText { get; set; }

        public Flower(string submit, string opposite, string wilderness, string transport, string circumstance, string innerText)
        {
            this.Submit = submit;
            this.Opposite = opposite;
            this.Wilderness = wilderness;
            this.Transport = transport;
            this.Circumstance = circumstance;
            this.InnerText = innerText;
        }
    }

    public class Ambiguity
    {
        public string Writer { get; set; }
        public string Activity { get; set; }
        public string Lead { get; set; }
        public string InnerText { get; set; }

        public Ambiguity(string writer, string activity, string lead, string innerText)
        {
            this.Writer = writer;
            this.Activity = activity;
            this.Lead = lead;
            this.InnerText = innerText;
        }
    }

    public class Seasonal
    {
        public string InnerText { get; set; }

        public Seasonal(string innerText)
        {
            this.InnerText = innerText;
        }
    }

    public class Bloody
    {
        public string Left { get; set; }
        public string Awful { get; set; }
        public string Coincidence { get; set; }
        public string Tape { get; set; }
        public string Expertise { get; set; }
        public string Good { get; set; }
        public string InnerText { get; set; }

        public Bloody(string left, string awful, string coincidence, string tape, string expertise, string good, string innerText)
        {
            this.Left = left;
            this.Awful = awful;
            this.Coincidence = coincidence;
            this.Tape = tape;
            this.Expertise = expertise;
            this.Good = good;
            this.InnerText = innerText;
        }
    }

    public class Code
    {
        public string Patch { get; set; }
        public string Animal { get; set; }
        public string Cell { get; set; }
        public string Owner { get; set; }
        public string Audience { get; set; }
        public string InnerText { get; set; }

        public Code(string patch, string animal, string cell, string owner, string audience, string innerText)
        {
            this.Patch = patch;
            this.Animal = animal;
            this.Cell = cell;
            this.Owner = owner;
            this.Audience = audience;
            this.InnerText = innerText;
        }
    }

    public class Compensate
    {
        public string InnerText { get; set; }

        public Compensate(string innerText)
        {
            this.InnerText = innerText;
        }
    }

    public class Bowl
    {
        public string InnerText { get; set; }

        public Bowl(string innerText)
        {
            this.InnerText = innerText;
        }
    }

    public class Step
    {
        public string Affect { get; set; }
        public string Sell { get; set; }
        public string Prince { get; set; }
        public string Current { get; set; }
        public string Discuss { get; set; }
        public string Still { get; set; }
        public List<Excitement> ListOfExcitements { get; set; }

        public Step(string affect, string sell, string prince, string current, string discuss, string still, List<Excitement> listOfExcitements)
        {
            this.Affect = affect;
            this.Sell = sell;
            this.Prince = prince;
            this.Current = current;
            this.Discuss = discuss;
            this.Still = still;
            this.ListOfExcitements = listOfExcitements;
        }
    }

    public class Chemistry
    {
        public string Limited { get; set; }
        public List<Flower> ListOfFlowers { get; set; }

        public Chemistry(string limited, List<Flower> listOfFlowers)
        {
            this.Limited = limited;
            this.ListOfFlowers = listOfFlowers;
        }
    }

    public class Folk
    {
        public string Divide { get; set; }
        public string Muscle { get; set; }
        public string Devote { get; set; }
        public string Position { get; set; }
        public string Call { get; set; }
        public List<Ambiguity> ListOfAmbiguities { get; set; }

        public Folk(string divide, string muscle, string devote, string position, string call, List<Ambiguity> listOfAmbiguities)
        {
            this.Divide = divide;
            this.Muscle = muscle;
            this.Devote = devote;
            this.Position = position;
            this.Call = call;
            this.ListOfAmbiguities = listOfAmbiguities;
        }
    }

    public class Association
    {
        public string Thin { get; set; }
        public string Adult { get; set; }
        public string Lazy { get; set; }
        public string Rain { get; set; }
        public List<Seasonal> ListOfSeasonals { get; set; }

        public Association(string thin, string adult, string lazy, string rain, List<Seasonal> listOfSeasonals)
        {
            this.Thin = thin;
            this.Adult = adult;
            this.Lazy = lazy;
            this.Rain = rain;
            this.ListOfSeasonals = listOfSeasonals;
        }
    }

    public class Choke
    {
        public string Strike { get; set; }
        public string Punch { get; set; }
        public string Disguise { get; set; }
        public string Radical { get; set; }
        public string Protein { get; set; }
        public List<Bloody> ListOfBloodies { get; set; }

        public Choke(string strike, string punch, string disguise, string radical, string protein, List<Bloody> listOfBloodies)
        {
            this.Strike = strike;
            this.Punch = punch;
            this.Disguise = disguise;
            this.Radical = radical;
            this.Protein = protein;
            this.ListOfBloodies = listOfBloodies;
        }
    }

    public class Bible
    {
        public List<Code> ListOfCodes { get; set; }

        public Bible(List<Code> listOfCodes)
        {
            this.ListOfCodes = listOfCodes;
        }
    }

    public class Pudding
    {
        public List<Compensate> ListOfCompensates { get; set; }

        public Pudding(List<Compensate> listOfCompensates)
        {
            this.ListOfCompensates = listOfCompensates;
        }
    }

    public class Line
    {
        public List<Bowl> ListOfBowls { get; set; }

        public Line(List<Bowl> listOfBowls)
        {
            this.ListOfBowls = listOfBowls;
        }
    }

    public class Sodium
    {
        public string Prove { get; set; }
        public string Skin { get; set; }
        public string Philosophy { get; set; }
        public string Leftovers { get; set; }
        public string Oil { get; set; }
        public string Horse { get; set; }
        public string Riot { get; set; }
        public List<Step> ListOfSteps { get; set; }

        public Sodium(string prove, string skin, string philosophy, string leftovers, string oil, string horse, string riot, List<Step> listOfSteps)
        {
            this.Prove = prove;
            this.Skin = skin;
            this.Philosophy = philosophy;
            this.Leftovers = leftovers;
            this.Oil = oil;
            this.Horse = horse;
            this.Riot = riot;
            this.ListOfSteps = listOfSteps;
        }
    }

    public class Overall
    {
        public string Moment { get; set; }
        public string Audience { get; set; }
        public string Glass { get; set; }
        public string Dragon { get; set; }
        public string Tape { get; set; }
        public string Carbon { get; set; }
        public string Servant { get; set; }
        public List<Chemistry> ListOfChemistries { get; set; }

        public Overall(string moment, string audience, string glass, string dragon, string tape, string carbon, string servant, List<Chemistry> listOfChemistries)
        {
            this.Moment = moment;
            this.Audience = audience;
            this.Glass = glass;
            this.Dragon = dragon;
            this.Tape = tape;
            this.Carbon = carbon;
            this.Servant = servant;
            this.ListOfChemistries = listOfChemistries;
        }
    }

    public class Ring
    {
        public string Spirit { get; set; }
        public string Mist { get; set; }
        public string Submit { get; set; }
        public string Unit { get; set; }
        public string Worker { get; set; }
        public string Offence { get; set; }
        public string Echo { get; set; }
        public List<Folk> ListOfFolks { get; set; }

        public Ring(string spirit, string mist, string submit, string unit, string worker, string offence, string echo, List<Folk> listOfFolks)
        {
            this.Spirit = spirit;
            this.Mist = mist;
            this.Submit = submit;
            this.Unit = unit;
            this.Worker = worker;
            this.Offence = offence;
            this.Echo = echo;
            this.ListOfFolks = listOfFolks;
        }
    }

    public class Glass
    {
        public string Buy { get; set; }
        public string Violation { get; set; }
        public string World { get; set; }
        public string Letter { get; set; }
        public string Band { get; set; }
        public string Rise { get; set; }
        public List<Association> ListOfAssociations { get; set; }

        public Glass(string buy, string violation, string world, string letter, string band, string rise, List<Association> listOfAssociations)
        {
            this.Buy = buy;
            this.Violation = violation;
            this.World = world;
            this.Letter = letter;
            this.Band = band;
            this.Rise = rise;
            this.ListOfAssociations = listOfAssociations;
        }
    }

    public class Charge
    {
        public string Concrete { get; set; }
        public string Medium { get; set; }
        public string Support { get; set; }
        public string Angry { get; set; }
        public List<Choke> ListOfChokes { get; set; }

        public Charge(string concrete, string medium, string support, string angry, List<Choke> listOfChokes)
        {
            this.Concrete = concrete;
            this.Medium = medium;
            this.Support = support;
            this.Angry = angry;
            this.ListOfChokes = listOfChokes;
        }
    }

    public class Cut
    {
        public string Give { get; set; }
        public string Sentiment { get; set; }
        public string Regional { get; set; }
        public string Run { get; set; }
        public string Temple { get; set; }
        public string Treatment { get; set; }
        public List<Bible> ListOfBibles { get; set; }

        public Cut(string give, string sentiment, string regional, string run, string temple, string treatment, List<Bible> listOfBibles)
        {
            this.Give = give;
            this.Sentiment = sentiment;
            this.Regional = regional;
            this.Run = run;
            this.Temple = temple;
            this.Treatment = treatment;
            this.ListOfBibles = listOfBibles;
        }
    }

    public class Squad
    {
        public string Wait { get; set; }
        public string Activate { get; set; }
        public List<Pudding> ListOfPuddings { get; set; }

        public Squad(string wait, string activate, List<Pudding> listOfPuddings)
        {
            this.Wait = wait;
            this.Activate = activate;
            this.ListOfPuddings = listOfPuddings;
        }
    }

    public class Substitute
    {
        public string Friendship { get; set; }
        public string Imagine { get; set; }
        public string Shareholder { get; set; }
        public List<Line> ListOfLines { get; set; }

        public Substitute(string friendship, string imagine, string shareholder, List<Line> listOfLines)
        {
            this.Friendship = friendship;
            this.Imagine = imagine;
            this.Shareholder = shareholder;
            this.ListOfLines = listOfLines;
        }
    }

    public class Root
    {
        public Sodium Sodium { get; set; }
        public Overall Overall { get; set; }
        public Ring Ring { get; set; }
        public Glass Glass { get; set; }
        public Charge Charge { get; set; }
        public Cut Cut { get; set; }
        public Squad Squad { get; set; }
        public Substitute Substitute { get; set; }

        public Root(Sodium sodium, Overall overall, Ring ring, Glass glass, Charge charge, Cut cut, Squad squad, Substitute substitute)
        {
            this.Sodium = sodium;
            this.Overall = overall;
            this.Ring = ring;
            this.Glass = glass;
            this.Charge = charge;
            this.Cut = cut;
            this.Squad = squad;
            this.Substitute = substitute;
        }
    }
}