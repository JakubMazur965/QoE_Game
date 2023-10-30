using System.Collections.Generic;
using System.Linq;
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
            { "Simulation and Sandbox", SimulationAndSandbox },
            { "Real-time strategy (RTS) and Strategy", RealTimeStrategyAndStrategy },
            { "Shooters (FPS and TPS)", Shooters },
            { "Multiplayer online battle arena (MOBA)", MultiplayerOnlineBattleArena },
            { "Role-playing (RPG, ARPG)", RolePlayingGame },
            { "Sports, Combat and Racing", SportsAndCombatAndRacing },
            { "Party Games, Puzzles", PartyGamesAndPuzzles },
            { "Action-adventure", ActionAndAdventure },
            { "Survival and horror", SurvivalAndHorror }
        };
        
        return categoriesPointMap.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
    }

    public static void ShowPointsMap()
    {
        var categoriesPointMap = GetCategoriesPointMap();
        foreach (var kvp in categoriesPointMap)
        {
            Debug.Log("Klucz: " + kvp.Key + ", Wartość: " + kvp.Value);
        }
    }
    
}
