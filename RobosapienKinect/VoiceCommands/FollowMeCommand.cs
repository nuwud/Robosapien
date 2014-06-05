namespace Com.Enterprisecoding.RobosapienKinect.VoiceCommands {
    internal sealed class FollowMeCommand : VoiceCommandBase {
        public const string COMMAND_NAME = "follow me";

        public FollowMeCommand() : base(COMMAND_NAME) { }

        public override void Execute() {
            RoboManager.Instance.FollowUp = true;
        }
    }
}
