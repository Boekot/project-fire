using Content.Shared.Audio;
using Content.Server.AlertLevel;

namespace Content.Server.Light.EntitySystems;
public sealed partial class EmergencyLightSystem
{
    partial void OnAlertLevelChangedFireAdded(EntityUid uid, AlertLevelDetail details)
    {
        if (TryComp<AmbientSoundComponent>(uid, out var ambientSoundComp))
        {
            _ambient.SetSound(uid, details.EmergencyLightSound, ambientSoundComp);
        }
    }
}
