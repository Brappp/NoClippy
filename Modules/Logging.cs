using ImGuiNET;

namespace NoClippy
{
    public partial class Configuration
    {
        public bool LogToChat = false;
    }
}

// This is a module because why not
namespace NoClippy.Modules
{
    public class Logging : Module
    {
        public override int DrawOrder => 8;

        public override void DrawConfig()
        {
            ImGui.Columns(2, null, false);

            if (ImGui.Checkbox("Output to Chat Log", ref NoClippy.Config.LogToChat))
                NoClippy.Config.Save();
            PluginUI.SetItemTooltip("Sends logging to the chat log as an echo instead.");

            ImGui.Columns(1);
        }
    }
}
