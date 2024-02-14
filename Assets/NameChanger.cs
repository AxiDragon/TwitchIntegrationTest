using TMPro;
using TwitchIntegration;

public class NameChanger : TwitchMonoBehaviour
{
    public TMP_Text textMesh;

    [TwitchCommand("change_name", "name", "n")]
    public void ChangeName(string newName)
    {
        textMesh.text = newName;
    }
}
