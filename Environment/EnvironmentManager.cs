using System.Collections.Generic;

namespace LlamaFS.ENV;

public class EnvironmentManager
{
    //I LOVE SINGLETONS
    public static EnvironmentManager Instance { get; } = new();

    protected Dictionary<int, VirtualEnvironment> AllEnvs = new();

    public EnvironmentManager() { }

    public VirtualEnvironment GetOrCreateEnvironment(int UUID)
    {

        if (AllEnvs.ContainsKey(UUID))
        {
            //Todo: logging callback
            return AllEnvs[UUID];
        }

        //Todo: Logging callback

        VirtualEnvironment temp = new(UUID);
        AllEnvs.Add(UUID, temp);
        return temp;
    }
}