using CRGorman.Demo.SpeedrunData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRGorman.Demo.MigrationService
{
    internal class SeedData
    {
        internal List<Game> Games;

        internal SeedData()
        {
            Games = new List<Game>();
            Game freespace = new()
            {
                Name = "Descent: Freespace - The Great War",
                Description = "Starting somewhere",
                VanityURL = "Freespace",
                Acts = new()
            {
                new()
                {
                    Name = "Darkness Rising",
                    ActNumber = 1,
                    Description = "The slog of a 14 year long war comes to a close with the Ross-128 incident.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "SM1-01A",
                            Name = "Eve of Destruction",
                            Description = "Thirteen 35% PVF Anubis fighters pick a fight with two fresh GTF Apollos and a stationary GTF Fenris.",
                            Guide = "3 Training Missions to Skip\r\n\r\nVictory: Delta Wing arrives.\r\nFlow: Anti-fighter waves.\r\nLoadout: Go with what you have"
                        },
                        new()
                        {
                            FileName = "SM1-02A",
                            Name = "The Field of Battle",
                            Description = "Thirteen more fighters hide in an asteroid field, that you can just skip right over.",
                            Guide = "Campaign File is bugged, jump out immediately and you can skip this entirely."
                        },
                        new()
                        {
                            FileName = "SM1-03A",
                            Name = "Small Deadly Space",
                            Description = "",
                            Guide = "Training Mission to Skip\r\nVictory: Destroy both freighters\r\nFlow: Call in reinforcements, have everyone gang up on freighter 1 while you go after freighter 2.\r\nLoadout: Go with what you have"
                        },

                        new()
                        {
                            FileName = "SM1-04A",
                            Name = "Avenging Angels",
                            Description = "",
                            Guide = "Victory: Omega is captured.\r\nFlow: Order everyone to disable omega and go after omega yourself. Then anti-fighter. The Rasputin is not important.\r\nLoadout: Go with what you have"
                        },
                        new()
                        {
                            FileName = "SM1-05A",
                            Name = "Out of the Dark, Into the Night",
                            Description = "Enter the Shivans",
                            Guide = "Victory: Plato Escape Pod jumps\r\nFlow: One wing of Vasudans to knock out, then order your wingmates to depart. Follow the escape pod, its likely to survive without issue.\r\nLoadout: Go with what you have"
                        },
                        new()
                        {
                            FileName = "SM1-06A",
                            Name = "Paving the Way",
                            Description = "Asteroid Defense vs. GTD Galatea",
                            Guide = "Loadout: Go with what you have"
                        },
                        new()
                        {
                            FileName = "SM1-07A",
                            Name = "Pandora's Box",
                            Description = "Scan Shivan Cargo",
                            Guide = "Victory: Command says \"Alpha wing, we've been set up, its a trap!\"\r\nFlow: Rush forward so the crates detonate.\r\nLoadout: Go with what you have"
                        },
                        new()
                        {
                            FileName = "SM1-08A",
                            Name = "The Hammer and the Anvil",
                            Description = "Avenger Cannon",
                            Guide = "Victory: Shield Transports Jump\r\nFlow: Run escort as needed. When the Vasudans arrive, get in position to take them out.\r\nLoadout: Go with what you have"
                        },
                        new()
                        {
                            FileName = "SM1-09A",
                            Name = "The Darkness and the Light",
                            Description = "",
                            Guide = "Training Mission to Skip\r\n\r\nVictory: Cargo and Ramses is Destroyed\r\nFlow: Order your mates to destroy the Ramses and you go to knock out the cargo. The Taranis is timed (195 seconds from the start), so just do what you can. Then go for the order the destruction of the Ramses, to speed things up.\r\nLoadout: Avenger and Fury."
                        },
                        new()
                        {
                            FileName = "SM1-10A",
                            Name = "First Strike",
                            Description = "",
                            Guide = "Victory: Taranis Jumps\r\nFlow: Call for reinforcements and order Alpha to disarm the Taranis. Wait until the Taranis gets to the edge of the node before disabling it, then keep ordering your mates to attack whatever shows up.\r\nLoadout: Its fine.\r\nTrivia: Your CO is named Col. Sweet Heart."
                        },
                    }
                },
                new()
                {
                    Name = "Lucifer Falls",
                    ActNumber = 2,
                    Description = "With the arrival of the Shivans and an unstable end of the 14 year war brokered, dread comes in the form of the SD Lucifer.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "SM2-01A",
                            Name = "The Aftermath",
                            Description = "",
                            Guide = "Victory: Five seconds after the Pinnacle arrives.\r\nFlow: Escort based on time/destroy all hostiles.\r\nLoadout: Go with what you have"
                        },
                        new()
                        {
                            FileName = "SM2-02A",
                            Name = "The Big Bang",
                            Description = "",
                            Guide = "Victory: Elysium transports jump out, command says \"Scientists are Safe\".\r\nFlow: Lots of strikecraft are around, knock them all out to get the transports to come in. This will be a slog as your loadout is terrible.\r\nLoadout: Locked in."
                        },
                        new()
                        {
                            FileName = "SM2-03A",
                            Name = "La Ruota della Fortuna",
                            Description = "",
                            Guide = "Victory: 15 seconds after all Shivans eliminated.\r\nFlow: Prioritize Bombers, they are easier to hit with the Phoenix. Once the cruisers jump in, join in the bombing run and resupply as needed.\r\nLoadout: Swap for a Medusa, grab the Phoenix V in the second bank and go."
                        },

                        new()
                        {
                            FileName = "SM2-04A",
                            Name = "Where Eagles Dare",
                            Description = "",
                            Guide = "Victory: Taurus, Aries and Kappa are destroyed.\r\nFlow: Blow everything up. When the second group jumps in, ignore the freighters and destroy everything else. Once they're gone, jump safely.\r\nLoadout: Your loadout is fine. Just go."
                        },
                        new()
                        {
                            FileName = "SM2-05A",
                            Name = "Tenderizer",
                            Description = "",
                            Guide = "Victory: Galatea jumps.\r\nFlow: Scan a sentry gun to start the mission, but don't bother wasting ordinance on the fighters that jump in. Blow everything up starting with the second wing and pay attention to when the cruiser jumps in. The Mauler should be disabled, then destroyed since the jump trigger is behind it. The bombers are armed with Stilettos, which can also be ignored.\r\nLoadout: Medusa, Stiletto for the first bank and a pair of Phoenix V."
                        },
                        new()
                        {
                            FileName = "SM2-06A",
                            Name = "Shell Game",
                            Description = "",
                            Guide = "Victory: Stern \"docks\" with Cargo 4.\r\nFlow: Go after the fighters, the freighters are just going to leave and do not matter. Once you get a moment, go find Shivan Cargo 4 (SAC 2) and scan it. Then wait.\r\nLoadout: Same as previous mission."
                        },
                        new()
                        {
                            FileName = "SM2-07A",
                            Name = "Enter the Dragon",
                            Description = "",
                            Guide = "Victory: Bugged Objective, jump out immediately.\r\nFlow: Jump Out.\r\nLoadout: Pre-selected."
                        },
                        new()
                        {
                            FileName = "SM2-08A",
                            Name = "Playing Judas",
                            Description = "",
                            Guide = "Victory: Time, mostly.\r\nFlow: Hoo boy. Fly off to the right of the subspace portal, wait for the Eva to arrive and try to wait where the subspace jump was. Then wait for the Lucifer, scan, get in the docking bay then leave. The debriefing says failure, but it does not matter.\r\nLoadout: Pre-selected."
                        },
                        new()
                        {
                            FileName = "SM2-09A",
                            Name = "Evangelist",
                            Description = "",
                            Guide = "Victory: Jump.\r\nFlow: The campaign bug returns. Jump out immediately.\r\nLoadout: Change Nothing"
                        },
                        new()
                        {
                            FileName = "SM2-10A",
                            Name = "Doomsday",
                            Description = "",
                            Guide = "Victory: 15 Seconds after the GTD Galatea is destroyed.\r\nFlow: Focus on Bheema (Nephilim) and Rama (Manticore), then run away. You cannot win. Use the Phoenix you are carrying to speed this up.\r\nLoadout: Same as SM2-06A."
                        },
                    }
                },
                new()
                {
                    Name = "Ancient Mysteries",
                    ActNumber = 3,
                    Description = "Vasuda Prime is glass, your home is dust, and Terra Prime is next. Xenoscientists pull a last ditch effort to find a weakness.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "SM3-01A",
                            Name = "Exodus",
                            Description = "",
                            Guide = "Victory: Zeta wing arrives.\r\nFlow: Just blow up whatever comes around. Once the Cains jump in, let your Prometheus cannons scream. The Banshee is just useless. When the Mecross jumps in, order everyone to protect it.\r\nLoadout: Prometheus and Phoenix V."
                        },
                        new()
                        {
                            FileName = "SM3-02A",
                            Name = "Last Hope",
                            Description = "",
                            Guide = "Victory: Mu relieves you of your watch.\r\nFlow: This one is long. For reference, the Isis repair ship takes 446 seconds after docking to get the engines back and running. The trigger, however, sits behind the destruction of Kali and Rama wings, which cause Mu to come in to relieve you.\r\nLoadout: Your loadout is going to be weird. Medusa, Prometheus, two banks of Phoenix V and one bank of Hornets."
                        },
                        new()
                        {
                            FileName = "SM3-03A",
                            Name = "A Failure to Communicate",
                            Description = "",
                            Guide = "Victory: Hope Dismisses you.\r\nFlow: Fly forward with haste. Two Dragons labeled Deva are your targets, which appear out of the Lucifer's fighter bay. After that focus on bombers that come in and anything else with your ordinance.\r\nLoadout: Pre-selected."
                        },

                        new()
                        {
                            FileName = "SM3-04A",
                            Name = "Reaching the Zenith",
                            Description = "",
                            Guide = "Victory: Auto-Jump.\r\nFlow: Knock out the cruisers Benedict and Zenith.\r\nLoadout: Grab a Hercules, Prometheus and Phoenix V."
                        },
                        new()
                        {
                            FileName = "SM3-05A",
                            Name = "Running the Gauntlet",
                            Description = "",
                            Guide = "Victory: Omega 1 Jumps.\r\nFlow: Intercept for days. The Lucifer should be ignored, of course.\r\nLoadout: Same as Previous."
                        },
                        new()
                        {
                            FileName = "SM3-06A",
                            Name = "Black Omega",
                            Description = "",
                            Guide = "Victory: Omega 1 Jumps.\r\nFlow: Get your fighters to focus on Omega 1, while Alpha knocks over the Anvil. Then cover the transport and get out of there. Don't worry about Omega 2.\r\nLoadout: Get some extra bombs in there."
                        },
                        new()
                        {
                            FileName = "SM3-07A",
                            Name = "Clash of the Titans",
                            Description = "",
                            Guide = "Victory: GTD Bastion Jumps.\r\nFlow: You are escorting the GTD Bastion, and it is best to just run intercept. Take out the two snout mounted turrets and the one on the underbelly to give the Bastion a better chance. This one is a bit of a reset point.\r\nLoadout: Give yourself the Hercules Phoenix combo."
                        },
                        new()
                        {
                            FileName = "SM3-08A",
                            Name = "The Great Hunt",
                            Description = "",
                            Guide = "Victory: Auto-Jump.\r\nFlow: DO NOT GO INTO THE NODE WITHOUT FULL ORDINANCE! You want it later. Tell your mates to shoot at everything not destroyer shaped and once the Ursas jump in, enter the node and call it done. Episilon arrives 180 seconds after the Ursas come, but you would be wasting time waiting for them.\r\nLoadout: Ursa, Disruptor, Prometheus and Harbinger."
                        },
                        new()
                        {
                            FileName = "SM3-09A",
                            Name = "Good Luck",
                            Description = "",
                            Guide = "Victory: SD Lucifer Reactors Destroyed.\r\nFlow: Go after Reactor 5. The other Ursas are pre-programmed to hit 1-4 by themselves, so you might as well finish the job.\r\nLoadout: Same as previous."
                        },
                        new()
                        {
                            FileName = "SM3-10A",
                            Name = "The Credits",
                            Description = "",
                            Guide = ""
                        },
                    }
                },
            }
            };

            Game silentThreat = new()
            {
                Name = "Descent: Freespace - Silent Threat",
                Description = "Boring...",
                VanityURL = "SilentThreat",
                Acts = new()
            {
                new()
                {
                    Name = "Hades Rebellion",
                    ActNumber = 1,
                    Description = "While the Shivans wreak havoc upon the galaxy, rogue elements of the GTI seek to disrupt the shakey Terran-Vasudan alliance.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "MD-01",
                            Name = "Silence All Voices",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-02",
                            Name = "The Pursuit",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-03",
                            Name = "Ghosts",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-04",
                            Name = "On the Run",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-05",
                            Name = "Hellfire",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-06",
                            Name = "Secret Recovery",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-07",
                            Name = "Cloak and Dagger",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-08",
                            Name = "Field of Destruction",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-09",
                            Name = "Exodus",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-10",
                            Name = "The Return to Ross 128",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-11",
                            Name = "The Wait",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "MD-12",
                            Name = "Secrets Revealed",
                            Description = ""
                        },
                    }
                },
            }
            };

            Game operationTemplar = new()
            {
                Name = "Freespace 2 - Operation Templar",
                Description = "Hammer the Hammer of Light",
                VanityURL = "OperationTemplar",
                Acts = new()
            {
                new()
                {
                    Name = "Operation Templar",
                    ActNumber = 1,
                    Description = "As the end of the Lucifier conflict has passed, the GTA seeks to solidify their alliance with the PVE by eliminating the last refuges of the Hammer of Light.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "Templar-01",
                            Name = "Bringing The Hammer Down",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "Templar-02",
                            Name = "Chasing the Threat",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "Templar-03",
                            Name = "Tightening the Noose",
                            Description = ""
                        },
                        new()
                        {
                            FileName = "Templar-04",
                            Name = "Final Outpost",
                            Description = ""
                        }
                    }
                },
            }
            };

            Game freespace2 = new()
            {
                Name = "Freespace 2",
                Description = "The Capella Conflict",
                VanityURL = "Freespace2",
                Acts = new()
            {
                new()
                {
                    Name = "The Neo-Terran Front",
                    ActNumber = 1,
                    Description = "32 Years after the end of the great war, elements of the former GTI rebel against the newly forged Galactic Terran Vasudan Alliance while a dormant enemy lies beyond the Capella system.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "SM1-01",
                            Name = "Surrender, Belisarius!",
                            Description = "",
                            Guide = "Three Training Missions to Skip\r\n\r\nVictory: 15 seconds after Belisarius is destroyed, at about 5:30 clock.\r\nFlow: TC to 4x and just let go, you may have to deal with remnants.\r\nLoadout: No Change"
                        },
                        new()
                        {
                            FileName = "SM1-02",
                            Name = "The Place of Chariots",
                            Description = "",
                            Guide = "Victory: No time after the Iceni Jumps. Command needs to say you can leave from all the strikecraft.\r\nFlow: Start at 4x, Ignore the freighters, wipe out hostile strikecraft, fly towards the Iceni, kill reinforcement strikecraft (7 seconds after both Pisces and Virgo are destroyed) to get the triggers to flow then jump when the Iceni does.\r\nLoadout: All Rockeyes\r\nTrivia: Aken H. Bosch's war crimes include\r\n\t§ \"Drunk on Butt from Bosch Beer\"\r\n\t§ \"No permit for lemondate stand\"\r\n\t§ \"Not blaming Aken\"\r\n\t§ \"Stockpiling Bosch Beer\""
                        },
                        new()
                        {
                            FileName = "SM1-03",
                            Name = "The Romans Blunder",
                            Description = "",
                            Guide = "Victory: Destroy all fighters, plus the Glorious and Impervious.\r\nFlow: 4x, Don't bother chasing the Iceni, give your mates orders to form on you to hang back and wait for the reinforcements. Get both freighters to below 65% and pelt Gemini until its down to half strength. When Scorpio and Aquarius jump in, destroy at least two of each wing to permit the Psamtik to jump in and give you fire support. Clean up by knocking out the Glorious first, then the Impervious. Use wingmen to assault fighters as needed.\r\nLoadout: Scramble mission."
                        },

                        new()
                        {
                            FileName = "SM1-04",
                            Name = "A Lion at the Door",
                            Description = "",
                            Guide = "Two Training Missions to Skip\r\n\r\nVictory: All hostiles either leave or are destroyed.\r\nFlow: 4x and abuse the harpoons. Knockout the escort fighters first with your wingmen, then order them to kill the Behemoth. Hornet missiles will overwhelm it quickly, so make use of them. Afterwards, some freighters will annoy you. Focus the wingmen to end them quickly and get them out of the way. Four wings will jump in after, knock them out as fast as possible to prepare for the Carthage and Dahshor. Once you have your reinforcements, deal with the Seraphim bombers, remaining fighters and finally the Goliath.\r\nLoadout: Change nothing."
                        },
                        new()
                        {
                            FileName = "SM1-05",
                            Name = "Mystery of the Trinity",
                            Description = "",
                            Guide = "Victory: Four seconds after the NTF Trinity is destroyed.\r\nFlow: 4x from go. You can sequence break this one. Immediately take off and fly on the right edge of the \"knob\", pitched up just enough to get over what's in front of you. Command will complain a lot, but as long as you take off fast enough the mission won't fail. Go full engines and burn until you run into Shivans, keep going until you get a pink dot for the Trinity. Once you can target, open up with everything to destroy it and get it under 30% before it's IFF turns green. Once its hull hits 0, jump.\r\nLoadout: Change nothing."
                        },
                        new()
                        {
                            FileName = "SM1-06",
                            Name = "The Great Hunt",
                            Description = "",
                            Guide = "Victory: GTCv Lysander is destroyed by the Shivans.\r\nFlow: 4x, Afterburn straight ahead to start the fight versus two wings of enemies. Follow radar dots for more enemies, and be sure to knock out bombers as they appear.\r\nLoadout: More subachs, but you can get back to using harpoons. Hornets are default."
                        },
                        new()
                        {
                            FileName = "SM1-07",
                            Name = "Slaying Ravana",
                            Description = "",
                            Guide = "Victory: SD Ravana is destroyed.\r\nFlow: 4x, Your only real target is the destroyer. Get in there and shut her down via targeting weapons.\r\nLoadout: Subachs, plus make sure to load 2/3 cyclops on everyone, with the last being hornets."
                        },
                        new()
                        {
                            FileName = "SM1-08",
                            Name = "The Sixth Wonder",
                            Description = "",
                            Guide = "One Training Mission to Skip\r\n\r\n(Enter the Colossus)\r\nVictory: Colossus destroys the Cato and Hawkwood\r\nFlow: 4x, have your wingmates go on the Cato just to get it out of the way. Destroy the loitering Hercs, then fly intercept. Once the Hawkwood jumps in destroy the two mounted front beam cannons. The Colossus jumps in at 5:00 and will cleanup the rest.\r\nLoadout: Subachs, Harpoons."
                        },
                        new()
                        {
                            FileName = "SM1-09",
                            Name = "Into the Maelstrom",
                            Description = "",
                            Guide = "Victory: Time elapses on the escort.\r\nFlow: 4x, Run intercept, especially on the incoming bombers. Once the cruiser jumps in, just tell your teammates to handle it, and deal with the lingering bombers yourself. Colossus jumps in at 7 minutes.\r\nLoadout: Subachs, change nothing else."
                        },
                        new()
                        {
                            FileName = "SM1-10",
                            Name = "Feint! Parry! Riposte!",
                            Description = "",
                            Guide = "Victory: The Repulse crashes into the Colossus.\r\nFlow: Engage Enemy. Deal with the fighters in the forward group, then rush the Majestic and Refute. Fire a set of missiles at the remaining Hercules as soon as its within range then run. Once the strikecraft are down, you will be authorized to return.\r\nLoadout: Stick to the Perseus as you will want the speed, Harpoons"
                        },
                    }
                },
                new()
                {
                    Name = "Colossal Firepower",
                    ActNumber = 2,
                    Description = "With the NTF on the run, the GTVA pushes into the nebula to find the extent of the second Shivan invasion.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "SM2-01",
                            Name = "Battle of the Wilderness",
                            Description = "",
                            Guide = "Skip the SOC Loop\r\n\r\nVictory: Destroy all shivans, wait to about 9:55.\r\nFlow: 4x, fly straight ahead at full burn to find Scorpio Wing. Call in Beta Wing for reinforcements, but hold on Zeta until the Cain cruiser shows up. Destroy everything, then pummel the cruiser. You will have minutes of waiting at the end.\r\nLoadout: Subach and Harpoons"
                        },
                        new()
                        {
                            FileName = "SM2-02",
                            Name = "A Game of TAG",
                            Description = "",
                            Guide = "Victory: Destroy all shivans.\r\nFlow: This mission is a mess and TC will be of no real help since you're outgunned like crazy. Immediately call back Alpha 2 to protect the Warspite. Your loadout will be pretty much the Subach and nothing else. The TAG warhead is dumbfire and would be much more interesting if the Warspite could hit anything beyond 500m. Chug your way through the fighters and bombers as best you can, shivan reinforcements are on previous wing's destruction, or a very long timer. Tag whatever you can, but don't rely on it. You can use some TC to get opposing strikecraft to close the distance to you sooner.\r\nLoadout: Pre-selected. Ugh."
                        },
                        new()
                        {
                            FileName = "SM2-03",
                            Name = "Proving Grounds",
                            Description = "",
                            Guide = "Victory: Aquitaine Jumps.\r\nFlow: 4x, Find the Oberon, close to 900m, remove targeting then unload all your Tempests into it to fail the test much faster. After that some bombers jump in to cause trouble, so switch to 1x or 2x and dispatch them. This will start the clock of Aquitaine leaving. Tiamat will come later, and needs to have its main beam canon knocked out to give the Aquitaine a better chance.\r\nLoadout: Perseus, Subach and Tempest + Harpoons for Alpha."
                        },

                        new()
                        {
                            FileName = "SM2-04",
                            Name = "The King's Gambit",
                            Description = "",
                            Guide = "Victory: Destroy at least 4 warships, escapees will slow the mission down.\r\nFlow: Bomb everything. Keep giving alpha orders to hit whatever ship you're on. Six warships will arrive in sequence with escort, starting at 8 seconds with the Uhuru. It will jump out 65 seconds later; use two banks of Cyclops on it then book it for the node. After its destruction or escape, Pax arrives 22 seconds and leaves after 90; use two banks on this, then issue a rearm order to yourself as this will be the longest break you get. Liberty arrives 39 after the previous leaves and departs 60 seconds after. Inspiration, a cargo ship, is 6 seconds after Liberty. Undaunted arrives 10 seconds after the previous leaves and departs 70 seconds later. While Perseverance arrives 35 seconds after the Undaunted. You'll have 29 seconds to knock out the transport before it has help, so fight as hard as you can. Once the Perseverance sinks, count to three and jump.\r\nGive Beta orders to knock out interceptors/fighters while giving alpha/gamma bombing runs. It may be easier to set all wings to destroy the warships while individually ordering Beta to deal with the escort.\r\nLoadout: Switch to the Boanerges for the extra payload. Add Prometheus S cannon and full Cyclops."
                        },
                        new()
                        {
                            FileName = "SM2-05",
                            Name = "The Sicilian Defense",
                            Description = "",
                            Guide = "Victory: Destroy all NTF warships.\r\nFlow: 4x, throw bombs at everything! Arrival pits you against the Vindicator (Destroyer) and the Venture (Transport). Go hard on the Vindicator first, as 8 seconds after its destroyed the Yoshitomo arrives. Do your best to ignore/avoid the Venture, as beta will likely sink it and its blast tends to do a lot of damage. After the Yoshitomo is sunk, 15 seconds after that you get the Alba. This may be your only useful time to rearm. After comes the Epigoni and once its hull hits 0, you can leave immediately. When all of them are destroyed, you can leave after 15 game seconds. Count to four then jump.\r\nLoadout: Somehow Alpha is not using any bombs. FIX THAT by throwing in the Boanerges on all four with Prometheus S and a pair of Cyclops in the lower banks."
                        },
                        new()
                        {
                            FileName = "SM2-06",
                            Name = "Endgame",
                            Description = "",
                            Guide = "Victory: Iceni jumps.\r\nFlow: Tell your wingmates to protect the monitor. Knock out bombers as they come in to get some breathing room, as the Loyola jumps in after 44 seconds. Give the capital ships orders to attack the Loyola. The trigger for the next ship is 128 seconds behind it, so you will need to prioritize its destruction to get a good time. 151 seconds after the start comes the Colossus, which at that point you will need to stop giving orders. The Danton comes in after no matter what, which the Colossus will do most of the work on, but you should shoot at it anyway and tell the capital ships to jump in on it. 8 Seconds after the Danton sinks, the Iceni will run the blockade. Jump out when command authorizes.\r\nLoadout: Hercules and Harpoons.\r\nRecord: 6:25\r\nTriggers:\r\n\t§ Colossus at 2:30\r\n\t§Danton at 4:05"
                        },
                        new()
                        {
                            FileName = "SM2-07",
                            Name = "The Fog of War",
                            Description = "Enter Sathanas 01",
                            Guide = "Victory: Six seconds after Sathanas 01 destroys Tatenen (GVCv Sobek).\r\nFlow: Ignore the sentries and fighters, instead pulverize the gas miners. To help along the way, order your wingmates to take down a miner while you find the next one. Repeat until all are down, then give an all protect the Tatenen order. Focus on Aries and Gemini wings, who when both are destroyed cause the Sathanas to jump in. When Tatenen's health hits 0, you can leave, don't wait for command to dismiss you.\r\nLoadout: Surprisingly your loadout is good. Replace your missiles with harpoons."
                        },
                        new()
                        {
                            FileName = "SM2-08",
                            Name = "A Monster in the Mist",
                            Description = "",
                            Guide = "Victory: Scan all four subsystems.\r\nFlow: Scan in order based on what targeting says. Jump once you get all 4, by the time the animation finishes the event to leave will have fired.\r\nLoadout: Don't bother changing anything."
                        },
                        new()
                        {
                            FileName = "SM2-09",
                            Name = "Speaking in Tongues",
                            Description = "",
                            Guide = "Victory: The Golab is destroyed.\r\nFlow: 4x, Rush the Rephaim with whatever you have, as when it is weak or destroyed the Thaumiel will jump in. It is likely this will happen before your bombers are available as reinforcements. 45 Seconds after the Thaumiel is destroyed, the Golab jumps in. Jump out four seconds after the Golab is destroyed.\r\nLoadout: Alpha wing needs help. Replace the Mekhu with the Prometheus and the TAG-B with Hornets. Apply to all, then replace yourself with Harpoons. Beta could also use help, replace the Mekhu with Prometheus and one bank of Tornados with Hornets."
                        },
                        new()
                        {
                            FileName = "SM2-10",
                            Name = "A Flaming Sword",
                            Description = "Knossos Destruction",
                            Guide = "Victory: The moment the Sathanas 01 starts to jump in.\r\nFlow: 4x, This one is very different to the no TC version. Once arrived, give a \"Protect my Target\" order (C-3-5) on the Revenant. Head for the Maras, then run away to increase the available firepower. Once the first Meson is undocked, change back to 1x or the triggers will not function in order (and you'll be swarmed by Dragons). Call in a support ship to rearm, then wait and engage enemy fighters as they appear. Once you destroy all 12 Pisces, you are done.\r\nLoadout: Give yourself Prometheus and Harpoons, then apply to all wingmates."
                        },
                    }
                },
                new()
                {
                    Name = "Supernova",
                    ActNumber = 3,
                    Description = "The clash of the GTVA Colossus and the SJ Sathanas serves as the pinnacle of military power, while the mysteries of the nebula expand their reach.",
                    Missions = new List<Mission>()
                    {
                        new()
                        {
                            FileName = "SM3-01",
                            Name = "Bearbaiting",
                            Description = "",
                            Guide = "Victory: Beleth is sunk and all of Gemini is destroyed, or the Beleth escapes.\r\nFlow: You know this one. 2x, Double up the Helios, knock out two forward turrets, call for resupply, knock out the other two and get out of the way. 4x, Rearm again, and the Beleth will shortly follow. Let it get away and you can jump out sooner, as it matters not weather it survives.\r\nLoadout: Pre-selected."
                        },
                        new()
                        {
                            FileName = "SM3-02",
                            Name = "High Noon",
                            Description = "Watch Colossus and Sathanas 01 fight",
                            Guide = "Victory: Sathanas 01 is destroyed.\r\nFlow: Provided the previous went well, set to 4x and just wait out the engagement. You can destroy the fighters if you want something to do. Once Sathanas 01 goes to 0 HP, immediately jump to avoid the explosion.\r\nLoadout: Pre-selected.\r\n"
                        },
                        new()
                        {
                            FileName = "SM3-03",
                            Name = "Return to Babel",
                            Description = "",
                            Guide = "Victory: Eight seconds after the Iceni self-destructs.\r\nFlow: 4x, Triggers are tied to the cruisers being destroyed, so prioritize them. Fly straight ahead, as your first cruiser is a dot slightly off to the left of your radar. Once found, have all wings destroy it, while you go search for the other cruiser (on the other side of the Iceni). Fire with the Maxim and then retarget your wingmen once they become available. The Qeb will be launched, while you want your wingmates to protect the Iceni as nobody will target the Qeb. After that run intercept until its over.\r\nLoadout: Give yourself a Tauret with Trebuchets, focus on bombers as they come. "
                        },

                        new()
                        {
                            FileName = "SM3-04",
                            Name = "Straight, No Chaser",
                            Description = "",
                            Guide = "Victory: Three seconds after the Sathanas 02 destroys the Psamtik.\r\nFlow: Fly straight ahead to find the second Knossos device. The Dahaka and Sephiroth are your main goals and are already on station when you jump in. When both are sunk, the Psamtik will jump in. You have 109 seconds to close to 3000 of it, which will trigger Sathanas 02 to enter.\r\nLoadout: Hoo boy. Replace your Aketons with Prometheus, all wings it and then you'll be fine."
                        },
                        new()
                        {
                            FileName = "SM3-05",
                            Name = "Argonautica",
                            Description = "",
                            Guide = "Victory: Three seconds after the Aquitaine leaves.\r\nFlow: This is all about time. 250 seconds after the mission starts, the Agrippa will jump in with the Argo. When the Argo docks with the Aquitaine, the ship will come online 40 seconds later and proceed to the node. You have about four minutes until it jumps, and then you can leave.\r\nLoadout: Use the Taruet and Trebuchets."
                        },
                        new()
                        {
                            FileName = "SM3-06",
                            Name = "Exodus",
                            Description = "",
                            Guide = "Skip the SOC Loop\r\n\r\nVictory: Timed Escort, Lambda 1 and 2 and the Vesalius must survive.\r\nFlow: STOP. Call in reinforcements immediately, use the Trebuchets to knock out all the bombers. This mission is too complicated for 4x, so stick to 1x or 2x as long as bombers are around. Order everyone to protect Lambda 1. The Sulla is the only ship you can lose, so you can safely ignore it. Fly intercept, then once the three (or four) listed ships jump you can leave. The corvette is at critical health, so don't worry about losing it.\r\nLoadout: Hercules, load up with Trebuchets."
                        },
                        new()
                        {
                            FileName = "SM3-07",
                            Name = "Dunkerque",
                            Description = "",
                            Guide = "Victory: 30 seconds after Lambda 2 docks with Messana, command says \"Well Done\".\r\nFlow: Lucky for us, no warships. Call in Delta immediately. Its mostly time, but the trigger for Lambda 2 is behind Lambda 1 leaving/is destroyed. Ignore Lambda 1, and run intercept otherwise. Order your mates to protect the Masana, and then one wing the Lambda 2 whenever it arrives. When it seems like there's a long break, get everyone on Lambda 1 and get close. One random bomber will attempt to give you defeat from the jaws of victory.\r\nLoadout: Hercules and Trebuchets, Kayser, Maxim and harpoons for all.\r\nTrivia: We're up to Sathanas 71!\r\n"
                        },
                        new()
                        {
                            FileName = "SM3-08",
                            Name = "Their Finest Hour",
                            Description = "",
                            Guide = "Victory: 22 Seconds after Sathanas 17 destroys the Colossus.\r\nFlow: This a mess of warships. 4x, Asmodeus 2 (A freighter) triggers the Demogorgon, Demogorgon triggers the Ball, Hela and Ball triggers the Orcus, the Orcus triggers the Beast, the Beast triggers Sathanas 17. The Beast will be a pain, since you won't have bombs to work with and it jumps in really far away. \r\nLoadout: Maxim and Trebuchet."
                        },
                        new()
                        {
                            FileName = "SM3-09",
                            Name = "Clash of the Titans II",
                            Description = "",
                            Guide = "Victory: No jump is needed, the mission ends on its own.\r\nFlow: 4x Protect the Bastion, as the only speed strategy is to keep its engines at max. The Shivans will be carrying \"Mega Bombs\" which are one shot lethal vs. you, so keep away from them. Suggest group fire everything otherwise you'll be slamming the switch weapon key every 10 seconds.\r\nLoadout: Switch in the Ares for Alpha if you did the SOC Loop, otherwise Hercules, Maxim + Kayser, Trebuchet + Trebuchet. Removing Beta 2 and 3 from the list does not affect the mission speed. Beta and Gamma will not survive, so don't bother giving them loadout considerations."
                        },
                        new()
                        {
                            FileName = "SM3-10",
                            Name = "Apocalypse",
                            Description = "",
                            Guide = "Victory: Jump out at the Vega node.\r\nFlow: Engines to max, get to Vega and Jump out. The mission is marked as complete either way.\r\nLoadout: Previous mission."
                        },
                    }
                },
            }

            };

            Games = new() { freespace, silentThreat, operationTemplar, freespace2 };
        }
    }
}
