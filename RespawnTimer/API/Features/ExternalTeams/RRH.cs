#if EXILED
namespace RespawnTimer.API.Features.ExternalTeams
{
    using System;
    using System.Reflection;

    public class SerpentsHandTeam : ExternalTeamChecker
    {
        public override void Init(Assembly assembly)
        {
            PluginEnabled = true;
            
            Type mainClass = assembly.GetType("RRR.Alpha-1_Red-Right-Hand");
            Instance = mainClass.GetField("Instance").GetValue(null);
            FieldInfo = mainClass.GetField("IsSpawnable");
        }
    }
}
#endif
