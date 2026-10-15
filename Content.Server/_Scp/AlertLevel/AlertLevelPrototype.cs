using Robust.Shared.Audio;

namespace Content.Server.AlertLevel;
public sealed partial class AlertLevelDetail
{
    [DataField] public SoundSpecifier EmergencyLightSound { get; private set; } = new 
    SoundPathSpecifier("/Audio/_Scp/Ambience/Emergency/alarm.ogg");
}
