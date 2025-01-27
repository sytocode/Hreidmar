using ImGuiNET;

namespace Hreidmar.GUI.Windows
{
    public class AboutWindow : Window
    {
        /// <summary>
        /// Draw the About window
        /// </summary>
        public override void Draw()
        {
            var opened = true;
            if (ImGui.Begin("About", ref opened, ImGuiWindowFlags.AlwaysAutoResize)) {
                ImGui.Text("Hreidmar is an open-source Odin/Heimdall alternative.");
                ImGui.Text("Licence: Mozilla Public License 2.0");
                ImGui.Text("GitHub: Samsung-Loki/Hreidmar");
                ImGui.Separator();
                ImGui.Text($"Hreidmar GUI is an ImGui.NET frontend.");
                ImGui.Text($"Enigma Engine is Odin protocol implementation.");
                ImGui.Separator();
                ImGui.Text($"Running Hreidmar GUI version {typeof(Window).Assembly.GetName().Version}");
                ImGui.Text($"Running Enigma Engine version {typeof(Window).Assembly.GetName().Version}");
                ImGui.End();
            }
            if (!opened) Close();
        }
    }
}