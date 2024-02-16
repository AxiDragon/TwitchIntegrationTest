using TwitchIntegration;
using UnityEngine;

public class ColorSetter : TwitchMonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public TrailRenderer trailRenderer;

    [TwitchCommand("color", "c")]
    public void SetColor(string hexCode)
    {
        ColorUtility.TryParseHtmlString(hexCode, out Color color);

        if (color != null)
        {
            spriteRenderer.color = color;
            trailRenderer.startColor = color;
            trailRenderer.endColor = color;
        }
    }
}
