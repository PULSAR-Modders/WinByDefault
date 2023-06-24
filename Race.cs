using HarmonyLib;

namespace Win_by_default
{
    [HarmonyPatch(typeof(PLRace), "Update")]
    internal class Race
    {
        static void Prefix(PLRace __instance, PLRaceEncounterBase ___MyRacingEncounter)
        {
            if (__instance.InProgress && PLNetworkManager.Instance.LocalPlayer.GetPhotonPlayer().IsMasterClient && ___MyRacingEncounter != null && ___MyRacingEncounter.GetRacers() != null)
            {
                int opponentCount = 0;
                foreach (PLShipInfoBase ship in ___MyRacingEncounter?.GetRacers())
                {
                    if (ship != null && ship != PLEncounterManager.Instance.PlayerShip)
                    {
                        opponentCount++;
                    }
                }
                if (opponentCount == 0)
                {
                    PLEncounterManager.Instance.PlayerShip.CompletedLaps = PLEncounterManager.Instance.PlayerShip.CurrentRace.Laps;
                }
            }
        }
    }
}
