using TwitchIntegration;

public class TwitchSpawner : TwitchMonoBehaviour
{
    private void OnEnable()
    {
        TwitchManager.OnTwitchMessageReceived += TwitchManager_OnTwitchMessageReceived;
    }

    private void TwitchManager_OnTwitchMessageReceived(TwitchUser user, string arg2)
    {
    }
}
