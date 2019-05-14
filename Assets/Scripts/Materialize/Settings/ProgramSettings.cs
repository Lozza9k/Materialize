#region

using Materialize.General;

#endregion

namespace Materialize.Settings
{
    public class ProgramSettings
    {
        public ProgramEnums.FileFormat FileFormat;
        public int FrameRate;
        public bool HighPrecision;
        public bool HideUiOnRotate;
        public bool FlipNormal;

        public bool PostProcessEnabled;
        public ProgramEnums.PropChannelMap PropBlue;
        public ProgramEnums.PropChannelMap PropGreen;
        public ProgramEnums.PropChannelMap PropRed;
    }
}