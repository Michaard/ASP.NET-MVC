using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace AspMvcApp.Models
{
    class XmlGenerator
    {
        public void Generate(string filename, Root root)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement header = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, header);

            XmlElement elRoot = doc.CreateElement("root");
            doc.AppendChild(elRoot);

            XmlElement elSodium = doc.CreateElement("sodium");

            XmlAttribute atProve = doc.CreateAttribute("prove");
            XmlAttribute atSkin = doc.CreateAttribute("skin");
            XmlAttribute atPhilosophy = doc.CreateAttribute("philosophy");
            XmlAttribute atLeftovers = doc.CreateAttribute("leftovers");
            XmlAttribute atOil = doc.CreateAttribute("oil");
            XmlAttribute atHorse = doc.CreateAttribute("horse");
            XmlAttribute atRiot = doc.CreateAttribute("riot");

            atProve.Value = root.Sodium.Prove;
            atSkin.Value = root.Sodium.Skin;
            atPhilosophy.Value = root.Sodium.Philosophy;
            atLeftovers.Value = root.Sodium.Leftovers;
            atOil.Value = root.Sodium.Oil;
            atHorse.Value = root.Sodium.Horse;
            atRiot.Value = root.Sodium.Riot;

            elSodium.Attributes.Append(atProve);
            elSodium.Attributes.Append(atSkin);
            elSodium.Attributes.Append(atPhilosophy);
            elSodium.Attributes.Append(atLeftovers);
            elSodium.Attributes.Append(atOil);
            elSodium.Attributes.Append(atHorse);
            elSodium.Attributes.Append(atRiot);

            XmlElement elStep, elExcitemenr;
            XmlAttribute atAffect, atSell, atPrince, atCurrent, atDiscuss, atStill, atTreatment, atSniff, atConstraint, atTrouble, atMail, atJuice;

            foreach (Step step in root.Sodium.ListOfSteps)
            {
                elStep = doc.CreateElement("step");
                atAffect = doc.CreateAttribute("affect");
                atSell = doc.CreateAttribute("sell");
                atPrince = doc.CreateAttribute("prince");
                atCurrent = doc.CreateAttribute("current");
                atDiscuss = doc.CreateAttribute("discuss");
                atStill = doc.CreateAttribute("still");

                atAffect.Value = step.Affect;
                atSell.Value = step.Sell;
                atPrince.Value = step.Prince;
                atCurrent.Value = step.Current;
                atDiscuss.Value = step.Discuss;
                atStill.Value = step.Still;

                elStep.Attributes.Append(atAffect);
                elStep.Attributes.Append(atSell);
                elStep.Attributes.Append(atPrince);
                elStep.Attributes.Append(atCurrent);
                elStep.Attributes.Append(atDiscuss);
                elStep.Attributes.Append(atStill);

                foreach (Excitement excitement in step.ListOfExcitements)
                {
                    elExcitemenr = doc.CreateElement("excitement");
                    atTreatment = doc.CreateAttribute("treatment");
                    atSniff = doc.CreateAttribute("sniff");
                    atConstraint = doc.CreateAttribute("constraint");
                    atTrouble = doc.CreateAttribute("trouble");
                    atMail = doc.CreateAttribute("mail");
                    atJuice = doc.CreateAttribute("juice");

                    atTreatment.Value = excitement.Treatment;
                    atSniff.Value = excitement.Sniff;
                    atConstraint.Value = excitement.Constraint;
                    atTrouble.Value = excitement.Trouble;
                    atMail.Value = excitement.Mail;
                    atJuice.Value = excitement.Juice;

                    elExcitemenr.Attributes.Append(atTreatment);
                    elExcitemenr.Attributes.Append(atSniff);
                    elExcitemenr.Attributes.Append(atConstraint);
                    elExcitemenr.Attributes.Append(atTrouble);
                    elExcitemenr.Attributes.Append(atMail);
                    elExcitemenr.Attributes.Append(atJuice);
                    elExcitemenr.InnerText = excitement.InnerText;

                    elStep.AppendChild(elExcitemenr);
                }

                elSodium.AppendChild(elStep);
            }

            elRoot.AppendChild(elSodium);

            XmlElement elOverall = doc.CreateElement("overall");

            XmlAttribute atMoment = doc.CreateAttribute("moment");
            XmlAttribute atAudience = doc.CreateAttribute("audience");
            XmlAttribute atGlass = doc.CreateAttribute("glass");
            XmlAttribute atDragon = doc.CreateAttribute("dragon");
            XmlAttribute atTape = doc.CreateAttribute("tape");
            XmlAttribute atCarbon = doc.CreateAttribute("carbon");
            XmlAttribute atServant = doc.CreateAttribute("servant");

            atMoment.Value = root.Overall.Moment;
            atAudience.Value = root.Overall.Audience;
            atGlass.Value = root.Overall.Glass;
            atDragon.Value = root.Overall.Dragon;
            atTape.Value = root.Overall.Tape;
            atCarbon.Value = root.Overall.Carbon;
            atServant.Value = root.Overall.Servant;

            elOverall.Attributes.Append(atMoment);
            elOverall.Attributes.Append(atAudience);
            elOverall.Attributes.Append(atGlass);
            elOverall.Attributes.Append(atDragon);
            elOverall.Attributes.Append(atTape);
            elOverall.Attributes.Append(atCarbon);
            elOverall.Attributes.Append(atServant);

            XmlElement elChemistry, elFlower;
            XmlAttribute atLimited, atSubmit, atOpposite, atWilderness, atTransport, atCircumstance;

            foreach (Chemistry chemistry in root.Overall.ListOfChemistries)
            {
                elChemistry = doc.CreateElement("chemistry");
                atLimited = doc.CreateAttribute("limited");

                atLimited.Value = chemistry.Limited;

                elChemistry.Attributes.Append(atLimited);

                foreach (Flower flower in chemistry.ListOfFlowers)
                {
                    elFlower = doc.CreateElement("flower");
                    atSubmit = doc.CreateAttribute("submit");
                    atOpposite = doc.CreateAttribute("opposite");
                    atWilderness = doc.CreateAttribute("wilderness");
                    atTransport = doc.CreateAttribute("transport");
                    atCircumstance = doc.CreateAttribute("circumstance");

                    atSubmit.Value = flower.Submit;
                    atOpposite.Value = flower.Opposite;
                    atWilderness.Value = flower.Wilderness;
                    atTransport.Value = flower.Transport;
                    atCircumstance.Value = flower.Circumstance;

                    elFlower.Attributes.Append(atSubmit);
                    elFlower.Attributes.Append(atOpposite);
                    elFlower.Attributes.Append(atWilderness);
                    elFlower.Attributes.Append(atTransport);
                    elFlower.Attributes.Append(atCircumstance);
                    elFlower.InnerText = flower.InnerText;

                    elChemistry.AppendChild(elFlower);
                }

                elOverall.AppendChild(elChemistry);
            }

            elRoot.AppendChild(elOverall);

            XmlElement elRing = doc.CreateElement("ring");

            XmlAttribute atSpirit = doc.CreateAttribute("spirit");
            XmlAttribute atMist = doc.CreateAttribute("mist");
            atSubmit = doc.CreateAttribute("submit");
            XmlAttribute atUnit = doc.CreateAttribute("unit");
            XmlAttribute atWorker = doc.CreateAttribute("worker");
            XmlAttribute atOffence = doc.CreateAttribute("offence");
            XmlAttribute atEcho = doc.CreateAttribute("echo");

            atSpirit.Value = root.Ring.Spirit;
            atMist.Value = root.Ring.Mist;
            atSubmit.Value = root.Ring.Submit;
            atUnit.Value = root.Ring.Unit;
            atWorker.Value = root.Ring.Worker;
            atOffence.Value = root.Ring.Offence;
            atEcho.Value = root.Ring.Echo;

            elRing.Attributes.Append(atSpirit);
            elRing.Attributes.Append(atMist);
            elRing.Attributes.Append(atSubmit);
            elRing.Attributes.Append(atUnit);
            elRing.Attributes.Append(atWorker);
            elRing.Attributes.Append(atOffence);
            elRing.Attributes.Append(atEcho);

            XmlElement elFolk, elAmbiguity;
            XmlAttribute atDivide, atMuscle, atDevote, atPosition, atCall, atWriter, atActivity, atLead;

            foreach (Folk folk in root.Ring.ListOfFolks)
            {
                elFolk = doc.CreateElement("folk");
                atDivide = doc.CreateAttribute("divide");
                atMuscle = doc.CreateAttribute("muscle");
                atDevote = doc.CreateAttribute("devote");
                atPosition = doc.CreateAttribute("position");
                atCall = doc.CreateAttribute("call");

                atDivide.Value = folk.Divide;
                atMuscle.Value = folk.Muscle;
                atDevote.Value = folk.Devote;
                atPosition.Value = folk.Position;
                atCall.Value = folk.Call;

                elFolk.Attributes.Append(atDivide);
                elFolk.Attributes.Append(atMuscle);
                elFolk.Attributes.Append(atDevote);
                elFolk.Attributes.Append(atPosition);
                elFolk.Attributes.Append(atCall);

                foreach (Ambiguity ambiguity in folk.ListOfAmbiguities)
                {
                    elAmbiguity = doc.CreateElement("ambiguity");
                    atWriter = doc.CreateAttribute("writer");
                    atActivity = doc.CreateAttribute("activity");
                    atLead = doc.CreateAttribute("lead");

                    atWriter.Value = ambiguity.Writer;
                    atActivity.Value = ambiguity.Activity;
                    atLead.Value = ambiguity.Lead;

                    elAmbiguity.Attributes.Append(atWriter);
                    elAmbiguity.Attributes.Append(atActivity);
                    elAmbiguity.Attributes.Append(atLead);
                    elAmbiguity.InnerText = ambiguity.InnerText;

                    elFolk.AppendChild(elAmbiguity);
                }

                elRing.AppendChild(elFolk);
            }

            elRoot.AppendChild(elRing);

            XmlElement elGlass = doc.CreateElement("glass");

            XmlAttribute atBuy = doc.CreateAttribute("buy");
            XmlAttribute atViolation = doc.CreateAttribute("violation");
            XmlAttribute atWorld = doc.CreateAttribute("world");
            XmlAttribute atLetter = doc.CreateAttribute("letter");
            XmlAttribute atBand = doc.CreateAttribute("band");
            XmlAttribute atRise = doc.CreateAttribute("rise");

            atBuy.Value = root.Glass.Buy;
            atViolation.Value = root.Glass.Violation;
            atWorld.Value = root.Glass.World;
            atLetter.Value = root.Glass.Letter;
            atBand.Value = root.Glass.Band;
            atRise.Value = root.Glass.Rise;

            elGlass.Attributes.Append(atBuy);
            elGlass.Attributes.Append(atViolation);
            elGlass.Attributes.Append(atWorld);
            elGlass.Attributes.Append(atLetter);
            elGlass.Attributes.Append(atBand);
            elGlass.Attributes.Append(atRise);

            XmlElement elAssociation, elSeasonal;
            XmlAttribute atThin, atAdult, atLazy, atRain;

            foreach (Association association in root.Glass.ListOfAssociations)
            {
                elAssociation = doc.CreateElement("association");
                atThin = doc.CreateAttribute("thin");
                atAdult = doc.CreateAttribute("adult");
                atLazy = doc.CreateAttribute("lazy");
                atRain = doc.CreateAttribute("rain");

                atThin.Value = association.Thin;
                atAdult.Value = association.Adult;
                atLazy.Value = association.Lazy;
                atRain.Value = association.Rain;

                elAssociation.Attributes.Append(atThin);
                elAssociation.Attributes.Append(atAdult);
                elAssociation.Attributes.Append(atLazy);
                elAssociation.Attributes.Append(atRain);

                foreach (Seasonal seasonal in association.ListOfSeasonals)
                {
                    elSeasonal = doc.CreateElement("seasonal");

                    elSeasonal.InnerText = seasonal.InnerText;

                    elAssociation.AppendChild(elSeasonal);
                }

                elGlass.AppendChild(elAssociation);
            }

            elRoot.AppendChild(elGlass);

            XmlElement elCharge = doc.CreateElement("charge");

            XmlAttribute atConcrete = doc.CreateAttribute("concrete");
            XmlAttribute atMedium = doc.CreateAttribute("medium");
            XmlAttribute atSupport = doc.CreateAttribute("support");
            XmlAttribute atAngry = doc.CreateAttribute("angry");

            atConcrete.Value = root.Charge.Concrete;
            atMedium.Value = root.Charge.Medium;
            atSupport.Value = root.Charge.Support;
            atAngry.Value = root.Charge.Angry;

            elCharge.Attributes.Append(atConcrete);
            elCharge.Attributes.Append(atMedium);
            elCharge.Attributes.Append(atSupport);
            elCharge.Attributes.Append(atAngry);

            XmlElement elChoke, elBloody;
            XmlAttribute atStrike, atPunch, atDisguise, atRadical, atProtein, atLeft, atAwful, atCoincidence, atExpertise, atGood;

            foreach (Choke choke in root.Charge.ListOfChokes)
            {
                elChoke = doc.CreateElement("choke");
                atStrike = doc.CreateAttribute("strike");
                atPunch = doc.CreateAttribute("punch");
                atDisguise = doc.CreateAttribute("disguise");
                atRadical = doc.CreateAttribute("radical");
                atProtein = doc.CreateAttribute("protein");

                atStrike.Value = choke.Strike;
                atPunch.Value = choke.Punch;
                atDisguise.Value = choke.Disguise;
                atRadical.Value = choke.Radical;
                atProtein.Value = choke.Protein;

                elChoke.Attributes.Append(atStrike);
                elChoke.Attributes.Append(atPunch);
                elChoke.Attributes.Append(atDisguise);
                elChoke.Attributes.Append(atRadical);
                elChoke.Attributes.Append(atProtein);

                foreach (Bloody bloody in choke.ListOfBloodies)
                {
                    elBloody = doc.CreateElement("bloody");
                    atLeft = doc.CreateAttribute("left");
                    atAwful = doc.CreateAttribute("awful");
                    atCoincidence = doc.CreateAttribute("coincidence");
                    atTape = doc.CreateAttribute("tape");
                    atExpertise = doc.CreateAttribute("expertise");
                    atGood = doc.CreateAttribute("good");

                    atLeft.Value = bloody.Left;
                    atAwful.Value = bloody.Awful;
                    atCoincidence.Value = bloody.Coincidence;
                    atTape.Value = bloody.Tape;
                    atExpertise.Value = bloody.Expertise;
                    atGood.Value = bloody.Good;

                    elBloody.Attributes.Append(atLeft);
                    elBloody.Attributes.Append(atAwful);
                    elBloody.Attributes.Append(atCoincidence);
                    elBloody.Attributes.Append(atTape);
                    elBloody.Attributes.Append(atExpertise);
                    elBloody.Attributes.Append(atGood);
                    elBloody.InnerText = bloody.InnerText;

                    elChoke.AppendChild(elBloody);
                }

                elCharge.AppendChild(elChoke);
            }

            elRoot.AppendChild(elCharge);

            XmlElement elCut = doc.CreateElement("cut");

            XmlAttribute atGive = doc.CreateAttribute("give");
            XmlAttribute atSentiment = doc.CreateAttribute("sentiment");
            XmlAttribute atRegional = doc.CreateAttribute("regional");
            XmlAttribute atRun = doc.CreateAttribute("run");
            XmlAttribute atTemple = doc.CreateAttribute("temple");
            atTreatment = doc.CreateAttribute("treatment");

            atGive.Value = root.Cut.Give;
            atSentiment.Value = root.Cut.Sentiment;
            atRegional.Value = root.Cut.Regional;
            atRun.Value = root.Cut.Run;
            atTemple.Value = root.Cut.Temple;
            atTreatment.Value = root.Cut.Treatment;

            elCut.Attributes.Append(atGive);
            elCut.Attributes.Append(atSentiment);
            elCut.Attributes.Append(atRegional);
            elCut.Attributes.Append(atRun);
            elCut.Attributes.Append(atTemple);
            elCut.Attributes.Append(atTreatment);

            XmlElement elBible, elCode;
            XmlAttribute atPatch, atAnimal, atCell, atOwner;

            foreach (Bible bible in root.Cut.ListOfBibles)
            {
                elBible = doc.CreateElement("bible");

                foreach (Code code in bible.ListOfCodes)
                {
                    elCode = doc.CreateElement("code");
                    atPatch = doc.CreateAttribute("patch");
                    atAnimal = doc.CreateAttribute("animal");
                    atCell = doc.CreateAttribute("cell");
                    atOwner = doc.CreateAttribute("owner");
                    atAudience = doc.CreateAttribute("audience");

                    atPatch.Value = code.Patch;
                    atAnimal.Value = code.Animal;
                    atCell.Value = code.Cell;
                    atOwner.Value = code.Owner;
                    atAudience.Value = code.Audience;

                    elCode.Attributes.Append(atPatch);
                    elCode.Attributes.Append(atAnimal);
                    elCode.Attributes.Append(atCell);
                    elCode.Attributes.Append(atOwner);
                    elCode.Attributes.Append(atAudience);
                    elCode.InnerText = code.InnerText;

                    elBible.AppendChild(elCode);
                }

                elCut.AppendChild(elBible);
            }

            elRoot.AppendChild(elCut);

            XmlElement elSquad = doc.CreateElement("squad");

            XmlAttribute atWait = doc.CreateAttribute("wait");
            XmlAttribute atActivate = doc.CreateAttribute("activate");

            atWait.Value = root.Squad.Wait;
            atActivate.Value = root.Squad.Activate;

            elSquad.Attributes.Append(atWait);
            elSquad.Attributes.Append(atActivate);

            XmlElement elPudding, elCompensate;

            foreach (Pudding pudding in root.Squad.ListOfPuddings)
            {
                elPudding = doc.CreateElement("pudding");

                foreach (Compensate compensate in pudding.ListOfCompensates)
                {
                    elCompensate = doc.CreateElement("compensate");

                    elCompensate.InnerText = compensate.InnerText;

                    elPudding.AppendChild(elCompensate);
                }

                elSquad.AppendChild(elPudding);
            }

            elRoot.AppendChild(elSquad);

            XmlElement elSubstitute = doc.CreateElement("substitute");

            XmlAttribute atFriendship = doc.CreateAttribute("friendship");
            XmlAttribute atImagine = doc.CreateAttribute("imagine");
            XmlAttribute atShareholder = doc.CreateAttribute("shareholder");

            atFriendship.Value = root.Substitute.Friendship;
            atImagine.Value = root.Substitute.Imagine;
            atShareholder.Value = root.Substitute.Shareholder;

            elSubstitute.Attributes.Append(atFriendship);
            elSubstitute.Attributes.Append(atImagine);
            elSubstitute.Attributes.Append(atShareholder);

            XmlElement elLine, elBowl;

            foreach (Line line in root.Substitute.ListOfLines)
            {
                elLine = doc.CreateElement("line");

                foreach (Bowl bowl in line.ListOfBowls)
                {
                    elBowl = doc.CreateElement("bowl");

                    elBowl.InnerText = bowl.InnerText;

                    elLine.AppendChild(elBowl);
                }

                elSubstitute.AppendChild(elLine);
            }

            elRoot.AppendChild(elSubstitute);

            doc.Save(filename);
        }
    }
}