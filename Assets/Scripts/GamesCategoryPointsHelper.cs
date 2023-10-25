using System.Collections.Generic;
using UnityEngine;

public class GamesCategoryPointsHelper : MonoBehaviour
{
    public static int SimulationAndSandbox;
    public static int RealTimeStrategyAndStrategy;
    public static int Shooters;
    public static int MultiplayerOnlineBattleArena;
    public static int RolePlayingGame;
    public static int SportsAndCombatAndRacing;
    public static int PartyGamesAndPuzzles;
    public static int ActionAndAdventure;
    public static int SurvivalAndHorror;
    public static int ForChildrenAndEducation;

    public static void AddPoints(int simulationAndSandbox, int realTimeStrategyAndStrategy, int shooters, 
        int multiplayerOnlineBattleArena, int rolePlayingGame, int sportsAndCombatAndRacing, int partyGamesAndPuzzles,
        int actionAndAdventure, int survivalAndHorror)
    {
        SimulationAndSandbox += simulationAndSandbox;
        RealTimeStrategyAndStrategy += realTimeStrategyAndStrategy;
        Shooters += shooters;
        MultiplayerOnlineBattleArena += multiplayerOnlineBattleArena;
        RolePlayingGame += rolePlayingGame;
        SportsAndCombatAndRacing += sportsAndCombatAndRacing;
        PartyGamesAndPuzzles += partyGamesAndPuzzles;
        ActionAndAdventure += actionAndAdventure;
        SurvivalAndHorror += survivalAndHorror;
    }

    public static Dictionary<string, int> GetCategoriesPointMap()
    {
        var categoriesPointMap = new Dictionary<string, int>
        {
            { "SimulationAndSandbox", SimulationAndSandbox },
            { "RealTimeStrategyAndStrategy", RealTimeStrategyAndStrategy },
            { "Shooters", Shooters },
            { "MultiplayerOnlineBattleArena", MultiplayerOnlineBattleArena },
            { "RolePlayingGame", RolePlayingGame },
            { "SportsAndCombatAndRacing", SportsAndCombatAndRacing },
            { "PartyGamesAndPuzzles", PartyGamesAndPuzzles },
            { "ActionAndAdventure", ActionAndAdventure },
            { "SurvivalAndHorror", SurvivalAndHorror }
        };
        return categoriesPointMap;
    }
}
